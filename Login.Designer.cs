namespace DSW_Semester_Project
{
    partial class FrmSmartWasteRecycling
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rdpLogin = new WindowsFormsApp1.RoundedPanel();
            txtPassword = new WindowsFormsApp1.CustomTextBox();
            txtUserName = new WindowsFormsApp1.CustomTextBox();
            btnRegister = new WindowsFormsApp1.RoundedButtonRegister();
            btnLogin = new WindowsFormsApp1.RoundedButton();
            lblPassword = new Label();
            lblUserName = new Label();
            lblquestion = new Label();
            lblWelcome = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            rdpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rdpLogin
            // 
            rdpLogin.BackColor = Color.White;
            rdpLogin.Controls.Add(txtPassword);
            rdpLogin.Controls.Add(txtUserName);
            rdpLogin.Controls.Add(btnRegister);
            rdpLogin.Controls.Add(btnLogin);
            rdpLogin.Controls.Add(lblPassword);
            rdpLogin.Controls.Add(lblUserName);
            rdpLogin.Controls.Add(lblquestion);
            rdpLogin.Controls.Add(lblWelcome);
            rdpLogin.Controls.Add(pictureBox2);
            rdpLogin.Location = new Point(664, 9);
            rdpLogin.Margin = new Padding(3, 2, 3, 2);
            rdpLogin.Name = "rdpLogin";
            rdpLogin.Size = new Size(512, 509);
            rdpLogin.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Location = new Point(80, 363);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(16, 8, 16, 8);
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(374, 32);
            txtPassword.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.Location = new Point(80, 268);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Padding = new Padding(16, 8, 16, 8);
            txtUserName.Size = new Size(377, 34);
            txtUserName.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.White;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F);
            btnRegister.ForeColor = Color.FromArgb(29, 65, 109);
            btnRegister.Location = new Point(284, 469);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(118, 22);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(29, 65, 109);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(60, 417);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(424, 25);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(83, 326);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(80, 244);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(61, 15);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "Usersame:";
            // 
            // lblquestion
            // 
            lblquestion.AutoSize = true;
            lblquestion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblquestion.Location = new Point(80, 472);
            lblquestion.Name = "lblquestion";
            lblquestion.Size = new Size(187, 20);
            lblquestion.TabIndex = 2;
            lblquestion.Text = "Don't have an account yet?";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(60, 175);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(361, 37);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome to Smart Recycling!";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.WhatsApp_Image_2026_09_12_at_14_11_58__1_;
            pictureBox2.Location = new Point(39, 15);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(444, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_09_12_at_16_13_26;
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(614, 528);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FrmSmartWasteRecycling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1199, 536);
            Controls.Add(pictureBox1);
            Controls.Add(rdpLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmSmartWasteRecycling";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SMART WASTE RECYCLING";
            rdpLogin.ResumeLayout(false);
            rdpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private WindowsFormsApp1.RoundedPanel rdpLogin;
        private PictureBox pictureBox2;
        private Label lblquestion;
        private Label lblWelcome;
        private Label lblUserName;
        private Label lblPassword;
        private WindowsFormsApp1.RoundedButton btnLogin;
        private WindowsFormsApp1.RoundedButtonRegister btnRegister;
        private WindowsFormsApp1.CustomTextBox txtPassword;
        private WindowsFormsApp1.CustomTextBox txtUserName;
        private PictureBox pictureBox1;
    }
}
