using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace DSW_Semester_Project
{
    public partial class Residents : Form
    {
        private Resident currentResident;
        public Residents(Resident resident)
        {

            InitializeComponent();
            currentResident = resident;
            ShowResidentInfo();
        }

        private void ShowResidentInfo()
        {
            lblResidentFullName.Text = "Hello, " + currentResident.FullName;

            if (currentResident.HasAddress())
            {
                lblUserAddress.Text = currentResident.Address;
            }
            else
            {
                lblUserAddress.Text = "No address saved yet";
                MessageBox.Show("Please add your address so we can collect from you.",
                    "Add Your Address", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

            //FrmSmartWasteRecycling frmSmartWasteRecycling = new FrmSmartWasteRecycling();
            //frmSmartWasteRecycling.Show();

            //this.Hide();
        }

        private void btnSaveAddress_Click(object sender, EventArgs e)
        {
            List<CustomTextBox> requiredBoxes = new List<CustomTextBox>();
            List<string> requiredNames = new List<string>();

            requiredBoxes.Add(txtStreetAddress);
            requiredNames.Add("Street address");

            requiredBoxes.Add(txtCity);
            requiredNames.Add("City");

            for (int i = 0; i < requiredBoxes.Count; i++)
            {
                if (requiredBoxes[i].Text.Trim() == "")
                {
                    MessageBox.Show(requiredNames[i] + " is required.",
                        "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    requiredBoxes[i].Focus();
                    return;
                }
            }

            // ---- Build the address, skipping any optional field left blank ----
            // Building name, province and postal code are optional, so we only
            // add them to the final string if the resident actually typed something.
            List<string> addressParts = new List<string>();

            addressParts.Add(txtStreetAddress.Text.Trim());

            if (txtBuildingName.Text.Trim() != "")
            {
                addressParts.Add(txtBuildingName.Text.Trim());
            }

            addressParts.Add(txtCity.Text.Trim());

            if (txtStateOrProvince.Text.Trim() != "")
            {
                addressParts.Add(txtStateOrProvince.Text.Trim());
            }

            if (txtZipCode.Text.Trim() != "")
            {
                addressParts.Add(txtZipCode.Text.Trim());
            }

            // foreach LOOP: join every piece together with a comma,
            // but don't put a comma before the very first piece.
            string fullAddress = "";
            foreach (string part in addressParts)
            {
                if (fullAddress == "")
                {
                    fullAddress = part;
                }
                else
                {
                    fullAddress = fullAddress + ", " + part;
                }
            }

            currentResident.Address = fullAddress;

            bool saved = UserData.UpdateResidentAddress(currentResident);

            if (saved)
            {
                lblUserAddress.Text = fullAddress;
                MessageBox.Show("Address saved.", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCancelAdress_Click(object sender, EventArgs e)
        {
            // Discard any unsaved typing - reload what's actually on file
            txtStreetAddress.Text = "";
            txtBuildingName.Text = "";
            txtCity.Text = "";
            txtStateOrProvince.Text = "";
            txtZipCode.Text = "";
        }

        private void lblResidentFullName_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string type = cmbComplaintsAndReview.SelectedItem.ToString();

            if (cmbComplaintsAndReview.SelectedItem == null)
            {
                MessageBox.Show("Please select a type.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtComplaintsAndReviews.Text.Trim() == "")
            {
                MessageBox.Show("Please describe your complaint or review.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string description = txtComplaintsAndReviews.Text.Trim();

            Complaint newComplaint = new Complaint(type, description, currentResident.Username);

            bool saved = ComplaintData.SaveComplaint(newComplaint);

            if (saved == false)
            {
                return;
            }

            // Show it immediately in "Your submissions"
            ListViewItem item = new ListViewItem(type);
            item.SubItems.Add(description);
            item.SubItems.Add(newComplaint.DateSubmitted.ToString("dd MMM yyyy"));
            lstComplaintsAndReviews.Items.Add(item);

            cmbComplaintsAndReview.SelectedIndex = -1;
            txtComplaintsAndReviews.Text = "";

            MessageBox.Show("Thank you! Your submission has been recorded.",
                "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
