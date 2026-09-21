using System;
using System.Collections.Generic;
using System.Text;

namespace DSW_Semester_Project
{
    public class Complaint
    {
        private string type;
        private string description;
        private string residentUsername;
        private string status;
        private DateTime dateSubmitted;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string ResidentUsername
        {
            get { return residentUsername; }
            set { residentUsername = value; }
        }

        // once a comlaint is logged, it will then go to the admnistration status so
        // they can view and address the complaint 
        public string Status
        {
            get { return status; }
            private set { status = value; }
        }

        public DateTime DateSubmitted
        {
            get { return dateSubmitted; }
            private set { dateSubmitted = value; }
        }

        // Used when a RESIDENT creates a brand-new complaint.
        // Status and date are decided here - not passed in.
        public Complaint(string type, string description, string residentUsername)
        {
            this.type = type;
            this.description = description;
            this.residentUsername = residentUsername;
            this.status = "Submitted";
            this.dateSubmitted = DateTime.Now;
        }

        // Used when LOADING an existing complaint back from the file,
        // where the status and date are already known.
        public Complaint(string type, string description, string residentUsername,
                         string status, DateTime dateSubmitted)
        {
            this.type = type;
            this.description = description;
            this.residentUsername = residentUsername;
            this.status = status;
            this.dateSubmitted = dateSubmitted;
        }
    }
}
