using AltUI.Config;
using AltUI.Controls;
using AltUI.Docking;
using AltUI.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace ImageEnhancingUtility.Winforms
{
    public partial class SettingsMiscTab : DarkDocument
    {
        #region Constructor Region

        public SettingsMiscTab()
        {
            InitializeComponent();         
        }

        public SettingsMiscTab(string text, Image icon)
            : this()
        {
            DockText = text;
            Icon = icon;
        }

        #endregion

        #region Event Handler Region


        #endregion
    }
}
