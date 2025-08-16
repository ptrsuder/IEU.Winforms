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
            this.preview_ContextMenu = new AltUI.Controls.DarkContextMenu();
            this.saveComparisonToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comaprisonScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparisonScale_025 = new System.Windows.Forms.ToolStripMenuItem();
            this.comparisonScale_050 = new System.Windows.Forms.ToolStripMenuItem();
            this.comparisonScale_100 = new System.Windows.Forms.ToolStripMenuItem();
            this.comparisonScale_200 = new System.Windows.Forms.ToolStripMenuItem();
            this.comparisonScale_400 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new AltUI.Controls.DarkToolStrip();
            this.openFromFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.actualSizeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomInToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomOutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.showModelForm_button = new AltUI.Controls.DarkButton();
            this.previewModels_comboBox = new AltUI.Controls.DarkComboBox();
            this.zoomImageBox = new Cyotek.Windows.Forms.ImageBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.previewUpdate_button = new AltUI.Controls.DarkButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.previewSaveOutputFormat_button = new AltUI.Controls.DarkButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.imageSizeToolStripStatusLabel = new System.Windows.Forms.Label();
            this.miniMapImageBox = new Cyotek.Windows.Forms.ImageBox();
            this.darkLabel1 = new AltUI.Controls.DarkLabel();
            this.previewImageBox = new Cyotek.Windows.Forms.ImageBox();
            this.preview_progressBar = new AltUI.Controls.DarkProgressBar();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.zoomLevelsToolStripComboBox = new AltUI.Controls.DarkComboBox();
            this.preview_ContextMenu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // preview_ContextMenu
            // 
            this.preview_ContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.preview_ContextMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.preview_ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveComparisonToClipboardToolStripMenuItem,
            this.comaprisonScaleToolStripMenuItem});
            this.preview_ContextMenu.Name = "preview_ContextMenu";
            this.preview_ContextMenu.Size = new System.Drawing.Size(232, 48);
            // 
            // saveComparisonToClipboardToolStripMenuItem
            // 
            this.saveComparisonToClipboardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.saveComparisonToClipboardToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.saveComparisonToClipboardToolStripMenuItem.Name = "saveComparisonToClipboardToolStripMenuItem";
            this.saveComparisonToClipboardToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.saveComparisonToClipboardToolStripMenuItem.Text = "Save comparison to clipboard";
            // 
            // comaprisonScaleToolStripMenuItem
            // 
            this.comaprisonScaleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.comaprisonScaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comparisonScale_025,
            this.comparisonScale_050,
            this.comparisonScale_100,
            this.comparisonScale_200,
            this.comparisonScale_400});
            this.comaprisonScaleToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comaprisonScaleToolStripMenuItem.Name = "comaprisonScaleToolStripMenuItem";
            this.comaprisonScaleToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.comaprisonScaleToolStripMenuItem.Text = "Comaprison scale";
            this.comaprisonScaleToolStripMenuItem.MouseEnter += new System.EventHandler(this.comaprisonScaleToolStripMenuItem_MouseEnter);
            this.comaprisonScaleToolStripMenuItem.MouseLeave += new System.EventHandler(this.comaprisonScaleToolStripMenuItem_MouseLeave);
            // 
            // comparisonScale_025
            // 
            this.comparisonScale_025.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.comparisonScale_025.CheckOnClick = true;
            this.comparisonScale_025.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comparisonScale_025.Name = "comparisonScale_025";
            this.comparisonScale_025.Size = new System.Drawing.Size(102, 22);
            this.comparisonScale_025.Tag = "0.25";
            this.comparisonScale_025.Text = "25%";
            this.comparisonScale_025.Click += new System.EventHandler(this.comparisonScale_Click);
            this.comparisonScale_025.MouseEnter += new System.EventHandler(this.comaprisonScaleToolStripMenuItem_MouseEnter);
            this.comparisonScale_025.MouseLeave += new System.EventHandler(this.comaprisonScaleToolStripMenuItem_MouseLeave);
            // 
            // comparisonScale_050
            // 
            this.comparisonScale_050.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.comparisonScale_050.CheckOnClick = true;
            this.comparisonScale_050.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comparisonScale_050.Name = "comparisonScale_050";
            this.comparisonScale_050.Size = new System.Drawing.Size(102, 22);
            this.comparisonScale_050.Tag = "0.50";
            this.comparisonScale_050.Text = "50%";
            this.comparisonScale_050.Click += new System.EventHandler(this.comparisonScale_Click);
            this.comparisonScale_050.MouseEnter += new System.EventHandler(this.comaprisonScaleToolStripMenuItem_MouseEnter);
            this.comparisonScale_050.MouseLeave += new System.EventHandler(this.comaprisonScaleToolStripMenuItem_MouseLeave);
            // 
            // comparisonScale_100
            // 
            this.comparisonScale_100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.comparisonScale_100.CheckOnClick = true;
            this.comparisonScale_100.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comparisonScale_100.Name = "comparisonScale_100";
            this.comparisonScale_100.Size = new System.Drawing.Size(102, 22);
            this.comparisonScale_100.Tag = "1.0";
            this.comparisonScale_100.Text = "100%";
            this.comparisonScale_100.Click += new System.EventHandler(this.comparisonScale_Click);
            this.comparisonScale_100.MouseEnter += new System.EventHandler(this.comaprisonScaleToolStripMenuItem_MouseEnter);
            this.comparisonScale_100.MouseLeave += new System.EventHandler(this.comaprisonScaleToolStripMenuItem_MouseLeave);
            // 
            // comparisonScale_200
            // 
            this.comparisonScale_200.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.comparisonScale_200.CheckOnClick = true;
            this.comparisonScale_200.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comparisonScale_200.Name = "comparisonScale_200";
            this.comparisonScale_200.Size = new System.Drawing.Size(102, 22);
            this.comparisonScale_200.Tag = "2.0";
            this.comparisonScale_200.Text = "200%";
            this.comparisonScale_200.Click += new System.EventHandler(this.comparisonScale_Click);
            this.comparisonScale_200.MouseEnter += new System.EventHandler(this.comaprisonScaleToolStripMenuItem_MouseEnter);
            this.comparisonScale_200.MouseLeave += new System.EventHandler(this.comaprisonScaleToolStripMenuItem_MouseLeave);
            // 
            // comparisonScale_400
            // 
            this.comparisonScale_400.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.comparisonScale_400.CheckOnClick = true;
            this.comparisonScale_400.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comparisonScale_400.Name = "comparisonScale_400";
            this.comparisonScale_400.Size = new System.Drawing.Size(102, 22);
            this.comparisonScale_400.Tag = "4.0";
            this.comparisonScale_400.Text = "400%";
            this.comparisonScale_400.Click += new System.EventHandler(this.comparisonScale_Click);
            this.comparisonScale_400.MouseEnter += new System.EventHandler(this.comaprisonScaleToolStripMenuItem_MouseEnter);
            this.comparisonScale_400.MouseLeave += new System.EventHandler(this.comaprisonScaleToolStripMenuItem_MouseLeave);
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
            this.toolStripSeparator2});
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
            this.actualSizeToolStripButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.actualSizeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.actualSizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actualSizeToolStripButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
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
            this.zoomInToolStripButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.zoomInToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.zoomInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInToolStripButton.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.zoomInToolStripButton.Name = "zoomInToolStripButton";
            this.zoomInToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.zoomInToolStripButton.Text = "Zoom In";
            // 
            // zoomOutToolStripButton
            // 
            this.zoomOutToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.zoomOutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.zoomOutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutToolStripButton.Image")));
            this.zoomOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutToolStripButton.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.zoomOutToolStripButton.Name = "zoomOutToolStripButton";
            this.zoomOutToolStripButton.Size = new System.Drawing.Size(23, 20);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.54205F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.45794F));
            this.tableLayoutPanel1.Controls.Add(this.showModelForm_button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.previewModels_comboBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(544, 570);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 25);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // showModelForm_button
            // 
            this.showModelForm_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.showModelForm_button.FlatBottom = false;
            this.showModelForm_button.FlatTop = false;
            this.showModelForm_button.HoldColour = false;
            this.showModelForm_button.Location = new System.Drawing.Point(469, 0);
            this.showModelForm_button.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.showModelForm_button.Name = "showModelForm_button";
            this.showModelForm_button.Padding = new System.Windows.Forms.Padding(5);
            this.showModelForm_button.Size = new System.Drawing.Size(66, 24);
            this.showModelForm_button.TabIndex = 0;
            this.showModelForm_button.Text = "...";
            // 
            // previewModels_comboBox
            // 
            this.previewModels_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.previewModels_comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewModels_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.previewModels_comboBox.FormattingEnabled = true;
            this.previewModels_comboBox.Location = new System.Drawing.Point(0, 0);
            this.previewModels_comboBox.Margin = new System.Windows.Forms.Padding(0);
            this.previewModels_comboBox.Name = "previewModels_comboBox";
            this.previewModels_comboBox.Size = new System.Drawing.Size(463, 24);
            this.previewModels_comboBox.TabIndex = 6;
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
            this.previewUpdate_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previewUpdate_button.HoldColour = false;
            this.previewUpdate_button.ImagePadding = 0;
            this.previewUpdate_button.Location = new System.Drawing.Point(0, 0);
            this.previewUpdate_button.Margin = new System.Windows.Forms.Padding(0);
            this.previewUpdate_button.Name = "previewUpdate_button";
            this.previewUpdate_button.Padding = new System.Windows.Forms.Padding(5);
            this.previewUpdate_button.Size = new System.Drawing.Size(267, 126);
            this.previewUpdate_button.TabIndex = 6;
            this.previewUpdate_button.Text = "Enhance Preview";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.previewSaveOutputFormat_button);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(267, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 126);
            this.panel4.TabIndex = 7;
            // 
            // previewSaveOutputFormat_button
            // 
            this.previewSaveOutputFormat_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewSaveOutputFormat_button.FlatBottom = false;
            this.previewSaveOutputFormat_button.FlatTop = false;
            this.previewSaveOutputFormat_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previewSaveOutputFormat_button.HoldColour = false;
            this.previewSaveOutputFormat_button.ImagePadding = 0;
            this.previewSaveOutputFormat_button.Location = new System.Drawing.Point(5, 0);
            this.previewSaveOutputFormat_button.Margin = new System.Windows.Forms.Padding(0);
            this.previewSaveOutputFormat_button.Name = "previewSaveOutputFormat_button";
            this.previewSaveOutputFormat_button.Padding = new System.Windows.Forms.Padding(5);
            this.previewSaveOutputFormat_button.Size = new System.Drawing.Size(263, 126);
            this.previewSaveOutputFormat_button.TabIndex = 9;
            this.previewSaveOutputFormat_button.Text = "Enhance Image";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(3, 570);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.imageSizeToolStripStatusLabel);
            this.splitContainer3.Panel1.Controls.Add(this.miniMapImageBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.darkLabel1);
            this.tableLayoutPanel3.SetRowSpan(this.splitContainer3, 2);
            this.splitContainer3.Size = new System.Drawing.Size(535, 157);
            this.splitContainer3.SplitterDistance = 200;
            this.splitContainer3.TabIndex = 9;
            // 
            // imageSizeToolStripStatusLabel
            // 
            this.imageSizeToolStripStatusLabel.AutoSize = true;
            this.imageSizeToolStripStatusLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.imageSizeToolStripStatusLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.imageSizeToolStripStatusLabel.Location = new System.Drawing.Point(0, 0);
            this.imageSizeToolStripStatusLabel.Name = "imageSizeToolStripStatusLabel";
            this.imageSizeToolStripStatusLabel.Size = new System.Drawing.Size(48, 15);
            this.imageSizeToolStripStatusLabel.TabIndex = 0;
            this.imageSizeToolStripStatusLabel.Text = "W:0 H:0";
            this.imageSizeToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.miniMapImageBox.Location = new System.Drawing.Point(2, 23);
            this.miniMapImageBox.Name = "miniMapImageBox";
            this.miniMapImageBox.PanMode = Cyotek.Windows.Forms.ImageBoxPanMode.Middle;
            this.miniMapImageBox.PixelGridColor = System.Drawing.Color.Transparent;
            this.miniMapImageBox.Size = new System.Drawing.Size(130, 130);
            this.miniMapImageBox.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.miniMapImageBox.TabIndex = 1;
            this.miniMapImageBox.TabStop = false;
            this.miniMapImageBox.VirtualMode = true;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.darkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.darkLabel1.Location = new System.Drawing.Point(282, 0);
            this.darkLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.darkLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.darkLabel1.Size = new System.Drawing.Size(49, 23);
            this.darkLabel1.TabIndex = 0;
            this.darkLabel1.Text = "Model:";
            this.darkLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.previewImageBox.ContextMenuStrip = this.preview_ContextMenu;
            this.previewImageBox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.previewImageBox.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.previewImageBox.Location = new System.Drawing.Point(544, 3);
            this.previewImageBox.Name = "previewImageBox";
            this.previewImageBox.Size = new System.Drawing.Size(535, 561);
            this.previewImageBox.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.previewImageBox.TabIndex = 4;
            this.previewImageBox.TabStop = false;
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.preview_progressBar, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.previewImageBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.splitContainer3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.zoomImageBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 1);
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
            // zoomLevelsToolStripComboBox
            // 
            this.zoomLevelsToolStripComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.zoomLevelsToolStripComboBox.Location = new System.Drawing.Point(124, 2);
            this.zoomLevelsToolStripComboBox.Name = "zoomLevelsToolStripComboBox";
            this.zoomLevelsToolStripComboBox.Size = new System.Drawing.Size(65, 24);
            this.zoomLevelsToolStripComboBox.TabIndex = 0;
            // 
            // DarkDockPreviewTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.zoomLevelsToolStripComboBox);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DarkDockPreviewTab";
            this.Size = new System.Drawing.Size(1082, 777);
            this.preview_ContextMenu.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

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
