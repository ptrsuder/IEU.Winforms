using System.Windows.Forms;
using AltUI.Controls;

namespace ImageEnhancingUtility.Winforms
{
    partial class DarkDockFormatsTab
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
            this.textBox1 = new System.Windows.Forms.TextBox();            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webpLossless_checkBox = new DarkCheckBox();
            this.webpQuality_numericUpDown = new DarkNumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.webpPreset_comboBox = new DarkComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pngCompression_numericUpDown = new DarkNumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.tiffSetting_groupBox = new System.Windows.Forms.GroupBox();
            this.tiffJpegQuality_numericUpDown = new DarkNumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tiffSettings_comboBox = new DarkComboBox();
            this.ddsOutputSettings_groupBox = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ddsIsCubemap_checkBox = new DarkCheckBox();
            this.ddsGenerateMipmaps_checkBox = new DarkCheckBox();
            this.ddsCompresion_comboBox = new DarkComboBox();
            this.ddsFileFormat_comboBox = new DarkComboBox();
            this.ddsTextureType_comboBox = new DarkComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webpQuality_numericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pngCompression_numericUpDown)).BeginInit();
            this.tiffSetting_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiffJpegQuality_numericUpDown)).BeginInit();
            this.ddsOutputSettings_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(70, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(542, 23);
            this.textBox1.TabIndex = 57;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Location = new System.Drawing.Point(70, 292);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(542, 23);
            this.textBox2.TabIndex = 58;
            this.textBox2.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(618, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 20);
            this.button2.TabIndex = 61;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label32.Location = new System.Drawing.Point(15, 270);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 15);
            this.label32.TabIndex = 59;
            this.label32.Text = "Original";
            this.label32.Visible = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label33.Location = new System.Drawing.Point(20, 294);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(39, 15);
            this.label33.TabIndex = 60;
            this.label33.Text = "Result";
            this.label33.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(618, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 20);
            this.button3.TabIndex = 62;
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
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(14, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 107);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WEBP";
            // 
            // webpLossless_checkBox
            // 
            this.webpLossless_checkBox.AutoSize = true;
            this.webpLossless_checkBox.Location = new System.Drawing.Point(9, 24);
            this.webpLossless_checkBox.Name = "webpLossless_checkBox";
            this.webpLossless_checkBox.Size = new System.Drawing.Size(65, 19);
            this.webpLossless_checkBox.TabIndex = 47;
            this.webpLossless_checkBox.Text = "Lossless";
            // 
            // webpQuality_numericUpDown
            // 
            this.webpQuality_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.webpQuality_numericUpDown.Location = new System.Drawing.Point(122, 73);
            this.webpQuality_numericUpDown.Name = "webpQuality_numericUpDown";
            this.webpQuality_numericUpDown.Size = new System.Drawing.Size(48, 23);
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
            this.label26.Size = new System.Drawing.Size(45, 15);
            this.label26.TabIndex = 2;
            this.label26.Text = "Quality";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(4, 47);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(112, 15);
            this.label27.TabIndex = 2;
            this.label27.Text = "Compression preset";
            // 
            // webpPreset_comboBox
            // 
            this.webpPreset_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.webpPreset_comboBox.FormattingEnabled = true;
            this.webpPreset_comboBox.Location = new System.Drawing.Point(122, 44);
            this.webpPreset_comboBox.Name = "webpPreset_comboBox";
            this.webpPreset_comboBox.Size = new System.Drawing.Size(85, 23);
            this.webpPreset_comboBox.TabIndex = 45;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pngCompression_numericUpDown);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Location = new System.Drawing.Point(14, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 52);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PNG";
            // 
            // pngCompression_numericUpDown
            // 
            this.pngCompression_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pngCompression_numericUpDown.Location = new System.Drawing.Point(122, 19);
            this.pngCompression_numericUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.pngCompression_numericUpDown.Name = "pngCompression_numericUpDown";
            this.pngCompression_numericUpDown.Size = new System.Drawing.Size(48, 23);
            this.pngCompression_numericUpDown.TabIndex = 44;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 21);
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
            this.tiffSetting_groupBox.Location = new System.Drawing.Point(14, 3);
            this.tiffSetting_groupBox.Name = "tiffSetting_groupBox";
            this.tiffSetting_groupBox.Size = new System.Drawing.Size(225, 73);
            this.tiffSetting_groupBox.TabIndex = 56;
            this.tiffSetting_groupBox.TabStop = false;
            this.tiffSetting_groupBox.Text = "TIFF";
            // 
            // tiffJpegQuality_numericUpDown
            // 
            this.tiffJpegQuality_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tiffJpegQuality_numericUpDown.Location = new System.Drawing.Point(122, 44);
            this.tiffJpegQuality_numericUpDown.Name = "tiffJpegQuality_numericUpDown";
            this.tiffJpegQuality_numericUpDown.Size = new System.Drawing.Size(48, 23);
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
            this.label25.Size = new System.Drawing.Size(70, 15);
            this.label25.TabIndex = 2;
            this.label25.Text = "Jpeg quality";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(117, 15);
            this.label24.TabIndex = 2;
            this.label24.Text = "Compresion method";
            // 
            // tiffSettings_comboBox
            // 
            this.tiffSettings_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tiffSettings_comboBox.FormattingEnabled = true;
            this.tiffSettings_comboBox.Location = new System.Drawing.Point(122, 15);
            this.tiffSettings_comboBox.Name = "tiffSettings_comboBox";
            this.tiffSettings_comboBox.Size = new System.Drawing.Size(86, 23);
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
            this.ddsOutputSettings_groupBox.Location = new System.Drawing.Point(374, 3);
            this.ddsOutputSettings_groupBox.Name = "ddsOutputSettings_groupBox";
            this.ddsOutputSettings_groupBox.Size = new System.Drawing.Size(344, 156);
            this.ddsOutputSettings_groupBox.TabIndex = 53;
            this.ddsOutputSettings_groupBox.TabStop = false;
            this.ddsOutputSettings_groupBox.Text = "DDS";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 15);
            this.label17.TabIndex = 3;
            this.label17.Text = "BC7 Compression";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Compression";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 31);
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
            this.ddsIsCubemap_checkBox.Location = new System.Drawing.Point(115, 133);
            this.ddsIsCubemap_checkBox.Name = "ddsIsCubemap_checkBox";
            this.ddsIsCubemap_checkBox.Size = new System.Drawing.Size(114, 19);
            this.ddsIsCubemap_checkBox.TabIndex = 1;
            this.ddsIsCubemap_checkBox.Text = "Save as cubemap";
            // 
            // ddsGenerateMipmaps_checkBox
            // 
            this.ddsGenerateMipmaps_checkBox.AutoSize = true;
            this.ddsGenerateMipmaps_checkBox.Checked = true;
            this.ddsGenerateMipmaps_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ddsGenerateMipmaps_checkBox.Location = new System.Drawing.Point(115, 110);
            this.ddsGenerateMipmaps_checkBox.Name = "ddsGenerateMipmaps_checkBox";
            this.ddsGenerateMipmaps_checkBox.Size = new System.Drawing.Size(123, 19);
            this.ddsGenerateMipmaps_checkBox.TabIndex = 1;
            this.ddsGenerateMipmaps_checkBox.Text = "Generate mipmaps";
            // 
            // ddsCompresion_comboBox
            // 
            this.ddsCompresion_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ddsCompresion_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddsCompresion_comboBox.FormattingEnabled = true;
            this.ddsCompresion_comboBox.Location = new System.Drawing.Point(115, 83);
            this.ddsCompresion_comboBox.Name = "ddsCompresion_comboBox";
            this.ddsCompresion_comboBox.Size = new System.Drawing.Size(211, 23);
            this.ddsCompresion_comboBox.TabIndex = 0;
            // 
            // ddsFileFormat_comboBox
            // 
            this.ddsFileFormat_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ddsFileFormat_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddsFileFormat_comboBox.FormattingEnabled = true;
            this.ddsFileFormat_comboBox.Location = new System.Drawing.Point(115, 56);
            this.ddsFileFormat_comboBox.Name = "ddsFileFormat_comboBox";
            this.ddsFileFormat_comboBox.Size = new System.Drawing.Size(211, 23);
            this.ddsFileFormat_comboBox.TabIndex = 0;
            // 
            // ddsTextureType_comboBox
            // 
            this.ddsTextureType_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ddsTextureType_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddsTextureType_comboBox.FormattingEnabled = true;
            this.ddsTextureType_comboBox.Location = new System.Drawing.Point(115, 28);
            this.ddsTextureType_comboBox.Name = "ddsTextureType_comboBox";
            this.ddsTextureType_comboBox.Size = new System.Drawing.Size(211, 23);
            this.ddsTextureType_comboBox.TabIndex = 0;
            // 
            // DarkDockFormatsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tiffSetting_groupBox);
            this.Controls.Add(this.ddsOutputSettings_groupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DarkDockFormatsTab";
            this.Size = new System.Drawing.Size(764, 362);
            this.Load += new System.EventHandler(this.DockDocument_Load);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label32;
        public System.Windows.Forms.Label label33;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.GroupBox groupBox2;
        public DarkCheckBox webpLossless_checkBox;
        public DarkNumericUpDown webpQuality_numericUpDown;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.Label label27;
        public DarkComboBox webpPreset_comboBox;
        public System.Windows.Forms.GroupBox groupBox3;
        public DarkNumericUpDown pngCompression_numericUpDown;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.GroupBox tiffSetting_groupBox;
        public DarkNumericUpDown tiffJpegQuality_numericUpDown;
        public System.Windows.Forms.Label label25;
        public System.Windows.Forms.Label label24;
        public DarkComboBox tiffSettings_comboBox;
        public System.Windows.Forms.GroupBox ddsOutputSettings_groupBox;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label15;
        public DarkCheckBox ddsIsCubemap_checkBox;
        public DarkCheckBox ddsGenerateMipmaps_checkBox;
        public DarkComboBox ddsCompresion_comboBox;
        public DarkComboBox ddsFileFormat_comboBox;
        public DarkComboBox ddsTextureType_comboBox;
    }
}
