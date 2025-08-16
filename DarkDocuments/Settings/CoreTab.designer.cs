namespace ImageEnhancingUtility.Winforms
{
    partial class SettingsCoreTab
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.appCoreVersion_linkLabel = new System.Windows.Forms.LinkLabel();
            this.appVersion_label = new System.Windows.Forms.LinkLabel();
            this.checkForUpdates_checkBox = new AltUI.Controls.DarkCheckBox();
            this.inMemoryMode_checkBox = new AltUI.Controls.DarkCheckBox();
            this.deletePreset_button = new AltUI.Controls.DarkButton();
            this.presetName_textBox = new AltUI.Controls.DarkTextBox();
            this.savePreset_button = new AltUI.Controls.DarkButton();
            this.presets_listBox = new AltUI.Controls.DarkListBox();
            this.loadPreset_button = new AltUI.Controls.DarkButton();
            this.darkGroupBox1 = new AltUI.Controls.DarkGroupBox();
            this.darkGroupBox2 = new AltUI.Controls.DarkGroupBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.darkGroupBox1.SuspendLayout();
            this.darkGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.appCoreVersion_linkLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.appVersion_label, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkForUpdates_checkBox, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(283, 48);
            this.tableLayoutPanel2.TabIndex = 92;
            // 
            // appCoreVersion_linkLabel
            // 
            this.appCoreVersion_linkLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.appCoreVersion_linkLabel, 2);
            this.appCoreVersion_linkLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.appCoreVersion_linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appCoreVersion_linkLabel.LinkColor = System.Drawing.Color.DodgerBlue;
            this.appCoreVersion_linkLabel.Location = new System.Drawing.Point(157, 3);
            this.appCoreVersion_linkLabel.Margin = new System.Windows.Forms.Padding(3);
            this.appCoreVersion_linkLabel.Name = "appCoreVersion_linkLabel";
            this.appCoreVersion_linkLabel.Size = new System.Drawing.Size(123, 16);
            this.appCoreVersion_linkLabel.TabIndex = 45;
            this.appCoreVersion_linkLabel.TabStop = true;
            this.appCoreVersion_linkLabel.Text = "IEU.Core v0.0.00.00";
            this.appCoreVersion_linkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // appVersion_label
            // 
            this.appVersion_label.AutoSize = true;
            this.appVersion_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.appVersion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appVersion_label.LinkColor = System.Drawing.Color.DodgerBlue;
            this.appVersion_label.Location = new System.Drawing.Point(131, 22);
            this.appVersion_label.Name = "appVersion_label";
            this.appVersion_label.Size = new System.Drawing.Size(149, 26);
            this.appVersion_label.TabIndex = 45;
            this.appVersion_label.TabStop = true;
            this.appVersion_label.Text = "IEU.Winforms v0.0.00.00";
            this.appVersion_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkForUpdates_checkBox
            // 
            this.checkForUpdates_checkBox.Checked = true;
            this.checkForUpdates_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkForUpdates_checkBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkForUpdates_checkBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkForUpdates_checkBox.Location = new System.Drawing.Point(3, 25);
            this.checkForUpdates_checkBox.Name = "checkForUpdates_checkBox";
            this.checkForUpdates_checkBox.Offset = 1;
            this.checkForUpdates_checkBox.Size = new System.Drawing.Size(122, 20);
            this.checkForUpdates_checkBox.TabIndex = 39;
            this.checkForUpdates_checkBox.Text = "Check for updates";
            // 
            // inMemoryMode_checkBox
            // 
            this.inMemoryMode_checkBox.AutoSize = true;
            this.inMemoryMode_checkBox.Location = new System.Drawing.Point(20, 17);
            this.inMemoryMode_checkBox.Name = "inMemoryMode_checkBox";
            this.inMemoryMode_checkBox.Offset = 1;
            this.inMemoryMode_checkBox.Size = new System.Drawing.Size(168, 19);
            this.inMemoryMode_checkBox.TabIndex = 56;
            this.inMemoryMode_checkBox.Text = "Process images in memory";
            // 
            // deletePreset_button
            // 
            this.deletePreset_button.FlatBottom = false;
            this.deletePreset_button.FlatTop = false;
            this.deletePreset_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deletePreset_button.HoldColour = false;
            this.deletePreset_button.Location = new System.Drawing.Point(187, 128);
            this.deletePreset_button.Name = "deletePreset_button";
            this.deletePreset_button.Padding = new System.Windows.Forms.Padding(5);
            this.deletePreset_button.Size = new System.Drawing.Size(149, 31);
            this.deletePreset_button.TabIndex = 108;
            this.deletePreset_button.Text = "Delete";
            // 
            // presetName_textBox
            // 
            this.presetName_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.presetName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.presetName_textBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.presetName_textBox.Location = new System.Drawing.Point(187, 33);
            this.presetName_textBox.Name = "presetName_textBox";
            this.presetName_textBox.Size = new System.Drawing.Size(149, 23);
            this.presetName_textBox.TabIndex = 107;
            // 
            // savePreset_button
            // 
            this.savePreset_button.FlatBottom = false;
            this.savePreset_button.FlatTop = false;
            this.savePreset_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.savePreset_button.HoldColour = false;
            this.savePreset_button.Location = new System.Drawing.Point(187, 59);
            this.savePreset_button.Name = "savePreset_button";
            this.savePreset_button.Padding = new System.Windows.Forms.Padding(5);
            this.savePreset_button.Size = new System.Drawing.Size(149, 31);
            this.savePreset_button.TabIndex = 105;
            this.savePreset_button.Text = "Save";
            // 
            // presets_listBox
            // 
            this.presets_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.presets_listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.presets_listBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.presets_listBox.FormattingEnabled = true;
            this.presets_listBox.ItemHeight = 15;
            this.presets_listBox.Location = new System.Drawing.Point(23, 33);
            this.presets_listBox.Name = "presets_listBox";
            this.presets_listBox.Size = new System.Drawing.Size(158, 152);
            this.presets_listBox.TabIndex = 104;
            // 
            // loadPreset_button
            // 
            this.loadPreset_button.FlatBottom = false;
            this.loadPreset_button.FlatTop = false;
            this.loadPreset_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.loadPreset_button.HoldColour = false;
            this.loadPreset_button.Location = new System.Drawing.Point(187, 93);
            this.loadPreset_button.Name = "loadPreset_button";
            this.loadPreset_button.Padding = new System.Windows.Forms.Padding(5);
            this.loadPreset_button.Size = new System.Drawing.Size(149, 31);
            this.loadPreset_button.TabIndex = 106;
            this.loadPreset_button.Text = "Load";
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.Controls.Add(this.deletePreset_button);
            this.darkGroupBox1.Controls.Add(this.loadPreset_button);
            this.darkGroupBox1.Controls.Add(this.presetName_textBox);
            this.darkGroupBox1.Controls.Add(this.presets_listBox);
            this.darkGroupBox1.Controls.Add(this.savePreset_button);
            this.darkGroupBox1.Location = new System.Drawing.Point(20, 52);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Size = new System.Drawing.Size(390, 207);
            this.darkGroupBox1.TabIndex = 109;
            this.darkGroupBox1.TabStop = false;
            this.darkGroupBox1.Text = "Settings Presets";
            // 
            // darkGroupBox2
            // 
            this.darkGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.darkGroupBox2.Controls.Add(this.tableLayoutPanel2);
            this.darkGroupBox2.Location = new System.Drawing.Point(440, 655);
            this.darkGroupBox2.Name = "darkGroupBox2";
            this.darkGroupBox2.Size = new System.Drawing.Size(307, 92);
            this.darkGroupBox2.TabIndex = 110;
            this.darkGroupBox2.TabStop = false;
            this.darkGroupBox2.Text = "App version";
            // 
            // SettingsCoreTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inMemoryMode_checkBox);
            this.Controls.Add(this.darkGroupBox2);
            this.Controls.Add(this.darkGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingsCoreTab";
            this.Size = new System.Drawing.Size(750, 750);
            this.Load += new System.EventHandler(this.DockDocument_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox1.PerformLayout();
            this.darkGroupBox2.ResumeLayout(false);
            this.darkGroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        public AltUI.Controls.DarkCheckBox inMemoryMode_checkBox;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.LinkLabel appCoreVersion_linkLabel;
        public System.Windows.Forms.LinkLabel appVersion_label;
        public AltUI.Controls.DarkCheckBox checkForUpdates_checkBox;
        public AltUI.Controls.DarkButton deletePreset_button;
        public AltUI.Controls.DarkTextBox presetName_textBox;
        public AltUI.Controls.DarkButton savePreset_button;
        public AltUI.Controls.DarkListBox presets_listBox;
        public AltUI.Controls.DarkButton loadPreset_button;
        private AltUI.Controls.DarkGroupBox darkGroupBox1;
        private AltUI.Controls.DarkGroupBox darkGroupBox2;
    }
}
