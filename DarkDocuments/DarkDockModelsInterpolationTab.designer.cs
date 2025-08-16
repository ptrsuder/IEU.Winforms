using AltUI.Controls;

namespace ImageEnhancingUtility.Winforms
{
    partial class DarkDockModIntTab
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
            this.modelInterpolationAlpha_trackBar = new System.Windows.Forms.TrackBar();
            this.interpolationOutputModelName_textBox = new AltUI.Controls.DarkTextBox();
            this.modelInterpolationAlphaValue_textBox = new AltUI.Controls.DarkTextBox();
            this.interpolationStart_button = new AltUI.Controls.DarkButton();
            this.interpolationModelTwo_comboBox = new AltUI.Controls.DarkComboBox();
            this.interpolationModelOne_comboBox = new AltUI.Controls.DarkComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.modelInterpolationAlpha_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // modelInterpolationAlpha_trackBar
            // 
            this.modelInterpolationAlpha_trackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modelInterpolationAlpha_trackBar.LargeChange = 10;
            this.modelInterpolationAlpha_trackBar.Location = new System.Drawing.Point(167, 128);
            this.modelInterpolationAlpha_trackBar.Maximum = 99;
            this.modelInterpolationAlpha_trackBar.Minimum = 1;
            this.modelInterpolationAlpha_trackBar.Name = "modelInterpolationAlpha_trackBar";
            this.modelInterpolationAlpha_trackBar.Size = new System.Drawing.Size(428, 45);
            this.modelInterpolationAlpha_trackBar.TabIndex = 10;
            this.modelInterpolationAlpha_trackBar.Value = 50;
            // 
            // interpolationOutputModelName_textBox
            // 
            this.interpolationOutputModelName_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.interpolationOutputModelName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.interpolationOutputModelName_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.interpolationOutputModelName_textBox.Location = new System.Drawing.Point(167, 179);
            this.interpolationOutputModelName_textBox.Name = "interpolationOutputModelName_textBox";
            this.interpolationOutputModelName_textBox.Size = new System.Drawing.Size(428, 23);
            this.interpolationOutputModelName_textBox.TabIndex = 9;
            // 
            // modelInterpolationAlphaValue_textBox
            // 
            this.modelInterpolationAlphaValue_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.modelInterpolationAlphaValue_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelInterpolationAlphaValue_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.modelInterpolationAlphaValue_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.modelInterpolationAlphaValue_textBox.Location = new System.Drawing.Point(601, 79);
            this.modelInterpolationAlphaValue_textBox.Name = "modelInterpolationAlphaValue_textBox";
            this.modelInterpolationAlphaValue_textBox.ReadOnly = true;
            this.modelInterpolationAlphaValue_textBox.Size = new System.Drawing.Size(63, 21);
            this.modelInterpolationAlphaValue_textBox.TabIndex = 7;
            this.modelInterpolationAlphaValue_textBox.Text = "0.5";
            this.modelInterpolationAlphaValue_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // interpolationStart_button
            // 
            this.interpolationStart_button.FlatBottom = false;
            this.interpolationStart_button.FlatTop = false;
            this.interpolationStart_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.interpolationStart_button.HoldColour = false;
            this.interpolationStart_button.Location = new System.Drawing.Point(167, 215);
            this.interpolationStart_button.Name = "interpolationStart_button";
            this.interpolationStart_button.Padding = new System.Windows.Forms.Padding(5);
            this.interpolationStart_button.Size = new System.Drawing.Size(428, 53);
            this.interpolationStart_button.TabIndex = 8;
            this.interpolationStart_button.Text = "INTERPOLATE";
            // 
            // interpolationModelTwo_comboBox
            // 
            this.interpolationModelTwo_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.interpolationModelTwo_comboBox.FormattingEnabled = true;
            this.interpolationModelTwo_comboBox.Location = new System.Drawing.Point(167, 101);
            this.interpolationModelTwo_comboBox.Name = "interpolationModelTwo_comboBox";
            this.interpolationModelTwo_comboBox.Size = new System.Drawing.Size(428, 24);
            this.interpolationModelTwo_comboBox.TabIndex = 5;
            // 
            // interpolationModelOne_comboBox
            // 
            this.interpolationModelOne_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.interpolationModelOne_comboBox.FormattingEnabled = true;
            this.interpolationModelOne_comboBox.Location = new System.Drawing.Point(167, 61);
            this.interpolationModelOne_comboBox.Name = "interpolationModelOne_comboBox";
            this.interpolationModelOne_comboBox.Size = new System.Drawing.Size(428, 24);
            this.interpolationModelOne_comboBox.TabIndex = 6;
            // 
            // DarkDockModIntTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modelInterpolationAlpha_trackBar);
            this.Controls.Add(this.interpolationOutputModelName_textBox);
            this.Controls.Add(this.modelInterpolationAlphaValue_textBox);
            this.Controls.Add(this.interpolationStart_button);
            this.Controls.Add(this.interpolationModelTwo_comboBox);
            this.Controls.Add(this.interpolationModelOne_comboBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DarkDockModIntTab";
            this.Size = new System.Drawing.Size(1082, 777);
            this.Load += new System.EventHandler(this.DockDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelInterpolationAlpha_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TrackBar modelInterpolationAlpha_trackBar;
        public DarkTextBox interpolationOutputModelName_textBox;
        public DarkTextBox modelInterpolationAlphaValue_textBox;
        public DarkButton interpolationStart_button;
        public DarkComboBox interpolationModelTwo_comboBox;
        public DarkComboBox interpolationModelOne_comboBox;
    }
}
