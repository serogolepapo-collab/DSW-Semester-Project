namespace DSW_Semester_Project
{
    partial class CreateAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            rndCreateAccount = new WindowsFormsApp1.RoundedPanel();
            txtConfirmPassword = new WindowsFormsApp1.CustomTextBox();
            txtPassword2 = new WindowsFormsApp1.CustomTextBox();
            txtEmail = new WindowsFormsApp1.CustomTextBox();
            txtName = new WindowsFormsApp1.CustomTextBox();
            btnRegister2 = new WindowsFormsApp1.RoundedButton();
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            lblName = new Label();
            lblCreateAccount = new Label();
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            rndCreateAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // rndCreateAccount
            // 
            rndCreateAccount.BackColor = Color.White;
            rndCreateAccount.Controls.Add(txtConfirmPassword);
            rndCreateAccount.Controls.Add(txtPassword2);
            rndCreateAccount.Controls.Add(txtEmail);
            rndCreateAccount.Controls.Add(txtName);
            rndCreateAccount.Controls.Add(btnRegister2);
            rndCreateAccount.Controls.Add(lblConfirmPassword);
            rndCreateAccount.Controls.Add(lblPassword);
            rndCreateAccount.Controls.Add(lblEmail);
            rndCreateAccount.Controls.Add(lblName);
            rndCreateAccount.Controls.Add(lblCreateAccount);
            rndCreateAccount.Location = new Point(20, 14);
            rndCreateAccount.Margin = new Padding(3, 2, 3, 2);
            rndCreateAccount.Name = "rndCreateAccount";
            rndCreateAccount.Size = new Size(522, 512);
            rndCreateAccount.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.Location = new Point(53, 388);
            txtConfirmPassword.Margin = new Padding(3, 2, 3, 2);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Padding = new Padding(16, 8, 16, 8);
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(425, 28);
            txtConfirmPassword.TabIndex = 9;
            // 
            // txtPassword2
            // 
            txtPassword2.BackColor = Color.White;
            txtPassword2.Location = new Point(55, 302);
            txtPassword2.Margin = new Padding(3, 2, 3, 2);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Padding = new Padding(16, 8, 16, 8);
            txtPassword2.PlaceholderText = "Password";
            txtPassword2.Size = new Size(424, 29);
            txtPassword2.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(57, 202);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(16, 8, 16, 8);
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(420, 29);
            txtEmail.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Location = new Point(53, 111);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Padding = new Padding(16, 8, 16, 8);
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(424, 30);
            txtName.TabIndex = 6;
            // 
            // btnRegister2
            // 
            btnRegister2.BackColor = Color.FromArgb(29, 65, 109);
            btnRegister2.FlatAppearance.BorderSize = 0;
            btnRegister2.FlatStyle = FlatStyle.Flat;
            btnRegister2.Font = new Font("Segoe UI", 10F);
            btnRegister2.ForeColor = Color.White;
            btnRegister2.Location = new Point(55, 470);
            btnRegister2.Margin = new Padding(3, 2, 3, 2);
            btnRegister2.Name = "btnRegister2";
            btnRegister2.Size = new Size(413, 26);
            btnRegister2.TabIndex = 5;
            btnRegister2.Text = "Register";
            btnRegister2.UseVisualStyleBackColor = false;
            btnRegister2.Click += btnRegister2_Click;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(67, 364);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(107, 15);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(67, 278);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(70, 175);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(67, 85);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblCreateAccount
            // 
            lblCreateAccount.AutoSize = true;
            lblCreateAccount.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreateAccount.Location = new Point(150, 24);
            lblCreateAccount.Name = "lblCreateAccount";
            lblCreateAccount.Size = new Size(190, 30);
            lblCreateAccount.TabIndex = 0;
            lblCreateAccount.Text = "Create an Account";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_09_12_at_16_04_53;
            pictureBox1.Location = new Point(578, -1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(622, 536);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 536);
            Controls.Add(pictureBox1);
            Controls.Add(rndCreateAccount);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAccount";
            rndCreateAccount.ResumeLayout(false);
            rndCreateAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private WindowsFormsApp1.RoundedPanel rndCreateAccount;
        private Label lblCreateAccount;
        private PictureBox pictureBox1;
        private WindowsFormsApp1.CustomTextBox txtName;
        private WindowsFormsApp1.RoundedButton btnRegister2;
        private Label lblConfirmPassword;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblName;
        private WindowsFormsApp1.CustomTextBox txtConfirmPassword;
        private WindowsFormsApp1.CustomTextBox txtPassword2;
        private WindowsFormsApp1.CustomTextBox txtEmail;
        private ErrorProvider errorProvider1;
    }
}