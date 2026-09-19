using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class RoundedPanel : Panel
    {
        [DefaultValue(25)]
        public int BorderRadius { get; set; } = 25;

        [DefaultValue(0)]
        public int BorderSize { get; set; } = 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor { get; set; } = Color.Transparent;

        public RoundedPanel()
        {
            this.BackColor = Color.White;
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);

            using (GraphicsPath pathSurface = GetRoundedPath(rectSurface, BorderRadius))
            {
                this.Region = new Region(pathSurface);

                if (BorderSize >= 1)
                {
                    using (Pen penBorder = new Pen(BorderColor, BorderSize))
                    {
                        g.DrawPath(penBorder, pathSurface);
                    }
                }
            }
        }

        private GraphicsPath GetRoundedPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            this.Invalidate();
        }
    }
}