using AltUI.Controls;

namespace ImageEnhancingUtility.Winforms
{
    partial class DarkDockMainTab
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new AltUI.Controls.DarkSectionPanel();
            this.progressFiltered_label = new AltUI.Controls.DarkLabel();
            this.progress_label = new AltUI.Controls.DarkLabel();
            this.panel1 = new AltUI.Controls.DarkSectionPanel();
            this.crop_button = new AltUI.Controls.DarkButton();
            this.showStepsButtons_checkBox = new AltUI.Controls.DarkCheckBox();
            this.merge_button = new AltUI.Controls.DarkButton();
            this.loadProfileMainTab_button = new AltUI.Controls.DarkButton();
            this.upscale_button = new AltUI.Controls.DarkButton();
            this.profilesMainTab_listBox = new AltUI.Controls.DarkListBox();
            this.groupBox1 = new AltUI.Controls.DarkGroupBox();
            this.overwriteMode_comboBox = new AltUI.Controls.DarkComboBox();
            this.runAll_button = new AltUI.Controls.DarkButton();
            this.groupBox11 = new AltUI.Controls.DarkGroupBox();
            this.UseModelChain_checkBox = new AltUI.Controls.DarkCheckBox();
            this.chainOrder_button = new AltUI.Controls.DarkButton();
            this.outputMode_groupBox = new AltUI.Controls.DarkGroupBox();
            this.outputDestinationMode_comboBox = new AltUI.Controls.DarkComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new AltUI.Controls.DarkProgressBar();
            this.toogleLogView_button = new AltUI.Controls.DarkButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.outputMode_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 777);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.progressFiltered_label);
            this.panel2.Controls.Add(this.progress_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(3, 739);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.SectionHeader = "";
            this.panel2.Size = new System.Drawing.Size(172, 33);
            this.panel2.TabIndex = 37;
            // 
            // progressFiltered_label
            // 
            this.progressFiltered_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressFiltered_label.Font = new System.Drawing.Font("Malgun Gothic", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressFiltered_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.progressFiltered_label.Location = new System.Drawing.Point(0, 1);
            this.progressFiltered_label.Name = "progressFiltered_label";
            this.progressFiltered_label.Size = new System.Drawing.Size(79, 32);
            this.progressFiltered_label.TabIndex = 24;
            this.progressFiltered_label.Text = "0";
            this.progressFiltered_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progress_label
            // 
            this.progress_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progress_label.Font = new System.Drawing.Font("Malgun Gothic", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progress_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.progress_label.Location = new System.Drawing.Point(85, 2);
            this.progress_label.Margin = new System.Windows.Forms.Padding(3);
            this.progress_label.Name = "progress_label";
            this.progress_label.Size = new System.Drawing.Size(87, 31);
            this.progress_label.TabIndex = 23;
            this.progress_label.Text = "0/0";
            this.progress_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.crop_button);
            this.panel1.Controls.Add(this.showStepsButtons_checkBox);
            this.panel1.Controls.Add(this.merge_button);
            this.panel1.Controls.Add(this.loadProfileMainTab_button);
            this.panel1.Controls.Add(this.upscale_button);
            this.panel1.Controls.Add(this.profilesMainTab_listBox);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.runAll_button);
            this.panel1.Controls.Add(this.groupBox11);
            this.panel1.Controls.Add(this.outputMode_groupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.SectionHeader = null;
            this.panel1.Size = new System.Drawing.Size(172, 728);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // crop_button
            // 
            this.crop_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.crop_button.FlatBottom = false;
            this.crop_button.FlatTop = false;
            this.crop_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.crop_button.HoldColour = false;
            this.crop_button.Location = new System.Drawing.Point(11, 578);
            this.crop_button.Name = "crop_button";
            this.crop_button.Padding = new System.Windows.Forms.Padding(5);
            this.crop_button.Size = new System.Drawing.Size(151, 34);
            this.crop_button.TabIndex = 17;
            this.crop_button.Text = "SPLIT";
            // 
            // showStepsButtons_checkBox
            // 
            this.showStepsButtons_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showStepsButtons_checkBox.AutoSize = true;
            this.showStepsButtons_checkBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.showStepsButtons_checkBox.Location = new System.Drawing.Point(11, 698);
            this.showStepsButtons_checkBox.Name = "showStepsButtons_checkBox";
            this.showStepsButtons_checkBox.Offset = 1;
            this.showStepsButtons_checkBox.Size = new System.Drawing.Size(81, 19);
            this.showStepsButtons_checkBox.TabIndex = 61;
            this.showStepsButtons_checkBox.Text = "Hide steps";
            // 
            // merge_button
            // 
            this.merge_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.merge_button.FlatBottom = false;
            this.merge_button.FlatTop = false;
            this.merge_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.merge_button.HoldColour = false;
            this.merge_button.Location = new System.Drawing.Point(11, 658);
            this.merge_button.Name = "merge_button";
            this.merge_button.Padding = new System.Windows.Forms.Padding(5);
            this.merge_button.Size = new System.Drawing.Size(151, 34);
            this.merge_button.TabIndex = 18;
            this.merge_button.Text = "MERGE";
            // 
            // loadProfileMainTab_button
            // 
            this.loadProfileMainTab_button.FlatBottom = false;
            this.loadProfileMainTab_button.FlatTop = false;
            this.loadProfileMainTab_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.loadProfileMainTab_button.HoldColour = false;
            this.loadProfileMainTab_button.Location = new System.Drawing.Point(11, 516);
            this.loadProfileMainTab_button.Name = "loadProfileMainTab_button";
            this.loadProfileMainTab_button.Padding = new System.Windows.Forms.Padding(5);
            this.loadProfileMainTab_button.Size = new System.Drawing.Size(151, 31);
            this.loadProfileMainTab_button.TabIndex = 52;
            this.loadProfileMainTab_button.Text = "Load profile";
            this.loadProfileMainTab_button.Click += new System.EventHandler(this.LoadProfileMainTab_button_Click);
            // 
            // upscale_button
            // 
            this.upscale_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.upscale_button.FlatBottom = false;
            this.upscale_button.FlatTop = false;
            this.upscale_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.upscale_button.HoldColour = false;
            this.upscale_button.Location = new System.Drawing.Point(11, 618);
            this.upscale_button.Name = "upscale_button";
            this.upscale_button.Padding = new System.Windows.Forms.Padding(5);
            this.upscale_button.Size = new System.Drawing.Size(151, 34);
            this.upscale_button.TabIndex = 1;
            this.upscale_button.Text = "RUN ESRGAN";
            // 
            // profilesMainTab_listBox
            // 
            this.profilesMainTab_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.profilesMainTab_listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilesMainTab_listBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.profilesMainTab_listBox.ItemHeight = 15;
            this.profilesMainTab_listBox.Location = new System.Drawing.Point(11, 326);
            this.profilesMainTab_listBox.Name = "profilesMainTab_listBox";
            this.profilesMainTab_listBox.Size = new System.Drawing.Size(151, 182);
            this.profilesMainTab_listBox.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.overwriteMode_comboBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(11, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 50);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile : Overwrite";
            // 
            // overwriteMode_comboBox
            // 
            this.overwriteMode_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.overwriteMode_comboBox.FormattingEnabled = true;
            this.overwriteMode_comboBox.Location = new System.Drawing.Point(6, 19);
            this.overwriteMode_comboBox.Name = "overwriteMode_comboBox";
            this.overwriteMode_comboBox.Size = new System.Drawing.Size(137, 24);
            this.overwriteMode_comboBox.TabIndex = 0;
            // 
            // runAll_button
            // 
            this.runAll_button.FlatBottom = false;
            this.runAll_button.FlatTop = false;
            this.runAll_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.runAll_button.HoldColour = false;
            this.runAll_button.Location = new System.Drawing.Point(11, 214);
            this.runAll_button.Name = "runAll_button";
            this.runAll_button.Padding = new System.Windows.Forms.Padding(5);
            this.runAll_button.Size = new System.Drawing.Size(151, 92);
            this.runAll_button.TabIndex = 32;
            this.runAll_button.Text = "START";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.UseModelChain_checkBox);
            this.groupBox11.Controls.Add(this.chainOrder_button);
            this.groupBox11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox11.Location = new System.Drawing.Point(11, 115);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(151, 85);
            this.groupBox11.TabIndex = 31;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Model chain";
            // 
            // UseModelChain_checkBox
            // 
            this.UseModelChain_checkBox.AutoSize = true;
            this.UseModelChain_checkBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.UseModelChain_checkBox.Location = new System.Drawing.Point(6, 19);
            this.UseModelChain_checkBox.Name = "UseModelChain_checkBox";
            this.UseModelChain_checkBox.Offset = 1;
            this.UseModelChain_checkBox.Size = new System.Drawing.Size(114, 19);
            this.UseModelChain_checkBox.TabIndex = 53;
            this.UseModelChain_checkBox.Text = "Use model chain";
            // 
            // chainOrder_button
            // 
            this.chainOrder_button.FlatBottom = false;
            this.chainOrder_button.FlatTop = false;
            this.chainOrder_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chainOrder_button.HoldColour = false;
            this.chainOrder_button.Location = new System.Drawing.Point(6, 42);
            this.chainOrder_button.Name = "chainOrder_button";
            this.chainOrder_button.Padding = new System.Windows.Forms.Padding(5);
            this.chainOrder_button.Size = new System.Drawing.Size(137, 30);
            this.chainOrder_button.TabIndex = 54;
            this.chainOrder_button.Text = "Chain order";
            // 
            // outputMode_groupBox
            // 
            this.outputMode_groupBox.Controls.Add(this.outputDestinationMode_comboBox);
            this.outputMode_groupBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.outputMode_groupBox.Location = new System.Drawing.Point(11, 8);
            this.outputMode_groupBox.Name = "outputMode_groupBox";
            this.outputMode_groupBox.Size = new System.Drawing.Size(151, 52);
            this.outputMode_groupBox.TabIndex = 31;
            this.outputMode_groupBox.TabStop = false;
            this.outputMode_groupBox.Text = "Output mode";
            // 
            // outputDestinationMode_comboBox
            // 
            this.outputDestinationMode_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.outputDestinationMode_comboBox.FormattingEnabled = true;
            this.outputDestinationMode_comboBox.Location = new System.Drawing.Point(6, 19);
            this.outputDestinationMode_comboBox.Name = "outputDestinationMode_comboBox";
            this.outputDestinationMode_comboBox.Size = new System.Drawing.Size(137, 24);
            this.outputDestinationMode_comboBox.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Location = new System.Drawing.Point(181, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.splitContainer1.Panel1MinSize = 400;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2MinSize = 400;
            this.splitContainer1.Size = new System.Drawing.Size(898, 728);
            this.splitContainer1.SplitterDistance = 428;
            this.splitContainer1.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Console", 10.25F);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(466, 728);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel7.Controls.Add(this.progressBar1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.toogleLogView_button, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(181, 737);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(898, 37);
            this.tableLayoutPanel7.TabIndex = 38;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(809, 31);
            this.progressBar1.TabIndex = 22;
            this.progressBar1.Text = null;
            // 
            // toogleLogView_button
            // 
            this.toogleLogView_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toogleLogView_button.FlatBottom = false;
            this.toogleLogView_button.FlatTop = false;
            this.toogleLogView_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toogleLogView_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toogleLogView_button.HoldColour = false;
            this.toogleLogView_button.Location = new System.Drawing.Point(818, 3);
            this.toogleLogView_button.Name = "toogleLogView_button";
            this.toogleLogView_button.Padding = new System.Windows.Forms.Padding(5);
            this.toogleLogView_button.Size = new System.Drawing.Size(77, 31);
            this.toogleLogView_button.TabIndex = 23;
            this.toogleLogView_button.Text = "Hide logs";
            this.toogleLogView_button.Click += new System.EventHandler(this.toogleLogView_button_Click);
            // 
            // DarkDockMainTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DarkDockMainTab";
            this.Size = new System.Drawing.Size(1082, 777);
            this.Load += new System.EventHandler(this.DockDocument_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.outputMode_groupBox.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public DarkSectionPanel panel2;
        public DarkLabel progressFiltered_label;
        public DarkLabel progress_label;
        public DarkSectionPanel panel1;
        public DarkButton crop_button;
        public DarkCheckBox showStepsButtons_checkBox;
        public DarkButton merge_button;
        public DarkButton loadProfileMainTab_button;
        public DarkButton upscale_button;
        public DarkListBox profilesMainTab_listBox;
        public DarkGroupBox groupBox1;
        public DarkComboBox overwriteMode_comboBox;
        public DarkButton runAll_button;
        public DarkGroupBox groupBox11;
        public DarkGroupBox outputMode_groupBox;
        public DarkComboBox outputDestinationMode_comboBox;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        public DarkProgressBar progressBar1;
        public DarkButton toogleLogView_button;
        public DarkCheckBox UseModelChain_checkBox;
        public DarkButton chainOrder_button;
        
        
    }
}
