namespace ImageEnhancingUtility.Winforms
{
    partial class SettingsProfileTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {           
            this.groupBox9 = new AltUI.Controls.DarkGroupBox();
            this.supportRgba_checkBox = new AltUI.Controls.DarkCheckBox();
            this.ignoreAlpha_checkBox = new AltUI.Controls.DarkCheckBox();
            this.imagePostprocess_groupBox = new AltUI.Controls.DarkGroupBox();
            this.label22 = new AltUI.Controls.DarkLabel();
            this.threshold_groupBox = new AltUI.Controls.DarkGroupBox();
            this.thresholdBlack_numericUpDown = new AltUI.Controls.DarkNumericUpDown();
            this.label13 = new AltUI.Controls.DarkLabel();
            this.thresholdEnabledAlpha_checkBox = new AltUI.Controls.DarkCheckBox();
            this.thresholdEnabledRbg_checkBox = new AltUI.Controls.DarkCheckBox();
            this.label12 = new AltUI.Controls.DarkLabel();
            this.thresholdWhite_numericUpDown = new AltUI.Controls.DarkNumericUpDown();
            this.label21 = new AltUI.Controls.DarkLabel();
            this.resizeImageAfterFilterType_comboBox = new AltUI.Controls.DarkComboBox();
            this.resizeImageAfterScaleFactor_comboBox = new AltUI.Controls.DarkComboBox();
            this.imagePreprocess_groupBox = new AltUI.Controls.DarkGroupBox();
            this.label20 = new AltUI.Controls.DarkLabel();
            this.label19 = new AltUI.Controls.DarkLabel();
            this.label14 = new AltUI.Controls.DarkLabel();
            this.resizeImageBeforeScaleFactor_comboBox = new AltUI.Controls.DarkComboBox();
            this.resizeImageBeforeFilterType_comboBox = new AltUI.Controls.DarkComboBox();
            this.noiseReductionType_comboBox = new AltUI.Controls.DarkComboBox();
            this.outputFormat_comboBox = new AltUI.Controls.DarkComboBox();
            this.ignoreSingleColorAlpha_checkBox = new AltUI.Controls.DarkCheckBox();
            this.splitRGB_checkBox = new AltUI.Controls.DarkCheckBox();
            this.profileModel_comboBox = new AltUI.Controls.DarkComboBox();
            this.useProfileModel_checkBox = new AltUI.Controls.DarkCheckBox();
            this.filterForAlpha_comboBox = new AltUI.Controls.DarkComboBox();
            this.useFilterForAlpha_checkBox = new AltUI.Controls.DarkCheckBox();
            this.modelForAlpha_comboBox = new AltUI.Controls.DarkComboBox();
            this.useDifferentModelForAlpha_checkBox = new AltUI.Controls.DarkCheckBox();
            this.seamlessTextures_checkBox = new AltUI.Controls.DarkCheckBox();
            this.preserveFormat_checkBox = new AltUI.Controls.DarkCheckBox();
            this.label23 = new AltUI.Controls.DarkLabel();
            this.deleteProfile_button = new AltUI.Controls.DarkButton();
            this.saveProfileName_textBox = new AltUI.Controls.DarkTextBox();
            this.saveProfile_button = new AltUI.Controls.DarkButton();
            this.profiles_listBox = new AltUI.Controls.DarkListBox();
            this.loadProfile_button = new AltUI.Controls.DarkButton();
            this.groupBox9.SuspendLayout();
            this.imagePostprocess_groupBox.SuspendLayout();
            this.threshold_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBlack_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdWhite_numericUpDown)).BeginInit();
            this.imagePreprocess_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.supportRgba_checkBox);
            this.groupBox9.Controls.Add(this.ignoreAlpha_checkBox);
            this.groupBox9.Controls.Add(this.imagePostprocess_groupBox);
            this.groupBox9.Controls.Add(this.imagePreprocess_groupBox);
            this.groupBox9.Controls.Add(this.outputFormat_comboBox);
            this.groupBox9.Controls.Add(this.ignoreSingleColorAlpha_checkBox);
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
            this.groupBox9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox9.Location = new System.Drawing.Point(20, 20);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(570, 326);
            this.groupBox9.TabIndex = 96;
            this.groupBox9.TabStop = false;
            // 
            // supportRgba_checkBox
            // 
            this.supportRgba_checkBox.AutoSize = true;
            this.supportRgba_checkBox.Location = new System.Drawing.Point(319, 158);
            this.supportRgba_checkBox.Name = "supportRgba_checkBox";
            this.supportRgba_checkBox.Offset = 1;
            this.supportRgba_checkBox.Size = new System.Drawing.Size(137, 19);
            this.supportRgba_checkBox.TabIndex = 25;
            this.supportRgba_checkBox.Text = "RGBA model support";
            // 
            // ignoreAlpha_checkBox
            // 
            this.ignoreAlpha_checkBox.AutoSize = true;
            this.ignoreAlpha_checkBox.Location = new System.Drawing.Point(319, 116);
            this.ignoreAlpha_checkBox.Name = "ignoreAlpha_checkBox";
            this.ignoreAlpha_checkBox.Offset = 1;
            this.ignoreAlpha_checkBox.Size = new System.Drawing.Size(137, 19);
            this.ignoreAlpha_checkBox.TabIndex = 25;
            this.ignoreAlpha_checkBox.Text = "Ignore alpha channel";
            // 
            // imagePostprocess_groupBox
            // 
            this.imagePostprocess_groupBox.Controls.Add(this.label22);
            this.imagePostprocess_groupBox.Controls.Add(this.threshold_groupBox);
            this.imagePostprocess_groupBox.Controls.Add(this.label21);
            this.imagePostprocess_groupBox.Controls.Add(this.resizeImageAfterFilterType_comboBox);
            this.imagePostprocess_groupBox.Controls.Add(this.resizeImageAfterScaleFactor_comboBox);
            this.imagePostprocess_groupBox.ForeColor = System.Drawing.SystemColors.ControlLight;
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
            this.label22.Location = new System.Drawing.Point(174, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(18, 15);
            this.label22.TabIndex = 2;
            this.label22.Text = "to";
            // 
            // threshold_groupBox
            // 
            this.threshold_groupBox.Controls.Add(this.thresholdBlack_numericUpDown);
            this.threshold_groupBox.Controls.Add(this.label13);
            this.threshold_groupBox.Controls.Add(this.thresholdEnabledAlpha_checkBox);
            this.threshold_groupBox.Controls.Add(this.thresholdEnabledRbg_checkBox);
            this.threshold_groupBox.Controls.Add(this.label12);
            this.threshold_groupBox.Controls.Add(this.thresholdWhite_numericUpDown);
            this.threshold_groupBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.threshold_groupBox.Location = new System.Drawing.Point(9, 48);
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
            this.thresholdBlack_numericUpDown.Location = new System.Drawing.Point(135, 13);
            this.thresholdBlack_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.thresholdBlack_numericUpDown.Name = "thresholdBlack_numericUpDown";
            this.thresholdBlack_numericUpDown.Size = new System.Drawing.Size(45, 23);
            this.thresholdBlack_numericUpDown.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(181, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "White";
            // 
            // thresholdEnabledAlpha_checkBox
            // 
            this.thresholdEnabledAlpha_checkBox.AutoSize = true;
            this.thresholdEnabledAlpha_checkBox.Location = new System.Drawing.Point(12, 42);
            this.thresholdEnabledAlpha_checkBox.Name = "thresholdEnabledAlpha_checkBox";
            this.thresholdEnabledAlpha_checkBox.Offset = 1;
            this.thresholdEnabledAlpha_checkBox.Size = new System.Drawing.Size(95, 19);
            this.thresholdEnabledAlpha_checkBox.TabIndex = 0;
            this.thresholdEnabledAlpha_checkBox.Text = "Use for alpha";
            // 
            // thresholdEnabledRbg_checkBox
            // 
            this.thresholdEnabledRbg_checkBox.AutoSize = true;
            this.thresholdEnabledRbg_checkBox.Location = new System.Drawing.Point(12, 19);
            this.thresholdEnabledRbg_checkBox.Name = "thresholdEnabledRbg_checkBox";
            this.thresholdEnabledRbg_checkBox.Offset = 1;
            this.thresholdEnabledRbg_checkBox.Size = new System.Drawing.Size(88, 19);
            this.thresholdEnabledRbg_checkBox.TabIndex = 0;
            this.thresholdEnabledRbg_checkBox.Text = "Use for RGB";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(181, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Black";
            // 
            // thresholdWhite_numericUpDown
            // 
            this.thresholdWhite_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thresholdWhite_numericUpDown.Enabled = false;
            this.thresholdWhite_numericUpDown.Location = new System.Drawing.Point(135, 39);
            this.thresholdWhite_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.thresholdWhite_numericUpDown.Name = "thresholdWhite_numericUpDown";
            this.thresholdWhite_numericUpDown.Size = new System.Drawing.Size(45, 23);
            this.thresholdWhite_numericUpDown.TabIndex = 1;
            this.thresholdWhite_numericUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 15);
            this.label21.TabIndex = 2;
            this.label21.Text = "Resize with";
            // 
            // resizeImageAfterFilterType_comboBox
            // 
            this.resizeImageAfterFilterType_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.resizeImageAfterFilterType_comboBox.FormattingEnabled = true;
            this.resizeImageAfterFilterType_comboBox.Location = new System.Drawing.Point(75, 24);
            this.resizeImageAfterFilterType_comboBox.Name = "resizeImageAfterFilterType_comboBox";
            this.resizeImageAfterFilterType_comboBox.Size = new System.Drawing.Size(95, 24);
            this.resizeImageAfterFilterType_comboBox.TabIndex = 0;
            // 
            // resizeImageAfterScaleFactor_comboBox
            // 
            this.resizeImageAfterScaleFactor_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.resizeImageAfterScaleFactor_comboBox.FormattingEnabled = true;
            this.resizeImageAfterScaleFactor_comboBox.Location = new System.Drawing.Point(196, 24);
            this.resizeImageAfterScaleFactor_comboBox.Name = "resizeImageAfterScaleFactor_comboBox";
            this.resizeImageAfterScaleFactor_comboBox.Size = new System.Drawing.Size(60, 24);
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
            this.imagePreprocess_groupBox.ForeColor = System.Drawing.SystemColors.ControlLight;
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
            this.label20.Size = new System.Drawing.Size(18, 15);
            this.label20.TabIndex = 2;
            this.label20.Text = "to";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 15);
            this.label19.TabIndex = 2;
            this.label19.Text = "Resize with";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Reduce noise";
            // 
            // resizeImageBeforeScaleFactor_comboBox
            // 
            this.resizeImageBeforeScaleFactor_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.resizeImageBeforeScaleFactor_comboBox.FormattingEnabled = true;
            this.resizeImageBeforeScaleFactor_comboBox.Location = new System.Drawing.Point(207, 24);
            this.resizeImageBeforeScaleFactor_comboBox.Name = "resizeImageBeforeScaleFactor_comboBox";
            this.resizeImageBeforeScaleFactor_comboBox.Size = new System.Drawing.Size(60, 24);
            this.resizeImageBeforeScaleFactor_comboBox.TabIndex = 0;
            // 
            // resizeImageBeforeFilterType_comboBox
            // 
            this.resizeImageBeforeFilterType_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.resizeImageBeforeFilterType_comboBox.FormattingEnabled = true;
            this.resizeImageBeforeFilterType_comboBox.Location = new System.Drawing.Point(87, 24);
            this.resizeImageBeforeFilterType_comboBox.Name = "resizeImageBeforeFilterType_comboBox";
            this.resizeImageBeforeFilterType_comboBox.Size = new System.Drawing.Size(95, 24);
            this.resizeImageBeforeFilterType_comboBox.TabIndex = 0;
            // 
            // noiseReductionType_comboBox
            // 
            this.noiseReductionType_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.noiseReductionType_comboBox.FormattingEnabled = true;
            this.noiseReductionType_comboBox.Location = new System.Drawing.Point(87, 54);
            this.noiseReductionType_comboBox.Name = "noiseReductionType_comboBox";
            this.noiseReductionType_comboBox.Size = new System.Drawing.Size(95, 24);
            this.noiseReductionType_comboBox.TabIndex = 0;
            // 
            // outputFormat_comboBox
            // 
            this.outputFormat_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.outputFormat_comboBox.FormattingEnabled = true;
            this.outputFormat_comboBox.Location = new System.Drawing.Point(116, 30);
            this.outputFormat_comboBox.Name = "outputFormat_comboBox";
            this.outputFormat_comboBox.Size = new System.Drawing.Size(120, 24);
            this.outputFormat_comboBox.TabIndex = 48;
            // 
            // ignoreSingleColorAlpha_checkBox
            // 
            this.ignoreSingleColorAlpha_checkBox.AutoSize = true;
            this.ignoreSingleColorAlpha_checkBox.Location = new System.Drawing.Point(319, 137);
            this.ignoreSingleColorAlpha_checkBox.Name = "ignoreSingleColorAlpha_checkBox";
            this.ignoreSingleColorAlpha_checkBox.Offset = 1;
            this.ignoreSingleColorAlpha_checkBox.Size = new System.Drawing.Size(152, 19);
            this.ignoreSingleColorAlpha_checkBox.TabIndex = 25;
            this.ignoreSingleColorAlpha_checkBox.Text = "Ignore solid white alpha";
            // 
            // splitRGB_checkBox
            // 
            this.splitRGB_checkBox.AutoSize = true;
            this.splitRGB_checkBox.Location = new System.Drawing.Point(17, 141);
            this.splitRGB_checkBox.Name = "splitRGB_checkBox";
            this.splitRGB_checkBox.Offset = 1;
            this.splitRGB_checkBox.Size = new System.Drawing.Size(124, 19);
            this.splitRGB_checkBox.TabIndex = 25;
            this.splitRGB_checkBox.Text = "Split RGB channels";
            // 
            // profileModel_comboBox
            // 
            this.profileModel_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.profileModel_comboBox.Enabled = false;
            this.profileModel_comboBox.FormattingEnabled = true;
            this.profileModel_comboBox.Location = new System.Drawing.Point(193, 61);
            this.profileModel_comboBox.Name = "profileModel_comboBox";
            this.profileModel_comboBox.Size = new System.Drawing.Size(371, 24);
            this.profileModel_comboBox.TabIndex = 47;
            // 
            // useProfileModel_checkBox
            // 
            this.useProfileModel_checkBox.AutoSize = true;
            this.useProfileModel_checkBox.Location = new System.Drawing.Point(17, 63);
            this.useProfileModel_checkBox.Name = "useProfileModel_checkBox";
            this.useProfileModel_checkBox.Offset = 1;
            this.useProfileModel_checkBox.Size = new System.Drawing.Size(125, 19);
            this.useProfileModel_checkBox.TabIndex = 25;
            this.useProfileModel_checkBox.Text = "Use specific model";
            // 
            // filterForAlpha_comboBox
            // 
            this.filterForAlpha_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.filterForAlpha_comboBox.Enabled = false;
            this.filterForAlpha_comboBox.FormattingEnabled = true;
            this.filterForAlpha_comboBox.Location = new System.Drawing.Point(193, 116);
            this.filterForAlpha_comboBox.Name = "filterForAlpha_comboBox";
            this.filterForAlpha_comboBox.Size = new System.Drawing.Size(110, 24);
            this.filterForAlpha_comboBox.TabIndex = 47;
            // 
            // useFilterForAlpha_checkBox
            // 
            this.useFilterForAlpha_checkBox.AutoSize = true;
            this.useFilterForAlpha_checkBox.Location = new System.Drawing.Point(17, 116);
            this.useFilterForAlpha_checkBox.Name = "useFilterForAlpha_checkBox";
            this.useFilterForAlpha_checkBox.Offset = 1;
            this.useFilterForAlpha_checkBox.Size = new System.Drawing.Size(122, 19);
            this.useFilterForAlpha_checkBox.TabIndex = 25;
            this.useFilterForAlpha_checkBox.Text = "Use filter for alpha";
            // 
            // modelForAlpha_comboBox
            // 
            this.modelForAlpha_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.modelForAlpha_comboBox.Enabled = false;
            this.modelForAlpha_comboBox.FormattingEnabled = true;
            this.modelForAlpha_comboBox.Location = new System.Drawing.Point(193, 88);
            this.modelForAlpha_comboBox.Name = "modelForAlpha_comboBox";
            this.modelForAlpha_comboBox.Size = new System.Drawing.Size(371, 24);
            this.modelForAlpha_comboBox.TabIndex = 47;
            // 
            // useDifferentModelForAlpha_checkBox
            // 
            this.useDifferentModelForAlpha_checkBox.AutoSize = true;
            this.useDifferentModelForAlpha_checkBox.Location = new System.Drawing.Point(17, 89);
            this.useDifferentModelForAlpha_checkBox.Name = "useDifferentModelForAlpha_checkBox";
            this.useDifferentModelForAlpha_checkBox.Offset = 1;
            this.useDifferentModelForAlpha_checkBox.Size = new System.Drawing.Size(175, 19);
            this.useDifferentModelForAlpha_checkBox.TabIndex = 25;
            this.useDifferentModelForAlpha_checkBox.Text = "Use specific model for alpha";
            // 
            // seamlessTextures_checkBox
            // 
            this.seamlessTextures_checkBox.AutoSize = true;
            this.seamlessTextures_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.seamlessTextures_checkBox.Location = new System.Drawing.Point(17, 166);
            this.seamlessTextures_checkBox.Name = "seamlessTextures_checkBox";
            this.seamlessTextures_checkBox.Offset = 1;
            this.seamlessTextures_checkBox.Size = new System.Drawing.Size(139, 17);
            this.seamlessTextures_checkBox.TabIndex = 30;
            this.seamlessTextures_checkBox.Text = "Seamless (tiled) textures";
            // 
            // preserveFormat_checkBox
            // 
            this.preserveFormat_checkBox.AutoSize = true;
            this.preserveFormat_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.preserveFormat_checkBox.Location = new System.Drawing.Point(242, 33);
            this.preserveFormat_checkBox.Name = "preserveFormat_checkBox";
            this.preserveFormat_checkBox.Offset = 1;
            this.preserveFormat_checkBox.Size = new System.Drawing.Size(113, 17);
            this.preserveFormat_checkBox.TabIndex = 30;
            this.preserveFormat_checkBox.Text = "Use original format";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(32, 34);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(84, 15);
            this.label23.TabIndex = 24;
            this.label23.Text = "Output format";
            // 
            // deleteProfile_button
            // 
            this.deleteProfile_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProfile_button.FlatBottom = false;
            this.deleteProfile_button.FlatTop = false;
            this.deleteProfile_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deleteProfile_button.HoldColour = false;
            this.deleteProfile_button.Location = new System.Drawing.Point(438, 712);
            this.deleteProfile_button.Name = "deleteProfile_button";
            this.deleteProfile_button.Padding = new System.Windows.Forms.Padding(5);
            this.deleteProfile_button.Size = new System.Drawing.Size(149, 31);
            this.deleteProfile_button.TabIndex = 102;
            this.deleteProfile_button.Text = "Delete profile";
            // 
            // saveProfileName_textBox
            // 
            this.saveProfileName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveProfileName_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.saveProfileName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveProfileName_textBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.saveProfileName_textBox.Location = new System.Drawing.Point(438, 617);
            this.saveProfileName_textBox.Name = "saveProfileName_textBox";
            this.saveProfileName_textBox.Size = new System.Drawing.Size(149, 23);
            this.saveProfileName_textBox.TabIndex = 101;
            // 
            // saveProfile_button
            // 
            this.saveProfile_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveProfile_button.FlatBottom = false;
            this.saveProfile_button.FlatTop = false;
            this.saveProfile_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.saveProfile_button.HoldColour = false;
            this.saveProfile_button.Location = new System.Drawing.Point(438, 643);
            this.saveProfile_button.Name = "saveProfile_button";
            this.saveProfile_button.Padding = new System.Windows.Forms.Padding(5);
            this.saveProfile_button.Size = new System.Drawing.Size(149, 31);
            this.saveProfile_button.TabIndex = 99;
            this.saveProfile_button.Text = "Save profile";
            // 
            // profiles_listBox
            // 
            this.profiles_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.profiles_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.profiles_listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profiles_listBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.profiles_listBox.FormattingEnabled = true;
            this.profiles_listBox.ItemHeight = 15;
            this.profiles_listBox.Location = new System.Drawing.Point(593, 426);
            this.profiles_listBox.Name = "profiles_listBox";
            this.profiles_listBox.Size = new System.Drawing.Size(150, 317);
            this.profiles_listBox.TabIndex = 98;
            // 
            // loadProfile_button
            // 
            this.loadProfile_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadProfile_button.FlatBottom = false;
            this.loadProfile_button.FlatTop = false;
            this.loadProfile_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.loadProfile_button.HoldColour = false;
            this.loadProfile_button.Location = new System.Drawing.Point(438, 677);
            this.loadProfile_button.Name = "loadProfile_button";
            this.loadProfile_button.Padding = new System.Windows.Forms.Padding(5);
            this.loadProfile_button.Size = new System.Drawing.Size(149, 31);
            this.loadProfile_button.TabIndex = 100;
            this.loadProfile_button.Text = "Load profile";
            // 
            // SettingsProfileTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteProfile_button);
            this.Controls.Add(this.saveProfileName_textBox);
            this.Controls.Add(this.saveProfile_button);
            this.Controls.Add(this.profiles_listBox);
            this.Controls.Add(this.loadProfile_button);
            this.Controls.Add(this.groupBox9);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingsProfileTab";
            this.Size = new System.Drawing.Size(750, 750);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.imagePostprocess_groupBox.ResumeLayout(false);
            this.imagePostprocess_groupBox.PerformLayout();
            this.threshold_groupBox.ResumeLayout(false);
            this.threshold_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBlack_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdWhite_numericUpDown)).EndInit();
            this.imagePreprocess_groupBox.ResumeLayout(false);
            this.imagePreprocess_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        public AltUI.Controls.DarkGroupBox groupBox9;
        public AltUI.Controls.DarkCheckBox supportRgba_checkBox;
        public AltUI.Controls.DarkCheckBox ignoreAlpha_checkBox;
        public AltUI.Controls.DarkGroupBox imagePostprocess_groupBox;
        public AltUI.Controls.DarkLabel label22;
        public AltUI.Controls.DarkGroupBox threshold_groupBox;
        public AltUI.Controls.DarkNumericUpDown thresholdBlack_numericUpDown;
        public AltUI.Controls.DarkLabel label13;
        public AltUI.Controls.DarkCheckBox thresholdEnabledAlpha_checkBox;
        public AltUI.Controls.DarkCheckBox thresholdEnabledRbg_checkBox;
        public AltUI.Controls.DarkLabel label12;
        public AltUI.Controls.DarkNumericUpDown thresholdWhite_numericUpDown;
        public AltUI.Controls.DarkLabel label21;
        public AltUI.Controls.DarkComboBox resizeImageAfterFilterType_comboBox;
        public AltUI.Controls.DarkComboBox resizeImageAfterScaleFactor_comboBox;
        public AltUI.Controls.DarkGroupBox imagePreprocess_groupBox;
        public AltUI.Controls.DarkLabel label20;
        public AltUI.Controls.DarkLabel label19;
        public AltUI.Controls.DarkLabel label14;
        public AltUI.Controls.DarkComboBox resizeImageBeforeScaleFactor_comboBox;
        public AltUI.Controls.DarkComboBox resizeImageBeforeFilterType_comboBox;
        public AltUI.Controls.DarkComboBox noiseReductionType_comboBox;
        public AltUI.Controls.DarkComboBox outputFormat_comboBox;
        public AltUI.Controls.DarkCheckBox ignoreSingleColorAlpha_checkBox;
        public AltUI.Controls.DarkCheckBox splitRGB_checkBox;
        public AltUI.Controls.DarkComboBox profileModel_comboBox;
        public AltUI.Controls.DarkCheckBox useProfileModel_checkBox;
        public AltUI.Controls.DarkComboBox filterForAlpha_comboBox;
        public AltUI.Controls.DarkCheckBox useFilterForAlpha_checkBox;
        public AltUI.Controls.DarkComboBox modelForAlpha_comboBox;
        public AltUI.Controls.DarkCheckBox useDifferentModelForAlpha_checkBox;
        public AltUI.Controls.DarkCheckBox seamlessTextures_checkBox;
        public AltUI.Controls.DarkCheckBox preserveFormat_checkBox;
        public AltUI.Controls.DarkLabel label23;
        public AltUI.Controls.DarkButton deleteProfile_button;
        public AltUI.Controls.DarkTextBox saveProfileName_textBox;
        public AltUI.Controls.DarkButton saveProfile_button;
        public AltUI.Controls.DarkListBox profiles_listBox;
        public AltUI.Controls.DarkButton loadProfile_button;
    }
}
