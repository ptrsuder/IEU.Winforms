using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
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
using ImageEnhancingUtility.Core.Utility;
using ReactiveUI;
using Tulpep.NotificationWindow;
using Rule = ImageEnhancingUtility.Core.Rule;

//TODO:
//ask to change all paths when changing ESRGAN path
//change VerifyPaths?

namespace ImageEnhancingUtility.Winforms
{
    public partial class MainForm : Form, IViewFor<MainViewModel>
    {
        public readonly string AppVersion = "0.13.0";
        public readonly string GitHubRepoName = "IEU.Winforms";

        public MainViewModel ViewModel { get; set; }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (MainViewModel)value;
        }        

        private MyTreeView treeView1;

        List<ModelInfo> checkedModels = new List<ModelInfo>();

        readonly List<TextBox> pathsTextBoxes;   
      
        private delegate void SafeCallDelegateWithColor(LogMessage message);      
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
                progressBar1.Value = (int)value;
                if(ViewModel.IEU.FilesDone == ViewModel.IEU.FilesTotal && ViewModel.IEU.InMemoryMode)                
                    ShowNotification("\nFinished processing images");
                
                progress_label.Text = $@"{ViewModel.IEU.FilesDone}/{ViewModel.IEU.FilesTotal}"; //hack, change to reactive bindings 
                progressFiltered_label.Text = ViewModel.IEU.FilesDoneSuccesfully.ToString();
            }
        }
              
        [DllImport("user32.dll")] //textbox hint
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        #region CONSTRUCTOR
               
        public MainForm()
        {
            InitializeComponent();
            
            //disable mousewheel scrolling:
            outputDestinationMode_comboBox.MouseWheel += (o, e) => ((HandledMouseEventArgs)e).Handled = true;
            overwriteMode_comboBox.MouseWheel += (o, e) => ((HandledMouseEventArgs)e).Handled = true;            

            CreateMyTreeView();

            treeView_contextMenuStrip.Items[0].Click += OpenModelFolder;
            treeView_contextMenuStrip.Items[1].Click += (o, e) => ViewModel.IEU.CreateModelTree(); 

            FormClosing += MainForm_FormClosing;             

            profiles_listBox.DisplayMember =
            profilesMainTab_listBox.DisplayMember = 
            ruleProfiles_comboBox.DisplayMember =                      
            filters_listBox.DisplayMember =         
            ruleFilters_comboBox.DisplayMember = "Name";

            ViewModel = new MainViewModel();

            BindMainTab();
            BindConfig();

            BindRuleSystem();            

            modelForAlpha_comboBox.DataSource = new BindingSource(ViewModel.IEU.ModelsItems.Items, null); //initial value
            profileModel_comboBox.DataSource = new BindingSource(ViewModel.IEU.ModelsItems.Items, null); //initial value

            BindSettingsTab();

            BindCommands();

            pathsTextBoxes = new List<TextBox> {  esrganPath_textBox, imgPath_textBox, modelsPath_textBox };
            var pathTextBoxesAll = new List<TextBox> { esrganPath_textBox, imgPath_textBox, resultsMergedPath_textBox, modelsPath_textBox, inputPath_textBox, outputPath_textBox };
            foreach (TextBox t in pathTextBoxesAll)
            {
                t.AllowDrop = true;
                t.DragDrop += new DragEventHandler(textbox_DragDrop);
                t.DragEnter += new DragEventHandler(general_DragEnter);
            }
            SetPathButtons();

            appVersion_label.Text = "IEU.Winforms v" + this.AppVersion;
            appCoreVersion_linkLabel.Text = "IEU.Core v" + ViewModel.IEU.AppVersion;

            interpolationModelOne_comboBox.DisplayMember =
            interpolationModelTwo_comboBox.DisplayMember =
            modelForAlpha_comboBox.DisplayMember =
            profileModel_comboBox.DisplayMember =
            previewModels_comboBox.DisplayMember = "ComboBoxName";
            //interpolationModelOne_comboBox.ValueMember =
            //interpolationModelTwo_comboBox.ValueMember =
            //modelForAlpha_comboBox.ValueMember =
            //profileModel_comboBox.ValueMember =
            //previewModels_comboBox.ValueMember = "Value";

            if (ViewModel.IEU.ModelsItems.Count > 0)
            {         
                this.Bind(ViewModel,
                   vm => vm.IEU.CurrentProfile.ModelForAlpha,
                   v => v.modelForAlpha_comboBox.SelectedIndex,
                   x => x == null ? 0 : ViewModel.IEU.ModelsItems.Items.ToList().FindIndex(y => y.FullName == x.FullName),
                   x => GetModel(x));

                this.Bind(ViewModel,
                   vm => vm.IEU.CurrentProfile.Model,
                   v => v.profileModel_comboBox.SelectedIndex,
                   x => GetIndex(x),
                   x => GetModel(x));
            }

            lastUseDifferentModelAlpha = useDifferentModelForAlpha_checkBox.Checked;

            #region bind references
            //Observable.FromEvent<ItemCheckEventHandler, ItemCheckEventArgs>(ev => filterExtensions_checkedListBox.ItemCheck += ev, ev => filterExtensions_checkedListBox.ItemCheck -= ev)
            //    .Select((x,y) => filterExtensions_checkedListBox.CheckedItems)
            //    .BindTo(ViewModel, vm => vm.IEU.filterSelectedExtensionsList, vmToViewConverterOverride: new ListboxToListConverter());

            //Observable.FromEventPattern(ev => ItemsListBox.SelectedValueChanged += ev, ev => ItemsListBox.SelectedValueChanged -= ev)
            //.Select(_ => ItemsListBox.SelectedItem)
            //.BindTo(_vm, vm => vm.IEU.SelectedItem);

            //this.WhenActivated(d =>
            //{
            //    d(this.Bind(ViewModel, vm => vm.IEU.esrganPath, v => v.esrganPath_textBox.Text));                
            //});

            //var selectionChanged = Observable.FromEvent<EventHandler, EventArgs>(
            //  h => (_, e) => h(e),
            //  ev => ddsTextureType_comboBox.SelectedIndexChanged += ev,
            //  ev => ddsTextureType_comboBox.SelectedIndexChanged += ev);
            #endregion

            BindOutputFormats();

            BindAdvanced();

            if (ViewModel.Config.CheckForUpdates)
            {
                ViewModel.IEU.Logger.Write("Checking new releases on github...");
                CheckNewReleases();
            }

            zoomImageBox.VerticalScroll.Enabled = false;

            imageA_panel.Tag = imageA_pictureBox;
            imageB_panel.Tag = imageB_pictureBox;
            imageA_pictureBox.SizeMode = imageB_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageAName_label.Text = imageBName_label.Text = "";

            originalImagesPath_textBox.Text = imgPath_textBox.Text;
            resultsDestinationPath_textBox.Text = resultsMergedPath_textBox.Text;

            treeView1.Enabled = !useProfileModel_checkBox.Checked;

            inMemoryMode_checkBox.Checked = !inMemoryMode_checkBox.Checked; //HACK
            inMemoryMode_checkBox.Checked = !inMemoryMode_checkBox.Checked; //LAZY

            comparisonMod_comboBox.DataSource = new BindingSource(IEU.ResizeImageScaleFactors, null);
            comparisonMod_comboBox.SelectedIndex = 2;

            SetStepVisibility(false);          
        }

        #endregion              

        #region BINDINGS

        void BindMainTab()
        {
            this.OneWayBind(ViewModel, vm => vm.IEU.OutputDestinationModes, v => v.outputDestinationMode_comboBox.DataSource, x => new BindingSource(x, null));
            outputDestinationMode_comboBox.DisplayMember = "Key";
            outputDestinationMode_comboBox.ValueMember = "Value";
            this.Bind(ViewModel, vm => vm.IEU.OutputDestinationMode, v => v.outputDestinationMode_comboBox.SelectedValue, x => x, x => (int)x);

            this.OneWayBind(ViewModel, vm => vm.IEU.OverwriteModes, v => v.overwriteMode_comboBox.DataSource, x => new BindingSource(x, null));
            overwriteMode_comboBox.DisplayMember = "Key";
            overwriteMode_comboBox.ValueMember = "Value";
            this.Bind(ViewModel, vm => vm.IEU.OverwriteMode, v => v.overwriteMode_comboBox.SelectedValue);

            this.OneWayBind(ViewModel, vm => vm.IEU.ProgressBarValue, v => v.ProgressBarValue);

            this.Bind(ViewModel, vm => vm.IEU.UseModelChain, v => v.UseModelChain_checkBox.Checked);
        }

        void BindConfig()
        {
            this.Bind(ViewModel, vm => vm.Config.WindowOnTop, v => v.topMost_checkBox.Checked);
            this.OneWayBind(ViewModel, vm => vm.Config.WindowOnTop, v => v.TopMost);
            this.Bind(ViewModel, vm => vm.Config.ShowPopups, v => v.showPopups_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.Config.CheckForUpdates, v => v.checkForUpdates_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.Config.ShowPreviewSaveDialog, v => v.previewShowSaveDialog_checkBox.Checked);
        }

        void BindSettingsTab()
        {
            this.Bind(ViewModel, vm => vm.IEU.ResultsPath, v => v.outputPath_textBox.Text);
            this.Bind(ViewModel, vm => vm.IEU.ModelsPath, v => v.modelsPath_textBox.Text);
            this.Bind(ViewModel, vm => vm.IEU.LrPath, v => v.inputPath_textBox.Text);
            this.Bind(ViewModel, vm => vm.IEU.InputDirectoryPath, v => v.imgPath_textBox.Text);
            this.Bind(ViewModel, vm => vm.IEU.OutputDirectoryPath, v => v.resultsMergedPath_textBox.Text);
            this.Bind(ViewModel, vm => vm.IEU.EsrganPath, v => v.esrganPath_textBox.Text);

            this.Bind(ViewModel, vm => vm.IEU.MaxTileResolution, v => v.maxTileResolution_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.IEU.MaxTileResolutionWidth, v => v.maxTileWidth_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.IEU.MaxTileResolutionHeight, v => v.maxTileHeight_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.IEU.PreciseTileResolution, v => v.preciseTile_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.IgnoreAlpha, v => v.ignoreAlpha_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.IgnoreSingleColorAlphas, v => v.ignoreSingleColorAlpha_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.BalanceAlphas, v => v.balanceAlphas_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.BalanceRgb, v => v.balanceRgb_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.DeleteResults, v => v.deleteResults_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CreateMemoryImage, v => v.createMemoryImage_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.UseOriginalImageFormat, v => v.preserveFormat_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.SplitRGB, v => v.splitRGB_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.UseCPU, v => v.useCPU_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.UseBasicSR, v => v.useBasicSR_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.UseDifferentModelForAlpha, v => v.useDifferentModelForAlpha_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.UseFilterForAlpha, v => v.useFilterForAlpha_checkBox.Checked);         

            filterForAlpha_comboBox.DataSource = new BindingSource(Dictionaries.MagickFilterTypes, null);
            filterForAlpha_comboBox.DisplayMember = "Value";
            filterForAlpha_comboBox.ValueMember = "Key";
            filterForAlpha_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.AlphaFilterType, v => v.filterForAlpha_comboBox.SelectedValue, x => x, x => (int)x);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.UseModel, v => v.useProfileModel_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.SeamlessTexture, v => v.seamlessTextures_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.OverlapSize, v => v.overlapSize_numericUpDown.Value, x => x, x => (int)x);

            this.Bind(ViewModel, vm => vm.IEU.UseCondaEnv, v => v.useCondaEnv_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CondaEnv, v => v.condaEnvName_textBox.Text);
            
            this.Bind(ViewModel, vm => vm.IEU.EnableBlend, v => v.useMblend_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.InMemoryMode, v => v.inMemoryMode_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.UseImageMagickMerge, v => v.useImMerge_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.UseOldVipsMerge, v => v.useOldVipsMerge_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.DebugMode, v => v.showDebugInfo_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.IEU.VramMonitorEnable, v => v.monitorVram_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.VramMonitorFrequency, v => v.monitorFrequency_numericUpDown.Value, x => x, y => decimal.ToInt32(y));

            this.Bind(ViewModel, vm => vm.IEU.AutoSetTileSizeEnable, v => v.autoSetTileSize_checkBox.Checked);

            this.OneWayBind(ViewModel, vm => vm.IEU.NoNvidia, v => v.autoSetTileSize_checkBox.Enabled, x => !x);
            this.OneWayBind(ViewModel, vm => vm.IEU.NoNvidia, v => v.monitorVram_checkBox.Enabled, x => !x);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.PaddingSize, v => v.tilesPadding_numericUpDown.Value, x => x, y => decimal.ToInt32(y));

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.UseJoey, v => v.useJoey_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.RgbaModel, v => v.supportRgba_checkBox.Checked);
        }
        
        void BindOutputFormats()
        {
            ddsTextureType_comboBox.DataSource = new BindingSource(Dictionaries.ddsTextureType, null);
            ddsTextureType_comboBox.DisplayMember = "Key";
            ddsTextureType_comboBox.ValueMember = "Value";
            ddsTextureType_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.DdsTextureTypeSelectedIndex, v => v.ddsTextureType_comboBox.SelectedIndex);

            ddsFileFormat_comboBox.DisplayMember = "Name";
            ddsFileFormat_comboBox.ValueMember = "DdsFileFormat";

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.DdsFileFormatsCurrent, v => v.ddsFileFormat_comboBox.DataSource);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.DdsFileFormatSelectedIndex, v => v.ddsFileFormat_comboBox.SelectedIndex);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.DdsGenerateMipmaps, v => v.ddsGenerateMipmaps_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.DdsIsCubemap, v => v.ddsIsCubemap_checkBox.Checked);

            ddsCompresion_comboBox.DataSource = new List<string>() { "Fast", "Normal", "Slow (best)" };
            ddsCompresion_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.DdsBC7CompressionSelected, v => v.ddsCompresion_comboBox.SelectedIndex);

            outputFormat_comboBox.DataSource = new BindingSource(ViewModel.IEU.CurrentProfile.FormatInfos, null);
            outputFormat_comboBox.DisplayMember = "DisplayName";
            outputFormat_comboBox.ValueMember = "Extension";
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.SelectedOutputFormatIndex, v => v.outputFormat_comboBox.SelectedIndex);

            outputFormatPreview_comboBox.DataSource = new BindingSource(ViewModel.IEU.CurrentProfile.FormatInfos, null);
            outputFormatPreview_comboBox.DisplayMember = "DisplayName";
            outputFormatPreview_comboBox.ValueMember = "Extension";
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.SelectedOutputFormatIndex, v => v.outputFormatPreview_comboBox.SelectedIndex);


            tiffSettings_comboBox.DataSource = new BindingSource(Dictionaries.TiffCompressionModes, null);
            tiffSettings_comboBox.DisplayMember = "Key";
            tiffSettings_comboBox.ValueMember = "Value";
            tiffSettings_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.tiffFormat.CompressionMethod, v => v.tiffSettings_comboBox.SelectedValue, x => x, x => (string)x);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.tiffFormat.QualityFactor, v => v.tiffJpegQuality_numericUpDown.Value, x => x, y => decimal.ToInt32(y));

            webpPreset_comboBox.DataSource = new BindingSource(Dictionaries.WebpPresets, null);
            webpPreset_comboBox.DisplayMember = "Key";
            webpPreset_comboBox.ValueMember = "Value";
            webpPreset_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.webpFormat.CompressionMethod, v => v.webpPreset_comboBox.SelectedValue, x => x, x => (string)x);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.webpFormat.QualityFactor, v => v.webpQuality_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.pngFormat.CompressionFactor, v => v.pngCompression_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
        }

        void BindRuleSystem()
        {            
            this.Bind(ViewModel, vm => vm.IEU.DisableRuleSystem, v => v.disableRuleSystem_checkBox.Checked);
            ViewModel.WhenAnyValue(vm => vm.IEU.DisableRuleSystem).Subscribe(x => HideRules(x));

            ViewModel.IEU.Logger.Log.Connect()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out ReadOnlyObservableCollection<LogMessage> bindingData)
                .OnItemAdded(x => WriteToLogsThreadSafe(x))
                .Subscribe();

            ViewModel.IEU.Profiles.Connect()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out ReadOnlyObservableCollection<Profile>  bindingDataProfiles)
                .Subscribe(x => UpdateDataSource(profiles_listBox, ruleProfiles_comboBox, bindingDataProfiles));

            ViewModel.IEU.Filters.Connect()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out ReadOnlyObservableCollection < Filter > bindingDataFilters)
                .Subscribe(x => UpdateDataSource(filters_listBox, ruleFilters_comboBox, bindingDataFilters));

            ViewModel.IEU.ModelsItems.Connect()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out ReadOnlyObservableCollection<ModelInfo> bindingDataModels)
                .Subscribe(_ => UpdateModels(bindingDataModels));

            rules_listBox.DisplayMember = "Name";
            rules_listBox.DataSource = new BindingSource(ViewModel.IEU.Ruleset.Values.ToList(), null);
        }

        void BindCommands()
        {    
            this.BindCommand(ViewModel, vm => vm.IEU.SplitCommand, v => v.crop_button);
            this.BindCommand(ViewModel, vm => vm.IEU.UpscaleCommand, v => v.upscale_button);
            this.BindCommand(ViewModel, vm => vm.IEU.MergeCommand, v => v.merge_button);
            this.BindCommand(ViewModel, vm => vm.IEU.SplitUpscaleMergeCommand, v => v.runAll_button);
           
            ViewModel.IEU.SplitCommand.ThrownExceptions.Subscribe(error => WriteErrors(error));
            ViewModel.IEU.UpscaleCommand.ThrownExceptions.Subscribe(error => WriteErrors(error));
            ViewModel.IEU.MergeCommand.ThrownExceptions.Subscribe(error => WriteErrors(error));      
            ViewModel.IEU.SplitUpscaleMergeCommand.ThrownExceptions.Subscribe(error => WriteErrors(error));

            ViewModel.IEU.SplitUpscaleMergeCommand.Subscribe(
                showNotif => ShowNotification("\nFinished processing images", !showNotif));
        }        
              
        void BindAdvanced()
        {
            this.Bind(ViewModel, vm => vm.IEU.UseResultSuffix, v => v.advancedUseSuffix_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.ResultSuffix, v => v.advancedSuffix_textBox.Text);

            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FilenameCaseSensitive, v => v.filterFilenameCaseSensitive_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FilenameContainsEnabled, v => v.filterFilenameContains_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FilenameContainsPattern, v => v.filterFilenameContains_textBox.Text);

            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FilenameNotContainsEnabled, v => v.filterFilenameNotContains_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FilenameNotContainsPattern, v => v.filterFilenameNotContains_textBox.Text);

            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FolderNameCaseSensitive, v => v.filterFolderNameCaseSensitive_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FolderNameContainsEnabled, v => v.filterFolderNameContains_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FolderNameContainsPattern, v => v.filterFolderNameContains_textBox.Text);

            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FolderNameNotContainsEnabled, v => v.filterFolderNameNotContains_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FolderNameNotContainsPattern, v => v.filterFolderNameNotContains_textBox.Text);

            filterAlpha_comboBox.DataSource = Filter.FiltersAlpha;
            filterAlpha_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.Alpha, v => v.filterAlpha_comboBox.SelectedIndex);

            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.ImageResolutionEnabled, v => v.filtersSizeOn_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.ImageResolutionOr, v => v.filterSizeOr_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.ImageResolutionMaxWidth, v => v.filterSizeWidth_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.ImageResolutionMaxHeight, v => v.filterSizeHeight_numericUpDown.Value, x => x, y => decimal.ToInt32(y));

            foreach (var item in Filter.ExtensionsList)
                filterExtensions_checkedListBox.Items.Add(item);

            noiseReductionType_comboBox.DataSource = IEU.NoiseReductionTypes;
            noiseReductionType_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.NoiseReductionType, v => v.noiseReductionType_comboBox.SelectedIndex);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.ThresholdEnabled, v => v.thresholdEnabledRbg_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.ThresholdAlphaEnabled, v => v.thresholdEnabledAlpha_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.ThresholdBlackValue, v => v.thresholdBlack_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.ThresholdWhiteValue, v => v.thresholdWhite_numericUpDown.Value, x => x, y => decimal.ToInt32(y));

            #region #RESIZE
            resizeImageBeforeScaleFactor_comboBox.DataSource = new BindingSource(IEU.ResizeImageScaleFactors, null);
            resizeImageBeforeScaleFactor_comboBox.SelectedIndex = 3;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.ResizeImageBeforeScaleFactor, v => v.resizeImageBeforeScaleFactor_comboBox.Text, x => x.ToString(), x => Double.Parse(x.ToString()));

            resizeImageBeforeFilterType_comboBox.DataSource = new BindingSource(Dictionaries.MagickFilterTypes, null);
            resizeImageBeforeFilterType_comboBox.DisplayMember = "Value";
            resizeImageBeforeFilterType_comboBox.ValueMember = "Key";
            resizeImageBeforeFilterType_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.ResizeImageBeforeFilterType, v => v.resizeImageBeforeFilterType_comboBox.SelectedValue, x => x, x => (int)x);

            resizeImageAfterScaleFactor_comboBox.DataSource = new BindingSource(IEU.ResizeImageScaleFactors, null);
            resizeImageAfterScaleFactor_comboBox.SelectedIndex = 3;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.ResizeImageAfterScaleFactor, v => v.resizeImageAfterScaleFactor_comboBox.Text, x => x.ToString(), x => Double.Parse(x.ToString()));

            resizeImageAfterFilterType_comboBox.DataSource = new BindingSource(Dictionaries.MagickFilterTypes, null);
            resizeImageAfterFilterType_comboBox.DisplayMember = "Value";
            resizeImageAfterFilterType_comboBox.ValueMember = "Key";
            resizeImageAfterFilterType_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.ResizeImageAfterFilterType, v => v.resizeImageAfterFilterType_comboBox.SelectedValue, x => x, x => (int)x);
            #endregion         
        }

        #endregion

        #region MODELS/TREEVIEW

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

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            checkedModels = treeView1.Nodes.Find("", true).Where(x => x.Checked).ToList()
                .ConvertAll(x => x.Tag as ModelInfo)
                .Where(x => x?.GetType().ToString() == "ImageEnhancingUtility.Core.ModelInfo").ToList();
            ViewModel.IEU.SelectedModelsItems = checkedModels; //hack, change to reactive bindings          

            DisableUseModelForAlpha();           
        }

        void UpdateDataSource(ListBox listBox, ComboBox comboBox, ReadOnlyObservableCollection<Profile> bindingData)
        {
            listBox.DataSource = new BindingSource(bindingData, null);
            profilesMainTab_listBox.DataSource = new BindingSource(bindingData, null);
            comboBox.DataSource = new BindingSource(bindingData, null);
        }

        void UpdateDataSource(ListBox listBox, ComboBox comboBox, ReadOnlyObservableCollection<Filter> bindingData)
        {
            listBox.DataSource = new BindingSource(bindingData, null);
            comboBox.DataSource = new BindingSource(bindingData, null);
        }

        void UpdateModels(ReadOnlyObservableCollection<ModelInfo> bindingDataModels)
        {
            if (bindingDataModels.Count == 0) return;
            string selectedModelFullname = ViewModel.IEU.CurrentProfile.ModelForAlpha?.FullName;            
            modelForAlpha_comboBox.DataSource = new BindingSource(bindingDataModels, null);
            int lastSelectedIndex = bindingDataModels.ToList().FindIndex(y => y.FullName == selectedModelFullname);
            if (lastSelectedIndex >= bindingDataModels.Count || lastSelectedIndex < 0)
                lastSelectedIndex = 0;
            modelForAlpha_comboBox.SelectedIndex = lastSelectedIndex;

            selectedModelFullname = ViewModel.IEU.CurrentProfile.Model?.FullName;
            profileModel_comboBox.DataSource = new BindingSource(bindingDataModels, null);
            lastSelectedIndex = bindingDataModels.ToList().FindIndex(y => y.FullName == selectedModelFullname);
            if (lastSelectedIndex >= bindingDataModels.Count || lastSelectedIndex < 0)
                lastSelectedIndex = 0;
            profileModel_comboBox.SelectedIndex = lastSelectedIndex;

            selectedModelFullname = (interpolationModelOne_comboBox.SelectedItem as ModelInfo)?.FullName;
            interpolationModelOne_comboBox.DataSource = new BindingSource(bindingDataModels, null);
            lastSelectedIndex = bindingDataModels.ToList().FindIndex(y => y.FullName == selectedModelFullname);
            if (lastSelectedIndex >= bindingDataModels.Count || lastSelectedIndex < 0)
                lastSelectedIndex = 0;
            interpolationModelOne_comboBox.SelectedIndex = lastSelectedIndex;            

            selectedModelFullname = (interpolationModelTwo_comboBox.SelectedItem as ModelInfo)?.FullName;
            interpolationModelTwo_comboBox.DataSource = new BindingSource(bindingDataModels, null);
            lastSelectedIndex = bindingDataModels.ToList().FindIndex(y => y.FullName == selectedModelFullname);
            if (lastSelectedIndex >= bindingDataModels.Count || lastSelectedIndex < 0)
                lastSelectedIndex = 0;
            interpolationModelTwo_comboBox.SelectedIndex = lastSelectedIndex;

            selectedModelFullname = (previewModels_comboBox.SelectedItem as ModelInfo)?.FullName;
            previewModels_comboBox.DataSource = new BindingSource(bindingDataModels, null);            
            lastSelectedIndex = bindingDataModels.ToList().FindIndex(y => y.FullName == selectedModelFullname);
            if (lastSelectedIndex >= bindingDataModels.Count || lastSelectedIndex < 0)
                lastSelectedIndex = 0;
            previewModels_comboBox.SelectedIndex = lastSelectedIndex;

            if (bindingDataModels.Count > 0)
                CreateModelTree(bindingDataModels);
        }

        ModelInfo GetModel(int x)
        {
            if(x == -1)
                return ViewModel.IEU.ModelsItems.Items.ToList()[0];
            return ViewModel.IEU.ModelsItems.Items.ToList()[x];
        }

        int GetIndex(ModelInfo x)
        {
            int r = x == null ? 0 : ViewModel.IEU.ModelsItems.Items.ToList().FindIndex(y => y.FullName == x.FullName);
            return r;
        }        
        
        void CreateModelTree(IEnumerable<ModelInfo> items)
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

        #endregion

        #region NOTIFICATIONS
        bool notificationActive = false;
        PopupNotifier popup;
        void ShowNotification(string message, bool ignore = false)
        {
            if (ignore) return;
            if (ViewModel.Config.ShowPopups)
            {
                popup = new PopupNotifier();
                popup.Delay = 300000;
                popup.TitleText = "Operation completed!";
                popup.ContentText = message;
                popup.Click += Popup_Click;
                popup.Popup();
                notificationActive = true;
            }
        }

        private void Popup_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        #endregion

        #region LOG
        private void WriteToLogsThreadSafe(LogMessage message)
        {
            if (richTextBox1.InvokeRequired)
            {
                var d = new SafeCallDelegateWithColor(WriteToLogsThreadSafe);
                Invoke(d, new object[] { message });
            }
            else
            {
                richTextBox1.AppendText(message.Text, message.Color);
            }
        }        
        void WriteErrors(Exception error)
        {
            if (error.InnerException != null)
                WriteToLogsThreadSafe(new LogMessage(error.InnerException.Message, Color.Red));
            else
                WriteToLogsThreadSafe(new LogMessage(error.Message, Color.Red));
        }
        #endregion

        async Task CheckNewReleases()
        {
            var checkerWinforms = new UpdateChecker("ptrsuder", GitHubRepoName, AppVersion);
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            UpdateType updateWinforms = await checkerWinforms.CheckUpdate();

            string updateMessage = "";

            switch (updateWinforms)
            {
                case UpdateType.None:
                    ViewModel.IEU.Logger.Write("No new updates.");
                    break;
                case UpdateType.Fail:
                    ViewModel.IEU.Logger.Write("Failed to check updates.");
                    ViewModel.IEU.Logger.Write(checkerWinforms.ErrorMessage);
                    break;
                default:
                    updateMessage += "New version is available!";
                    using (UpdateNotifyDialog updateNotifyDialog = new(checkerWinforms, updateMessage))
                    {
                        updateNotifyDialog.ShowDialog(this);
                    }
                    break;
            }
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
            {
                MessageBox.Show(message);
            }

            main_tabPage.Enabled = allgood;
            interpolation_tabPage.Enabled = allgood;

            return allgood;
        }
        void SetPathButtons()
        {
            progress_label.Text = "0/0";
            changeEsrganPath_button.Tag = esrganPath_textBox;
            changeInputImgPath_button.Tag = imgPath_textBox;
            changeMergedResultsPath_button.Tag = resultsMergedPath_textBox;
            changeInputPath_button.Tag = inputPath_textBox;
            changeOutputPath_button.Tag = outputPath_textBox;
            changeModelsPath_button.Tag = modelsPath_textBox;

            changeOriginalImagesPath_button.Tag = originalImagesPath_textBox;
            changeResultsAPath_button.Tag = resultsAPath_textBox;
            changeResultsBPath_button.Tag = resultsBPath_textBox;
            changeResultsDestinationPath_button.Tag = resultsDestinationPath_textBox;
        }
                
        bool lastUseDifferentModelAlpha = false;

        void DisableUseModelForAlpha()
        {
            useDifferentModelForAlpha_checkBox.Enabled = checkedModels.Count <= 1 || useProfileModel_checkBox.Checked;

            if (checkedModels.Count > 1)
                if (useDifferentModelForAlpha_checkBox.Checked)
                {
                    lastUseDifferentModelAlpha = true;
                    useDifferentModelForAlpha_checkBox.Checked = false;
                }
                else
                {
                    if (lastUseDifferentModelAlpha)
                        useDifferentModelForAlpha_checkBox.Checked = lastUseDifferentModelAlpha;
                }
        }

        void HideRules(bool on = true)
        {
            rules_groupBox.Visible = !on;
        }

        private void OpenModelFolder(object sender, EventArgs e)
        {
            Process.Start(modelsPath_textBox.Text);
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
            if (rect.Width > zoomImageBox.Image.Width) rect.Width = zoomImageBox.Image.Width;
            if (rect.Height > zoomImageBox.Image.Height) rect.Height = zoomImageBox.Image.Height;
            currentW = (int)Math.Floor(rect.Width);
            currentH = (int)Math.Round(rect.Height);
            imageSizeToolStripStatusLabel.Text = $"W:{currentW}, H:{currentH}";            
        }

        private void OpenImage(string fullname)
        {          
            originalPreview = null;
            resultPreview = null;

            Image image = ImageOperations.LoadImageToBitmap(fullname);
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
                if (level > minimumZoom && level <= 600)
                {
                    levels.Add(level);
                }
            }
            FillZoomLevels();
            UpdateStatusBar();           
            zoomImageBox.ZoomToFit();
            FitImage();
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
            Size previewSize = previewImageBox.GetInsideViewPort().Size;
                       
            //visibleImageRegion.Width = Convert.ToInt32(previewSize.Width / zoomFactor) ;
            //visibleImageRegion.Height = Convert.ToInt32(previewSize.Height / zoomFactor) ;           

            if (previewSize.Width == viewSize.Width)
            {
                wOffset = 0;
                h = imageSize.Height;               
            }
            if (previewSize.Height == viewSize.Height)
            {
                hOffset = 0;
                w = imageSize.Width;
            }

            w = (int)visibleImageRegion.Width + wOffset;
            h = (int)visibleImageRegion.Height + hOffset;

            Bitmap result = new Bitmap(w, h);

            visibleImageRegion.Width += wOffset;
            visibleImageRegion.Height += hOffset;

            using (Graphics g = Graphics.FromImage(result))
            {
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(
                    zoomImageBox.Image,
                    new Rectangle(0, 0, (int)visibleImageRegion.Width, (int)visibleImageRegion.Height),
                    visibleImageRegion,
                    GraphicsUnit.Pixel);
            }

            previewImageBox.Image = result;                        
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
        
        private void PreviewInProgress(bool inProgress)
        {
            int progress = inProgress ? 30 : 0;
            bool enabled = !inProgress;
            preview_progressBar.Style = inProgress ? ProgressBarStyle.Marquee : preview_progressBar.Style = ProgressBarStyle.Continuous;
            preview_progressBar.MarqueeAnimationSpeed = progress;
            previewUpdate_button.Enabled = enabled;
            zoomImageBox.Enabled = enabled;
            previewModels_comboBox.Enabled = enabled;
            button_previewSaveComparison.Enabled = enabled;            
            previewSaveOutputFormat_button.Enabled = enabled;
        }

        private double GetColorContrast(Color background, Color text)
        {
            double L1 = 0.2126 * background.R /255 + 0.7152 * background.G / 255 + 0.0722 * background.B / 255;
            double L2 = 0.2126 * text.R / 255 + 0.7152 * text.G / 255 + 0.0722 * text.B / 255;
            if (L1 > L2)
                return (L1 + 0.05) / (L2 + 0.05);
            else
                return (L2 + 0.05) / (L1 + 0.05);

        }

        #endregion

        #region PREVIEW event handlers

        int widthBeforeResize, heightBeforeResize;

        private void zoomImageBox_ImageChanged(object sender, EventArgs e)
        {
            RefreshMiniMap();
        }

        public int currentX = 0, currentY = 0, currentW, currentH;
        bool zoomed = false;
        private void zoomImageBox_Scroll(object sender, ScrollEventArgs e)
        {         
            if(zoomed)
                return;
            
            float newX = currentX, newY = currentY;
        
            var rect = zoomImageBox.GetSourceImageRegion();        

            if (rect.Width != 0 && rect.Height != 0)
            {
                bool fit = false;
                if (Math.Round(rect.X + rect.Width,0) > Math.Round(zoomImageBox.Image.Width - 17 / zoomImageBox.ZoomFactor, 0) && zoomImageBox.ZoomFactor >= 1)
                {
                    newX = (int)Math.Round(zoomImageBox.Image.Width - rect.Width - 17 / zoomImageBox.ZoomFactor, 0);
                    if (newX - rect.X < 1) newX--;
                    if (newX > 0)
                        fit = true;
                }
                if (Math.Round(rect.Y + rect.Height, 0) > Math.Round(zoomImageBox.Image.Height - 17 / zoomImageBox.ZoomFactor, 0) && zoomImageBox.ZoomFactor >= 1)
                {
                    newY = (int)Math.Round(zoomImageBox.Image.Height  - rect.Height - 17 / zoomImageBox.ZoomFactor, 0);
                    if (newY - rect.Y < 1) newY--;
                    if (newY > 0)
                        fit = true;
                }

                currentX = (int)rect.X;
                currentY = (int)rect.Y;

                if (fit)
                {
                    zoomed = true;
                    zoomImageBox.ZoomToRegion(newX, newY, rect.Width, rect.Height);
                    zoomed = false;
                }
            }

            UpdateMiniMap();

            if (!zoomImageBox.IsPanning)            
                UpdatePreview();            
        }
              
        private void zoomImageBox_PanEnd(object sender, EventArgs e)
        {           
            FitImage();
            UpdatePreview();
        }
               
        private void zoomImageBox_ZoomChanged(object sender, EventArgs e)
        {
        }

        private void zoomImageBox_Zoomed(object sender, ImageBoxZoomEventArgs e)
        {
            //var rect = zoomImageBox.GetSourceImageRegion();
            //currentX = (int)rect.X;
            //currentY = (int)rect.Y;
            //currentW = (int)rect.Width;
            //currentH = (int)rect.Height;

            UpdateMiniMap();
            UpdatePreview();
            FitImage();
            UpdateStatusBar();
            zoomLevelsToolStripComboBox.Text = string.Format("{0}%", zoomImageBox.Zoom);

            //var zoom = zoomImageBox.ZoomFactor;

            //zoomImageBox.Image = zoomBoxImage;
            //var newRect = zoomImageBox.GetScaledRectangle(currentX, currentY, currentW, currentH);

            //zoomImageBox.Image = zoomBoxImage;
            //currentX = (int)newRect.X;
            //currentY = (int)newRect.Y;
            //currentW = (int)newRect.Width;
            //currentH = (int)newRect.Height;

            //if (currentW != 0 && currentH != 0)
            //    zoomImageBox.ZoomToRegion(currentX, currentY, currentW, currentH);

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
                dialog.Filter = "All Supported Images (*.bmp;*.dib;*.rle;*.gif;*.jpg;*.jpeg;*.png;*.dds;*.tga;*.tiff;*.webp)|*.bmp;*.dib;*.rle;*.gif;*.jpg;*.jpeg;*.png;*.dds;*.tga;*.tiff;*.webp|All Files (*.*)|*.*";
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
            var model = previewModels_comboBox.SelectedValue as ModelInfo;
            if (originalPreview == null)
                return;            
            PreviewInProgress(true);          

            bool success = await ViewModel.IEU.Preview(previewFullname, originalPreview, model, true);            
            PreviewInProgress(false);
            if (!success)
            {
                ErrorLogForm errorLogForm = new ErrorLogForm(ViewModel.IEU.PreviewLog);
                errorLogForm.ShowDialog(this);                
                return;
            }
            string previewOutPath = $"{ViewModel.IEU.PreviewDirPath}\\preview.png";
            if (File.Exists(previewOutPath))
            {
                Bitmap preview = new Bitmap(previewOutPath);
                if (preview != null)
                {
                    Bitmap preview2 = new Bitmap(preview);
                    previewImageBox.Image = preview2;
                    resultPreview = preview2;
                }
                preview.Dispose();
            }               
        }

        private async void savePreview(bool saveAsPng)
        {            
            var model = previewModels_comboBox.SelectedValue as ModelInfo;
            if (zoomImageBox.Image == null)
                return;

            string imagePath = "";
            if (previewFullname == Path.GetTempPath() + clipboardImageName || ViewModel.Config.ShowPreviewSaveDialog) //image from clipboard
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.DefaultExt = "";
                saveFileDialog.InitialDirectory = ViewModel.IEU.OutputDirectoryPath;
              

                string modelName = model.Name;

                if (previewFullname == Path.GetTempPath() + clipboardImageName)
                    saveFileDialog.FileName = $"ClipboardImage_{modelName}{"." + outputFormatPreview_comboBox.Text.ToLower()}";
                else
                    saveFileDialog.FileName = $"{Path.GetFileNameWithoutExtension(previewFullname)}_{modelName}{"." + outputFormatPreview_comboBox.Text.ToLower()}";
                var diResult = saveFileDialog.ShowDialog();
                if (diResult == DialogResult.OK)
                    imagePath = saveFileDialog.FileName;
                else
                    return;              

                string fileName = Path.GetFileNameWithoutExtension(imagePath);
                string dir = Path.GetDirectoryName(imagePath);

                imagePath = $"{ dir }\\{fileName}{"." + outputFormatPreview_comboBox.Text.ToLower()}";
            }
            PreviewInProgress(true);          
            try
            {
                bool success = await ViewModel.IEU.Preview(previewFullname, zoomImageBox.Image, model, saveAsPng, true, imagePath);
                if (!success)
                {
                    ErrorLogForm errorLogForm = new ErrorLogForm(ViewModel.IEU.PreviewLog);
                    errorLogForm.ShowDialog(this);                   
                }
            }
            catch(Exception ex)
            {
                ErrorLogForm errorLogForm = new ErrorLogForm(ex.Message);
                errorLogForm.ShowDialog(this);
            }
            finally
            {
                PreviewInProgress(false);              
            }
            return;           
        }      

        private async void previewSaveOutputFormat_button_Click(object sender, EventArgs e)
        {
            savePreview(false);
        }
                
        private async void previewSaveComparison_button_Click(object sender, EventArgs e)
        {
            if (resultPreview == null)
                return;
            int footerHeight = 45;

            int comparisonMod = 1;
            int.TryParse(comparisonMod_comboBox.SelectedValue.ToString(), out comparisonMod);
            int newWidth = comparisonMod * resultPreview.Width, newHeight = comparisonMod * resultPreview.Height;

            Bitmap outputImage = new Bitmap(2 * newWidth, newHeight + footerHeight);
            var mdl = previewModels_comboBox.SelectedValue as ModelInfo;
            string modelName = mdl.Name;
            using (Graphics graphics = Graphics.FromImage(outputImage))
            {
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.DrawImage(originalPreview, new Rectangle(0,0, newWidth, newHeight),
                    new Rectangle(new Point(), originalPreview.Size), GraphicsUnit.Pixel);
                graphics.DrawImage(resultPreview, new Rectangle(newWidth, 0, newWidth, newHeight),
                    new Rectangle(new Point(), resultPreview.Size), GraphicsUnit.Pixel);
               
                Bitmap Bmp = new Bitmap(2 * newWidth, footerHeight);
                Color color = comparison_colorWheel.Color; //Color.FromArgb(226, 00, 122)
                using (Graphics gfx = Graphics.FromImage(Bmp))
                using (SolidBrush brush = new SolidBrush(color))
                {
                    gfx.FillRectangle(brush, 0, 0, 2 * newWidth, footerHeight);
                }
                graphics.DrawImage(Bmp, 0, newHeight);
                
                GraphicsPath p = new GraphicsPath();
                int fontSize = 19;
                SizeF s = new Size(999999999, 99999999);

                Font font = new Font("Times New Roman", graphics.DpiY * fontSize / 72);                  
                int cf = 0, lf = 0;
                while (s.Width >= 2 * newWidth)
                {
                    fontSize--;
                    font = new Font(FontFamily.GenericSansSerif, graphics.DpiY * fontSize / 72, FontStyle.Regular);   
                    s = graphics.MeasureString(modelName, font, new SizeF(), new StringFormat(), out cf, out lf);           
                }              
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                
                double a = graphics.DpiY * fontSize / 72;
                stringFormat.LineAlignment = StringAlignment.Center;

                double contrastW = GetColorContrast(color, Color.White);
                double contrastB = GetColorContrast(color, Color.Black);
                Brush textBrush = contrastW < 3.0 ? Brushes.Black : Brushes.White;

                graphics.DrawString(
                    $"{modelName}",
                    font,
                    textBrush,
                    new Rectangle(0, newHeight, 2 * newWidth, footerHeight - 0),
                    stringFormat );
            }
            try
            {
                Clipboard.SetDataObject(outputImage);
            }
            catch
            { }
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

        #region MainForm event handlers

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
            ViewModel.Config.LogPanelWidth = splitContainer1.SplitterDistance;
            
            ViewModel.Config.ActiveTab = tabControl1.SelectedIndex;
            ViewModel.Config.ComparisonColor = comparison_colorWheel.Color;
            ViewModel.Config.WindowState = WindowState;
            ViewModel.Config.SaveSettings();
            ViewModel.IEU.SaveSettings();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SendMessage(filterFilenameContains_textBox.Handle, 0x1501, 1, "word1;word2;word3");
            SendMessage(filterFilenameNotContains_textBox.Handle, 0x1501, 1, "word1;word2;word3");
            SendMessage(filterFolderNameContains_textBox.Handle, 0x1501, 1, "word1;word2;word3");
            SendMessage(filterFolderNameNotContains_textBox.Handle, 0x1501, 1, "word1;word2;word3");
            SendMessage(interpolationOutputModelName_textBox.Handle, 0x1501, 1, "New model name");
            
            ViewModel.Config.ReadSettings();

            if(ViewModel.Config.WindowState != FormWindowState.Minimized)
                WindowState = ViewModel.Config.WindowState;
            Location = ViewModel.Config.WindowLocation;
            Width = Convert.ToInt32(ViewModel.Config.WindowWidth);
            Height = Convert.ToInt32(ViewModel.Config.WindowHeight);           

            splitContainer1.SplitterDistance = Convert.ToInt32(ViewModel.Config.LogPanelWidth);
            tabControl1.SelectedIndex = ViewModel.Config.ActiveTab;
            comparison_colorWheel.Color = ViewModel.Config.ComparisonColor;
            comparisonMod_comboBox.SelectedIndex = ViewModel.Config.ComparisonModSelectedIndex;

            bool myPathAreOk = VerifyPaths();
            if (!myPathAreOk)
                tabControl1.SelectedIndex = 2;
        }

        private void MainForm_DoubleClick(object sender, EventArgs e)
        {
            var location = (e as MouseEventArgs).X;
            var form = sender as MainForm;
            var x1 = form.Width - 30;
            var x2 = form.Width;
            if (location > x1 && location < x2)
            {
                splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
                if (splitContainer1.Panel2.Size.Width < 51)
                    splitContainer1.SplitterDistance = 100;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                ViewModel.Config.WindowWidth = Width;
                ViewModel.Config.WindowHeight = Height;
                ViewModel.Config.WindowLocation = Location;
            }            
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
            KeyValue<bool, double> alpha = Helper.CheckAlphaValue(modelInterpolationAlphaValue_textBox.Text);
           
            if (!alpha.Key)          
            {
                MessageBox.Show("Alpha value is not valid value");
                return;
            }
            tabControl1.SelectedTab = main_tabPage;
            bool success = await ViewModel.IEU.CreateInterpolatedModel(
                (interpolationModelOne_comboBox.SelectedValue as ModelInfo).FullName,
                (interpolationModelTwo_comboBox.SelectedValue as ModelInfo).FullName,
                alpha.Value,
                interpolationOutputModelName_textBox.Text);      
        }

        #endregion

        private void comboBox_DisableMouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void advancedUseSuffix_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            advancedSuffix_textBox.ReadOnly = !advancedUseSuffix_checkBox.Checked;
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
            if (thresholdEnabledRbg_checkBox.Checked || thresholdEnabledAlpha_checkBox.Checked)
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
            Process.Start(@"https://github.com/ptrsuder/" + ViewModel.IEU.GitHubRepoName);
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

        private void textbox_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = e.Data.GetData(DataFormats.FileDrop) as string[];
            var path = filePaths[0];
            string folderName = Path.GetFileName(path);
            string folderNewPath = imgPath_textBox.Text + Path.DirectorySeparatorChar + folderName;

            if ((File.GetAttributes(path) & FileAttributes.Directory) == FileAttributes.Directory)
            {
                var t = (sender as TextBox);
                t.Text = path;
            }
        }

        #region MODEL INTERPOLATION
        string alphaPrev = "05";
        private void InterpolationSettingsChanged(object sender, EventArgs e)
        {
            string alphaNow = modelInterpolationAlphaValue_textBox.Text.Replace(",", "");
            interpolationOutputModelName_textBox.Text = interpolationOutputModelName_textBox.Text
                .Replace($"_interp_{alphaPrev}", $"_interp_{alphaNow}");
            alphaPrev = alphaNow;
        }

        private void InterpolationModelsChanged(object sender, EventArgs e)
        {
            interpolationOutputModelName_textBox.Text =
                $"{((ModelInfo)interpolationModelOne_comboBox.SelectedItem)?.Name.Replace(".pth", "")}_" +
                $"{((ModelInfo)interpolationModelTwo_comboBox.SelectedItem)?.Name.Replace(".pth", "")}_" +
                $"interp_{modelInterpolationAlphaValue_textBox.Text.Replace(",", "").Replace(".", "")}.pth";
        }

        private void ModelInterpolationAlpha_trackBar_Scroll(object sender, EventArgs e)
        {
            modelInterpolationAlphaValue_textBox.Text = (modelInterpolationAlpha_trackBar.Value * 0.01).ToString();
        }
        #endregion

        private void useDifferentModelForAlpha_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            modelForAlpha_comboBox.Enabled = useDifferentModelForAlpha_checkBox.Checked;
            if (checkedModels.Count <= 1 && useDifferentModelForAlpha_checkBox.Checked == false)
                lastUseDifferentModelAlpha = false;
        }

        private void useFilterForAlpha_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            filterForAlpha_comboBox.Enabled = useFilterForAlpha_checkBox.Checked;            
        }

        private void useProfileModel_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            profileModel_comboBox.Enabled = useProfileModel_checkBox.Checked;
            treeView1.Enabled = !useProfileModel_checkBox.Checked;

            if (!useDifferentModelForAlpha_checkBox.Enabled && useProfileModel_checkBox.Checked)
                useDifferentModelForAlpha_checkBox.Enabled = true;
            if (useDifferentModelForAlpha_checkBox.Enabled && !useProfileModel_checkBox.Checked && checkedModels.Count > 1)
                DisableUseModelForAlpha();
        }

        private void preserveFormat_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            outputFormat_comboBox.Enabled = !preserveFormat_checkBox.Checked;
        }

        private void filterExtensions_checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = sender as CheckedListBox;
            var selectedITem = checkedListBox.SelectedItem;
            ViewModel.IEU.CurrentFilter.SelectedExtensionsList = checkedListBox.CheckedItems.Cast<string>().ToList(); //hack, change to reactive bindings 
            if (checkedListBox.CheckedItems.Contains(selectedITem))
                ViewModel.IEU.CurrentFilter.SelectedExtensionsList.Remove(checkedListBox.SelectedItem.ToString());
            else
                ViewModel.IEU.CurrentFilter.SelectedExtensionsList.Add(checkedListBox.SelectedItem.ToString());
        }

        #region IMAGE INTERPOLATION

        private void imagePanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (filePaths.Length == 1)
            {
                try
                {
                    Image image = ImageOperations.LoadImageToBitmap(filePaths[0]);
                    PictureBox pictureBox = ((sender as Panel).Tag as PictureBox);
                    pictureBox.Image = image;
                    pictureBox.Tag = filePaths[0];
                    if(overlayResultName_textBox.Text != Path.GetFileName(imageA_pictureBox.Tag as string))
                        overlayResultName_textBox.Text = Path.GetFileNameWithoutExtension(filePaths[0]) + "_interpolated.png";
                    Label label = pictureBox.Name == "imageA_pictureBox" ? imageAName_label : imageBName_label;
                    label.Text = Path.GetFileName(filePaths[0]);
                }
                catch
                {
                    MessageBox.Show("Failed to open image");
                }
            }
        }

        private void OverlayImages_button_Click(object sender, EventArgs e)
        {
            string pathA = imageA_pictureBox.Tag as string, pathB = imageB_pictureBox.Tag as string;
            if (string.IsNullOrEmpty(pathA) || string.IsNullOrEmpty(pathB) || imageA_pictureBox.Image == null || imageB_pictureBox.Image == null)
            {
                MessageBox.Show("Images is missing");
                return;
            }
            KeyValue<bool, double> alpha = Helper.CheckAlphaValue(imageInterpolationAlphaValue_textBox.Text);
            if(!alpha.Key)
            {
                MessageBox.Show("Alpha value is not valid");
                return;
            }
            
            if (string.IsNullOrEmpty(overlayResultName_textBox.Text))
                overlayResultName_textBox.Text = Path.GetFileName(pathA);

            string destPath = pathA.Replace(Path.GetFileName(pathA), "");

            bool success = ViewModel.IEU.InterpolateImages(imageA_pictureBox.Image, imageB_pictureBox.Image, destPath + overlayResultName_textBox.Text, alpha.Value);
            if (!success)
                tabControl1.SelectedIndex = 0;
            else
            {
                StepFinishedForm finishedForm = new StepFinishedForm(ViewModel.IEU.OutputDirectoryPath, $"Result is saved in { destPath }");
                finishedForm.ShowDialog();
                //MessageBox.Show($"Result is saved in {ViewModel.IEU.OutputDirectoryPath}");
            }
        }

        private async void OverlayFolders_button_Click(object sender, EventArgs e)
        {
            string originalPath = originalImagesPath_textBox.Text, destinationPath = resultsDestinationPath_textBox.Text;
            string pathA = resultsAPath_textBox.Text, pathB = resultsBPath_textBox.Text;
            KeyValue<bool, double> alpha = Helper.CheckAlphaValue(imageInterpolationAlphaValue_textBox.Text);
            if (!alpha.Key)
            {
                MessageBox.Show("Alpha value is not valid");
                return;
            }
            tabControl1.SelectedIndex = 0;
            ViewModel.IEU.InterpolateFolders(originalPath, pathA, pathB, destinationPath, alpha.Value);

            StepFinishedForm finishedForm = new StepFinishedForm(destinationPath, $"Result is saved in { destinationPath }");
            finishedForm.ShowDialog();
        }

        private void ImageInterpolation_trackBar_Scroll(object sender, EventArgs e)
        {
            imageInterpolationAlphaValue_textBox.Text = (imageInterpolation_trackBar.Value * 0.01).ToString();
        }

        #endregion

        #region RULESET     

        private void SaveProfile_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.AddProfile(saveProfileName_textBox.Text);
        }

        private void LoadProfile_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.LoadProfile(profiles_listBox.SelectedValue as Profile);
        }

        private void LoadProfileMainTab_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.LoadProfile(profilesMainTab_listBox.SelectedValue as Profile);
        }

        private void configs_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (profiles_listBox.SelectedValue != null)
                saveProfileName_textBox.Text = (profiles_listBox.SelectedValue as Profile).Name;
            if ((profiles_listBox.SelectedValue as Profile).Name == "Global")
                deleteProfile_button.Enabled = false;
            else
                deleteProfile_button.Enabled = true;
        }

        private void DeleteProfile_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.DeleteProfile(profiles_listBox.SelectedValue as Profile);
        }     

        private void SaveFilter_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.AddFilter(newFilterName_textBox.Text);
        }

        private void LoadFilter_button_Click(object sender, EventArgs e)
        {
            Filter loadedFilter = filters_listBox.SelectedValue as Filter;
            ViewModel.IEU.LoadFilter(loadedFilter);

            for (int i = 0; i < filterExtensions_checkedListBox.Items.Count; i++)
                filterExtensions_checkedListBox.SetItemChecked(i, false);

            foreach (var ext in loadedFilter.SelectedExtensionsList)
            {
                int index = filterExtensions_checkedListBox.Items.IndexOf(ext);
                filterExtensions_checkedListBox.SetItemChecked(index, true);
            }
        }
        
        private void DeleteFilter_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.DeleteFilter(filters_listBox.SelectedValue as Filter);
        }

        private void filters_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filters_listBox.SelectedValue != null)
                newFilterName_textBox.Text = (filters_listBox.SelectedValue as Filter).Name;
            if ((filters_listBox.SelectedValue as Filter).Name == "Global")
                deleteFilter_button.Enabled = false;
            else
                deleteFilter_button.Enabled = true;
        }

        private void SaveRule_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.AddRule(
                newRuleName_textBox.Text,
                ruleProfiles_comboBox.SelectedValue as Profile,
                ruleFilters_comboBox.SelectedValue as Filter);
            rules_listBox.DataSource = new BindingSource(ViewModel.IEU.Ruleset.Values.ToList(), null);
        }

        private void SaveRuleFromCurrent_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.AddRule(
                newRuleName_textBox.Text,
                ViewModel.IEU.CurrentProfile,
                ViewModel.IEU.CurrentFilter);
            rules_listBox.DataSource = new BindingSource(ViewModel.IEU.Ruleset.Values.ToList(), null);
        }

        private void DeleteRule_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.DeleteRule(rules_listBox.SelectedValue as Rule);
            rules_listBox.DataSource = new BindingSource(ViewModel.IEU.Ruleset.Values.ToList(), null);
        }

        private void Rules_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rules_listBox.SelectedValue != null)
                newRuleName_textBox.Text = (rules_listBox.SelectedValue as Rule).Name;
            if ((rules_listBox.SelectedValue as Rule).Name == "Global")                            
                deleteRule_button.Enabled = false;            
            else            
                deleteRule_button.Enabled = true;
            rulePriority_numericUpDown.Value = (rules_listBox.SelectedValue as Rule).Priority;
        }

        private void NewRuleName_textBox_TextChanged(object sender, EventArgs e)
        {
            saveRule_button.Enabled =
            saveRuleFromCurrent_button.Enabled =
            newRuleName_textBox.Text != "Global";           
        }

        private void LoadRule_button_Click(object sender, EventArgs e)
        {
            if (rules_listBox.SelectedValue is Rule selectedRule)
            {
                ViewModel.IEU.LoadProfile(selectedRule.Profile);
                ViewModel.IEU.LoadFilter(selectedRule.Filter);
            }
        }

        private void useCondaEnv_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            condaEnvName_textBox.Enabled = useCondaEnv_checkBox.Checked;
        }
        
        private void MainForm_Enter(object sender, EventArgs e)
        {
            if (notificationActive)
                popup.Hide();
        }

        private void inMemoryMode_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            crop_button.Enabled = !inMemoryMode_checkBox.Checked;
            merge_button.Enabled = !inMemoryMode_checkBox.Checked;
            upscale_button.Enabled = !inMemoryMode_checkBox.Checked;
        }

        private void chainOrder_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.GetCheckedModels();
            if (checkedModels.Count == 0) return;                      
            var chainForm = new SortListForm(ViewModel.IEU);
            chainForm.StartPosition = FormStartPosition.CenterParent;
            chainForm.ShowDialog(this);
        }

        private void UseModelChain_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            overwriteMode_comboBox.Enabled = !UseModelChain_checkBox.Checked;
            outputDestinationMode_comboBox.Enabled = !UseModelChain_checkBox.Checked;
            chainOrder_button.Enabled = UseModelChain_checkBox.Checked;
        }

        private void showIEU_button_Click(object sender, EventArgs e)
        {
            PropertiesForm propertiesForm = new PropertiesForm(ViewModel.IEU);
           
            propertiesForm.ShowDialog(this);
        }
               
        private void comparison_colorWheel_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {                
                case MouseButtons.Right:
                    var coldial = new ColorPickerDialog();
                    coldial.Color = comparison_colorWheel.Color;
                    coldial.ShowDialog(this);
                    comparison_colorWheel.Color = coldial.Color;
                    break;
            }
        }

        private void autoSetTileSize_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            maxTileHeight_numericUpDown.Enabled = maxTileWidth_numericUpDown.Enabled = !autoSetTileSize_checkBox.Checked;
        }

        private void outputFormat_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void preserveFormatPreview_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            //outputFormatPreview_comboBox.Enabled = !preserveFormatPreview_checkBox.Checked;
            //preserveFormat_checkBox.Checked = preserveFormatPreview_checkBox.Checked;
        }

        private void comparisonMod_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewModel.Config.ComparisonModSelectedIndex = comparisonMod_comboBox.SelectedIndex;
        }

        private void showStepsButtons_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SetStepVisibility(!showStepsButtons_checkBox.Checked);
        }

        void SetStepVisibility(bool visible)
        {
            crop_button.Visible = upscale_button.Visible = merge_button.Visible = visible;
            showStepsButtons_checkBox.Checked = !visible;
        }

        private void showJoeyProperties_button_Click(object sender, EventArgs e)
        {
            PropertiesForm propertiesForm = new PropertiesForm(ViewModel.IEU.JoeyEsrgan, 400);
            propertiesForm.ShowDialog(this);
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://github.com/JoeyBallentine/ESRGAN");
        }

        private void toogleLogView_button_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed)
                toogleLogView_button.Text = "Hide logs"; 
            else
                toogleLogView_button.Text = "Show logs";
            
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
        }
               

        string clipboardImageName = "ieu.clipboard.image.png";
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
            {
                string tmpPath = Path.GetTempPath() + clipboardImageName;

                Image returnImage = null;
                if (Clipboard.ContainsImage())
                {
                    returnImage = Clipboard.GetImage();
                    returnImage.Save(tmpPath, ImageFormat.Png);
                    OpenImage(tmpPath);
                    tabControl1.SelectedIndex = 1;
                }
            }
        }
     
        private void RulePriority_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int newValue = (int)rulePriority_numericUpDown.Value;
            if (rules_listBox.SelectedValue is Rule selectedRule
                && selectedRule.Name != "Global"
                && newValue != selectedRule.Priority
                && newValue > 0
                && newValue < rules_listBox.Items.Count)
            {
                ViewModel.IEU.ChangeRulePriority(selectedRule, newValue);
                rules_listBox.DataSource = new BindingSource(ViewModel.IEU.Ruleset.Values.ToList(), null);
                rules_listBox.SelectedIndex = rules_listBox.Items.Count - 1 - newValue;
            }
            else
                rulePriority_numericUpDown.Value = (rules_listBox.SelectedValue as Rule).Priority;
        }
        #endregion

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
