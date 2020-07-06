using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageEnhancingUtility.Core;
using ReactiveUI;

namespace ImageEnhancingUtility.Winforms
{
    public partial class SortListForm : Form, IViewFor<IEU>
    {
        public IEU ViewModel { get; set; }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (IEU)value;
        }

        public SortListForm(IEU ieu)
        {
            InitializeComponent();
            ViewModel = ieu;
            chainModels_listBox.DisplayMember = "Name";
            chainModels_listBox.DataSource = new BindingSource(ViewModel.checkedModels, null);
            //chainModels_listBox.SelectedIndex = 0;
        }

        private void chainModels_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
            chainPriority_numericUpDown.Value = (chainModels_listBox.SelectedValue as ModelInfo).Priority;
        }

        private void priority_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int newValue = (int)chainPriority_numericUpDown.Value;
            ModelInfo selectedModel = chainModels_listBox.SelectedValue as ModelInfo;
            if (selectedModel != null
                && newValue >= 0
                && newValue != selectedModel.Priority              
                && newValue < chainModels_listBox.Items.Count)
            {
                ViewModel.ChangeModelPriority(selectedModel, newValue);
                chainModels_listBox.DataSource = new BindingSource(ViewModel.checkedModels, null);
                chainModels_listBox.SelectedIndex = newValue;
            }
            else
                chainPriority_numericUpDown.Value = (chainModels_listBox.SelectedValue as ModelInfo).Priority;
        }
    }
}
