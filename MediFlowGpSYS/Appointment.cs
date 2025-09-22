using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediFlowGpSYS
{
    internal class Appointment
    {
        public static void ScheduleAppointment(DateTime appointmentDateTime, int mrn, string DOCTORNAME, string appointmentTime)
        {
            // Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb)) 
            {
                try
                {
                    // Define the SQL query to be executed
                    string sqlQuery = "INSERT INTO APPOINTMENT (APPID, ARRIVALDATE, MRN, DOCTORNAME, ARRIVALTIME) " +
                   "VALUES (:appid, :appointmentDateTime, :mrn, :mdn, :appointmentTime)";

                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("appid", GenerateUniqueAppointmentId()));
                        cmd.Parameters.Add(new OracleParameter("appointmentDateTime", appointmentDateTime));
                        cmd.Parameters.Add(new OracleParameter("mrn", mrn));
                        cmd.Parameters.Add(new OracleParameter("mdn", DOCTORNAME));
                        cmd.Parameters.Add(new OracleParameter("appointmentTime", appointmentTime));

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Appointment scheduled successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to schedule appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private static string GenerateUniqueAppointmentId()
        {
            // Generate a unique 3-digit APPID value
            int maxAppId = 999;
            int minAppId = 100;
            Random random = new Random();
            return random.Next(minAppId, maxAppId + 1).ToString("D3");
        }

        public static Dictionary<string, List<string>> GetAvailableTimesForDoctors(DateTime appointmentDate)
        {
            Dictionary<string, List<string>> availableTimesForDoctors = new Dictionary<string, List<string>>();
            DateTime currentTime = DateTime.Now;

            // Retrieve doctors
            List<Doctor> doctors = Doctor.GetAllDoctors(); // Assuming there's a method to get all doctors

            foreach (Doctor doctor in doctors)
            {
                List<string> bookedTimes = GetBookedTimesForDate(appointmentDate, doctor.Forename + " " + doctor.Surname);
                List<string> availableTimes = new List<string>();

                // Define available times
                List<string> allTimes = new List<string>();
                for (int i = 13; i <= 17; i++) // Loop from 01:00 PM to 05:00 PM
                {
                    string time = i.ToString().PadLeft(2, '0') + ":00 PM"; // Assuming times are in PM
                    DateTime timeObject = appointmentDate.Date.AddHours(i);
                    if (timeObject >= currentTime)
                    {
                        allTimes.Add(time);
                    }
                }

                // Add only if not booked
                bool allTimesBooked = true;
                foreach (string time in allTimes)
                {
                    if (!bookedTimes.Contains(time))
                    {
                        availableTimes.Add(time);
                        allTimesBooked = false;
                    }
                }

                if (allTimesBooked && appointmentDate.Date.AddHours(17) < currentTime)
                {
                    availableTimesForDoctors.Add(doctor.Forename + " " + doctor.Surname, new List<string> { "No available appointment time today" });
                }
                else
                {
                    availableTimesForDoctors.Add(doctor.Forename + " " + doctor.Surname, availableTimes);
                }
            }

            return availableTimesForDoctors;
        }
       
        
        
        private static List<string> GetBookedTimesForDate(DateTime appointmentDate, string doctorName)
        {
            List<string> bookedTimes = new List<string>();

            // Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb)) 
            {
                // Define the SQL query to get booked times for the specified date and doctor
                string sqlQuery = "SELECT ARRIVALTIME FROM APPOINTMENT WHERE TRUNC(ARRIVALDATE) = :appointmentDate AND DOCTORNAME = :doctorName";

                // Execute the SQL query (OracleCommand)
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("appointmentDate", appointmentDate.Date));
                    cmd.Parameters.Add(new OracleParameter("doctorName", doctorName));

                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bookedTimes.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return bookedTimes;
        }

        public static void CancelAppointment(int appointmentId)
        {
            // Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                try
                {
                    // Define the SQL query to cancel the appointment
                    string sqlQuery = "DELETE FROM APPOINTMENT WHERE APPID = :appointmentId";

                    // Execute the SQL query (OracleCommand)
                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("appointmentId", appointmentId));
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Appointment was successfully canceled
                            MessageBox.Show($"Appointment with ID {appointmentId} has been canceled.");
                        }
                        else
                        {
                            // No appointment found with the given ID
                            MessageBox.Show($"No appointment found with ID {appointmentId}.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        public static void RecordArrivalDepartures(int appointmentId)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                try
                {
                    string sqlQuery = "UPDATE APPOINTMENT SET APPSTATUS = 'ARRIVED' WHERE APPID = :appointmentId";

                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("appointmentId", appointmentId));
                        conn.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Appointment with ID {appointmentId} has been set to 'ARRIVED'.");
                        }
                        else
                        {
                            MessageBox.Show($"No appointment found with ID {appointmentId}.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        public static void RecordPayment(int appointmentId)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                try
                {
                    conn.Open();

                    // Get the patient's MRN from the APPOINTMENT table
                    string getMrnSql = "SELECT MRN FROM APPOINTMENT WHERE APPID = :appointmentId";
                    int mrn = 0;
                    using (OracleCommand cmd = new OracleCommand(getMrnSql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("appointmentId", appointmentId));
                        object mrnObj = cmd.ExecuteScalar();
                        if (mrnObj != null && int.TryParse(mrnObj.ToString(), out mrn))
                        {
                            // MRN value was successfully retrieved
                        }
                        else
                        {
                            MessageBox.Show($"No appointment found with ID {appointmentId}.");
                            return;
                        }
                    }

                    // Check if the patient has a medical card in the PATIENTS table
                    string checkMedicalCardSql = "SELECT MEDICALCARD FROM PATIENTS WHERE MRN = :mrn";
                    bool hasMedicalCard = false;
                    using (OracleCommand cmd = new OracleCommand(checkMedicalCardSql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("mrn", mrn));
                        object medicalCardObj = cmd.ExecuteScalar();
                        if (medicalCardObj != null)
                        {
                            string medicalCardString = medicalCardObj.ToString().Trim().ToUpper();
                            hasMedicalCard = medicalCardString == "YES"; // Check for 'YES' in uppercase
                        }
                        else
                        {
                            // The medical card value could not be retrieved; assuming the patient doesn't have a medical card
                            hasMedicalCard = false;
                        }
                    }

                    // Update the payment status based on medical card status
                    string updatePaymentSql = "UPDATE APPOINTMENT SET PAYMENTSTATUS = :paymentStatus WHERE APPID = :appointmentId";
                    using (OracleCommand cmd = new OracleCommand(updatePaymentSql, conn))
                    {
                        string paymentStatus = hasMedicalCard ? "PATIENT_PAID WITH MEDICAL CARD" : "PATIENT_PAID";

                        cmd.Parameters.Add(new OracleParameter("paymentStatus", paymentStatus));
                        cmd.Parameters.Add(new OracleParameter("appointmentId", appointmentId));
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Appointment with ID {appointmentId} has been updated with the new payment status: {paymentStatus}.");
                        }
                        else
                        {
                            MessageBox.Show($"No appointment found with ID {appointmentId}.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}\n\n{ex.StackTrace}");
                    // Optionally, log the exception to a file or a logging service for further investigation
                }
            }
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
    }
    
}
