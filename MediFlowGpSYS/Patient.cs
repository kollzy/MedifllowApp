using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace MediFlowGpSYS
{
    public class Patient
    {
        private int MRN;
        private string Forename;
        private string Surname;
        private string Email;
        private string Address;
        private string PhoneNumber;
        private bool MedicalCard;

        public Patient()
        {
            this.MRN = 0;
            this.Forename = "";
            this.Surname = "";
            this.Email = "";
            this.Address = "";
            this.PhoneNumber = "";
            this.MedicalCard = false; // Default value: No medical card
        }

        public Patient(int MRN, string Forename, string Surname, string Email, string Address, string PhoneNumber, bool MedicalCard)
        {
            this.MRN = MRN;
            this.Forename = Forename;
            this.Surname = Surname;
            this.Email = Email;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.MedicalCard = MedicalCard;
        }

        // Getters
        public int GetMRN() { return this.MRN; }
        public string GetForename() { return this.Forename; }
        public string GetSurname() { return this.Surname; }
        public string GetEmail() { return this.Email; }
        public string GetAddress() { return this.Address; }
        public string GetPhoneNumber() { return this.PhoneNumber; }
        public bool HasMedicalCard() { return this.MedicalCard; }

        // Setters
        public void SetMRN(int MRN) { this.MRN = MRN; }
        public void SetForename(string Forename) { this.Forename = Forename; }
        public void SetSurname(string Surname) { this.Surname = Surname; }
        public void SetEmail(string Email) { this.Email = Email; }
        public void SetAddress(string Address) { this.Address = Address; }
        public void SetPhoneNumber(string PhoneNumber) { this.PhoneNumber = PhoneNumber; }
        public void SetMedicalCard(bool MedicalCard) { this.MedicalCard = MedicalCard; }

        // Additional methods, if needed

        // Register a patient
        public void RegisterPatient(int mrn, string Forename, string Surname, string Email, string Address, string PhoneNumber, bool MedicalCard)
        {
            // Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                bool mrnExists = CheckIfMRNExists(mrn);

                if (mrnExists)
                {
                    MessageBox.Show("MRN already exists. Please enter Your unique MRN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method
                }
                else
                {
                    MessageBox.Show("Patient registered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Define the SQL query to be executed
                string sqlQuery = "INSERT INTO Patients (mrn, Forename, Surname, Email, Address, Phone, MedicalCard, RegistrationDate) " +
                                  "VALUES (:mrn, :Forename, :Surname, :Email, :Address, :Phone, :MedicalCard, :RegistrationDate)";

                // Execute the SQL query (OracleCommand)
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(new OracleParameter(":mrn", OracleDbType.Int32)).Value = mrn;
                    cmd.Parameters.Add(new OracleParameter(":Forename", OracleDbType.Varchar2, 50)).Value = Forename;
                    cmd.Parameters.Add(new OracleParameter(":Surname", OracleDbType.Varchar2, 50)).Value = Surname;
                    cmd.Parameters.Add(new OracleParameter(":Email", OracleDbType.Varchar2, 100)).Value = Email;
                    cmd.Parameters.Add(new OracleParameter(":Address", OracleDbType.Varchar2, 200)).Value = Address;
                    cmd.Parameters.Add(new OracleParameter(":Phone", OracleDbType.Varchar2)).Value = PhoneNumber;
                    cmd.Parameters.Add(new OracleParameter(":MedicalCard", OracleDbType.Varchar2, 3)).Value = MedicalCard ? "Yes" : "No";
                    cmd.Parameters.Add(new OracleParameter(":RegistrationDate", OracleDbType.Date)).Value = DateTime.Now;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


       
        public static bool CheckIfMRNExists(int mrn)
        {
            // Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb)) 
            {
                // Define the SQL query to check if the MRN exists
                string sqlQuery = "SELECT COUNT(*) FROM Patients WHERE MRN = :mrn";

                // Execute the SQL query (OracleCommand)
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    conn.Open();
                    cmd.Parameters.Add(new OracleParameter("mrn", mrn));
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // If count is greater than 0, MRN exists
                }
            }
        }
        public static List<string> SearchPationByMRN(string mrn)
        {
            List<string> matchingDoctors = new List<string>();

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = "SELECT MRN FROM PATIENTS WHERE MRN LIKE :mrn";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    conn.Open();
                    cmd.Parameters.Add(new OracleParameter("mrn", mrn + "%"));

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string pationMrN = reader["MRN"].ToString();
                            matchingDoctors.Add(pationMrN);
                        }
                    }
                }
            }

            return matchingDoctors;
        }
        public string GetPATIENTSFullNameFromMDN(string mrn)
        {
            string doctorFullName = string.Empty;

            // Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb)) 
            {
                try
                {
                    // Define the SQL query to retrieve the doctor's full name
                    string sqlQuery = "SELECT Forename, Surname FROM PATIENTS WHERE MRN = :mrn";

                    // Execute the SQL query (OracleCommand)
                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("MRN", mrn));
                        conn.Open();

                        // Execute the query and retrieve the doctor's full name
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Concatenate forename and surname to form full name
                                string forename = reader["Forename"].ToString();
                                string surname = reader["Surname"].ToString();
                                doctorFullName = forename + " " + surname;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return doctorFullName;
        }
        // Deregister a patient by surname
        public void DeregisterPatient(int mrn)
        {
            // Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb)) 
            {
                try
                {
                    // Define the SQL query to be executed
                    string sqlQuery = "DELETE FROM Patients WHERE MRN = :mrn";

                    // Execute the SQL query (OracleCommand)
                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("MRN", mrn));
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
          

    }
}
