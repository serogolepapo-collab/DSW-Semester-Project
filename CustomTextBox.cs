using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class CustomTextBox : UserControl
    {
        private TextBox innerTextBox;
        private PictureBox rightIconBox;
        private bool isPlaceholderActive = true;
        private string placeholderText = "Username";
        private bool isPassword = false;

        [DefaultValue(35)]
        public int BorderRadius { get; set; } = 35;

        [DefaultValue(1)]
        public int BorderSize { get; set; } = 1;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor { get; set; } = Color.FromArgb(180, 180, 180);

        [DefaultValue("Username")]
        public string PlaceholderText
        {
            get => placeholderText;
            set
            {
                placeholderText = value;
                if (isPlaceholderActive)
                {
                    innerTextBox.Text = value;
                    innerTextBox.ForeColor = Color.Gray;
                }
            }
        }

        [DefaultValue(false)]
        public bool IsPassword
        {
            get => isPassword;
            set
            {
                isPassword = value;
                if (!isPlaceholderActive)
                {
                    innerTextBox.UseSystemPasswordChar = value;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image RightIcon
        {
            get => rightIconBox.Image;
            set
            {
                rightIconBox.Image = value;
                rightIconBox.Visible = (value != null);
            }
        }

        public override string Text
        {
            get => isPlaceholderActive ? "" : innerTextBox.Text;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    SetPlaceholder();
                }
                else
                {
                    RemovePlaceholder();
                    innerTextBox.Text = value;
                }
            }
        }

        public CustomTextBox()
        {
            this.Size = new Size(280, 42);
            this.BackColor = Color.White;
            this.Padding = new Padding(18, 11, 18, 11);

            // Set up inner borderless TextBox
            innerTextBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                ForeColor = Color.Gray,
                Text = placeholderText
            };

            innerTextBox.GotFocus += InnerTextBox_GotFocus;
            innerTextBox.LostFocus += InnerTextBox_LostFocus;


            // Set up optional Right Icon (e.g. eye icon for password)
            rightIconBox = new PictureBox
            {
                Size = new Size(20, 20),
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Right,
                Visible = false,
                Cursor = Cursors.Hand
            };

            this.Controls.Add(innerTextBox);
            this.Controls.Add(rightIconBox);
            innerTextBox.UseSystemPasswordChar = isPassword;
        }

        private void SetPlaceholder()
        {
            isPlaceholderActive = true;
            innerTextBox.Text = placeholderText;
            innerTextBox.ForeColor = Color.Gray;
            //innerTextBox.UseSystemPasswordChar = false;
        }

        private void RemovePlaceholder()
        {
            isPlaceholderActive = false;
            innerTextBox.Text = "";
            innerTextBox.ForeColor = Color.FromArgb(50, 50, 50);
            //if (isPassword)
            //{
            //    innerTextBox.UseSystemPasswordChar = true;
            //}
        }

        private void InnerTextBox_GotFocus(object sender, EventArgs e)
        {
            if (isPlaceholderActive)
            {
                RemovePlaceholder();
            }
        }

        private void InnerTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(innerTextBox.Text))
            {
                SetPlaceholder();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(0.5f, 0.5f, this.Width - 1, this.Height - 1);

            using (GraphicsPath pathSurface = GetRoundedPath(rectSurface, BorderRadius))
            using (GraphicsPath pathBorder = GetRoundedPath(rectBorder, BorderRadius))
            using (Pen penBorder = new Pen(BorderColor, BorderSize))
            {
                this.Region = new Region(pathSurface);

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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }
    }
}