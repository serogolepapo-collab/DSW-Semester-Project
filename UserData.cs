using System;
using System.Collections.Generic;
using System.Text;

namespace DSW_Semester_Project
{
    public static class UserData
    {
        
        private static string fileName = "users.txt";

        // Each line in users.txt looks like this:
        //   username|email|password|role|fullName|address/position
        //
        // Example lines:
        //   admin|admin@waste.co.za|Admin123|Administrator|System Admin|
        //   driver1|d1@waste.co.za|Driver123|Staff|John Dlamini|Driver
        //   sipho|sipho@gmail.com|Sipho123|Resident|Sipho Papo|12 Main St, Soweto

        public static void SetUpFile()
        {
            try
            {
                // If the file doesn't exist yet, we create it with the
                // default admin and staff accounts inside.
                if (File.Exists(fileName) == false)
                {
                    File.WriteAllText(fileName,
                        "admin|admin@waste.co.za|Admin123|Administrator|System Admin|\n");

                    File.AppendAllText(fileName,
                        "driver1|driver1@waste.co.za|Driver123|Staff|John Dlamini|Driver\n");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not create the users file.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        // Looks for a user by username OR email.
        // Returns the correct CHILD object (Resident / StaffMember /
        // Administrator) but the return type is the PARENT type User.
        // Returns null if nothing is found.
        public static User FindUser(string usernameOrEmail)
        {
            try
            {
                if (File.Exists(fileName) == false)
                {
                    return null;
                }

                // Read every line of the file into an array
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    if (line == "")
                    {
                        continue;   // skip empty lines
                    }

                    
                    string[] parts = line.Split('|');

                    if (parts.Length < 6)
                    {
                        continue;   // skip broken lines
                    }

                    string username = parts[0];
                    string email = parts[1];
                    string password = parts[2];
                    string role = parts[3];
                    string fullName = parts[4];
                    string extra = parts[5];   // address for residents, position for staff

                    // Does this line match what the user typed?
                    if (username.ToLower() == usernameOrEmail.ToLower() ||
                        email.ToLower() == usernameOrEmail.ToLower())
                    {
                      
                        // The role saved in the file tells us which class to build.
                        // The user never has to choose - the file already knows.

                        if (role == "Resident")
                        {
                            return new Resident(username, email, password, fullName, extra);
                        }
                        else if (role == "Staff")
                        {
                            return new StaffMember(username, email, password, fullName, extra);
                        }
                        else if (role == "Administrator")
                        {
                            return new Administrator(username, email, password, fullName);
                        }
                    }
                }

                return null;   // no matching account found
            }
            catch (Exception)
            {
                MessageBox.Show("Could not read the users file.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        
        // CHECKING FOR DUPLICATES
       
        public static bool EmailAlreadyUsed(string email)
        {
            User found = FindUser(email);

            if (found == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

      
        // SAVING A NEW RESIDENT
       
        public static bool SaveNewResident(Resident newResident)
        {
            try
            {
                string line = newResident.Username + "|" +
                              newResident.Email + "|" +
                              newResident.GetPasswordForSaving() + "|" +
                              "Resident" + "|" +
                              newResident.FullName + "|" +
                              newResident.Address;

                File.AppendAllText(fileName, line + "\n");
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Could not save the new account.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

      
        // UPDATING A RESIDENT'S ADDRESS
        // Reads every line, changes the matching one, writes them all back.
     
        public static bool UpdateResidentAddress(Resident resident)
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName);
                List<string> newLines = new List<string>();

                foreach (string line in lines)
                {
                    if (line == "")
                    {
                        continue;
                    }

                    string[] parts = line.Split('|');

                    if (parts.Length >= 6 && parts[0] == resident.Username)
                    {
                        // This is the line we want to change - rebuild it
                        string updated = resident.Username + "|" +
                                         resident.Email + "|" +
                                         resident.GetPasswordForSaving() + "|" +
                                         "Resident" + "|" +
                                         resident.FullName + "|" +
                                         resident.Address;
                        newLines.Add(updated);
                    }
                    else
                    {
                        // Keep every other line exactly as it was
                        newLines.Add(line);
                    }
                }

                File.WriteAllLines(fileName, newLines);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Could not update the address.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Every resident account - used by the admin dashboard's grid.
        public static List<Resident> GetAllResidents()
        {
            List<Resident> results = new List<Resident>();

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

                string[] parts = line.Split('|');

                if (parts.Length < 6)
                {
                    continue;
                }

                string role = parts[3];

                if (role == "Resident")
                {
                    Resident newResident = new Resident(parts[0], parts[1], parts[2], parts[4], parts[5]);
                    results.Add(newResident);
                }
            }

            return results;
        }


    }
}
