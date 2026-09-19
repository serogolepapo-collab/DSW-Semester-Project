using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class RoundedButtonRegister : Button
    {
        
        [DefaultValue(30)]
        public int BorderRadius { get; set; } = 30;

        [DefaultValue(2)]
        public int BorderSize { get; set; } = 2;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor { get; set; } = Color.FromArgb(100, 110, 120); 

        public RoundedButtonRegister()
        {
            this.Size = new Size(120, 40);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.White; 
            this.ForeColor = Color.FromArgb(29, 65, 109); 
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 2, this.Height - 2);

            using (GraphicsPath pathSurface = GetRoundedPath(rectSurface, BorderRadius))
            using (GraphicsPath pathBorder = GetRoundedPath(rectBorder, BorderRadius - 1))
            using (Pen penBorder = new Pen(BorderColor, BorderSize))
            {
                
                this.Region = new Region(pathSurface);

                
                base.OnPaint(pevent);

                
                if (BorderSize >= 1)
                {
                    g.DrawPath(penBorder, pathBorder);
                }
            }
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
