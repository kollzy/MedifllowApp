using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace MediFlowGpSYS
{
    public static class Utility
    {
        // Method to retrieve all patients from the database
        public static DataTable GetPatients()
        {
            DataTable patientsTable = new DataTable();

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = "SELECT mrn, Forename, Surname, Email, Address, Phone, MedicalCard, RegistrationDate FROM Patients";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    conn.Open();
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(patientsTable);
                    }
                }
            }

            return patientsTable;
        }

        // Method to search patients by surname and return a DataTable
        public static DataTable SearchPatient(string surname)
        {
            DataTable patientsTable = new DataTable();

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    conn.Open();
                    string sqlQuery = "SELECT mrn, Forename, Surname, Email, Address, Phone, MedicalCard, RegistrationDate FROM Patients WHERE Surname LIKE :surname";
                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("surname", "%" + surname + "%"));

                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            adapter.Fill(patientsTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return patientsTable;
        }

        // Method to filter patients by surname and update the DataGridView
        public static void FilterPatientsBySurname(string surname, DataGridView dataGridView)
        {
            DataTable patientsTable = SearchPatient(surname);

            // Bind the DataTable to the DataGridView
            dataGridView.DataSource = patientsTable;
        }
        public static DataTable GetAppointments()
        {
            DataTable appointmentTable = new DataTable();

            // Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                try
                {
                    // Define the SQL query to retrieve appointments
                    string sqlQuery = "SELECT * FROM APPOINTMENT";

                    // Execute the SQL query (OracleCommand)
                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        conn.Open();
                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            // Fill the appointment table with the retrieved data
                            adapter.Fill(appointmentTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

            return appointmentTable;
        }




       
       

       

        // Method to apply a search filter on the DataTable and update the DataGridView
     



        // Method to check if a patient has pending appointments
        public static bool HasPendingAppointmentsForPatient(int MRN)
        {
            bool hasPendingAppointments = false;

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    conn.Open();

                    string sqlQuery = "SELECT COUNT(*) FROM APPOINTMENT WHERE MRN = :mrn AND APPSTATUS = 'NA'";
                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("mrn", MRN));
                        int pendingAppointments = Convert.ToInt32(cmd.ExecuteScalar());

                        hasPendingAppointments = pendingAppointments > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return hasPendingAppointments;
        }
        // Method to load all appointments
       
       
    

    // Method to check if there are pending appointments for a specific doctor
    public static bool HasPendingAppointments(string doctorName)
        {
            bool hasPendingAppointments = false;

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    conn.Open();

                    string sqlQuery = "SELECT COUNT(*) FROM APPOINTMENT WHERE DOCTORNAME = :doctorName AND APPSTATUS = 'NA'";
                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("doctorName", doctorName));
                        int pendingAppointments = Convert.ToInt32(cmd.ExecuteScalar());

                        hasPendingAppointments = pendingAppointments > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return hasPendingAppointments;
        }



        // Utility method to display error messages
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Utility method to display success messages
        public static void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Validation helper methods
        public static class ValidationHelper
        {
            public static bool IsValidForename(string forename)
            {
                return !string.IsNullOrWhiteSpace(forename) &&
                       forename.All(char.IsLetter) &&
                       forename.Length > 0;
            }

            public static bool IsValidSurname(string surname)
            {
                return !string.IsNullOrWhiteSpace(surname) &&
                       surname.All(char.IsLetter) &&
                       surname.Length > 0;
            }

            public static bool IsValidMDN(string mdn)
            {
                return !string.IsNullOrWhiteSpace(mdn) &&
                       mdn.All(char.IsDigit) &&
                       mdn.Length == 3;
            }

            public static bool IsValidEmail(string email)
            {
                if (string.IsNullOrWhiteSpace(email))
                    return false;

                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return regex.IsMatch(email);
            }

            public static bool IsValidPhoneNumber(string phoneNumber)
            {
                if (string.IsNullOrWhiteSpace(phoneNumber))
                    return false;

                var regex = new Regex(@"^\d{10}$|^\d{12}$"); // Allow 10 or 12 digits
                return regex.IsMatch(phoneNumber);
            }
        }
        public static bool IsValidYear(string yearInput, out int year)
        {
            return int.TryParse(yearInput, out year) && yearInput.Length == 4;
        }
    }
}

