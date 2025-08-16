using AltUI.Config;
using AltUI.Controls;
using AltUI.Docking;
using AltUI.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace ImageEnhancingUtility.Winforms
{
    public partial class DarkDockMainTab : DarkDocument
    {
        #region Constructor Region

        public DarkDockMainTab(): base()
        {
            InitializeComponent();  
        }

        public DarkDockMainTab(string text, Image icon)
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
        }

        #endregion

        private void DockDocument_Load(object sender, System.EventArgs e)
        {

        }

        private void showStepsButtons_checkBox_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void LoadProfileMainTab_button_Click(object sender, System.EventArgs e)
        {

        }

        private void UseModelChain_checkBox_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void chainOrder_button_Click(object sender, System.EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void toogleLogView_button_Click(object sender, System.EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
