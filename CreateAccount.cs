using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DSW_Semester_Project
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
            txtPassword2.IsPassword = true;
            txtConfirmPassword.IsPassword = true;

        }

        private bool CheckName()
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider1.SetError(txtName, "Please enter your full name.");
                return false;
            }

            if (name.Length < 3)
            {
                errorProvider1.SetError(txtName, "Name must be at least 3 characters.");
                return false;
            }

            
            foreach (char _name in name)
            {
                if (char.IsLetter(_name) == false && _name != ' ')
                {
                    errorProvider1.SetError(txtName, "Name can only contain letters.");
                    return false;
                }
            }

            errorProvider1.SetError(txtName, "");
            return true;
        }

        private bool CheckEmail()
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider1.SetError(txtEmail, "Please enter your email address.");
                return false;
            }

            if (email.Contains("@") == false)
            {
                errorProvider1.SetError(txtEmail, "Email must contain an @ symbol.");
                return false;
            }

            if (email.Contains(".") == false)
            {
                errorProvider1.SetError(txtEmail, "Email must contain a full stop, e.g. .com");
                return false;
            }

            if (email.StartsWith("@") || email.EndsWith("@"))
            {
                errorProvider1.SetError(txtEmail, "That email is not in a valid format.");
                return false;
            }

            errorProvider1.SetError(txtEmail, "");
            return true;
        }

        private bool CheckPassword()
        {
            string password = txtPassword2.Text;

            if (string.IsNullOrWhiteSpace(password))
            {
                errorProvider1.SetError(txtPassword2, "Please enter a password.");
                return false;
            }

            if (password.Length < 8)
            {
                errorProvider1.SetError(txtPassword2,
                    "Password must be at least 8 characters long.");
                return false;
            }

            bool hasCapital = false;
            bool hasNumber = false;

            // foreach LOOP: walk through every character once
            foreach (char _password in password)
            {
                if (char.IsUpper(_password))
                {
                    hasCapital = true;
                }

                if (char.IsDigit(_password))
                {
                    hasNumber = true;
                }
            }

            if (hasCapital == false)
            {
                errorProvider1.SetError(txtPassword2,
                    "Password must have at least one capital letter.");
                return false;
            }

            if (hasNumber == false)
            {
                errorProvider1.SetError(txtPassword2,
                    "Password must have at least one number.");
                return false;
            }

            errorProvider1.SetError(txtPassword2, "");
            return true;
        }

        private bool CheckConfirmPassword()
        {
            string confirmPassword = txtConfirmPassword.Text;
            if (string.IsNullOrWhiteSpace(confirmPassword)) 
            {
                errorProvider1.SetError(txtConfirmPassword, "Please confirm your password.");
                return false;
            }

            if (txtConfirmPassword.Text != txtPassword2.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "The passwords do not match.");
                return false;
            }

            errorProvider1.SetError(txtConfirmPassword, "");
            return true;
        }




        private void btnRegister2_Click(object sender, EventArgs e)
        {
            bool nameOk = CheckName();
            bool emailOk = CheckEmail();
            bool passwordOk = CheckPassword();
            bool confirmOk = CheckConfirmPassword();

            if (nameOk == false || emailOk == false ||
                passwordOk == false || confirmOk == false)
            {
                MessageBox.Show("Please fix the highlighted fields.",
                    "Cannot Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserData.EmailAlreadyUsed(txtEmail.Text.Trim()))
            {
                errorProvider1.SetError(txtEmail, "This email is already registered.");
                MessageBox.Show("An account with that email already exists.",
                    "Cannot Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = txtEmail.Text.Trim();
            string username = email.Split('@')[0];

            Resident newResident = new Resident(
                username, email, txtPassword2.Text, txtName.Text.Trim(), "");

            bool saved = UserData.SaveNewResident(newResident);

            if (saved == false)
            {
                return;
            }

            MessageBox.Show(
                "Account created!\n\nYour username is: " + username +
                "\n\nYou can log in with your username or your email.",
                "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmSmartWasteRecycling loginForm = new FrmSmartWasteRecycling();
            loginForm.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
