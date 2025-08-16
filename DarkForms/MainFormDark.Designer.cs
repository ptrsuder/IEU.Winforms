namespace ImageEnhancingUtility.Winforms
{
    partial class MainFormDark
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormDark));
            this.treeView_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openModelFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshModelList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.popupNotifier1 = new Tulpep.NotificationWindow.PopupNotifier();
            this.darkDockPanel1 = new AltUI.Docking.DarkDockPanel();
            this.treeView_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView_contextMenuStrip
            // 
            this.treeView_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openModelFolder,
            this.refreshModelList});
            this.treeView_contextMenuStrip.Name = "treeView_contextMenuStrip";
            this.treeView_contextMenuStrip.Size = new System.Drawing.Size(175, 48);
            // 
            // openModelFolder
            // 
            this.openModelFolder.Name = "openModelFolder";
            this.openModelFolder.Size = new System.Drawing.Size(174, 22);
            this.openModelFolder.Text = "Open model folder";
            // 
            // refreshModelList
            // 
            this.refreshModelList.Name = "refreshModelList";
            this.refreshModelList.Size = new System.Drawing.Size(174, 22);
            this.refreshModelList.Text = "Refresh models";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            // 
            // popupNotifier1
            // 
            this.popupNotifier1.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            this.popupNotifier1.ContentText = null;
            this.popupNotifier1.Image = null;
            this.popupNotifier1.IsRightToLeft = false;
            this.popupNotifier1.OptionsMenu = null;
            this.popupNotifier1.Size = new System.Drawing.Size(400, 100);
            this.popupNotifier1.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.popupNotifier1.TitleText = null;
            // 
            // darkDockPanel1
            // 
            this.darkDockPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkDockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.darkDockPanel1.Name = "darkDockPanel1";
            this.darkDockPanel1.Size = new System.Drawing.Size(984, 861);
            this.darkDockPanel1.TabIndex = 1;
            this.darkDockPanel1.Vertical = false;
            // 
            // MainFormDark
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 861);
            this.Controls.Add(this.darkDockPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(820, 750);
            this.Name = "MainFormDark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Enhancing Utility";
            this.Activated += new System.EventHandler(this.MainForm_Enter);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.DoubleClick += new System.EventHandler(this.MainForm_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.treeView_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip treeView_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openModelFolder;
        private Tulpep.NotificationWindow.PopupNotifier popupNotifier1;
        private System.Windows.Forms.ToolStripMenuItem refreshModelList;
        private AltUI.Docking.DarkDockPanel darkDockPanel1;
    }
}

