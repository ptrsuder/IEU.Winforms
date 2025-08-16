namespace ImageEnhancingUtility.Winforms
{
    partial class SettingsMiscTab
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
            this.groupBox14 = new AltUI.Controls.DarkGroupBox();
            this.condaEnvName_textBox = new AltUI.Controls.DarkTextBox();
            this.createMemoryImage_checkBox = new AltUI.Controls.DarkCheckBox();
            this.label34 = new AltUI.Controls.DarkLabel();
            this.monitorVram_checkBox = new AltUI.Controls.DarkCheckBox();
            this.monitorFrequency_numericUpDown = new AltUI.Controls.DarkNumericUpDown();
            this.deleteResults_checkBox = new AltUI.Controls.DarkCheckBox();
            this.useCondaEnv_checkBox = new AltUI.Controls.DarkCheckBox();
            this.showDebugInfo_checkBox = new AltUI.Controls.DarkCheckBox();
            this.showIEU_button = new AltUI.Controls.DarkButton();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorFrequency_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.condaEnvName_textBox);
            this.groupBox14.Controls.Add(this.showDebugInfo_checkBox);
            this.groupBox14.Controls.Add(this.createMemoryImage_checkBox);
            this.groupBox14.Controls.Add(this.label34);
            this.groupBox14.Controls.Add(this.monitorVram_checkBox);
            this.groupBox14.Controls.Add(this.monitorFrequency_numericUpDown);
            this.groupBox14.Controls.Add(this.deleteResults_checkBox);
            this.groupBox14.Controls.Add(this.useCondaEnv_checkBox);
            this.groupBox14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox14.Location = new System.Drawing.Point(20, 20);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(322, 178);
            this.groupBox14.TabIndex = 104;
            this.groupBox14.TabStop = false;
            // 
            // condaEnvName_textBox
            // 
            this.condaEnvName_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.condaEnvName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.condaEnvName_textBox.Enabled = false;
            this.condaEnvName_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.condaEnvName_textBox.Location = new System.Drawing.Point(161, 100);
            this.condaEnvName_textBox.Name = "condaEnvName_textBox";
            this.condaEnvName_textBox.Size = new System.Drawing.Size(149, 23);
            this.condaEnvName_textBox.TabIndex = 52;
            // 
            // createMemoryImage_checkBox
            // 
            this.createMemoryImage_checkBox.AutoSize = true;
            this.createMemoryImage_checkBox.Location = new System.Drawing.Point(14, 46);
            this.createMemoryImage_checkBox.Name = "createMemoryImage_checkBox";
            this.createMemoryImage_checkBox.Offset = 1;
            this.createMemoryImage_checkBox.Size = new System.Drawing.Size(190, 19);
            this.createMemoryImage_checkBox.TabIndex = 31;
            this.createMemoryImage_checkBox.Text = "Create max resolution tile in LR";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(227, 76);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(23, 15);
            this.label34.TabIndex = 59;
            this.label34.Text = "ms";
            // 
            // monitorVram_checkBox
            // 
            this.monitorVram_checkBox.AutoSize = true;
            this.monitorVram_checkBox.Location = new System.Drawing.Point(14, 73);
            this.monitorVram_checkBox.Name = "monitorVram_checkBox";
            this.monitorVram_checkBox.Offset = 1;
            this.monitorVram_checkBox.Size = new System.Drawing.Size(147, 19);
            this.monitorVram_checkBox.TabIndex = 58;
            this.monitorVram_checkBox.Text = "Log VRAM usage every";
            // 
            // monitorFrequency_numericUpDown
            // 
            this.monitorFrequency_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monitorFrequency_numericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.monitorFrequency_numericUpDown.Location = new System.Drawing.Point(161, 73);
            this.monitorFrequency_numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.monitorFrequency_numericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.monitorFrequency_numericUpDown.Name = "monitorFrequency_numericUpDown";
            this.monitorFrequency_numericUpDown.Size = new System.Drawing.Size(66, 23);
            this.monitorFrequency_numericUpDown.TabIndex = 32;
            this.monitorFrequency_numericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // deleteResults_checkBox
            // 
            this.deleteResults_checkBox.AutoSize = true;
            this.deleteResults_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteResults_checkBox.Location = new System.Drawing.Point(14, 20);
            this.deleteResults_checkBox.Name = "deleteResults_checkBox";
            this.deleteResults_checkBox.Offset = 1;
            this.deleteResults_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteResults_checkBox.Size = new System.Drawing.Size(146, 17);
            this.deleteResults_checkBox.TabIndex = 38;
            this.deleteResults_checkBox.Text = "Delete results after merge";
            // 
            // useCondaEnv_checkBox
            // 
            this.useCondaEnv_checkBox.AutoSize = true;
            this.useCondaEnv_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.useCondaEnv_checkBox.Location = new System.Drawing.Point(14, 101);
            this.useCondaEnv_checkBox.Name = "useCondaEnv_checkBox";
            this.useCondaEnv_checkBox.Offset = 1;
            this.useCondaEnv_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.useCondaEnv_checkBox.Size = new System.Drawing.Size(133, 17);
            this.useCondaEnv_checkBox.TabIndex = 38;
            this.useCondaEnv_checkBox.Text = "Use conda enviroment";
            // 
            // showDebugInfo_checkBox
            // 
            this.showDebugInfo_checkBox.AutoSize = true;
            this.showDebugInfo_checkBox.Location = new System.Drawing.Point(14, 131);
            this.showDebugInfo_checkBox.Name = "showDebugInfo_checkBox";
            this.showDebugInfo_checkBox.Offset = 1;
            this.showDebugInfo_checkBox.Size = new System.Drawing.Size(116, 19);
            this.showDebugInfo_checkBox.TabIndex = 105;
            this.showDebugInfo_checkBox.Text = "Show debug info";
            // 
            // showIEU_button
            // 
            this.showIEU_button.FlatBottom = false;
            this.showIEU_button.FlatTop = false;
            this.showIEU_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.showIEU_button.HoldColour = false;
            this.showIEU_button.Location = new System.Drawing.Point(348, 22);
            this.showIEU_button.Name = "showIEU_button";
            this.showIEU_button.Padding = new System.Windows.Forms.Padding(5);
            this.showIEU_button.Size = new System.Drawing.Size(150, 61);
            this.showIEU_button.TabIndex = 106;
            this.showIEU_button.Text = "All settings";
            // 
            // SettingsMiscTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showIEU_button);
            this.Controls.Add(this.groupBox14);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingsMiscTab";
            this.Size = new System.Drawing.Size(750, 750);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorFrequency_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        public AltUI.Controls.DarkGroupBox groupBox14;
        public AltUI.Controls.DarkTextBox condaEnvName_textBox;
        public AltUI.Controls.DarkCheckBox createMemoryImage_checkBox;
        public AltUI.Controls.DarkLabel label34;
        public AltUI.Controls.DarkCheckBox monitorVram_checkBox;
        public AltUI.Controls.DarkNumericUpDown monitorFrequency_numericUpDown;
        public AltUI.Controls.DarkCheckBox deleteResults_checkBox;
        public AltUI.Controls.DarkCheckBox useCondaEnv_checkBox;
        public AltUI.Controls.DarkCheckBox showDebugInfo_checkBox;
        public AltUI.Controls.DarkButton showIEU_button;
    }
}
