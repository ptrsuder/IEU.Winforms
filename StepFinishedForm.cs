using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEnhancingUtility.Winforms
{
    public partial class StepFinishedForm : Form
    {
        string downloadFolder;

        public StepFinishedForm(string directoryInfo, string message)
        {            
            downloadFolder = directoryInfo;
            InitializeComponent();
            this.message_label.Text = message;
            this.CenterToParent();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ppenFolder_button_Click(object sender, EventArgs e)
        {
            Process.Start(downloadFolder);
            this.Close();
            this.Dispose();
        }
    }
}
