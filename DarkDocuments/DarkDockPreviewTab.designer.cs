using System.Windows.Forms;
using AltUI.Controls;

namespace ImageEnhancingUtility.Winforms
{
    partial class DarkDockPreviewTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DarkDockPreviewTab));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.preview_progressBar = new AltUI.Controls.DarkProgressBar();
            this.previewImageBox = new Cyotek.Windows.Forms.ImageBox();
            this.previewModels_comboBox = new AltUI.Controls.DarkComboBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.miniMapImageBox = new Cyotek.Windows.Forms.ImageBox();
            this.label35 = new System.Windows.Forms.Label();
            this.comparisonMod_comboBox = new AltUI.Controls.DarkComboBox();
            this.comparison_colorWheel = new Cyotek.Windows.Forms.ColorWheel();
            this.imageSizeToolStripStatusLabel = new System.Windows.Forms.Label();
            this.button_previewSaveComparison = new AltUI.Controls.DarkButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.previewUpdate_button = new AltUI.Controls.DarkButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.previewShowSaveDialog_checkBox = new System.Windows.Forms.CheckBox();
            this.outputFormatPreview_comboBox = new AltUI.Controls.DarkComboBox();
            this.previewSaveOutputFormat_button = new AltUI.Controls.DarkButton();
            this.zoomImageBox = new Cyotek.Windows.Forms.ImageBox();
            this.toolStrip = new AltUI.Controls.DarkToolStrip();
            this.openFromFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.actualSizeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomInToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomOutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomLevelsToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.preview_progressBar, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.previewImageBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.previewModels_comboBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.splitContainer3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.zoomImageBox, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1082, 752);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // preview_progressBar
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.preview_progressBar, 2);
            this.preview_progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview_progressBar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.preview_progressBar.Location = new System.Drawing.Point(3, 733);
            this.preview_progressBar.Name = "preview_progressBar";
            this.preview_progressBar.Size = new System.Drawing.Size(1076, 16);
            this.preview_progressBar.TabIndex = 23;
            this.preview_progressBar.Text = null;
            // 
            // previewImageBox
            // 
            this.previewImageBox.AlwaysShowHScroll = true;
            this.previewImageBox.AlwaysShowVScroll = true;
            this.previewImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewImageBox.AutoScroll = false;
            this.previewImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewImageBox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.previewImageBox.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.previewImageBox.Location = new System.Drawing.Point(544, 3);
            this.previewImageBox.Name = "previewImageBox";
            this.previewImageBox.Size = new System.Drawing.Size(535, 561);
            this.previewImageBox.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.previewImageBox.TabIndex = 4;
            this.previewImageBox.TabStop = false;
            // 
            // previewModels_comboBox
            // 
            this.previewModels_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.previewModels_comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewModels_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.previewModels_comboBox.FormattingEnabled = true;
            this.previewModels_comboBox.Location = new System.Drawing.Point(544, 570);
            this.previewModels_comboBox.Name = "previewModels_comboBox";
            this.previewModels_comboBox.Size = new System.Drawing.Size(535, 24);
            this.previewModels_comboBox.TabIndex = 6;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 570);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.miniMapImageBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label35);
            this.splitContainer3.Panel2.Controls.Add(this.comparisonMod_comboBox);
            this.splitContainer3.Panel2.Controls.Add(this.comparison_colorWheel);
            this.splitContainer3.Panel2.Controls.Add(this.imageSizeToolStripStatusLabel);
            this.splitContainer3.Panel2.Controls.Add(this.button_previewSaveComparison);
            this.tableLayoutPanel3.SetRowSpan(this.splitContainer3, 2);
            this.splitContainer3.Size = new System.Drawing.Size(535, 157);
            this.splitContainer3.SplitterDistance = 200;
            this.splitContainer3.TabIndex = 9;
            // 
            // miniMapImageBox
            // 
            this.miniMapImageBox.AllowZoom = false;
            this.miniMapImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.miniMapImageBox.AutoPan = false;
            this.miniMapImageBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.miniMapImageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.miniMapImageBox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.miniMapImageBox.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.miniMapImageBox.Location = new System.Drawing.Point(32, 15);
            this.miniMapImageBox.Name = "miniMapImageBox";
            this.miniMapImageBox.PanMode = Cyotek.Windows.Forms.ImageBoxPanMode.Middle;
            this.miniMapImageBox.PixelGridColor = System.Drawing.Color.Transparent;
            this.miniMapImageBox.Size = new System.Drawing.Size(129, 127);
            this.miniMapImageBox.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.miniMapImageBox.TabIndex = 1;
            this.miniMapImageBox.TabStop = false;
            this.miniMapImageBox.VirtualMode = true;
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label35.Location = new System.Drawing.Point(33, 3);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(102, 15);
            this.label35.TabIndex = 9;
            this.label35.Text = "Scale modificator:";
            this.label35.Click += new System.EventHandler(this.label35_Click);
            // 
            // comparisonMod_comboBox
            // 
            this.comparisonMod_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comparisonMod_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comparisonMod_comboBox.FormattingEnabled = true;
            this.comparisonMod_comboBox.Location = new System.Drawing.Point(141, 0);
            this.comparisonMod_comboBox.Name = "comparisonMod_comboBox";
            this.comparisonMod_comboBox.Size = new System.Drawing.Size(52, 24);
            this.comparisonMod_comboBox.TabIndex = 8;
            // 
            // comparison_colorWheel
            // 
            this.comparison_colorWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comparison_colorWheel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comparison_colorWheel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(104)))));
            this.comparison_colorWheel.Location = new System.Drawing.Point(196, 30);
            this.comparison_colorWheel.Name = "comparison_colorWheel";
            this.comparison_colorWheel.Size = new System.Drawing.Size(132, 112);
            this.comparison_colorWheel.TabIndex = 1;
            // 
            // imageSizeToolStripStatusLabel
            // 
            this.imageSizeToolStripStatusLabel.AutoSize = true;
            this.imageSizeToolStripStatusLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.imageSizeToolStripStatusLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.imageSizeToolStripStatusLabel.Location = new System.Drawing.Point(283, 0);
            this.imageSizeToolStripStatusLabel.Name = "imageSizeToolStripStatusLabel";
            this.imageSizeToolStripStatusLabel.Size = new System.Drawing.Size(48, 15);
            this.imageSizeToolStripStatusLabel.TabIndex = 0;
            this.imageSizeToolStripStatusLabel.Text = "W:0 H:0";
            this.imageSizeToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imageSizeToolStripStatusLabel.Click += new System.EventHandler(this.imageSizeToolStripStatusLabel_Click);
            // 
            // button_previewSaveComparison
            // 
            this.button_previewSaveComparison.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_previewSaveComparison.FlatBottom = false;
            this.button_previewSaveComparison.FlatTop = false;
            this.button_previewSaveComparison.HoldColour = false;
            this.button_previewSaveComparison.Location = new System.Drawing.Point(36, 30);
            this.button_previewSaveComparison.Name = "button_previewSaveComparison";
            this.button_previewSaveComparison.Padding = new System.Windows.Forms.Padding(5);
            this.button_previewSaveComparison.Size = new System.Drawing.Size(157, 112);
            this.button_previewSaveComparison.TabIndex = 7;
            this.button_previewSaveComparison.Text = "Save comparison to clipboard";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.previewUpdate_button, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(544, 601);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(535, 126);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // previewUpdate_button
            // 
            this.previewUpdate_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewUpdate_button.FlatBottom = false;
            this.previewUpdate_button.FlatTop = false;
            this.previewUpdate_button.HoldColour = false;
            this.previewUpdate_button.ImagePadding = 0;
            this.previewUpdate_button.Location = new System.Drawing.Point(0, 0);
            this.previewUpdate_button.Margin = new System.Windows.Forms.Padding(0);
            this.previewUpdate_button.Name = "previewUpdate_button";
            this.previewUpdate_button.Padding = new System.Windows.Forms.Padding(5);
            this.previewUpdate_button.Size = new System.Drawing.Size(267, 126);
            this.previewUpdate_button.TabIndex = 6;
            this.previewUpdate_button.Text = "Enchance preview";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.previewShowSaveDialog_checkBox);
            this.panel4.Controls.Add(this.outputFormatPreview_comboBox);
            this.panel4.Controls.Add(this.previewSaveOutputFormat_button);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(267, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 126);
            this.panel4.TabIndex = 7;
            // 
            // previewShowSaveDialog_checkBox
            // 
            this.previewShowSaveDialog_checkBox.AutoSize = true;
            this.previewShowSaveDialog_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previewShowSaveDialog_checkBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.previewShowSaveDialog_checkBox.Location = new System.Drawing.Point(5, 3);
            this.previewShowSaveDialog_checkBox.Name = "previewShowSaveDialog_checkBox";
            this.previewShowSaveDialog_checkBox.Size = new System.Drawing.Size(133, 19);
            this.previewShowSaveDialog_checkBox.TabIndex = 51;
            this.previewShowSaveDialog_checkBox.Text = "Show save file dialog";
            this.previewShowSaveDialog_checkBox.UseVisualStyleBackColor = true;
            this.previewShowSaveDialog_checkBox.CheckedChanged += new System.EventHandler(this.previewShowSaveDialog_checkBox_CheckedChanged);
            // 
            // outputFormatPreview_comboBox
            // 
            this.outputFormatPreview_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFormatPreview_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.outputFormatPreview_comboBox.FormattingEnabled = true;
            this.outputFormatPreview_comboBox.Location = new System.Drawing.Point(174, 0);
            this.outputFormatPreview_comboBox.Name = "outputFormatPreview_comboBox";
            this.outputFormatPreview_comboBox.Size = new System.Drawing.Size(94, 24);
            this.outputFormatPreview_comboBox.TabIndex = 50;
            // 
            // previewSaveOutputFormat_button
            // 
            this.previewSaveOutputFormat_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewSaveOutputFormat_button.FlatBottom = false;
            this.previewSaveOutputFormat_button.FlatTop = false;
            this.previewSaveOutputFormat_button.HoldColour = false;
            this.previewSaveOutputFormat_button.ImagePadding = 0;
            this.previewSaveOutputFormat_button.Location = new System.Drawing.Point(5, 29);
            this.previewSaveOutputFormat_button.Margin = new System.Windows.Forms.Padding(0);
            this.previewSaveOutputFormat_button.Name = "previewSaveOutputFormat_button";
            this.previewSaveOutputFormat_button.Padding = new System.Windows.Forms.Padding(5);
            this.previewSaveOutputFormat_button.Size = new System.Drawing.Size(263, 97);
            this.previewSaveOutputFormat_button.TabIndex = 9;
            this.previewSaveOutputFormat_button.Text = "Enhance and Save";
            // 
            // zoomImageBox
            // 
            this.zoomImageBox.AllowDrop = true;
            this.zoomImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoomImageBox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.zoomImageBox.GridColorAlternate = System.Drawing.SystemColors.ControlDark;
            this.zoomImageBox.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.zoomImageBox.Location = new System.Drawing.Point(3, 3);
            this.zoomImageBox.Name = "zoomImageBox";
            this.zoomImageBox.PanMode = Cyotek.Windows.Forms.ImageBoxPanMode.Left;
            this.zoomImageBox.Size = new System.Drawing.Size(535, 561);
            this.zoomImageBox.TabIndex = 0;
            this.zoomImageBox.TabStop = false;
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.toolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFromFileToolStripButton,
            this.toolStripSeparator8,
            this.actualSizeToolStripButton,
            this.zoomInToolStripButton,
            this.zoomOutToolStripButton,
            this.toolStripSeparator2,
            this.zoomLevelsToolStripComboBox});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.toolStrip.Size = new System.Drawing.Size(1082, 25);
            this.toolStrip.TabIndex = 6;
            // 
            // openFromFileToolStripButton
            // 
            this.openFromFileToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.openFromFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFromFileToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.openFromFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openFromFileToolStripButton.Image")));
            this.openFromFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFromFileToolStripButton.Name = "openFromFileToolStripButton";
            this.openFromFileToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openFromFileToolStripButton.Text = "&Open";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.toolStripSeparator8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.toolStripSeparator8.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // actualSizeToolStripButton
            // 
            this.actualSizeToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.actualSizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actualSizeToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.actualSizeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("actualSizeToolStripButton.Image")));
            this.actualSizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actualSizeToolStripButton.Name = "actualSizeToolStripButton";
            this.actualSizeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.actualSizeToolStripButton.Text = "Actual Size";
            // 
            // zoomInToolStripButton
            // 
            this.zoomInToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.zoomInToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.zoomInToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomInToolStripButton.Image")));
            this.zoomInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInToolStripButton.Name = "zoomInToolStripButton";
            this.zoomInToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zoomInToolStripButton.Text = "Zoom In";
            // 
            // zoomOutToolStripButton
            // 
            this.zoomOutToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.zoomOutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.zoomOutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutToolStripButton.Image")));
            this.zoomOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutToolStripButton.Name = "zoomOutToolStripButton";
            this.zoomOutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zoomOutToolStripButton.Text = "Zoom Out";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // zoomLevelsToolStripComboBox
            // 
            this.zoomLevelsToolStripComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.zoomLevelsToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zoomLevelsToolStripComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.zoomLevelsToolStripComboBox.Name = "zoomLevelsToolStripComboBox";
            this.zoomLevelsToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // DarkDockPreviewTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DarkDockPreviewTab";
            this.Size = new System.Drawing.Size(1082, 777);
            this.Load += new System.EventHandler(this.DockDocument_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public Cyotek.Windows.Forms.ImageBox previewImageBox;
        public DarkComboBox previewModels_comboBox;
        public System.Windows.Forms.SplitContainer splitContainer3;
        public Cyotek.Windows.Forms.ImageBox miniMapImageBox;
        public System.Windows.Forms.Label label35;
        public DarkComboBox comparisonMod_comboBox;
        public Cyotek.Windows.Forms.ColorWheel comparison_colorWheel;
        public System.Windows.Forms.Label imageSizeToolStripStatusLabel;
        public DarkButton button_previewSaveComparison;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        public DarkButton previewUpdate_button;
        public System.Windows.Forms.CheckBox previewShowSaveDialog_checkBox;
        public DarkComboBox outputFormatPreview_comboBox;
        public DarkButton previewSaveOutputFormat_button;
        public Cyotek.Windows.Forms.ImageBox zoomImageBox;
        public DarkToolStrip toolStrip;
        public System.Windows.Forms.ToolStripButton openFromFileToolStripButton;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        public System.Windows.Forms.ToolStripButton actualSizeToolStripButton;
        public System.Windows.Forms.ToolStripButton zoomInToolStripButton;
        public System.Windows.Forms.ToolStripButton zoomOutToolStripButton;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripComboBox zoomLevelsToolStripComboBox;
        public Panel panel4;
        public DarkProgressBar preview_progressBar;
    }
}
