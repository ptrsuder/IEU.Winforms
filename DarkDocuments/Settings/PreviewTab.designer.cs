namespace ImageEnhancingUtility.Winforms
{
    partial class SettingsPreviewTab
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
            this.comparison_colorWheel = new Cyotek.Windows.Forms.ColorWheel();
            this.outputFormatPreview_comboBox = new AltUI.Controls.DarkComboBox();
            this.darkLabel1 = new AltUI.Controls.DarkLabel();
            this.previewShowSaveDialog_checkBox = new AltUI.Controls.DarkCheckBox();
            this.darkGroupBox1 = new AltUI.Controls.DarkGroupBox();
            this.darkGroupBox2 = new AltUI.Controls.DarkGroupBox();
            this.darkGroupBox1.SuspendLayout();
            this.darkGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comparison_colorWheel
            // 
            this.comparison_colorWheel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comparison_colorWheel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(104)))));
            this.comparison_colorWheel.Location = new System.Drawing.Point(6, 22);
            this.comparison_colorWheel.Name = "comparison_colorWheel";
            this.comparison_colorWheel.Size = new System.Drawing.Size(220, 164);
            this.comparison_colorWheel.TabIndex = 2;
            // 
            // outputFormatPreview_comboBox
            // 
            this.outputFormatPreview_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.outputFormatPreview_comboBox.FormattingEnabled = true;
            this.outputFormatPreview_comboBox.Location = new System.Drawing.Point(150, 18);
            this.outputFormatPreview_comboBox.Name = "outputFormatPreview_comboBox";
            this.outputFormatPreview_comboBox.Size = new System.Drawing.Size(105, 24);
            this.outputFormatPreview_comboBox.TabIndex = 52;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.Location = new System.Drawing.Point(22, 21);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(123, 15);
            this.darkLabel1.TabIndex = 54;
            this.darkLabel1.Text = "Default output format";
            // 
            // previewShowSaveDialog_checkBox
            // 
            this.previewShowSaveDialog_checkBox.AutoSize = true;
            this.previewShowSaveDialog_checkBox.Location = new System.Drawing.Point(23, 48);
            this.previewShowSaveDialog_checkBox.Name = "previewShowSaveDialog_checkBox";
            this.previewShowSaveDialog_checkBox.Offset = 1;
            this.previewShowSaveDialog_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.previewShowSaveDialog_checkBox.Size = new System.Drawing.Size(136, 19);
            this.previewShowSaveDialog_checkBox.TabIndex = 56;
            this.previewShowSaveDialog_checkBox.Text = "Show save file dialog";
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.Controls.Add(this.comparison_colorWheel);
            this.darkGroupBox1.Location = new System.Drawing.Point(23, 76);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Size = new System.Drawing.Size(232, 199);
            this.darkGroupBox1.TabIndex = 57;
            this.darkGroupBox1.TabStop = false;
            this.darkGroupBox1.Text = "Comparison footer color";
            // 
            // darkGroupBox2
            // 
            this.darkGroupBox2.Controls.Add(this.darkGroupBox1);
            this.darkGroupBox2.Controls.Add(this.outputFormatPreview_comboBox);
            this.darkGroupBox2.Controls.Add(this.previewShowSaveDialog_checkBox);
            this.darkGroupBox2.Controls.Add(this.darkLabel1);
            this.darkGroupBox2.Location = new System.Drawing.Point(20, 20);
            this.darkGroupBox2.Name = "darkGroupBox2";
            this.darkGroupBox2.Size = new System.Drawing.Size(433, 335);
            this.darkGroupBox2.TabIndex = 58;
            this.darkGroupBox2.TabStop = false;
            // 
            // SettingsPreviewTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.darkGroupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingsPreviewTab";
            this.Size = new System.Drawing.Size(750, 750);
            this.Load += new System.EventHandler(this.SettingsPreviewTab_Load);
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox2.ResumeLayout(false);
            this.darkGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        public Cyotek.Windows.Forms.ColorWheel comparison_colorWheel;
        public AltUI.Controls.DarkComboBox outputFormatPreview_comboBox;
        private AltUI.Controls.DarkLabel darkLabel1;
        public AltUI.Controls.DarkCheckBox previewShowSaveDialog_checkBox;
        private AltUI.Controls.DarkGroupBox darkGroupBox1;
        private AltUI.Controls.DarkGroupBox darkGroupBox2;
    }
}
