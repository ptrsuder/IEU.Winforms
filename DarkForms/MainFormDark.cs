﻿using System;
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
using AltUI;
using AltUI.Forms;
using AltUI.Config;
using AltUI.Docking;

//TODO:
//ask to change all paths when changing ESRGAN path
//change VerifyPaths?

namespace ImageEnhancingUtility.Winforms
{
    public partial class MainFormDark : DarkForm, IViewFor<MainViewModel>
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

        public double PreviewProgressBarValue
        {
            get => 0;
            set
            {
                ReportPreviewProgressThreadSafe(value);
            }
        }

        private delegate void SafeCallDelegate2(double value);
        private void ReportProgressThreadSafe(double value)
        {
            if (mainTab.progressBar1.InvokeRequired || mainTab.progress_label.InvokeRequired)
            {
                var d = new SafeCallDelegate2(ReportProgressThreadSafe);
                Invoke(d, new object[] { value });
            }
            else
            {
                mainTab.progressBar1.Value = (int)value;
                if(
                    ViewModel.IEU.FilesDone == ViewModel.IEU.FilesTotal 
                    && ViewModel.IEU.FilesDone != 0 
                    && ViewModel.IEU.CurrentPreset.InMemoryMode)                
                    ShowNotification("\nFinished processing images");

                mainTab.progress_label.Text = $@"{ViewModel.IEU.FilesDone}/{ViewModel.IEU.FilesTotal}"; //hack, change to reactive bindings 
                mainTab.progressFiltered_label.Text = ViewModel.IEU.FilesDoneSuccesfully.ToString();
            }
        }
        
        private void ReportPreviewProgressThreadSafe(double value)
        {
            if (previewTab.preview_progressBar.InvokeRequired)
            {
                var d = new SafeCallDelegate2(ReportPreviewProgressThreadSafe);
                Invoke(d, new object[] { value });
            }
            else
            {
                previewTab.preview_progressBar.Value = (int)value;  
            }
        }

        [DllImport("user32.dll")] //textbox hint
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        #region CONSTRUCTOR

        DarkDockMainTab mainTab;
        DarkDockSettingsTab settingsTab;
        DarkDockPreviewTab previewTab;
        DarkDockModIntTab modIntTab;
        DarkDockFormatsTab formatsTab;
        DarkDockRulesTab rulesTab;
        DarkDockImageInterpolationTab imgIntTab;

        void SetEventHandlersSettings()
        {
            settingsTab.changeEsrganPath_button.Click += changePath_button_Click;
            settingsTab.changeInputImgPath_button.Click += changePath_button_Click;
            settingsTab.changeInputPath_button.Click += changePath_button_Click;
            settingsTab.changeMergedResultsPath_button.Click += changePath_button_Click;
            settingsTab.changeModelsPath_button.Click += changePath_button_Click;
            settingsTab.changeOutputPath_button.Click += changePath_button_Click;

            settingsTab.advancedUseSuffix_checkBox.CheckedChanged += advancedUseSuffix_checkBox_CheckedChanged;
            settingsTab.thresholdEnabledRbg_checkBox.CheckedChanged += thresholdEnabled_checkBox_CheckedChanged;
            settingsTab.thresholdEnabledAlpha_checkBox.CheckedChanged += thresholdEnabled_checkBox_CheckedChanged;

            settingsTab.appVersion_label.LinkClicked += linkLabel1_LinkClicked;
            settingsTab.appCoreVersion_linkLabel.LinkClicked += linkLabel2_LinkClicked;
            settingsTab.joeyEsrgan_linkLabel.LinkClicked += linkLabel1_LinkClicked_1;

            settingsTab.useDifferentModelForAlpha_checkBox.CheckedChanged += useDifferentModelForAlpha_checkBox_CheckedChanged;
            settingsTab.useFilterForAlpha_checkBox.CheckedChanged += useFilterForAlpha_checkBox_CheckedChanged;

            settingsTab.useProfileModel_checkBox.CheckedChanged += useProfileModel_checkBox_CheckedChanged;
            settingsTab.useCondaEnv_checkBox.CheckedChanged += useCondaEnv_checkBox_CheckedChanged;
            settingsTab.inMemoryMode_checkBox.CheckedChanged += inMemoryMode_checkBox_CheckedChanged;
            settingsTab.showIEU_button.Click += showIEU_button_Click;
            settingsTab.autoSetTileSize_checkBox.CheckedChanged += autoSetTileSize_checkBox_CheckedChanged;
            settingsTab.showJoeyProperties_button.Click += showJoeyProperties_button_Click;
            settingsTab.preserveFormat_checkBox.CheckedChanged += preserveFormat_checkBox_CheckedChanged;

            formatsTab.webpLossless_checkBox.CheckedChanged += webpLossless_checkBox_CheckedChanged;

            settingsTab.savePreset_button.Click += SavePreset_button_Click;
            settingsTab.loadPreset_button.Click += LoadPreset_button_Click;
            settingsTab.presets_listBox.SelectedIndexChanged += presetsListBox_SelectedIndexChanged;
            settingsTab.deletePreset_button.Click += DeletePreset_button_Click;
        }
        void SetEventHandlersMain()
        {
            mainTab.outputDestinationMode_comboBox.MouseWheel += comboBox_DisableMouseWheel;
            mainTab.overwriteMode_comboBox.MouseWheel += comboBox_DisableMouseWheel;
            mainTab.richTextBox1.TextChanged += richTextBox1_TextChanged;
            mainTab.AllowDrop = true;
            mainTab.DragEnter += general_DragEnter;
            mainTab.DragDrop += mainTab_DragDrop;
            mainTab.chainOrder_button.Click += chainOrder_button_Click;
            mainTab.UseModelChain_checkBox.CheckedChanged += UseModelChain_checkBox_CheckedChanged;
            mainTab.showStepsButtons_checkBox.CheckedChanged += showStepsButtons_checkBox_CheckedChanged;
            mainTab.toogleLogView_button.Click += toogleLogView_button_Click;
        }
        void SetEventHandlersPreview()
        {
            previewTab.zoomImageBox.ImageChanged += zoomImageBox_ImageChanged;
            previewTab.zoomImageBox.Scroll += zoomImageBox_Scroll;
            previewTab.zoomImageBox.PanEnd += zoomImageBox_PanEnd;
            previewTab.zoomImageBox.ZoomChanged += zoomImageBox_ZoomChanged;
            previewTab.zoomImageBox.Zoomed += zoomImageBox_Zoomed;
            previewTab.miniMapImageBox.Paint += miniMapImageBox_Paint;
            previewTab.openFromFileToolStripButton.Click += openFromFileToolStripMenuItem_Click;
            previewTab.previewImageBox.MouseUp += previewImageBox_MouseUp;
            previewTab.previewImageBox.MouseDown += previewImageBox_MouseDown;
            darkDockPanel1.ActiveContentChanged += DarkDockPanel1_ActiveContentChanged;
            previewTab.previewUpdate_button.Click += previewUpdate_button_Click;
            previewTab.previewSaveOutputFormat_button.Click += previewSaveOutputFormat_button_Click;
            previewTab.button_previewSaveComparison.Click += previewSaveComparison_button_Click;

            previewTab.zoomLevelsToolStripComboBox.SelectedIndexChanged += zoomLevelsToolStripComboBox_SelectedIndexChanged;
            previewTab.zoomInToolStripButton.Click += zoomInToolStripButton_Click;
            previewTab.zoomOutToolStripButton.Click += zoomOutToolStripButton_Click;
            previewTab.actualSizeToolStripButton.Click += actualSizeToolStripButton_Click;
            previewTab.comparison_colorWheel.MouseClick += comparison_colorWheel_MouseClick;
            previewTab.previewSaveOutputFormat_button.Click += preserveFormatPreview_checkBox_CheckedChanged;
            previewTab.comparisonMod_comboBox.SelectedIndexChanged += comparisonMod_comboBox_SelectedIndexChanged;

            previewTab.zoomImageBox.AllowDrop = true;
            previewTab.zoomImageBox.DragEnter += general_DragEnter;
            previewTab.zoomImageBox.DragDrop += zoomImageBox_DragDrop;


        }
        void SetEventHandlersRules()
        {
            mainTab.loadProfileMainTab_button.Click += LoadProfileMainTab_button_Click;
            settingsTab.saveProfile_button.Click += SaveProfile_button_Click;
            settingsTab.loadProfile_button.Click += LoadProfile_button_Click;
            settingsTab.profiles_listBox.SelectedIndexChanged += configs_listBox_SelectedIndexChanged;
            settingsTab.deleteProfile_button.Click += DeleteProfile_button_Click;

            rulesTab.filterSizeOr_checkBox.CheckedChanged += filterSizeOr_checkBox_CheckedChanged;
            rulesTab.filterFilenameContains_checkBox.CheckedChanged += filterFilenameContains_checkBox_CheckedChanged;
            rulesTab.filterFilenameNotContains_checkBox.CheckedChanged += filterFilenameNotContains_checkBox_CheckedChanged;
            rulesTab.filtersSizeOn_checkBox.CheckedChanged += filtersSizeOn_checkBox_CheckedChanged;
            rulesTab.filterExtensions_checkedListBox.ItemCheck += filterExtensions_checkedListBox_ItemCheck;

            rulesTab.saveFilter_button.Click += SaveFilter_button_Click;
            rulesTab.loadFilter_button.Click += LoadFilter_button_Click;
            rulesTab.deleteFilter_button.Click += DeleteFilter_button_Click;
            rulesTab.filters_listBox.SelectedIndexChanged += filters_listBox_SelectedIndexChanged;
            rulesTab.saveRule_button.Click += SaveRule_button_Click;
            rulesTab.saveRuleFromCurrent_button.Click += SaveRuleFromCurrent_button_Click;
            rulesTab.deleteRule_button.Click += DeleteRule_button_Click;
            rulesTab.rules_listBox.SelectedIndexChanged += Rules_listBox_SelectedIndexChanged;
            rulesTab.newRuleName_textBox.TextChanged += NewRuleName_textBox_TextChanged;
            rulesTab.loadRule_button.Click += LoadRule_button_Click;
            rulesTab.rulePriority_numericUpDown.ValueChanged += RulePriority_numericUpDown_ValueChanged;
        }
        void SetEventHandlersModInt()
        { 
            modIntTab.interpolationStart_button.Click += interpolationStart_button_Click;
            modIntTab.interpolationModelOne_comboBox.SelectedIndexChanged += InterpolationModelsChanged;
            modIntTab.interpolationModelTwo_comboBox.SelectedIndexChanged += InterpolationModelsChanged;
            modIntTab.modelInterpolationAlpha_trackBar.Scroll += ModelInterpolationAlpha_trackBar_Scroll;
            modIntTab.modelInterpolationAlphaValue_textBox.TextChanged += InterpolationSettingsChanged;
        }

        public bool LightTheme = false;

        public MainFormDark()
        {         
            InitializeComponent();

            mainTab = new DarkDockMainTab("MAIN", Icons.Icon.document_16xLG);
            settingsTab = new DarkDockSettingsTab("SETTINGS", Icons.Icon.document_16xLG);
            previewTab = new DarkDockPreviewTab("PREVIEW", Icons.Icon.document_16xLG);            
            formatsTab = new DarkDockFormatsTab("FORMAT SETTINGS", Icons.Icon.document_16xLG);
            rulesTab = new DarkDockRulesTab("RULES", Icons.Icon.document_16xLG);
            modIntTab = new DarkDockModIntTab("MODELS INTERPOLATION", Icons.Icon.document_16xLG);
            imgIntTab = new DarkDockImageInterpolationTab("IMAGE INTERPOLATION", Icons.Icon.document_16xLG);
            var ffff = new DarkDockTest("test", Icons.Icon.document_16xLG);

            SetEventHandlersMain();
            SetEventHandlersSettings();
            SetEventHandlersPreview();
            SetEventHandlersRules();
            SetEventHandlersModInt();

            TextBox esrganPath_textBox = settingsTab.esrganPath_textBox,
            imgPath_textBox = settingsTab.esrganPath_textBox,
            modelsPath_textBox = settingsTab.modelsPath_textBox,
            resultsMergedPath_textBox = settingsTab.resultsMergedPath_textBox,
            inputPath_textBox = settingsTab.modelsPath_textBox,
            outputPath_textBox = settingsTab.outputPath_textBox;

            ImageBox zoomImageBox = previewTab.zoomImageBox, miniMapImageBox = previewTab.miniMapImageBox, previewImageBox = previewTab.previewImageBox;

            CreateMyTreeView();

            treeView_contextMenuStrip.Items[0].Click += OpenModelFolder;
            treeView_contextMenuStrip.Items[1].Click += (o, e) => ViewModel.IEU.CreateModelTree(); 

            FormClosing += MainForm_FormClosing;

            mainTab.profilesMainTab_listBox.DisplayMember =
            settingsTab.profiles_listBox.DisplayMember =
            rulesTab.ruleProfiles_comboBox.DisplayMember =
            rulesTab.filters_listBox.DisplayMember =
            rulesTab.ruleFilters_comboBox.DisplayMember =
            settingsTab.presets_listBox.DisplayMember = "Name";

            ViewModel = new MainViewModel();
          
            BindMainTab();
            BindConfig();
            BindRuleSystem();

            LightTheme = !ViewModel.Config.DarkTheme;
            ThemeProvider.Theme = new DarkThemeIEU();

            if (LightTheme)
            {
                ThemeProvider.LightMode = true;
                ThemeProvider.Theme = new LightTheme();
            }

            settingsTab.modelForAlpha_comboBox.DataSource = new BindingSource(ViewModel.IEU.ModelsItems.Items, null); //initial value
            settingsTab.profileModel_comboBox.DataSource = new BindingSource(ViewModel.IEU.ModelsItems.Items, null); //initial value

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

            settingsTab.appVersion_label.Text = "IEU.Winforms v" + this.AppVersion;
            settingsTab.appCoreVersion_linkLabel.Text = "IEU.Core v" + ViewModel.IEU.AppVersion;

            modIntTab.interpolationModelOne_comboBox.DisplayMember =
            modIntTab.interpolationModelTwo_comboBox.DisplayMember =
            settingsTab.modelForAlpha_comboBox.DisplayMember =
            settingsTab.profileModel_comboBox.DisplayMember =
            previewTab.previewModels_comboBox.DisplayMember = "ComboBoxName";

            if (ViewModel.IEU.ModelsItems.Count > 0)
            {         
                this.Bind(ViewModel,
                   vm => vm.IEU.CurrentProfile.ModelForAlpha,
                   v => v.settingsTab.modelForAlpha_comboBox.SelectedIndex,
                   x => x == null ? 0 : ViewModel.IEU.ModelsItems.Items.ToList().FindIndex(y => y.FullName == x.FullName),
                   x => GetModel(x));

                this.Bind(ViewModel,
                   vm => vm.IEU.CurrentProfile.Model,
                   v => v.settingsTab.profileModel_comboBox.SelectedIndex,
                   x => GetIndex(x),
                   x => GetModel(x));
            }

            lastUseDifferentModelAlpha = settingsTab.useDifferentModelForAlpha_checkBox.Checked;

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

            imgIntTab.imageA_panel.Tag = imgIntTab.imageA_pictureBox;
            imgIntTab.imageB_panel.Tag = imgIntTab.imageB_pictureBox;
            imgIntTab.imageA_pictureBox.SizeMode = imgIntTab.imageB_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imgIntTab.imageAName_label.Text = imgIntTab.imageBName_label.Text = "";

            imgIntTab.originalImagesPath_textBox.Text = imgPath_textBox.Text;
            imgIntTab.resultsDestinationPath_textBox.Text = resultsMergedPath_textBox.Text;

            treeView1.Enabled = !settingsTab.useProfileModel_checkBox.Checked;

            settingsTab.inMemoryMode_checkBox.Checked = !settingsTab.inMemoryMode_checkBox.Checked; //HACK
            settingsTab.inMemoryMode_checkBox.Checked = !settingsTab.inMemoryMode_checkBox.Checked; //LAZY

            previewTab.comparisonMod_comboBox.DataSource = new BindingSource(IEU.ResizeImageScaleFactors, null);
            previewTab.comparisonMod_comboBox.SelectedIndex = 2;

            SetStepVisibility(false);   
        }

        #endregion              

        #region BINDINGS

        void BindMainTab()
        {
            this.OneWayBind(ViewModel, vm => vm.IEU.CurrentPreset.OutputDestinationModes, v => v.mainTab.outputDestinationMode_comboBox.DataSource, x => new BindingSource(x, null));
            mainTab.outputDestinationMode_comboBox.DisplayMember = "Key";
            mainTab.outputDestinationMode_comboBox.ValueMember = "Value";
            this.Bind(ViewModel, vm => vm.IEU.CurrentPreset.OutputDestinationMode, v => v.mainTab.outputDestinationMode_comboBox.SelectedValue, x => x, x => (int)x);

            this.OneWayBind(ViewModel, vm => vm.IEU.CurrentPreset.OverwriteModes, v => v.mainTab.overwriteMode_comboBox.DataSource, x => new BindingSource(x, null));
            mainTab.overwriteMode_comboBox.DisplayMember = "Key";
            mainTab.overwriteMode_comboBox.ValueMember = "Value";
            this.Bind(ViewModel, vm => vm.IEU.CurrentPreset.OverwriteMode, v => v.mainTab.overwriteMode_comboBox.SelectedValue);

            this.OneWayBind(ViewModel, vm => vm.IEU.ProgressBarValue, v => v.ProgressBarValue);
            this.OneWayBind(ViewModel, vm => vm.IEU.previewIEU.ProgressBarValue, v => v.PreviewProgressBarValue);

            this.Bind(ViewModel, vm => vm.IEU.CurrentPreset.UseModelChain, v => v.mainTab.UseModelChain_checkBox.Checked);
        }

        void BindConfig()
        {
            this.Bind(ViewModel, vm => vm.Config.WindowOnTop, v => v.settingsTab.topMost_checkBox.Checked);
            this.OneWayBind(ViewModel, vm => vm.Config.WindowOnTop, v => v.TopMost);
            this.Bind(ViewModel, vm => vm.Config.ShowPopups, v => v.settingsTab.showPopups_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.Config.CheckForUpdates, v => v.settingsTab.checkForUpdates_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.Config.ShowPreviewSaveDialog, v => v.previewTab.previewShowSaveDialog_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.Config.DarkTheme, v => v.settingsTab.darkTheme_сheckBox.Checked);
        }

        void BindSettingsTab()
        {
            this.Bind(ViewModel, vm => vm.IEU.ResultsPath, v => v.settingsTab.outputPath_textBox.Text);
            this.Bind(ViewModel, vm => vm.IEU.ModelsPath, v => v.settingsTab.modelsPath_textBox.Text);
            this.Bind(ViewModel, vm => vm.IEU.LrPath, v => v.settingsTab.inputPath_textBox.Text);
            this.Bind(ViewModel, vm => vm.IEU.InputDirectoryPath, v => v.settingsTab.imgPath_textBox.Text);
            this.Bind(ViewModel, vm => vm.IEU.OutputDirectoryPath, v => v.settingsTab.resultsMergedPath_textBox.Text);
            this.Bind(ViewModel, vm => vm.IEU.EsrganPath, v => v.settingsTab.esrganPath_textBox.Text);

            this.Bind(ViewModel, vm => vm.IEU.CurrentPreset.MaxTileResolution, v => v.settingsTab.maxTileResolution_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.IEU.CurrentPreset.MaxTileResolutionWidth, v => v.settingsTab.maxTileWidth_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.IEU.CurrentPreset.MaxTileResolutionHeight, v => v.settingsTab.maxTileHeight_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.IEU.PreciseTileResolution, v => v.settingsTab.preciseTile_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.IgnoreAlpha, v => v.settingsTab.ignoreAlpha_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.IgnoreSingleColorAlphas, v => v.settingsTab.ignoreSingleColorAlpha_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.BalanceAlphas, v => v.settingsTab.balanceAlphas_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.BalanceRgb, v => v.settingsTab.balanceRgb_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.DeleteResults, v => v.settingsTab.deleteResults_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentPreset.CreateMemoryImage, v => v.settingsTab.createMemoryImage_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.UseOriginalImageFormat, v => v.settingsTab.preserveFormat_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.SplitRGB, v => v.settingsTab.splitRGB_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentPreset.UseCPU, v => v.settingsTab.useCPU_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentPreset.UseBasicSR, v => v.settingsTab.useBasicSR_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.UseDifferentModelForAlpha, v => v.settingsTab.useDifferentModelForAlpha_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.UseFilterForAlpha, v => v.settingsTab.useFilterForAlpha_checkBox.Checked);

            var filterForAlpha_comboBox = settingsTab.filterForAlpha_comboBox;
            filterForAlpha_comboBox.DataSource = new BindingSource(Dictionaries.MagickFilterTypes, null);
            filterForAlpha_comboBox.DisplayMember = "Value";
            filterForAlpha_comboBox.ValueMember = "Key";
            filterForAlpha_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.AlphaFilterType, v => v.settingsTab.filterForAlpha_comboBox.SelectedValue, x => x, x => (int)x);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.UseModel, v => v.settingsTab.useProfileModel_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.SeamlessTexture, v => v.settingsTab.seamlessTextures_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentPreset.OverlapSize, v => v.settingsTab.overlapSize_numericUpDown.Value, x => x, x => (int)x);

            this.Bind(ViewModel, vm => vm.IEU.UseCondaEnv, v => v.settingsTab.useCondaEnv_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CondaEnv, v => v.settingsTab.condaEnvName_textBox.Text);
            
            this.Bind(ViewModel, vm => vm.IEU.EnableBlend, v => v.settingsTab.useMblend_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentPreset.InMemoryMode, v => v.settingsTab.inMemoryMode_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentPreset.UseImageMagickMerge, v => v.settingsTab.useImMerge_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.UseOldVipsMerge, v => v.settingsTab.useOldVipsMerge_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentPreset.DebugMode, v => v.settingsTab.showDebugInfo_checkBox.Checked);            

            this.Bind(ViewModel, vm => vm.IEU.VramMonitorEnable, v => v.settingsTab.monitorVram_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.VramMonitorFrequency, v => v.settingsTab.monitorFrequency_numericUpDown.Value, x => x, y => decimal.ToInt32(y));

            this.Bind(ViewModel, vm => vm.IEU.CurrentPreset.AutoSetTileSizeEnable, v => v.settingsTab.autoSetTileSize_checkBox.Checked);

            this.OneWayBind(ViewModel, vm => vm.IEU.NoNvidia, v => v.settingsTab.autoSetTileSize_checkBox.Enabled, x => !x);
            this.OneWayBind(ViewModel, vm => vm.IEU.NoNvidia, v => v.settingsTab.monitorVram_checkBox.Enabled, x => !x);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.PaddingSize, v => v.settingsTab.tilesPadding_numericUpDown.Value, x => x, y => decimal.ToInt32(y));

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.UseJoey, v => v.settingsTab.useJoey_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.RgbaModel, v => v.settingsTab.supportRgba_checkBox.Checked);               
        }
        
        void BindOutputFormats()
        {
            var ddsTextureType_comboBox = formatsTab.ddsTextureType_comboBox;
            var ddsFileFormat_comboBox = formatsTab.ddsFileFormat_comboBox;
            var ddsCompresion_comboBox = formatsTab.ddsCompresion_comboBox;

            ddsTextureType_comboBox.DataSource = new BindingSource(Dictionaries.ddsTextureType, null);
            ddsTextureType_comboBox.DisplayMember = "Key";
            ddsTextureType_comboBox.ValueMember = "Value";
            ddsTextureType_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.DdsTextureTypeSelectedIndex, v => v.formatsTab.ddsTextureType_comboBox.SelectedIndex);

            ddsFileFormat_comboBox.DisplayMember = "Name";
            ddsFileFormat_comboBox.ValueMember = "DdsFileFormat";

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.DdsFileFormatsCurrent, v => v.formatsTab.ddsFileFormat_comboBox.DataSource);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.DdsFileFormatSelectedIndex, v => v.formatsTab.ddsFileFormat_comboBox.SelectedIndex);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.DdsGenerateMipmaps, v => v.formatsTab.ddsGenerateMipmaps_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.DdsIsCubemap, v => v.formatsTab.ddsIsCubemap_checkBox.Checked);

            ddsCompresion_comboBox.DataSource = new List<string>() { "Fast", "Normal", "Slow (best)" };
            ddsCompresion_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.DdsBC7CompressionSelected, v => v.formatsTab.ddsCompresion_comboBox.SelectedIndex);

            settingsTab.outputFormat_comboBox.DataSource = new BindingSource(ViewModel.IEU.CurrentProfile.FormatInfos, null);
            settingsTab.outputFormat_comboBox.DisplayMember = "DisplayName";
            settingsTab.outputFormat_comboBox.ValueMember = "Extension";
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.SelectedOutputFormatIndex, v => v.settingsTab.outputFormat_comboBox.SelectedIndex);

            var outputFormatPreview_comboBox = previewTab.outputFormatPreview_comboBox;
            outputFormatPreview_comboBox.DataSource = new BindingSource(ViewModel.IEU.CurrentProfile.FormatInfos, null);
            outputFormatPreview_comboBox.DisplayMember = "DisplayName";
            outputFormatPreview_comboBox.ValueMember = "Extension";
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.SelectedOutputFormatIndex, v => v.previewTab.outputFormatPreview_comboBox.SelectedIndex);

            var tiffSettings_comboBox = formatsTab.tiffSettings_comboBox;

            tiffSettings_comboBox.DataSource = new BindingSource(Dictionaries.TiffCompressionModes, null);
            tiffSettings_comboBox.DisplayMember = "Key";
            tiffSettings_comboBox.ValueMember = "Value";
            tiffSettings_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.tiffFormat.CompressionMethod, v => v.formatsTab.tiffSettings_comboBox.SelectedValue, x => x, x => (string)x);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.tiffFormat.QualityFactor, v => v.formatsTab.tiffJpegQuality_numericUpDown.Value, x => x, y => decimal.ToInt32(y));

            var webpPreset_comboBox = formatsTab.webpPreset_comboBox;

            webpPreset_comboBox.DataSource = new BindingSource(Dictionaries.WebpPresets, null);
            webpPreset_comboBox.DisplayMember = "Key";
            webpPreset_comboBox.ValueMember = "Value";
            webpPreset_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.webpFormat.CompressionMethod, v => v.formatsTab.webpPreset_comboBox.SelectedValue, x => x, x => (string)x);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.webpFormat.QualityFactor, v => v.formatsTab.webpQuality_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.pngFormat.CompressionFactor, v => v.formatsTab.pngCompression_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
        }

        void BindRuleSystem()
        {            
            this.Bind(ViewModel, vm => vm.IEU.DisableRuleSystem, v => v.rulesTab.disableRuleSystem_checkBox.Checked);
            ViewModel.WhenAnyValue(vm => vm.IEU.DisableRuleSystem).Subscribe(x => HideRules(x));

            ViewModel.IEU.Logger.Log.Connect()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out ReadOnlyObservableCollection<LogMessage> bindingData)
                .OnItemAdded(x => WriteToLogsThreadSafe(x))
                .Subscribe();

            ViewModel.IEU.Profiles.Connect()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out ReadOnlyObservableCollection<Profile>  bindingDataProfiles)
                .Subscribe(x => UpdateDataSource(settingsTab.profiles_listBox, rulesTab.ruleProfiles_comboBox, bindingDataProfiles));

            ViewModel.IEU.Filters.Connect()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out ReadOnlyObservableCollection < Filter > bindingDataFilters)
                .Subscribe(x => UpdateDataSource(rulesTab.filters_listBox, rulesTab.ruleFilters_comboBox, bindingDataFilters));

            ViewModel.IEU.Presets.Connect()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out ReadOnlyObservableCollection<Preset> bindingDataPresets)
                .Subscribe(x => { settingsTab.presets_listBox.DataSource = new BindingSource(bindingDataPresets, null); });

            ViewModel.IEU.ModelsItems.Connect()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out ReadOnlyObservableCollection<ModelInfo> bindingDataModels)
                .Subscribe(_ => UpdateModels(bindingDataModels));

            rulesTab.rules_listBox.DisplayMember = "Name";
            rulesTab.rules_listBox.DataSource = new BindingSource(ViewModel.IEU.Ruleset.Values.ToList(), null);
        }

        void BindCommands()
        {    
            this.BindCommand(ViewModel, vm => vm.IEU.SplitCommand, v => v.mainTab.crop_button);
            this.BindCommand(ViewModel, vm => vm.IEU.UpscaleCommand, v => v.mainTab.upscale_button);
            this.BindCommand(ViewModel, vm => vm.IEU.MergeCommand, v => v.mainTab.merge_button);
            this.BindCommand(ViewModel, vm => vm.IEU.SplitUpscaleMergeCommand, v => v.mainTab.runAll_button);
           
            ViewModel.IEU.SplitCommand.ThrownExceptions.Subscribe(error => WriteErrors(error));
            ViewModel.IEU.UpscaleCommand.ThrownExceptions.Subscribe(error => WriteErrors(error));
            ViewModel.IEU.MergeCommand.ThrownExceptions.Subscribe(error => WriteErrors(error));      
            ViewModel.IEU.SplitUpscaleMergeCommand.ThrownExceptions.Subscribe(error => WriteErrors(error));

            ViewModel.IEU.SplitUpscaleMergeCommand.Subscribe(
                showNotif => ShowNotification("\nFinished processing images", !showNotif));
        }        
              
        void BindAdvanced()
        {
            this.Bind(ViewModel, vm => vm.IEU.CurrentPreset.UseResultSuffix, v => v.settingsTab.advancedUseSuffix_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentPreset.ResultSuffix, v => v.settingsTab.advancedSuffix_textBox.Text);

            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FilenameCaseSensitive, v => v.rulesTab.filterFilenameCaseSensitive_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FilenameContainsEnabled, v => v.rulesTab.filterFilenameContains_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FilenameContainsPattern, v => v.rulesTab.filterFilenameContains_textBox.Text);

            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FilenameNotContainsEnabled, v => v.rulesTab.filterFilenameNotContains_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FilenameNotContainsPattern, v => v.rulesTab.filterFilenameNotContains_textBox.Text);

            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FolderNameCaseSensitive, v => v.rulesTab.filterFolderNameCaseSensitive_checkBox.Checked);

            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FolderNameContainsEnabled, v => v.rulesTab.filterFolderNameContains_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FolderNameContainsPattern, v => v.rulesTab.filterFolderNameContains_textBox.Text);

            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FolderNameNotContainsEnabled, v => v.rulesTab.filterFolderNameNotContains_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.FolderNameNotContainsPattern, v => v.rulesTab.filterFolderNameNotContains_textBox.Text);

            rulesTab.filterAlpha_comboBox.DataSource = Filter.FiltersAlpha;
            rulesTab.filterAlpha_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.Alpha, v => v.rulesTab.filterAlpha_comboBox.SelectedIndex);

            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.ImageResolutionEnabled, v => v.rulesTab.filtersSizeOn_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.ImageResolutionOr, v => v.rulesTab.filterSizeOr_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.ImageResolutionMaxWidth, v => v.rulesTab.filterSizeWidth_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.IEU.CurrentFilter.ImageResolutionMaxHeight, v => v.rulesTab.filterSizeHeight_numericUpDown.Value, x => x, y => decimal.ToInt32(y));

            foreach (var item in Filter.ExtensionsList)
                rulesTab.filterExtensions_checkedListBox.Items.Add(item);

            settingsTab.noiseReductionType_comboBox.DataSource = IEU.NoiseReductionTypes;
            settingsTab.noiseReductionType_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.NoiseReductionType, v => v.settingsTab.noiseReductionType_comboBox.SelectedIndex);

            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.ThresholdEnabled, v => v.settingsTab.thresholdEnabledRbg_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.ThresholdAlphaEnabled, v => v.settingsTab.thresholdEnabledAlpha_checkBox.Checked);
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.ThresholdBlackValue, v => v.settingsTab.thresholdBlack_numericUpDown.Value, x => x, y => decimal.ToInt32(y));
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.ThresholdWhiteValue, v => v.settingsTab.thresholdWhite_numericUpDown.Value, x => x, y => decimal.ToInt32(y));

            #region #RESIZE
            settingsTab.resizeImageBeforeScaleFactor_comboBox.DataSource = new BindingSource(IEU.ResizeImageScaleFactors, null);
            settingsTab.resizeImageBeforeScaleFactor_comboBox.SelectedIndex = 3;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.ResizeImageBeforeScaleFactor, v => v.settingsTab.resizeImageBeforeScaleFactor_comboBox.Text, x => x.ToString(), x => Double.Parse(x.ToString()));

            var resizeImageBeforeFilterType_comboBox = settingsTab.resizeImageBeforeFilterType_comboBox;
            resizeImageBeforeFilterType_comboBox.DataSource = new BindingSource(Dictionaries.VipsKernel, null);
            resizeImageBeforeFilterType_comboBox.DisplayMember = "Value";
            resizeImageBeforeFilterType_comboBox.ValueMember = "Key";
            resizeImageBeforeFilterType_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.ResizeImageBeforeFilterType, v => v.settingsTab.resizeImageBeforeFilterType_comboBox.SelectedValue, x => x, x => (int)x);

            var resizeImageAfterScaleFactor_comboBox = settingsTab.resizeImageAfterScaleFactor_comboBox;
            resizeImageAfterScaleFactor_comboBox.DataSource = new BindingSource(IEU.ResizeImageScaleFactors, null);
            resizeImageAfterScaleFactor_comboBox.SelectedIndex = 3;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.ResizeImageAfterScaleFactor, v => v.settingsTab.resizeImageAfterScaleFactor_comboBox.Text, x => x.ToString(), x => Double.Parse(x.ToString()));

            var resizeImageAfterFilterType_comboBox = settingsTab.resizeImageAfterFilterType_comboBox;
            resizeImageAfterFilterType_comboBox.DataSource = new BindingSource(Dictionaries.VipsKernel, null);
            resizeImageAfterFilterType_comboBox.DisplayMember = "Value";
            resizeImageAfterFilterType_comboBox.ValueMember = "Key";
            resizeImageAfterFilterType_comboBox.SelectedIndex = 0;
            this.Bind(ViewModel, vm => vm.IEU.CurrentProfile.ResizeImageAfterFilterType, v => v.settingsTab.resizeImageAfterFilterType_comboBox.SelectedValue, x => x, x => (int)x);
            #endregion         
        }

        #endregion

        #region MODELS/TREEVIEW

        private void CreateMyTreeView()
        {
            treeView1 = new MyTreeView
            {
                BackColor = Color.FromArgb(70, 70, 70),
                ForeColor = Color.FromArgb(180, 180, 180),
                LineColor = Color.FromArgb(180, 180, 180),               
                BorderStyle = BorderStyle.FixedSingle,
                ContextMenuStrip = treeView_contextMenuStrip,
                Dock = DockStyle.Fill,
                Font = new Font("Lucida Console", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0),
                HideSelection = false,
                ItemHeight = 20,
                Location = new Point(0, 0),
                Name = "treeView1",
                Size = new Size(400, 571),
                TabIndex = 9
            };
            if (LightTheme)
            {               
                treeView1.BackColor = MyTreeView.DefaultBackColor;
                treeView1.ForeColor = MyTreeView.DefaultForeColor;
            }
            treeView1.AfterCheck += new TreeViewEventHandler(treeView1_AfterCheck);
            mainTab.splitContainer1.Panel1.Controls.Add(treeView1);
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

            mainTab.profilesMainTab_listBox.DataSource = new BindingSource(bindingData, null);

            comboBox.DataSource = new BindingSource(bindingData, null);
        }

        void UpdateDataSource(ListBox listBox, ComboBox comboBox, ReadOnlyObservableCollection<Filter> bindingData)
        {
            listBox.DataSource = new BindingSource(bindingData, null);
            comboBox.DataSource = new BindingSource(bindingData, null);            
        }

        void UpdateModels(ReadOnlyObservableCollection<ModelInfo> bindingDataModels)
        {
            var modelForAlpha_comboBox = settingsTab.modelForAlpha_comboBox;
                
            if (bindingDataModels.Count == 0) return;
            string selectedModelFullname = ViewModel.IEU.CurrentProfile.ModelForAlpha?.FullName;            
            modelForAlpha_comboBox.DataSource = new BindingSource(bindingDataModels, null);
            int lastSelectedIndex = bindingDataModels.ToList().FindIndex(y => y.FullName == selectedModelFullname);
            if (lastSelectedIndex >= bindingDataModels.Count || lastSelectedIndex < 0)
                lastSelectedIndex = 0;
            modelForAlpha_comboBox.SelectedIndex = lastSelectedIndex;

            selectedModelFullname = ViewModel.IEU.CurrentProfile.Model?.FullName;
            settingsTab.profileModel_comboBox.DataSource = new BindingSource(bindingDataModels, null);
            lastSelectedIndex = bindingDataModels.ToList().FindIndex(y => y.FullName == selectedModelFullname);
            if (lastSelectedIndex >= bindingDataModels.Count || lastSelectedIndex < 0)
                lastSelectedIndex = 0;
            settingsTab.profileModel_comboBox.SelectedIndex = lastSelectedIndex;

            selectedModelFullname = (modIntTab.interpolationModelOne_comboBox.SelectedItem as ModelInfo)?.FullName;
            modIntTab.interpolationModelOne_comboBox.DataSource = new BindingSource(bindingDataModels, null);
            lastSelectedIndex = bindingDataModels.ToList().FindIndex(y => y.FullName == selectedModelFullname);
            if (lastSelectedIndex >= bindingDataModels.Count || lastSelectedIndex < 0)
                lastSelectedIndex = 0;
            modIntTab.interpolationModelOne_comboBox.SelectedIndex = lastSelectedIndex;            

            selectedModelFullname = (modIntTab.interpolationModelTwo_comboBox.SelectedItem as ModelInfo)?.FullName;
            modIntTab.interpolationModelTwo_comboBox.DataSource = new BindingSource(bindingDataModels, null);
            lastSelectedIndex = bindingDataModels.ToList().FindIndex(y => y.FullName == selectedModelFullname);
            if (lastSelectedIndex >= bindingDataModels.Count || lastSelectedIndex < 0)
                lastSelectedIndex = 0;
            modIntTab.interpolationModelTwo_comboBox.SelectedIndex = lastSelectedIndex;

            var previewModels_comboBox = previewTab.previewModels_comboBox;
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

            if (settingsTab.modelsPath_textBox.Text == "")
                return;
            DirectoryInfo di = new DirectoryInfo(settingsTab.modelsPath_textBox.Text);
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
            if (mainTab.richTextBox1.InvokeRequired)
            {
                var d = new SafeCallDelegateWithColor(WriteToLogsThreadSafe);
                Invoke(d, new object[] { message });
            }
            else
            {
                mainTab.richTextBox1.AppendText(message.Text, message.Color);
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
                    using (UpdateNotifyDialog updateNotifyDialog = new UpdateNotifyDialog(checkerWinforms, updateMessage))
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

            mainTab.Enabled = allgood;
            modIntTab.Enabled = allgood;

            return allgood;
        }
        void SetPathButtons()
        {
            mainTab.progress_label.Text = "0/0";
            settingsTab.changeEsrganPath_button.Tag = settingsTab.esrganPath_textBox;
            settingsTab.changeInputImgPath_button.Tag = settingsTab.imgPath_textBox;
            settingsTab.changeMergedResultsPath_button.Tag = settingsTab.resultsMergedPath_textBox;
            settingsTab.changeInputPath_button.Tag = settingsTab.inputPath_textBox;
            settingsTab.changeOutputPath_button.Tag = settingsTab.outputPath_textBox;
            settingsTab.changeModelsPath_button.Tag = settingsTab.modelsPath_textBox;

            imgIntTab.changeOriginalImagesPath_button.Tag = imgIntTab.originalImagesPath_textBox;
            imgIntTab.changeResultsAPath_button.Tag = imgIntTab.resultsAPath_textBox;
            imgIntTab.changeResultsBPath_button.Tag = imgIntTab.resultsBPath_textBox;
            imgIntTab.changeResultsDestinationPath_button.Tag = imgIntTab.resultsDestinationPath_textBox;
        }
                
        bool lastUseDifferentModelAlpha = false;

        void DisableUseModelForAlpha()
        {
            var useDifferentModelForAlpha_checkBox = settingsTab.useDifferentModelForAlpha_checkBox
                ;
            useDifferentModelForAlpha_checkBox.Enabled = checkedModels.Count <= 1 || settingsTab.useProfileModel_checkBox.Checked;

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
            rulesTab.rules_groupBox.Visible = !on;
        }

        private void OpenModelFolder(object sender, EventArgs e)
        {
            Process.Start(settingsTab.modelsPath_textBox.Text);
        }

        #region PREVIEW methods

        Bitmap originalPreview, resultPreview;
        int visibleImageWidthBeforeResize, visibleImageHeightBeforeResize;

        Rectangle _minimap;
        Bitmap _thumbnailBitmap;

        string previewFullname;
        
        private void UpdateStatusBar()
        {
            ImageBox zoomImageBox = previewTab.zoomImageBox;

            RectangleF rect = zoomImageBox.GetSourceImageRegion();
            if (rect.Width > zoomImageBox.Image.Width) rect.Width = zoomImageBox.Image.Width;
            if (rect.Height > zoomImageBox.Image.Height) rect.Height = zoomImageBox.Image.Height;
            currentW = (int)Math.Floor(rect.Width);
            currentH = (int)Math.Round(rect.Height);
            previewTab.imageSizeToolStripStatusLabel.Text = $"W:{currentW}, H:{currentH}";            
        }

        private void OpenImage(string fullname)
        {
            ImageBox zoomImageBox = previewTab.zoomImageBox, miniMapImageBox = previewTab.miniMapImageBox, previewImageBox = previewTab.previewImageBox;

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
            ImageBox zoomImageBox = previewTab.zoomImageBox, previewImageBox = previewTab.previewImageBox;

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
            ImageBox zoomImageBox = previewTab.zoomImageBox, miniMapImageBox = previewTab.miniMapImageBox, previewImageBox = previewTab.previewImageBox;

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
            ImageBox zoomImageBox = previewTab.zoomImageBox, miniMapImageBox = previewTab.miniMapImageBox, previewImageBox = previewTab.previewImageBox;

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
            previewTab.zoomLevelsToolStripComboBox.Items.Clear();
            
            foreach (int zoom in previewTab.zoomImageBox.ZoomLevels)
            {
                previewTab.zoomLevelsToolStripComboBox.Items.Add(string.Format("{0}%", zoom));
            }
        }

        private void FitImage()
        {
            if (previewTab.zoomImageBox.Image != null)
            {
                double zoomFactor = previewTab.zoomImageBox.ZoomFactor;

                Size imageSize = previewTab.zoomImageBox.Image.Size;
                int scaledWidth = Convert.ToInt32(imageSize.Width * zoomFactor);
                int scaledHeight = Convert.ToInt32(imageSize.Height * zoomFactor);

                Size viewSize = previewTab.zoomImageBox.GetInsideViewPort().Size;

                if (scaledWidth < viewSize.Width && scaledHeight < viewSize.Height)
                {
                    previewTab.zoomImageBox.ZoomToFit();
                }
            }
        }
        
        private void PreviewInProgress(bool inProgress)
        {            
            bool enabled = !inProgress;            
            previewTab.preview_progressBar.Value = 0;

            previewTab.previewUpdate_button.Enabled = enabled;
            previewTab.zoomImageBox.Enabled = enabled;
            previewTab.previewModels_comboBox.Enabled = enabled;
            previewTab.button_previewSaveComparison.Enabled = enabled;
            previewTab.previewSaveOutputFormat_button.Enabled = enabled;
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
        
            var rect = previewTab.zoomImageBox.GetSourceImageRegion();        

            if (rect.Width != 0 && rect.Height != 0)
            {
                bool fit = false;
                if (Math.Round(rect.X + rect.Width,0) > Math.Round(previewTab.zoomImageBox.Image.Width - 17 / previewTab.zoomImageBox.ZoomFactor, 0) && previewTab.zoomImageBox.ZoomFactor >= 1)
                {
                    newX = (int)Math.Round(previewTab.zoomImageBox.Image.Width - rect.Width - 17 / previewTab.zoomImageBox.ZoomFactor, 0);
                    if (newX - rect.X < 1) newX--;
                    if (newX > 0)
                        fit = true;
                }
                if (Math.Round(rect.Y + rect.Height, 0) > Math.Round(previewTab.zoomImageBox.Image.Height - 17 / previewTab.zoomImageBox.ZoomFactor, 0) && previewTab.zoomImageBox.ZoomFactor >= 1)
                {
                    newY = (int)Math.Round(previewTab.zoomImageBox.Image.Height  - rect.Height - 17 / previewTab.zoomImageBox.ZoomFactor, 0);
                    if (newY - rect.Y < 1) newY--;
                    if (newY > 0)
                        fit = true;
                }

                currentX = (int)rect.X;
                currentY = (int)rect.Y;

                if (fit)
                {
                    zoomed = true;
                    previewTab.zoomImageBox.ZoomToRegion(newX, newY, rect.Width, rect.Height);
                    zoomed = false;
                }
            }

            UpdateMiniMap();

            if (!previewTab.zoomImageBox.IsPanning)            
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
            previewTab.zoomLevelsToolStripComboBox.Text = string.Format("{0}%", previewTab.zoomImageBox.Zoom);

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
                    e.Graphics.DrawImage(_thumbnailBitmap, previewTab.miniMapImageBox.GetImageViewPort().
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
            if (previewTab.previewImageBox.Image == resultPreview)
                previewTab.previewImageBox.Image = originalPreview;
        }

        private void previewImageBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (originalPreview == null || resultPreview == null)
                return;
            if (previewTab.previewImageBox.Image == originalPreview)
                previewTab.previewImageBox.Image = resultPreview;
        }
                
        private void DarkDockPanel1_ActiveContentChanged(object sender, AltUI.Docking.DockContentEventArgs e)
        {
            if(darkDockPanel1.ActiveContent.TabIndex == 1 && (Width != widthBeforeResize || Height != heightBeforeResize))
            {
                FitImage();
                UpdatePreview();
            }
        }


        private async void previewUpdate_button_Click(object sender, EventArgs e)
        {            
            var model = previewTab.previewModels_comboBox.SelectedValue as ModelInfo;
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
                    previewTab.previewImageBox.Image = preview2;
                    resultPreview = preview2;
                }
                preview.Dispose();
            }               
        }

        private async void savePreview(bool saveAsPng)
        {            
            var model = previewTab.previewModels_comboBox.SelectedValue as ModelInfo;
            if (previewTab.zoomImageBox.Image == null)
                return;

            string imagePath = "";
            if (previewFullname == Path.GetTempPath() + clipboardImageName || ViewModel.Config.ShowPreviewSaveDialog) //image from clipboard
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.DefaultExt = "";
                saveFileDialog.InitialDirectory = ViewModel.IEU.OutputDirectoryPath;

                string modelName = model.Name;

                if (previewFullname == Path.GetTempPath() + clipboardImageName)
                    saveFileDialog.FileName = $"ClipboardImage_{modelName}";
                else
                    saveFileDialog.FileName = $"{Path.GetFileNameWithoutExtension(previewFullname)}_{modelName}";
                var diResult = saveFileDialog.ShowDialog();
                if (diResult == DialogResult.OK)
                    imagePath = saveFileDialog.FileName;
                else
                    return;

                string fileName = Path.GetFileNameWithoutExtension(imagePath);
                string dir = Path.GetDirectoryName(imagePath);

                imagePath = $"{ dir }\\{fileName}{"." + previewTab.outputFormatPreview_comboBox.Text.ToLower()}";
            }
            PreviewInProgress(true);          
            try
            {
                bool success = await ViewModel.IEU.Preview(previewFullname, previewTab.zoomImageBox.Image, model, saveAsPng, true, imagePath);
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
            int.TryParse(previewTab.comparisonMod_comboBox.SelectedValue.ToString(), out comparisonMod);
            int newWidth = comparisonMod * resultPreview.Width, newHeight = comparisonMod * resultPreview.Height;

            Bitmap outputImage = new Bitmap(2 * newWidth, newHeight + footerHeight);
            var mdl = previewTab.previewModels_comboBox.SelectedValue as ModelInfo;
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
                Color color = previewTab.comparison_colorWheel.Color; //Color.FromArgb(226, 00, 122)
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

            zoom = Convert.ToInt32(previewTab.zoomLevelsToolStripComboBox.Text.Substring(0, previewTab.zoomLevelsToolStripComboBox.Text.Length - 1));

            previewTab.zoomImageBox.Zoom = zoom;
        }

        private void zoomInToolStripButton_Click(object sender, EventArgs e)
        {
            previewTab.zoomImageBox.ZoomIn();
        }

        private void zoomOutToolStripButton_Click(object sender, EventArgs e)
        {
            previewTab.zoomImageBox.ZoomOut();
        }

        private void actualSizeToolStripButton_Click(object sender, EventArgs e)
        {
            previewTab.zoomImageBox.ActualSize();
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

        private void comparison_colorWheel_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    var coldial = new ColorPickerDialog();
                    coldial.Color = previewTab.comparison_colorWheel.Color;
                    coldial.ShowDialog(this);
                    previewTab.comparison_colorWheel.Color = coldial.Color;
                    break;
            }
        }

        private void preserveFormatPreview_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            //outputFormatPreview_comboBox.Enabled = !preserveFormatPreview_checkBox.Checked;
            //preserveFormat_checkBox.Checked = preserveFormatPreview_checkBox.Checked;
        }

        private void comparisonMod_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewModel.Config.ComparisonModSelectedIndex = previewTab.comparisonMod_comboBox.SelectedIndex;
        }


        #endregion

        #region MainForm event handlers

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            widthBeforeResize = Width;
            heightBeforeResize = Height;
            RectangleF visibleImageRegion = previewTab.zoomImageBox.GetSourceImageRegion();
            visibleImageWidthBeforeResize = Convert.ToInt32(visibleImageRegion.Width);
            visibleImageHeightBeforeResize = Convert.ToInt32(visibleImageRegion.Height);
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            
            if (darkDockPanel1.ActiveContent.TabIndex == 1 && (widthBeforeResize != Width || heightBeforeResize != Height))
                FitImage();
            else
                return;

            RectangleF visibleImageRegion = previewTab.zoomImageBox.GetSourceImageRegion();
            int w = Convert.ToInt32(visibleImageRegion.Width);
            int h = Convert.ToInt32(visibleImageRegion.Height);

            if (Math.Abs(visibleImageWidthBeforeResize - w) <= 2 && Math.Abs(visibleImageHeightBeforeResize - h) <= 2)
                return;

            UpdatePreview();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {         
            ViewModel.Config.LogPanelWidth = mainTab.splitContainer1.SplitterDistance;
            
            ViewModel.Config.ActiveTab = darkDockPanel1.ActiveContent.TabIndex;
            ViewModel.Config.ComparisonColor = previewTab.comparison_colorWheel.Color;
            ViewModel.Config.WindowState = WindowState;
            ViewModel.Config.SaveSettings();
            ViewModel.IEU.SaveSettings();
            ViewModel.IEU.CurrentPreset.Write();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SendMessage(rulesTab.filterFilenameContains_textBox.Handle, 0x1501, 1, "word1;word2;word3");
            SendMessage(rulesTab.filterFilenameNotContains_textBox.Handle, 0x1501, 1, "word1;word2;word3");
            SendMessage(rulesTab.filterFolderNameContains_textBox.Handle, 0x1501, 1, "word1;word2;word3");
            SendMessage(rulesTab.filterFolderNameNotContains_textBox.Handle, 0x1501, 1, "word1;word2;word3");
            SendMessage(modIntTab.interpolationOutputModelName_textBox.Handle, 0x1501, 1, "New model name");

            darkDockPanel1.AddContent(mainTab);
            darkDockPanel1.AddContent(previewTab);
            darkDockPanel1.AddContent(settingsTab);
            darkDockPanel1.AddContent(formatsTab);
            darkDockPanel1.AddContent(rulesTab);
            //darkDockPanel1.AddContent(ffff);

            List<DarkDockContent> tabs = new List<DarkDockContent>() { mainTab, previewTab, settingsTab, formatsTab, rulesTab };

            ViewModel.Config.ReadSettings();

            if(ViewModel.Config.WindowState != FormWindowState.Minimized)
                WindowState = ViewModel.Config.WindowState;
            Location = ViewModel.Config.WindowLocation;
            Width = Convert.ToInt32(ViewModel.Config.WindowWidth);
            Height = Convert.ToInt32(ViewModel.Config.WindowHeight);

            mainTab.splitContainer1.SplitterDistance = Convert.ToInt32(ViewModel.Config.LogPanelWidth);
            var activeTab = tabs.Where(x => x.TabIndex == ViewModel.Config.ActiveTab).FirstOrDefault();
            if (activeTab != null)
                darkDockPanel1.ActiveContent = activeTab;

            previewTab.comparison_colorWheel.Color = ViewModel.Config.ComparisonColor;
            previewTab.comparisonMod_comboBox.SelectedIndex = ViewModel.Config.ComparisonModSelectedIndex;
            LightTheme = !ViewModel.Config.DarkTheme;

            bool myPathAreOk = VerifyPaths();
            if (!myPathAreOk)
                darkDockPanel1.ActiveContent.TabIndex = 2;                       
        }

        private void MainForm_DoubleClick(object sender, EventArgs e)
        {
            var location = (e as MouseEventArgs).X;
            var form = sender as MainFormDark;
            var x1 = form.Width - 30;
            var x2 = form.Width;
            if (location > x1 && location < x2)
            {
                mainTab.splitContainer1.Panel2Collapsed = !mainTab.splitContainer1.Panel2Collapsed;
                if (mainTab.splitContainer1.Panel2.Size.Width < 51)
                    mainTab.splitContainer1.SplitterDistance = 100;
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

        private void MainForm_Enter(object sender, EventArgs e)
        {
            if (notificationActive)
                popup.Hide();
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
                    darkDockPanel1.ActiveContent.TabIndex = 1;
                }
            }
        }
        #endregion

        #region MAINTAB

        private void comboBox_DisableMouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            mainTab.richTextBox1.SelectionStart = mainTab.richTextBox1.Text.Length;
            // scroll it automatically
            mainTab.richTextBox1.ScrollToCaret();
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
                    string folderNewPath = settingsTab.imgPath_textBox.Text + Path.DirectorySeparatorChar + folderName;

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
                            File.Copy(path, settingsTab.modelsPath_textBox.Text + Path.DirectorySeparatorChar + Path.GetFileName(path), true);
                            modelsCopied++;
                        }
                        else
                        {
                            File.Copy(path, settingsTab.imgPath_textBox.Text + Path.DirectorySeparatorChar + Path.GetFileName(path), true);
                            imagesCopied++;
                        }
                    }
                }
            MessageBox.Show($"Succesfully copied {imagesCopied} files" + (modelsCopied > 0 ? $" and {modelsCopied} models" : ""));
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
            mainTab.overwriteMode_comboBox.Enabled = !mainTab.UseModelChain_checkBox.Checked;
            mainTab.outputDestinationMode_comboBox.Enabled = !mainTab.UseModelChain_checkBox.Checked;
            mainTab.chainOrder_button.Enabled = mainTab.UseModelChain_checkBox.Checked;
        }


        private void showStepsButtons_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SetStepVisibility(!mainTab.showStepsButtons_checkBox.Checked);
        }


        private void toogleLogView_button_Click(object sender, EventArgs e)
        {
            if (mainTab.splitContainer1.Panel2Collapsed)
                mainTab.toogleLogView_button.Text = "Hide logs";
            else
                mainTab.toogleLogView_button.Text = "Show logs";

            mainTab.splitContainer1.Panel2Collapsed = !mainTab.splitContainer1.Panel2Collapsed;
        }


        #endregion

        #region SETTINGS even handles
        private void changePath_button_Click(object sender, EventArgs e)
        {
            TextBox textBox = (sender as Button).Tag as TextBox;
            FolderSelectDialog.FolderSelectDialog folderSelectDialog = new FolderSelectDialog.FolderSelectDialog();
            folderSelectDialog.ShowDialog();
            if (folderSelectDialog.FileName != "")
                textBox.Text = folderSelectDialog.FileName;

            mainTab.Enabled = VerifyPaths();
        }

        private void advancedUseSuffix_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            settingsTab.advancedSuffix_textBox.ReadOnly = !settingsTab.advancedUseSuffix_checkBox.Checked;
        }

        private void thresholdEnabled_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (settingsTab.thresholdEnabledRbg_checkBox.Checked || settingsTab.thresholdEnabledAlpha_checkBox.Checked)
            {
                settingsTab.thresholdBlack_numericUpDown.Enabled = true;
                settingsTab.thresholdWhite_numericUpDown.Enabled = true;
            }
            else
            {
                settingsTab.thresholdBlack_numericUpDown.Enabled = false;
                settingsTab.thresholdWhite_numericUpDown.Enabled = false;
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

        private void useDifferentModelForAlpha_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            settingsTab.modelForAlpha_comboBox.Enabled = settingsTab.useDifferentModelForAlpha_checkBox.Checked;
            if (checkedModels.Count <= 1 && settingsTab.useDifferentModelForAlpha_checkBox.Checked == false)
                lastUseDifferentModelAlpha = false;
        }

        private void useFilterForAlpha_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            settingsTab.filterForAlpha_comboBox.Enabled = settingsTab.useFilterForAlpha_checkBox.Checked;
        }

        private void useProfileModel_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            var useDifferentModelForAlpha_checkBox = settingsTab.useDifferentModelForAlpha_checkBox;
            var useProfileModel_checkBox = settingsTab.useProfileModel_checkBox;

            settingsTab.profileModel_comboBox.Enabled = useProfileModel_checkBox.Checked;
            treeView1.Enabled = !useProfileModel_checkBox.Checked;

            if (!useDifferentModelForAlpha_checkBox.Enabled && useProfileModel_checkBox.Checked)
                useDifferentModelForAlpha_checkBox.Enabled = true;
            if (useDifferentModelForAlpha_checkBox.Enabled && !useProfileModel_checkBox.Checked && checkedModels.Count > 1)
                DisableUseModelForAlpha();
        }

        private void useCondaEnv_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            settingsTab.condaEnvName_textBox.Enabled = settingsTab.useCondaEnv_checkBox.Checked;
        }

        private void inMemoryMode_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            mainTab.crop_button.Enabled = !settingsTab.inMemoryMode_checkBox.Checked;
            mainTab.merge_button.Enabled = !settingsTab.inMemoryMode_checkBox.Checked;
            mainTab.upscale_button.Enabled = !settingsTab.inMemoryMode_checkBox.Checked;
        }

        private void showIEU_button_Click(object sender, EventArgs e)
        {
            PropertiesForm propertiesForm = new PropertiesForm(ViewModel.IEU);

            propertiesForm.ShowDialog(this);
        }

        private void autoSetTileSize_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            settingsTab.maxTileHeight_numericUpDown.Enabled = settingsTab.maxTileWidth_numericUpDown.Enabled = !settingsTab.autoSetTileSize_checkBox.Checked;
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

        private void preciseTile_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            settingsTab.overlapSize_numericUpDown.Enabled = !settingsTab.preciseTile_checkBox.Checked;
        }

        private void preserveFormat_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            settingsTab.outputFormat_comboBox.Enabled = !settingsTab.preserveFormat_checkBox.Checked;
        }


        #endregion                     
                
        private void general_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void textbox_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = e.Data.GetData(DataFormats.FileDrop) as string[];
            var path = filePaths[0];
            string folderName = Path.GetFileName(path);
            string folderNewPath = settingsTab.imgPath_textBox.Text + Path.DirectorySeparatorChar + folderName;

            if ((File.GetAttributes(path) & FileAttributes.Directory) == FileAttributes.Directory)
            {
                var t = (sender as TextBox);
                t.Text = path;
            }
        }

        #region MODEL INTERPOLATION

        string alphaPrev = "05";
        private async void interpolationStart_button_Click(object sender, EventArgs e)
        {
            KeyValue<bool, double> alpha = Helper.CheckAlphaValue(modIntTab.modelInterpolationAlphaValue_textBox.Text);

            if (!alpha.Key)
            {
                MessageBox.Show("Alpha value is not valid value");
                return;
            }
            darkDockPanel1.ActiveContent.TabIndex = 0;
            bool success = await ViewModel.IEU.CreateInterpolatedModel(
                (modIntTab.interpolationModelOne_comboBox.SelectedValue as ModelInfo).FullName,
                (modIntTab.interpolationModelTwo_comboBox.SelectedValue as ModelInfo).FullName,
                alpha.Value,
                modIntTab.interpolationOutputModelName_textBox.Text);
        }
        private void InterpolationSettingsChanged(object sender, EventArgs e)
        {
            string alphaNow = modIntTab.modelInterpolationAlphaValue_textBox.Text.Replace(",", "");
            modIntTab.interpolationOutputModelName_textBox.Text = modIntTab.interpolationOutputModelName_textBox.Text
                .Replace($"_interp_{alphaPrev}", $"_interp_{alphaNow}");
            alphaPrev = alphaNow;
        }
        private void InterpolationModelsChanged(object sender, EventArgs e)
        {
            modIntTab.interpolationOutputModelName_textBox.Text =
                $"{((ModelInfo)modIntTab.interpolationModelOne_comboBox.SelectedItem)?.Name.Replace(".pth", "")}_" +
                $"{((ModelInfo)modIntTab.interpolationModelTwo_comboBox.SelectedItem)?.Name.Replace(".pth", "")}_" +
                $"interp_{modIntTab.modelInterpolationAlphaValue_textBox.Text.Replace(",", "").Replace(".", "")}.pth";
        }
        private void ModelInterpolationAlpha_trackBar_Scroll(object sender, EventArgs e)
        {
            modIntTab.modelInterpolationAlphaValue_textBox.Text = (modIntTab.modelInterpolationAlpha_trackBar.Value * 0.01).ToString();
        }
        
        #endregion
            
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
                    if(imgIntTab.overlayResultName_textBox.Text != Path.GetFileName(imgIntTab.imageA_pictureBox.Tag as string))
                        imgIntTab.overlayResultName_textBox.Text = Path.GetFileNameWithoutExtension(filePaths[0]) + "_interpolated.png";
                    Label label = pictureBox.Name == "imageA_pictureBox" ? imgIntTab.imageAName_label : imgIntTab.imageBName_label;
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
            string pathA = imgIntTab.imageA_pictureBox.Tag as string, pathB = imgIntTab.imageB_pictureBox.Tag as string;
            if (string.IsNullOrEmpty(pathA) || string.IsNullOrEmpty(pathB) || imgIntTab.imageA_pictureBox.Image == null || imgIntTab.imageB_pictureBox.Image == null)
            {
                MessageBox.Show("Images is missing");
                return;
            }
            KeyValue<bool, double> alpha = Helper.CheckAlphaValue(imgIntTab.imageInterpolationAlphaValue_textBox.Text);
            if(!alpha.Key)
            {
                MessageBox.Show("Alpha value is not valid");
                return;
            }
            
            if (string.IsNullOrEmpty(imgIntTab.overlayResultName_textBox.Text))
                imgIntTab.overlayResultName_textBox.Text = Path.GetFileName(pathA);

            string destPath = pathA.Replace(Path.GetFileName(pathA), "");

            bool success = ViewModel.IEU.InterpolateImages(imgIntTab.imageA_pictureBox.Image, imgIntTab.imageB_pictureBox.Image, destPath + imgIntTab.overlayResultName_textBox.Text, alpha.Value);
            if (!success)
                darkDockPanel1.ActiveContent.TabIndex = 0;
            else
            {
                StepFinishedForm finishedForm = new StepFinishedForm(ViewModel.IEU.OutputDirectoryPath, $"Result is saved in { destPath }");
                finishedForm.ShowDialog();
                //MessageBox.Show($"Result is saved in {ViewModel.IEU.OutputDirectoryPath}");
            }
        }

        private async void OverlayFolders_button_Click(object sender, EventArgs e)
        {
            string originalPath = imgIntTab.originalImagesPath_textBox.Text, destinationPath = imgIntTab.resultsDestinationPath_textBox.Text;
            string pathA = imgIntTab.resultsAPath_textBox.Text, pathB = imgIntTab.resultsBPath_textBox.Text;
            KeyValue<bool, double> alpha = Helper.CheckAlphaValue(imgIntTab.imageInterpolationAlphaValue_textBox.Text);
            if (!alpha.Key)
            {
                MessageBox.Show("Alpha value is not valid");
                return;
            }
            darkDockPanel1.ActiveContent.TabIndex = 0;
            ViewModel.IEU.InterpolateFolders(originalPath, pathA, pathB, destinationPath, alpha.Value);

            StepFinishedForm finishedForm = new StepFinishedForm(destinationPath, $"Result is saved in { destinationPath }");
            finishedForm.ShowDialog();
        }

        private void ImageInterpolation_trackBar_Scroll(object sender, EventArgs e)
        {
            imgIntTab.imageInterpolationAlphaValue_textBox.Text = (imgIntTab.imageInterpolation_trackBar.Value * 0.01).ToString();
        }

        #endregion

        #region RULESET    

        private void SavePreset_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.AddPreset(settingsTab.presetName_textBox.Text);
        }
        private void LoadPreset_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.LoadPreset(settingsTab.presets_listBox.SelectedValue as Preset);
        }
        private void DeletePreset_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.DeletePreset(settingsTab.presets_listBox.SelectedValue as Preset);
        }
        private void presetsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (settingsTab.presets_listBox.SelectedValue != null)
                settingsTab.presetName_textBox.Text = (settingsTab.presets_listBox.SelectedValue as Preset).Name;
            if ((settingsTab.presets_listBox.SelectedValue as Preset).Name == "Global")
                settingsTab.deletePreset_button.Enabled = false;
            else
                settingsTab.deletePreset_button.Enabled = true;
        }


        private void SaveProfile_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.AddProfile(settingsTab.saveProfileName_textBox.Text);
        }
        private void LoadProfile_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.LoadProfile(settingsTab.profiles_listBox.SelectedValue as Profile);
        }

        private void LoadProfileMainTab_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.LoadProfile(mainTab.profilesMainTab_listBox.SelectedIndices[0]);
        }

        private void configs_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (settingsTab.profiles_listBox.SelectedValue != null)
                settingsTab.saveProfileName_textBox.Text = (settingsTab.profiles_listBox.SelectedValue as Profile).Name;
            if ((settingsTab.profiles_listBox.SelectedValue as Profile).Name == "Global")
                settingsTab.deleteProfile_button.Enabled = false;
            else
                settingsTab.deleteProfile_button.Enabled = true;
        }

        private void DeleteProfile_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.DeleteProfile(settingsTab.profiles_listBox.SelectedValue as Profile);
        }     

        private void SaveFilter_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.AddFilter(rulesTab.newFilterName_textBox.Text);
        }

        private void LoadFilter_button_Click(object sender, EventArgs e)
        {
            Filter loadedFilter = rulesTab.filters_listBox.SelectedValue as Filter;
            ViewModel.IEU.LoadFilter(loadedFilter);

            for (int i = 0; i < rulesTab.filterExtensions_checkedListBox.Items.Count; i++)
                rulesTab.filterExtensions_checkedListBox.SetItemChecked(i, false);

            foreach (var ext in loadedFilter.SelectedExtensionsList)
            {
                int index = rulesTab.filterExtensions_checkedListBox.Items.IndexOf(ext);
                rulesTab.filterExtensions_checkedListBox.SetItemChecked(index, true);
            }
        }
        
        private void DeleteFilter_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.DeleteFilter(rulesTab.filters_listBox.SelectedValue as Filter);
        }

        private void filters_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rulesTab.filters_listBox.SelectedValue != null)
                rulesTab.newFilterName_textBox.Text = (rulesTab.filters_listBox.SelectedValue as Filter).Name;
            if ((rulesTab.filters_listBox.SelectedValue as Filter).Name == "Global")
                rulesTab.deleteFilter_button.Enabled = false;
            else
                rulesTab.deleteFilter_button.Enabled = true;
        }

        private void SaveRule_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.AddRule(
                rulesTab.newRuleName_textBox.Text,
                rulesTab.ruleProfiles_comboBox.SelectedValue as Profile,
                rulesTab.ruleFilters_comboBox.SelectedValue as Filter);
            rulesTab.rules_listBox.DataSource = new BindingSource(ViewModel.IEU.Ruleset.Values.ToList(), null);
        }

        private void SaveRuleFromCurrent_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.AddRule(
                rulesTab.newRuleName_textBox.Text,
                ViewModel.IEU.CurrentProfile,
                ViewModel.IEU.CurrentFilter);
            rulesTab.rules_listBox.DataSource = new BindingSource(ViewModel.IEU.Ruleset.Values.ToList(), null);
        }

        private void DeleteRule_button_Click(object sender, EventArgs e)
        {
            ViewModel.IEU.DeleteRule(rulesTab.rules_listBox.SelectedValue as Rule);
            rulesTab.rules_listBox.DataSource = new BindingSource(ViewModel.IEU.Ruleset.Values.ToList(), null);
        }

        private void Rules_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rulesTab.rules_listBox.SelectedValue != null)
                rulesTab.newRuleName_textBox.Text = (rulesTab.rules_listBox.SelectedValue as Rule).Name;
            if ((rulesTab.rules_listBox.SelectedValue as Rule).Name == "Global")
                rulesTab.deleteRule_button.Enabled = false;            
            else
                rulesTab.deleteRule_button.Enabled = true;
            rulesTab.rulePriority_numericUpDown.Value = (rulesTab.rules_listBox.SelectedValue as Rule).Priority;
        }

        private void NewRuleName_textBox_TextChanged(object sender, EventArgs e)
        {
            rulesTab.saveRule_button.Enabled =
            rulesTab.saveRuleFromCurrent_button.Enabled =
            rulesTab.newRuleName_textBox.Text != "Global";           
        }

        private void LoadRule_button_Click(object sender, EventArgs e)
        {
            if (rulesTab.rules_listBox.SelectedValue is Rule selectedRule)
            {
                ViewModel.IEU.LoadProfile(selectedRule.Profile);
                ViewModel.IEU.LoadFilter(selectedRule.Filter);
            }
        }
      
        private void RulePriority_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int newValue = (int)rulesTab.rulePriority_numericUpDown.Value;
            if (rulesTab.rules_listBox.SelectedValue is Rule selectedRule
                && selectedRule.Name != "Global"
                && newValue != selectedRule.Priority
                && newValue > 0
                && newValue < rulesTab.rules_listBox.Items.Count)
            {
                ViewModel.IEU.ChangeRulePriority(selectedRule, newValue);
                rulesTab.rules_listBox.DataSource = new BindingSource(ViewModel.IEU.Ruleset.Values.ToList(), null);
                rulesTab.rules_listBox.SelectedIndex = rulesTab.rules_listBox.Items.Count - 1 - newValue;
            }
            else
                rulesTab.rulePriority_numericUpDown.Value = (rulesTab.rules_listBox.SelectedValue as Rule).Priority;
        }

        private void filterSizeOr_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rulesTab.filterSizeOr_checkBox.Checked)
                rulesTab.filterSizeOr_checkBox.Text = "AND";
            else
                rulesTab.filterSizeOr_checkBox.Text = "OR";
        }

        private void filterFilenameContains_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            rulesTab.filterFilenameContains_textBox.ReadOnly = !rulesTab.filterFilenameContains_checkBox.Checked;
        }

        private void filterFilenameNotContains_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            rulesTab.filterFilenameNotContains_textBox.ReadOnly = !rulesTab.filterFilenameNotContains_checkBox.Checked;
        }

        private void filtersSizeOn_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rulesTab.filtersSizeOn_checkBox.Checked)
            {
                rulesTab.filterSizeHeight_numericUpDown.Enabled = true;
                rulesTab.filterSizeWidth_numericUpDown.Enabled = true;
                rulesTab.filterSizeOr_checkBox.Enabled = true;
            }
            else
            {
                rulesTab.filterSizeHeight_numericUpDown.Enabled = false;
                rulesTab.filterSizeWidth_numericUpDown.Enabled = false;
                rulesTab.filterSizeOr_checkBox.Enabled = false;
            }
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

        #endregion

        void SetStepVisibility(bool visible)
        {
            mainTab.crop_button.Visible = mainTab.upscale_button.Visible = mainTab.merge_button.Visible = visible;
            mainTab.showStepsButtons_checkBox.Checked = !visible;
        }

        private void webpLossless_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            formatsTab.webpPreset_comboBox.Enabled = !formatsTab.webpLossless_checkBox.Checked;
            formatsTab.webpQuality_numericUpDown.Enabled = !formatsTab.webpLossless_checkBox.Checked;         
            if(formatsTab.webpLossless_checkBox.Checked)
                formatsTab.webpQuality_numericUpDown.Value = 100;            
        }
          
    }    
}
