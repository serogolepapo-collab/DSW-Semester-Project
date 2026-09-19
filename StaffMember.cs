using System;
using System.Collections.Generic;
using System.Text;

namespace DSW_Semester_Project
{
    public class StaffMember : User
    {
        private string fullName;
        private string position;   // "Driver" or "Collector"

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

      
        public StaffMember(string username, string email, string password,
                           string fullName, string position)
            : base(username, email, password, "Staff")
        {
            this.fullName = fullName;
            this.position = position;
        }

        public bool IsDriver()
        {
            return position == "Driver";
        }

        // Same command, different result - this is POLYMORPHISM
        public override void OpenDashboard()
        {
            CollectionStaff staffForm = new CollectionStaff(this);
            staffForm.Show();
        }

        public override string GetDisplayName()
        {
            return fullName;
        }


    }
}
