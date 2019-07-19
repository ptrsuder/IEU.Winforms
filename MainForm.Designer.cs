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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.overwriteMode_comboBox = new System.Windows.Forms.ComboBox();
            this.runAll_button = new System.Windows.Forms.Button();
            this.outputMode_groupBox = new System.Windows.Forms.GroupBox();
            this.outputDestinationMode_comboBox = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new ImageEnhancingUtility.Winforms.MyTreeView();
            this.treeView_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openModelFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.settings_tabPage = new System.Windows.Forms.TabPage();
            this.outputFormat_comboBox = new System.Windows.Forms.ComboBox();
            this.modelForAlpha_comboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.appCoreVersion_linkLabel = new System.Windows.Forms.LinkLabel();
            this.appVersion_label = new System.Windows.Forms.LinkLabel();
            this.checkForUpdates_checkBox = new System.Windows.Forms.CheckBox();
            this.deleteResults_checkBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maxTileHeight_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxTileWidth_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.createMemoryImage_checkBox = new System.Windows.Forms.CheckBox();
            this.preserveFormat_checkBox = new System.Windows.Forms.CheckBox();
            this.changeInputImgPath_button = new System.Windows.Forms.Button();
            this.changeMergedResultsPath_button = new System.Windows.Forms.Button();
            this.changeEsrganPath_button = new System.Windows.Forms.Button();
            this.debugUpscale_checkBox = new System.Windows.Forms.CheckBox();
            this.useDifferentModelForAlpha_checkBox = new System.Windows.Forms.CheckBox();
            this.splitRGB_checkBox = new System.Windows.Forms.CheckBox();
            this.ignoreAlpha_checkBox = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.overlapSize_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.maxTileResolution_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.imgPath_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsOutputFormat_tabPage = new System.Windows.Forms.TabPage();
            this.ddsOutputSettings_groupBox = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ddsGenerateMipmaps_checkBox = new System.Windows.Forms.CheckBox();
            this.ddsCompresion_comboBox = new System.Windows.Forms.ComboBox();
            this.ddsFileFormat_comboBox = new System.Windows.Forms.ComboBox();
            this.ddsTextureType_comboBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pngCompression_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.advanced_tabPage = new System.Windows.Forms.TabPage();
            this.imagePostprocess_groupBox = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.threshold_groupBox = new System.Windows.Forms.GroupBox();
            this.thresholdBlack_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.thresholdEnabled_checkBox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.thresholdWhite_numericUpDown = new System.Windows.Forms.NumericUpDown();
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
            this.changeModelsPath_button = new System.Windows.Forms.Button();
            this.upscaleSize_groupBox = new System.Windows.Forms.GroupBox();
            this.x1_radioButton = new System.Windows.Forms.RadioButton();
            this.x2_radioButton = new System.Windows.Forms.RadioButton();
            this.x4_radioButton = new System.Windows.Forms.RadioButton();
            this.changeOutputPath_button = new System.Windows.Forms.Button();
            this.filters_groupBox = new System.Windows.Forms.GroupBox();
            this.filterExtensions_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.filtersSize_groupBox = new System.Windows.Forms.GroupBox();
            this.filtersSizeOn_checkBox = new System.Windows.Forms.CheckBox();
            this.filterSizeWidth_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.filterSizeHeight_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.filterSizeOr_checkBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.filtersFilename_groupBox = new System.Windows.Forms.GroupBox();
            this.filterFilenameCaseSensitive_checkBox = new System.Windows.Forms.CheckBox();
            this.filterFilenameContains_checkBox = new System.Windows.Forms.CheckBox();
            this.filterFilenameContains_textBox = new System.Windows.Forms.TextBox();
            this.filterFilenameNotContains_checkBox = new System.Windows.Forms.CheckBox();
            this.filterFilenameNotContains_textBox = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.filtersAlpha_groupBox = new System.Windows.Forms.GroupBox();
            this.filterAlpha_comboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.advancedSuffix_textBox = new System.Windows.Forms.TextBox();
            this.changeInputPath_button = new System.Windows.Forms.Button();
            this.advancedUseSuffix_checkBox = new System.Windows.Forms.CheckBox();
            this.inputPath_textBox = new System.Windows.Forms.TextBox();
            this.outputPath_textBox = new System.Windows.Forms.TextBox();
            this.modelsPath_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.interpolation_tabPage = new System.Windows.Forms.TabPage();
            this.interpolationOutputModelName_textBox = new System.Windows.Forms.TextBox();
            this.interpolationStart_button = new System.Windows.Forms.Button();
            this.interpolationAlphaValue_textBox = new System.Windows.Forms.TextBox();
            this.interpolationModelTwo_comboBox = new System.Windows.Forms.ComboBox();
            this.interpolationModelOne_comboBox = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.main_tabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.outputMode_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.treeView_contextMenuStrip.SuspendLayout();
            this.settings_tabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileHeight_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileWidth_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overlapSize_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileResolution_numericUpDown)).BeginInit();
            this.settingsOutputFormat_tabPage.SuspendLayout();
            this.ddsOutputSettings_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pngCompression_numericUpDown)).BeginInit();
            this.advanced_tabPage.SuspendLayout();
            this.imagePostprocess_groupBox.SuspendLayout();
            this.threshold_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBlack_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdWhite_numericUpDown)).BeginInit();
            this.imagePreprocess_groupBox.SuspendLayout();
            this.upscaleSize_groupBox.SuspendLayout();
            this.filters_groupBox.SuspendLayout();
            this.filtersSize_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeWidth_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeHeight_numericUpDown)).BeginInit();
            this.filtersFilename_groupBox.SuspendLayout();
            this.filtersAlpha_groupBox.SuspendLayout();
            this.interpolation_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // upscale_button
            // 
            this.upscale_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.upscale_button.Location = new System.Drawing.Point(0, 332);
            this.upscale_button.Name = "upscale_button";
            this.upscale_button.Size = new System.Drawing.Size(149, 83);
            this.upscale_button.TabIndex = 1;
            this.upscale_button.Text = "RUN ESRGAN";
            this.toolTip1.SetToolTip(this.upscale_button, "Process all files from ESRGAN input folder and save them in results folder or it " +
        "subfolders depending on output mode");
            this.upscale_button.UseVisualStyleBackColor = true;
            // 
            // esrganPath_textBox
            // 
            this.esrganPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.esrganPath_textBox.Location = new System.Drawing.Point(84, 18);
            this.esrganPath_textBox.Name = "esrganPath_textBox";
            this.esrganPath_textBox.ReadOnly = true;
            this.esrganPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.esrganPath_textBox.TabIndex = 13;
            // 
            // resultsMergedPath_textBox
            // 
            this.resultsMergedPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsMergedPath_textBox.Location = new System.Drawing.Point(84, 44);
            this.resultsMergedPath_textBox.Name = "resultsMergedPath_textBox";
            this.resultsMergedPath_textBox.ReadOnly = true;
            this.resultsMergedPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.resultsMergedPath_textBox.TabIndex = 15;
            // 
            // crop_button
            // 
            this.crop_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.crop_button.Location = new System.Drawing.Point(0, 149);
            this.crop_button.Name = "crop_button";
            this.crop_button.Size = new System.Drawing.Size(149, 83);
            this.crop_button.TabIndex = 17;
            this.crop_button.Text = "CROP IMAGES";
            this.toolTip1.SetToolTip(this.crop_button, "Create tiles from original images and save them as png in ESRGAN input folder");
            this.crop_button.UseVisualStyleBackColor = true;
            // 
            // merge_button
            // 
            this.merge_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.merge_button.Location = new System.Drawing.Point(0, 421);
            this.merge_button.Name = "merge_button";
            this.merge_button.Size = new System.Drawing.Size(149, 83);
            this.merge_button.TabIndex = 18;
            this.merge_button.Text = "MERGE IMAGES";
            this.toolTip1.SetToolTip(this.merge_button, "Find all image tiles in results folder/subfolders, merge them in single image and" +
        " save it in merged-results folder/subfolder depending on output mode.");
            this.merge_button.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.main_tabPage);
            this.tabControl1.Controls.Add(this.settings_tabPage);
            this.tabControl1.Controls.Add(this.settingsOutputFormat_tabPage);
            this.tabControl1.Controls.Add(this.advanced_tabPage);
            this.tabControl1.Controls.Add(this.interpolation_tabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 21);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1156, 747);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 19;
            // 
            // main_tabPage
            // 
            this.main_tabPage.Controls.Add(this.tableLayoutPanel1);
            this.main_tabPage.Location = new System.Drawing.Point(4, 25);
            this.main_tabPage.Name = "main_tabPage";
            this.main_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.main_tabPage.Size = new System.Drawing.Size(1148, 718);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1142, 712);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressFiltered_label);
            this.panel2.Controls.Add(this.progress_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 685);
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
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.runAll_button);
            this.panel1.Controls.Add(this.outputMode_groupBox);
            this.panel1.Controls.Add(this.upscale_button);
            this.panel1.Controls.Add(this.crop_button);
            this.panel1.Controls.Add(this.merge_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 676);
            this.panel1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.overwriteMode_comboBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 50);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overwrite";
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
            this.runAll_button.Location = new System.Drawing.Point(0, 539);
            this.runAll_button.Name = "runAll_button";
            this.runAll_button.Size = new System.Drawing.Size(149, 32);
            this.runAll_button.TabIndex = 32;
            this.runAll_button.Text = "RUN ALL STEPS";
            this.runAll_button.UseVisualStyleBackColor = true;
            this.runAll_button.Click += new System.EventHandler(this.runAll_button_ClickAsync);
            // 
            // outputMode_groupBox
            // 
            this.outputMode_groupBox.Controls.Add(this.outputDestinationMode_comboBox);
            this.outputMode_groupBox.Location = new System.Drawing.Point(0, 91);
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
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1MinSize = 400;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(981, 676);
            this.splitContainer1.SplitterDistance = 709;
            this.splitContainer1.TabIndex = 21;
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.ContextMenuStrip = this.treeView_contextMenuStrip;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Lucida Console", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.HideSelection = false;
            this.treeView1.ItemHeight = 20;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(709, 676);
            this.treeView1.TabIndex = 9;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
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
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Console", 10.25F);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(268, 676);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(158, 685);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(981, 24);
            this.progressBar1.TabIndex = 22;
            // 
            // settings_tabPage
            // 
            this.settings_tabPage.Controls.Add(this.outputFormat_comboBox);
            this.settings_tabPage.Controls.Add(this.modelForAlpha_comboBox);
            this.settings_tabPage.Controls.Add(this.tableLayoutPanel2);
            this.settings_tabPage.Controls.Add(this.deleteResults_checkBox);
            this.settings_tabPage.Controls.Add(this.label9);
            this.settings_tabPage.Controls.Add(this.maxTileHeight_numericUpDown);
            this.settings_tabPage.Controls.Add(this.maxTileWidth_numericUpDown);
            this.settings_tabPage.Controls.Add(this.createMemoryImage_checkBox);
            this.settings_tabPage.Controls.Add(this.preserveFormat_checkBox);
            this.settings_tabPage.Controls.Add(this.changeInputImgPath_button);
            this.settings_tabPage.Controls.Add(this.changeMergedResultsPath_button);
            this.settings_tabPage.Controls.Add(this.changeEsrganPath_button);
            this.settings_tabPage.Controls.Add(this.debugUpscale_checkBox);
            this.settings_tabPage.Controls.Add(this.useDifferentModelForAlpha_checkBox);
            this.settings_tabPage.Controls.Add(this.splitRGB_checkBox);
            this.settings_tabPage.Controls.Add(this.ignoreAlpha_checkBox);
            this.settings_tabPage.Controls.Add(this.label23);
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
            this.settings_tabPage.Size = new System.Drawing.Size(1148, 718);
            this.settings_tabPage.TabIndex = 1;
            this.settings_tabPage.Text = "Settings";
            this.settings_tabPage.UseVisualStyleBackColor = true;
            // 
            // outputFormat_comboBox
            // 
            this.outputFormat_comboBox.FormattingEnabled = true;
            this.outputFormat_comboBox.Location = new System.Drawing.Point(84, 159);
            this.outputFormat_comboBox.Name = "outputFormat_comboBox";
            this.outputFormat_comboBox.Size = new System.Drawing.Size(120, 21);
            this.outputFormat_comboBox.TabIndex = 48;
            // 
            // modelForAlpha_comboBox
            // 
            this.modelForAlpha_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.modelForAlpha_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.modelForAlpha_comboBox.Enabled = false;
            this.modelForAlpha_comboBox.FormattingEnabled = true;
            this.modelForAlpha_comboBox.Location = new System.Drawing.Point(249, 210);
            this.modelForAlpha_comboBox.Name = "modelForAlpha_comboBox";
            this.modelForAlpha_comboBox.Size = new System.Drawing.Size(381, 21);
            this.modelForAlpha_comboBox.TabIndex = 47;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(906, 661);
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
            this.appVersion_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            // deleteResults_checkBox
            // 
            this.deleteResults_checkBox.AutoSize = true;
            this.deleteResults_checkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteResults_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteResults_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteResults_checkBox.Location = new System.Drawing.Point(84, 280);
            this.deleteResults_checkBox.Name = "deleteResults_checkBox";
            this.deleteResults_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteResults_checkBox.Size = new System.Drawing.Size(144, 17);
            this.deleteResults_checkBox.TabIndex = 38;
            this.deleteResults_checkBox.Text = "Delete results after merge";
            this.deleteResults_checkBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "X";
            // 
            // maxTileHeight_numericUpDown
            // 
            this.maxTileHeight_numericUpDown.Location = new System.Drawing.Point(308, 107);
            this.maxTileHeight_numericUpDown.Maximum = new decimal(new int[] {
            4096,
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
            // maxTileWidth_numericUpDown
            // 
            this.maxTileWidth_numericUpDown.Location = new System.Drawing.Point(222, 107);
            this.maxTileWidth_numericUpDown.Maximum = new decimal(new int[] {
            4096,
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
            // createMemoryImage_checkBox
            // 
            this.createMemoryImage_checkBox.AutoSize = true;
            this.createMemoryImage_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createMemoryImage_checkBox.Location = new System.Drawing.Point(84, 257);
            this.createMemoryImage_checkBox.Name = "createMemoryImage_checkBox";
            this.createMemoryImage_checkBox.Size = new System.Drawing.Size(312, 17);
            this.createMemoryImage_checkBox.TabIndex = 31;
            this.createMemoryImage_checkBox.Text = "Create max resolution tile in LR (helps with memory allocation)";
            this.createMemoryImage_checkBox.UseVisualStyleBackColor = true;
            // 
            // preserveFormat_checkBox
            // 
            this.preserveFormat_checkBox.AutoSize = true;
            this.preserveFormat_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.preserveFormat_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.preserveFormat_checkBox.Location = new System.Drawing.Point(84, 304);
            this.preserveFormat_checkBox.Name = "preserveFormat_checkBox";
            this.preserveFormat_checkBox.Size = new System.Drawing.Size(142, 17);
            this.preserveFormat_checkBox.TabIndex = 30;
            this.preserveFormat_checkBox.Text = "Use original image format";
            this.preserveFormat_checkBox.UseVisualStyleBackColor = true;
            this.preserveFormat_checkBox.CheckedChanged += new System.EventHandler(this.preserveFormat_checkBox_CheckedChanged);
            // 
            // changeInputImgPath_button
            // 
            this.changeInputImgPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeInputImgPath_button.Location = new System.Drawing.Point(591, 69);
            this.changeInputImgPath_button.Name = "changeInputImgPath_button";
            this.changeInputImgPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeInputImgPath_button.TabIndex = 29;
            this.changeInputImgPath_button.Text = "...";
            this.changeInputImgPath_button.UseVisualStyleBackColor = true;
            this.changeInputImgPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // changeMergedResultsPath_button
            // 
            this.changeMergedResultsPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeMergedResultsPath_button.Location = new System.Drawing.Point(591, 44);
            this.changeMergedResultsPath_button.Name = "changeMergedResultsPath_button";
            this.changeMergedResultsPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeMergedResultsPath_button.TabIndex = 29;
            this.changeMergedResultsPath_button.Text = "...";
            this.changeMergedResultsPath_button.UseVisualStyleBackColor = true;
            this.changeMergedResultsPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // changeEsrganPath_button
            // 
            this.changeEsrganPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeEsrganPath_button.Location = new System.Drawing.Point(591, 18);
            this.changeEsrganPath_button.Name = "changeEsrganPath_button";
            this.changeEsrganPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeEsrganPath_button.TabIndex = 29;
            this.changeEsrganPath_button.Text = "...";
            this.changeEsrganPath_button.UseVisualStyleBackColor = true;
            this.changeEsrganPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // debugUpscale_checkBox
            // 
            this.debugUpscale_checkBox.AutoSize = true;
            this.debugUpscale_checkBox.Checked = true;
            this.debugUpscale_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.debugUpscale_checkBox.Location = new System.Drawing.Point(734, 693);
            this.debugUpscale_checkBox.Name = "debugUpscale_checkBox";
            this.debugUpscale_checkBox.Size = new System.Drawing.Size(166, 17);
            this.debugUpscale_checkBox.TabIndex = 28;
            this.debugUpscale_checkBox.Text = "Keep ESRGAN console open";
            this.debugUpscale_checkBox.UseVisualStyleBackColor = true;
            this.debugUpscale_checkBox.Visible = false;
            // 
            // useDifferentModelForAlpha_checkBox
            // 
            this.useDifferentModelForAlpha_checkBox.AutoSize = true;
            this.useDifferentModelForAlpha_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.useDifferentModelForAlpha_checkBox.Location = new System.Drawing.Point(84, 211);
            this.useDifferentModelForAlpha_checkBox.Name = "useDifferentModelForAlpha_checkBox";
            this.useDifferentModelForAlpha_checkBox.Size = new System.Drawing.Size(159, 17);
            this.useDifferentModelForAlpha_checkBox.TabIndex = 25;
            this.useDifferentModelForAlpha_checkBox.Text = "Use different model for alpha";
            this.useDifferentModelForAlpha_checkBox.UseVisualStyleBackColor = true;
            this.useDifferentModelForAlpha_checkBox.CheckedChanged += new System.EventHandler(this.differentModelForAlpha_checkBox_CheckedChanged);
            // 
            // splitRGB_checkBox
            // 
            this.splitRGB_checkBox.AutoSize = true;
            this.splitRGB_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.splitRGB_checkBox.Location = new System.Drawing.Point(84, 234);
            this.splitRGB_checkBox.Name = "splitRGB_checkBox";
            this.splitRGB_checkBox.Size = new System.Drawing.Size(116, 17);
            this.splitRGB_checkBox.TabIndex = 25;
            this.splitRGB_checkBox.Text = "Split RGB channels";
            this.splitRGB_checkBox.UseVisualStyleBackColor = true;
            // 
            // ignoreAlpha_checkBox
            // 
            this.ignoreAlpha_checkBox.AutoSize = true;
            this.ignoreAlpha_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ignoreAlpha_checkBox.Location = new System.Drawing.Point(84, 188);
            this.ignoreAlpha_checkBox.Name = "ignoreAlpha_checkBox";
            this.ignoreAlpha_checkBox.Size = new System.Drawing.Size(124, 17);
            this.ignoreAlpha_checkBox.TabIndex = 25;
            this.ignoreAlpha_checkBox.Text = "Ignore alpha channel";
            this.ignoreAlpha_checkBox.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 162);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "Output format";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tiles overlap";
            // 
            // overlapSize_numericUpDown
            // 
            this.overlapSize_numericUpDown.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.overlapSize_numericUpDown.Location = new System.Drawing.Point(84, 133);
            this.overlapSize_numericUpDown.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.overlapSize_numericUpDown.Minimum = new decimal(new int[] {
            16,
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
            this.label5.Location = new System.Drawing.Point(9, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Max tile WxH";
            // 
            // maxTileResolution_numericUpDown
            // 
            this.maxTileResolution_numericUpDown.Location = new System.Drawing.Point(84, 107);
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
            this.label4.Location = new System.Drawing.Point(37, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Images";
            // 
            // imgPath_textBox
            // 
            this.imgPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPath_textBox.Location = new System.Drawing.Point(84, 70);
            this.imgPath_textBox.Name = "imgPath_textBox";
            this.imgPath_textBox.ReadOnly = true;
            this.imgPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.imgPath_textBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Merged results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ESRGAN";
            // 
            // settingsOutputFormat_tabPage
            // 
            this.settingsOutputFormat_tabPage.Controls.Add(this.ddsOutputSettings_groupBox);
            this.settingsOutputFormat_tabPage.Controls.Add(this.label18);
            this.settingsOutputFormat_tabPage.Controls.Add(this.pngCompression_numericUpDown);
            this.settingsOutputFormat_tabPage.Location = new System.Drawing.Point(4, 25);
            this.settingsOutputFormat_tabPage.Name = "settingsOutputFormat_tabPage";
            this.settingsOutputFormat_tabPage.Size = new System.Drawing.Size(1148, 718);
            this.settingsOutputFormat_tabPage.TabIndex = 4;
            this.settingsOutputFormat_tabPage.Text = "Output format";
            this.settingsOutputFormat_tabPage.UseVisualStyleBackColor = true;
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
            this.ddsOutputSettings_groupBox.Location = new System.Drawing.Point(8, 22);
            this.ddsOutputSettings_groupBox.Name = "ddsOutputSettings_groupBox";
            this.ddsOutputSettings_groupBox.Size = new System.Drawing.Size(344, 144);
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
            this.ddsGenerateMipmaps_checkBox.Location = new System.Drawing.Point(104, 110);
            this.ddsGenerateMipmaps_checkBox.Name = "ddsGenerateMipmaps_checkBox";
            this.ddsGenerateMipmaps_checkBox.Size = new System.Drawing.Size(114, 17);
            this.ddsGenerateMipmaps_checkBox.TabIndex = 1;
            this.ddsGenerateMipmaps_checkBox.Text = "Generate mipmaps";
            this.ddsGenerateMipmaps_checkBox.UseVisualStyleBackColor = true;
            // 
            // ddsCompresion_comboBox
            // 
            this.ddsCompresion_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddsCompresion_comboBox.FormattingEnabled = true;
            this.ddsCompresion_comboBox.Location = new System.Drawing.Point(104, 83);
            this.ddsCompresion_comboBox.Name = "ddsCompresion_comboBox";
            this.ddsCompresion_comboBox.Size = new System.Drawing.Size(222, 21);
            this.ddsCompresion_comboBox.TabIndex = 0;
            // 
            // ddsFileFormat_comboBox
            // 
            this.ddsFileFormat_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddsFileFormat_comboBox.FormattingEnabled = true;
            this.ddsFileFormat_comboBox.Location = new System.Drawing.Point(104, 56);
            this.ddsFileFormat_comboBox.Name = "ddsFileFormat_comboBox";
            this.ddsFileFormat_comboBox.Size = new System.Drawing.Size(222, 21);
            this.ddsFileFormat_comboBox.TabIndex = 0;
            // 
            // ddsTextureType_comboBox
            // 
            this.ddsTextureType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddsTextureType_comboBox.FormattingEnabled = true;
            this.ddsTextureType_comboBox.Location = new System.Drawing.Point(104, 28);
            this.ddsTextureType_comboBox.Name = "ddsTextureType_comboBox";
            this.ddsTextureType_comboBox.Size = new System.Drawing.Size(222, 21);
            this.ddsTextureType_comboBox.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(373, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "Png compression";
            this.toolTip1.SetToolTip(this.label18, "0 - no compression, 9 - max compression");
            // 
            // pngCompression_numericUpDown
            // 
            this.pngCompression_numericUpDown.Location = new System.Drawing.Point(469, 22);
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
            // advanced_tabPage
            // 
            this.advanced_tabPage.Controls.Add(this.imagePostprocess_groupBox);
            this.advanced_tabPage.Controls.Add(this.imagePreprocess_groupBox);
            this.advanced_tabPage.Controls.Add(this.changeModelsPath_button);
            this.advanced_tabPage.Controls.Add(this.upscaleSize_groupBox);
            this.advanced_tabPage.Controls.Add(this.changeOutputPath_button);
            this.advanced_tabPage.Controls.Add(this.filters_groupBox);
            this.advanced_tabPage.Controls.Add(this.label8);
            this.advanced_tabPage.Controls.Add(this.advancedSuffix_textBox);
            this.advanced_tabPage.Controls.Add(this.changeInputPath_button);
            this.advanced_tabPage.Controls.Add(this.advancedUseSuffix_checkBox);
            this.advanced_tabPage.Controls.Add(this.inputPath_textBox);
            this.advanced_tabPage.Controls.Add(this.outputPath_textBox);
            this.advanced_tabPage.Controls.Add(this.modelsPath_textBox);
            this.advanced_tabPage.Controls.Add(this.label7);
            this.advanced_tabPage.Controls.Add(this.label2);
            this.advanced_tabPage.Location = new System.Drawing.Point(4, 25);
            this.advanced_tabPage.Name = "advanced_tabPage";
            this.advanced_tabPage.Size = new System.Drawing.Size(1148, 718);
            this.advanced_tabPage.TabIndex = 2;
            this.advanced_tabPage.Text = "Advanced";
            this.advanced_tabPage.UseVisualStyleBackColor = true;
            // 
            // imagePostprocess_groupBox
            // 
            this.imagePostprocess_groupBox.Controls.Add(this.label22);
            this.imagePostprocess_groupBox.Controls.Add(this.threshold_groupBox);
            this.imagePostprocess_groupBox.Controls.Add(this.label21);
            this.imagePostprocess_groupBox.Controls.Add(this.resizeImageAfterFilterType_comboBox);
            this.imagePostprocess_groupBox.Controls.Add(this.resizeImageAfterScaleFactor_comboBox);
            this.imagePostprocess_groupBox.Location = new System.Drawing.Point(443, 407);
            this.imagePostprocess_groupBox.Name = "imagePostprocess_groupBox";
            this.imagePostprocess_groupBox.Size = new System.Drawing.Size(269, 198);
            this.imagePostprocess_groupBox.TabIndex = 42;
            this.imagePostprocess_groupBox.TabStop = false;
            this.imagePostprocess_groupBox.Text = "Image postprocess";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(163, 126);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "to";
            // 
            // threshold_groupBox
            // 
            this.threshold_groupBox.Controls.Add(this.thresholdBlack_numericUpDown);
            this.threshold_groupBox.Controls.Add(this.label13);
            this.threshold_groupBox.Controls.Add(this.thresholdEnabled_checkBox);
            this.threshold_groupBox.Controls.Add(this.label12);
            this.threshold_groupBox.Controls.Add(this.thresholdWhite_numericUpDown);
            this.threshold_groupBox.Location = new System.Drawing.Point(12, 22);
            this.threshold_groupBox.Name = "threshold_groupBox";
            this.threshold_groupBox.Size = new System.Drawing.Size(204, 88);
            this.threshold_groupBox.TabIndex = 3;
            this.threshold_groupBox.TabStop = false;
            this.threshold_groupBox.Text = "Threshold";
            // 
            // thresholdBlack_numericUpDown
            // 
            this.thresholdBlack_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thresholdBlack_numericUpDown.Enabled = false;
            this.thresholdBlack_numericUpDown.Location = new System.Drawing.Point(91, 24);
            this.thresholdBlack_numericUpDown.Name = "thresholdBlack_numericUpDown";
            this.thresholdBlack_numericUpDown.Size = new System.Drawing.Size(45, 20);
            this.thresholdBlack_numericUpDown.TabIndex = 1;
            this.toolTip1.SetToolTip(this.thresholdBlack_numericUpDown, "Make all pixels darker than percentage true black");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(137, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "% White";
            // 
            // thresholdEnabled_checkBox
            // 
            this.thresholdEnabled_checkBox.AutoSize = true;
            this.thresholdEnabled_checkBox.Location = new System.Drawing.Point(12, 38);
            this.thresholdEnabled_checkBox.Name = "thresholdEnabled_checkBox";
            this.thresholdEnabled_checkBox.Size = new System.Drawing.Size(73, 17);
            this.thresholdEnabled_checkBox.TabIndex = 0;
            this.thresholdEnabled_checkBox.Text = "Threshold";
            this.thresholdEnabled_checkBox.UseVisualStyleBackColor = true;
            this.thresholdEnabled_checkBox.CheckedChanged += new System.EventHandler(this.thresholdEnabled_checkBox_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(137, 28);
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
            this.thresholdWhite_numericUpDown.Location = new System.Drawing.Point(91, 50);
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
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 126);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Resize";
            // 
            // resizeImageAfterFilterType_comboBox
            // 
            this.resizeImageAfterFilterType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resizeImageAfterFilterType_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resizeImageAfterFilterType_comboBox.FormattingEnabled = true;
            this.resizeImageAfterFilterType_comboBox.Location = new System.Drawing.Point(54, 122);
            this.resizeImageAfterFilterType_comboBox.Name = "resizeImageAfterFilterType_comboBox";
            this.resizeImageAfterFilterType_comboBox.Size = new System.Drawing.Size(102, 21);
            this.resizeImageAfterFilterType_comboBox.TabIndex = 0;
            // 
            // resizeImageAfterScaleFactor_comboBox
            // 
            this.resizeImageAfterScaleFactor_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resizeImageAfterScaleFactor_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resizeImageAfterScaleFactor_comboBox.FormattingEnabled = true;
            this.resizeImageAfterScaleFactor_comboBox.Location = new System.Drawing.Point(186, 122);
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
            this.imagePreprocess_groupBox.Location = new System.Drawing.Point(8, 407);
            this.imagePreprocess_groupBox.Name = "imagePreprocess_groupBox";
            this.imagePreprocess_groupBox.Size = new System.Drawing.Size(429, 198);
            this.imagePreprocess_groupBox.TabIndex = 41;
            this.imagePreprocess_groupBox.TabStop = false;
            this.imagePreprocess_groupBox.Text = "Image preprocess";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(217, 61);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "to";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Resize with";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 29);
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
            this.resizeImageBeforeScaleFactor_comboBox.Location = new System.Drawing.Point(239, 57);
            this.resizeImageBeforeScaleFactor_comboBox.Name = "resizeImageBeforeScaleFactor_comboBox";
            this.resizeImageBeforeScaleFactor_comboBox.Size = new System.Drawing.Size(60, 21);
            this.resizeImageBeforeScaleFactor_comboBox.TabIndex = 0;
            // 
            // resizeImageBeforeFilterType_comboBox
            // 
            this.resizeImageBeforeFilterType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resizeImageBeforeFilterType_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resizeImageBeforeFilterType_comboBox.FormattingEnabled = true;
            this.resizeImageBeforeFilterType_comboBox.Location = new System.Drawing.Point(87, 57);
            this.resizeImageBeforeFilterType_comboBox.Name = "resizeImageBeforeFilterType_comboBox";
            this.resizeImageBeforeFilterType_comboBox.Size = new System.Drawing.Size(127, 21);
            this.resizeImageBeforeFilterType_comboBox.TabIndex = 0;
            // 
            // noiseReductionType_comboBox
            // 
            this.noiseReductionType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.noiseReductionType_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.noiseReductionType_comboBox.FormattingEnabled = true;
            this.noiseReductionType_comboBox.Location = new System.Drawing.Point(87, 26);
            this.noiseReductionType_comboBox.Name = "noiseReductionType_comboBox";
            this.noiseReductionType_comboBox.Size = new System.Drawing.Size(127, 21);
            this.noiseReductionType_comboBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.noiseReductionType_comboBox, "Try to remove image noise with specific ImageMagick method");
            // 
            // changeModelsPath_button
            // 
            this.changeModelsPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeModelsPath_button.Location = new System.Drawing.Point(591, 69);
            this.changeModelsPath_button.Name = "changeModelsPath_button";
            this.changeModelsPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeModelsPath_button.TabIndex = 29;
            this.changeModelsPath_button.Text = "...";
            this.changeModelsPath_button.UseVisualStyleBackColor = true;
            this.changeModelsPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // upscaleSize_groupBox
            // 
            this.upscaleSize_groupBox.Controls.Add(this.x1_radioButton);
            this.upscaleSize_groupBox.Controls.Add(this.x2_radioButton);
            this.upscaleSize_groupBox.Controls.Add(this.x4_radioButton);
            this.upscaleSize_groupBox.Location = new System.Drawing.Point(977, 618);
            this.upscaleSize_groupBox.Name = "upscaleSize_groupBox";
            this.upscaleSize_groupBox.Size = new System.Drawing.Size(129, 54);
            this.upscaleSize_groupBox.TabIndex = 39;
            this.upscaleSize_groupBox.TabStop = false;
            this.upscaleSize_groupBox.Text = "Upscale Size";
            this.upscaleSize_groupBox.Visible = false;
            // 
            // x1_radioButton
            // 
            this.x1_radioButton.AutoSize = true;
            this.x1_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x1_radioButton.Location = new System.Drawing.Point(6, 23);
            this.x1_radioButton.Name = "x1_radioButton";
            this.x1_radioButton.Size = new System.Drawing.Size(35, 17);
            this.x1_radioButton.TabIndex = 12;
            this.x1_radioButton.Tag = "1";
            this.x1_radioButton.Text = "x1";
            this.x1_radioButton.UseVisualStyleBackColor = true;
            // 
            // x2_radioButton
            // 
            this.x2_radioButton.AutoSize = true;
            this.x2_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x2_radioButton.Location = new System.Drawing.Point(48, 23);
            this.x2_radioButton.Name = "x2_radioButton";
            this.x2_radioButton.Size = new System.Drawing.Size(35, 17);
            this.x2_radioButton.TabIndex = 10;
            this.x2_radioButton.Tag = "2";
            this.x2_radioButton.Text = "x2";
            this.x2_radioButton.UseVisualStyleBackColor = true;
            // 
            // x4_radioButton
            // 
            this.x4_radioButton.AutoSize = true;
            this.x4_radioButton.Checked = true;
            this.x4_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x4_radioButton.Location = new System.Drawing.Point(90, 23);
            this.x4_radioButton.Name = "x4_radioButton";
            this.x4_radioButton.Size = new System.Drawing.Size(35, 17);
            this.x4_radioButton.TabIndex = 11;
            this.x4_radioButton.TabStop = true;
            this.x4_radioButton.Tag = "4";
            this.x4_radioButton.Text = "x4";
            this.x4_radioButton.UseVisualStyleBackColor = true;
            // 
            // changeOutputPath_button
            // 
            this.changeOutputPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeOutputPath_button.Location = new System.Drawing.Point(591, 43);
            this.changeOutputPath_button.Name = "changeOutputPath_button";
            this.changeOutputPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeOutputPath_button.TabIndex = 29;
            this.changeOutputPath_button.Text = "...";
            this.changeOutputPath_button.UseVisualStyleBackColor = true;
            this.changeOutputPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // filters_groupBox
            // 
            this.filters_groupBox.Controls.Add(this.filterExtensions_checkedListBox);
            this.filters_groupBox.Controls.Add(this.filtersSize_groupBox);
            this.filters_groupBox.Controls.Add(this.filtersFilename_groupBox);
            this.filters_groupBox.Controls.Add(this.checkBox3);
            this.filters_groupBox.Controls.Add(this.filtersAlpha_groupBox);
            this.filters_groupBox.Location = new System.Drawing.Point(8, 131);
            this.filters_groupBox.Name = "filters_groupBox";
            this.filters_groupBox.Size = new System.Drawing.Size(704, 270);
            this.filters_groupBox.TabIndex = 32;
            this.filters_groupBox.TabStop = false;
            this.filters_groupBox.Text = "Filters";
            // 
            // filterExtensions_checkedListBox
            // 
            this.filterExtensions_checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterExtensions_checkedListBox.FormattingEnabled = true;
            this.filterExtensions_checkedListBox.Location = new System.Drawing.Point(425, 38);
            this.filterExtensions_checkedListBox.Name = "filterExtensions_checkedListBox";
            this.filterExtensions_checkedListBox.Size = new System.Drawing.Size(120, 197);
            this.filterExtensions_checkedListBox.TabIndex = 10;
            this.filterExtensions_checkedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.filterExtensions_checkedListBox_ItemCheck);
            // 
            // filtersSize_groupBox
            // 
            this.filtersSize_groupBox.Controls.Add(this.filtersSizeOn_checkBox);
            this.filtersSize_groupBox.Controls.Add(this.filterSizeWidth_numericUpDown);
            this.filtersSize_groupBox.Controls.Add(this.filterSizeHeight_numericUpDown);
            this.filtersSize_groupBox.Controls.Add(this.label11);
            this.filtersSize_groupBox.Controls.Add(this.filterSizeOr_checkBox);
            this.filtersSize_groupBox.Controls.Add(this.label10);
            this.filtersSize_groupBox.Location = new System.Drawing.Point(181, 141);
            this.filtersSize_groupBox.Name = "filtersSize_groupBox";
            this.filtersSize_groupBox.Size = new System.Drawing.Size(227, 94);
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
            // filtersFilename_groupBox
            // 
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameCaseSensitive_checkBox);
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameContains_checkBox);
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameContains_textBox);
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameNotContains_checkBox);
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameNotContains_textBox);
            this.filtersFilename_groupBox.Location = new System.Drawing.Point(11, 34);
            this.filtersFilename_groupBox.Name = "filtersFilename_groupBox";
            this.filtersFilename_groupBox.Size = new System.Drawing.Size(397, 94);
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
            this.filterFilenameContains_textBox.Size = new System.Drawing.Size(266, 20);
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
            this.filterFilenameNotContains_textBox.Size = new System.Drawing.Size(266, 20);
            this.filterFilenameNotContains_textBox.TabIndex = 2;
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
            // filtersAlpha_groupBox
            // 
            this.filtersAlpha_groupBox.Controls.Add(this.filterAlpha_comboBox);
            this.filtersAlpha_groupBox.Location = new System.Drawing.Point(11, 141);
            this.filtersAlpha_groupBox.Name = "filtersAlpha_groupBox";
            this.filtersAlpha_groupBox.Size = new System.Drawing.Size(164, 94);
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
            this.filterAlpha_comboBox.Size = new System.Drawing.Size(147, 21);
            this.filterAlpha_comboBox.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Models";
            // 
            // advancedSuffix_textBox
            // 
            this.advancedSuffix_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.advancedSuffix_textBox.Location = new System.Drawing.Point(393, 96);
            this.advancedSuffix_textBox.Name = "advancedSuffix_textBox";
            this.advancedSuffix_textBox.ReadOnly = true;
            this.advancedSuffix_textBox.Size = new System.Drawing.Size(193, 20);
            this.advancedSuffix_textBox.TabIndex = 1;
            // 
            // changeInputPath_button
            // 
            this.changeInputPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeInputPath_button.Location = new System.Drawing.Point(591, 17);
            this.changeInputPath_button.Name = "changeInputPath_button";
            this.changeInputPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeInputPath_button.TabIndex = 29;
            this.changeInputPath_button.Text = "...";
            this.changeInputPath_button.UseVisualStyleBackColor = true;
            this.changeInputPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // advancedUseSuffix_checkBox
            // 
            this.advancedUseSuffix_checkBox.AutoSize = true;
            this.advancedUseSuffix_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advancedUseSuffix_checkBox.Location = new System.Drawing.Point(273, 97);
            this.advancedUseSuffix_checkBox.Name = "advancedUseSuffix_checkBox";
            this.advancedUseSuffix_checkBox.Size = new System.Drawing.Size(117, 17);
            this.advancedUseSuffix_checkBox.TabIndex = 0;
            this.advancedUseSuffix_checkBox.Text = "Use suffix for results";
            this.advancedUseSuffix_checkBox.UseVisualStyleBackColor = true;
            this.advancedUseSuffix_checkBox.CheckedChanged += new System.EventHandler(this.advancedUseSuffix_checkBox_CheckedChanged);
            // 
            // inputPath_textBox
            // 
            this.inputPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPath_textBox.Location = new System.Drawing.Point(84, 18);
            this.inputPath_textBox.Name = "inputPath_textBox";
            this.inputPath_textBox.ReadOnly = true;
            this.inputPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.inputPath_textBox.TabIndex = 19;
            // 
            // outputPath_textBox
            // 
            this.outputPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputPath_textBox.Location = new System.Drawing.Point(84, 44);
            this.outputPath_textBox.Name = "outputPath_textBox";
            this.outputPath_textBox.ReadOnly = true;
            this.outputPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.outputPath_textBox.TabIndex = 19;
            // 
            // modelsPath_textBox
            // 
            this.modelsPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelsPath_textBox.Location = new System.Drawing.Point(84, 70);
            this.modelsPath_textBox.Name = "modelsPath_textBox";
            this.modelsPath_textBox.ReadOnly = true;
            this.modelsPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.modelsPath_textBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Output/results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Input/LR";
            // 
            // interpolation_tabPage
            // 
            this.interpolation_tabPage.Controls.Add(this.interpolationOutputModelName_textBox);
            this.interpolation_tabPage.Controls.Add(this.interpolationStart_button);
            this.interpolation_tabPage.Controls.Add(this.interpolationAlphaValue_textBox);
            this.interpolation_tabPage.Controls.Add(this.interpolationModelTwo_comboBox);
            this.interpolation_tabPage.Controls.Add(this.interpolationModelOne_comboBox);
            this.interpolation_tabPage.Location = new System.Drawing.Point(4, 25);
            this.interpolation_tabPage.Name = "interpolation_tabPage";
            this.interpolation_tabPage.Size = new System.Drawing.Size(1148, 718);
            this.interpolation_tabPage.TabIndex = 3;
            this.interpolation_tabPage.Text = "Models interpolation";
            this.interpolation_tabPage.UseVisualStyleBackColor = true;
            // 
            // interpolationOutputModelName_textBox
            // 
            this.interpolationOutputModelName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.interpolationOutputModelName_textBox.Location = new System.Drawing.Point(25, 147);
            this.interpolationOutputModelName_textBox.Name = "interpolationOutputModelName_textBox";
            this.interpolationOutputModelName_textBox.Size = new System.Drawing.Size(428, 20);
            this.interpolationOutputModelName_textBox.TabIndex = 3;
            // 
            // interpolationStart_button
            // 
            this.interpolationStart_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.interpolationStart_button.Location = new System.Drawing.Point(25, 183);
            this.interpolationStart_button.Name = "interpolationStart_button";
            this.interpolationStart_button.Size = new System.Drawing.Size(428, 53);
            this.interpolationStart_button.TabIndex = 2;
            this.interpolationStart_button.Text = "INTERPOLATE";
            this.interpolationStart_button.UseVisualStyleBackColor = true;
            this.interpolationStart_button.Click += new System.EventHandler(this.interpolationStart_button_Click);
            // 
            // interpolationAlphaValue_textBox
            // 
            this.interpolationAlphaValue_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.interpolationAlphaValue_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.interpolationAlphaValue_textBox.Location = new System.Drawing.Point(459, 89);
            this.interpolationAlphaValue_textBox.Name = "interpolationAlphaValue_textBox";
            this.interpolationAlphaValue_textBox.Size = new System.Drawing.Size(63, 21);
            this.interpolationAlphaValue_textBox.TabIndex = 1;
            this.interpolationAlphaValue_textBox.Text = "0.5";
            this.interpolationAlphaValue_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.interpolationAlphaValue_textBox.TextChanged += new System.EventHandler(this.InterpolationSettingsChanged);
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
            this.interpolationModelTwo_comboBox.SelectedIndexChanged += new System.EventHandler(this.InterpolationSettingsChanged);
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
            this.interpolationModelOne_comboBox.SelectedIndexChanged += new System.EventHandler(this.InterpolationSettingsChanged);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 747);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(740, 676);
            this.Name = "MainForm";
            this.Text = "crop-upscale-merge";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.tabControl1.ResumeLayout(false);
            this.main_tabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.outputMode_groupBox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.treeView_contextMenuStrip.ResumeLayout(false);
            this.settings_tabPage.ResumeLayout(false);
            this.settings_tabPage.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileHeight_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileWidth_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overlapSize_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileResolution_numericUpDown)).EndInit();
            this.settingsOutputFormat_tabPage.ResumeLayout(false);
            this.settingsOutputFormat_tabPage.PerformLayout();
            this.ddsOutputSettings_groupBox.ResumeLayout(false);
            this.ddsOutputSettings_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pngCompression_numericUpDown)).EndInit();
            this.advanced_tabPage.ResumeLayout(false);
            this.advanced_tabPage.PerformLayout();
            this.imagePostprocess_groupBox.ResumeLayout(false);
            this.imagePostprocess_groupBox.PerformLayout();
            this.threshold_groupBox.ResumeLayout(false);
            this.threshold_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBlack_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdWhite_numericUpDown)).EndInit();
            this.imagePreprocess_groupBox.ResumeLayout(false);
            this.imagePreprocess_groupBox.PerformLayout();
            this.upscaleSize_groupBox.ResumeLayout(false);
            this.upscaleSize_groupBox.PerformLayout();
            this.filters_groupBox.ResumeLayout(false);
            this.filters_groupBox.PerformLayout();
            this.filtersSize_groupBox.ResumeLayout(false);
            this.filtersSize_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeWidth_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeHeight_numericUpDown)).EndInit();
            this.filtersFilename_groupBox.ResumeLayout(false);
            this.filtersFilename_groupBox.PerformLayout();
            this.filtersAlpha_groupBox.ResumeLayout(false);
            this.interpolation_tabPage.ResumeLayout(false);
            this.interpolation_tabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button upscale_button;
        private MyTreeView treeView1;
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
        private System.Windows.Forms.CheckBox debugUpscale_checkBox;
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
        private System.Windows.Forms.GroupBox upscaleSize_groupBox;
        private System.Windows.Forms.RadioButton x1_radioButton;
        private System.Windows.Forms.RadioButton x2_radioButton;
        private System.Windows.Forms.RadioButton x4_radioButton;
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
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.TextBox interpolationAlphaValue_textBox;
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
    }
}

