#region сборка AltUI, Version=2.0.1.0, Culture=neutral, PublicKeyToken=null
// C:\Users\MKso\.nuget\packages\AltUI\2.0.2\lib\AltUI.dll
// Decompiled with ICSharpCode.Decompiler 7.1.0.6543
#endregion

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using AltUI.Config;
using AltUI.Controls;

namespace ImageEnhancingUtility.Winforms
{
    public class DarkComboBoxMod : DarkComboBox
    {
        private Bitmap _buffer;
      
        public DarkComboBoxMod():base()
        {            
        }

        private void PaintCombobox()
        {
            if (_buffer == null)
            {
                _buffer = new Bitmap(base.ClientRectangle.Width, base.ClientRectangle.Height);
            }

            using Graphics graphics = Graphics.FromImage(_buffer);
            Rectangle rect = new Rectangle(0, 0, base.ClientSize.Width, base.ClientSize.Height);
            Color lightText = Colors.LightText;
            Color color = Colors.GreySelection;
            Color lightBackground = Colors.LightBackground;
            if (Focused && base.TabStop)
            {
                color = Colors.BlueHighlight;
            }

            using (SolidBrush brush = new SolidBrush(lightBackground))
            {
                graphics.FillRectangle(brush, rect);
            }

            using (Pen pen = new Pen(color, 1f))
            {
                Rectangle rect2 = new Rectangle(rect.Left, rect.Top, rect.Width - 1, rect.Height - 1);
                graphics.DrawRectangle(pen, rect2);
            }

            Bitmap scrollbar_arrow_hot = ScrollIconsMod.scrollbar_arrow_hot;
            graphics.DrawImageUnscaled(scrollbar_arrow_hot, rect.Right - scrollbar_arrow_hot.Width - Consts.Padding / 2, rect.Height / 2 - scrollbar_arrow_hot.Height / 2);
            string s = ((base.SelectedItem != null) ? GetItemText(SelectedItem) : Text);
            using SolidBrush brush2 = new SolidBrush(lightText);
            int num = 2;
            Rectangle rectangle = new Rectangle(rect.Left + num, rect.Top + num, rect.Width - scrollbar_arrow_hot.Width - Consts.Padding / 2 - num * 2, rect.Height - num * 2);
            StringFormat format = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Near,
                FormatFlags = StringFormatFlags.NoWrap,
                Trimming = StringTrimming.EllipsisCharacter
            };
            graphics.DrawString(s, Font, brush2, rectangle, format);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle bounds = e.Bounds;
            Color lightText = Colors.LightText;
            Color color = Colors.LightBackground;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected || (e.State & DrawItemState.Focus) == DrawItemState.Focus || (e.State & DrawItemState.NoFocusRect) != DrawItemState.NoFocusRect)
            {
                color = Colors.BlueSelection;
            }

            using (SolidBrush brush = new SolidBrush(color))
            {
                graphics.FillRectangle(brush, bounds);
            }

            if (e.Index >= 0 && e.Index < base.Items.Count)
            {
                string s = GetItemText(Items[e.Index]);
                using SolidBrush brush2 = new SolidBrush(lightText);
                int num = 2;
                Rectangle rectangle = new Rectangle(bounds.Left + num, bounds.Top + num, bounds.Width - num * 2, bounds.Height - num * 2);
                StringFormat format = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Near,
                    FormatFlags = StringFormatFlags.NoWrap,
                    Trimming = StringTrimming.EllipsisCharacter
                };
                graphics.DrawString(s, Font, brush2, rectangle, format);
            }
        }
    }
}
#if false // Журнал декомпиляции
Элементов в кэше: "159"
------------------
Разрешить: "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
Найдена одна сборка: "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
Загрузить из: "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\mscorlib.dll"
------------------
Разрешить: "System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
Найдена одна сборка: "System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
Загрузить из: "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Core.dll"
------------------
Разрешить: "System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
Найдена одна сборка: "System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
Загрузить из: "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.dll"
------------------
Разрешить: "System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
Найдена одна сборка: "System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
Загрузить из: "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Drawing.dll"
------------------
Разрешить: "System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
Найдена одна сборка: "System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
Загрузить из: "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Windows.Forms.dll"
#endif
