using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class TransparentLabel : Label
    {
        public TransparentLabel()
        {
            this.BackColor = Color.Transparent;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20; // WS_EX_TRANSPARENT
                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Do not draw background to keep visual background clear
        }
    }
}
