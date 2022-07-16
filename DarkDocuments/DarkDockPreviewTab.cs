using AltUI.Config;
using AltUI.Controls;
using AltUI.Docking;
using AltUI.Forms;
using System.Drawing;
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

        private void DockDocument_Load(object sender, System.EventArgs e)
        {

        }

        private void previewShowSaveDialog_checkBox_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void label35_Click(object sender, System.EventArgs e)
        {

        }

        private void imageSizeToolStripStatusLabel_Click(object sender, System.EventArgs e)
        {

        }

        private void preview_progressBar_Click(object sender, System.EventArgs e)
        {

        }
    }
}
