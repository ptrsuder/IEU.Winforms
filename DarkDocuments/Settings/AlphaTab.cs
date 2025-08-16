using AltUI.Config;
using AltUI.Controls;
using AltUI.Docking;
using AltUI.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace ImageEnhancingUtility.Winforms
{
    public partial class SettingsAlphaTab : DarkDocument
    {
        #region Constructor Region

        public SettingsAlphaTab()
        {
            InitializeComponent();         
        }

        public SettingsAlphaTab(string text, Image icon)
            : this()
        {
            DockText = text;
            Icon = icon;
        }

        #endregion

        #region Event Handler Region

        public override void Close()
        { 
            base.Close();
        }

        #endregion

        private void DockDocument_Load(object sender, System.EventArgs e)
        {
            

        }          
    }
}
