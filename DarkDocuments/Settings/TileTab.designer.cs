namespace ImageEnhancingUtility.Winforms
{
    partial class SettingsTileTab
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
            this.label9 = new AltUI.Controls.DarkLabel();
            this.maxTileHeight_numericUpDown = new AltUI.Controls.DarkNumericUpDown();
            this.maxTileWidth_numericUpDown = new AltUI.Controls.DarkNumericUpDown();
            this.autoSetTileSize_checkBox = new AltUI.Controls.DarkCheckBox();
            this.label36 = new AltUI.Controls.DarkLabel();
            this.label6 = new AltUI.Controls.DarkLabel();
            this.tilesPadding_numericUpDown = new AltUI.Controls.DarkNumericUpDown();
            this.overlapSize_numericUpDown = new AltUI.Controls.DarkNumericUpDown();
            this.label5 = new AltUI.Controls.DarkLabel();
            this.maxTileResolution_numericUpDown = new AltUI.Controls.DarkNumericUpDown();
            this.seamlessTextures_checkBox = new AltUI.Controls.DarkCheckBox();
            this.darkGroupBox1 = new AltUI.Controls.DarkGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileHeight_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileWidth_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilesPadding_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overlapSize_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileResolution_numericUpDown)).BeginInit();
            this.darkGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(303, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 15);
            this.label9.TabIndex = 100;
            this.label9.Text = "X";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxTileHeight_numericUpDown
            // 
            this.maxTileHeight_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxTileHeight_numericUpDown.Location = new System.Drawing.Point(317, 19);
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
            this.maxTileHeight_numericUpDown.Size = new System.Drawing.Size(69, 23);
            this.maxTileHeight_numericUpDown.TabIndex = 98;
            this.maxTileHeight_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxTileHeight_numericUpDown.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // maxTileWidth_numericUpDown
            // 
            this.maxTileWidth_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxTileWidth_numericUpDown.Location = new System.Drawing.Point(233, 19);
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
            this.maxTileWidth_numericUpDown.Size = new System.Drawing.Size(69, 23);
            this.maxTileWidth_numericUpDown.TabIndex = 99;
            this.maxTileWidth_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxTileWidth_numericUpDown.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // autoSetTileSize_checkBox
            // 
            this.autoSetTileSize_checkBox.AutoSize = true;
            this.autoSetTileSize_checkBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.autoSetTileSize_checkBox.Location = new System.Drawing.Point(397, 21);
            this.autoSetTileSize_checkBox.Name = "autoSetTileSize_checkBox";
            this.autoSetTileSize_checkBox.Offset = 1;
            this.autoSetTileSize_checkBox.Size = new System.Drawing.Size(153, 19);
            this.autoSetTileSize_checkBox.TabIndex = 97;
            this.autoSetTileSize_checkBox.Text = "Auto set tile dimensions";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label36.Location = new System.Drawing.Point(15, 78);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(77, 15);
            this.label36.TabIndex = 95;
            this.label36.Text = "Tiles padding";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(15, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 96;
            this.label6.Text = "Tiles overlap";
            // 
            // tilesPadding_numericUpDown
            // 
            this.tilesPadding_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tilesPadding_numericUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.tilesPadding_numericUpDown.Location = new System.Drawing.Point(107, 74);
            this.tilesPadding_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tilesPadding_numericUpDown.Name = "tilesPadding_numericUpDown";
            this.tilesPadding_numericUpDown.Size = new System.Drawing.Size(52, 23);
            this.tilesPadding_numericUpDown.TabIndex = 93;
            this.tilesPadding_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // overlapSize_numericUpDown
            // 
            this.overlapSize_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overlapSize_numericUpDown.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.overlapSize_numericUpDown.Location = new System.Drawing.Point(107, 45);
            this.overlapSize_numericUpDown.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.overlapSize_numericUpDown.Name = "overlapSize_numericUpDown";
            this.overlapSize_numericUpDown.Size = new System.Drawing.Size(52, 23);
            this.overlapSize_numericUpDown.TabIndex = 94;
            this.overlapSize_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.overlapSize_numericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(15, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 92;
            this.label5.Text = "Max tile WxH";
            // 
            // maxTileResolution_numericUpDown
            // 
            this.maxTileResolution_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxTileResolution_numericUpDown.Enabled = false;
            this.maxTileResolution_numericUpDown.Location = new System.Drawing.Point(107, 19);
            this.maxTileResolution_numericUpDown.Maximum = new decimal(new int[] {
            16777216,
            0,
            0,
            0});
            this.maxTileResolution_numericUpDown.Name = "maxTileResolution_numericUpDown";
            this.maxTileResolution_numericUpDown.Size = new System.Drawing.Size(120, 23);
            this.maxTileResolution_numericUpDown.TabIndex = 91;
            this.maxTileResolution_numericUpDown.ThousandsSeparator = true;
            this.maxTileResolution_numericUpDown.Value = new decimal(new int[] {
            204800,
            0,
            0,
            0});
            // 
            // seamlessTextures_checkBox
            // 
            this.seamlessTextures_checkBox.AutoSize = true;
            this.seamlessTextures_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.seamlessTextures_checkBox.Location = new System.Drawing.Point(18, 113);
            this.seamlessTextures_checkBox.Name = "seamlessTextures_checkBox";
            this.seamlessTextures_checkBox.Offset = 1;
            this.seamlessTextures_checkBox.Size = new System.Drawing.Size(139, 17);
            this.seamlessTextures_checkBox.TabIndex = 101;
            this.seamlessTextures_checkBox.Text = "Seamless (tiled) textures";
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.Controls.Add(this.autoSetTileSize_checkBox);
            this.darkGroupBox1.Controls.Add(this.seamlessTextures_checkBox);
            this.darkGroupBox1.Controls.Add(this.maxTileResolution_numericUpDown);
            this.darkGroupBox1.Controls.Add(this.label9);
            this.darkGroupBox1.Controls.Add(this.label5);
            this.darkGroupBox1.Controls.Add(this.maxTileHeight_numericUpDown);
            this.darkGroupBox1.Controls.Add(this.overlapSize_numericUpDown);
            this.darkGroupBox1.Controls.Add(this.maxTileWidth_numericUpDown);
            this.darkGroupBox1.Controls.Add(this.tilesPadding_numericUpDown);
            this.darkGroupBox1.Controls.Add(this.label6);
            this.darkGroupBox1.Controls.Add(this.label36);
            this.darkGroupBox1.Location = new System.Drawing.Point(20, 20);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Size = new System.Drawing.Size(590, 446);
            this.darkGroupBox1.TabIndex = 102;
            this.darkGroupBox1.TabStop = false;
            // 
            // SettingsTileTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.darkGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingsTileTab";
            this.Size = new System.Drawing.Size(750, 750);
            this.Load += new System.EventHandler(this.DockDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxTileHeight_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileWidth_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilesPadding_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overlapSize_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileResolution_numericUpDown)).EndInit();
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        public AltUI.Controls.DarkLabel label9;
        public AltUI.Controls.DarkNumericUpDown maxTileHeight_numericUpDown;
        public AltUI.Controls.DarkNumericUpDown maxTileWidth_numericUpDown;
        public AltUI.Controls.DarkCheckBox autoSetTileSize_checkBox;
        public AltUI.Controls.DarkLabel label36;
        public AltUI.Controls.DarkLabel label6;
        public AltUI.Controls.DarkNumericUpDown tilesPadding_numericUpDown;
        public AltUI.Controls.DarkNumericUpDown overlapSize_numericUpDown;
        public AltUI.Controls.DarkLabel label5;
        public AltUI.Controls.DarkNumericUpDown maxTileResolution_numericUpDown;
        public AltUI.Controls.DarkCheckBox seamlessTextures_checkBox;
        private AltUI.Controls.DarkGroupBox darkGroupBox1;
    }
}
