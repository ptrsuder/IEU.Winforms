using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltUI.Forms;
using ImageEnhancingUtility.Core;

namespace ImageEnhancingUtility.Winforms.DarkForms
{
    public partial class ModelTreeviewForm : DarkForm
    {
        public ModelInfo SelectedModel;
        MyTreeView treeView1;
        public ModelTreeviewForm(MyTreeView treeView)
        {
            InitializeComponent();
            treeView1 = treeView;
            mainPanel.Controls.Add(treeView);
            treeView.BeforeSelect += TreeView_BeforeSelect;
            treeView.AfterSelect += TreeView_AfterSelect;
            StartPosition = FormStartPosition.CenterParent;
            AcceptButton = ok_button;
        }

        private void TreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            var model = (e.Node.Tag as ModelInfo);
            if (model == null || model.GetType() != typeof(ModelInfo))
                e.Cancel = true;
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelectedModel = treeView1.Nodes.Find("", true).Where(x => x.IsSelected).ToList()
                .ConvertAll(x => x.Tag as ModelInfo)
                .Where(x => x?.GetType() == typeof(ModelInfo)).FirstOrDefault();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
