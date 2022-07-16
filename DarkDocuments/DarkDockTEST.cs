using AltUI.Config;
using AltUI.Controls;
using AltUI.Docking;
using AltUI.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace ImageEnhancingUtility.Winforms
{
    public partial class DarkDockTest : DarkDocument
    {
        #region Constructor Region

        public DarkDockTest()
        {
            InitializeComponent();         
        }

        public DarkDockTest(string text, Image icon)
            : this()
        {
            DockText = text;
            Icon = icon;


            darkTreeView1.Nodes.Add(new DarkTreeNode("1"));
            darkTreeView1.Nodes.Add(new DarkTreeNode("2"));
            darkTreeView1.Nodes.Add(new DarkTreeNode("3"));
            var n = new DarkTreeNode("4");
            n.Nodes.Add(new DarkTreeNode("4.1"));
            n.Nodes.Add(new DarkTreeNode("4.2"));
            darkTreeView1.Nodes.Add(n);
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
        private void darkTreeView1_SelectedNodesChanged(object sender, System.EventArgs e)
        {
            
        }
    }
}
