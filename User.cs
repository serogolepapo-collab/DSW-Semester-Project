namespace DSW_Semester_Project
{
    //Parent class (Base class)
    public class User
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string password;

        public string Password
        {

            set { password = value; }
        }
        private string role;

        public string Role
        {
            get { return role; }
            set { role = value; }
        }


        // Parameterised constructor
        public User(string username, string email, string password, string role)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.role = role;
        }

        // checks if a password typed matches this user's password.
        public bool CheckPassword(string typedPassword)
        {
            return password == typedPassword;
        }

        // Used when saving to the text file.
        public string GetPasswordForSaving()
        {
            return password;
        }

        // VIRTUAL = child classes are allowed to replace this method.
        // This is the method that makes POLYMORPHISM work.
        public virtual void OpenDashboard()
        {
            // The parent doesn't know which form to open.
            // Each child class overrides this and opens its own form.
        }

        // VIRTUAL = children can give a better version of this too.
        public virtual string GetDisplayName()
        {
            return username;
        }


    }
}
