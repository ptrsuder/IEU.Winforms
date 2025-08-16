using AltUI.Config;
using AltUI.Controls;
using AltUI.Docking;
using AltUI.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace ImageEnhancingUtility.Winforms
{
    public partial class DarkDockImageInterpolationTab : DarkDocument
    {
        #region Constructor Region

        public DarkDockImageInterpolationTab()
        {
            InitializeComponent();         
        }

        public DarkDockImageInterpolationTab(string text, Image icon)
            : this()
        {
            DockText = text;
            Icon = icon;
        }

        #endregion

        #region Event Handler Region

        public override void Close()
        {
            return;
            var result = DarkMessageBox.ShowWarning(@"You will lose any unsaved changes. Continue?", @"Close document", DarkDialogButton.YesNo);
            if (result == DialogResult.No)
                return;

            base.Close();
        }

        #endregion

        private void DockDocument_Load(object sender, System.EventArgs e)
        {
        }
    }
}
