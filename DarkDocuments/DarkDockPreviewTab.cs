using AltUI.Config;
using AltUI.Controls;
using AltUI.Docking;
using AltUI.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace ImageEnhancingUtility.Winforms
{
    public partial class DarkDockPreviewTab : DarkDocument
    {
        #region Constructor Region

        public DarkDockPreviewTab()
        {
            InitializeComponent();         
        }

        public DarkDockPreviewTab(string text, Image icon)
            : this()
        {
            DockText = text;
            Icon = icon;
        }

        #endregion

        #region Event Handler Region

        public override void Close()
        {
            var result = DarkMessageBox.ShowWarning(@"You will lose any unsaved changes. Continue?", @"Close document", DarkDialogButton.YesNo);
            if (result == DialogResult.No)
                return;

            base.Close();
        }

        #endregion

        private void comparisonScale_Click(object sender, System.EventArgs e)
        {  
            foreach(var item in comaprisonScaleToolStripMenuItem.DropDownItems)            
               (item as ToolStripMenuItem).Checked = false;

            (sender as ToolStripMenuItem).Checked = true;
        }

        private void comaprisonScaleToolStripMenuItem_MouseEnter(object sender, System.EventArgs e)
        {
            comaprisonScaleToolStripMenuItem.DropDown.AutoClose = false;
            comparisonScale_050.DropDown.AutoClose = false;
            preview_ContextMenu.AutoClose = false;
        }

        private void comaprisonScaleToolStripMenuItem_MouseLeave(object sender, System.EventArgs e)
        {
            comaprisonScaleToolStripMenuItem.DropDown.AutoClose = true;
            comparisonScale_050.DropDown.AutoClose = true;
            preview_ContextMenu.AutoClose = true;
        }
    }   
}
