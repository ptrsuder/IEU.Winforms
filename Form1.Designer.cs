namespace ImageEnhancingUtility.Winforms
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.openFromFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.actualSizeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomInToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomOutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomLevelsToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.miniMapImageBox = new Cyotek.Windows.Forms.ImageBox();
            this.zoomImageBox = new Cyotek.Windows.Forms.ImageBox();
            this.imageSizeToolStripStatusLabel = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
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
            this.toolStrip.Size = new System.Drawing.Size(994, 25);
            this.toolStrip.TabIndex = 4;
            // 
            // openFromFileToolStripButton
            // 
            this.openFromFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFromFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openFromFileToolStripButton.Image")));
            this.openFromFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFromFileToolStripButton.Name = "openFromFileToolStripButton";
            this.openFromFileToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openFromFileToolStripButton.Text = "&Open";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // actualSizeToolStripButton
            // 
            this.actualSizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actualSizeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("actualSizeToolStripButton.Image")));
            this.actualSizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actualSizeToolStripButton.Name = "actualSizeToolStripButton";
            this.actualSizeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.actualSizeToolStripButton.Text = "Actual Size";
            // 
            // zoomInToolStripButton
            // 
            this.zoomInToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomInToolStripButton.Image")));
            this.zoomInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInToolStripButton.Name = "zoomInToolStripButton";
            this.zoomInToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zoomInToolStripButton.Text = "Zoom In";
            // 
            // zoomOutToolStripButton
            // 
            this.zoomOutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutToolStripButton.Image")));
            this.zoomOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutToolStripButton.Name = "zoomOutToolStripButton";
            this.zoomOutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zoomOutToolStripButton.Text = "Zoom Out";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // zoomLevelsToolStripComboBox
            // 
            this.zoomLevelsToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zoomLevelsToolStripComboBox.Name = "zoomLevelsToolStripComboBox";
            this.zoomLevelsToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // miniMapImageBox
            // 
            this.miniMapImageBox.AllowZoom = false;
            this.miniMapImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.miniMapImageBox.AutoPan = false;
            this.miniMapImageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.miniMapImageBox.GridColor = System.Drawing.SystemColors.Control;
            this.miniMapImageBox.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.miniMapImageBox.Location = new System.Drawing.Point(12, 432);
            this.miniMapImageBox.Name = "miniMapImageBox";
            this.miniMapImageBox.PanMode = Cyotek.Windows.Forms.ImageBoxPanMode.Middle;
            this.miniMapImageBox.PixelGridColor = System.Drawing.Color.Transparent;
            this.miniMapImageBox.Size = new System.Drawing.Size(129, 127);
            this.miniMapImageBox.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.miniMapImageBox.TabIndex = 5;
            this.miniMapImageBox.TabStop = false;
            this.miniMapImageBox.VirtualMode = true;
            // 
            // zoomImageBox
            // 
            this.zoomImageBox.AllowDrop = true;
            this.zoomImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoomImageBox.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.zoomImageBox.GridColorAlternate = System.Drawing.SystemColors.ControlDark;
            this.zoomImageBox.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.zoomImageBox.Location = new System.Drawing.Point(12, 59);
            this.zoomImageBox.Name = "zoomImageBox";
            this.zoomImageBox.Size = new System.Drawing.Size(301, 294);
            this.zoomImageBox.TabIndex = 6;
            this.zoomImageBox.TabStop = false;
            // 
            // imageSizeToolStripStatusLabel
            // 
            this.imageSizeToolStripStatusLabel.AutoSize = true;
            this.imageSizeToolStripStatusLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.imageSizeToolStripStatusLabel.Location = new System.Drawing.Point(947, 25);
            this.imageSizeToolStripStatusLabel.Name = "imageSizeToolStripStatusLabel";
            this.imageSizeToolStripStatusLabel.Size = new System.Drawing.Size(47, 13);
            this.imageSizeToolStripStatusLabel.TabIndex = 7;
            this.imageSizeToolStripStatusLabel.Text = "W:0 H:0";
            this.imageSizeToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 596);
            this.Controls.Add(this.imageSizeToolStripStatusLabel);
            this.Controls.Add(this.zoomImageBox);
            this.Controls.Add(this.miniMapImageBox);
            this.Controls.Add(this.toolStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton openFromFileToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton actualSizeToolStripButton;
        private System.Windows.Forms.ToolStripButton zoomInToolStripButton;
        private System.Windows.Forms.ToolStripButton zoomOutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox zoomLevelsToolStripComboBox;
        private Cyotek.Windows.Forms.ImageBox miniMapImageBox;
        private Cyotek.Windows.Forms.ImageBox zoomImageBox;
        private System.Windows.Forms.Label imageSizeToolStripStatusLabel;
    }
}