using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediFlowGpSYS
{
	public class Doctor
	{
		public int MDN;
		public string Forename;
		public string Surname;
		public string Email;
		public string Phone;
		public string MDNAME;

		public int DoctorMDN
		{
			get { return MDN; }
			set { MDN = value; }
		}

		public string DoctorForename
		{
			get { return Forename; }
			set { Forename = value; }
		}

		public string DoctorSurname
		{
			get { return Surname; }
			set { Surname = value; }
		}

		public string DoctorEmail
		{
			get { return Email; }
			set { Email = value; }
		}

		public string DoctorPhone
		{
			get { return Phone; }
			set { Phone = value; }
		}

		public Doctor()
		{
			this.MDN = 0;
			this.Forename = "";
			this.Surname = "";
			this.Email = "";
			this.Phone = "";
		}

		public Doctor(int MDN, string Forename, string Surname, string Email, string Phone)
		{
			this.MDN = MDN;
			this.Forename = Forename;
			this.Surname = Surname;
			this.Email = Email;
			this.Phone = Phone;
		}

		// Getters
		public int GetMDN() { return this.MDN; }
		public string GetForename() { return this.Forename; }
		public string GetSurname() { return this.Surname; }
		public string GetEmail() { return this.Email; }
		public string GetPhone() { return this.Phone; }

		// Setters
		public void SetMDN(int MDN) { this.MDN = MDN; }
		public void SetForename(string Forename) { this.Forename = Forename; }
		public void SetSurname(string Surname) { this.Surname = Surname; }
		public void SetEmail(string Email) { this.Email = Email; }
		public void SetPhone(string Phone) { this.Phone = Phone; }

        public static void RegisterDoctor(int mdn, string forename, string surname, string email, string phone)
        {
            // Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb)) 
            {
                // Check if the MDN already exists
                bool mdnExists = CheckIfMDNExists(mdn);

                if (mdnExists)
                {
                    MessageBox.Show("MDN already exists. Please enter a unique MDN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method
                }
                else
                {
                    MessageBox.Show("Doctor registered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Define the SQL query to be executed
                string sqlQuery = "INSERT INTO Doctors (MDN, Forename, Surname, Email, Phone, RegistrationDate) VALUES (:mdn, :forename, :surname, :email, :phone, SYSDATE)";

                // Execute the SQL query (OracleCommand)
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":mdn", OracleDbType.Int32).Value = mdn;
                    cmd.Parameters.Add(":forename", OracleDbType.Varchar2).Value = forename;
                    cmd.Parameters.Add(":surname", OracleDbType.Varchar2).Value = surname;
                    cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;
                    cmd.Parameters.Add(":phone", OracleDbType.Varchar2).Value = phone;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static DataTable GetDoctors()
		{
			DataTable doctorsTable = new DataTable();

			// Open a db connection
			using (OracleConnection conn = new OracleConnection(DBConnect.oradb)) 
			{
				// Define the SQL query to be executed
				string sqlQuery = "SELECT MDN, Forename, Surname, Email, Phone FROM Doctors";

				// Execute the SQL query (OracleCommand)
				using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
				{
					conn.Open();
					using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
					{
						adapter.Fill(doctorsTable);
					}
				}
			}

			return doctorsTable;
		}

		private static bool CheckIfMDNExists(int mdn)
		{
			// Open a db connection
			using (OracleConnection conn = new OracleConnection(DBConnect.oradb)) 
			{
				// Define the SQL query to check if the MDN exists
				string sqlQuery = "SELECT COUNT(*) FROM Doctors WHERE MDN = :mdn";

				// Execute the SQL query (OracleCommand)
				using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
				{
					conn.Open();
					cmd.Parameters.Add(new OracleParameter("mdn", mdn));
					int count = Convert.ToInt32(cmd.ExecuteScalar());
					return count > 0; // If count is greater than 0, MDN exists
				}
			}
		}
		public static bool CheckIfDoctorExistsByName(string doctorName)
		{
			// Open a db connection
			using (OracleConnection conn = new OracleConnection(DBConnect.oradb)) 
			{
				// Define the SQL query to check if the doctor exists by name
				string sqlQuery = "SELECT COUNT(*) FROM Doctors WHERE  Surname = :doctorName";

				// Execute the SQL query (OracleCommand)
				using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
				{
					conn.Open();
					cmd.Parameters.Add(new OracleParameter("doctorName", doctorName));
					int count = Convert.ToInt32(cmd.ExecuteScalar());
					return count > 0; // If count is greater than 0, doctor exists
				}
			}
		}

		public static DataTable GetDoctorsByName(string doctorName)
		{
			DataTable doctorsTable = new DataTable();

			// Open a db connection
			using (OracleConnection conn = new OracleConnection(DBConnect.oradb)) 
			{
				// Define the SQL query to be executed
				string sqlQuery = "SELECT MDN, Forename, Surname, Email, Phone FROM Doctors WHERE Forename LIKE :doctorName OR Surname LIKE :doctorName";

				// Execute the SQL query (OracleCommand)
				using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
				{
					conn.Open();
					cmd.Parameters.Add(new OracleParameter("doctorName", "%" + doctorName + "%"));

					using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
					{
						adapter.Fill(doctorsTable);
					}
				}
			}

			return doctorsTable;
		}

		

		public static void DeregisterDoctor(int mdn)
		{
			// Open a db connection
			using (OracleConnection conn = new OracleConnection(DBConnect.oradb)) 
			{
				try
				{
					// Define the SQL query to be executed
					string sqlQuery = "DELETE FROM Doctors WHERE MDN = :mdn";

					// Execute the SQL query (OracleCommand)
					using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
					{
						cmd.Parameters.Add(new OracleParameter("MDN", mdn));
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
		public static List<Doctor> GetAllDoctors()
		{
			List<Doctor> doctors = new List<Doctor>();
			using (OracleConnection conn = new OracleConnection(DBConnect.oradb)) 
			{
				string sqlQuery = "SELECT MDN, Forename, Surname FROM Doctors";

				conn.Open();

				using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
				{
					OracleDataReader reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						Doctor doctor = new Doctor
						{
							DoctorMDN = Convert.ToInt32(reader["MDN"]),
							DoctorForename = reader["Forename"].ToString(),
							DoctorSurname = reader["Surname"].ToString()
						};

						doctors.Add(doctor);
					}

					reader.Close();
				}

				conn.Close();
			}

			return doctors;
		}

		public static int GetMDNByDoctorName(string doctorName)
		{
			int mdn = -1; 
			string[] nameParts = doctorName.Split(' '); 

			if (nameParts.Length >= 2)
			{
				string forename = nameParts[0];
				string surname = nameParts[1];

				using (OracleConnection conn = new OracleConnection(DBConnect.oradb)) 
				{
					string sqlQuery = "SELECT MDN FROM Doctors WHERE Forename = :forename AND Surname = :surname";

					conn.Open();

					using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
					{
						cmd.Parameters.Add("forename", forename);
						cmd.Parameters.Add("surname", surname);

						OracleDataReader reader = cmd.ExecuteReader();

						if (reader.Read())
						{
							mdn = Convert.ToInt32(reader["MDN"]);
						}

						reader.Close();
					}

					conn.Close();
				}
			}

			return mdn;
		}


	}
}

