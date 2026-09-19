using System;
using System.Collections.Generic;
using System.Text;

namespace DSW_Semester_Project
{
    public class Administrator : User
    {
        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

      
        public Administrator(string username, string email, string password, string fullName)
            : base(username, email, password, "Administrator")
        {
            this.fullName = fullName;
        }

        // Same command, different result again - POLYMORPHISM
        public override void OpenDashboard()
        {
            Administration adminForm = new Administration(this);
            adminForm.Show();
        }

        public override string GetDisplayName()
        {
            return fullName;
        }



    }
}
