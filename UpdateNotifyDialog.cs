using System;
using System.Windows.Forms;
using GitHubUpdate;


namespace ImageEnhancingUtility.Winforms
{
    public partial class UpdateNotifyDialog : Form
    {
        private readonly UpdateChecker _checker;
        private bool _loadednotes;
        string releaseNotes;

        public UpdateNotifyDialog(UpdateChecker checker, string message)
        {
            _checker = checker;

            InitializeComponent();

            label1.Text = message;//string.Format(label1.Text, _checker.RepositoryName);
        }

        void panel1_Resize(object sender, EventArgs e)
        {
            label1.Left = (panel1.ClientSize.Width - label1.Width) / 2;
            label2.Left = (panel1.ClientSize.Width - label2.Width) / 2;
        }

        async void boxReleaseNotes_CheckedChanged(object sender, EventArgs e)
        {
            ReleaseNotesPanel.Visible = boxReleaseNotes.Checked;

            if (_loadednotes) return;

            ReleaseNotes.DocumentText = await _checker.RenderReleaseNotes();
            _loadednotes = true;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"https://github.com/ptrsuder/{_checker.RepositoryName}/releases");
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
