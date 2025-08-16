using AltUI.Config;
using AltUI.Controls;
using AltUI.Docking;
using AltUI.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace ImageEnhancingUtility.Winforms
{
    public partial class SettingsCoreTab : DarkDocument
    {
        #region Constructor Region

        public SettingsCoreTab()
        {
            InitializeComponent();         
        }

        public SettingsCoreTab(string text, Image icon)
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
