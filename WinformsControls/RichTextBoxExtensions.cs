using System.Windows.Forms;

namespace ImageEnhancingUtility.Winforms
{
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, System.Drawing.Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
