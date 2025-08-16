namespace ImageEnhancingUtility.Winforms
{
    partial class SettingsUiTab
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
            this.groupBox8 = new AltUI.Controls.DarkGroupBox();
            this.topMost_checkBox = new AltUI.Controls.DarkCheckBox();
            this.darkTheme_сheckBox = new AltUI.Controls.DarkCheckBox();
            this.showDebugInfo_checkBox = new AltUI.Controls.DarkCheckBox();
            this.showPopups_checkBox = new AltUI.Controls.DarkCheckBox();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.topMost_checkBox);
            this.groupBox8.Controls.Add(this.darkTheme_сheckBox);
            this.groupBox8.Controls.Add(this.showDebugInfo_checkBox);
            this.groupBox8.Controls.Add(this.showPopups_checkBox);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox8.Location = new System.Drawing.Point(20, 20);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(187, 138);
            this.groupBox8.TabIndex = 99;
            this.groupBox8.TabStop = false;
            // 
            // topMost_checkBox
            // 
            this.topMost_checkBox.AutoSize = true;
            this.topMost_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topMost_checkBox.Location = new System.Drawing.Point(14, 15);
            this.topMost_checkBox.Name = "topMost_checkBox";
            this.topMost_checkBox.Offset = 1;
            this.topMost_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.topMost_checkBox.Size = new System.Drawing.Size(80, 17);
            this.topMost_checkBox.TabIndex = 38;
            this.topMost_checkBox.Text = "Stay on top";
            // 
            // darkTheme_сheckBox
            // 
            this.darkTheme_сheckBox.AutoSize = true;
            this.darkTheme_сheckBox.Location = new System.Drawing.Point(14, 85);
            this.darkTheme_сheckBox.Name = "darkTheme_сheckBox";
            this.darkTheme_сheckBox.Offset = 1;
            this.darkTheme_сheckBox.Size = new System.Drawing.Size(87, 19);
            this.darkTheme_сheckBox.TabIndex = 56;
            this.darkTheme_сheckBox.Text = "Dark theme";
            // 
            // showDebugInfo_checkBox
            // 
            this.showDebugInfo_checkBox.AutoSize = true;
            this.showDebugInfo_checkBox.Location = new System.Drawing.Point(14, 60);
            this.showDebugInfo_checkBox.Name = "showDebugInfo_checkBox";
            this.showDebugInfo_checkBox.Offset = 1;
            this.showDebugInfo_checkBox.Size = new System.Drawing.Size(116, 19);
            this.showDebugInfo_checkBox.TabIndex = 56;
            this.showDebugInfo_checkBox.Text = "Show debug info";
            // 
            // showPopups_checkBox
            // 
            this.showPopups_checkBox.AutoSize = true;
            this.showPopups_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPopups_checkBox.Location = new System.Drawing.Point(14, 38);
            this.showPopups_checkBox.Name = "showPopups_checkBox";
            this.showPopups_checkBox.Offset = 1;
            this.showPopups_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showPopups_checkBox.Size = new System.Drawing.Size(145, 17);
            this.showPopups_checkBox.TabIndex = 38;
            this.showPopups_checkBox.Text = "Show popup notifications";
            // 
            // SettingsUiTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox8);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingsUiTab";
            this.Size = new System.Drawing.Size(549, 289);
            this.Load += new System.EventHandler(this.DockDocument_Load);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        public AltUI.Controls.DarkGroupBox groupBox8;
        public AltUI.Controls.DarkCheckBox topMost_checkBox;
        public AltUI.Controls.DarkCheckBox darkTheme_сheckBox;
        public AltUI.Controls.DarkCheckBox showDebugInfo_checkBox;
        public AltUI.Controls.DarkCheckBox showPopups_checkBox;
    }
}
