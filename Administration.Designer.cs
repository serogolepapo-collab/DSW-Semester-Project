namespace DSW_Semester_Project
{
    partial class Administration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            panel1 = new Panel();
            btnSignOut = new Button();
            lblWelcome = new Label();
            btnResidents = new Button();
            btnCollection = new Button();
            btnRecycling = new Button();
            btnComplaints = new Button();
            btnReports = new Button();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            label2 = new Label();
            dgvResident = new DataGridView();
            groupBox2 = new GroupBox();
            dgvComplaints = new DataGridView();
            Issue = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ResidentName = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResident).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComplaints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(btnSignOut);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(btnResidents);
            panel1.Controls.Add(btnCollection);
            panel1.Controls.Add(btnRecycling);
            panel1.Controls.Add(btnComplaints);
            panel1.Controls.Add(btnReports);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 539);
            panel1.TabIndex = 0;
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = Color.FromArgb(0, 64, 0);
            btnSignOut.ForeColor = Color.White;
            btnSignOut.Location = new Point(53, 493);
            btnSignOut.Margin = new Padding(3, 2, 3, 2);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(82, 22);
            btnSignOut.TabIndex = 7;
            btnSignOut.Text = "→ Sign Out";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.ForeColor = SystemColors.ButtonHighlight;
            lblWelcome.Location = new Point(66, 471);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(57, 15);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "Welcome";
            // 
            // btnResidents
            // 
            btnResidents.FlatAppearance.BorderSize = 0;
            btnResidents.FlatStyle = FlatStyle.Flat;
            btnResidents.ForeColor = Color.White;
            btnResidents.Location = new Point(75, 43);
            btnResidents.Margin = new Padding(3, 2, 3, 2);
            btnResidents.Name = "btnResidents";
            btnResidents.Size = new Size(82, 22);
            btnResidents.TabIndex = 1;
            btnResidents.Text = "Residents";
            btnResidents.UseVisualStyleBackColor = true;
            // 
            // btnCollection
            // 
            btnCollection.FlatAppearance.BorderSize = 0;
            btnCollection.FlatStyle = FlatStyle.Flat;
            btnCollection.ForeColor = Color.White;
            btnCollection.Location = new Point(75, 97);
            btnCollection.Margin = new Padding(3, 2, 3, 2);
            btnCollection.Name = "btnCollection";
            btnCollection.Size = new Size(82, 22);
            btnCollection.TabIndex = 2;
            btnCollection.Text = "Collection";
            btnCollection.UseVisualStyleBackColor = true;
            // 
            // btnRecycling
            // 
            btnRecycling.FlatAppearance.BorderSize = 0;
            btnRecycling.FlatStyle = FlatStyle.Flat;
            btnRecycling.ForeColor = Color.White;
            btnRecycling.Location = new Point(75, 145);
            btnRecycling.Margin = new Padding(3, 2, 3, 2);
            btnRecycling.Name = "btnRecycling";
            btnRecycling.Size = new Size(82, 22);
            btnRecycling.TabIndex = 3;
            btnRecycling.Text = "Recycling";
            btnRecycling.UseVisualStyleBackColor = true;
            // 
            // btnComplaints
            // 
            btnComplaints.FlatAppearance.BorderSize = 0;
            btnComplaints.FlatStyle = FlatStyle.Flat;
            btnComplaints.ForeColor = Color.White;
            btnComplaints.Location = new Point(75, 194);
            btnComplaints.Margin = new Padding(3, 2, 3, 2);
            btnComplaints.Name = "btnComplaints";
            btnComplaints.Size = new Size(82, 22);
            btnComplaints.TabIndex = 4;
            btnComplaints.Text = "Complaints";
            btnComplaints.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(75, 242);
            btnReports.Margin = new Padding(3, 2, 3, 2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(82, 22);
            btnReports.TabIndex = 5;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(257, 7);
            label1.Name = "label1";
            label1.Size = new Size(293, 30);
            label1.TabIndex = 1;
            label1.Text = "Administration Dash Board";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dgvResident);
            groupBox1.Location = new Point(257, 326);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(454, 201);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resident";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(17, 17);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 1;
            label2.Text = "ResidentList";
            // 
            // dgvResident
            // 
            dgvResident.BackgroundColor = Color.FromArgb(0, 64, 0);
            dgvResident.BorderStyle = BorderStyle.Fixed3D;
            dgvResident.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResident.Columns.AddRange(new DataGridViewColumn[] { ResidentName, email, Address });
            dgvResident.Location = new Point(17, 48);
            dgvResident.Margin = new Padding(3, 2, 3, 2);
            dgvResident.Name = "dgvResident";
            dgvResident.RowHeadersWidth = 51;
            dgvResident.Size = new Size(375, 141);
            dgvResident.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvComplaints);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(756, 326);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(415, 201);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Compliants";
            // 
            // dgvComplaints
            // 
            dgvComplaints.BackgroundColor = Color.FromArgb(0, 64, 0);
            dgvComplaints.BorderStyle = BorderStyle.Fixed3D;
            dgvComplaints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComplaints.Columns.AddRange(new DataGridViewColumn[] { Issue, Status, Date });
            dgvComplaints.GridColor = Color.FromArgb(0, 64, 0);
            dgvComplaints.Location = new Point(22, 48);
            dgvComplaints.Margin = new Padding(3, 2, 3, 2);
            dgvComplaints.Name = "dgvComplaints";
            dgvComplaints.RowHeadersWidth = 51;
            dgvComplaints.Size = new Size(375, 141);
            dgvComplaints.TabIndex = 1;
            // 
            // Issue
            // 
            Issue.HeaderText = "Issue";
            Issue.MinimumWidth = 6;
            Issue.Name = "Issue";
            Issue.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 64, 0);
            label3.Location = new Point(3, 17);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 0;
            label3.Text = "Complaints";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(252, 123);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(914, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(252, 69);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(366, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // ResidentName
            // 
            ResidentName.HeaderText = "Resident Name";
            ResidentName.MinimumWidth = 6;
            ResidentName.Name = "ResidentName";
            ResidentName.Width = 125;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.Name = "email";
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 125;
            // 
            // Administration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 536);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Administration";
            Text = "Administration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResident).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComplaints).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCollection;
        private Button btnRecycling;
        private Button btnComplaints;
        private Button btnReports;
        private Button btnResidents;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private GroupBox groupBox1;
        private DataGridView dgvResident;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dgvComplaints;
        private Label label3;
        private DataGridViewTextBoxColumn Issue;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Date;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblWelcome;
        private Button btnSignOut;
        private DataGridViewTextBoxColumn ResidentName;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn Address;
    }
}