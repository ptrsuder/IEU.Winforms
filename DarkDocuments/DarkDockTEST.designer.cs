namespace ImageEnhancingUtility.Winforms
{
    partial class DarkDockTest
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
            this.darkDockPanel1 = new AltUI.Docking.DarkDockPanel();
            this.darkTreeView1 = new AltUI.Controls.DarkTreeView();
            this.darkSectionPanel1 = new AltUI.Controls.DarkSectionPanel();
            this.darkSectionPanel2 = new AltUI.Controls.DarkSectionPanel();
            this.darkSectionPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkDockPanel1
            // 
            this.darkDockPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.darkDockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.darkDockPanel1.Name = "darkDockPanel1";
            this.darkDockPanel1.Size = new System.Drawing.Size(1082, 777);
            this.darkDockPanel1.TabIndex = 0;
            // 
            // darkTreeView1
            // 
            this.darkTreeView1.Location = new System.Drawing.Point(0, 28);
            this.darkTreeView1.MaxDragChange = 20;
            this.darkTreeView1.Name = "darkTreeView1";
            this.darkTreeView1.Size = new System.Drawing.Size(294, 419);
            this.darkTreeView1.TabIndex = 1;
            this.darkTreeView1.Text = "darkTreeView1";
            this.darkTreeView1.SelectedNodesChanged += new System.EventHandler(this.darkTreeView1_SelectedNodesChanged);
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.darkTreeView1);
            this.darkSectionPanel1.Location = new System.Drawing.Point(74, 114);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = null;
            this.darkSectionPanel1.Size = new System.Drawing.Size(294, 288);
            this.darkSectionPanel1.TabIndex = 2;
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Location = new System.Drawing.Point(374, 114);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = null;
            this.darkSectionPanel2.Size = new System.Drawing.Size(444, 288);
            this.darkSectionPanel2.TabIndex = 3;
            // 
            // DarkDockTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.darkSectionPanel1);
            this.Controls.Add(this.darkDockPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DarkDockTest";
            this.Size = new System.Drawing.Size(1082, 777);
            this.Load += new System.EventHandler(this.DockDocument_Load);
            this.darkSectionPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AltUI.Docking.DarkDockPanel darkDockPanel1;
        private AltUI.Controls.DarkTreeView darkTreeView1;
        private AltUI.Controls.DarkSectionPanel darkSectionPanel1;
        private AltUI.Controls.DarkSectionPanel darkSectionPanel2;
    }
}
