namespace ImageEnhancingUtility.Winforms
{
    partial class SortListForm
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
            this.chainPriority_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.chainModels_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chainPriority_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // chainPriority_numericUpDown
            // 
            this.chainPriority_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chainPriority_numericUpDown.Location = new System.Drawing.Point(393, 215);
            this.chainPriority_numericUpDown.Name = "chainPriority_numericUpDown";
            this.chainPriority_numericUpDown.ReadOnly = true;
            this.chainPriority_numericUpDown.Size = new System.Drawing.Size(66, 20);
            this.chainPriority_numericUpDown.TabIndex = 61;
            this.chainPriority_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chainPriority_numericUpDown.ValueChanged += new System.EventHandler(this.priority_numericUpDown_ValueChanged);
            // 
            // chainModels_listBox
            // 
            this.chainModels_listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chainModels_listBox.FormattingEnabled = true;
            this.chainModels_listBox.Location = new System.Drawing.Point(12, 12);
            this.chainModels_listBox.Name = "chainModels_listBox";
            this.chainModels_listBox.Size = new System.Drawing.Size(447, 197);
            this.chainModels_listBox.TabIndex = 60;
            this.chainModels_listBox.SelectedIndexChanged += new System.EventHandler(this.chainModels_listBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Selected model position";
            // 
            // SortListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chainPriority_numericUpDown);
            this.Controls.Add(this.chainModels_listBox);
            this.MaximumSize = new System.Drawing.Size(480, 275);
            this.MinimumSize = new System.Drawing.Size(480, 275);
            this.Name = "SortListForm";
            this.Text = "Model Chain";
            ((System.ComponentModel.ISupportInitialize)(this.chainPriority_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown chainPriority_numericUpDown;
        private System.Windows.Forms.ListBox chainModels_listBox;
        private System.Windows.Forms.Label label1;
    }
}