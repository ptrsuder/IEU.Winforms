using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEnhancingUtility.Winforms
{
    public partial class ErrorLogForm : Form
    {
        public ErrorLogForm(string log)
        {
            InitializeComponent();
            this.CenterToParent();

            richTextBox1.Text = log;
        }
    }
}
