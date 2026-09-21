namespace DSW_Semester_Project
{
    public partial class FrmSmartWasteRecycling : Form
    {
        public FrmSmartWasteRecycling()
        {
            InitializeComponent();
            txtPassword.IsPassword = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();

            this.Hide();
            
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string typedName = txtUserName.Text.Trim();
            string typedPassword = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(typedName))
            {
                MessageBox.Show("Please enter your username or email.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(typedPassword))
            {
                MessageBox.Show("Please enter your password.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Admin login: any name, but this exact password 
            if (typedPassword == "Admin123")
            {
                Administrator admin = new Administrator(typedName, "", typedPassword, typedName);
                admin.OpenDashboard();
                this.Hide();
                return;
            }

            // Staff/driver login: any name, but this exact password 
            if (typedPassword == "Driver123")
            {
                StaffMember staff = new StaffMember(typedName, "", typedPassword, typedName, "Driver");
                staff.OpenDashboard();
                this.Hide();
                return;
            }

            // Everyone else: normal resident 
            User foundUser = UserData.FindUser(typedName);

            if (foundUser == null || foundUser.CheckPassword(typedPassword) == false)
            {
                MessageBox.Show("Invalid username or password.",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                return;
            }

            foundUser.OpenDashboard();
            this.Hide();
        }

        
    }

}
