using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DSW_Semester_Project
{
    public partial class CollectionStaff : Form
    {
        private StaffMember currentStaff;
        public CollectionStaff(StaffMember staff)
        {
            InitializeComponent();
            currentStaff = staff;
            lblHelloDriver.Text = "Hello, " + currentStaff.FullName + " (" + currentStaff.Position + ")";
            lblCollectionStaff.Text = $"{currentStaff.FullName}";
        }

        private void btnSignOut2_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to sign out?", "Confirm",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                FrmSmartWasteRecycling loginForm = new FrmSmartWasteRecycling();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
