using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cyotek.Windows.Forms;
using DynamicData;
using GitHubUpdate;
using ImageEnhancingUtility.Core;
using ReactiveUI;

//TODO:
//ask to change all paths when changing ESRGAN path
//change VerifyPaths?

namespace ImageEnhancingUtility.Winforms
{
    public partial class MainForm : Form, IViewFor<IEU>
    {
        public readonly string AppVersion = "0.10.01";
        public readonly string GitHubRepoName = "IEU.Winforms";

        public IEU ViewModel { get; set; }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (IEU)value;
        }

        private MyTreeView treeView1;

        List<ModelInfo> checkedModels = new List<ModelInfo>();        

        readonly List<TextBox> pathsTextBoxes;

        int widthBeforeResize, heightBeforeResize;

        bool lastUseDifferentModelAlpha = false;

        private delegate void SafeCallDelegate(string text);
        private delegate void SafeCallDelegateWithColor(string text, Color color);

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

        private void WriteToLogsThreadSafe(LogMessage message)
        {
            if (richTextBox1.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteToLogsThreadSafe);
                Invoke(d, new object[] { message });
            }
            else
            {      
                richTextBox1.AppendText(message.Text, message.Color);
            }
            //richTextBox1.AppendText($"\n[{DateTime.Now}] {text}", System.Drawing.Color.White);
        }

        private void AppendToLogsThreadSafe(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                var d = new SafeCallDelegate(AppendToLogsThreadSafe);
                Invoke(d, new object[] { text });
            }
            else
                richTextBox1.AppendText($"\n[{DateTime.Now}] {text}", System.Drawing.Color.White);
        }

        private void WriteToLogsThreadSafe(string text, Color color)
        {
            if (richTextBox1.InvokeRequired)
            {
                var d = new SafeCallDelegateWithColor(WriteToLogsThreadSafe);
                Invoke(d, new object[] { text, color });
            }
            else
                richTextBox1.AppendText($"\n[{DateTime.Now}] {text}", color);
        }

        public double ProgressBarValue
        {
            get => 0;
            set
            {
                ReportProgressThreadSafe(value);
            }
        }

        private delegate void SafeCallDelegate2(double value);
        private void ReportProgressThreadSafe(double value)
        {
            if (progressBar1.InvokeRequired || progress_label.InvokeRequired)
            {
                var d = new SafeCallDelegate2(ReportProgressThreadSafe);
                Invoke(d, new object[] { value });
            }
            else
            {
                progressBar1.Value = (int) value;
                progress_label.Text = $@"{ViewModel.FilesDone}/{ViewModel.FilesTotal}"; //hack
                progressFiltered_label.Text = ViewModel.FilesDoneSuccesfully.ToString();
            }
        }              

        public List<ModelInfo> ModelsItems
        {
            get => null;
            set
            {
                CreateModelTree(value);
                modelForAlpha_comboBox.DataSource = new BindingSource(ViewModel.ModelsItems, null);
                previewModels_comboBox.DataSource = new BindingSource(ViewModel.ModelsItems, null);
                interpolationModelOne_comboBox.DataSource = new BindingSource(ViewModel.ModelsItems, null);
                interpolationModelTwo_comboBox.DataSource = new BindingSource(ViewModel.ModelsItems, null);
            }
        }

        [DllImport("user32.dll")] //textbox hint
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        #region BINDINGS

        void BindSettingsTab()
        {
            this.Bind(ViewModel, vm => vm.ResultsPath, v => v.outputPath_textBox.Text);
            this.Bind(ViewModel, vm => vm.ModelsPath, v => v.modelsPath_textBox.Text);
            this.Bind(ViewModel, vm => vm.LrPath, v => v.inputPath_textBox.Text);

            this.Bind(ViewModel, vm => vm.InputDirectoryPath, v => v.imgPath_textBox.Text);
            this.Bind(ViewModel, vm => vm.OutputDirectoryPath, v => v.resultsMergedPath_textBox.Text);

            this.Bind(ViewModel, vm => vm.EsrganPath, v => v.esrganPath_textBox.Text);


            this.Bind(ViewModel, vm => vm.MaxTileResolution, v => v.maxTileResolution_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.MaxTileResolutionWidth, v => v.maxTileWidth_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.MaxTileResolutionHeight, v => v.maxTileHeight_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.PreciseTileResolution, v => v.preciseTile_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.IgnoreAlpha, v => v.ignoreAlpha_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IgnoreSingleColorAlphas, v => v.ignoreSingleColorAlpha_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.BalanceAlphas, v => v.balanceAlphas_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.DeleteResults, v => v.deleteResults_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.CreateMemoryImage, v => v.createMemoryImage_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.UseOriginalImageFormat, v => v.preserveFormat_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.SplitRGB, v => v.splitRGB_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.UseCPU, v => v.useCPU_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.UseDifferentModelForAlpha, v => v.useDifferentModelForAlpha_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.SeamlessTexture, v => v.seamlessTextures_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.OverlapSize, v => v.overlapSize_numericUpDown.Value, x => x, x => (int)x);

            this.Bind(ViewModel, vm => vm.CheckForUpdates, v => v.checkForUpdates_checkBox.Checked);
        }

        void BindMainTab()
        {
            this.Bind(ViewModel, vm => vm.OutputDestinationModes, v => v.outputDestinationMode_comboBox.DataSource, x => new BindingSource(x, null), x => (x as BindingSource).DataSource as Dictionary<string, int>);
            outputDestinationMode_comboBox.DisplayMember = "Key";
            outputDestinationMode_comboBox.ValueMember = "Value";
            this.Bind(ViewModel, vm => vm.OutputDestinationMode, v => v.outputDestinationMode_comboBox.SelectedValue, x => x, x => (int)x);

            this.Bind(ViewModel, vm => vm.OverwriteModes, v => v.overwriteMode_comboBox.DataSource, x => new BindingSource(x, null), x => (x as BindingSource).DataSource as Dictionary<string, int>);
            overwriteMode_comboBox.DisplayMember = "Key";
            overwriteMode_comboBox.ValueMember = "Value";
            this.Bind(ViewModel, vm => vm.OverwriteMode, v => v.overwriteMode_comboBox.SelectedIndex);

            this.OneWayBind(ViewModel, vm => vm.ProgressBarValue, v => v.ProgressBarValue);
            this.OneWayBind(ViewModel, vm => vm.ModelsItems, v => v.ModelsItems);
        }

        void BindOutputFormats()
        {
            ddsTextureType_comboBox.DataSource = new BindingSource(IEU.ddsTextureType, null);
            ddsTextureType_comboBox.DisplayMember = "Key";
            ddsTextureType_comboBox.ValueMember = "Value";
            ddsTextureType_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.DdsTextureTypeSelectedIndex, v => v.ddsTextureType_comboBox.SelectedIndex);

            ddsFileFormat_comboBox.DisplayMember = "Name";
            ddsFileFormat_comboBox.ValueMember = "DdsFileFormat";

            this.Bind(ViewModel, vm => vm.DdsFileFormatsCurrent, v => v.ddsFileFormat_comboBox.DataSource);
            this.Bind(ViewModel, vm => vm.DdsFileFormatSelectedIndex, v => v.ddsFileFormat_comboBox.SelectedIndex);

            this.Bind(ViewModel, vm => vm.ddsGenerateMipmaps, v => v.ddsGenerateMipmaps_checkBox.Checked);

            ddsCompresion_comboBox.DataSource = new List<string>() { "Fast", "Normal", "Slow (best)" };
            ddsCompresion_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.DdsBC7CompressionSelected, v => v.ddsCompresion_comboBox.SelectedIndex);

            outputFormat_comboBox.DataSource = new BindingSource(ViewModel.FormatInfos, null);
            outputFormat_comboBox.DisplayMember = "DisplayName";
            outputFormat_comboBox.ValueMember = "Extension";
            this.Bind(ViewModel, vm => vm.SelectedOutputFormatIndex, v => v.outputFormat_comboBox.SelectedIndex);


            tiffSettings_comboBox.DataSource = new BindingSource(IEU.TiffCompressionModes, null);
            tiffSettings_comboBox.DisplayMember = "Key";
            tiffSettings_comboBox.ValueMember = "Value";
            tiffSettings_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.tiffFormat.CompressionMethod, v => v.tiffSettings_comboBox.SelectedValue, x => x, x => (string)x);
            this.Bind(ViewModel, vm => vm.tiffFormat.QualityFactor, v => v.tiffJpegQuality_numericUpDown.Value, x => x, y => decimal.ToInt32(y));

            webpPreset_comboBox.DataSource = new BindingSource(IEU.WebpPresets, null);
            webpPreset_comboBox.DisplayMember = "Key";
            webpPreset_comboBox.ValueMember = "Value";
            webpPreset_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.webpFormat.CompressionMethod, v => v.webpPreset_comboBox.SelectedValue, x => x, x => (string)x);
            this.Bind(ViewModel, vm => vm.webpFormat.QualityFactor, v => v.webpQuality_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.pngFormat.CompressionFactor, v => v.pngCompression_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
        }

        void BindCommands()
        {
            this.BindCommand(ViewModel, vm => vm.SplitCommand, v => v.crop_button);
            this.BindCommand(ViewModel, vm => vm.UpscaleCommand, v => v.upscale_button);
            this.BindCommand(ViewModel, vm => vm.MergeCommand, v => v.merge_button);
            this.BindCommand(ViewModel, vm => vm.SplitUpscaleMergeCommand, v => v.runAll_button);

            ViewModel.SplitCommand.ThrownExceptions.Subscribe(error => { AppendToLogsThreadSafe(error.Message); });
            ViewModel.UpscaleCommand.ThrownExceptions.Subscribe(error => { AppendToLogsThreadSafe(error.Message); });
            ViewModel.MergeCommand.ThrownExceptions.Subscribe(error => { AppendToLogsThreadSafe(error.Message); });
            ViewModel.SplitUpscaleMergeCommand.ThrownExceptions.Subscribe(error => { AppendToLogsThreadSafe(error.Message); });
        }

        void BindAdvanced()
        {
            #region #ADVANCED_TAB           

            this.Bind(ViewModel, vm => vm.AdvancedUseResultSuffix, v => v.advancedUseSuffix_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.AdvancedResultSuffix, v => v.advancedSuffix_textBox.Text);

            this.Bind(ViewModel, vm => vm.FilterFilenameCaseSensitive, v => v.filterFilenameCaseSensitive_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.FilterFilenameContainsEnabled, v => v.filterFilenameContains_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.FilterFilenameContainsPattern, v => v.filterFilenameContains_textBox.Text);

            this.Bind(ViewModel, vm => vm.FilterFilenameNotContainsEnabled, v => v.filterFilenameNotContains_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.FilterFilenameNotContainsPattern, v => v.filterFilenameNotContains_textBox.Text);

            filterAlpha_comboBox.DataSource = new List<string>() { "None", "Contains alpha", "Doesn't contain alpha" };
            filterAlpha_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.FilterAlpha, v => v.filterAlpha_comboBox.SelectedIndex);

            this.Bind(ViewModel, vm => vm.FilterImageResolutionEnabled, v => v.filtersSizeOn_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.FilterImageResolutionOr, v => v.filterSizeOr_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.FilterImageResolutionMaxWidth, v => v.filterSizeWidth_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.FilterImageResolutionMaxHeight, v => v.filterSizeHeight_numericUpDown.Value, x => x, y => decimal.ToInt32(y));

            foreach (var item in IEU.filterExtensionsList)
                filterExtensions_checkedListBox.Items.Add(item);

            noiseReductionType_comboBox.DataSource = ViewModel.postprocessNoiseFilter;
            noiseReductionType_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.NoiseReductionType, v => v.noiseReductionType_comboBox.SelectedIndex);

            this.Bind(ViewModel, vm => vm.ThresholdEnabled, v => v.thresholdEnabled_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.ThresholdBlackValue, v => v.thresholdBlack_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.ThresholdWhiteValue, v => v.thresholdWhite_numericUpDown.Value, x => x, y => decimal.ToInt32(y));            

            #region #RESIZE
            resizeImageBeforeScaleFactor_comboBox.DataSource = IEU.ResizeImageScaleFactors;
            resizeImageBeforeScaleFactor_comboBox.SelectedIndex = 3;
            this.Bind(ViewModel, vm => vm.ResizeImageBeforeScaleFactor, v => v.resizeImageBeforeScaleFactor_comboBox.Text, x => x.ToString(), x => Double.Parse(x.ToString()));

            resizeImageBeforeFilterType_comboBox.DataSource = new BindingSource(IEU.MagickFilterTypes, null);
            resizeImageBeforeFilterType_comboBox.DisplayMember = "Value";
            resizeImageBeforeFilterType_comboBox.ValueMember = "Key";
            resizeImageBeforeFilterType_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.ResizeImageBeforeFilterType, v => v.resizeImageBeforeFilterType_comboBox.SelectedValue, x => x, x => (int)x);

            resizeImageAfterScaleFactor_comboBox.DataSource = IEU.ResizeImageScaleFactors;
            resizeImageAfterScaleFactor_comboBox.SelectedIndex = 3;
            this.Bind(ViewModel, vm => vm.ResizeImageAfterScaleFactor, v => v.resizeImageAfterScaleFactor_comboBox.Text, x => x.ToString(), x => Double.Parse(x.ToString()));

            resizeImageAfterFilterType_comboBox.DataSource = new BindingSource(IEU.MagickFilterTypes, null);
            resizeImageAfterFilterType_comboBox.DisplayMember = "Value";
            resizeImageAfterFilterType_comboBox.ValueMember = "Key";
            resizeImageAfterFilterType_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.ResizeImageAfterFilterType, v => v.resizeImageAfterFilterType_comboBox.SelectedValue, x => x, x => (int)x);
            #endregion

            #endregion
        }

        #endregion

        public MainForm()
        {
            InitializeComponent();
            CreateMyTreeView();
            treeView_contextMenuStrip.Items[0].Click += OpenModelFolder;

            FormClosing += MainForm_FormClosing;

            //this.OneWayBind(ViewModel, vm => vm.SelectedModelsItems, v => v.checkedModels, vmToViewConverterOverride: new ReactiveListConverter());

            BindMainTab();            

            ViewModel = new IEU();

            ReadOnlyObservableCollection<LogMessage> bindingData;

            ViewModel.Log.Connect()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out bindingData)
                .OnItemAdded(x => WriteToLogsThreadSafe(x))
                .Subscribe();

            BindSettingsTab();
            
            BindCommands();

            pathsTextBoxes = new List<TextBox> { esrganPath_textBox, imgPath_textBox, modelsPath_textBox };
            progress_label.Text = "0/0";
            changeEsrganPath_button.Tag = esrganPath_textBox;
            changeInputImgPath_button.Tag = imgPath_textBox;
            changeMergedResultsPath_button.Tag = resultsMergedPath_textBox;
            changeInputPath_button.Tag = inputPath_textBox;
            changeOutputPath_button.Tag = outputPath_textBox;
            changeModelsPath_button.Tag = modelsPath_textBox;

            appVersion_label.Text = "GUI v" + this.AppVersion;
            appCoreVersion_linkLabel.Text = "IEU.Core v" + ViewModel.AppVersion;       

            interpolationModelOne_comboBox.DisplayMember = "Name";
            interpolationModelOne_comboBox.ValueMember = "FullName";
            interpolationModelOne_comboBox.DataSource = new BindingSource(ViewModel.ModelsItems, null);

            interpolationModelTwo_comboBox.DisplayMember = "Name";
            interpolationModelTwo_comboBox.ValueMember = "FullName";
            interpolationModelTwo_comboBox.DataSource = new BindingSource(ViewModel.ModelsItems, null);

            modelForAlpha_comboBox.DisplayMember = "Name";
            modelForAlpha_comboBox.ValueMember = "FullName";
            modelForAlpha_comboBox.DataSource = new BindingSource(ViewModel.ModelsItems, null);           

            previewModels_comboBox.DisplayMember = "Name";
            previewModels_comboBox.ValueMember = "FullName";
            previewModels_comboBox.DataSource = new BindingSource(ViewModel.ModelsItems, null);

            if (ViewModel.ModelsItems.Count > 0)
            {
                interpolationModelOne_comboBox.SelectedIndex = 0;
                interpolationModelTwo_comboBox.SelectedIndex = 0;
                modelForAlpha_comboBox.SelectedIndex = 0;

                this.Bind(ViewModel,
                   vm => vm.LastModelForAlphaPath,
                   v => v.modelForAlpha_comboBox.SelectedIndex,
                   x => x==""?0:ViewModel.ModelsItems.FindIndex(y => y.FullName == x),
                   x => ViewModel.ModelsItems[x].FullName);
            }

            lastUseDifferentModelAlpha = useDifferentModelForAlpha_checkBox.Checked;

            BindOutputFormats();

            #region bind references
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

            BindAdvanced();

            VerifyPaths();

            if (ViewModel.CheckForUpdates)
                CheckNewReleases();

            zoomImageBox.VerticalScroll.Enabled = false;

            //OpenImage(@"E:\Documents\GitHub\ImageEnhancingUtility\IEU.Winforms\sample.jpg");
        }
        
        private void CreateMyTreeView()
        {
            this.treeView1 = new MyTreeView
            {
                BorderStyle = BorderStyle.FixedSingle,
                ContextMenuStrip = this.treeView_contextMenuStrip,
                Dock = DockStyle.Fill,
                Font = new System.Drawing.Font("Lucida Console", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                HideSelection = false,
                ItemHeight = 20,
                Location = new System.Drawing.Point(0, 0),
                Name = "treeView1",
                Size = new System.Drawing.Size(400, 571),
                TabIndex = 9
            };
            this.treeView1.AfterCheck += new TreeViewEventHandler(this.treeView1_AfterCheck);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
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
               
        async Task CheckNewReleases()
        {
            //var checkerCore = new UpdateChecker("ptrsuder", ViewModel.GitHubRepoName, ViewModel.AppVersion);
            var checkerWinforms = new UpdateChecker("ptrsuder", GitHubRepoName, AppVersion);
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            //UpdateType updateCore = await checkerCore.CheckUpdate();
            UpdateType updateWinforms = await checkerWinforms.CheckUpdate();

            string updateMessage = "";

            //switch (updateCore)
            //{
            //    case UpdateType.None:
            //        break;
            //    case UpdateType.Fail:
            //        MessageBox.Show(checkerCore.ErrorMessage);
            //        break;
            //    default:
            //        updateMessage += "New version of IEU.Core is available!";                   
            //        //UpdateNotifyDialog updateNotifyDialog = new UpdateNotifyDialog(checkerCore);
            //        //updateNotifyDialog.Show();
            //        //if (await Application.Current.MainWindow.ShowDialog<bool>(Application.Current.MainWindow))
            //        //    Helper.OpenBrowser(@"https://github.com/ptrsuder/crop-upscale-merge/releases");
            //        break;
            //}

            switch (updateWinforms)
            {
                case UpdateType.None:
                    break;
                case UpdateType.Fail:
                    MessageBox.Show(checkerWinforms.ErrorMessage);
                    break;
                default:
                    updateMessage += "New version of IEU.Winforms is available!";
                    using (UpdateNotifyDialog updateNotifyDialog = new UpdateNotifyDialog(checkerWinforms, updateMessage))
                    {
                        updateNotifyDialog.ShowDialog(this);
                    }
                    break;
            }
        }
        
        #region PREVIEW methods

        Bitmap originalPreview, resultPreview;
        int visibleImageWidthBeforeResize, visibleImageHeightBeforeResize;

        Rectangle _minimap;
        Bitmap _thumbnailBitmap;

        string previewFullname;
        
        private void UpdateStatusBar()
        {      
            RectangleF rect = zoomImageBox.GetSourceImageRegion();
            imageSizeToolStripStatusLabel.Text = $"W:{(int)rect.Width}, H:{(int)rect.Height}";            
        }              

        private void OpenImage(string fullname)
        {
            Image image = Helper.LoadImageToBitmap(fullname);
            previewFullname = fullname;
            //zoomImageBox.BeginUpdate();
            zoomImageBox.Image = image;
            zoomImageBox.ZoomToFit();
            //zoomImageBox.EndUpdate();
            int minimumZoom = zoomImageBox.Zoom;
            zoomImageBox.ActualSize();

            ZoomLevelCollection levels = zoomImageBox.ZoomLevels;

            levels.Clear();

            levels.Add(minimumZoom);

            foreach (int level in ZoomLevelCollection.Default)
            {
                if (level > minimumZoom && level <= 400)
                {
                    levels.Add(level);
                }
            }
            FillZoomLevels();
            UpdateStatusBar();
            zoomImageBox.ZoomToFit();

            originalPreview = null;
            resultPreview = null;
        }

        private void UpdatePreview()
        {
            if (zoomImageBox.Image == null)
                return;
            RectangleF visibleImageRegion = zoomImageBox.GetSourceImageRegion();

            int w = Convert.ToInt32(visibleImageRegion.Width);
            int h = Convert.ToInt32(visibleImageRegion.Height);
            double zoomFactor = zoomImageBox.ZoomFactor;
            int wOffset = Convert.ToInt32(SystemInformation.VerticalScrollBarWidth / zoomFactor);
            int hOffset = Convert.ToInt32(SystemInformation.HorizontalScrollBarHeight / zoomFactor);

            Size imageSize = zoomImageBox.Image.Size;

            int scaledWidth = Convert.ToInt32(visibleImageRegion.Width * zoomFactor);
            int scaledHeight = Convert.ToInt32(visibleImageRegion.Height * zoomFactor);

            Size viewSize = zoomImageBox.GetInsideViewPort().Size;

            if (scaledWidth < viewSize.Width)
                wOffset = 0;
            if (scaledHeight < viewSize.Height)
                hOffset = 0;

            w += wOffset;
            h += hOffset;
            visibleImageRegion.Width = w;
            visibleImageRegion.Height = h;
            Bitmap result = new Bitmap(w, h);

            using (Graphics g = Graphics.FromImage(result))
            {
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(zoomImageBox.Image, new Rectangle(0, 0, w, h), visibleImageRegion, GraphicsUnit.Pixel);
            }
            //if( previewImageBox.Image != null)            
            //    previewImageBox.Image.Dispose();
            previewImageBox.Image = result;

            //if (originalPreview != null)
            //    originalPreview.Dispose();                  
            originalPreview = result;
            resultPreview = null;
        }

        private void UpdateMiniMap()
        {
            Rectangle proposedView;
            Size viewSize;
            Point location;
            double x;
            double y;
            double w;
            double h;

            // define the initial size. We'll take the current
            // size from the source imagebox's image viewport
            viewSize = zoomImageBox.GetImageViewPort().
                                    Size;
            w = viewSize.Width;
            h = viewSize.Height;

            // next we need to scale the size to match the zoomfactor of the source imagebox
            w /= zoomImageBox.ZoomFactor;
            h /= zoomImageBox.ZoomFactor;

            // next we scale the size again - this time by the zoomfactor the destination imagebox
            w *= miniMapImageBox.ZoomFactor;
            h *= miniMapImageBox.ZoomFactor;

            // with the size define, we can now turn out attention to the origin
            // first, we get the current auto scroll offsets, and reverse them
            // to give us our origin
            x = -zoomImageBox.AutoScrollPosition.X;
            y = -zoomImageBox.AutoScrollPosition.Y;

            // next, we need to scale that to account for the source imagebox zoom
            x /= zoomImageBox.ZoomFactor;
            y /= zoomImageBox.ZoomFactor;

            // as with the size, we need to scale again to account for the destination imagebox
            x *= miniMapImageBox.ZoomFactor;
            y *= miniMapImageBox.ZoomFactor;

            // and for our final action, we need to offset the origin to account
            // for where the destination imagebox is painting the output image
            location = miniMapImageBox.GetImageViewPort().
                                       Location;
            x += location.X;
            y += location.Y;

            // all done, create the final rectangle for painting
            proposedView = new Rectangle(Convert.ToInt32(x), Convert.ToInt32(y), Convert.ToInt32(w), Convert.ToInt32(h));

            // see if the final rectangle is different to the one already being used
            // to avoid painting if we don't need to
            if (proposedView != _minimap)
            {
                _minimap = proposedView;

                // force the destination to repaint to show the new rectangle
                // this has performance issues
                // https://github.com/cyotek/Cyotek.Windows.Forms.ImageBox/issues/27
                miniMapImageBox.Invalidate();

                //imageViewPortToolStripStatusLabel.Text = "Image Viewport: " + zoomImageBox.GetImageViewPort().ToString();
                //calculatedRectangleToolStripStatusLabel.Text = "Rectangle: " + _minimap.ToString();
            }
        }

        private void RefreshMiniMap()
        {
            Image image;

            image = zoomImageBox.Image;

            if (image != null)
            {
                Bitmap minimap;
                Size minimapSize;

                // https://github.com/cyotek/Cyotek.Windows.Forms.ImageBox/issues/27
                // I found that ImageBox can cause performance issues if you instruct it
                // to paint a large image that is zoomed out repeatly. As the image for
                // our minimap doesn't actually change or allow zooming, lets create
                // a tiny version up front. To make it easy, the "mini map" ImageBox
                // has its VirtualMode property set to True, and the SizeMode set to
                // Fit. I then set the VirtualSize to be the size if the original
                // image and it will then calculate the size I need for the thumbnail
                // which saves me some manual work. However, it does mean that I need
                // to manually paint the thumbnail

                miniMapImageBox.VirtualSize = image.Size;
                minimapSize = miniMapImageBox.GetImageViewPort().
                                              Size;
                minimap = new Bitmap(minimapSize.Width, minimapSize.Height);

                // generate the thumbnail
                using (Graphics g = Graphics.FromImage(minimap))
                {
                    g.DrawImage(image, new Rectangle(Point.Empty, minimap.Size), new Rectangle(Point.Empty, image.Size), GraphicsUnit.Pixel);
                }

                // always clean up
                if (_thumbnailBitmap != null)
                {
                    _thumbnailBitmap.Dispose();
                    _thumbnailBitmap = null;
                }
                _thumbnailBitmap = minimap;

                // force a paint of the minimap
                UpdateMiniMap();
            }
        }

        private void FillZoomLevels()
        {
            zoomLevelsToolStripComboBox.Items.Clear();

            //for (int zoom = 50; zoom < 400; zoom += 50 )
            //{
            //    zoomLevelsToolStripComboBox.Items.Add($"{zoom}%");
            //}

            foreach (int zoom in zoomImageBox.ZoomLevels)
            {
                zoomLevelsToolStripComboBox.Items.Add(string.Format("{0}%", zoom));
            }
        }

        private void FitImage()
        {
            if (zoomImageBox.Image != null)
            {
                double zoomFactor = zoomImageBox.ZoomFactor;

                Size imageSize = zoomImageBox.Image.Size;
                int scaledWidth = Convert.ToInt32(imageSize.Width * zoomFactor);
                int scaledHeight = Convert.ToInt32(imageSize.Height * zoomFactor);

                Size viewSize = zoomImageBox.GetInsideViewPort().Size;

                if (scaledWidth < viewSize.Width && scaledHeight < viewSize.Height)
                {
                    zoomImageBox.ZoomToFit();
                }
            }
        }

        #endregion

        #region PREVIEW event handlers

        private void zoomImageBox_ImageChanged(object sender, EventArgs e)
        {
            RefreshMiniMap();
        }

        private void zoomImageBox_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateMiniMap();
            if (!zoomImageBox.IsPanning)
                UpdatePreview();            
        }

        private void zoomImageBox_PanEnd(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void zoomImageBox_Zoomed(object sender, ImageBoxZoomEventArgs e)
        {
            UpdateMiniMap();
            UpdatePreview();
            FitImage();
            UpdateStatusBar();
            zoomLevelsToolStripComboBox.Text = string.Format("{0}%", zoomImageBox.Zoom);
        }     

        private void OpenModelFolder(object sender, EventArgs e)
        {
            Process.Start(modelsPath_textBox.Text);
        }

        private void miniMapImageBox_Paint(object sender, PaintEventArgs e)
        {
            if (_thumbnailBitmap != null)
            {
                using (Pen pen = new Pen(Color.Aquamarine, 3))
                {
                    e.Graphics.DrawImage(_thumbnailBitmap, miniMapImageBox.GetImageViewPort().
                                                                           Location);
                    e.Graphics.DrawRectangle(pen, _minimap.X, _minimap.Y, _minimap.Width, _minimap.Height);
                }
            }
        }

        private void openFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "All Supported Images (*.bmp;*.dib;*.rle;*.gif;*.jpg;*.jpeg;*.png)|*.bmp;*.dib;*.rle;*.gif;*.jpg;*.jpeg;*.png|Bitmaps (*.bmp;*.dib;*.rle)|*.bmp;*.dib;*.rle|Graphics Interchange Format (*.gif)|*.gif|Joint Photographic Experts (*.jpg)|*.jpg|Portable Network Graphics (*.png)|*.png|All Files (*.*)|*.*";
                dialog.DefaultExt = "png";

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        OpenImage(dialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void previewImageBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (originalPreview == null || resultPreview == null)
                return;
            if (previewImageBox.Image == resultPreview)
                previewImageBox.Image = originalPreview;
        }

        private void previewImageBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (originalPreview == null || resultPreview == null)
                return;
            if (previewImageBox.Image == originalPreview)
                previewImageBox.Image = resultPreview;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1 && (Width != widthBeforeResize || Height != heightBeforeResize))
            {
                FitImage();
                UpdatePreview();
            }
        }

        private async void previewUpdate_button_Click(object sender, EventArgs e)
        {
            string modelPath = previewModels_comboBox.SelectedValue.ToString();
            if (originalPreview == null)
                return;

            preview_progressBar.Style = ProgressBarStyle.Marquee;
            preview_progressBar.MarqueeAnimationSpeed = 30;
            Bitmap preview = await ViewModel.CreatePreview(originalPreview, modelPath);
            preview_progressBar.Style = ProgressBarStyle.Continuous;
            preview_progressBar.MarqueeAnimationSpeed = 0;
            if (preview != null)
            {
                previewImageBox.Image = preview;
                resultPreview = preview;
            }
            else
            {
                MessageBox.Show($"Failed to create preview! Logs saved in <{ViewModel.previeIEU.EsrganPath}>");
            }
        }

        private async void previewSave_button_Click(object sender, EventArgs e)
        {
            string modelPath = previewModels_comboBox.SelectedValue.ToString();
            if (zoomImageBox.Image == null)
                return;
            preview_progressBar.Style = ProgressBarStyle.Marquee;
            preview_progressBar.MarqueeAnimationSpeed = 30;
            Bitmap preview = await ViewModel.CreatePreview((Bitmap)zoomImageBox.Image, modelPath);
            preview_progressBar.Style = ProgressBarStyle.Continuous;
            preview_progressBar.MarqueeAnimationSpeed = 0;
            if (preview != null)
            {
                string modelName = Path.GetFileNameWithoutExtension(modelPath);
                string dir = Path.GetDirectoryName(previewFullname);
                string fileName = Path.GetFileNameWithoutExtension(previewFullname);
                preview.Save(dir + "\\" + fileName + "_" + modelName + ".png");
            }
            else
            {
                MessageBox.Show("Failed to create preview, sorry!");
            }
        }

        private void zoomLevelsToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int zoom;

            zoom = Convert.ToInt32(zoomLevelsToolStripComboBox.Text.Substring(0, zoomLevelsToolStripComboBox.Text.Length - 1));

            zoomImageBox.Zoom = zoom;
        }

        private void zoomInToolStripButton_Click(object sender, EventArgs e)
        {
            zoomImageBox.ZoomIn();
        }

        private void zoomOutToolStripButton_Click(object sender, EventArgs e)
        {
            zoomImageBox.ZoomOut();
        }

        private void actualSizeToolStripButton_Click(object sender, EventArgs e)
        {
            zoomImageBox.ActualSize();
        }

        private void zoomImageBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (filePaths.Length == 1)
            {
                try
                {
                    OpenImage(filePaths[0]);
                }
                catch
                {
                    MessageBox.Show("Failed to open image");
                }
            }
        }


        #endregion

        #region MainForm

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            widthBeforeResize = Width;
            heightBeforeResize = Height;
            RectangleF visibleImageRegion = zoomImageBox.GetSourceImageRegion();
            visibleImageWidthBeforeResize = Convert.ToInt32(visibleImageRegion.Width);
            visibleImageHeightBeforeResize = Convert.ToInt32(visibleImageRegion.Height);
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1 && (widthBeforeResize != Width || heightBeforeResize != Height))
                FitImage();
            else
                return;

            RectangleF visibleImageRegion = zoomImageBox.GetSourceImageRegion();
            int w = Convert.ToInt32(visibleImageRegion.Width);
            int h = Convert.ToInt32(visibleImageRegion.Height);

            if (Math.Abs(visibleImageWidthBeforeResize - w) <= 2 && Math.Abs(visibleImageHeightBeforeResize - h) <= 2)
                return;

            UpdatePreview();
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

        #endregion

        #region BUTTONS

        private void changePath_button_Click(object sender, EventArgs e)
        {
            TextBox textBox = (sender as Button).Tag as TextBox;
            FolderSelectDialog.FolderSelectDialog folderSelectDialog = new FolderSelectDialog.FolderSelectDialog();
            folderSelectDialog.ShowDialog();
            if (folderSelectDialog.FileName != "")
                textBox.Text = folderSelectDialog.FileName;

            main_tabPage.Enabled = VerifyPaths();
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
            bool success = await ViewModel.CreateInterpolatedModel(
                interpolationModelOne_comboBox.SelectedValue.ToString(),
                interpolationModelTwo_comboBox.SelectedValue.ToString(),
                alphaValue,
                interpolationOutputModelName_textBox.Text);      
        }

        #endregion

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
                if (useDifferentModelForAlpha_checkBox.Checked)
                {
                    lastUseDifferentModelAlpha = true;
                    useDifferentModelForAlpha_checkBox.Checked = false;
                }                         
            else            
                if (lastUseDifferentModelAlpha)
                    useDifferentModelForAlpha_checkBox.Checked = lastUseDifferentModelAlpha;                       
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

        
        private void general_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void mainTab_DragDrop(object sender, DragEventArgs e)
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
                        else
                        {
                            File.Copy(path, imgPath_textBox.Text + Path.DirectorySeparatorChar + Path.GetFileName(path), true);
                            imagesCopied++;
                        }
                    }
                }
            MessageBox.Show($"Succesfully copied {imagesCopied} files" + (modelsCopied > 0 ? $" and { modelsCopied} models" : ""));
        }

        private void InterpolationSettingsChanged(object sender, EventArgs e)
        {
            interpolationOutputModelName_textBox.Text =
                $"{((ModelInfo)interpolationModelOne_comboBox.SelectedItem)?.Name.Replace(".pth", "")}_" +
                $"{((ModelInfo)interpolationModelTwo_comboBox.SelectedItem)?.Name.Replace(".pth", "")}_" +
                $"interp_{interpolationAlphaValue_textBox.Text.Replace(",", "").Replace(".", "")}.pth";
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
            ViewModel.FilterSelectedExtensionsList = checkedListBox.CheckedItems.Cast<string>().ToList(); //hack
            if (checkedListBox.CheckedItems.Contains(selectedITem))
                ViewModel.FilterSelectedExtensionsList.Remove(checkedListBox.SelectedItem.ToString());
            else
                ViewModel.FilterSelectedExtensionsList.Add(checkedListBox.SelectedItem.ToString());
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
               
        private void preciseTile_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            overlapSize_numericUpDown.Enabled = !preciseTile_checkBox.Checked;
        }

       
    }    
}
