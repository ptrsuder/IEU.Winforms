namespace ImageEnhancingUtility.Winforms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.upscale_button = new System.Windows.Forms.Button();
            this.esrganPath_textBox = new System.Windows.Forms.TextBox();
            this.resultsMergedPath_textBox = new System.Windows.Forms.TextBox();
            this.crop_button = new System.Windows.Forms.Button();
            this.merge_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.main_tabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressFiltered_label = new System.Windows.Forms.Label();
            this.progress_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.profilesMainTab_listBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.overwriteMode_comboBox = new System.Windows.Forms.ComboBox();
            this.runAll_button = new System.Windows.Forms.Button();
            this.outputMode_groupBox = new System.Windows.Forms.GroupBox();
            this.outputDestinationMode_comboBox = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.previewResult_tabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.zoomImageBox = new Cyotek.Windows.Forms.ImageBox();
            this.previewImageBox = new Cyotek.Windows.Forms.ImageBox();
            this.previewModels_comboBox = new System.Windows.Forms.ComboBox();
            this.preview_progressBar = new System.Windows.Forms.ProgressBar();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.miniMapImageBox = new Cyotek.Windows.Forms.ImageBox();
            this.imageSizeToolStripStatusLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.previewUpdate_button = new System.Windows.Forms.Button();
            this.previewSave_button = new System.Windows.Forms.Button();
            this.button_previewSaveComparison = new System.Windows.Forms.Button();
            this.previewSaveOutputFormat_button = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.openFromFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.actualSizeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomInToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomOutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomLevelsToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.settings_tabPage = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.topMost_checkBox = new System.Windows.Forms.CheckBox();
            this.showPopups_checkBox = new System.Windows.Forms.CheckBox();
            this.deleteProfile_button = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.ignoreAlpha_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.threshold_groupBox = new System.Windows.Forms.GroupBox();
            this.thresholdBlack_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.thresholdEnabled_checkBox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.thresholdWhite_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.imagePostprocess_groupBox = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.resizeImageAfterFilterType_comboBox = new System.Windows.Forms.ComboBox();
            this.resizeImageAfterScaleFactor_comboBox = new System.Windows.Forms.ComboBox();
            this.imagePreprocess_groupBox = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.resizeImageBeforeScaleFactor_comboBox = new System.Windows.Forms.ComboBox();
            this.resizeImageBeforeFilterType_comboBox = new System.Windows.Forms.ComboBox();
            this.noiseReductionType_comboBox = new System.Windows.Forms.ComboBox();
            this.outputFormat_comboBox = new System.Windows.Forms.ComboBox();
            this.ignoreSingleColorAlpha_checkBox = new System.Windows.Forms.CheckBox();
            this.balanceRgb_checkBox = new System.Windows.Forms.CheckBox();
            this.balanceAlphas_checkBox = new System.Windows.Forms.CheckBox();
            this.splitRGB_checkBox = new System.Windows.Forms.CheckBox();
            this.profileModel_comboBox = new System.Windows.Forms.ComboBox();
            this.useProfileModel_checkBox = new System.Windows.Forms.CheckBox();
            this.filterForAlpha_comboBox = new System.Windows.Forms.ComboBox();
            this.useFilterForAlpha_checkBox = new System.Windows.Forms.CheckBox();
            this.modelForAlpha_comboBox = new System.Windows.Forms.ComboBox();
            this.useDifferentModelForAlpha_checkBox = new System.Windows.Forms.CheckBox();
            this.seamlessTextures_checkBox = new System.Windows.Forms.CheckBox();
            this.preserveFormat_checkBox = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.condaEnvName_textBox = new System.Windows.Forms.TextBox();
            this.saveProfileName_textBox = new System.Windows.Forms.TextBox();
            this.useBasicSR_checkBox = new System.Windows.Forms.CheckBox();
            this.modelsPath_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveProfile_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.appCoreVersion_linkLabel = new System.Windows.Forms.LinkLabel();
            this.appVersion_label = new System.Windows.Forms.LinkLabel();
            this.checkForUpdates_checkBox = new System.Windows.Forms.CheckBox();
            this.profiles_listBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.loadProfile_button = new System.Windows.Forms.Button();
            this.useCondaEnv_checkBox = new System.Windows.Forms.CheckBox();
            this.deleteResults_checkBox = new System.Windows.Forms.CheckBox();
            this.outputPath_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inputPath_textBox = new System.Windows.Forms.TextBox();
            this.maxTileHeight_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.changeModelsPath_button = new System.Windows.Forms.Button();
            this.maxTileWidth_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.advancedUseSuffix_checkBox = new System.Windows.Forms.CheckBox();
            this.createMemoryImage_checkBox = new System.Windows.Forms.CheckBox();
            this.changeInputPath_button = new System.Windows.Forms.Button();
            this.useCPU_checkBox = new System.Windows.Forms.CheckBox();
            this.changeOutputPath_button = new System.Windows.Forms.Button();
            this.advancedSuffix_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.changeInputImgPath_button = new System.Windows.Forms.Button();
            this.changeMergedResultsPath_button = new System.Windows.Forms.Button();
            this.changeEsrganPath_button = new System.Windows.Forms.Button();
            this.preciseTile_checkBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.overlapSize_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.maxTileResolution_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.imgPath_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsOutputFormat_tabPage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webpLossless_checkBox = new System.Windows.Forms.CheckBox();
            this.webpQuality_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.webpPreset_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pngCompression_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.tiffSetting_groupBox = new System.Windows.Forms.GroupBox();
            this.tiffJpegQuality_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tiffSettings_comboBox = new System.Windows.Forms.ComboBox();
            this.ddsOutputSettings_groupBox = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ddsGenerateMipmaps_checkBox = new System.Windows.Forms.CheckBox();
            this.ddsCompresion_comboBox = new System.Windows.Forms.ComboBox();
            this.ddsFileFormat_comboBox = new System.Windows.Forms.ComboBox();
            this.ddsTextureType_comboBox = new System.Windows.Forms.ComboBox();
            this.advanced_tabPage = new System.Windows.Forms.TabPage();
            this.disableRuleSystem_checkBox = new System.Windows.Forms.CheckBox();
            this.rules_groupBox = new System.Windows.Forms.GroupBox();
            this.rulePriority_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.deleteRule_button = new System.Windows.Forms.Button();
            this.rules_listBox = new System.Windows.Forms.ListBox();
            this.newRuleName_textBox = new System.Windows.Forms.TextBox();
            this.ruleProfiles_comboBox = new System.Windows.Forms.ComboBox();
            this.ruleFilters_comboBox = new System.Windows.Forms.ComboBox();
            this.saveRuleFromCurrent_button = new System.Windows.Forms.Button();
            this.saveRule_button = new System.Windows.Forms.Button();
            this.loadRule_button = new System.Windows.Forms.Button();
            this.filters_groupBox = new System.Windows.Forms.GroupBox();
            this.deleteFilter_button = new System.Windows.Forms.Button();
            this.filterExtensions_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.newFilterName_textBox = new System.Windows.Forms.TextBox();
            this.filtersSize_groupBox = new System.Windows.Forms.GroupBox();
            this.filtersSizeOn_checkBox = new System.Windows.Forms.CheckBox();
            this.filterSizeWidth_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.filterSizeHeight_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.filterSizeOr_checkBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.saveFilter_button = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.filterFolderNameCaseSensitive_checkBox = new System.Windows.Forms.CheckBox();
            this.filterFolderNameContains_checkBox = new System.Windows.Forms.CheckBox();
            this.filterFolderNameContains_textBox = new System.Windows.Forms.TextBox();
            this.filterFolderNameNotContains_checkBox = new System.Windows.Forms.CheckBox();
            this.filterFolderNameNotContains_textBox = new System.Windows.Forms.TextBox();
            this.filtersFilename_groupBox = new System.Windows.Forms.GroupBox();
            this.filterFilenameCaseSensitive_checkBox = new System.Windows.Forms.CheckBox();
            this.filterFilenameContains_checkBox = new System.Windows.Forms.CheckBox();
            this.filterFilenameContains_textBox = new System.Windows.Forms.TextBox();
            this.filterFilenameNotContains_checkBox = new System.Windows.Forms.CheckBox();
            this.filterFilenameNotContains_textBox = new System.Windows.Forms.TextBox();
            this.loadFilter_button = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.filters_listBox = new System.Windows.Forms.ListBox();
            this.filtersAlpha_groupBox = new System.Windows.Forms.GroupBox();
            this.filterAlpha_comboBox = new System.Windows.Forms.ComboBox();
            this.interpolation_tabPage = new System.Windows.Forms.TabPage();
            this.modelInterpolationAlpha_trackBar = new System.Windows.Forms.TrackBar();
            this.interpolationOutputModelName_textBox = new System.Windows.Forms.TextBox();
            this.interpolationStart_button = new System.Windows.Forms.Button();
            this.modelInterpolationAlphaValue_textBox = new System.Windows.Forms.TextBox();
            this.interpolationModelTwo_comboBox = new System.Windows.Forms.ComboBox();
            this.interpolationModelOne_comboBox = new System.Windows.Forms.ComboBox();
            this.overlayResults_tabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.overlayImages_button = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.imageBName_label = new System.Windows.Forms.Label();
            this.imageB_panel = new System.Windows.Forms.Panel();
            this.imageB_pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.imageAName_label = new System.Windows.Forms.Label();
            this.imageA_panel = new System.Windows.Forms.Panel();
            this.imageA_pictureBox = new System.Windows.Forms.PictureBox();
            this.overlayResultName_textBox = new System.Windows.Forms.TextBox();
            this.overlayFolders_button = new System.Windows.Forms.Button();
            this.imageInterpolationAlphaValue_textBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.changeResultsDestinationPath_button = new System.Windows.Forms.Button();
            this.originalImagesPath_textBox = new System.Windows.Forms.TextBox();
            this.changeResultsBPath_button = new System.Windows.Forms.Button();
            this.resultsAPath_textBox = new System.Windows.Forms.TextBox();
            this.changeResultsAPath_button = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.changeOriginalImagesPath_button = new System.Windows.Forms.Button();
            this.resultsBPath_textBox = new System.Windows.Forms.TextBox();
            this.resultsDestinationPath_textBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageInterpolation_trackBar = new System.Windows.Forms.TrackBar();
            this.treeView_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openModelFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.popupNotifier1 = new Tulpep.NotificationWindow.PopupNotifier();
            this.tabControl1.SuspendLayout();
            this.main_tabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.outputMode_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.previewResult_tabPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.settings_tabPage.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.threshold_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBlack_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdWhite_numericUpDown)).BeginInit();
            this.imagePostprocess_groupBox.SuspendLayout();
            this.imagePreprocess_groupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileHeight_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileWidth_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overlapSize_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileResolution_numericUpDown)).BeginInit();
            this.settingsOutputFormat_tabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webpQuality_numericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pngCompression_numericUpDown)).BeginInit();
            this.tiffSetting_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiffJpegQuality_numericUpDown)).BeginInit();
            this.ddsOutputSettings_groupBox.SuspendLayout();
            this.advanced_tabPage.SuspendLayout();
            this.rules_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulePriority_numericUpDown)).BeginInit();
            this.filters_groupBox.SuspendLayout();
            this.filtersSize_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeWidth_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeHeight_numericUpDown)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.filtersFilename_groupBox.SuspendLayout();
            this.filtersAlpha_groupBox.SuspendLayout();
            this.interpolation_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelInterpolationAlpha_trackBar)).BeginInit();
            this.overlayResults_tabPage.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.imageB_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageB_pictureBox)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.imageA_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageA_pictureBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageInterpolation_trackBar)).BeginInit();
            this.treeView_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // upscale_button
            // 
            this.upscale_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.upscale_button.Location = new System.Drawing.Point(0, 196);
            this.upscale_button.Name = "upscale_button";
            this.upscale_button.Size = new System.Drawing.Size(149, 34);
            this.upscale_button.TabIndex = 1;
            this.upscale_button.Text = "RUN ESRGAN";
            this.toolTip1.SetToolTip(this.upscale_button, "Process all files from ESRGAN input folder and save them in results folder or it " +
        "subfolders depending on output mode");
            this.upscale_button.UseVisualStyleBackColor = true;
            // 
            // esrganPath_textBox
            // 
            this.esrganPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.esrganPath_textBox.Location = new System.Drawing.Point(111, 19);
            this.esrganPath_textBox.Name = "esrganPath_textBox";
            this.esrganPath_textBox.ReadOnly = true;
            this.esrganPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.esrganPath_textBox.TabIndex = 13;
            this.toolTip1.SetToolTip(this.esrganPath_textBox, "ESRGAN root folder");
            // 
            // resultsMergedPath_textBox
            // 
            this.resultsMergedPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsMergedPath_textBox.Location = new System.Drawing.Point(111, 72);
            this.resultsMergedPath_textBox.Name = "resultsMergedPath_textBox";
            this.resultsMergedPath_textBox.ReadOnly = true;
            this.resultsMergedPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.resultsMergedPath_textBox.TabIndex = 15;
            this.toolTip1.SetToolTip(this.resultsMergedPath_textBox, "IEU output folder");
            // 
            // crop_button
            // 
            this.crop_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.crop_button.Location = new System.Drawing.Point(0, 59);
            this.crop_button.Name = "crop_button";
            this.crop_button.Size = new System.Drawing.Size(149, 34);
            this.crop_button.TabIndex = 17;
            this.crop_button.Text = "SPLIT";
            this.toolTip1.SetToolTip(this.crop_button, "Create tiles from original images and save them as png in ESRGAN input folder");
            this.crop_button.UseVisualStyleBackColor = true;
            // 
            // merge_button
            // 
            this.merge_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.merge_button.Location = new System.Drawing.Point(0, 236);
            this.merge_button.Name = "merge_button";
            this.merge_button.Size = new System.Drawing.Size(149, 34);
            this.merge_button.TabIndex = 18;
            this.merge_button.Text = "MERGE";
            this.toolTip1.SetToolTip(this.merge_button, "Find all image tiles in results folder/subfolders, merge them in single image and" +
        " save it in merged-results folder/subfolder depending on output mode.");
            this.merge_button.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.main_tabPage);
            this.tabControl1.Controls.Add(this.previewResult_tabPage);
            this.tabControl1.Controls.Add(this.settings_tabPage);
            this.tabControl1.Controls.Add(this.settingsOutputFormat_tabPage);
            this.tabControl1.Controls.Add(this.advanced_tabPage);
            this.tabControl1.Controls.Add(this.interpolation_tabPage);
            this.tabControl1.Controls.Add(this.overlayResults_tabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 21);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1271, 743);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 19;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainTab_DragDrop);
            this.tabControl1.DragEnter += new System.Windows.Forms.DragEventHandler(this.general_DragEnter);
            // 
            // main_tabPage
            // 
            this.main_tabPage.Controls.Add(this.tableLayoutPanel1);
            this.main_tabPage.Location = new System.Drawing.Point(4, 25);
            this.main_tabPage.Name = "main_tabPage";
            this.main_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.main_tabPage.Size = new System.Drawing.Size(1263, 714);
            this.main_tabPage.TabIndex = 0;
            this.main_tabPage.Text = "Basic";
            this.main_tabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1257, 708);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressFiltered_label);
            this.panel2.Controls.Add(this.progress_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 681);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 24);
            this.panel2.TabIndex = 37;
            // 
            // progressFiltered_label
            // 
            this.progressFiltered_label.AutoSize = true;
            this.progressFiltered_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressFiltered_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressFiltered_label.Font = new System.Drawing.Font("Malgun Gothic", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressFiltered_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressFiltered_label.Location = new System.Drawing.Point(0, 0);
            this.progressFiltered_label.Name = "progressFiltered_label";
            this.progressFiltered_label.Size = new System.Drawing.Size(19, 21);
            this.progressFiltered_label.TabIndex = 24;
            this.progressFiltered_label.Text = "0";
            this.progressFiltered_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progress_label
            // 
            this.progress_label.AutoSize = true;
            this.progress_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progress_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.progress_label.Font = new System.Drawing.Font("Malgun Gothic", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progress_label.Location = new System.Drawing.Point(116, 0);
            this.progress_label.Name = "progress_label";
            this.progress_label.Size = new System.Drawing.Size(33, 21);
            this.progress_label.TabIndex = 23;
            this.progress_label.Text = "0/0";
            this.progress_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.profilesMainTab_listBox);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.runAll_button);
            this.panel1.Controls.Add(this.outputMode_groupBox);
            this.panel1.Controls.Add(this.upscale_button);
            this.panel1.Controls.Add(this.crop_button);
            this.panel1.Controls.Add(this.merge_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 672);
            this.panel1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(0, 624);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 31);
            this.button1.TabIndex = 52;
            this.button1.Text = "Load profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadProfileMainTab_button_Click);
            // 
            // profilesMainTab_listBox
            // 
            this.profilesMainTab_listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilesMainTab_listBox.FormattingEnabled = true;
            this.profilesMainTab_listBox.Location = new System.Drawing.Point(0, 356);
            this.profilesMainTab_listBox.Name = "profilesMainTab_listBox";
            this.profilesMainTab_listBox.Size = new System.Drawing.Size(149, 262);
            this.profilesMainTab_listBox.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.overwriteMode_comboBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 50);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile:Overwrite";
            // 
            // overwriteMode_comboBox
            // 
            this.overwriteMode_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.overwriteMode_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.overwriteMode_comboBox.FormattingEnabled = true;
            this.overwriteMode_comboBox.Location = new System.Drawing.Point(6, 19);
            this.overwriteMode_comboBox.Name = "overwriteMode_comboBox";
            this.overwriteMode_comboBox.Size = new System.Drawing.Size(137, 21);
            this.overwriteMode_comboBox.TabIndex = 0;
            // 
            // runAll_button
            // 
            this.runAll_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runAll_button.Location = new System.Drawing.Point(0, 293);
            this.runAll_button.Name = "runAll_button";
            this.runAll_button.Size = new System.Drawing.Size(149, 44);
            this.runAll_button.TabIndex = 32;
            this.runAll_button.Text = "SPLIT-ESRGAN-MERGE";
            this.runAll_button.UseVisualStyleBackColor = true;
            // 
            // outputMode_groupBox
            // 
            this.outputMode_groupBox.Controls.Add(this.outputDestinationMode_comboBox);
            this.outputMode_groupBox.Location = new System.Drawing.Point(0, 3);
            this.outputMode_groupBox.Name = "outputMode_groupBox";
            this.outputMode_groupBox.Size = new System.Drawing.Size(149, 52);
            this.outputMode_groupBox.TabIndex = 31;
            this.outputMode_groupBox.TabStop = false;
            this.outputMode_groupBox.Text = "Output mode";
            // 
            // outputDestinationMode_comboBox
            // 
            this.outputDestinationMode_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputDestinationMode_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.outputDestinationMode_comboBox.FormattingEnabled = true;
            this.outputDestinationMode_comboBox.Location = new System.Drawing.Point(6, 19);
            this.outputDestinationMode_comboBox.Name = "outputDestinationMode_comboBox";
            this.outputDestinationMode_comboBox.Size = new System.Drawing.Size(137, 21);
            this.outputDestinationMode_comboBox.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(158, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1MinSize = 400;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(1096, 672);
            this.splitContainer1.SplitterDistance = 581;
            this.splitContainer1.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Console", 10.25F);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(511, 672);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(158, 681);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1096, 24);
            this.progressBar1.TabIndex = 22;
            // 
            // previewResult_tabPage
            // 
            this.previewResult_tabPage.Controls.Add(this.tableLayoutPanel3);
            this.previewResult_tabPage.Controls.Add(this.toolStrip);
            this.previewResult_tabPage.Location = new System.Drawing.Point(4, 25);
            this.previewResult_tabPage.Name = "previewResult_tabPage";
            this.previewResult_tabPage.Size = new System.Drawing.Size(1263, 714);
            this.previewResult_tabPage.TabIndex = 5;
            this.previewResult_tabPage.Text = "Preview result";
            this.previewResult_tabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.zoomImageBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.previewImageBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.previewModels_comboBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.preview_progressBar, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.splitContainer3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1263, 689);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // zoomImageBox
            // 
            this.zoomImageBox.AllowDrop = true;
            this.zoomImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoomImageBox.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.zoomImageBox.GridColorAlternate = System.Drawing.SystemColors.ControlDark;
            this.zoomImageBox.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.zoomImageBox.Location = new System.Drawing.Point(3, 3);
            this.zoomImageBox.Name = "zoomImageBox";
            this.zoomImageBox.Size = new System.Drawing.Size(625, 498);
            this.zoomImageBox.TabIndex = 0;
            this.zoomImageBox.TabStop = false;
            this.zoomImageBox.ImageChanged += new System.EventHandler(this.zoomImageBox_ImageChanged);
            this.zoomImageBox.PanEnd += new System.EventHandler(this.zoomImageBox_PanEnd);
            this.zoomImageBox.Zoomed += new System.EventHandler<Cyotek.Windows.Forms.ImageBoxZoomEventArgs>(this.zoomImageBox_Zoomed);
            this.zoomImageBox.Scroll += new System.Windows.Forms.ScrollEventHandler(this.zoomImageBox_Scroll);
            this.zoomImageBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.zoomImageBox_DragDrop);
            this.zoomImageBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.general_DragEnter);
            this.zoomImageBox.Resize += new System.EventHandler(this.zoomImageBox_ImageChanged);
            // 
            // previewImageBox
            // 
            this.previewImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewImageBox.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.previewImageBox.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.previewImageBox.Location = new System.Drawing.Point(634, 3);
            this.previewImageBox.Name = "previewImageBox";
            this.previewImageBox.Size = new System.Drawing.Size(626, 498);
            this.previewImageBox.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.previewImageBox.TabIndex = 4;
            this.previewImageBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.previewImageBox_MouseDown);
            this.previewImageBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.previewImageBox_MouseUp);
            // 
            // previewModels_comboBox
            // 
            this.previewModels_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.previewModels_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.previewModels_comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewModels_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.previewModels_comboBox.FormattingEnabled = true;
            this.previewModels_comboBox.Location = new System.Drawing.Point(634, 507);
            this.previewModels_comboBox.Name = "previewModels_comboBox";
            this.previewModels_comboBox.Size = new System.Drawing.Size(626, 21);
            this.previewModels_comboBox.TabIndex = 6;
            // 
            // preview_progressBar
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.preview_progressBar, 2);
            this.preview_progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview_progressBar.Location = new System.Drawing.Point(3, 662);
            this.preview_progressBar.Name = "preview_progressBar";
            this.preview_progressBar.Size = new System.Drawing.Size(1257, 24);
            this.preview_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.preview_progressBar.TabIndex = 8;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 507);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.miniMapImageBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.imageSizeToolStripStatusLabel);
            this.tableLayoutPanel3.SetRowSpan(this.splitContainer3, 2);
            this.splitContainer3.Size = new System.Drawing.Size(625, 149);
            this.splitContainer3.SplitterDistance = 239;
            this.splitContainer3.TabIndex = 9;
            // 
            // miniMapImageBox
            // 
            this.miniMapImageBox.AllowZoom = false;
            this.miniMapImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.miniMapImageBox.AutoPan = false;
            this.miniMapImageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.miniMapImageBox.GridColor = System.Drawing.SystemColors.Control;
            this.miniMapImageBox.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.miniMapImageBox.Location = new System.Drawing.Point(5, 19);
            this.miniMapImageBox.Name = "miniMapImageBox";
            this.miniMapImageBox.PanMode = Cyotek.Windows.Forms.ImageBoxPanMode.Middle;
            this.miniMapImageBox.PixelGridColor = System.Drawing.Color.Transparent;
            this.miniMapImageBox.Size = new System.Drawing.Size(129, 127);
            this.miniMapImageBox.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.miniMapImageBox.TabIndex = 1;
            this.miniMapImageBox.TabStop = false;
            this.miniMapImageBox.VirtualMode = true;
            this.miniMapImageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.miniMapImageBox_Paint);
            // 
            // imageSizeToolStripStatusLabel
            // 
            this.imageSizeToolStripStatusLabel.AutoSize = true;
            this.imageSizeToolStripStatusLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.imageSizeToolStripStatusLabel.Location = new System.Drawing.Point(340, 0);
            this.imageSizeToolStripStatusLabel.Name = "imageSizeToolStripStatusLabel";
            this.imageSizeToolStripStatusLabel.Size = new System.Drawing.Size(42, 13);
            this.imageSizeToolStripStatusLabel.TabIndex = 0;
            this.imageSizeToolStripStatusLabel.Text = "X:0 Y:0";
            this.imageSizeToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.84026F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.15974F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel6.Controls.Add(this.previewUpdate_button, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.previewSave_button, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.button_previewSaveComparison, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.previewSaveOutputFormat_button, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(634, 538);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(626, 118);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // previewUpdate_button
            // 
            this.previewUpdate_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewUpdate_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.previewUpdate_button.Location = new System.Drawing.Point(3, 3);
            this.previewUpdate_button.Name = "previewUpdate_button";
            this.previewUpdate_button.Size = new System.Drawing.Size(211, 75);
            this.previewUpdate_button.TabIndex = 6;
            this.previewUpdate_button.Text = "Update preview";
            this.previewUpdate_button.UseVisualStyleBackColor = true;
            this.previewUpdate_button.Click += new System.EventHandler(this.previewUpdate_button_Click);
            // 
            // previewSave_button
            // 
            this.previewSave_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewSave_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.previewSave_button.Location = new System.Drawing.Point(220, 3);
            this.previewSave_button.Name = "previewSave_button";
            this.tableLayoutPanel6.SetRowSpan(this.previewSave_button, 2);
            this.previewSave_button.Size = new System.Drawing.Size(212, 112);
            this.previewSave_button.TabIndex = 6;
            this.previewSave_button.Text = "Enhance and save as png";
            this.previewSave_button.UseVisualStyleBackColor = true;
            this.previewSave_button.Click += new System.EventHandler(this.previewSavePng_button_Click);
            // 
            // button_previewSaveComparison
            // 
            this.button_previewSaveComparison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_previewSaveComparison.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_previewSaveComparison.Location = new System.Drawing.Point(3, 84);
            this.button_previewSaveComparison.Name = "button_previewSaveComparison";
            this.button_previewSaveComparison.Size = new System.Drawing.Size(211, 31);
            this.button_previewSaveComparison.TabIndex = 7;
            this.button_previewSaveComparison.Text = "Save comparison to clipboard";
            this.button_previewSaveComparison.UseVisualStyleBackColor = true;
            this.button_previewSaveComparison.Click += new System.EventHandler(this.previewSaveComparison_button_Click);
            // 
            // previewSaveOutputFormat_button
            // 
            this.previewSaveOutputFormat_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewSaveOutputFormat_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.previewSaveOutputFormat_button.Location = new System.Drawing.Point(438, 3);
            this.previewSaveOutputFormat_button.Name = "previewSaveOutputFormat_button";
            this.tableLayoutPanel6.SetRowSpan(this.previewSaveOutputFormat_button, 2);
            this.previewSaveOutputFormat_button.Size = new System.Drawing.Size(185, 112);
            this.previewSaveOutputFormat_button.TabIndex = 9;
            this.previewSaveOutputFormat_button.Text = "Enhance and save with ouput format";
            this.previewSaveOutputFormat_button.UseVisualStyleBackColor = true;
            this.previewSaveOutputFormat_button.Click += new System.EventHandler(this.previewSaveOutputFormat_button_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFromFileToolStripButton,
            this.toolStripSeparator8,
            this.actualSizeToolStripButton,
            this.zoomInToolStripButton,
            this.zoomOutToolStripButton,
            this.toolStripSeparator2,
            this.zoomLevelsToolStripComboBox});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1263, 25);
            this.toolStrip.TabIndex = 3;
            // 
            // openFromFileToolStripButton
            // 
            this.openFromFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFromFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openFromFileToolStripButton.Image")));
            this.openFromFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFromFileToolStripButton.Name = "openFromFileToolStripButton";
            this.openFromFileToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openFromFileToolStripButton.Text = "&Open";
            this.openFromFileToolStripButton.Click += new System.EventHandler(this.openFromFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // actualSizeToolStripButton
            // 
            this.actualSizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actualSizeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("actualSizeToolStripButton.Image")));
            this.actualSizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actualSizeToolStripButton.Name = "actualSizeToolStripButton";
            this.actualSizeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.actualSizeToolStripButton.Text = "Actual Size";
            this.actualSizeToolStripButton.Click += new System.EventHandler(this.actualSizeToolStripButton_Click);
            // 
            // zoomInToolStripButton
            // 
            this.zoomInToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomInToolStripButton.Image")));
            this.zoomInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInToolStripButton.Name = "zoomInToolStripButton";
            this.zoomInToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zoomInToolStripButton.Text = "Zoom In";
            this.zoomInToolStripButton.Click += new System.EventHandler(this.zoomInToolStripButton_Click);
            // 
            // zoomOutToolStripButton
            // 
            this.zoomOutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutToolStripButton.Image")));
            this.zoomOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutToolStripButton.Name = "zoomOutToolStripButton";
            this.zoomOutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zoomOutToolStripButton.Text = "Zoom Out";
            this.zoomOutToolStripButton.Click += new System.EventHandler(this.zoomOutToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // zoomLevelsToolStripComboBox
            // 
            this.zoomLevelsToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zoomLevelsToolStripComboBox.Name = "zoomLevelsToolStripComboBox";
            this.zoomLevelsToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.zoomLevelsToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.zoomLevelsToolStripComboBox_SelectedIndexChanged);
            // 
            // settings_tabPage
            // 
            this.settings_tabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settings_tabPage.Controls.Add(this.groupBox8);
            this.settings_tabPage.Controls.Add(this.deleteProfile_button);
            this.settings_tabPage.Controls.Add(this.groupBox9);
            this.settings_tabPage.Controls.Add(this.condaEnvName_textBox);
            this.settings_tabPage.Controls.Add(this.saveProfileName_textBox);
            this.settings_tabPage.Controls.Add(this.useBasicSR_checkBox);
            this.settings_tabPage.Controls.Add(this.modelsPath_textBox);
            this.settings_tabPage.Controls.Add(this.label2);
            this.settings_tabPage.Controls.Add(this.saveProfile_button);
            this.settings_tabPage.Controls.Add(this.tableLayoutPanel2);
            this.settings_tabPage.Controls.Add(this.profiles_listBox);
            this.settings_tabPage.Controls.Add(this.label7);
            this.settings_tabPage.Controls.Add(this.loadProfile_button);
            this.settings_tabPage.Controls.Add(this.useCondaEnv_checkBox);
            this.settings_tabPage.Controls.Add(this.deleteResults_checkBox);
            this.settings_tabPage.Controls.Add(this.outputPath_textBox);
            this.settings_tabPage.Controls.Add(this.label9);
            this.settings_tabPage.Controls.Add(this.inputPath_textBox);
            this.settings_tabPage.Controls.Add(this.maxTileHeight_numericUpDown);
            this.settings_tabPage.Controls.Add(this.changeModelsPath_button);
            this.settings_tabPage.Controls.Add(this.maxTileWidth_numericUpDown);
            this.settings_tabPage.Controls.Add(this.advancedUseSuffix_checkBox);
            this.settings_tabPage.Controls.Add(this.createMemoryImage_checkBox);
            this.settings_tabPage.Controls.Add(this.changeInputPath_button);
            this.settings_tabPage.Controls.Add(this.useCPU_checkBox);
            this.settings_tabPage.Controls.Add(this.changeOutputPath_button);
            this.settings_tabPage.Controls.Add(this.advancedSuffix_textBox);
            this.settings_tabPage.Controls.Add(this.label8);
            this.settings_tabPage.Controls.Add(this.changeInputImgPath_button);
            this.settings_tabPage.Controls.Add(this.changeMergedResultsPath_button);
            this.settings_tabPage.Controls.Add(this.changeEsrganPath_button);
            this.settings_tabPage.Controls.Add(this.preciseTile_checkBox);
            this.settings_tabPage.Controls.Add(this.label6);
            this.settings_tabPage.Controls.Add(this.overlapSize_numericUpDown);
            this.settings_tabPage.Controls.Add(this.label5);
            this.settings_tabPage.Controls.Add(this.maxTileResolution_numericUpDown);
            this.settings_tabPage.Controls.Add(this.label4);
            this.settings_tabPage.Controls.Add(this.imgPath_textBox);
            this.settings_tabPage.Controls.Add(this.label3);
            this.settings_tabPage.Controls.Add(this.label1);
            this.settings_tabPage.Controls.Add(this.esrganPath_textBox);
            this.settings_tabPage.Controls.Add(this.resultsMergedPath_textBox);
            this.settings_tabPage.Location = new System.Drawing.Point(4, 25);
            this.settings_tabPage.Name = "settings_tabPage";
            this.settings_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settings_tabPage.Size = new System.Drawing.Size(1263, 714);
            this.settings_tabPage.TabIndex = 1;
            this.settings_tabPage.Text = "Settings";
            this.settings_tabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.topMost_checkBox);
            this.groupBox8.Controls.Add(this.showPopups_checkBox);
            this.groupBox8.Location = new System.Drawing.Point(670, 283);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(158, 70);
            this.groupBox8.TabIndex = 54;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "UI";
            // 
            // topMost_checkBox
            // 
            this.topMost_checkBox.AutoSize = true;
            this.topMost_checkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.topMost_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.topMost_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topMost_checkBox.Location = new System.Drawing.Point(6, 24);
            this.topMost_checkBox.Name = "topMost_checkBox";
            this.topMost_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.topMost_checkBox.Size = new System.Drawing.Size(78, 17);
            this.topMost_checkBox.TabIndex = 38;
            this.topMost_checkBox.Text = "Stay on top";
            this.topMost_checkBox.UseVisualStyleBackColor = true;
            // 
            // showPopups_checkBox
            // 
            this.showPopups_checkBox.AutoSize = true;
            this.showPopups_checkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.showPopups_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showPopups_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPopups_checkBox.Location = new System.Drawing.Point(6, 47);
            this.showPopups_checkBox.Name = "showPopups_checkBox";
            this.showPopups_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showPopups_checkBox.Size = new System.Drawing.Size(143, 17);
            this.showPopups_checkBox.TabIndex = 38;
            this.showPopups_checkBox.Text = "Show popup notifications";
            this.showPopups_checkBox.UseVisualStyleBackColor = true;
            // 
            // deleteProfile_button
            // 
            this.deleteProfile_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteProfile_button.Location = new System.Drawing.Point(834, 655);
            this.deleteProfile_button.Name = "deleteProfile_button";
            this.deleteProfile_button.Size = new System.Drawing.Size(149, 31);
            this.deleteProfile_button.TabIndex = 53;
            this.deleteProfile_button.Text = "Delete profile";
            this.deleteProfile_button.UseVisualStyleBackColor = true;
            this.deleteProfile_button.Click += new System.EventHandler(this.DeleteProfile_button_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.ignoreAlpha_checkBox);
            this.groupBox9.Controls.Add(this.groupBox11);
            this.groupBox9.Controls.Add(this.imagePostprocess_groupBox);
            this.groupBox9.Controls.Add(this.imagePreprocess_groupBox);
            this.groupBox9.Controls.Add(this.outputFormat_comboBox);
            this.groupBox9.Controls.Add(this.ignoreSingleColorAlpha_checkBox);
            this.groupBox9.Controls.Add(this.balanceRgb_checkBox);
            this.groupBox9.Controls.Add(this.balanceAlphas_checkBox);
            this.groupBox9.Controls.Add(this.splitRGB_checkBox);
            this.groupBox9.Controls.Add(this.profileModel_comboBox);
            this.groupBox9.Controls.Add(this.useProfileModel_checkBox);
            this.groupBox9.Controls.Add(this.filterForAlpha_comboBox);
            this.groupBox9.Controls.Add(this.useFilterForAlpha_checkBox);
            this.groupBox9.Controls.Add(this.modelForAlpha_comboBox);
            this.groupBox9.Controls.Add(this.useDifferentModelForAlpha_checkBox);
            this.groupBox9.Controls.Add(this.seamlessTextures_checkBox);
            this.groupBox9.Controls.Add(this.preserveFormat_checkBox);
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Location = new System.Drawing.Point(94, 353);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(570, 333);
            this.groupBox9.TabIndex = 52;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Profile:Settings";
            // 
            // ignoreAlpha_checkBox
            // 
            this.ignoreAlpha_checkBox.AutoSize = true;
            this.ignoreAlpha_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ignoreAlpha_checkBox.Location = new System.Drawing.Point(319, 119);
            this.ignoreAlpha_checkBox.Name = "ignoreAlpha_checkBox";
            this.ignoreAlpha_checkBox.Size = new System.Drawing.Size(124, 17);
            this.ignoreAlpha_checkBox.TabIndex = 25;
            this.ignoreAlpha_checkBox.Text = "Ignore alpha channel";
            this.toolTip1.SetToolTip(this.ignoreAlpha_checkBox, "Don\'t create alpha tiles in LR, don\'t read alpha tiles from results");
            this.ignoreAlpha_checkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label34);
            this.groupBox11.Controls.Add(this.threshold_groupBox);
            this.groupBox11.Controls.Add(this.label35);
            this.groupBox11.Controls.Add(this.comboBox1);
            this.groupBox11.Controls.Add(this.comboBox2);
            this.groupBox11.Location = new System.Drawing.Point(298, 194);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(266, 126);
            this.groupBox11.TabIndex = 42;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Image postprocess";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(173, 28);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(16, 13);
            this.label34.TabIndex = 2;
            this.label34.Text = "to";
            // 
            // threshold_groupBox
            // 
            this.threshold_groupBox.Controls.Add(this.thresholdBlack_numericUpDown);
            this.threshold_groupBox.Controls.Add(this.label13);
            this.threshold_groupBox.Controls.Add(this.thresholdEnabled_checkBox);
            this.threshold_groupBox.Controls.Add(this.label12);
            this.threshold_groupBox.Controls.Add(this.thresholdWhite_numericUpDown);
            this.threshold_groupBox.Location = new System.Drawing.Point(9, 51);
            this.threshold_groupBox.Name = "threshold_groupBox";
            this.threshold_groupBox.Size = new System.Drawing.Size(247, 70);
            this.threshold_groupBox.TabIndex = 3;
            this.threshold_groupBox.TabStop = false;
            this.threshold_groupBox.Text = "Threshold";
            // 
            // thresholdBlack_numericUpDown
            // 
            this.thresholdBlack_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thresholdBlack_numericUpDown.Enabled = false;
            this.thresholdBlack_numericUpDown.Location = new System.Drawing.Point(63, 16);
            this.thresholdBlack_numericUpDown.Name = "thresholdBlack_numericUpDown";
            this.thresholdBlack_numericUpDown.Size = new System.Drawing.Size(45, 20);
            this.thresholdBlack_numericUpDown.TabIndex = 1;
            this.toolTip1.SetToolTip(this.thresholdBlack_numericUpDown, "Make all pixels darker than percentage true black");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(109, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "% White";
            // 
            // thresholdEnabled_checkBox
            // 
            this.thresholdEnabled_checkBox.AutoSize = true;
            this.thresholdEnabled_checkBox.Location = new System.Drawing.Point(12, 31);
            this.thresholdEnabled_checkBox.Name = "thresholdEnabled_checkBox";
            this.thresholdEnabled_checkBox.Size = new System.Drawing.Size(45, 17);
            this.thresholdEnabled_checkBox.TabIndex = 0;
            this.thresholdEnabled_checkBox.Text = "Use";
            this.thresholdEnabled_checkBox.UseVisualStyleBackColor = true;
            this.thresholdEnabled_checkBox.CheckedChanged += new System.EventHandler(this.thresholdEnabled_checkBox_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(109, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "% Black";
            // 
            // thresholdWhite_numericUpDown
            // 
            this.thresholdWhite_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thresholdWhite_numericUpDown.Enabled = false;
            this.thresholdWhite_numericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.thresholdWhite_numericUpDown.Location = new System.Drawing.Point(63, 42);
            this.thresholdWhite_numericUpDown.Name = "thresholdWhite_numericUpDown";
            this.thresholdWhite_numericUpDown.Size = new System.Drawing.Size(45, 20);
            this.thresholdWhite_numericUpDown.TabIndex = 1;
            this.toolTip1.SetToolTip(this.thresholdWhite_numericUpDown, "Make all pixels brighter than percentage true white");
            this.thresholdWhite_numericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(9, 27);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(61, 13);
            this.label35.TabIndex = 2;
            this.label35.Text = "Resize with";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(196, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(60, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // imagePostprocess_groupBox
            // 
            this.imagePostprocess_groupBox.Controls.Add(this.label22);
            this.imagePostprocess_groupBox.Controls.Add(this.label21);
            this.imagePostprocess_groupBox.Controls.Add(this.resizeImageAfterFilterType_comboBox);
            this.imagePostprocess_groupBox.Controls.Add(this.resizeImageAfterScaleFactor_comboBox);
            this.imagePostprocess_groupBox.Location = new System.Drawing.Point(298, 194);
            this.imagePostprocess_groupBox.Name = "imagePostprocess_groupBox";
            this.imagePostprocess_groupBox.Size = new System.Drawing.Size(261, 126);
            this.imagePostprocess_groupBox.TabIndex = 42;
            this.imagePostprocess_groupBox.TabStop = false;
            this.imagePostprocess_groupBox.Text = "Image postprocess";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(173, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "to";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Resize with";
            // 
            // resizeImageAfterFilterType_comboBox
            // 
            this.resizeImageAfterFilterType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resizeImageAfterFilterType_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resizeImageAfterFilterType_comboBox.FormattingEnabled = true;
            this.resizeImageAfterFilterType_comboBox.Location = new System.Drawing.Point(75, 21);
            this.resizeImageAfterFilterType_comboBox.Name = "resizeImageAfterFilterType_comboBox";
            this.resizeImageAfterFilterType_comboBox.Size = new System.Drawing.Size(95, 21);
            this.resizeImageAfterFilterType_comboBox.TabIndex = 0;
            // 
            // resizeImageAfterScaleFactor_comboBox
            // 
            this.resizeImageAfterScaleFactor_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resizeImageAfterScaleFactor_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resizeImageAfterScaleFactor_comboBox.FormattingEnabled = true;
            this.resizeImageAfterScaleFactor_comboBox.Location = new System.Drawing.Point(196, 21);
            this.resizeImageAfterScaleFactor_comboBox.Name = "resizeImageAfterScaleFactor_comboBox";
            this.resizeImageAfterScaleFactor_comboBox.Size = new System.Drawing.Size(60, 21);
            this.resizeImageAfterScaleFactor_comboBox.TabIndex = 0;
            // 
            // imagePreprocess_groupBox
            // 
            this.imagePreprocess_groupBox.Controls.Add(this.label20);
            this.imagePreprocess_groupBox.Controls.Add(this.label19);
            this.imagePreprocess_groupBox.Controls.Add(this.label14);
            this.imagePreprocess_groupBox.Controls.Add(this.resizeImageBeforeScaleFactor_comboBox);
            this.imagePreprocess_groupBox.Controls.Add(this.resizeImageBeforeFilterType_comboBox);
            this.imagePreprocess_groupBox.Controls.Add(this.noiseReductionType_comboBox);
            this.imagePreprocess_groupBox.Location = new System.Drawing.Point(18, 194);
            this.imagePreprocess_groupBox.Name = "imagePreprocess_groupBox";
            this.imagePreprocess_groupBox.Size = new System.Drawing.Size(274, 126);
            this.imagePreprocess_groupBox.TabIndex = 41;
            this.imagePreprocess_groupBox.TabStop = false;
            this.imagePreprocess_groupBox.Text = "Image preprocess";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(188, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "to";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Resize with";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Reduce noise";
            // 
            // resizeImageBeforeScaleFactor_comboBox
            // 
            this.resizeImageBeforeScaleFactor_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resizeImageBeforeScaleFactor_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resizeImageBeforeScaleFactor_comboBox.FormattingEnabled = true;
            this.resizeImageBeforeScaleFactor_comboBox.Location = new System.Drawing.Point(207, 24);
            this.resizeImageBeforeScaleFactor_comboBox.Name = "resizeImageBeforeScaleFactor_comboBox";
            this.resizeImageBeforeScaleFactor_comboBox.Size = new System.Drawing.Size(60, 21);
            this.resizeImageBeforeScaleFactor_comboBox.TabIndex = 0;
            // 
            // resizeImageBeforeFilterType_comboBox
            // 
            this.resizeImageBeforeFilterType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resizeImageBeforeFilterType_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resizeImageBeforeFilterType_comboBox.FormattingEnabled = true;
            this.resizeImageBeforeFilterType_comboBox.Location = new System.Drawing.Point(87, 24);
            this.resizeImageBeforeFilterType_comboBox.Name = "resizeImageBeforeFilterType_comboBox";
            this.resizeImageBeforeFilterType_comboBox.Size = new System.Drawing.Size(95, 21);
            this.resizeImageBeforeFilterType_comboBox.TabIndex = 0;
            // 
            // noiseReductionType_comboBox
            // 
            this.noiseReductionType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.noiseReductionType_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.noiseReductionType_comboBox.FormattingEnabled = true;
            this.noiseReductionType_comboBox.Location = new System.Drawing.Point(87, 54);
            this.noiseReductionType_comboBox.Name = "noiseReductionType_comboBox";
            this.noiseReductionType_comboBox.Size = new System.Drawing.Size(95, 21);
            this.noiseReductionType_comboBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.noiseReductionType_comboBox, "Try to remove image noise with specific ImageMagick method");
            // 
            // outputFormat_comboBox
            // 
            this.outputFormat_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.outputFormat_comboBox.FormattingEnabled = true;
            this.outputFormat_comboBox.Location = new System.Drawing.Point(101, 26);
            this.outputFormat_comboBox.Name = "outputFormat_comboBox";
            this.outputFormat_comboBox.Size = new System.Drawing.Size(120, 21);
            this.outputFormat_comboBox.TabIndex = 48;
            // 
            // ignoreSingleColorAlpha_checkBox
            // 
            this.ignoreSingleColorAlpha_checkBox.AutoSize = true;
            this.ignoreSingleColorAlpha_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ignoreSingleColorAlpha_checkBox.Location = new System.Drawing.Point(319, 140);
            this.ignoreSingleColorAlpha_checkBox.Name = "ignoreSingleColorAlpha_checkBox";
            this.ignoreSingleColorAlpha_checkBox.Size = new System.Drawing.Size(135, 17);
            this.ignoreSingleColorAlpha_checkBox.TabIndex = 25;
            this.ignoreSingleColorAlpha_checkBox.Text = "Ignore solid white alpha";
            this.toolTip1.SetToolTip(this.ignoreSingleColorAlpha_checkBox, "Solid white alpha will be always ignored on split");
            this.ignoreSingleColorAlpha_checkBox.UseVisualStyleBackColor = true;
            // 
            // balanceRgb_checkBox
            // 
            this.balanceRgb_checkBox.AutoSize = true;
            this.balanceRgb_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.balanceRgb_checkBox.Location = new System.Drawing.Point(403, 20);
            this.balanceRgb_checkBox.Name = "balanceRgb_checkBox";
            this.balanceRgb_checkBox.Size = new System.Drawing.Size(153, 17);
            this.balanceRgb_checkBox.TabIndex = 25;
            this.balanceRgb_checkBox.Text = "Use globalbalance on RGB";
            this.toolTip1.SetToolTip(this.balanceRgb_checkBox, "No need to enable this for most cases");
            this.balanceRgb_checkBox.UseVisualStyleBackColor = true;
            // 
            // balanceAlphas_checkBox
            // 
            this.balanceAlphas_checkBox.AutoSize = true;
            this.balanceAlphas_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.balanceAlphas_checkBox.Location = new System.Drawing.Point(403, 39);
            this.balanceAlphas_checkBox.Name = "balanceAlphas_checkBox";
            this.balanceAlphas_checkBox.Size = new System.Drawing.Size(156, 17);
            this.balanceAlphas_checkBox.TabIndex = 25;
            this.balanceAlphas_checkBox.Text = "Use globalbalance on alpha";
            this.toolTip1.SetToolTip(this.balanceAlphas_checkBox, "No need to enable this for most cases");
            this.balanceAlphas_checkBox.UseVisualStyleBackColor = true;
            // 
            // splitRGB_checkBox
            // 
            this.splitRGB_checkBox.AutoSize = true;
            this.splitRGB_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.splitRGB_checkBox.Location = new System.Drawing.Point(17, 140);
            this.splitRGB_checkBox.Name = "splitRGB_checkBox";
            this.splitRGB_checkBox.Size = new System.Drawing.Size(116, 17);
            this.splitRGB_checkBox.TabIndex = 25;
            this.splitRGB_checkBox.Text = "Split RGB channels";
            this.splitRGB_checkBox.UseVisualStyleBackColor = true;
            // 
            // profileModel_comboBox
            // 
            this.profileModel_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.profileModel_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.profileModel_comboBox.Enabled = false;
            this.profileModel_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.profileModel_comboBox.FormattingEnabled = true;
            this.profileModel_comboBox.Location = new System.Drawing.Point(182, 61);
            this.profileModel_comboBox.Name = "profileModel_comboBox";
            this.profileModel_comboBox.Size = new System.Drawing.Size(382, 21);
            this.profileModel_comboBox.TabIndex = 47;
            // 
            // useProfileModel_checkBox
            // 
            this.useProfileModel_checkBox.AutoSize = true;
            this.useProfileModel_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.useProfileModel_checkBox.Location = new System.Drawing.Point(17, 62);
            this.useProfileModel_checkBox.Name = "useProfileModel_checkBox";
            this.useProfileModel_checkBox.Size = new System.Drawing.Size(113, 17);
            this.useProfileModel_checkBox.TabIndex = 25;
            this.useProfileModel_checkBox.Text = "Use specific model";
            this.useProfileModel_checkBox.UseVisualStyleBackColor = true;
            this.useProfileModel_checkBox.CheckedChanged += new System.EventHandler(this.UseProfileModel_checkBox_CheckedChanged);
            // 
            // filterForAlpha_comboBox
            // 
            this.filterForAlpha_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.filterForAlpha_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filterForAlpha_comboBox.Enabled = false;
            this.filterForAlpha_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filterForAlpha_comboBox.FormattingEnabled = true;
            this.filterForAlpha_comboBox.Location = new System.Drawing.Point(182, 115);
            this.filterForAlpha_comboBox.Name = "filterForAlpha_comboBox";
            this.filterForAlpha_comboBox.Size = new System.Drawing.Size(121, 21);
            this.filterForAlpha_comboBox.TabIndex = 47;
            // 
            // useFilterForAlpha_checkBox
            // 
            this.useFilterForAlpha_checkBox.AutoSize = true;
            this.useFilterForAlpha_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.useFilterForAlpha_checkBox.Location = new System.Drawing.Point(17, 117);
            this.useFilterForAlpha_checkBox.Name = "useFilterForAlpha_checkBox";
            this.useFilterForAlpha_checkBox.Size = new System.Drawing.Size(109, 17);
            this.useFilterForAlpha_checkBox.TabIndex = 25;
            this.useFilterForAlpha_checkBox.Text = "Use filter for alpha";
            this.useFilterForAlpha_checkBox.UseVisualStyleBackColor = true;
            this.useFilterForAlpha_checkBox.CheckedChanged += new System.EventHandler(this.useFilterForAlpha_checkBox_CheckedChanged);
            // 
            // modelForAlpha_comboBox
            // 
            this.modelForAlpha_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.modelForAlpha_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.modelForAlpha_comboBox.Enabled = false;
            this.modelForAlpha_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modelForAlpha_comboBox.FormattingEnabled = true;
            this.modelForAlpha_comboBox.Location = new System.Drawing.Point(182, 88);
            this.modelForAlpha_comboBox.Name = "modelForAlpha_comboBox";
            this.modelForAlpha_comboBox.Size = new System.Drawing.Size(382, 21);
            this.modelForAlpha_comboBox.TabIndex = 47;
            // 
            // useDifferentModelForAlpha_checkBox
            // 
            this.useDifferentModelForAlpha_checkBox.AutoSize = true;
            this.useDifferentModelForAlpha_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.useDifferentModelForAlpha_checkBox.Location = new System.Drawing.Point(17, 90);
            this.useDifferentModelForAlpha_checkBox.Name = "useDifferentModelForAlpha_checkBox";
            this.useDifferentModelForAlpha_checkBox.Size = new System.Drawing.Size(159, 17);
            this.useDifferentModelForAlpha_checkBox.TabIndex = 25;
            this.useDifferentModelForAlpha_checkBox.Text = "Use different model for alpha";
            this.toolTip1.SetToolTip(this.useDifferentModelForAlpha_checkBox, "Need to split images when changing this setting");
            this.useDifferentModelForAlpha_checkBox.UseVisualStyleBackColor = true;
            this.useDifferentModelForAlpha_checkBox.CheckedChanged += new System.EventHandler(this.useDifferentModelForAlpha_checkBox_CheckedChanged);
            // 
            // seamlessTextures_checkBox
            // 
            this.seamlessTextures_checkBox.AutoSize = true;
            this.seamlessTextures_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seamlessTextures_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.seamlessTextures_checkBox.Location = new System.Drawing.Point(17, 163);
            this.seamlessTextures_checkBox.Name = "seamlessTextures_checkBox";
            this.seamlessTextures_checkBox.Size = new System.Drawing.Size(137, 17);
            this.seamlessTextures_checkBox.TabIndex = 30;
            this.seamlessTextures_checkBox.Text = "Seamless (tiled) textures";
            this.toolTip1.SetToolTip(this.seamlessTextures_checkBox, "Use if original image is seamless texture");
            this.seamlessTextures_checkBox.UseVisualStyleBackColor = true;
            // 
            // preserveFormat_checkBox
            // 
            this.preserveFormat_checkBox.AutoSize = true;
            this.preserveFormat_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.preserveFormat_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.preserveFormat_checkBox.Location = new System.Drawing.Point(227, 29);
            this.preserveFormat_checkBox.Name = "preserveFormat_checkBox";
            this.preserveFormat_checkBox.Size = new System.Drawing.Size(142, 17);
            this.preserveFormat_checkBox.TabIndex = 30;
            this.preserveFormat_checkBox.Text = "Use original image format";
            this.toolTip1.SetToolTip(this.preserveFormat_checkBox, "Use original image extension with settings from [Output formats] tab");
            this.preserveFormat_checkBox.UseVisualStyleBackColor = true;
            this.preserveFormat_checkBox.CheckedChanged += new System.EventHandler(this.preserveFormat_checkBox_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(25, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "Output format";
            // 
            // condaEnvName_textBox
            // 
            this.condaEnvName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.condaEnvName_textBox.Enabled = false;
            this.condaEnvName_textBox.Location = new System.Drawing.Point(507, 332);
            this.condaEnvName_textBox.Name = "condaEnvName_textBox";
            this.condaEnvName_textBox.Size = new System.Drawing.Size(157, 20);
            this.condaEnvName_textBox.TabIndex = 52;
            // 
            // saveProfileName_textBox
            // 
            this.saveProfileName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveProfileName_textBox.Location = new System.Drawing.Point(834, 560);
            this.saveProfileName_textBox.Name = "saveProfileName_textBox";
            this.saveProfileName_textBox.Size = new System.Drawing.Size(149, 20);
            this.saveProfileName_textBox.TabIndex = 52;
            // 
            // useBasicSR_checkBox
            // 
            this.useBasicSR_checkBox.AutoSize = true;
            this.useBasicSR_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.useBasicSR_checkBox.Location = new System.Drawing.Point(111, 284);
            this.useBasicSR_checkBox.Name = "useBasicSR_checkBox";
            this.useBasicSR_checkBox.Size = new System.Drawing.Size(146, 17);
            this.useBasicSR_checkBox.TabIndex = 51;
            this.useBasicSR_checkBox.Text = "Use BasicSR architecture";
            this.useBasicSR_checkBox.UseVisualStyleBackColor = true;
            // 
            // modelsPath_textBox
            // 
            this.modelsPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelsPath_textBox.Location = new System.Drawing.Point(111, 151);
            this.modelsPath_textBox.Name = "modelsPath_textBox";
            this.modelsPath_textBox.ReadOnly = true;
            this.modelsPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.modelsPath_textBox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.modelsPath_textBox, "Folder with .pth files");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "LR";
            // 
            // saveProfile_button
            // 
            this.saveProfile_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveProfile_button.Location = new System.Drawing.Point(834, 586);
            this.saveProfile_button.Name = "saveProfile_button";
            this.saveProfile_button.Size = new System.Drawing.Size(149, 31);
            this.saveProfile_button.TabIndex = 50;
            this.saveProfile_button.Text = "Save profile";
            this.saveProfile_button.UseVisualStyleBackColor = true;
            this.saveProfile_button.Click += new System.EventHandler(this.SaveProfile_button_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.appCoreVersion_linkLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.appVersion_label, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkForUpdates_checkBox, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1019, 655);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(242, 57);
            this.tableLayoutPanel2.TabIndex = 46;
            // 
            // appCoreVersion_linkLabel
            // 
            this.appCoreVersion_linkLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.appCoreVersion_linkLabel, 2);
            this.appCoreVersion_linkLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.appCoreVersion_linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appCoreVersion_linkLabel.Location = new System.Drawing.Point(141, 3);
            this.appCoreVersion_linkLabel.Margin = new System.Windows.Forms.Padding(3);
            this.appCoreVersion_linkLabel.Name = "appCoreVersion_linkLabel";
            this.appCoreVersion_linkLabel.Size = new System.Drawing.Size(98, 14);
            this.appCoreVersion_linkLabel.TabIndex = 45;
            this.appCoreVersion_linkLabel.TabStop = true;
            this.appCoreVersion_linkLabel.Text = "Core v0.0.00.00";
            this.appCoreVersion_linkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.appCoreVersion_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // appVersion_label
            // 
            this.appVersion_label.AutoSize = true;
            this.appVersion_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.appVersion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appVersion_label.Location = new System.Drawing.Point(145, 20);
            this.appVersion_label.Name = "appVersion_label";
            this.appVersion_label.Size = new System.Drawing.Size(94, 37);
            this.appVersion_label.TabIndex = 45;
            this.appVersion_label.TabStop = true;
            this.appVersion_label.Text = "GUI v0.0.00.00";
            this.appVersion_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.appVersion_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // checkForUpdates_checkBox
            // 
            this.checkForUpdates_checkBox.AutoSize = true;
            this.checkForUpdates_checkBox.Checked = true;
            this.checkForUpdates_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkForUpdates_checkBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkForUpdates_checkBox.Location = new System.Drawing.Point(3, 23);
            this.checkForUpdates_checkBox.Name = "checkForUpdates_checkBox";
            this.checkForUpdates_checkBox.Size = new System.Drawing.Size(113, 31);
            this.checkForUpdates_checkBox.TabIndex = 39;
            this.checkForUpdates_checkBox.Text = "Check for updates";
            this.checkForUpdates_checkBox.UseVisualStyleBackColor = true;
            // 
            // profiles_listBox
            // 
            this.profiles_listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profiles_listBox.FormattingEnabled = true;
            this.profiles_listBox.Location = new System.Drawing.Point(670, 359);
            this.profiles_listBox.Name = "profiles_listBox";
            this.profiles_listBox.Size = new System.Drawing.Size(158, 327);
            this.profiles_listBox.TabIndex = 47;
            this.profiles_listBox.SelectedIndexChanged += new System.EventHandler(this.configs_listBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Results";
            // 
            // loadProfile_button
            // 
            this.loadProfile_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadProfile_button.Location = new System.Drawing.Point(834, 620);
            this.loadProfile_button.Name = "loadProfile_button";
            this.loadProfile_button.Size = new System.Drawing.Size(149, 31);
            this.loadProfile_button.TabIndex = 51;
            this.loadProfile_button.Text = "Load profile";
            this.loadProfile_button.UseVisualStyleBackColor = true;
            this.loadProfile_button.Click += new System.EventHandler(this.LoadProfile_button_Click);
            // 
            // useCondaEnv_checkBox
            // 
            this.useCondaEnv_checkBox.AutoSize = true;
            this.useCondaEnv_checkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.useCondaEnv_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.useCondaEnv_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.useCondaEnv_checkBox.Location = new System.Drawing.Point(370, 333);
            this.useCondaEnv_checkBox.Name = "useCondaEnv_checkBox";
            this.useCondaEnv_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.useCondaEnv_checkBox.Size = new System.Drawing.Size(131, 17);
            this.useCondaEnv_checkBox.TabIndex = 38;
            this.useCondaEnv_checkBox.Text = "Use conda enviroment";
            this.useCondaEnv_checkBox.UseVisualStyleBackColor = true;
            this.useCondaEnv_checkBox.CheckedChanged += new System.EventHandler(this.useCondaEnv_checkBox_CheckedChanged);
            // 
            // deleteResults_checkBox
            // 
            this.deleteResults_checkBox.AutoSize = true;
            this.deleteResults_checkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteResults_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteResults_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteResults_checkBox.Location = new System.Drawing.Point(111, 261);
            this.deleteResults_checkBox.Name = "deleteResults_checkBox";
            this.deleteResults_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteResults_checkBox.Size = new System.Drawing.Size(144, 17);
            this.deleteResults_checkBox.TabIndex = 38;
            this.deleteResults_checkBox.Text = "Delete results after merge";
            this.deleteResults_checkBox.UseVisualStyleBackColor = true;
            // 
            // outputPath_textBox
            // 
            this.outputPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputPath_textBox.Location = new System.Drawing.Point(111, 125);
            this.outputPath_textBox.Name = "outputPath_textBox";
            this.outputPath_textBox.ReadOnly = true;
            this.outputPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.outputPath_textBox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.outputPath_textBox, "ESRGAN output folder");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "X";
            // 
            // inputPath_textBox
            // 
            this.inputPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPath_textBox.Location = new System.Drawing.Point(111, 99);
            this.inputPath_textBox.Name = "inputPath_textBox";
            this.inputPath_textBox.ReadOnly = true;
            this.inputPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.inputPath_textBox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.inputPath_textBox, "ESRGAN input folder");
            // 
            // maxTileHeight_numericUpDown
            // 
            this.maxTileHeight_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxTileHeight_numericUpDown.Location = new System.Drawing.Point(321, 206);
            this.maxTileHeight_numericUpDown.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.maxTileHeight_numericUpDown.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.maxTileHeight_numericUpDown.Name = "maxTileHeight_numericUpDown";
            this.maxTileHeight_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.maxTileHeight_numericUpDown.TabIndex = 32;
            this.maxTileHeight_numericUpDown.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // changeModelsPath_button
            // 
            this.changeModelsPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeModelsPath_button.Location = new System.Drawing.Point(618, 150);
            this.changeModelsPath_button.Name = "changeModelsPath_button";
            this.changeModelsPath_button.Size = new System.Drawing.Size(46, 20);
            this.changeModelsPath_button.TabIndex = 29;
            this.changeModelsPath_button.Text = "...";
            this.changeModelsPath_button.UseVisualStyleBackColor = true;
            this.changeModelsPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // maxTileWidth_numericUpDown
            // 
            this.maxTileWidth_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxTileWidth_numericUpDown.Location = new System.Drawing.Point(237, 206);
            this.maxTileWidth_numericUpDown.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.maxTileWidth_numericUpDown.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.maxTileWidth_numericUpDown.Name = "maxTileWidth_numericUpDown";
            this.maxTileWidth_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.maxTileWidth_numericUpDown.TabIndex = 32;
            this.maxTileWidth_numericUpDown.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // advancedUseSuffix_checkBox
            // 
            this.advancedUseSuffix_checkBox.AutoSize = true;
            this.advancedUseSuffix_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advancedUseSuffix_checkBox.Location = new System.Drawing.Point(323, 179);
            this.advancedUseSuffix_checkBox.Name = "advancedUseSuffix_checkBox";
            this.advancedUseSuffix_checkBox.Size = new System.Drawing.Size(117, 17);
            this.advancedUseSuffix_checkBox.TabIndex = 0;
            this.advancedUseSuffix_checkBox.Text = "Use suffix for results";
            this.advancedUseSuffix_checkBox.UseVisualStyleBackColor = true;
            this.advancedUseSuffix_checkBox.CheckedChanged += new System.EventHandler(this.advancedUseSuffix_checkBox_CheckedChanged);
            // 
            // createMemoryImage_checkBox
            // 
            this.createMemoryImage_checkBox.AutoSize = true;
            this.createMemoryImage_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createMemoryImage_checkBox.Location = new System.Drawing.Point(111, 307);
            this.createMemoryImage_checkBox.Name = "createMemoryImage_checkBox";
            this.createMemoryImage_checkBox.Size = new System.Drawing.Size(169, 17);
            this.createMemoryImage_checkBox.TabIndex = 31;
            this.createMemoryImage_checkBox.Text = "Create max resolution tile in LR";
            this.toolTip1.SetToolTip(this.createMemoryImage_checkBox, " Helps with ESRGAN memory allocation, when you have images with different dimensi" +
        "ons in LR");
            this.createMemoryImage_checkBox.UseVisualStyleBackColor = true;
            // 
            // changeInputPath_button
            // 
            this.changeInputPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeInputPath_button.Location = new System.Drawing.Point(618, 98);
            this.changeInputPath_button.Name = "changeInputPath_button";
            this.changeInputPath_button.Size = new System.Drawing.Size(46, 20);
            this.changeInputPath_button.TabIndex = 29;
            this.changeInputPath_button.Text = "...";
            this.changeInputPath_button.UseVisualStyleBackColor = true;
            this.changeInputPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // useCPU_checkBox
            // 
            this.useCPU_checkBox.AutoSize = true;
            this.useCPU_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.useCPU_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.useCPU_checkBox.Location = new System.Drawing.Point(111, 330);
            this.useCPU_checkBox.Name = "useCPU_checkBox";
            this.useCPU_checkBox.Size = new System.Drawing.Size(68, 17);
            this.useCPU_checkBox.TabIndex = 30;
            this.useCPU_checkBox.Text = "Use CPU";
            this.toolTip1.SetToolTip(this.useCPU_checkBox, "Use CPU instead of GPU (very slow)");
            this.useCPU_checkBox.UseVisualStyleBackColor = true;
            // 
            // changeOutputPath_button
            // 
            this.changeOutputPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeOutputPath_button.Location = new System.Drawing.Point(618, 124);
            this.changeOutputPath_button.Name = "changeOutputPath_button";
            this.changeOutputPath_button.Size = new System.Drawing.Size(46, 20);
            this.changeOutputPath_button.TabIndex = 29;
            this.changeOutputPath_button.Text = "...";
            this.changeOutputPath_button.UseVisualStyleBackColor = true;
            this.changeOutputPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // advancedSuffix_textBox
            // 
            this.advancedSuffix_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.advancedSuffix_textBox.Location = new System.Drawing.Point(442, 177);
            this.advancedSuffix_textBox.Name = "advancedSuffix_textBox";
            this.advancedSuffix_textBox.ReadOnly = true;
            this.advancedSuffix_textBox.Size = new System.Drawing.Size(171, 20);
            this.advancedSuffix_textBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Models";
            // 
            // changeInputImgPath_button
            // 
            this.changeInputImgPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeInputImgPath_button.Location = new System.Drawing.Point(618, 45);
            this.changeInputImgPath_button.Name = "changeInputImgPath_button";
            this.changeInputImgPath_button.Size = new System.Drawing.Size(46, 20);
            this.changeInputImgPath_button.TabIndex = 29;
            this.changeInputImgPath_button.Text = "...";
            this.changeInputImgPath_button.UseVisualStyleBackColor = true;
            this.changeInputImgPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // changeMergedResultsPath_button
            // 
            this.changeMergedResultsPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeMergedResultsPath_button.Location = new System.Drawing.Point(618, 72);
            this.changeMergedResultsPath_button.Name = "changeMergedResultsPath_button";
            this.changeMergedResultsPath_button.Size = new System.Drawing.Size(46, 20);
            this.changeMergedResultsPath_button.TabIndex = 29;
            this.changeMergedResultsPath_button.Text = "...";
            this.changeMergedResultsPath_button.UseVisualStyleBackColor = true;
            this.changeMergedResultsPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // changeEsrganPath_button
            // 
            this.changeEsrganPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeEsrganPath_button.Location = new System.Drawing.Point(618, 19);
            this.changeEsrganPath_button.Name = "changeEsrganPath_button";
            this.changeEsrganPath_button.Size = new System.Drawing.Size(46, 20);
            this.changeEsrganPath_button.TabIndex = 29;
            this.changeEsrganPath_button.Text = "...";
            this.changeEsrganPath_button.UseVisualStyleBackColor = true;
            this.changeEsrganPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // preciseTile_checkBox
            // 
            this.preciseTile_checkBox.AutoSize = true;
            this.preciseTile_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.preciseTile_checkBox.Location = new System.Drawing.Point(396, 209);
            this.preciseTile_checkBox.Name = "preciseTile_checkBox";
            this.preciseTile_checkBox.Size = new System.Drawing.Size(130, 17);
            this.preciseTile_checkBox.TabIndex = 25;
            this.preciseTile_checkBox.Text = "Precise tile dimensions";
            this.toolTip1.SetToolTip(this.preciseTile_checkBox, "Usefull when you need to create tiles for training");
            this.preciseTile_checkBox.UseVisualStyleBackColor = true;
            this.preciseTile_checkBox.CheckedChanged += new System.EventHandler(this.preciseTile_checkBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tiles overlap";
            // 
            // overlapSize_numericUpDown
            // 
            this.overlapSize_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overlapSize_numericUpDown.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.overlapSize_numericUpDown.Location = new System.Drawing.Point(111, 232);
            this.overlapSize_numericUpDown.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.overlapSize_numericUpDown.Name = "overlapSize_numericUpDown";
            this.overlapSize_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.overlapSize_numericUpDown.TabIndex = 23;
            this.overlapSize_numericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Max tile WxH";
            // 
            // maxTileResolution_numericUpDown
            // 
            this.maxTileResolution_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxTileResolution_numericUpDown.Enabled = false;
            this.maxTileResolution_numericUpDown.Location = new System.Drawing.Point(111, 206);
            this.maxTileResolution_numericUpDown.Maximum = new decimal(new int[] {
            16777216,
            0,
            0,
            0});
            this.maxTileResolution_numericUpDown.Name = "maxTileResolution_numericUpDown";
            this.maxTileResolution_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.maxTileResolution_numericUpDown.TabIndex = 21;
            this.maxTileResolution_numericUpDown.ThousandsSeparator = true;
            this.maxTileResolution_numericUpDown.Value = new decimal(new int[] {
            204800,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "IEU input";
            // 
            // imgPath_textBox
            // 
            this.imgPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPath_textBox.Location = new System.Drawing.Point(111, 45);
            this.imgPath_textBox.Name = "imgPath_textBox";
            this.imgPath_textBox.ReadOnly = true;
            this.imgPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.imgPath_textBox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.imgPath_textBox, "IEU input folder");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "IEU output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ESRGAN/BasicSR";
            // 
            // settingsOutputFormat_tabPage
            // 
            this.settingsOutputFormat_tabPage.Controls.Add(this.textBox1);
            this.settingsOutputFormat_tabPage.Controls.Add(this.textBox2);
            this.settingsOutputFormat_tabPage.Controls.Add(this.button2);
            this.settingsOutputFormat_tabPage.Controls.Add(this.label32);
            this.settingsOutputFormat_tabPage.Controls.Add(this.label33);
            this.settingsOutputFormat_tabPage.Controls.Add(this.button3);
            this.settingsOutputFormat_tabPage.Controls.Add(this.groupBox2);
            this.settingsOutputFormat_tabPage.Controls.Add(this.groupBox3);
            this.settingsOutputFormat_tabPage.Controls.Add(this.tiffSetting_groupBox);
            this.settingsOutputFormat_tabPage.Controls.Add(this.ddsOutputSettings_groupBox);
            this.settingsOutputFormat_tabPage.Location = new System.Drawing.Point(4, 25);
            this.settingsOutputFormat_tabPage.Name = "settingsOutputFormat_tabPage";
            this.settingsOutputFormat_tabPage.Size = new System.Drawing.Size(1263, 714);
            this.settingsOutputFormat_tabPage.TabIndex = 4;
            this.settingsOutputFormat_tabPage.Text = "Output formats";
            this.settingsOutputFormat_tabPage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(75, 409);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(553, 20);
            this.textBox1.TabIndex = 47;
            this.toolTip1.SetToolTip(this.textBox1, "ESRGAN root folder");
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(75, 435);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(553, 20);
            this.textBox2.TabIndex = 48;
            this.toolTip1.SetToolTip(this.textBox2, "IEU output folder");
            this.textBox2.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(634, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 20);
            this.button2.TabIndex = 51;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(31, 413);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(42, 13);
            this.label32.TabIndex = 49;
            this.label32.Text = "Original";
            this.label32.Visible = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(36, 437);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(37, 13);
            this.label33.TabIndex = 50;
            this.label33.Text = "Result";
            this.label33.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(634, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 20);
            this.button3.TabIndex = 52;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webpLossless_checkBox);
            this.groupBox2.Controls.Add(this.webpQuality_numericUpDown);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.webpPreset_comboBox);
            this.groupBox2.Location = new System.Drawing.Point(8, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 107);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WEBP";
            // 
            // webpLossless_checkBox
            // 
            this.webpLossless_checkBox.AutoSize = true;
            this.webpLossless_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.webpLossless_checkBox.Location = new System.Drawing.Point(9, 24);
            this.webpLossless_checkBox.Name = "webpLossless_checkBox";
            this.webpLossless_checkBox.Size = new System.Drawing.Size(64, 17);
            this.webpLossless_checkBox.TabIndex = 47;
            this.webpLossless_checkBox.Text = "Lossless";
            this.webpLossless_checkBox.UseVisualStyleBackColor = true;
            this.webpLossless_checkBox.CheckedChanged += new System.EventHandler(this.webpLossless_checkBox_CheckedChanged);
            // 
            // webpQuality_numericUpDown
            // 
            this.webpQuality_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.webpQuality_numericUpDown.Location = new System.Drawing.Point(111, 73);
            this.webpQuality_numericUpDown.Name = "webpQuality_numericUpDown";
            this.webpQuality_numericUpDown.Size = new System.Drawing.Size(48, 20);
            this.webpQuality_numericUpDown.TabIndex = 46;
            this.webpQuality_numericUpDown.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(64, 75);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Quality";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(4, 47);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(99, 13);
            this.label27.TabIndex = 2;
            this.label27.Text = "Compression preset";
            // 
            // webpPreset_comboBox
            // 
            this.webpPreset_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.webpPreset_comboBox.FormattingEnabled = true;
            this.webpPreset_comboBox.Location = new System.Drawing.Point(111, 44);
            this.webpPreset_comboBox.Name = "webpPreset_comboBox";
            this.webpPreset_comboBox.Size = new System.Drawing.Size(96, 21);
            this.webpPreset_comboBox.TabIndex = 45;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pngCompression_numericUpDown);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(8, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 52);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PNG";
            // 
            // pngCompression_numericUpDown
            // 
            this.pngCompression_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pngCompression_numericUpDown.Location = new System.Drawing.Point(111, 19);
            this.pngCompression_numericUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.pngCompression_numericUpDown.Name = "pngCompression_numericUpDown";
            this.pngCompression_numericUpDown.Size = new System.Drawing.Size(48, 20);
            this.pngCompression_numericUpDown.TabIndex = 44;
            this.toolTip1.SetToolTip(this.pngCompression_numericUpDown, "0 - no compression, 9 - max compression");
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "Compression factor";
            this.toolTip1.SetToolTip(this.label18, "0 - no compression, 9 - max compression");
            // 
            // tiffSetting_groupBox
            // 
            this.tiffSetting_groupBox.Controls.Add(this.tiffJpegQuality_numericUpDown);
            this.tiffSetting_groupBox.Controls.Add(this.label25);
            this.tiffSetting_groupBox.Controls.Add(this.label24);
            this.tiffSetting_groupBox.Controls.Add(this.tiffSettings_comboBox);
            this.tiffSetting_groupBox.Location = new System.Drawing.Point(8, 17);
            this.tiffSetting_groupBox.Name = "tiffSetting_groupBox";
            this.tiffSetting_groupBox.Size = new System.Drawing.Size(225, 73);
            this.tiffSetting_groupBox.TabIndex = 46;
            this.tiffSetting_groupBox.TabStop = false;
            this.tiffSetting_groupBox.Text = "TIFF";
            // 
            // tiffJpegQuality_numericUpDown
            // 
            this.tiffJpegQuality_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tiffJpegQuality_numericUpDown.Location = new System.Drawing.Point(112, 44);
            this.tiffJpegQuality_numericUpDown.Name = "tiffJpegQuality_numericUpDown";
            this.tiffJpegQuality_numericUpDown.Size = new System.Drawing.Size(48, 20);
            this.tiffJpegQuality_numericUpDown.TabIndex = 46;
            this.tiffJpegQuality_numericUpDown.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(40, 46);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "Jpeg quality";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Compresion method";
            // 
            // tiffSettings_comboBox
            // 
            this.tiffSettings_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tiffSettings_comboBox.FormattingEnabled = true;
            this.tiffSettings_comboBox.Location = new System.Drawing.Point(112, 15);
            this.tiffSettings_comboBox.Name = "tiffSettings_comboBox";
            this.tiffSettings_comboBox.Size = new System.Drawing.Size(96, 21);
            this.tiffSettings_comboBox.TabIndex = 45;
            // 
            // ddsOutputSettings_groupBox
            // 
            this.ddsOutputSettings_groupBox.Controls.Add(this.label17);
            this.ddsOutputSettings_groupBox.Controls.Add(this.label16);
            this.ddsOutputSettings_groupBox.Controls.Add(this.label15);
            this.ddsOutputSettings_groupBox.Controls.Add(this.ddsGenerateMipmaps_checkBox);
            this.ddsOutputSettings_groupBox.Controls.Add(this.ddsCompresion_comboBox);
            this.ddsOutputSettings_groupBox.Controls.Add(this.ddsFileFormat_comboBox);
            this.ddsOutputSettings_groupBox.Controls.Add(this.ddsTextureType_comboBox);
            this.ddsOutputSettings_groupBox.Location = new System.Drawing.Point(368, 17);
            this.ddsOutputSettings_groupBox.Name = "ddsOutputSettings_groupBox";
            this.ddsOutputSettings_groupBox.Size = new System.Drawing.Size(344, 139);
            this.ddsOutputSettings_groupBox.TabIndex = 42;
            this.ddsOutputSettings_groupBox.TabStop = false;
            this.ddsOutputSettings_groupBox.Text = "DDS output settings";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "BC7 Compression";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Compression";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Texture type";
            // 
            // ddsGenerateMipmaps_checkBox
            // 
            this.ddsGenerateMipmaps_checkBox.AutoSize = true;
            this.ddsGenerateMipmaps_checkBox.Checked = true;
            this.ddsGenerateMipmaps_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ddsGenerateMipmaps_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddsGenerateMipmaps_checkBox.Location = new System.Drawing.Point(104, 110);
            this.ddsGenerateMipmaps_checkBox.Name = "ddsGenerateMipmaps_checkBox";
            this.ddsGenerateMipmaps_checkBox.Size = new System.Drawing.Size(112, 17);
            this.ddsGenerateMipmaps_checkBox.TabIndex = 1;
            this.ddsGenerateMipmaps_checkBox.Text = "Generate mipmaps";
            this.ddsGenerateMipmaps_checkBox.UseVisualStyleBackColor = true;
            // 
            // ddsCompresion_comboBox
            // 
            this.ddsCompresion_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddsCompresion_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddsCompresion_comboBox.FormattingEnabled = true;
            this.ddsCompresion_comboBox.Location = new System.Drawing.Point(104, 83);
            this.ddsCompresion_comboBox.Name = "ddsCompresion_comboBox";
            this.ddsCompresion_comboBox.Size = new System.Drawing.Size(222, 21);
            this.ddsCompresion_comboBox.TabIndex = 0;
            // 
            // ddsFileFormat_comboBox
            // 
            this.ddsFileFormat_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddsFileFormat_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddsFileFormat_comboBox.FormattingEnabled = true;
            this.ddsFileFormat_comboBox.Location = new System.Drawing.Point(104, 56);
            this.ddsFileFormat_comboBox.Name = "ddsFileFormat_comboBox";
            this.ddsFileFormat_comboBox.Size = new System.Drawing.Size(222, 21);
            this.ddsFileFormat_comboBox.TabIndex = 0;
            // 
            // ddsTextureType_comboBox
            // 
            this.ddsTextureType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddsTextureType_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddsTextureType_comboBox.FormattingEnabled = true;
            this.ddsTextureType_comboBox.Location = new System.Drawing.Point(104, 28);
            this.ddsTextureType_comboBox.Name = "ddsTextureType_comboBox";
            this.ddsTextureType_comboBox.Size = new System.Drawing.Size(222, 21);
            this.ddsTextureType_comboBox.TabIndex = 0;
            // 
            // advanced_tabPage
            // 
            this.advanced_tabPage.Controls.Add(this.disableRuleSystem_checkBox);
            this.advanced_tabPage.Controls.Add(this.rules_groupBox);
            this.advanced_tabPage.Controls.Add(this.filters_groupBox);
            this.advanced_tabPage.Location = new System.Drawing.Point(4, 25);
            this.advanced_tabPage.Name = "advanced_tabPage";
            this.advanced_tabPage.Size = new System.Drawing.Size(1263, 714);
            this.advanced_tabPage.TabIndex = 2;
            this.advanced_tabPage.Text = "Filters/Rules";
            this.advanced_tabPage.UseVisualStyleBackColor = true;
            // 
            // disableRuleSystem_checkBox
            // 
            this.disableRuleSystem_checkBox.AutoSize = true;
            this.disableRuleSystem_checkBox.Location = new System.Drawing.Point(562, 494);
            this.disableRuleSystem_checkBox.Name = "disableRuleSystem_checkBox";
            this.disableRuleSystem_checkBox.Size = new System.Drawing.Size(123, 17);
            this.disableRuleSystem_checkBox.TabIndex = 41;
            this.disableRuleSystem_checkBox.Text = "Disable Rule System";
            this.disableRuleSystem_checkBox.UseVisualStyleBackColor = true;
            // 
            // rules_groupBox
            // 
            this.rules_groupBox.Controls.Add(this.rulePriority_numericUpDown);
            this.rules_groupBox.Controls.Add(this.deleteRule_button);
            this.rules_groupBox.Controls.Add(this.rules_listBox);
            this.rules_groupBox.Controls.Add(this.newRuleName_textBox);
            this.rules_groupBox.Controls.Add(this.ruleProfiles_comboBox);
            this.rules_groupBox.Controls.Add(this.ruleFilters_comboBox);
            this.rules_groupBox.Controls.Add(this.saveRuleFromCurrent_button);
            this.rules_groupBox.Controls.Add(this.saveRule_button);
            this.rules_groupBox.Controls.Add(this.loadRule_button);
            this.rules_groupBox.Location = new System.Drawing.Point(562, 3);
            this.rules_groupBox.Name = "rules_groupBox";
            this.rules_groupBox.Size = new System.Drawing.Size(200, 485);
            this.rules_groupBox.TabIndex = 40;
            this.rules_groupBox.TabStop = false;
            this.rules_groupBox.Text = "Rules";
            // 
            // rulePriority_numericUpDown
            // 
            this.rulePriority_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rulePriority_numericUpDown.Location = new System.Drawing.Point(134, 274);
            this.rulePriority_numericUpDown.Name = "rulePriority_numericUpDown";
            this.rulePriority_numericUpDown.ReadOnly = true;
            this.rulePriority_numericUpDown.Size = new System.Drawing.Size(47, 20);
            this.rulePriority_numericUpDown.TabIndex = 59;
            this.rulePriority_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.rulePriority_numericUpDown, "Rule priority. Rules with higher priority will be applied first.");
            this.rulePriority_numericUpDown.ValueChanged += new System.EventHandler(this.RulePriority_numericUpDown_ValueChanged);
            // 
            // deleteRule_button
            // 
            this.deleteRule_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteRule_button.Location = new System.Drawing.Point(20, 410);
            this.deleteRule_button.Name = "deleteRule_button";
            this.deleteRule_button.Size = new System.Drawing.Size(161, 31);
            this.deleteRule_button.TabIndex = 58;
            this.deleteRule_button.Text = "Delete rule";
            this.deleteRule_button.UseVisualStyleBackColor = true;
            this.deleteRule_button.Click += new System.EventHandler(this.DeleteRule_button_Click);
            // 
            // rules_listBox
            // 
            this.rules_listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rules_listBox.FormattingEnabled = true;
            this.rules_listBox.Location = new System.Drawing.Point(20, 25);
            this.rules_listBox.Name = "rules_listBox";
            this.rules_listBox.Size = new System.Drawing.Size(161, 184);
            this.rules_listBox.TabIndex = 1;
            this.rules_listBox.SelectedIndexChanged += new System.EventHandler(this.Rules_listBox_SelectedIndexChanged);
            // 
            // newRuleName_textBox
            // 
            this.newRuleName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newRuleName_textBox.Location = new System.Drawing.Point(20, 274);
            this.newRuleName_textBox.Name = "newRuleName_textBox";
            this.newRuleName_textBox.Size = new System.Drawing.Size(110, 20);
            this.newRuleName_textBox.TabIndex = 57;
            this.toolTip1.SetToolTip(this.newRuleName_textBox, "Rule name");
            this.newRuleName_textBox.TextChanged += new System.EventHandler(this.NewRuleName_textBox_TextChanged);
            // 
            // ruleProfiles_comboBox
            // 
            this.ruleProfiles_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ruleProfiles_comboBox.FormattingEnabled = true;
            this.ruleProfiles_comboBox.Location = new System.Drawing.Point(20, 242);
            this.ruleProfiles_comboBox.Name = "ruleProfiles_comboBox";
            this.ruleProfiles_comboBox.Size = new System.Drawing.Size(161, 21);
            this.ruleProfiles_comboBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.ruleProfiles_comboBox, "Profile for rule");
            // 
            // ruleFilters_comboBox
            // 
            this.ruleFilters_comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.ruleFilters_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ruleFilters_comboBox.FormattingEnabled = true;
            this.ruleFilters_comboBox.Location = new System.Drawing.Point(20, 216);
            this.ruleFilters_comboBox.Name = "ruleFilters_comboBox";
            this.ruleFilters_comboBox.Size = new System.Drawing.Size(161, 21);
            this.ruleFilters_comboBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.ruleFilters_comboBox, "Filter for rule");
            // 
            // saveRuleFromCurrent_button
            // 
            this.saveRuleFromCurrent_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveRuleFromCurrent_button.Location = new System.Drawing.Point(20, 339);
            this.saveRuleFromCurrent_button.Name = "saveRuleFromCurrent_button";
            this.saveRuleFromCurrent_button.Size = new System.Drawing.Size(161, 31);
            this.saveRuleFromCurrent_button.TabIndex = 55;
            this.saveRuleFromCurrent_button.Text = "Save from current filter/profile";
            this.saveRuleFromCurrent_button.UseVisualStyleBackColor = true;
            this.saveRuleFromCurrent_button.Click += new System.EventHandler(this.SaveRule_button_Click);
            // 
            // saveRule_button
            // 
            this.saveRule_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveRule_button.Location = new System.Drawing.Point(20, 303);
            this.saveRule_button.Name = "saveRule_button";
            this.saveRule_button.Size = new System.Drawing.Size(161, 31);
            this.saveRule_button.TabIndex = 55;
            this.saveRule_button.Text = "Save from selected filter/profile";
            this.saveRule_button.UseVisualStyleBackColor = true;
            this.saveRule_button.Click += new System.EventHandler(this.SaveRule_button_Click);
            // 
            // loadRule_button
            // 
            this.loadRule_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadRule_button.Location = new System.Drawing.Point(20, 375);
            this.loadRule_button.Name = "loadRule_button";
            this.loadRule_button.Size = new System.Drawing.Size(161, 31);
            this.loadRule_button.TabIndex = 56;
            this.loadRule_button.Text = "Load rule";
            this.loadRule_button.UseVisualStyleBackColor = true;
            this.loadRule_button.Click += new System.EventHandler(this.LoadRule_button_Click);
            // 
            // filters_groupBox
            // 
            this.filters_groupBox.Controls.Add(this.deleteFilter_button);
            this.filters_groupBox.Controls.Add(this.filterExtensions_checkedListBox);
            this.filters_groupBox.Controls.Add(this.newFilterName_textBox);
            this.filters_groupBox.Controls.Add(this.filtersSize_groupBox);
            this.filters_groupBox.Controls.Add(this.saveFilter_button);
            this.filters_groupBox.Controls.Add(this.groupBox10);
            this.filters_groupBox.Controls.Add(this.filtersFilename_groupBox);
            this.filters_groupBox.Controls.Add(this.loadFilter_button);
            this.filters_groupBox.Controls.Add(this.checkBox3);
            this.filters_groupBox.Controls.Add(this.filters_listBox);
            this.filters_groupBox.Controls.Add(this.filtersAlpha_groupBox);
            this.filters_groupBox.Location = new System.Drawing.Point(0, 3);
            this.filters_groupBox.Name = "filters_groupBox";
            this.filters_groupBox.Size = new System.Drawing.Size(537, 631);
            this.filters_groupBox.TabIndex = 32;
            this.filters_groupBox.TabStop = false;
            this.filters_groupBox.Text = "Filters";
            // 
            // deleteFilter_button
            // 
            this.deleteFilter_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteFilter_button.Location = new System.Drawing.Point(162, 583);
            this.deleteFilter_button.Name = "deleteFilter_button";
            this.deleteFilter_button.Size = new System.Drawing.Size(149, 31);
            this.deleteFilter_button.TabIndex = 58;
            this.deleteFilter_button.Text = "Delete filter";
            this.deleteFilter_button.UseVisualStyleBackColor = true;
            this.deleteFilter_button.Click += new System.EventHandler(this.DeleteFilter_button_Click);
            // 
            // filterExtensions_checkedListBox
            // 
            this.filterExtensions_checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterExtensions_checkedListBox.CheckOnClick = true;
            this.filterExtensions_checkedListBox.FormattingEnabled = true;
            this.filterExtensions_checkedListBox.Location = new System.Drawing.Point(388, 25);
            this.filterExtensions_checkedListBox.Name = "filterExtensions_checkedListBox";
            this.filterExtensions_checkedListBox.Size = new System.Drawing.Size(128, 182);
            this.filterExtensions_checkedListBox.TabIndex = 10;
            this.filterExtensions_checkedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.filterExtensions_checkedListBox_ItemCheck);
            // 
            // newFilterName_textBox
            // 
            this.newFilterName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newFilterName_textBox.Location = new System.Drawing.Point(165, 443);
            this.newFilterName_textBox.Name = "newFilterName_textBox";
            this.newFilterName_textBox.Size = new System.Drawing.Size(149, 20);
            this.newFilterName_textBox.TabIndex = 57;
            // 
            // filtersSize_groupBox
            // 
            this.filtersSize_groupBox.Controls.Add(this.filtersSizeOn_checkBox);
            this.filtersSize_groupBox.Controls.Add(this.filterSizeWidth_numericUpDown);
            this.filtersSize_groupBox.Controls.Add(this.filterSizeHeight_numericUpDown);
            this.filtersSize_groupBox.Controls.Add(this.label11);
            this.filtersSize_groupBox.Controls.Add(this.filterSizeOr_checkBox);
            this.filtersSize_groupBox.Controls.Add(this.label10);
            this.filtersSize_groupBox.Location = new System.Drawing.Point(140, 274);
            this.filtersSize_groupBox.Name = "filtersSize_groupBox";
            this.filtersSize_groupBox.Size = new System.Drawing.Size(242, 86);
            this.filtersSize_groupBox.TabIndex = 9;
            this.filtersSize_groupBox.TabStop = false;
            this.filtersSize_groupBox.Text = "Size";
            // 
            // filtersSizeOn_checkBox
            // 
            this.filtersSizeOn_checkBox.AutoSize = true;
            this.filtersSizeOn_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtersSizeOn_checkBox.Location = new System.Drawing.Point(7, 42);
            this.filtersSizeOn_checkBox.Name = "filtersSizeOn_checkBox";
            this.filtersSizeOn_checkBox.Size = new System.Drawing.Size(72, 17);
            this.filtersSizeOn_checkBox.TabIndex = 11;
            this.filtersSizeOn_checkBox.Text = "Not bigger";
            this.filtersSizeOn_checkBox.UseVisualStyleBackColor = true;
            this.filtersSizeOn_checkBox.CheckedChanged += new System.EventHandler(this.filtersSizeOn_checkBox_CheckedChanged);
            // 
            // filterSizeWidth_numericUpDown
            // 
            this.filterSizeWidth_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterSizeWidth_numericUpDown.Enabled = false;
            this.filterSizeWidth_numericUpDown.Location = new System.Drawing.Point(79, 29);
            this.filterSizeWidth_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.filterSizeWidth_numericUpDown.Name = "filterSizeWidth_numericUpDown";
            this.filterSizeWidth_numericUpDown.Size = new System.Drawing.Size(55, 20);
            this.filterSizeWidth_numericUpDown.TabIndex = 3;
            this.filterSizeWidth_numericUpDown.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // filterSizeHeight_numericUpDown
            // 
            this.filterSizeHeight_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterSizeHeight_numericUpDown.Enabled = false;
            this.filterSizeHeight_numericUpDown.Location = new System.Drawing.Point(79, 52);
            this.filterSizeHeight_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.filterSizeHeight_numericUpDown.Name = "filterSizeHeight_numericUpDown";
            this.filterSizeHeight_numericUpDown.Size = new System.Drawing.Size(55, 20);
            this.filterSizeHeight_numericUpDown.TabIndex = 3;
            this.filterSizeHeight_numericUpDown.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(135, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Height";
            // 
            // filterSizeOr_checkBox
            // 
            this.filterSizeOr_checkBox.AutoSize = true;
            this.filterSizeOr_checkBox.Enabled = false;
            this.filterSizeOr_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterSizeOr_checkBox.Location = new System.Drawing.Point(174, 42);
            this.filterSizeOr_checkBox.Name = "filterSizeOr_checkBox";
            this.filterSizeOr_checkBox.Size = new System.Drawing.Size(39, 17);
            this.filterSizeOr_checkBox.TabIndex = 4;
            this.filterSizeOr_checkBox.Text = "OR";
            this.filterSizeOr_checkBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.filterSizeOr_checkBox.UseVisualStyleBackColor = true;
            this.filterSizeOr_checkBox.CheckedChanged += new System.EventHandler(this.filterSizeOr_checkBox_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(135, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Width";
            // 
            // saveFilter_button
            // 
            this.saveFilter_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveFilter_button.Location = new System.Drawing.Point(162, 514);
            this.saveFilter_button.Name = "saveFilter_button";
            this.saveFilter_button.Size = new System.Drawing.Size(149, 31);
            this.saveFilter_button.TabIndex = 55;
            this.saveFilter_button.Text = "Save filter";
            this.saveFilter_button.UseVisualStyleBackColor = true;
            this.saveFilter_button.Click += new System.EventHandler(this.SaveFilter_button_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.filterFolderNameCaseSensitive_checkBox);
            this.groupBox10.Controls.Add(this.filterFolderNameContains_checkBox);
            this.groupBox10.Controls.Add(this.filterFolderNameContains_textBox);
            this.groupBox10.Controls.Add(this.filterFolderNameNotContains_checkBox);
            this.groupBox10.Controls.Add(this.filterFolderNameNotContains_textBox);
            this.groupBox10.Location = new System.Drawing.Point(3, 121);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(378, 94);
            this.groupBox10.TabIndex = 8;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Folder name";
            // 
            // filterFolderNameCaseSensitive_checkBox
            // 
            this.filterFolderNameCaseSensitive_checkBox.AutoSize = true;
            this.filterFolderNameCaseSensitive_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterFolderNameCaseSensitive_checkBox.Location = new System.Drawing.Point(112, 15);
            this.filterFolderNameCaseSensitive_checkBox.Name = "filterFolderNameCaseSensitive_checkBox";
            this.filterFolderNameCaseSensitive_checkBox.Size = new System.Drawing.Size(91, 17);
            this.filterFolderNameCaseSensitive_checkBox.TabIndex = 3;
            this.filterFolderNameCaseSensitive_checkBox.Text = "Case sensitive";
            this.filterFolderNameCaseSensitive_checkBox.UseVisualStyleBackColor = true;
            // 
            // filterFolderNameContains_checkBox
            // 
            this.filterFolderNameContains_checkBox.AutoSize = true;
            this.filterFolderNameContains_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterFolderNameContains_checkBox.Location = new System.Drawing.Point(9, 39);
            this.filterFolderNameContains_checkBox.Name = "filterFolderNameContains_checkBox";
            this.filterFolderNameContains_checkBox.Size = new System.Drawing.Size(64, 17);
            this.filterFolderNameContains_checkBox.TabIndex = 1;
            this.filterFolderNameContains_checkBox.Text = "Contains";
            this.filterFolderNameContains_checkBox.UseVisualStyleBackColor = true;
            this.filterFolderNameContains_checkBox.CheckedChanged += new System.EventHandler(this.filterFilenameContains_checkBox_CheckedChanged);
            // 
            // filterFolderNameContains_textBox
            // 
            this.filterFolderNameContains_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterFolderNameContains_textBox.Location = new System.Drawing.Point(112, 38);
            this.filterFolderNameContains_textBox.Name = "filterFolderNameContains_textBox";
            this.filterFolderNameContains_textBox.ReadOnly = true;
            this.filterFolderNameContains_textBox.Size = new System.Drawing.Size(247, 20);
            this.filterFolderNameContains_textBox.TabIndex = 2;
            // 
            // filterFolderNameNotContains_checkBox
            // 
            this.filterFolderNameNotContains_checkBox.AutoSize = true;
            this.filterFolderNameNotContains_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterFolderNameNotContains_checkBox.Location = new System.Drawing.Point(9, 65);
            this.filterFolderNameNotContains_checkBox.Name = "filterFolderNameNotContains_checkBox";
            this.filterFolderNameNotContains_checkBox.Size = new System.Drawing.Size(97, 17);
            this.filterFolderNameNotContains_checkBox.TabIndex = 1;
            this.filterFolderNameNotContains_checkBox.Text = "Doesn\'t contain";
            this.filterFolderNameNotContains_checkBox.UseVisualStyleBackColor = true;
            this.filterFolderNameNotContains_checkBox.CheckedChanged += new System.EventHandler(this.filterFilenameNotContains_checkBox_CheckedChanged);
            // 
            // filterFolderNameNotContains_textBox
            // 
            this.filterFolderNameNotContains_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterFolderNameNotContains_textBox.Location = new System.Drawing.Point(112, 64);
            this.filterFolderNameNotContains_textBox.Name = "filterFolderNameNotContains_textBox";
            this.filterFolderNameNotContains_textBox.ReadOnly = true;
            this.filterFolderNameNotContains_textBox.Size = new System.Drawing.Size(247, 20);
            this.filterFolderNameNotContains_textBox.TabIndex = 2;
            // 
            // filtersFilename_groupBox
            // 
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameCaseSensitive_checkBox);
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameContains_checkBox);
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameContains_textBox);
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameNotContains_checkBox);
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameNotContains_textBox);
            this.filtersFilename_groupBox.Location = new System.Drawing.Point(4, 21);
            this.filtersFilename_groupBox.Name = "filtersFilename_groupBox";
            this.filtersFilename_groupBox.Size = new System.Drawing.Size(378, 94);
            this.filtersFilename_groupBox.TabIndex = 8;
            this.filtersFilename_groupBox.TabStop = false;
            this.filtersFilename_groupBox.Text = "Filename";
            // 
            // filterFilenameCaseSensitive_checkBox
            // 
            this.filterFilenameCaseSensitive_checkBox.AutoSize = true;
            this.filterFilenameCaseSensitive_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterFilenameCaseSensitive_checkBox.Location = new System.Drawing.Point(112, 15);
            this.filterFilenameCaseSensitive_checkBox.Name = "filterFilenameCaseSensitive_checkBox";
            this.filterFilenameCaseSensitive_checkBox.Size = new System.Drawing.Size(91, 17);
            this.filterFilenameCaseSensitive_checkBox.TabIndex = 3;
            this.filterFilenameCaseSensitive_checkBox.Text = "Case sensitive";
            this.filterFilenameCaseSensitive_checkBox.UseVisualStyleBackColor = true;
            // 
            // filterFilenameContains_checkBox
            // 
            this.filterFilenameContains_checkBox.AutoSize = true;
            this.filterFilenameContains_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterFilenameContains_checkBox.Location = new System.Drawing.Point(9, 39);
            this.filterFilenameContains_checkBox.Name = "filterFilenameContains_checkBox";
            this.filterFilenameContains_checkBox.Size = new System.Drawing.Size(64, 17);
            this.filterFilenameContains_checkBox.TabIndex = 1;
            this.filterFilenameContains_checkBox.Text = "Contains";
            this.filterFilenameContains_checkBox.UseVisualStyleBackColor = true;
            this.filterFilenameContains_checkBox.CheckedChanged += new System.EventHandler(this.filterFilenameContains_checkBox_CheckedChanged);
            // 
            // filterFilenameContains_textBox
            // 
            this.filterFilenameContains_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterFilenameContains_textBox.Location = new System.Drawing.Point(112, 38);
            this.filterFilenameContains_textBox.Name = "filterFilenameContains_textBox";
            this.filterFilenameContains_textBox.ReadOnly = true;
            this.filterFilenameContains_textBox.Size = new System.Drawing.Size(247, 20);
            this.filterFilenameContains_textBox.TabIndex = 2;
            // 
            // filterFilenameNotContains_checkBox
            // 
            this.filterFilenameNotContains_checkBox.AutoSize = true;
            this.filterFilenameNotContains_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterFilenameNotContains_checkBox.Location = new System.Drawing.Point(9, 65);
            this.filterFilenameNotContains_checkBox.Name = "filterFilenameNotContains_checkBox";
            this.filterFilenameNotContains_checkBox.Size = new System.Drawing.Size(97, 17);
            this.filterFilenameNotContains_checkBox.TabIndex = 1;
            this.filterFilenameNotContains_checkBox.Text = "Doesn\'t contain";
            this.filterFilenameNotContains_checkBox.UseVisualStyleBackColor = true;
            this.filterFilenameNotContains_checkBox.CheckedChanged += new System.EventHandler(this.filterFilenameNotContains_checkBox_CheckedChanged);
            // 
            // filterFilenameNotContains_textBox
            // 
            this.filterFilenameNotContains_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterFilenameNotContains_textBox.Location = new System.Drawing.Point(112, 64);
            this.filterFilenameNotContains_textBox.Name = "filterFilenameNotContains_textBox";
            this.filterFilenameNotContains_textBox.ReadOnly = true;
            this.filterFilenameNotContains_textBox.Size = new System.Drawing.Size(247, 20);
            this.filterFilenameNotContains_textBox.TabIndex = 2;
            // 
            // loadFilter_button
            // 
            this.loadFilter_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadFilter_button.Location = new System.Drawing.Point(162, 548);
            this.loadFilter_button.Name = "loadFilter_button";
            this.loadFilter_button.Size = new System.Drawing.Size(149, 31);
            this.loadFilter_button.TabIndex = 56;
            this.loadFilter_button.Text = "Load filter";
            this.loadFilter_button.UseVisualStyleBackColor = true;
            this.loadFilter_button.Click += new System.EventHandler(this.LoadFilter_button_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Location = new System.Drawing.Point(855, 218);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(106, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Already has result";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            // 
            // filters_listBox
            // 
            this.filters_listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filters_listBox.FormattingEnabled = true;
            this.filters_listBox.Location = new System.Drawing.Point(8, 443);
            this.filters_listBox.Name = "filters_listBox";
            this.filters_listBox.Size = new System.Drawing.Size(149, 171);
            this.filters_listBox.TabIndex = 54;
            this.filters_listBox.SelectedIndexChanged += new System.EventHandler(this.filters_listBox_SelectedIndexChanged);
            // 
            // filtersAlpha_groupBox
            // 
            this.filtersAlpha_groupBox.Controls.Add(this.filterAlpha_comboBox);
            this.filtersAlpha_groupBox.Location = new System.Drawing.Point(4, 274);
            this.filtersAlpha_groupBox.Name = "filtersAlpha_groupBox";
            this.filtersAlpha_groupBox.Size = new System.Drawing.Size(130, 86);
            this.filtersAlpha_groupBox.TabIndex = 0;
            this.filtersAlpha_groupBox.TabStop = false;
            this.filtersAlpha_groupBox.Text = "Alpha";
            // 
            // filterAlpha_comboBox
            // 
            this.filterAlpha_comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.filterAlpha_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterAlpha_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filterAlpha_comboBox.FormattingEnabled = true;
            this.filterAlpha_comboBox.Location = new System.Drawing.Point(9, 38);
            this.filterAlpha_comboBox.Name = "filterAlpha_comboBox";
            this.filterAlpha_comboBox.Size = new System.Drawing.Size(111, 21);
            this.filterAlpha_comboBox.TabIndex = 0;
            // 
            // interpolation_tabPage
            // 
            this.interpolation_tabPage.Controls.Add(this.modelInterpolationAlpha_trackBar);
            this.interpolation_tabPage.Controls.Add(this.interpolationOutputModelName_textBox);
            this.interpolation_tabPage.Controls.Add(this.interpolationStart_button);
            this.interpolation_tabPage.Controls.Add(this.modelInterpolationAlphaValue_textBox);
            this.interpolation_tabPage.Controls.Add(this.interpolationModelTwo_comboBox);
            this.interpolation_tabPage.Controls.Add(this.interpolationModelOne_comboBox);
            this.interpolation_tabPage.Location = new System.Drawing.Point(4, 25);
            this.interpolation_tabPage.Name = "interpolation_tabPage";
            this.interpolation_tabPage.Size = new System.Drawing.Size(1263, 714);
            this.interpolation_tabPage.TabIndex = 3;
            this.interpolation_tabPage.Text = "Models interpolation";
            this.interpolation_tabPage.UseVisualStyleBackColor = true;
            // 
            // modelInterpolationAlpha_trackBar
            // 
            this.modelInterpolationAlpha_trackBar.LargeChange = 10;
            this.modelInterpolationAlpha_trackBar.Location = new System.Drawing.Point(25, 135);
            this.modelInterpolationAlpha_trackBar.Maximum = 99;
            this.modelInterpolationAlpha_trackBar.Minimum = 1;
            this.modelInterpolationAlpha_trackBar.Name = "modelInterpolationAlpha_trackBar";
            this.modelInterpolationAlpha_trackBar.Size = new System.Drawing.Size(428, 45);
            this.modelInterpolationAlpha_trackBar.TabIndex = 4;
            this.modelInterpolationAlpha_trackBar.Value = 50;
            this.modelInterpolationAlpha_trackBar.Scroll += new System.EventHandler(this.ModelInterpolationAlpha_trackBar_Scroll);
            // 
            // interpolationOutputModelName_textBox
            // 
            this.interpolationOutputModelName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.interpolationOutputModelName_textBox.Location = new System.Drawing.Point(25, 186);
            this.interpolationOutputModelName_textBox.Name = "interpolationOutputModelName_textBox";
            this.interpolationOutputModelName_textBox.Size = new System.Drawing.Size(428, 20);
            this.interpolationOutputModelName_textBox.TabIndex = 3;
            // 
            // interpolationStart_button
            // 
            this.interpolationStart_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.interpolationStart_button.Location = new System.Drawing.Point(25, 222);
            this.interpolationStart_button.Name = "interpolationStart_button";
            this.interpolationStart_button.Size = new System.Drawing.Size(428, 53);
            this.interpolationStart_button.TabIndex = 2;
            this.interpolationStart_button.Text = "INTERPOLATE";
            this.interpolationStart_button.UseVisualStyleBackColor = true;
            this.interpolationStart_button.Click += new System.EventHandler(this.interpolationStart_button_Click);
            // 
            // modelInterpolationAlphaValue_textBox
            // 
            this.modelInterpolationAlphaValue_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelInterpolationAlphaValue_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.modelInterpolationAlphaValue_textBox.Location = new System.Drawing.Point(459, 86);
            this.modelInterpolationAlphaValue_textBox.Name = "modelInterpolationAlphaValue_textBox";
            this.modelInterpolationAlphaValue_textBox.ReadOnly = true;
            this.modelInterpolationAlphaValue_textBox.Size = new System.Drawing.Size(63, 21);
            this.modelInterpolationAlphaValue_textBox.TabIndex = 1;
            this.modelInterpolationAlphaValue_textBox.Text = "0.5";
            this.modelInterpolationAlphaValue_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modelInterpolationAlphaValue_textBox.TextChanged += new System.EventHandler(this.InterpolationSettingsChanged);
            // 
            // interpolationModelTwo_comboBox
            // 
            this.interpolationModelTwo_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.interpolationModelTwo_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.interpolationModelTwo_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.interpolationModelTwo_comboBox.FormattingEnabled = true;
            this.interpolationModelTwo_comboBox.Location = new System.Drawing.Point(25, 108);
            this.interpolationModelTwo_comboBox.Name = "interpolationModelTwo_comboBox";
            this.interpolationModelTwo_comboBox.Size = new System.Drawing.Size(428, 21);
            this.interpolationModelTwo_comboBox.TabIndex = 0;
            this.interpolationModelTwo_comboBox.SelectedIndexChanged += new System.EventHandler(this.InterpolationModelsChanged);
            // 
            // interpolationModelOne_comboBox
            // 
            this.interpolationModelOne_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.interpolationModelOne_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.interpolationModelOne_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.interpolationModelOne_comboBox.FormattingEnabled = true;
            this.interpolationModelOne_comboBox.Location = new System.Drawing.Point(25, 68);
            this.interpolationModelOne_comboBox.Name = "interpolationModelOne_comboBox";
            this.interpolationModelOne_comboBox.Size = new System.Drawing.Size(428, 21);
            this.interpolationModelOne_comboBox.TabIndex = 0;
            this.interpolationModelOne_comboBox.SelectedIndexChanged += new System.EventHandler(this.InterpolationModelsChanged);
            // 
            // overlayResults_tabPage
            // 
            this.overlayResults_tabPage.Controls.Add(this.tableLayoutPanel4);
            this.overlayResults_tabPage.Location = new System.Drawing.Point(4, 25);
            this.overlayResults_tabPage.Name = "overlayResults_tabPage";
            this.overlayResults_tabPage.Size = new System.Drawing.Size(1263, 714);
            this.overlayResults_tabPage.TabIndex = 6;
            this.overlayResults_tabPage.Text = "Image interpolation";
            this.overlayResults_tabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.Controls.Add(this.overlayImages_button, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.overlayFolders_button, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.imageInterpolationAlphaValue_textBox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1263, 714);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // overlayImages_button
            // 
            this.overlayImages_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlayImages_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.overlayImages_button.Location = new System.Drawing.Point(1166, 3);
            this.overlayImages_button.Name = "overlayImages_button";
            this.overlayImages_button.Size = new System.Drawing.Size(94, 483);
            this.overlayImages_button.TabIndex = 1;
            this.overlayImages_button.Text = "Interpolate";
            this.overlayImages_button.UseVisualStyleBackColor = true;
            this.overlayImages_button.Click += new System.EventHandler(this.OverlayImages_button_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1157, 483);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Interpolate two images";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox7, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.overlayResultName_textBox, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1151, 464);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.imageBName_label);
            this.groupBox7.Controls.Add(this.imageB_panel);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(578, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(570, 430);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Image B";
            // 
            // imageBName_label
            // 
            this.imageBName_label.AutoSize = true;
            this.imageBName_label.Location = new System.Drawing.Point(54, 0);
            this.imageBName_label.Name = "imageBName_label";
            this.imageBName_label.Size = new System.Drawing.Size(98, 13);
            this.imageBName_label.TabIndex = 6;
            this.imageBName_label.Text = "imageBName_label";
            // 
            // imageB_panel
            // 
            this.imageB_panel.AllowDrop = true;
            this.imageB_panel.Controls.Add(this.imageB_pictureBox);
            this.imageB_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageB_panel.Location = new System.Drawing.Point(3, 16);
            this.imageB_panel.Name = "imageB_panel";
            this.imageB_panel.Size = new System.Drawing.Size(564, 411);
            this.imageB_panel.TabIndex = 5;
            this.imageB_panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.imagePanel_DragDrop);
            this.imageB_panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.general_DragEnter);
            // 
            // imageB_pictureBox
            // 
            this.imageB_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageB_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.imageB_pictureBox.Name = "imageB_pictureBox";
            this.imageB_pictureBox.Size = new System.Drawing.Size(564, 411);
            this.imageB_pictureBox.TabIndex = 0;
            this.imageB_pictureBox.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.imageAName_label);
            this.groupBox6.Controls.Add(this.imageA_panel);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(569, 430);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Image A";
            // 
            // imageAName_label
            // 
            this.imageAName_label.AutoSize = true;
            this.imageAName_label.Location = new System.Drawing.Point(54, 0);
            this.imageAName_label.Name = "imageAName_label";
            this.imageAName_label.Size = new System.Drawing.Size(98, 13);
            this.imageAName_label.TabIndex = 6;
            this.imageAName_label.Text = "imageAName_label";
            // 
            // imageA_panel
            // 
            this.imageA_panel.AllowDrop = true;
            this.imageA_panel.Controls.Add(this.imageA_pictureBox);
            this.imageA_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageA_panel.Location = new System.Drawing.Point(3, 16);
            this.imageA_panel.Name = "imageA_panel";
            this.imageA_panel.Size = new System.Drawing.Size(563, 411);
            this.imageA_panel.TabIndex = 4;
            this.imageA_panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.imagePanel_DragDrop);
            this.imageA_panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.general_DragEnter);
            // 
            // imageA_pictureBox
            // 
            this.imageA_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageA_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.imageA_pictureBox.Name = "imageA_pictureBox";
            this.imageA_pictureBox.Size = new System.Drawing.Size(563, 411);
            this.imageA_pictureBox.TabIndex = 0;
            this.imageA_pictureBox.TabStop = false;
            // 
            // overlayResultName_textBox
            // 
            this.overlayResultName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel5.SetColumnSpan(this.overlayResultName_textBox, 2);
            this.overlayResultName_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlayResultName_textBox.Location = new System.Drawing.Point(3, 439);
            this.overlayResultName_textBox.Name = "overlayResultName_textBox";
            this.overlayResultName_textBox.Size = new System.Drawing.Size(1145, 20);
            this.overlayResultName_textBox.TabIndex = 2;
            // 
            // overlayFolders_button
            // 
            this.overlayFolders_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlayFolders_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.overlayFolders_button.Location = new System.Drawing.Point(1166, 542);
            this.overlayFolders_button.Name = "overlayFolders_button";
            this.overlayFolders_button.Size = new System.Drawing.Size(94, 169);
            this.overlayFolders_button.TabIndex = 1;
            this.overlayFolders_button.Text = "Interpolate";
            this.overlayFolders_button.UseVisualStyleBackColor = true;
            this.overlayFolders_button.Click += new System.EventHandler(this.OverlayFolders_button_Click);
            // 
            // imageInterpolationAlphaValue_textBox
            // 
            this.imageInterpolationAlphaValue_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageInterpolationAlphaValue_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageInterpolationAlphaValue_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.imageInterpolationAlphaValue_textBox.Location = new System.Drawing.Point(1166, 501);
            this.imageInterpolationAlphaValue_textBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.imageInterpolationAlphaValue_textBox.Name = "imageInterpolationAlphaValue_textBox";
            this.imageInterpolationAlphaValue_textBox.ReadOnly = true;
            this.imageInterpolationAlphaValue_textBox.Size = new System.Drawing.Size(94, 21);
            this.imageInterpolationAlphaValue_textBox.TabIndex = 2;
            this.imageInterpolationAlphaValue_textBox.Text = "0.5";
            this.imageInterpolationAlphaValue_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.changeResultsDestinationPath_button);
            this.groupBox5.Controls.Add(this.originalImagesPath_textBox);
            this.groupBox5.Controls.Add(this.changeResultsBPath_button);
            this.groupBox5.Controls.Add(this.resultsAPath_textBox);
            this.groupBox5.Controls.Add(this.changeResultsAPath_button);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.changeOriginalImagesPath_button);
            this.groupBox5.Controls.Add(this.resultsBPath_textBox);
            this.groupBox5.Controls.Add(this.resultsDestinationPath_textBox);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Location = new System.Drawing.Point(3, 542);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(661, 169);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Interpolate two folders";
            // 
            // changeResultsDestinationPath_button
            // 
            this.changeResultsDestinationPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeResultsDestinationPath_button.Location = new System.Drawing.Point(616, 126);
            this.changeResultsDestinationPath_button.Name = "changeResultsDestinationPath_button";
            this.changeResultsDestinationPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeResultsDestinationPath_button.TabIndex = 36;
            this.changeResultsDestinationPath_button.Text = "...";
            this.changeResultsDestinationPath_button.UseVisualStyleBackColor = true;
            this.changeResultsDestinationPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // originalImagesPath_textBox
            // 
            this.originalImagesPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalImagesPath_textBox.Location = new System.Drawing.Point(57, 34);
            this.originalImagesPath_textBox.Name = "originalImagesPath_textBox";
            this.originalImagesPath_textBox.ReadOnly = true;
            this.originalImagesPath_textBox.Size = new System.Drawing.Size(553, 20);
            this.originalImagesPath_textBox.TabIndex = 30;
            this.toolTip1.SetToolTip(this.originalImagesPath_textBox, "ESRGAN root folder");
            // 
            // changeResultsBPath_button
            // 
            this.changeResultsBPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeResultsBPath_button.Location = new System.Drawing.Point(616, 86);
            this.changeResultsBPath_button.Name = "changeResultsBPath_button";
            this.changeResultsBPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeResultsBPath_button.TabIndex = 36;
            this.changeResultsBPath_button.Text = "...";
            this.changeResultsBPath_button.UseVisualStyleBackColor = true;
            this.changeResultsBPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // resultsAPath_textBox
            // 
            this.resultsAPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsAPath_textBox.Location = new System.Drawing.Point(57, 60);
            this.resultsAPath_textBox.Name = "resultsAPath_textBox";
            this.resultsAPath_textBox.ReadOnly = true;
            this.resultsAPath_textBox.Size = new System.Drawing.Size(553, 20);
            this.resultsAPath_textBox.TabIndex = 31;
            this.toolTip1.SetToolTip(this.resultsAPath_textBox, "IEU output folder");
            // 
            // changeResultsAPath_button
            // 
            this.changeResultsAPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeResultsAPath_button.Location = new System.Drawing.Point(616, 61);
            this.changeResultsAPath_button.Name = "changeResultsAPath_button";
            this.changeResultsAPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeResultsAPath_button.TabIndex = 37;
            this.changeResultsAPath_button.Text = "...";
            this.changeResultsAPath_button.UseVisualStyleBackColor = true;
            this.changeResultsAPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(13, 38);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(42, 13);
            this.label30.TabIndex = 32;
            this.label30.Text = "Original";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(17, 130);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(37, 13);
            this.label31.TabIndex = 35;
            this.label31.Text = "Result";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(8, 64);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 13);
            this.label29.TabIndex = 33;
            this.label29.Text = "Result A";
            // 
            // changeOriginalImagesPath_button
            // 
            this.changeOriginalImagesPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeOriginalImagesPath_button.Location = new System.Drawing.Point(616, 35);
            this.changeOriginalImagesPath_button.Name = "changeOriginalImagesPath_button";
            this.changeOriginalImagesPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeOriginalImagesPath_button.TabIndex = 38;
            this.changeOriginalImagesPath_button.Text = "...";
            this.changeOriginalImagesPath_button.UseVisualStyleBackColor = true;
            this.changeOriginalImagesPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // resultsBPath_textBox
            // 
            this.resultsBPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsBPath_textBox.Location = new System.Drawing.Point(57, 86);
            this.resultsBPath_textBox.Name = "resultsBPath_textBox";
            this.resultsBPath_textBox.ReadOnly = true;
            this.resultsBPath_textBox.Size = new System.Drawing.Size(553, 20);
            this.resultsBPath_textBox.TabIndex = 34;
            this.toolTip1.SetToolTip(this.resultsBPath_textBox, "IEU input folder");
            // 
            // resultsDestinationPath_textBox
            // 
            this.resultsDestinationPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsDestinationPath_textBox.Location = new System.Drawing.Point(57, 126);
            this.resultsDestinationPath_textBox.Name = "resultsDestinationPath_textBox";
            this.resultsDestinationPath_textBox.ReadOnly = true;
            this.resultsDestinationPath_textBox.Size = new System.Drawing.Size(553, 20);
            this.resultsDestinationPath_textBox.TabIndex = 34;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 89);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(47, 13);
            this.label28.TabIndex = 35;
            this.label28.Text = "Result B";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.imageInterpolation_trackBar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 492);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1157, 44);
            this.panel3.TabIndex = 6;
            // 
            // imageInterpolation_trackBar
            // 
            this.imageInterpolation_trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageInterpolation_trackBar.LargeChange = 10;
            this.imageInterpolation_trackBar.Location = new System.Drawing.Point(0, 0);
            this.imageInterpolation_trackBar.Maximum = 99;
            this.imageInterpolation_trackBar.Minimum = 1;
            this.imageInterpolation_trackBar.Name = "imageInterpolation_trackBar";
            this.imageInterpolation_trackBar.Size = new System.Drawing.Size(1157, 44);
            this.imageInterpolation_trackBar.TabIndex = 5;
            this.imageInterpolation_trackBar.Value = 50;
            this.imageInterpolation_trackBar.Scroll += new System.EventHandler(this.ImageInterpolation_trackBar_Scroll);
            // 
            // treeView_contextMenuStrip
            // 
            this.treeView_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openModelFolder});
            this.treeView_contextMenuStrip.Name = "treeView_contextMenuStrip";
            this.treeView_contextMenuStrip.Size = new System.Drawing.Size(175, 26);
            // 
            // openModelFolder
            // 
            this.openModelFolder.Name = "openModelFolder";
            this.openModelFolder.Size = new System.Drawing.Size(174, 22);
            this.openModelFolder.Text = "Open model folder";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            // 
            // popupNotifier1
            // 
            this.popupNotifier1.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            this.popupNotifier1.ContentText = null;
            this.popupNotifier1.Image = null;
            this.popupNotifier1.IsRightToLeft = false;
            this.popupNotifier1.OptionsMenu = null;
            this.popupNotifier1.Size = new System.Drawing.Size(400, 100);
            this.popupNotifier1.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.popupNotifier1.TitleText = null;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 743);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 777);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Enhancing Utility";
            this.Activated += new System.EventHandler(this.MainForm_Enter);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.tabControl1.ResumeLayout(false);
            this.main_tabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.outputMode_groupBox.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.previewResult_tabPage.ResumeLayout(false);
            this.previewResult_tabPage.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.settings_tabPage.ResumeLayout(false);
            this.settings_tabPage.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.threshold_groupBox.ResumeLayout(false);
            this.threshold_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBlack_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdWhite_numericUpDown)).EndInit();
            this.imagePostprocess_groupBox.ResumeLayout(false);
            this.imagePostprocess_groupBox.PerformLayout();
            this.imagePreprocess_groupBox.ResumeLayout(false);
            this.imagePreprocess_groupBox.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileHeight_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileWidth_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overlapSize_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileResolution_numericUpDown)).EndInit();
            this.settingsOutputFormat_tabPage.ResumeLayout(false);
            this.settingsOutputFormat_tabPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webpQuality_numericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pngCompression_numericUpDown)).EndInit();
            this.tiffSetting_groupBox.ResumeLayout(false);
            this.tiffSetting_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiffJpegQuality_numericUpDown)).EndInit();
            this.ddsOutputSettings_groupBox.ResumeLayout(false);
            this.ddsOutputSettings_groupBox.PerformLayout();
            this.advanced_tabPage.ResumeLayout(false);
            this.advanced_tabPage.PerformLayout();
            this.rules_groupBox.ResumeLayout(false);
            this.rules_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulePriority_numericUpDown)).EndInit();
            this.filters_groupBox.ResumeLayout(false);
            this.filters_groupBox.PerformLayout();
            this.filtersSize_groupBox.ResumeLayout(false);
            this.filtersSize_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeWidth_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeHeight_numericUpDown)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.filtersFilename_groupBox.ResumeLayout(false);
            this.filtersFilename_groupBox.PerformLayout();
            this.filtersAlpha_groupBox.ResumeLayout(false);
            this.interpolation_tabPage.ResumeLayout(false);
            this.interpolation_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelInterpolationAlpha_trackBar)).EndInit();
            this.overlayResults_tabPage.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.imageB_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageB_pictureBox)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.imageA_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageA_pictureBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageInterpolation_trackBar)).EndInit();
            this.treeView_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button upscale_button;
        private System.Windows.Forms.TextBox esrganPath_textBox;
        private System.Windows.Forms.TextBox resultsMergedPath_textBox;
        private System.Windows.Forms.Button crop_button;
        private System.Windows.Forms.Button merge_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage main_tabPage;
        private System.Windows.Forms.TabPage settings_tabPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imgPath_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown maxTileResolution_numericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown overlapSize_numericUpDown;
        private System.Windows.Forms.CheckBox ignoreAlpha_checkBox;
        private System.Windows.Forms.Button changeInputImgPath_button;
        private System.Windows.Forms.Button changeEsrganPath_button;
        private System.Windows.Forms.Button changeMergedResultsPath_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox outputMode_groupBox;
        private System.Windows.Forms.TabPage advanced_tabPage;
        private System.Windows.Forms.Button runAll_button;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox preserveFormat_checkBox;
        private System.Windows.Forms.Button changeModelsPath_button;
        private System.Windows.Forms.Button changeOutputPath_button;
        private System.Windows.Forms.Button changeInputPath_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox modelsPath_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputPath_textBox;
        private System.Windows.Forms.TextBox inputPath_textBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progress_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox advancedSuffix_textBox;
        private System.Windows.Forms.CheckBox advancedUseSuffix_checkBox;
        private System.Windows.Forms.GroupBox filters_groupBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox filterSizeOr_checkBox;
        private System.Windows.Forms.NumericUpDown filterSizeHeight_numericUpDown;
        private System.Windows.Forms.NumericUpDown filterSizeWidth_numericUpDown;
        private System.Windows.Forms.TextBox filterFilenameContains_textBox;
        private System.Windows.Forms.CheckBox filterFilenameContains_checkBox;
        private System.Windows.Forms.GroupBox filtersAlpha_groupBox;
        private System.Windows.Forms.CheckBox createMemoryImage_checkBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox filterFilenameNotContains_textBox;
        private System.Windows.Forms.CheckBox filterFilenameNotContains_checkBox;
        private System.Windows.Forms.GroupBox filtersSize_groupBox;
        private System.Windows.Forms.GroupBox filtersFilename_groupBox;
        private System.Windows.Forms.CheckBox filtersSizeOn_checkBox;
        private System.Windows.Forms.CheckBox filterFilenameCaseSensitive_checkBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label progressFiltered_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown maxTileHeight_numericUpDown;
        private System.Windows.Forms.NumericUpDown maxTileWidth_numericUpDown;
        private System.Windows.Forms.CheckBox deleteResults_checkBox;
        private System.Windows.Forms.CheckBox checkForUpdates_checkBox;
        private System.Windows.Forms.GroupBox imagePostprocess_groupBox;
        private System.Windows.Forms.GroupBox threshold_groupBox;
        private System.Windows.Forms.NumericUpDown thresholdBlack_numericUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox thresholdEnabled_checkBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown thresholdWhite_numericUpDown;
        private System.Windows.Forms.GroupBox imagePreprocess_groupBox;
        private System.Windows.Forms.ComboBox noiseReductionType_comboBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox ddsOutputSettings_groupBox;
        private System.Windows.Forms.ComboBox ddsFileFormat_comboBox;
        private System.Windows.Forms.ComboBox ddsTextureType_comboBox;
        private System.Windows.Forms.ComboBox ddsCompresion_comboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox ddsGenerateMipmaps_checkBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown pngCompression_numericUpDown;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox outputDestinationMode_comboBox;
        private System.Windows.Forms.ComboBox overwriteMode_comboBox;
        private System.Windows.Forms.ComboBox filterAlpha_comboBox;
        private System.Windows.Forms.CheckedListBox filterExtensions_checkedListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel appCoreVersion_linkLabel;
        private System.Windows.Forms.LinkLabel appVersion_label;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox resizeImageBeforeFilterType_comboBox;
        private System.Windows.Forms.ComboBox resizeImageBeforeScaleFactor_comboBox;
        private System.Windows.Forms.CheckBox splitRGB_checkBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox resizeImageAfterFilterType_comboBox;
        private System.Windows.Forms.ComboBox resizeImageAfterScaleFactor_comboBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage interpolation_tabPage;
        private System.Windows.Forms.Button interpolationStart_button;
        private System.Windows.Forms.TextBox modelInterpolationAlphaValue_textBox;
        private System.Windows.Forms.ComboBox interpolationModelTwo_comboBox;
        private System.Windows.Forms.ComboBox interpolationModelOne_comboBox;
        private System.Windows.Forms.TextBox interpolationOutputModelName_textBox;
        private System.Windows.Forms.ComboBox modelForAlpha_comboBox;
        private System.Windows.Forms.CheckBox useDifferentModelForAlpha_checkBox;
        private System.Windows.Forms.ComboBox outputFormat_comboBox;
        private System.Windows.Forms.TabPage settingsOutputFormat_tabPage;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ContextMenuStrip treeView_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openModelFolder;
        private System.Windows.Forms.CheckBox seamlessTextures_checkBox;
        private System.Windows.Forms.CheckBox useCPU_checkBox;
        private System.Windows.Forms.CheckBox ignoreSingleColorAlpha_checkBox;
        private System.Windows.Forms.CheckBox balanceAlphas_checkBox;
        private System.Windows.Forms.GroupBox tiffSetting_groupBox;
        private System.Windows.Forms.ComboBox tiffSettings_comboBox;
        private System.Windows.Forms.NumericUpDown tiffJpegQuality_numericUpDown;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox webpLossless_checkBox;
        private System.Windows.Forms.NumericUpDown webpQuality_numericUpDown;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox webpPreset_comboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox preciseTile_checkBox;
        private System.Windows.Forms.TabPage previewResult_tabPage;
        private Cyotek.Windows.Forms.ImageBox zoomImageBox;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton openFromFileToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton actualSizeToolStripButton;
        private System.Windows.Forms.ToolStripButton zoomInToolStripButton;
        private System.Windows.Forms.ToolStripButton zoomOutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox zoomLevelsToolStripComboBox;
        private Cyotek.Windows.Forms.ImageBox previewImageBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox previewModels_comboBox;
        private System.Windows.Forms.Button previewUpdate_button;
        private System.Windows.Forms.Button previewSave_button;
        private System.Windows.Forms.ProgressBar preview_progressBar;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Cyotek.Windows.Forms.ImageBox miniMapImageBox;
        private System.Windows.Forms.Label imageSizeToolStripStatusLabel;
        private System.Windows.Forms.CheckBox useBasicSR_checkBox;
        private System.Windows.Forms.TabPage overlayResults_tabPage;
        private System.Windows.Forms.TextBox imageInterpolationAlphaValue_textBox;
        private System.Windows.Forms.Button overlayFolders_button;
        private System.Windows.Forms.Button overlayImages_button;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button changeResultsDestinationPath_button;
        private System.Windows.Forms.TextBox originalImagesPath_textBox;
        private System.Windows.Forms.Button changeResultsBPath_button;
        private System.Windows.Forms.TextBox resultsAPath_textBox;
        private System.Windows.Forms.Button changeResultsAPath_button;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button changeOriginalImagesPath_button;
        private System.Windows.Forms.TextBox resultsBPath_textBox;
        private System.Windows.Forms.TextBox resultsDestinationPath_textBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel imageB_panel;
        private System.Windows.Forms.PictureBox imageB_pictureBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel imageA_panel;
        private System.Windows.Forms.PictureBox imageA_pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox overlayResultName_textBox;
        private System.Windows.Forms.TrackBar modelInterpolationAlpha_trackBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar imageInterpolation_trackBar;
        private System.Windows.Forms.ListBox profiles_listBox;
        private System.Windows.Forms.Button deleteProfile_button;
        private System.Windows.Forms.TextBox saveProfileName_textBox;
        private System.Windows.Forms.Button saveProfile_button;
        private System.Windows.Forms.Button loadProfile_button;
        private System.Windows.Forms.Button deleteFilter_button;
        private System.Windows.Forms.TextBox newFilterName_textBox;
        private System.Windows.Forms.Button saveFilter_button;
        private System.Windows.Forms.Button loadFilter_button;
        private System.Windows.Forms.ListBox filters_listBox;
        private System.Windows.Forms.GroupBox rules_groupBox;
        private System.Windows.Forms.NumericUpDown rulePriority_numericUpDown;
        private System.Windows.Forms.Button deleteRule_button;
        private System.Windows.Forms.ListBox rules_listBox;
        private System.Windows.Forms.TextBox newRuleName_textBox;
        private System.Windows.Forms.ComboBox ruleProfiles_comboBox;
        private System.Windows.Forms.ComboBox ruleFilters_comboBox;
        private System.Windows.Forms.Button saveRule_button;
        private System.Windows.Forms.Button loadRule_button;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListBox profilesMainTab_listBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox filterFolderNameCaseSensitive_checkBox;
        private System.Windows.Forms.CheckBox filterFolderNameContains_checkBox;
        private System.Windows.Forms.TextBox filterFolderNameContains_textBox;
        private System.Windows.Forms.CheckBox filterFolderNameNotContains_checkBox;
        private System.Windows.Forms.TextBox filterFolderNameNotContains_textBox;
        private System.Windows.Forms.CheckBox disableRuleSystem_checkBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button saveRuleFromCurrent_button;
        private System.Windows.Forms.ComboBox profileModel_comboBox;
        private System.Windows.Forms.CheckBox useProfileModel_checkBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label imageBName_label;
        private System.Windows.Forms.Label imageAName_label;
        private System.Windows.Forms.CheckBox topMost_checkBox;
        private System.Windows.Forms.Button button_previewSaveComparison;
        private System.Windows.Forms.CheckBox balanceRgb_checkBox;
        private System.Windows.Forms.TextBox condaEnvName_textBox;
        private System.Windows.Forms.CheckBox useCondaEnv_checkBox;
        private System.Windows.Forms.ComboBox filterForAlpha_comboBox;
        private System.Windows.Forms.CheckBox useFilterForAlpha_checkBox;
        private Tulpep.NotificationWindow.PopupNotifier popupNotifier1;
        private System.Windows.Forms.CheckBox showPopups_checkBox;
        private System.Windows.Forms.Button previewSaveOutputFormat_button;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

