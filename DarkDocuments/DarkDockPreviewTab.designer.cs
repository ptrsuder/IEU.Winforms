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
            preview_ContextMenu = new DarkContextMenu();
            saveComparisonToClipboardToolStripMenuItem = new ToolStripMenuItem();
            comaprisonScaleToolStripMenuItem = new ToolStripMenuItem();
            comparisonScale_025 = new ToolStripMenuItem();
            comparisonScale_050 = new ToolStripMenuItem();
            comparisonScale_100 = new ToolStripMenuItem();
            comparisonScale_200 = new ToolStripMenuItem();
            comparisonScale_400 = new ToolStripMenuItem();
            toolStrip = new DarkToolStrip();
            openFromFileToolStripButton = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            actualSizeToolStripButton = new ToolStripButton();
            zoomInToolStripButton = new ToolStripButton();
            zoomOutToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tableLayoutPanel1 = new TableLayoutPanel();
            showModelForm_button = new DarkButton();
            previewModels_comboBox = new DarkComboBox();
            zoomImageBox = new Cyotek.Windows.Forms.ImageBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            previewUpdate_button = new DarkButton();
            panel4 = new Panel();
            previewSaveOutputFormat_button = new DarkButton();
            splitContainer3 = new SplitContainer();
            imageSizeToolStripStatusLabel = new Label();
            miniMapImageBox = new Cyotek.Windows.Forms.ImageBox();
            darkLabel1 = new DarkLabel();
            previewImageBox = new Cyotek.Windows.Forms.ImageBox();
            preview_progressBar = new DarkProgressBar();
            tableLayoutPanel3 = new TableLayoutPanel();
            zoomLevelsToolStripComboBox = new DarkComboBox();
            preview_ContextMenu.SuspendLayout();
            toolStrip.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // preview_ContextMenu
            // 
            preview_ContextMenu.BackColor = System.Drawing.Color.FromArgb(16, 16, 17);
            preview_ContextMenu.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            preview_ContextMenu.Items.AddRange(new ToolStripItem[] { saveComparisonToClipboardToolStripMenuItem, comaprisonScaleToolStripMenuItem });
            preview_ContextMenu.Name = "preview_ContextMenu";
            preview_ContextMenu.Size = new System.Drawing.Size(232, 48);
            // 
            // saveComparisonToClipboardToolStripMenuItem
            // 
            saveComparisonToClipboardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(16, 16, 17);
            saveComparisonToClipboardToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            saveComparisonToClipboardToolStripMenuItem.Name = "saveComparisonToClipboardToolStripMenuItem";
            saveComparisonToClipboardToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            saveComparisonToClipboardToolStripMenuItem.Text = "Save comparison to clipboard";
            // 
            // comaprisonScaleToolStripMenuItem
            // 
            comaprisonScaleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(16, 16, 17);
            comaprisonScaleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { comparisonScale_025, comparisonScale_050, comparisonScale_100, comparisonScale_200, comparisonScale_400 });
            comaprisonScaleToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            comaprisonScaleToolStripMenuItem.Name = "comaprisonScaleToolStripMenuItem";
            comaprisonScaleToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            comaprisonScaleToolStripMenuItem.Text = "Comparison scale";
            comaprisonScaleToolStripMenuItem.MouseEnter += comaprisonScaleToolStripMenuItem_MouseEnter;
            comaprisonScaleToolStripMenuItem.MouseLeave += comaprisonScaleToolStripMenuItem_MouseLeave;
            // 
            // comparisonScale_025
            // 
            comparisonScale_025.BackColor = System.Drawing.Color.FromArgb(16, 16, 17);
            comparisonScale_025.CheckOnClick = true;
            comparisonScale_025.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            comparisonScale_025.Name = "comparisonScale_025";
            comparisonScale_025.Size = new System.Drawing.Size(102, 22);
            comparisonScale_025.Tag = "0.25";
            comparisonScale_025.Text = "25%";
            comparisonScale_025.Click += comparisonScale_Click;
            comparisonScale_025.MouseEnter += comaprisonScaleToolStripMenuItem_MouseEnter;
            comparisonScale_025.MouseLeave += comaprisonScaleToolStripMenuItem_MouseLeave;
            // 
            // comparisonScale_050
            // 
            comparisonScale_050.BackColor = System.Drawing.Color.FromArgb(16, 16, 17);
            comparisonScale_050.CheckOnClick = true;
            comparisonScale_050.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            comparisonScale_050.Name = "comparisonScale_050";
            comparisonScale_050.Size = new System.Drawing.Size(102, 22);
            comparisonScale_050.Tag = "0.50";
            comparisonScale_050.Text = "50%";
            comparisonScale_050.Click += comparisonScale_Click;
            comparisonScale_050.MouseEnter += comaprisonScaleToolStripMenuItem_MouseEnter;
            comparisonScale_050.MouseLeave += comaprisonScaleToolStripMenuItem_MouseLeave;
            // 
            // comparisonScale_100
            // 
            comparisonScale_100.BackColor = System.Drawing.Color.FromArgb(16, 16, 17);
            comparisonScale_100.CheckOnClick = true;
            comparisonScale_100.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            comparisonScale_100.Name = "comparisonScale_100";
            comparisonScale_100.Size = new System.Drawing.Size(102, 22);
            comparisonScale_100.Tag = "1.0";
            comparisonScale_100.Text = "100%";
            comparisonScale_100.Click += comparisonScale_Click;
            comparisonScale_100.MouseEnter += comaprisonScaleToolStripMenuItem_MouseEnter;
            comparisonScale_100.MouseLeave += comaprisonScaleToolStripMenuItem_MouseLeave;
            // 
            // comparisonScale_200
            // 
            comparisonScale_200.BackColor = System.Drawing.Color.FromArgb(16, 16, 17);
            comparisonScale_200.CheckOnClick = true;
            comparisonScale_200.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            comparisonScale_200.Name = "comparisonScale_200";
            comparisonScale_200.Size = new System.Drawing.Size(102, 22);
            comparisonScale_200.Tag = "2.0";
            comparisonScale_200.Text = "200%";
            comparisonScale_200.Click += comparisonScale_Click;
            comparisonScale_200.MouseEnter += comaprisonScaleToolStripMenuItem_MouseEnter;
            comparisonScale_200.MouseLeave += comaprisonScaleToolStripMenuItem_MouseLeave;
            // 
            // comparisonScale_400
            // 
            comparisonScale_400.BackColor = System.Drawing.Color.FromArgb(16, 16, 17);
            comparisonScale_400.CheckOnClick = true;
            comparisonScale_400.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            comparisonScale_400.Name = "comparisonScale_400";
            comparisonScale_400.Size = new System.Drawing.Size(102, 22);
            comparisonScale_400.Tag = "4.0";
            comparisonScale_400.Text = "400%";
            comparisonScale_400.Click += comparisonScale_Click;
            comparisonScale_400.MouseEnter += comaprisonScaleToolStripMenuItem_MouseEnter;
            comparisonScale_400.MouseLeave += comaprisonScaleToolStripMenuItem_MouseLeave;
            // 
            // toolStrip
            // 
            toolStrip.AutoSize = false;
            toolStrip.BackColor = System.Drawing.Color.FromArgb(16, 16, 17);
            toolStrip.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            toolStrip.Items.AddRange(new ToolStripItem[] { openFromFileToolStripButton, toolStripSeparator8, actualSizeToolStripButton, zoomInToolStripButton, zoomOutToolStripButton, toolStripSeparator2 });
            toolStrip.Location = new System.Drawing.Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Padding = new Padding(5, 0, 1, 0);
            toolStrip.Size = new System.Drawing.Size(1082, 25);
            toolStrip.TabIndex = 6;
            // 
            // openFromFileToolStripButton
            // 
            openFromFileToolStripButton.BackColor = System.Drawing.Color.FromArgb(16, 16, 17);
            openFromFileToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openFromFileToolStripButton.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            openFromFileToolStripButton.Image = (System.Drawing.Image)resources.GetObject("openFromFileToolStripButton.Image");
            openFromFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            openFromFileToolStripButton.Name = "openFromFileToolStripButton";
            openFromFileToolStripButton.Size = new System.Drawing.Size(23, 22);
            openFromFileToolStripButton.Text = "&Open";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.BackColor = System.Drawing.Color.FromArgb(16, 16, 17);
            toolStripSeparator8.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            toolStripSeparator8.Margin = new Padding(0, 0, 2, 0);
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // actualSizeToolStripButton
            // 
            actualSizeToolStripButton.BackColor = System.Drawing.Color.FromArgb(16, 16, 17);
            actualSizeToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            actualSizeToolStripButton.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            actualSizeToolStripButton.Image = (System.Drawing.Image)resources.GetObject("actualSizeToolStripButton.Image");
            actualSizeToolStripButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            actualSizeToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            actualSizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            actualSizeToolStripButton.Margin = new Padding(0, 3, 0, 0);
            actualSizeToolStripButton.Name = "actualSizeToolStripButton";
            actualSizeToolStripButton.Size = new System.Drawing.Size(23, 22);
            actualSizeToolStripButton.Text = "Actual Size";
            // 
            // zoomInToolStripButton
            // 
            zoomInToolStripButton.BackColor = System.Drawing.Color.FromArgb(16, 16, 17);
            zoomInToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            zoomInToolStripButton.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            zoomInToolStripButton.Image = (System.Drawing.Image)resources.GetObject("zoomInToolStripButton.Image");
            zoomInToolStripButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            zoomInToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            zoomInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            zoomInToolStripButton.Margin = new Padding(0, 5, 0, 0);
            zoomInToolStripButton.Name = "zoomInToolStripButton";
            zoomInToolStripButton.Size = new System.Drawing.Size(23, 20);
            zoomInToolStripButton.Text = "Zoom In";
            // 
            // zoomOutToolStripButton
            // 
            zoomOutToolStripButton.BackColor = System.Drawing.Color.FromArgb(16, 16, 17);
            zoomOutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            zoomOutToolStripButton.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            zoomOutToolStripButton.Image = (System.Drawing.Image)resources.GetObject("zoomOutToolStripButton.Image");
            zoomOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            zoomOutToolStripButton.Margin = new Padding(0, 5, 0, 0);
            zoomOutToolStripButton.Name = "zoomOutToolStripButton";
            zoomOutToolStripButton.Size = new System.Drawing.Size(23, 20);
            zoomOutToolStripButton.Text = "Zoom Out";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.BackColor = System.Drawing.Color.FromArgb(16, 16, 17);
            toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(213, 213, 213);
            toolStripSeparator2.Margin = new Padding(0, 0, 2, 0);
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.54205F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.45794F));
            tableLayoutPanel1.Controls.Add(showModelForm_button, 1, 0);
            tableLayoutPanel1.Controls.Add(previewModels_comboBox, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(544, 570);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(535, 25);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // showModelForm_button
            // 
            showModelForm_button.Dock = DockStyle.Right;
            showModelForm_button.FlatBottom = false;
            showModelForm_button.FlatTop = false;
            showModelForm_button.HoldColour = false;
            showModelForm_button.Location = new System.Drawing.Point(469, 0);
            showModelForm_button.Margin = new Padding(0, 0, 0, 1);
            showModelForm_button.Name = "showModelForm_button";
            showModelForm_button.Padding = new Padding(5);
            showModelForm_button.Size = new System.Drawing.Size(66, 24);
            showModelForm_button.TabIndex = 0;
            showModelForm_button.Text = "...";
            // 
            // previewModels_comboBox
            // 
            previewModels_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            previewModels_comboBox.Dock = DockStyle.Fill;
            previewModels_comboBox.DrawMode = DrawMode.OwnerDrawVariable;
            previewModels_comboBox.FormattingEnabled = true;
            previewModels_comboBox.Location = new System.Drawing.Point(0, 0);
            previewModels_comboBox.Margin = new Padding(0);
            previewModels_comboBox.Name = "previewModels_comboBox";
            previewModels_comboBox.Size = new System.Drawing.Size(463, 24);
            previewModels_comboBox.TabIndex = 6;
            // 
            // zoomImageBox
            // 
            zoomImageBox.AllowDrop = true;
            zoomImageBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            zoomImageBox.BorderStyle = BorderStyle.FixedSingle;
            zoomImageBox.GridColor = System.Drawing.Color.FromArgb(26, 26, 29);
            zoomImageBox.GridColorAlternate = System.Drawing.SystemColors.ControlDark;
            zoomImageBox.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            zoomImageBox.Location = new System.Drawing.Point(3, 3);
            zoomImageBox.Name = "zoomImageBox";
            zoomImageBox.PanMode = Cyotek.Windows.Forms.ImageBoxPanMode.Left;
            zoomImageBox.Size = new System.Drawing.Size(535, 561);
            zoomImageBox.TabIndex = 0;
            zoomImageBox.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(previewUpdate_button, 0, 0);
            tableLayoutPanel6.Controls.Add(panel4, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new System.Drawing.Point(544, 601);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
            tableLayoutPanel6.Size = new System.Drawing.Size(535, 126);
            tableLayoutPanel6.TabIndex = 10;
            // 
            // previewUpdate_button
            // 
            previewUpdate_button.Dock = DockStyle.Fill;
            previewUpdate_button.FlatBottom = false;
            previewUpdate_button.FlatTop = false;
            previewUpdate_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            previewUpdate_button.HoldColour = false;
            previewUpdate_button.ImagePadding = 0;
            previewUpdate_button.Location = new System.Drawing.Point(0, 0);
            previewUpdate_button.Margin = new Padding(0);
            previewUpdate_button.Name = "previewUpdate_button";
            previewUpdate_button.Padding = new Padding(5);
            previewUpdate_button.Size = new System.Drawing.Size(267, 126);
            previewUpdate_button.TabIndex = 6;
            previewUpdate_button.Text = "Enhance Preview";
            // 
            // panel4
            // 
            panel4.Controls.Add(previewSaveOutputFormat_button);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new System.Drawing.Point(267, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(268, 126);
            panel4.TabIndex = 7;
            // 
            // previewSaveOutputFormat_button
            // 
            previewSaveOutputFormat_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            previewSaveOutputFormat_button.FlatBottom = false;
            previewSaveOutputFormat_button.FlatTop = false;
            previewSaveOutputFormat_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            previewSaveOutputFormat_button.HoldColour = false;
            previewSaveOutputFormat_button.ImagePadding = 0;
            previewSaveOutputFormat_button.Location = new System.Drawing.Point(5, 0);
            previewSaveOutputFormat_button.Margin = new Padding(0);
            previewSaveOutputFormat_button.Name = "previewSaveOutputFormat_button";
            previewSaveOutputFormat_button.Padding = new Padding(5);
            previewSaveOutputFormat_button.Size = new System.Drawing.Size(263, 126);
            previewSaveOutputFormat_button.TabIndex = 9;
            previewSaveOutputFormat_button.Text = "Enhance Image";
            previewSaveOutputFormat_button.Click += previewSaveOutputFormat_button_Click;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new System.Drawing.Point(3, 570);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(imageSizeToolStripStatusLabel);
            splitContainer3.Panel1.Controls.Add(miniMapImageBox);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(darkLabel1);
            tableLayoutPanel3.SetRowSpan(splitContainer3, 2);
            splitContainer3.Size = new System.Drawing.Size(535, 157);
            splitContainer3.SplitterDistance = 200;
            splitContainer3.TabIndex = 9;
            // 
            // imageSizeToolStripStatusLabel
            // 
            imageSizeToolStripStatusLabel.AutoSize = true;
            imageSizeToolStripStatusLabel.Dock = DockStyle.Left;
            imageSizeToolStripStatusLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            imageSizeToolStripStatusLabel.Location = new System.Drawing.Point(0, 0);
            imageSizeToolStripStatusLabel.Name = "imageSizeToolStripStatusLabel";
            imageSizeToolStripStatusLabel.Size = new System.Drawing.Size(48, 15);
            imageSizeToolStripStatusLabel.TabIndex = 0;
            imageSizeToolStripStatusLabel.Text = "W:0 H:0";
            imageSizeToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // miniMapImageBox
            // 
            miniMapImageBox.AllowZoom = false;
            miniMapImageBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            miniMapImageBox.AutoPan = false;
            miniMapImageBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            miniMapImageBox.BorderStyle = BorderStyle.None;
            miniMapImageBox.GridColor = System.Drawing.Color.FromArgb(26, 26, 29);
            miniMapImageBox.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            miniMapImageBox.Location = new System.Drawing.Point(2, 23);
            miniMapImageBox.Name = "miniMapImageBox";
            miniMapImageBox.PanMode = Cyotek.Windows.Forms.ImageBoxPanMode.Middle;
            miniMapImageBox.PixelGridColor = System.Drawing.Color.Transparent;
            miniMapImageBox.Size = new System.Drawing.Size(130, 130);
            miniMapImageBox.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            miniMapImageBox.TabIndex = 1;
            miniMapImageBox.TabStop = false;
            miniMapImageBox.VirtualMode = true;
            // 
            // darkLabel1
            // 
            darkLabel1.AutoSize = true;
            darkLabel1.Dock = DockStyle.Right;
            darkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            darkLabel1.Location = new System.Drawing.Point(282, 0);
            darkLabel1.Margin = new Padding(0);
            darkLabel1.Name = "darkLabel1";
            darkLabel1.Padding = new Padding(0, 6, 0, 0);
            darkLabel1.RightToLeft = RightToLeft.No;
            darkLabel1.Size = new System.Drawing.Size(49, 23);
            darkLabel1.TabIndex = 0;
            darkLabel1.Text = "Model:";
            darkLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // previewImageBox
            // 
            previewImageBox.AlwaysShowHScroll = true;
            previewImageBox.AlwaysShowVScroll = true;
            previewImageBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            previewImageBox.AutoScroll = false;
            previewImageBox.BorderStyle = BorderStyle.FixedSingle;
            previewImageBox.ContextMenuStrip = preview_ContextMenu;
            previewImageBox.GridColor = System.Drawing.Color.FromArgb(26, 26, 29);
            previewImageBox.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            previewImageBox.Location = new System.Drawing.Point(544, 3);
            previewImageBox.Name = "previewImageBox";
            previewImageBox.Size = new System.Drawing.Size(535, 561);
            previewImageBox.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            previewImageBox.TabIndex = 4;
            previewImageBox.TabStop = false;
            // 
            // preview_progressBar
            // 
            tableLayoutPanel3.SetColumnSpan(preview_progressBar, 2);
            preview_progressBar.Dock = DockStyle.Fill;
            preview_progressBar.ForeColor = System.Drawing.SystemColors.ControlLight;
            preview_progressBar.Location = new System.Drawing.Point(3, 733);
            preview_progressBar.Name = "preview_progressBar";
            preview_progressBar.Size = new System.Drawing.Size(1076, 16);
            preview_progressBar.TabIndex = 23;
            preview_progressBar.Text = null;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(preview_progressBar, 0, 3);
            tableLayoutPanel3.Controls.Add(previewImageBox, 1, 0);
            tableLayoutPanel3.Controls.Add(splitContainer3, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 1, 2);
            tableLayoutPanel3.Controls.Add(zoomImageBox, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(0, 25);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 132F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel3.Size = new System.Drawing.Size(1082, 752);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // zoomLevelsToolStripComboBox
            // 
            zoomLevelsToolStripComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            zoomLevelsToolStripComboBox.Location = new System.Drawing.Point(124, 2);
            zoomLevelsToolStripComboBox.Name = "zoomLevelsToolStripComboBox";
            zoomLevelsToolStripComboBox.Size = new System.Drawing.Size(65, 24);
            zoomLevelsToolStripComboBox.TabIndex = 0;
            // 
            // DarkDockPreviewTab
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(zoomLevelsToolStripComboBox);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(toolStrip);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Name = "DarkDockPreviewTab";
            Size = new System.Drawing.Size(1082, 777);
            preview_ContextMenu.ResumeLayout(false);
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        public DarkToolStrip toolStrip;
        public System.Windows.Forms.ToolStripButton openFromFileToolStripButton;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        public System.Windows.Forms.ToolStripButton actualSizeToolStripButton;
        public System.Windows.Forms.ToolStripButton zoomInToolStripButton;
        public System.Windows.Forms.ToolStripButton zoomOutToolStripButton;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public DarkContextMenu preview_ContextMenu;
        public ToolStripMenuItem saveComparisonToClipboardToolStripMenuItem;
        private ToolStripMenuItem comaprisonScaleToolStripMenuItem;
        public ToolStripMenuItem comparisonScale_025;
        public ToolStripMenuItem comparisonScale_050;
        public ToolStripMenuItem comparisonScale_100;
        public ToolStripMenuItem comparisonScale_200;
        public ToolStripMenuItem comparisonScale_400;
        private TableLayoutPanel tableLayoutPanel1;
        public DarkComboBox previewModels_comboBox;
        public Cyotek.Windows.Forms.ImageBox zoomImageBox;
        public TableLayoutPanel tableLayoutPanel6;
        public DarkButton previewUpdate_button;
        public Panel panel4;
        public DarkButton previewSaveOutputFormat_button;
        public SplitContainer splitContainer3;
        public Label imageSizeToolStripStatusLabel;
        public Cyotek.Windows.Forms.ImageBox miniMapImageBox;
        private DarkLabel darkLabel1;
        public TableLayoutPanel tableLayoutPanel3;
        public DarkProgressBar preview_progressBar;
        public Cyotek.Windows.Forms.ImageBox previewImageBox;
        public DarkComboBox zoomLevelsToolStripComboBox;
        public DarkButton showModelForm_button;
    }
}
