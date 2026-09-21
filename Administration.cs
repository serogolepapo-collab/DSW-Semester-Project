using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;

namespace DSW_Semester_Project
{
    public partial class Administration : Form
    {
        private Administrator currentAdmin;
        public Administration(Administrator admin)
        {
            InitializeComponent();
            currentAdmin = admin;
            LoadDashboardData();

            lblWelcome.Text = "Hello, " + currentAdmin.FullName;
        }

        private void LoadDashboardData()
        {
            LoadComplaints();
            LoadResidents();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" };
            int[] collectionsData = { 20, 35, 50, 40, 60, 80, 70 };
            int[] trendData = { 15, 30, 45, 35, 55, 75, 65 };



        }

        private void btnSignOut_Click(object sender, EventArgs e)
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

        //public override void OpenDashboard()
        //{
        //    Administration adminForm = new Administration();
        //    adminForm.Show();
        //}

        private void LoadComplaints()
        {
            dgvComplaints.Rows.Clear();

            List<Complaint> allComplaints = ComplaintData.GetAllComplaints();

            foreach (Complaint residentComplaint in allComplaints)
            {
                dgvComplaints.Rows.Add(residentComplaint.Type, residentComplaint.Status, residentComplaint.DateSubmitted.ToString("dd MMM yyyy"));
            }
        }

        private void LoadResidents()
        {
            dgvResident.Rows.Clear();

            List<Resident> allResidents = UserData.GetAllResidents();
            int idCounter = 1;

            foreach (Resident resident in allResidents)
            {
                dgvResident.Rows.Add(idCounter, resident.FullName, resident.Address, resident.Email);
                idCounter++;
            }
        }


    }
}
