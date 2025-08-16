using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageEnhancingUtility.Winforms
{
    public class MyTreeView : TreeView
    {
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            // Suppress WM_LBUTTONDBLCLK
            if (m.Msg == 0x203) { m.Result = IntPtr.Zero; }
            else base.WndProc(ref m);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MyTreeView
            // 
            this.LineColor = System.Drawing.Color.Black;
            this.ResumeLayout(false);

        }

        public MyTreeView() {}       
    }
}
