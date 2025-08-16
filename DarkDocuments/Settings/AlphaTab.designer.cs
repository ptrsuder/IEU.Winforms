namespace ImageEnhancingUtility.Winforms
{
    partial class SettingsAlphaTab
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
            this.ignoreSingleColorAlpha_checkBox = new AltUI.Controls.DarkCheckBox();
            this.filterForAlpha_comboBox = new AltUI.Controls.DarkComboBox();
            this.useFilterForAlpha_checkBox = new AltUI.Controls.DarkCheckBox();
            this.modelForAlpha_comboBox = new AltUI.Controls.DarkComboBox();
            this.useDifferentModelForAlpha_checkBox = new AltUI.Controls.DarkCheckBox();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.supportRgba_checkBox);
            this.groupBox9.Controls.Add(this.ignoreAlpha_checkBox);
            this.groupBox9.Controls.Add(this.ignoreSingleColorAlpha_checkBox);
            this.groupBox9.Controls.Add(this.filterForAlpha_comboBox);
            this.groupBox9.Controls.Add(this.useFilterForAlpha_checkBox);
            this.groupBox9.Controls.Add(this.modelForAlpha_comboBox);
            this.groupBox9.Controls.Add(this.useDifferentModelForAlpha_checkBox);
            this.groupBox9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox9.Location = new System.Drawing.Point(20, 20);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(560, 289);
            this.groupBox9.TabIndex = 96;
            this.groupBox9.TabStop = false;
            // 
            // supportRgba_checkBox
            // 
            this.supportRgba_checkBox.AutoSize = true;
            this.supportRgba_checkBox.Location = new System.Drawing.Point(17, 57);
            this.supportRgba_checkBox.Name = "supportRgba_checkBox";
            this.supportRgba_checkBox.Offset = 1;
            this.supportRgba_checkBox.Size = new System.Drawing.Size(137, 19);
            this.supportRgba_checkBox.TabIndex = 25;
            this.supportRgba_checkBox.Text = "RGBA model support";
            // 
            // ignoreAlpha_checkBox
            // 
            this.ignoreAlpha_checkBox.AutoSize = true;
            this.ignoreAlpha_checkBox.Location = new System.Drawing.Point(17, 13);
            this.ignoreAlpha_checkBox.Name = "ignoreAlpha_checkBox";
            this.ignoreAlpha_checkBox.Offset = 1;
            this.ignoreAlpha_checkBox.Size = new System.Drawing.Size(137, 19);
            this.ignoreAlpha_checkBox.TabIndex = 25;
            this.ignoreAlpha_checkBox.Text = "Ignore alpha channel";
            // 
            // ignoreSingleColorAlpha_checkBox
            // 
            this.ignoreSingleColorAlpha_checkBox.AutoSize = true;
            this.ignoreSingleColorAlpha_checkBox.Location = new System.Drawing.Point(17, 34);
            this.ignoreSingleColorAlpha_checkBox.Name = "ignoreSingleColorAlpha_checkBox";
            this.ignoreSingleColorAlpha_checkBox.Offset = 1;
            this.ignoreSingleColorAlpha_checkBox.Size = new System.Drawing.Size(152, 19);
            this.ignoreSingleColorAlpha_checkBox.TabIndex = 25;
            this.ignoreSingleColorAlpha_checkBox.Text = "Ignore solid white alpha";
            // 
            // filterForAlpha_comboBox
            // 
            this.filterForAlpha_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.filterForAlpha_comboBox.Enabled = false;
            this.filterForAlpha_comboBox.FormattingEnabled = true;
            this.filterForAlpha_comboBox.Location = new System.Drawing.Point(193, 107);
            this.filterForAlpha_comboBox.Name = "filterForAlpha_comboBox";
            this.filterForAlpha_comboBox.Size = new System.Drawing.Size(110, 24);
            this.filterForAlpha_comboBox.TabIndex = 47;
            // 
            // useFilterForAlpha_checkBox
            // 
            this.useFilterForAlpha_checkBox.AutoSize = true;
            this.useFilterForAlpha_checkBox.Location = new System.Drawing.Point(17, 108);
            this.useFilterForAlpha_checkBox.Name = "useFilterForAlpha_checkBox";
            this.useFilterForAlpha_checkBox.Offset = 1;
            this.useFilterForAlpha_checkBox.Size = new System.Drawing.Size(154, 19);
            this.useFilterForAlpha_checkBox.TabIndex = 25;
            this.useFilterForAlpha_checkBox.Text = "Use resize filter for alpha";
            // 
            // modelForAlpha_comboBox
            // 
            this.modelForAlpha_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.modelForAlpha_comboBox.Enabled = false;
            this.modelForAlpha_comboBox.FormattingEnabled = true;
            this.modelForAlpha_comboBox.Location = new System.Drawing.Point(193, 79);
            this.modelForAlpha_comboBox.Name = "modelForAlpha_comboBox";
            this.modelForAlpha_comboBox.Size = new System.Drawing.Size(351, 24);
            this.modelForAlpha_comboBox.TabIndex = 47;
            // 
            // useDifferentModelForAlpha_checkBox
            // 
            this.useDifferentModelForAlpha_checkBox.AutoSize = true;
            this.useDifferentModelForAlpha_checkBox.Location = new System.Drawing.Point(17, 80);
            this.useDifferentModelForAlpha_checkBox.Name = "useDifferentModelForAlpha_checkBox";
            this.useDifferentModelForAlpha_checkBox.Offset = 1;
            this.useDifferentModelForAlpha_checkBox.Size = new System.Drawing.Size(175, 19);
            this.useDifferentModelForAlpha_checkBox.TabIndex = 25;
            this.useDifferentModelForAlpha_checkBox.Text = "Use specific model for alpha";
            // 
            // SettingsAlphaTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox9);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingsAlphaTab";
            this.Size = new System.Drawing.Size(750, 750);
            this.Load += new System.EventHandler(this.DockDocument_Load);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        public AltUI.Controls.DarkGroupBox groupBox9;
        public AltUI.Controls.DarkCheckBox supportRgba_checkBox;
        public AltUI.Controls.DarkCheckBox ignoreAlpha_checkBox;
        public AltUI.Controls.DarkCheckBox ignoreSingleColorAlpha_checkBox;
        public AltUI.Controls.DarkComboBox filterForAlpha_comboBox;
        public AltUI.Controls.DarkCheckBox useFilterForAlpha_checkBox;
        public AltUI.Controls.DarkComboBox modelForAlpha_comboBox;
        public AltUI.Controls.DarkCheckBox useDifferentModelForAlpha_checkBox;
    }
}
