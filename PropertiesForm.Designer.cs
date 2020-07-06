namespace ImageEnhancingUtility.Winforms
{
    partial class PropertiesForm
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
            this.settings_propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // settings_propertyGrid
            // 
            this.settings_propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.settings_propertyGrid.Name = "settings_propertyGrid";
            this.settings_propertyGrid.Size = new System.Drawing.Size(509, 610);
            this.settings_propertyGrid.TabIndex = 0;
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 610);
            this.Controls.Add(this.settings_propertyGrid);
            this.Name = "PropertiesForm";
            this.Text = "PropertiesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid settings_propertyGrid;
    }
}