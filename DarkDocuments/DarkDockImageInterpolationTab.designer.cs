namespace ImageEnhancingUtility.Winforms
{
    partial class DarkDockImageInterpolationTab
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.overlayImages_button = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.imageBName_label = new System.Windows.Forms.Label();
            this.imageB_panel = new System.Windows.Forms.Panel();
            this.imageB_pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.imageAName_label = new System.Windows.Forms.Label();
            this.imageA_panel = new System.Windows.Forms.Panel();
            this.imageA_pictureBox = new System.Windows.Forms.PictureBox();
            this.overlayResultName_textBox = new System.Windows.Forms.TextBox();
            this.overlayFolders_button = new System.Windows.Forms.Button();
            this.imageInterpolationAlphaValue_textBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.changeResultsDestinationPath_button = new System.Windows.Forms.Button();
            this.originalImagesPath_textBox = new System.Windows.Forms.TextBox();
            this.changeResultsBPath_button = new System.Windows.Forms.Button();
            this.resultsAPath_textBox = new System.Windows.Forms.TextBox();
            this.changeResultsAPath_button = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.changeOriginalImagesPath_button = new System.Windows.Forms.Button();
            this.resultsBPath_textBox = new System.Windows.Forms.TextBox();
            this.resultsDestinationPath_textBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageInterpolation_trackBar = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.imageB_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageB_pictureBox)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.imageA_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageA_pictureBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageInterpolation_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.Controls.Add(this.overlayImages_button, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.overlayFolders_button, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.imageInterpolationAlphaValue_textBox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1082, 777);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // overlayImages_button
            // 
            this.overlayImages_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlayImages_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.overlayImages_button.Location = new System.Drawing.Point(985, 3);
            this.overlayImages_button.Name = "overlayImages_button";
            this.overlayImages_button.Size = new System.Drawing.Size(94, 546);
            this.overlayImages_button.TabIndex = 1;
            this.overlayImages_button.Text = "Interpolate";
            this.overlayImages_button.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(976, 546);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Interpolate two images";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox7, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.overlayResultName_textBox, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(970, 524);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.imageBName_label);
            this.groupBox7.Controls.Add(this.imageB_panel);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(488, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(479, 490);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Image B";
            // 
            // imageBName_label
            // 
            this.imageBName_label.AutoSize = true;
            this.imageBName_label.Location = new System.Drawing.Point(54, 0);
            this.imageBName_label.Name = "imageBName_label";
            this.imageBName_label.Size = new System.Drawing.Size(109, 15);
            this.imageBName_label.TabIndex = 6;
            this.imageBName_label.Text = "imageBName_label";
            // 
            // imageB_panel
            // 
            this.imageB_panel.AllowDrop = true;
            this.imageB_panel.Controls.Add(this.imageB_pictureBox);
            this.imageB_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageB_panel.Location = new System.Drawing.Point(3, 19);
            this.imageB_panel.Name = "imageB_panel";
            this.imageB_panel.Size = new System.Drawing.Size(473, 468);
            this.imageB_panel.TabIndex = 5;
            // 
            // imageB_pictureBox
            // 
            this.imageB_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageB_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.imageB_pictureBox.Name = "imageB_pictureBox";
            this.imageB_pictureBox.Size = new System.Drawing.Size(473, 468);
            this.imageB_pictureBox.TabIndex = 0;
            this.imageB_pictureBox.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.imageAName_label);
            this.groupBox6.Controls.Add(this.imageA_panel);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(479, 490);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Image A";
            // 
            // imageAName_label
            // 
            this.imageAName_label.AutoSize = true;
            this.imageAName_label.Location = new System.Drawing.Point(54, 0);
            this.imageAName_label.Name = "imageAName_label";
            this.imageAName_label.Size = new System.Drawing.Size(110, 15);
            this.imageAName_label.TabIndex = 6;
            this.imageAName_label.Text = "imageAName_label";
            // 
            // imageA_panel
            // 
            this.imageA_panel.AllowDrop = true;
            this.imageA_panel.Controls.Add(this.imageA_pictureBox);
            this.imageA_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageA_panel.Location = new System.Drawing.Point(3, 19);
            this.imageA_panel.Name = "imageA_panel";
            this.imageA_panel.Size = new System.Drawing.Size(473, 468);
            this.imageA_panel.TabIndex = 4;
            // 
            // imageA_pictureBox
            // 
            this.imageA_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageA_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.imageA_pictureBox.Name = "imageA_pictureBox";
            this.imageA_pictureBox.Size = new System.Drawing.Size(473, 468);
            this.imageA_pictureBox.TabIndex = 0;
            this.imageA_pictureBox.TabStop = false;
            // 
            // overlayResultName_textBox
            // 
            this.overlayResultName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel5.SetColumnSpan(this.overlayResultName_textBox, 2);
            this.overlayResultName_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlayResultName_textBox.Location = new System.Drawing.Point(3, 499);
            this.overlayResultName_textBox.Name = "overlayResultName_textBox";
            this.overlayResultName_textBox.Size = new System.Drawing.Size(964, 23);
            this.overlayResultName_textBox.TabIndex = 2;
            // 
            // overlayFolders_button
            // 
            this.overlayFolders_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlayFolders_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.overlayFolders_button.Location = new System.Drawing.Point(985, 605);
            this.overlayFolders_button.Name = "overlayFolders_button";
            this.overlayFolders_button.Size = new System.Drawing.Size(94, 169);
            this.overlayFolders_button.TabIndex = 1;
            this.overlayFolders_button.Text = "Interpolate";
            this.overlayFolders_button.UseVisualStyleBackColor = true;
            // 
            // imageInterpolationAlphaValue_textBox
            // 
            this.imageInterpolationAlphaValue_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageInterpolationAlphaValue_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageInterpolationAlphaValue_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.imageInterpolationAlphaValue_textBox.Location = new System.Drawing.Point(985, 564);
            this.imageInterpolationAlphaValue_textBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.imageInterpolationAlphaValue_textBox.Name = "imageInterpolationAlphaValue_textBox";
            this.imageInterpolationAlphaValue_textBox.ReadOnly = true;
            this.imageInterpolationAlphaValue_textBox.Size = new System.Drawing.Size(94, 21);
            this.imageInterpolationAlphaValue_textBox.TabIndex = 2;
            this.imageInterpolationAlphaValue_textBox.Text = "0.5";
            this.imageInterpolationAlphaValue_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.changeResultsDestinationPath_button);
            this.groupBox5.Controls.Add(this.originalImagesPath_textBox);
            this.groupBox5.Controls.Add(this.changeResultsBPath_button);
            this.groupBox5.Controls.Add(this.resultsAPath_textBox);
            this.groupBox5.Controls.Add(this.changeResultsAPath_button);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.changeOriginalImagesPath_button);
            this.groupBox5.Controls.Add(this.resultsBPath_textBox);
            this.groupBox5.Controls.Add(this.resultsDestinationPath_textBox);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Location = new System.Drawing.Point(3, 605);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1, 169);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Interpolate two folders";
            // 
            // changeResultsDestinationPath_button
            // 
            this.changeResultsDestinationPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeResultsDestinationPath_button.Location = new System.Drawing.Point(616, 126);
            this.changeResultsDestinationPath_button.Name = "changeResultsDestinationPath_button";
            this.changeResultsDestinationPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeResultsDestinationPath_button.TabIndex = 36;
            this.changeResultsDestinationPath_button.Text = "...";
            this.changeResultsDestinationPath_button.UseVisualStyleBackColor = true;
            // 
            // originalImagesPath_textBox
            // 
            this.originalImagesPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalImagesPath_textBox.Location = new System.Drawing.Point(57, 34);
            this.originalImagesPath_textBox.Name = "originalImagesPath_textBox";
            this.originalImagesPath_textBox.ReadOnly = true;
            this.originalImagesPath_textBox.Size = new System.Drawing.Size(553, 23);
            this.originalImagesPath_textBox.TabIndex = 30;
            // 
            // changeResultsBPath_button
            // 
            this.changeResultsBPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeResultsBPath_button.Location = new System.Drawing.Point(616, 86);
            this.changeResultsBPath_button.Name = "changeResultsBPath_button";
            this.changeResultsBPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeResultsBPath_button.TabIndex = 36;
            this.changeResultsBPath_button.Text = "...";
            this.changeResultsBPath_button.UseVisualStyleBackColor = true;
            // 
            // resultsAPath_textBox
            // 
            this.resultsAPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsAPath_textBox.Location = new System.Drawing.Point(57, 60);
            this.resultsAPath_textBox.Name = "resultsAPath_textBox";
            this.resultsAPath_textBox.ReadOnly = true;
            this.resultsAPath_textBox.Size = new System.Drawing.Size(553, 23);
            this.resultsAPath_textBox.TabIndex = 31;
            // 
            // changeResultsAPath_button
            // 
            this.changeResultsAPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeResultsAPath_button.Location = new System.Drawing.Point(616, 61);
            this.changeResultsAPath_button.Name = "changeResultsAPath_button";
            this.changeResultsAPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeResultsAPath_button.TabIndex = 37;
            this.changeResultsAPath_button.Text = "...";
            this.changeResultsAPath_button.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(13, 38);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 15);
            this.label30.TabIndex = 32;
            this.label30.Text = "Original";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(17, 130);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(39, 15);
            this.label31.TabIndex = 35;
            this.label31.Text = "Result";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(8, 64);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(50, 15);
            this.label29.TabIndex = 33;
            this.label29.Text = "Result A";
            // 
            // changeOriginalImagesPath_button
            // 
            this.changeOriginalImagesPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeOriginalImagesPath_button.Location = new System.Drawing.Point(616, 35);
            this.changeOriginalImagesPath_button.Name = "changeOriginalImagesPath_button";
            this.changeOriginalImagesPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeOriginalImagesPath_button.TabIndex = 38;
            this.changeOriginalImagesPath_button.Text = "...";
            this.changeOriginalImagesPath_button.UseVisualStyleBackColor = true;
            // 
            // resultsBPath_textBox
            // 
            this.resultsBPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsBPath_textBox.Location = new System.Drawing.Point(57, 86);
            this.resultsBPath_textBox.Name = "resultsBPath_textBox";
            this.resultsBPath_textBox.ReadOnly = true;
            this.resultsBPath_textBox.Size = new System.Drawing.Size(553, 23);
            this.resultsBPath_textBox.TabIndex = 34;
            // 
            // resultsDestinationPath_textBox
            // 
            this.resultsDestinationPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsDestinationPath_textBox.Location = new System.Drawing.Point(57, 126);
            this.resultsDestinationPath_textBox.Name = "resultsDestinationPath_textBox";
            this.resultsDestinationPath_textBox.ReadOnly = true;
            this.resultsDestinationPath_textBox.Size = new System.Drawing.Size(553, 23);
            this.resultsDestinationPath_textBox.TabIndex = 34;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 89);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(49, 15);
            this.label28.TabIndex = 35;
            this.label28.Text = "Result B";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.imageInterpolation_trackBar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 555);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(976, 44);
            this.panel3.TabIndex = 6;
            // 
            // imageInterpolation_trackBar
            // 
            this.imageInterpolation_trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageInterpolation_trackBar.LargeChange = 10;
            this.imageInterpolation_trackBar.Location = new System.Drawing.Point(0, 0);
            this.imageInterpolation_trackBar.Maximum = 99;
            this.imageInterpolation_trackBar.Minimum = 1;
            this.imageInterpolation_trackBar.Name = "imageInterpolation_trackBar";
            this.imageInterpolation_trackBar.Size = new System.Drawing.Size(976, 44);
            this.imageInterpolation_trackBar.TabIndex = 5;
            this.imageInterpolation_trackBar.Value = 50;
            // 
            // DarkDockImageInterpolationTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DarkDockImageInterpolationTab";
            this.Size = new System.Drawing.Size(1082, 777);
            this.Load += new System.EventHandler(this.DockDocument_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.imageB_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageB_pictureBox)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.imageA_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageA_pictureBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageInterpolation_trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        public System.Windows.Forms.Button overlayImages_button;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        public System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.Label imageBName_label;
        public System.Windows.Forms.Panel imageB_panel;
        public System.Windows.Forms.PictureBox imageB_pictureBox;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.Label imageAName_label;
        public System.Windows.Forms.Panel imageA_panel;
        public System.Windows.Forms.PictureBox imageA_pictureBox;
        public System.Windows.Forms.TextBox overlayResultName_textBox;
        public System.Windows.Forms.Button overlayFolders_button;
        public System.Windows.Forms.TextBox imageInterpolationAlphaValue_textBox;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Button changeResultsDestinationPath_button;
        public System.Windows.Forms.TextBox originalImagesPath_textBox;
        public System.Windows.Forms.Button changeResultsBPath_button;
        public System.Windows.Forms.TextBox resultsAPath_textBox;
        public System.Windows.Forms.Button changeResultsAPath_button;
        public System.Windows.Forms.Label label30;
        public System.Windows.Forms.Label label31;
        public System.Windows.Forms.Label label29;
        public System.Windows.Forms.Button changeOriginalImagesPath_button;
        public System.Windows.Forms.TextBox resultsBPath_textBox;
        public System.Windows.Forms.TextBox resultsDestinationPath_textBox;
        public System.Windows.Forms.Label label28;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TrackBar imageInterpolation_trackBar;
    }
}
