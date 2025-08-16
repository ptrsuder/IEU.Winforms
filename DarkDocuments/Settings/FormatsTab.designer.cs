namespace ImageEnhancingUtility.Winforms
{
    partial class FormatsTab
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
            this.newFormatExtension_comboBox = new AltUI.Controls.DarkComboBox();
            this.label23 = new AltUI.Controls.DarkLabel();
            this.groupBox2 = new AltUI.Controls.DarkGroupBox();
            this.webpLossless_checkBox = new AltUI.Controls.DarkCheckBox();
            this.webpQuality_numericUpDown = new AltUI.Controls.DarkNumericUpDown();
            this.label26 = new AltUI.Controls.DarkLabel();
            this.label27 = new AltUI.Controls.DarkLabel();
            this.webpPreset_comboBox = new AltUI.Controls.DarkComboBox();
            this.groupBox3 = new AltUI.Controls.DarkGroupBox();
            this.pngCompression_numericUpDown = new AltUI.Controls.DarkNumericUpDown();
            this.label18 = new AltUI.Controls.DarkLabel();
            this.tiffSetting_groupBox = new AltUI.Controls.DarkGroupBox();
            this.tiffJpegQuality_numericUpDown = new AltUI.Controls.DarkNumericUpDown();
            this.label25 = new AltUI.Controls.DarkLabel();
            this.label24 = new AltUI.Controls.DarkLabel();
            this.tiffSettings_comboBox = new AltUI.Controls.DarkComboBox();
            this.ddsOutputSettings_groupBox = new AltUI.Controls.DarkGroupBox();
            this.label17 = new AltUI.Controls.DarkLabel();
            this.label16 = new AltUI.Controls.DarkLabel();
            this.label15 = new AltUI.Controls.DarkLabel();
            this.ddsIsCubemap_checkBox = new AltUI.Controls.DarkCheckBox();
            this.ddsGenerateMipmaps_checkBox = new AltUI.Controls.DarkCheckBox();
            this.ddsCompresion_comboBox = new AltUI.Controls.DarkComboBox();
            this.ddsFileFormat_comboBox = new AltUI.Controls.DarkComboBox();
            this.ddsTextureType_comboBox = new AltUI.Controls.DarkComboBox();
            this.darkGroupBox1 = new AltUI.Controls.DarkGroupBox();
            this.deleteFormat_button = new AltUI.Controls.DarkButton();
            this.newFormatName_textBox = new AltUI.Controls.DarkTextBox();
            this.formats_listBox = new AltUI.Controls.DarkListBox();
            this.loadFormat_button = new AltUI.Controls.DarkButton();
            this.saveFormat_button = new AltUI.Controls.DarkButton();
            this.preserveFormat_checkBox = new AltUI.Controls.DarkCheckBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webpQuality_numericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pngCompression_numericUpDown)).BeginInit();
            this.tiffSetting_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiffJpegQuality_numericUpDown)).BeginInit();
            this.ddsOutputSettings_groupBox.SuspendLayout();
            this.darkGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newFormatExtension_comboBox
            // 
            this.newFormatExtension_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newFormatExtension_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.newFormatExtension_comboBox.FormattingEnabled = true;
            this.newFormatExtension_comboBox.Location = new System.Drawing.Point(732, 505);
            this.newFormatExtension_comboBox.Name = "newFormatExtension_comboBox";
            this.newFormatExtension_comboBox.Size = new System.Drawing.Size(149, 24);
            this.newFormatExtension_comboBox.TabIndex = 51;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(742, 487);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 15);
            this.label23.TabIndex = 49;
            this.label23.Text = "Extension";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webpLossless_checkBox);
            this.groupBox2.Controls.Add(this.webpQuality_numericUpDown);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.webpPreset_comboBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(17, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 107);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WEBP";
            // 
            // webpLossless_checkBox
            // 
            this.webpLossless_checkBox.AutoSize = true;
            this.webpLossless_checkBox.Location = new System.Drawing.Point(14, 23);
            this.webpLossless_checkBox.Name = "webpLossless_checkBox";
            this.webpLossless_checkBox.Offset = 1;
            this.webpLossless_checkBox.Size = new System.Drawing.Size(68, 19);
            this.webpLossless_checkBox.TabIndex = 47;
            this.webpLossless_checkBox.Text = "Lossless";
            // 
            // webpQuality_numericUpDown
            // 
            this.webpQuality_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.webpQuality_numericUpDown.Location = new System.Drawing.Point(142, 73);
            this.webpQuality_numericUpDown.Name = "webpQuality_numericUpDown";
            this.webpQuality_numericUpDown.Size = new System.Drawing.Size(48, 23);
            this.webpQuality_numericUpDown.TabIndex = 46;
            this.webpQuality_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.webpQuality_numericUpDown.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(11, 73);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 15);
            this.label26.TabIndex = 2;
            this.label26.Text = "Quality";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(10, 48);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 15);
            this.label27.TabIndex = 2;
            this.label27.Text = "Compression";
            // 
            // webpPreset_comboBox
            // 
            this.webpPreset_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.webpPreset_comboBox.FormattingEnabled = true;
            this.webpPreset_comboBox.Location = new System.Drawing.Point(142, 42);
            this.webpPreset_comboBox.Name = "webpPreset_comboBox";
            this.webpPreset_comboBox.Size = new System.Drawing.Size(85, 24);
            this.webpPreset_comboBox.TabIndex = 45;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pngCompression_numericUpDown);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Location = new System.Drawing.Point(17, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 59);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PNG";
            // 
            // pngCompression_numericUpDown
            // 
            this.pngCompression_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pngCompression_numericUpDown.Location = new System.Drawing.Point(142, 22);
            this.pngCompression_numericUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.pngCompression_numericUpDown.Name = "pngCompression_numericUpDown";
            this.pngCompression_numericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pngCompression_numericUpDown.Size = new System.Drawing.Size(48, 23);
            this.pngCompression_numericUpDown.TabIndex = 44;
            this.pngCompression_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 15);
            this.label18.TabIndex = 43;
            this.label18.Text = "Compression factor";
            // 
            // tiffSetting_groupBox
            // 
            this.tiffSetting_groupBox.Controls.Add(this.tiffJpegQuality_numericUpDown);
            this.tiffSetting_groupBox.Controls.Add(this.label25);
            this.tiffSetting_groupBox.Controls.Add(this.label24);
            this.tiffSetting_groupBox.Controls.Add(this.tiffSettings_comboBox);
            this.tiffSetting_groupBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tiffSetting_groupBox.Location = new System.Drawing.Point(17, 243);
            this.tiffSetting_groupBox.Name = "tiffSetting_groupBox";
            this.tiffSetting_groupBox.Size = new System.Drawing.Size(396, 83);
            this.tiffSetting_groupBox.TabIndex = 60;
            this.tiffSetting_groupBox.TabStop = false;
            this.tiffSetting_groupBox.Text = "TIFF";
            // 
            // tiffJpegQuality_numericUpDown
            // 
            this.tiffJpegQuality_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tiffJpegQuality_numericUpDown.Location = new System.Drawing.Point(142, 49);
            this.tiffJpegQuality_numericUpDown.Name = "tiffJpegQuality_numericUpDown";
            this.tiffJpegQuality_numericUpDown.Size = new System.Drawing.Size(48, 23);
            this.tiffJpegQuality_numericUpDown.TabIndex = 46;
            this.tiffJpegQuality_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tiffJpegQuality_numericUpDown.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(11, 51);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 15);
            this.label25.TabIndex = 2;
            this.label25.Text = "Jpeg quality";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(117, 15);
            this.label24.TabIndex = 2;
            this.label24.Text = "Compresion method";
            // 
            // tiffSettings_comboBox
            // 
            this.tiffSettings_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.tiffSettings_comboBox.FormattingEnabled = true;
            this.tiffSettings_comboBox.Location = new System.Drawing.Point(142, 17);
            this.tiffSettings_comboBox.Name = "tiffSettings_comboBox";
            this.tiffSettings_comboBox.Size = new System.Drawing.Size(86, 24);
            this.tiffSettings_comboBox.TabIndex = 45;
            // 
            // ddsOutputSettings_groupBox
            // 
            this.ddsOutputSettings_groupBox.Controls.Add(this.label17);
            this.ddsOutputSettings_groupBox.Controls.Add(this.label16);
            this.ddsOutputSettings_groupBox.Controls.Add(this.label15);
            this.ddsOutputSettings_groupBox.Controls.Add(this.ddsIsCubemap_checkBox);
            this.ddsOutputSettings_groupBox.Controls.Add(this.ddsGenerateMipmaps_checkBox);
            this.ddsOutputSettings_groupBox.Controls.Add(this.ddsCompresion_comboBox);
            this.ddsOutputSettings_groupBox.Controls.Add(this.ddsFileFormat_comboBox);
            this.ddsOutputSettings_groupBox.Controls.Add(this.ddsTextureType_comboBox);
            this.ddsOutputSettings_groupBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ddsOutputSettings_groupBox.Location = new System.Drawing.Point(17, 340);
            this.ddsOutputSettings_groupBox.Name = "ddsOutputSettings_groupBox";
            this.ddsOutputSettings_groupBox.Size = new System.Drawing.Size(396, 196);
            this.ddsOutputSettings_groupBox.TabIndex = 57;
            this.ddsOutputSettings_groupBox.TabStop = false;
            this.ddsOutputSettings_groupBox.Text = "DDS";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 15);
            this.label17.TabIndex = 3;
            this.label17.Text = "BC7 Compression";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Compression";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Texture type";
            // 
            // ddsIsCubemap_checkBox
            // 
            this.ddsIsCubemap_checkBox.AutoSize = true;
            this.ddsIsCubemap_checkBox.Checked = true;
            this.ddsIsCubemap_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ddsIsCubemap_checkBox.Location = new System.Drawing.Point(11, 156);
            this.ddsIsCubemap_checkBox.Name = "ddsIsCubemap_checkBox";
            this.ddsIsCubemap_checkBox.Offset = 1;
            this.ddsIsCubemap_checkBox.Size = new System.Drawing.Size(117, 19);
            this.ddsIsCubemap_checkBox.TabIndex = 1;
            this.ddsIsCubemap_checkBox.Text = "Save as cubemap";
            // 
            // ddsGenerateMipmaps_checkBox
            // 
            this.ddsGenerateMipmaps_checkBox.AutoSize = true;
            this.ddsGenerateMipmaps_checkBox.Checked = true;
            this.ddsGenerateMipmaps_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ddsGenerateMipmaps_checkBox.Location = new System.Drawing.Point(11, 129);
            this.ddsGenerateMipmaps_checkBox.Name = "ddsGenerateMipmaps_checkBox";
            this.ddsGenerateMipmaps_checkBox.Offset = 1;
            this.ddsGenerateMipmaps_checkBox.Size = new System.Drawing.Size(126, 19);
            this.ddsGenerateMipmaps_checkBox.TabIndex = 1;
            this.ddsGenerateMipmaps_checkBox.Text = "Generate mipmaps";
            // 
            // ddsCompresion_comboBox
            // 
            this.ddsCompresion_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ddsCompresion_comboBox.FormattingEnabled = true;
            this.ddsCompresion_comboBox.Location = new System.Drawing.Point(142, 90);
            this.ddsCompresion_comboBox.Name = "ddsCompresion_comboBox";
            this.ddsCompresion_comboBox.Size = new System.Drawing.Size(184, 24);
            this.ddsCompresion_comboBox.TabIndex = 0;
            // 
            // ddsFileFormat_comboBox
            // 
            this.ddsFileFormat_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ddsFileFormat_comboBox.FormattingEnabled = true;
            this.ddsFileFormat_comboBox.Location = new System.Drawing.Point(142, 59);
            this.ddsFileFormat_comboBox.Name = "ddsFileFormat_comboBox";
            this.ddsFileFormat_comboBox.Size = new System.Drawing.Size(184, 24);
            this.ddsFileFormat_comboBox.TabIndex = 0;
            // 
            // ddsTextureType_comboBox
            // 
            this.ddsTextureType_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ddsTextureType_comboBox.FormattingEnabled = true;
            this.ddsTextureType_comboBox.Location = new System.Drawing.Point(142, 28);
            this.ddsTextureType_comboBox.Name = "ddsTextureType_comboBox";
            this.ddsTextureType_comboBox.Size = new System.Drawing.Size(184, 24);
            this.ddsTextureType_comboBox.TabIndex = 0;
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.Controls.Add(this.preserveFormat_checkBox);
            this.darkGroupBox1.Controls.Add(this.groupBox2);
            this.darkGroupBox1.Controls.Add(this.groupBox3);
            this.darkGroupBox1.Controls.Add(this.tiffSetting_groupBox);
            this.darkGroupBox1.Controls.Add(this.ddsOutputSettings_groupBox);
            this.darkGroupBox1.Location = new System.Drawing.Point(20, 20);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Size = new System.Drawing.Size(494, 626);
            this.darkGroupBox1.TabIndex = 61;
            this.darkGroupBox1.TabStop = false;
            // 
            // deleteFormat_button
            // 
            this.deleteFormat_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteFormat_button.FlatBottom = false;
            this.deleteFormat_button.FlatTop = false;
            this.deleteFormat_button.HoldColour = false;
            this.deleteFormat_button.Location = new System.Drawing.Point(577, 716);
            this.deleteFormat_button.Name = "deleteFormat_button";
            this.deleteFormat_button.Padding = new System.Windows.Forms.Padding(5);
            this.deleteFormat_button.Size = new System.Drawing.Size(149, 31);
            this.deleteFormat_button.TabIndex = 66;
            this.deleteFormat_button.Text = "Delete";
            // 
            // newFormatName_textBox
            // 
            this.newFormatName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newFormatName_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.newFormatName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newFormatName_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.newFormatName_textBox.Location = new System.Drawing.Point(577, 614);
            this.newFormatName_textBox.Name = "newFormatName_textBox";
            this.newFormatName_textBox.Size = new System.Drawing.Size(149, 23);
            this.newFormatName_textBox.TabIndex = 65;
            // 
            // formats_listBox
            // 
            this.formats_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.formats_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.formats_listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formats_listBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.formats_listBox.FormattingEnabled = true;
            this.formats_listBox.ItemHeight = 15;
            this.formats_listBox.Location = new System.Drawing.Point(732, 535);
            this.formats_listBox.Name = "formats_listBox";
            this.formats_listBox.Size = new System.Drawing.Size(149, 212);
            this.formats_listBox.TabIndex = 62;
            // 
            // loadFormat_button
            // 
            this.loadFormat_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadFormat_button.FlatBottom = false;
            this.loadFormat_button.FlatTop = false;
            this.loadFormat_button.HoldColour = false;
            this.loadFormat_button.Location = new System.Drawing.Point(577, 680);
            this.loadFormat_button.Name = "loadFormat_button";
            this.loadFormat_button.Padding = new System.Windows.Forms.Padding(5);
            this.loadFormat_button.Size = new System.Drawing.Size(149, 31);
            this.loadFormat_button.TabIndex = 64;
            this.loadFormat_button.Text = "Load";
            // 
            // saveFormat_button
            // 
            this.saveFormat_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveFormat_button.FlatBottom = false;
            this.saveFormat_button.FlatTop = false;
            this.saveFormat_button.HoldColour = false;
            this.saveFormat_button.Location = new System.Drawing.Point(577, 643);
            this.saveFormat_button.Name = "saveFormat_button";
            this.saveFormat_button.Padding = new System.Windows.Forms.Padding(5);
            this.saveFormat_button.Size = new System.Drawing.Size(149, 31);
            this.saveFormat_button.TabIndex = 63;
            this.saveFormat_button.Text = "Save";
            // 
            // preserveFormat_checkBox
            // 
            this.preserveFormat_checkBox.AutoSize = true;
            this.preserveFormat_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.preserveFormat_checkBox.Location = new System.Drawing.Point(25, 22);
            this.preserveFormat_checkBox.Name = "preserveFormat_checkBox";
            this.preserveFormat_checkBox.Offset = 1;
            this.preserveFormat_checkBox.Size = new System.Drawing.Size(113, 17);
            this.preserveFormat_checkBox.TabIndex = 61;
            this.preserveFormat_checkBox.Text = "Use original format";
            // 
            // FormatsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newFormatExtension_comboBox);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.deleteFormat_button);
            this.Controls.Add(this.newFormatName_textBox);
            this.Controls.Add(this.formats_listBox);
            this.Controls.Add(this.loadFormat_button);
            this.Controls.Add(this.saveFormat_button);
            this.Controls.Add(this.darkGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormatsTab";
            this.Size = new System.Drawing.Size(884, 750);
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
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        public AltUI.Controls.DarkComboBox newFormatExtension_comboBox;
        public AltUI.Controls.DarkLabel label23;
        public AltUI.Controls.DarkGroupBox groupBox2;
        public AltUI.Controls.DarkCheckBox webpLossless_checkBox;
        public AltUI.Controls.DarkNumericUpDown webpQuality_numericUpDown;
        public AltUI.Controls.DarkLabel label26;
        public AltUI.Controls.DarkLabel label27;
        public AltUI.Controls.DarkComboBox webpPreset_comboBox;
        public AltUI.Controls.DarkGroupBox groupBox3;
        public AltUI.Controls.DarkNumericUpDown pngCompression_numericUpDown;
        public AltUI.Controls.DarkLabel label18;
        public AltUI.Controls.DarkGroupBox tiffSetting_groupBox;
        public AltUI.Controls.DarkNumericUpDown tiffJpegQuality_numericUpDown;
        public AltUI.Controls.DarkLabel label25;
        public AltUI.Controls.DarkLabel label24;
        public AltUI.Controls.DarkComboBox tiffSettings_comboBox;
        public AltUI.Controls.DarkGroupBox ddsOutputSettings_groupBox;
        public AltUI.Controls.DarkLabel label17;
        public AltUI.Controls.DarkLabel label16;
        public AltUI.Controls.DarkLabel label15;
        public AltUI.Controls.DarkCheckBox ddsIsCubemap_checkBox;
        public AltUI.Controls.DarkCheckBox ddsGenerateMipmaps_checkBox;
        public AltUI.Controls.DarkComboBox ddsCompresion_comboBox;
        public AltUI.Controls.DarkComboBox ddsFileFormat_comboBox;
        public AltUI.Controls.DarkComboBox ddsTextureType_comboBox;
        private AltUI.Controls.DarkGroupBox darkGroupBox1;
        public AltUI.Controls.DarkButton deleteFormat_button;
        public AltUI.Controls.DarkTextBox newFormatName_textBox;
        public AltUI.Controls.DarkListBox formats_listBox;
        public AltUI.Controls.DarkButton loadFormat_button;
        public AltUI.Controls.DarkButton saveFormat_button;
        public AltUI.Controls.DarkCheckBox preserveFormat_checkBox;
    }
}
