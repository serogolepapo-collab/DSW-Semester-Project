using System;
using System.Collections.Generic;
using System.Text;

namespace DSW_Semester_Project
{
    public class Resident : User
    {
        // Only the EXTRA things a Resident has, that a plain User doesn't
        private string fullName;
        private string address;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        // ": base(...)" passes the shared data up to the User constructor,
        // so we don't repeat that code here.
        public Resident(string username, string email, string password,
                        string fullName, string address)
            : base(username, email, password, "Resident")
        {
            this.fullName = fullName;
            this.address = address;
        }

        public bool HasAddress()
        {
            return address != "";
        }

        // OVERRIDE = we are replacing the parent's version of this method.
        // When the login form calls OpenDashboard(), THIS runs for a resident.
        public override void OpenDashboard()
        {
            Residents residentForm = new Residents(this);
            residentForm.Show();
        }

        public override string GetDisplayName()
        {
            return fullName;
        }

    }
}
