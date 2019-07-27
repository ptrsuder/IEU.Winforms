using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using DynamicData;
using ReactiveUI;
using ImageEnhancingUtility.Core;
using GitHubUpdate;

//TODO:
//ask to change all paths when changing ESRGAN path
//change VerifyPaths?
//settings for output formats
//transfet AllInOneStep method to Core

namespace ImageEnhancingUtility.Winforms
{
    public partial class MainForm : Form, IViewFor<IEU>
    {
        public readonly string AppVersion = "0.9.04";
        public readonly string GitHubRepoName = "IEU.Winforms";

        public IEU ViewModel { get; set; }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (IEU) value;
        }

        private MyTreeView treeView1;

        List<ModelInfo> checkedModels = new List<ModelInfo>();       

        Dictionary<string, int> outputDestinationModes;
        Dictionary<string, int> outputDestinationModesSingleModel;
        Dictionary<string, int> overwriteModes;
        List<TextBox> pathsTextBoxes;

        private ImageFormatInfo _selectedOutputFormat;
        public ImageFormatInfo SelectedOutputFormat
        {
            get => _selectedOutputFormat;
            set => _selectedOutputFormat = value;
        }

        int lastCheckedModelsCount = 0;        
        bool lastUseDifferentModelAlpha = false;
        
        public string RichBoxText
        {
            get => "";
            set
            {
                WriteToLogsThreadSafe(value);
            }
        }

        private delegate void SafeCallDelegate(string text);
        private delegate void SafeCallDelegateWithColor(string text, System.Drawing.Color color);

        private void WriteToLogsThreadSafe(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteToLogsThreadSafe);
                Invoke(d, new object[] { text });
            }
            else
                richTextBox1.Text = text;
                //richTextBox1.AppendText($"\n[{DateTime.Now}] {text}", System.Drawing.Color.White);
        }
        private void WriteToLogsThreadSafe(string text, System.Drawing.Color color)
        {
            if (richTextBox1.InvokeRequired)
            {
                var d = new SafeCallDelegateWithColor(WriteToLogsThreadSafe);
                Invoke(d, new object[] { text, color });
            }
            else
                richTextBox1.AppendText($"\n[{DateTime.Now}] {text}", color);
        }

        public int ProgressBarValue
        {
            get => 0;
            set
            {
                ReportProgressThreadSafe(value);
            }
        }

        private delegate void SafeCallDelegate2(int value);
        private void ReportProgressThreadSafe(int value)
        {
            if (progressBar1.InvokeRequired || progress_label.InvokeRequired)
            {
                var d = new SafeCallDelegate2(ReportProgressThreadSafe);
                Invoke(d, new object[] { value })
;
            }
            else
            {                
                progressBar1.Value = value;
                progress_label.Text = $@"{ViewModel.filesDone}/{ViewModel.filesNumber}"; //hack
                progressFiltered_label.Text = ViewModel.filesDoneSuccesfully.ToString();
            }
        }

        public List<ModelInfo> ModelsItems
        {
            get => null;
            set => CreateModelTree(value);
        }

        [DllImport("user32.dll")] //textbox hint
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public MainForm()
        {
            InitializeComponent();
            CreateMyTreeView();
            treeView_contextMenuStrip.Items[0].Click += OpenModelFolder;

            FormClosing += MainForm_FormClosing;
            
            #region #MAIN_TAB

            outputDestinationModes = new Dictionary<string, int>();
            outputDestinationModes.Add("Folder for each image", 1);
            outputDestinationModes.Add("Folder for each model", 2);

            outputDestinationModesSingleModel = new Dictionary<string, int>();
            outputDestinationModesSingleModel.Add("Default", 0);
            outputDestinationModesSingleModel.Add("Preserve folder structure", 3);
            outputDestinationModesSingleModel.Add("Folder for each image", 1);
            outputDestinationModesSingleModel.Add("Folder for each model", 2);

            outputDestinationMode_comboBox.DataSource = new BindingSource(outputDestinationModesSingleModel, null);
            outputDestinationMode_comboBox.DisplayMember = "Key";
            outputDestinationMode_comboBox.ValueMember = "Value";
            outputDestinationMode_comboBox.SelectedIndex = 0;

            overwriteModes = new Dictionary<string, int>();
            overwriteModes.Add("None", 0);
            overwriteModes.Add("Tiles", 1);
            overwriteModes.Add("Original image", 2);            

            overwriteMode_comboBox.DataSource = new BindingSource(overwriteModes, null);
            overwriteMode_comboBox.DisplayMember = "Key";
            overwriteMode_comboBox.ValueMember = "Value";
            overwriteMode_comboBox.SelectedIndex = 0;
            #endregion
            
            this.OneWayBind(ViewModel, vm => vm.Logs, v => v.RichBoxText);
            this.OneWayBind(ViewModel, vm => vm.progressBarValue, v => v.ProgressBarValue);

            this.OneWayBind(ViewModel, vm => vm.ModelsItems, v => v.ModelsItems);
            //this.OneWayBind(ViewModel, vm => vm.SelectedModelsItems, v => v.checkedModels, vmToViewConverterOverride: new ReactiveListConverter());
            
            ViewModel = new IEU();

            #region #SETTINGS_TAB
            this.Bind(ViewModel, vm => vm.esrganPath, v => v.esrganPath_textBox.Text);
            this.Bind(ViewModel, vm => vm.imgPath, v => v.imgPath_textBox.Text);
            this.Bind(ViewModel, vm => vm.resultsMergedPath, v => v.resultsMergedPath_textBox.Text);

            this.Bind(ViewModel, vm => vm.OutputDestinationMode, v => v.outputDestinationMode_comboBox.SelectedIndex);
            this.Bind(ViewModel, vm => vm.OverwriteMode, v => v.overwriteMode_comboBox.SelectedIndex);

            this.Bind(ViewModel, vm => vm.maxTileResolution, v => v.maxTileResolution_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.maxTileResolutionWidth, v => v.maxTileWidth_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.maxTileResolutionHeight, v => v.maxTileHeight_numericUpDown.Value, x => x, y => decimal.ToInt32(y));

            this.Bind(ViewModel, vm => vm.IgnoreAlpha, v => v.ignoreAlpha_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IgnoreSingleColorAlphas, v => v.ignoreSingleColorAlpha_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.BalanceAlphas, v => v.balanceAlphas_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.DeleteResults, v => v.deleteResults_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.CreateMemoryImage, v => v.createMemoryImage_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.UseOriginalImageFormat, v => v.preserveFormat_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.SplitRGB, v => v.splitRGB_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.UseCPU, v => v.useCPU_checkBox.Checked);
            
            #region #DDS

            ddsTextureType_comboBox.DataSource = new BindingSource(IEU.ddsTextureType, null);
            ddsTextureType_comboBox.DisplayMember = "Key";
            ddsTextureType_comboBox.ValueMember = "Value";
            ddsTextureType_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.ddsTextureTypeSelectedIndex, v => v.ddsTextureType_comboBox.SelectedIndex);

            ddsFileFormat_comboBox.DisplayMember = "Name";
            ddsFileFormat_comboBox.ValueMember = "DdsFileFormat";
            
            this.Bind(ViewModel, vm => vm.ddsFileFormatsCurrent, v => v.ddsFileFormat_comboBox.DataSource);
            this.Bind(ViewModel, vm => vm.ddsFileFormatSelectedIndex, v => v.ddsFileFormat_comboBox.SelectedIndex);
            
            this.Bind(ViewModel, vm => vm.ddsGenerateMipmaps, v => v.ddsGenerateMipmaps_checkBox.Checked);

            ddsCompresion_comboBox.DataSource = new List<string>() { "Fast", "Normal", "Slow (best)" };
            ddsCompresion_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.ddsBC7CompressionSelected, v => v.ddsCompresion_comboBox.SelectedIndex);

            #endregion

            #endregion

            this.BindCommand(ViewModel, vm => vm.SplitCommand, v => v.crop_button);
            this.BindCommand(ViewModel, vm => vm.UpscaleCommand, v => v.upscale_button);
            this.BindCommand(ViewModel, vm => vm.MergeCommand, v => v.merge_button);
            this.BindCommand(ViewModel, vm => vm.SplitUpscaleMergeCommand, v => v.runAll_button);

            pathsTextBoxes = new List<TextBox> { esrganPath_textBox, imgPath_textBox, modelsPath_textBox };
            progress_label.Text = "0/0";
            changeEsrganPath_button.Tag = esrganPath_textBox;
            changeInputImgPath_button.Tag = imgPath_textBox;
            changeMergedResultsPath_button.Tag = resultsMergedPath_textBox;
            changeInputPath_button.Tag = inputPath_textBox;
            changeOutputPath_button.Tag = outputPath_textBox;
            changeModelsPath_button.Tag = modelsPath_textBox;

            appVersion_label.Text = "GUI v" + Application.ProductVersion;
            appCoreVersion_linkLabel.Text = "IEU.Core v" + ViewModel.AppVersion;

            this.Bind(ViewModel, vm => vm.UseDifferentModelForAlpha, v => v.useDifferentModelForAlpha_checkBox.Checked);
           
            this.Bind(ViewModel, vm => vm.SeamlessTexture, v => v.seamlessTextures_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.OverlapSize, v => v.overlapSize_numericUpDown.Value, x => x, x => (int) x);           
            
            interpolationModelOne_comboBox.DisplayMember = "Name";
            interpolationModelOne_comboBox.ValueMember = "FullName";
            interpolationModelOne_comboBox.DataSource = new BindingSource(ViewModel.ModelsItems, null);

            interpolationModelTwo_comboBox.DisplayMember = "Name";
            interpolationModelTwo_comboBox.ValueMember = "FullName";
            interpolationModelTwo_comboBox.DataSource = new BindingSource(ViewModel.ModelsItems, null);

            modelForAlpha_comboBox.DisplayMember = "Name";
            modelForAlpha_comboBox.ValueMember = "FullName";
            modelForAlpha_comboBox.DataSource = new BindingSource(ViewModel.ModelsItems, null);

            if (ViewModel.ModelsItems.Count > 0)
            {
                interpolationModelOne_comboBox.SelectedIndex = 0;
                interpolationModelTwo_comboBox.SelectedIndex = 0;
                modelForAlpha_comboBox.SelectedIndex = 0;

                this.Bind(ViewModel,
                   vm => vm.LastModelForAlphaPath,
                   v => v.modelForAlpha_comboBox.SelectedIndex,
                   x => ViewModel.ModelsItems.FindIndex(y => y.FullName == x),
                   x => ViewModel.ModelsItems[x].FullName);
            }



            lastUseDifferentModelAlpha = useDifferentModelForAlpha_checkBox.Checked;

            outputFormat_comboBox.DataSource = new BindingSource(ViewModel.formatInfos, null);
            outputFormat_comboBox.DisplayMember = "DisplayName";
            outputFormat_comboBox.ValueMember = "Extension";            
            this.Bind(ViewModel, vm => vm.SelectedOutputFormatIndex, v => v.outputFormat_comboBox.SelectedIndex);

            #region references
            //Observable.FromEvent<ItemCheckEventHandler, ItemCheckEventArgs>(ev => filterExtensions_checkedListBox.ItemCheck += ev, ev => filterExtensions_checkedListBox.ItemCheck -= ev)
            //    .Select((x,y) => filterExtensions_checkedListBox.CheckedItems)
            //    .BindTo(ViewModel, vm => vm.filterSelectedExtensionsList, vmToViewConverterOverride: new ListboxToListConverter());

            //Observable.FromEventPattern(ev => ItemsListBox.SelectedValueChanged += ev, ev => ItemsListBox.SelectedValueChanged -= ev)
            //.Select(_ => ItemsListBox.SelectedItem)
            //.BindTo(_vm, vm => vm.SelectedItem);

            //this.WhenActivated(d =>
            //{
            //    d(this.Bind(ViewModel, vm => vm.esrganPath, v => v.esrganPath_textBox.Text));                
            //});

            //var selectionChanged = Observable.FromEvent<EventHandler, EventArgs>(
            //  h => (_, e) => h(e),
            //  ev => ddsTextureType_comboBox.SelectedIndexChanged += ev,
            //  ev => ddsTextureType_comboBox.SelectedIndexChanged += ev);
            #endregion
            
            #region #ADVANCED_TAB

            this.Bind(ViewModel, vm => vm.resultsPath, v => v.outputPath_textBox.Text);
            this.Bind(ViewModel, vm => vm.modelsPath, v => v.modelsPath_textBox.Text);
            this.Bind(ViewModel, vm => vm.lrPath, v => v.inputPath_textBox.Text);

            this.Bind(ViewModel, vm => vm.advancedUseResultSuffix, v => v.advancedUseSuffix_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.advancedResultSuffix, v => v.advancedSuffix_textBox.Text);

            this.Bind(ViewModel, vm => vm.filterFilenameCaseSensitive, v => v.filterFilenameCaseSensitive_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.filterFilenameContainsEnabled, v => v.filterFilenameContains_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.filterFilenameContainsPattern, v => v.filterFilenameContains_textBox.Text);

            this.Bind(ViewModel, vm => vm.filterFilenameNotContainsEnabled, v => v.filterFilenameNotContains_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.filterFilenameNotContainsPattern, v => v.filterFilenameNotContains_textBox.Text);

            filterAlpha_comboBox.DataSource = new List<string>() { "None", "Contains alpha", "Doesn't contain alpha" };
            filterAlpha_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.filterAlpha, v => v.filterAlpha_comboBox.SelectedIndex);

            this.Bind(ViewModel, vm => vm.filterImageResolutionEnabled, v => v.filtersSizeOn_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.filterImageResolutionOr, v => v.filterSizeOr_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.filterImageResolutionMaxWidth, v => v.filterSizeWidth_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.filterImageResolutionMaxHeight, v => v.filterSizeHeight_numericUpDown.Value, x => x, y => decimal.ToInt32(y));

            foreach (var item in IEU.filterExtensionsList)
                filterExtensions_checkedListBox.Items.Add(item);
                        
            noiseReductionType_comboBox.DataSource = ViewModel.postprocessNoiseFilter;         
            noiseReductionType_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.noiseReductionType, v => v.noiseReductionType_comboBox.SelectedIndex);

            this.Bind(ViewModel, vm => vm.thresholdEnabled, v => v.thresholdEnabled_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.thresholdBlackValue, v => v.thresholdBlack_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.thresholdWhiteValue, v => v.thresholdWhite_numericUpDown.Value, x => x, y => decimal.ToInt32(y));

            tiffSettings_comboBox.DataSource = new BindingSource(IEU.TiffCompressionModes, null);
            tiffSettings_comboBox.DisplayMember = "Key";
            tiffSettings_comboBox.ValueMember = "Value";
            tiffSettings_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.tiffFormat.CompressionMethod, v => v.tiffSettings_comboBox.SelectedValue, x => x, x => (string) x);
            this.Bind(ViewModel, vm => vm.tiffFormat.QualityFactor, v => v.tiffJpegQuality_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            
            webpPreset_comboBox.DataSource = new BindingSource(IEU.WebpPresets, null);
            webpPreset_comboBox.DisplayMember = "Key";
            webpPreset_comboBox.ValueMember = "Value";
            webpPreset_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.webpFormat.CompressionMethod, v => v.webpPreset_comboBox.SelectedValue, x => x, x => (string)x);
            this.Bind(ViewModel, vm => vm.webpFormat.QualityFactor, v => v.webpQuality_numericUpDown.Value, x => x, y => decimal.ToInt32(y));

            this.Bind(ViewModel, vm => vm.pngFormat.CompressionFactor, v => v.pngCompression_numericUpDown.Value, x => x, y => decimal.ToInt32(y));

            #region #RESIZE
            resizeImageBeforeScaleFactor_comboBox.DataSource = IEU.ResizeImageScaleFactors;
            resizeImageBeforeScaleFactor_comboBox.SelectedIndex = 3;
            this.Bind(ViewModel, vm => vm.resizeImageBeforeScaleFactor, v => v.resizeImageBeforeScaleFactor_comboBox.Text, x => x.ToString(), x => Double.Parse(x.ToString()));

            resizeImageBeforeFilterType_comboBox.DataSource = new BindingSource(IEU.MagickFilterTypes, null);
            resizeImageBeforeFilterType_comboBox.DisplayMember = "Value";
            resizeImageBeforeFilterType_comboBox.ValueMember = "Key";
            resizeImageBeforeFilterType_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.resizeImageBeforeFilterType, v => v.resizeImageBeforeFilterType_comboBox.SelectedValue, x => x, x => (int)x);

            resizeImageAfterScaleFactor_comboBox.DataSource = IEU.ResizeImageScaleFactors;
            resizeImageAfterScaleFactor_comboBox.SelectedIndex = 3;
            this.Bind(ViewModel, vm => vm.resizeImageAfterScaleFactor, v => v.resizeImageAfterScaleFactor_comboBox.Text, x => x.ToString(), x => Double.Parse(x.ToString()));

            resizeImageAfterFilterType_comboBox.DataSource = new BindingSource(IEU.MagickFilterTypes, null);
            resizeImageAfterFilterType_comboBox.DisplayMember = "Value";
            resizeImageAfterFilterType_comboBox.ValueMember = "Key";
            resizeImageAfterFilterType_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.resizeImageAfterFilterType, v => v.resizeImageAfterFilterType_comboBox.SelectedValue, x => x, x => (int)x);
            #endregion

            #endregion

            VerifyPaths();           

            //if (ViewModel.checkForUpdates)
            //    CheckNewReleases();
        }

        private void OpenModelFolder(object sender, EventArgs e)
        {
            Process.Start(modelsPath_textBox.Text);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ViewModel.WindowWidth = Width;
            ViewModel.WindowHeight = Height;
            ViewModel.LogPanelWidth = splitContainer1.SplitterDistance;
            ViewModel.SaveSettings();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            SendMessage(filterFilenameContains_textBox.Handle, 0x1501, 1, "word1;word2;word3");
            SendMessage(filterFilenameNotContains_textBox.Handle, 0x1501, 1, "word1;word2;word3");
            SendMessage(interpolationOutputModelName_textBox.Handle, 0x1501, 1, "New model name");            

            Width = Convert.ToInt32(ViewModel.WindowWidth);
            Height = Convert.ToInt32(ViewModel.WindowHeight);
            splitContainer1.SplitterDistance = Convert.ToInt32(ViewModel.LogPanelWidth);
        }

        bool VerifyPaths()
        {
            string message = "Some directories dont exist!";
            bool allgood = true;
            foreach (TextBox t in pathsTextBoxes)
            {
                if (t.Text == "")
                    allgood = false;
                else
                {
                    if (!Directory.Exists(t.Text))
                        message += $"\n{t.Text}";
                    allgood = allgood && Directory.Exists(t.Text);
                }
            }         
            if (!allgood)
                MessageBox.Show(message);

            main_tabPage.Enabled = allgood;
            interpolation_tabPage.Enabled = allgood;

            return allgood;
        }
        
        void CreateModelTree(List<ModelInfo> items)
        {
            treeView1.Nodes.Clear();
            treeView1.CheckBoxes = true;

            if (modelsPath_textBox.Text == "")
                return;
            DirectoryInfo di = new DirectoryInfo(modelsPath_textBox.Text);
            if (!di.Exists)
            {
                MessageBox.Show($"{di.FullName} doesn't exist!");
                return;
            }

            List<TreeNode> folders = new List<TreeNode>();

            foreach (var model in items)
            {
                if (model.ParentFolder != "")
                {
                    if (folders.Where(x => x.Text == model.ParentFolder).Count() == 0)
                    {
                        TreeNode node = new TreeNode() { Text = model.ParentFolder };
                        node.Nodes.AddRange(items
                            .Where(x => x.ParentFolder == model.ParentFolder).ToList()
                            .ConvertAll(x => new TreeNode(x.Name) { Tag = x }).ToArray());
                        node.Tag = "";
                        folders.Add(node);
                        treeView1.Nodes.Add(node);
                    }
                }
                else
                    treeView1.Nodes.Add(new TreeNode() { Text = model.Name, Tag = model });
            }
            treeView1.Nodes[0].ExpandAll();
        }        
        void CreateModelTree()
        {
            treeView1.Nodes.Clear();
            treeView1.CheckBoxes = true;

            DirectoryInfo di = new DirectoryInfo(ViewModel.modelsPath);
            if (!di.Exists)
            {
                MessageBox.Show($"{di.FullName} doesn't exist!");
                return;
            }
            
            List<TreeNode> folders = new List<TreeNode>();

            foreach (var model in ViewModel.ModelsItems)
            {
                if (model.ParentFolder != "")
                {
                    if (folders.Where(x => x.Text == model.ParentFolder).Count() == 0)
                    {
                        TreeNode node = new TreeNode() { Text = model.ParentFolder };
                        node.Nodes.AddRange(ViewModel.ModelsItems
                            .Where(x => x.ParentFolder == model.ParentFolder).ToList()
                            .ConvertAll(x => new TreeNode(x.Name) {Tag = x }).ToArray());
                        node.Tag = "";
                        folders.Add(node);
                        treeView1.Nodes.Add(node);
                    }
                }
                else
                    treeView1.Nodes.Add(new TreeNode() { Text = model.Name, Tag = model});
            }

            treeView1.Nodes[0].ExpandAll();
        }

        async Task CheckNewReleases()
        {
            var checkerCore = new UpdateChecker("ptrsuder", ViewModel.GitHubRepoName, ViewModel.AppVersion);
            var checkerWinforms = new UpdateChecker("ptrsuder", this.GitHubRepoName, this.AppVersion);
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            UpdateType updateCore = await checkerCore.CheckUpdate();
            UpdateType updateWinforms = await checkerWinforms.CheckUpdate();

            switch (updateCore)
            {
                case UpdateType.None:
                    break;
                case UpdateType.Fail:
                    MessageBox.Show(checkerCore.ErrorMessage);
                    break;
                default:
                    UpdateNotifyDialog updateNotifyDialog = new UpdateNotifyDialog(checkerCore);
                    updateNotifyDialog.Show();
                    //if (await Application.Current.MainWindow.ShowDialog<bool>(Application.Current.MainWindow))
                    //    Helper.OpenBrowser(@"https://github.com/ptrsuder/crop-upscale-merge/releases");
                    break;
            }

            switch (updateWinforms)
            {
                case UpdateType.None:
                    break;
                case UpdateType.Fail:
                    MessageBox.Show(checkerCore.ErrorMessage);
                    break;
                default:
                    UpdateNotifyDialog updateNotifyDialog = new UpdateNotifyDialog(checkerWinforms);
                    updateNotifyDialog.Show();
                    break;
            }
        }
                
        private void advancedUseSuffix_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            advancedSuffix_textBox.ReadOnly = !advancedUseSuffix_checkBox.Checked;
        }                
      
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            checkedModels = treeView1.Nodes.Find("", true).Where(x => x.Checked).ToList()
                .ConvertAll(x => x.Tag as ModelInfo)
                .Where(x => x?.GetType().ToString() == "ImageEnhancingUtility.Core.ModelInfo").ToList();
            ViewModel.SelectedModelsItems = checkedModels; //hack           
            
            useDifferentModelForAlpha_checkBox.Enabled = checkedModels.Count <= 1;

            if (checkedModels.Count > 1)
            {               
                if (useDifferentModelForAlpha_checkBox.Checked)
                {
                    lastUseDifferentModelAlpha = true;
                    useDifferentModelForAlpha_checkBox.Checked = false;
                }
                outputDestinationMode_comboBox.DataSource = new BindingSource(outputDestinationModes, null);
            }
            else
            {
                if(lastUseDifferentModelAlpha)
                    useDifferentModelForAlpha_checkBox.Checked = lastUseDifferentModelAlpha;
                outputDestinationMode_comboBox.DataSource = new BindingSource(outputDestinationModesSingleModel, null);
            }
            lastCheckedModelsCount = checkedModels.Count;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }

        private void filterSizeOr_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (filterSizeOr_checkBox.Checked)
                filterSizeOr_checkBox.Text = "AND";
            else
                filterSizeOr_checkBox.Text = "OR";
        }

        private void filterFilenameContains_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            filterFilenameContains_textBox.ReadOnly = !filterFilenameContains_checkBox.Checked;
        }

        private void filterFilenameNotContains_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            filterFilenameNotContains_textBox.ReadOnly = !filterFilenameNotContains_checkBox.Checked;
        }

        private void filtersSizeOn_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (filtersSizeOn_checkBox.Checked)
            {
                filterSizeHeight_numericUpDown.Enabled = true;
                filterSizeWidth_numericUpDown.Enabled = true;
                filterSizeOr_checkBox.Enabled = true;
            }
            else
            {
                filterSizeHeight_numericUpDown.Enabled = false;
                filterSizeWidth_numericUpDown.Enabled = false;
                filterSizeOr_checkBox.Enabled = false;
            }
        }

        private void thresholdEnabled_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (thresholdEnabled_checkBox.Checked)
            {
                thresholdBlack_numericUpDown.Enabled = true;
                thresholdWhite_numericUpDown.Enabled = true;
            }
            else
            {
                thresholdBlack_numericUpDown.Enabled = false;
                thresholdWhite_numericUpDown.Enabled = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://github.com/ptrsuder/" + ViewModel.GitHubRepoName);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://github.com/ptrsuder/" + GitHubRepoName);
        }

        private void changePath_button_Click(object sender, EventArgs e)
        {
            TextBox textBox = (sender as Button).Tag as TextBox;
            FolderSelectDialog.FolderSelectDialog folderSelectDialog = new FolderSelectDialog.FolderSelectDialog();
            folderSelectDialog.ShowDialog();
            if (folderSelectDialog.FileName != "")
                textBox.Text = folderSelectDialog.FileName;

            main_tabPage.Enabled = VerifyPaths();
        }
             
        private void upscale_button_Click(object sender, EventArgs e)
        {
            //ViewModel.Upscale();
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = e.Data.GetData(DataFormats.FileDrop) as string[];
            DialogResult dialogResult;            
            dialogResult = MessageBox.Show($"Copy file? Existing files will be overwriten", "Copy confirmation", buttons: MessageBoxButtons.YesNo);
            int imagesCopied = 0, modelsCopied = 0;
            if (dialogResult == DialogResult.Yes)
                foreach (string path in filePaths)
                {
                    string folderName = Path.GetFileName(path);
                    string folderNewPath = imgPath_textBox.Text + Path.DirectorySeparatorChar + folderName;

                    if ((File.GetAttributes(path) & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        Directory.CreateDirectory(folderNewPath);
                        Directory.CreateDirectory(path);
                        foreach (string dirPath in Directory.GetDirectories(path, "*",
                            SearchOption.AllDirectories))
                            Directory.CreateDirectory(dirPath.Replace(path, folderNewPath));

                        //Copy all the files & Replaces any files with the same name
                        foreach (string filePath in Directory.GetFiles(path, "*.*",
                            SearchOption.AllDirectories))
                        {
                            string newFilePath = filePath.Replace(path, folderNewPath);
                            File.Copy(filePath, newFilePath, true);
                            imagesCopied++;
                        }
                    }
                    else
                    {
                        if (Path.GetExtension(path).ToLower() == ".pth")
                        {
                            File.Copy(path, modelsPath_textBox.Text + Path.DirectorySeparatorChar + Path.GetFileName(path), true);
                            modelsCopied++;
                        }
                        File.Copy(path, imgPath_textBox.Text + Path.DirectorySeparatorChar + Path.GetFileName(path), true);
                    }
                }
            MessageBox.Show($"Succesfully copied {imagesCopied} files" + (modelsCopied>0?$" and { modelsCopied} models":""));
        }

        private async void interpolationStart_button_Click(object sender, EventArgs e)
        {
            double alphaValue = 0.0;
            try
            {
                alphaValue = double.Parse(interpolationAlphaValue_textBox.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Alpha value is not valid value");
            }
            tabControl1.SelectedTab = main_tabPage;
            bool success = await ViewModel.CreateInterpolatedModel(interpolationModelOne_comboBox.SelectedValue.ToString(), interpolationModelTwo_comboBox.SelectedValue.ToString(), alphaValue);          
            //if (!success)
                //MessageBox.Show("Alpha should be between 0.0 and 1.0");
        }

        private void InterpolationSettingsChanged(object sender, EventArgs e)
        {
            interpolationOutputModelName_textBox.Text =
                $"{((ModelInfo)interpolationModelOne_comboBox.SelectedItem)?.Name.Replace(".pth","")}_" +
                $"{((ModelInfo)interpolationModelTwo_comboBox.SelectedItem)?.Name.Replace(".pth", "")}_" +
                $"interp_{interpolationAlphaValue_textBox.Text.Replace(",", "").Replace(".","")}.pth";
        }

        private void useDifferentModelForAlpha_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            modelForAlpha_comboBox.Enabled = useDifferentModelForAlpha_checkBox.Checked;
            if (checkedModels.Count <= 1 && useDifferentModelForAlpha_checkBox.Checked == false)
                lastUseDifferentModelAlpha = false;
        }

        private void preserveFormat_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            outputFormat_comboBox.Enabled = !preserveFormat_checkBox.Checked;
        }

        private void filterExtensions_checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = sender as CheckedListBox;
            var selectedITem = checkedListBox.SelectedItem;
            ViewModel.filterSelectedExtensionsList = checkedListBox.CheckedItems.Cast<string>().ToList(); //hack
            if (checkedListBox.CheckedItems.Contains(selectedITem))
                ViewModel.filterSelectedExtensionsList.Remove(checkedListBox.SelectedItem.ToString());
            else
                ViewModel.filterSelectedExtensionsList.Add(checkedListBox.SelectedItem.ToString());        
        }       

        void CreateMyTreeView()
        {
            this.treeView1 = new MyTreeView();
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = BorderStyle.FixedSingle;
            this.treeView1.ContextMenuStrip = this.treeView_contextMenuStrip;
            this.treeView1.Dock = DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Lucida Console", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.HideSelection = false;
            this.treeView1.ItemHeight = 20;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(400, 571);
            this.treeView1.TabIndex = 9;
            this.treeView1.AfterCheck += new TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);


        }

        private void modelForAlpha_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewModel.ModelForAlpha = modelForAlpha_comboBox.SelectedItem as ModelInfo; //hack, breaks MVVM
        }

        private void webpLossless_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            webpPreset_comboBox.Enabled = !webpLossless_checkBox.Checked;
            webpQuality_numericUpDown.Enabled = !webpLossless_checkBox.Checked;         
            if(webpLossless_checkBox.Checked)            
                webpQuality_numericUpDown.Value = 100;
            
        }
    }    
}
