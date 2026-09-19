using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class RoundedButton : Button
    {
       
        [DefaultValue(30)]
        public int BorderRadius { get; set; } = 30;

        public RoundedButton()
        {
            this.Size = new Size(120, 40); 
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.FromArgb(29, 65, 109); 
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rect = new RectangleF(0, 0, this.Width, this.Height);

            
            using (GraphicsPath path = GetRoundedPath(rect, BorderRadius))
            {
                this.Region = new Region(path);
            }

            base.OnPaint(pevent);
        }

        private GraphicsPath GetRoundedPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius;

            path.StartFigure();
            
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}