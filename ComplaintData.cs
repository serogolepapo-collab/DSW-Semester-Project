using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace DSW_Semester_Project
{

    // All complaints and reviews file handling lives here:
    //   username|type|description|status|dateSubmitted
    public class ComplaintData
    {
        private const char Separator = '|';
        private static string fileName = "complaints.txt";

        public static void SetUpFile()
        {
            try
            {
                if (File.Exists(fileName) == false)
                {
                    File.WriteAllText(fileName, "");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not create the complaints file.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Saves a brand-new complaint/review submitted by a resident.
        public static bool SaveComplaint(Complaint complaint)
        {
            try
            {
                string line = complaint.ResidentUsername + Separator +
                              complaint.Type + Separator +
                              complaint.Description + Separator +
                              complaint.Status + Separator +
                              complaint.DateSubmitted.ToString("yyyy-MM-dd HH:mm");

                File.AppendAllText(fileName, line + "\n");
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Could not save your submission.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Every complaint belonging to ONE resident is under the List<Complaint> GetComplaintsForResident
        public static List<Complaint> GetComplaintsForResident(string username)
        {
            List<Complaint> results = new List<Complaint>();

            if (File.Exists(fileName) == false)
            {
                return results;
            }

            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                if (line == "")
                {
                    continue;
                }

                string[] parts = line.Split(Separator);

                if (parts.Length < 5)
                {
                    continue;
                }

                if (parts[0] == username)
                {
                    DateTime submittedDate = DateTime.Parse(parts[4]);
                    results.Add(new Complaint(parts[1], parts[2], parts[0], parts[3], submittedDate));
                }
            }

            return results;
        }

        // EVERY complaint from EVERY resident - used by the admin dashboard.
        public static List<Complaint> GetAllComplaints()
        {
            List<Complaint> results = new List<Complaint>();

            if (File.Exists(fileName) == false)
            {
                return results;
            }

            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                if (line == "")
                {
                    continue;
                }

                string[] parts = line.Split(Separator);

                if (parts.Length < 5)
                {
                    continue;
                }
                else
                {
                DateTime submittedDate = DateTime.Parse(parts[4]);
                    results.Add(new Complaint(parts[1], parts[2], parts[0], parts[3], submittedDate));
                }

            }

            return results;
        }



    }
}
