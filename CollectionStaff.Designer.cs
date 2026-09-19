namespace DSW_Semester_Project
{
    partial class CollectionStaff
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
            panelSideBar = new Panel();
            panelUserDisplay = new Panel();
            btnSignOut2 = new Button();
            lblCollectionStaff = new Label();
            pictureBoxIcon = new PictureBox();
            lblCollectionType = new Label();
            lblTitle = new Label();
            roundedPanel1 = new WindowsFormsApp1.RoundedPanel();
            chkCollected = new CheckBox();
            chkNotCollected = new CheckBox();
            dgvCollectionStaff = new DataGridView();
            ColumnStreetAddress = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            roundedButton1 = new WindowsFormsApp1.RoundedButton();
            lblCity = new Label();
            lblSuburbOrTown = new Label();
            lblStreetAddress = new Label();
            lblResidentialStreetAddress = new Label();
            pictureBox1 = new PictureBox();
            lblHelloDriver = new Label();
            pictureBox2 = new PictureBox();
            panelSideBar.SuspendLayout();
            panelUserDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCollectionStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelSideBar
            // 
            panelSideBar.BackColor = Color.FromArgb(0, 64, 0);
            panelSideBar.Controls.Add(panelUserDisplay);
            panelSideBar.Controls.Add(pictureBoxIcon);
            panelSideBar.Controls.Add(lblCollectionType);
            panelSideBar.Controls.Add(lblTitle);
            panelSideBar.Location = new Point(0, 2);
            panelSideBar.Margin = new Padding(3, 2, 3, 2);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(236, 537);
            panelSideBar.TabIndex = 2;
            // 
            // panelUserDisplay
            // 
            panelUserDisplay.BackColor = Color.Transparent;
            panelUserDisplay.BackgroundImageLayout = ImageLayout.None;
            panelUserDisplay.Controls.Add(btnSignOut2);
            panelUserDisplay.Controls.Add(lblCollectionStaff);
            panelUserDisplay.Location = new Point(26, 443);
            panelUserDisplay.Margin = new Padding(3, 2, 3, 2);
            panelUserDisplay.Name = "panelUserDisplay";
            panelUserDisplay.Size = new Size(170, 73);
            panelUserDisplay.TabIndex = 1;
            // 
            // btnSignOut2
            // 
            btnSignOut2.BackColor = Color.FromArgb(0, 64, 0);
            btnSignOut2.ForeColor = Color.White;
            btnSignOut2.Location = new Point(20, 45);
            btnSignOut2.Margin = new Padding(3, 2, 3, 2);
            btnSignOut2.Name = "btnSignOut2";
            btnSignOut2.Size = new Size(82, 22);
            btnSignOut2.TabIndex = 1;
            btnSignOut2.Text = "→ Sign Out";
            btnSignOut2.UseVisualStyleBackColor = false;
            btnSignOut2.Click += btnSignOut2_Click;
            // 
            // lblCollectionStaff
            // 
            lblCollectionStaff.AutoSize = true;
            lblCollectionStaff.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCollectionStaff.ForeColor = Color.White;
            lblCollectionStaff.Location = new Point(20, 13);
            lblCollectionStaff.Name = "lblCollectionStaff";
            lblCollectionStaff.Size = new Size(93, 15);
            lblCollectionStaff.TabIndex = 1;
            lblCollectionStaff.Text = "Collection Staff";
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Image = Properties.Resources.WhatsApp_Image_2026_09_12_at_17_39_25;
            pictureBoxIcon.Location = new Point(10, 27);
            pictureBoxIcon.Margin = new Padding(3, 2, 3, 2);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(57, 41);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIcon.TabIndex = 1;
            pictureBoxIcon.TabStop = false;
            // 
            // lblCollectionType
            // 
            lblCollectionType.AutoSize = true;
            lblCollectionType.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCollectionType.ForeColor = Color.White;
            lblCollectionType.Location = new Point(94, 50);
            lblCollectionType.Name = "lblCollectionType";
            lblCollectionType.Size = new Size(86, 13);
            lblCollectionType.TabIndex = 1;
            lblCollectionType.Text = "Collection Staff";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(86, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(117, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Smart Waste";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.Controls.Add(chkCollected);
            roundedPanel1.Controls.Add(chkNotCollected);
            roundedPanel1.Controls.Add(dgvCollectionStaff);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(roundedButton1);
            roundedPanel1.Controls.Add(lblCity);
            roundedPanel1.Controls.Add(lblSuburbOrTown);
            roundedPanel1.Controls.Add(lblStreetAddress);
            roundedPanel1.Controls.Add(lblResidentialStreetAddress);
            roundedPanel1.Location = new Point(266, 42);
            roundedPanel1.Margin = new Padding(3, 2, 3, 2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(492, 476);
            roundedPanel1.TabIndex = 3;
            // 
            // chkCollected
            // 
            chkCollected.AutoSize = true;
            chkCollected.Location = new Point(12, 256);
            chkCollected.Margin = new Padding(3, 2, 3, 2);
            chkCollected.Name = "chkCollected";
            chkCollected.Size = new Size(76, 19);
            chkCollected.TabIndex = 11;
            chkCollected.Text = "Collected";
            chkCollected.UseVisualStyleBackColor = true;
            // 
            // chkNotCollected
            // 
            chkNotCollected.AutoSize = true;
            chkNotCollected.Location = new Point(200, 256);
            chkNotCollected.Margin = new Padding(3, 2, 3, 2);
            chkNotCollected.Name = "chkNotCollected";
            chkNotCollected.Size = new Size(99, 19);
            chkNotCollected.TabIndex = 10;
            chkNotCollected.Text = "Not Collected";
            chkNotCollected.UseVisualStyleBackColor = true;
            // 
            // dgvCollectionStaff
            // 
            dgvCollectionStaff.AllowUserToAddRows = false;
            dgvCollectionStaff.AllowUserToDeleteRows = false;
            dgvCollectionStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCollectionStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCollectionStaff.Columns.AddRange(new DataGridViewColumn[] { ColumnStreetAddress, Column1, Time, City, Column2 });
            dgvCollectionStaff.Location = new Point(0, 356);
            dgvCollectionStaff.Margin = new Padding(3, 2, 3, 2);
            dgvCollectionStaff.MultiSelect = false;
            dgvCollectionStaff.Name = "dgvCollectionStaff";
            dgvCollectionStaff.RowHeadersWidth = 51;
            dgvCollectionStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCollectionStaff.Size = new Size(492, 96);
            dgvCollectionStaff.TabIndex = 9;
            // 
            // ColumnStreetAddress
            // 
            ColumnStreetAddress.HeaderText = "Street Address";
            ColumnStreetAddress.MinimumWidth = 6;
            ColumnStreetAddress.Name = "ColumnStreetAddress";
            // 
            // Column1
            // 
            Column1.HeaderText = "Suburb";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            // 
            // City
            // 
            City.HeaderText = "City";
            City.MinimumWidth = 6;
            City.Name = "City";
            // 
            // Column2
            // 
            Column2.HeaderText = "Collected";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 154);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 8;
            label1.Text = "Time:";
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(29, 65, 109);
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI", 10F);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(200, 314);
            roundedButton1.Margin = new Padding(3, 2, 3, 2);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(83, 26);
            roundedButton1.TabIndex = 7;
            roundedButton1.Text = "Check";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(12, 196);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(31, 15);
            lblCity.TabIndex = 3;
            lblCity.Text = "City:";
            // 
            // lblSuburbOrTown
            // 
            lblSuburbOrTown.AutoSize = true;
            lblSuburbOrTown.Location = new Point(12, 119);
            lblSuburbOrTown.Name = "lblSuburbOrTown";
            lblSuburbOrTown.Size = new Size(82, 15);
            lblSuburbOrTown.TabIndex = 2;
            lblSuburbOrTown.Text = "Suburb/Town:";
            // 
            // lblStreetAddress
            // 
            lblStreetAddress.AutoSize = true;
            lblStreetAddress.Location = new Point(12, 76);
            lblStreetAddress.Name = "lblStreetAddress";
            lblStreetAddress.Size = new Size(85, 15);
            lblStreetAddress.TabIndex = 1;
            lblStreetAddress.Text = "Street Address:";
            // 
            // lblResidentialStreetAddress
            // 
            lblResidentialStreetAddress.AutoSize = true;
            lblResidentialStreetAddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResidentialStreetAddress.Location = new Point(136, 9);
            lblResidentialStreetAddress.Name = "lblResidentialStreetAddress";
            lblResidentialStreetAddress.Size = new Size(182, 20);
            lblResidentialStreetAddress.TabIndex = 0;
            lblResidentialStreetAddress.Text = "Residential Street Address";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_09_14_at_14_21_39;
            pictureBox1.Location = new Point(776, 42);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblHelloDriver
            // 
            lblHelloDriver.AutoSize = true;
            lblHelloDriver.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHelloDriver.Location = new Point(327, 15);
            lblHelloDriver.Name = "lblHelloDriver";
            lblHelloDriver.Size = new Size(85, 19);
            lblHelloDriver.TabIndex = 5;
            lblHelloDriver.Text = "Hello Driver!";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.vehicle;
            pictureBox2.Location = new Point(273, 9);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // CollectionStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 536);
            Controls.Add(pictureBox2);
            Controls.Add(lblHelloDriver);
            Controls.Add(pictureBox1);
            Controls.Add(roundedPanel1);
            Controls.Add(panelSideBar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CollectionStaff";
            Text = "CollectionStaff";
            panelSideBar.ResumeLayout(false);
            panelSideBar.PerformLayout();
            panelUserDisplay.ResumeLayout(false);
            panelUserDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCollectionStaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSideBar;
        private Panel panelUserDisplay;
        private Button btnSignOut2;
        private Label lblCollectionStaff;
        private PictureBox pictureBoxIcon;
        private Label lblCollectionType;
        private Label lblTitle;
        private WindowsFormsApp1.RoundedPanel roundedPanel1;
        private PictureBox pictureBox1;
        private Label lblHelloDriver;
        private PictureBox pictureBox2;
        private Label lblCity;
        private Label lblSuburbOrTown;
        private Label lblStreetAddress;
        private Label lblResidentialStreetAddress;
        private WindowsFormsApp1.RoundedButton roundedButton1;
        private Label label1;
        private DataGridView dgvCollectionStaff;
        private DataGridViewTextBoxColumn ColumnStreetAddress;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Column2;
        private CheckBox chkNotCollected;
        private CheckBox chkCollected;
    }
}