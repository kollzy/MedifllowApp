using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MediFlowGpSYS
{


public partial class frmYearlyRevenue : Form
    {
        frmMainMenu parent;

        public frmYearlyRevenue()
        {
            InitializeComponent();
        }

        public frmYearlyRevenue(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmYearlyRevenue_Load(object sender, EventArgs e)
        {
            grdYearlyRevenue.CellClick += dataGridView1_CellClick;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        public void GetYearlyRevenue()
        {
            if (!Utility.IsValidYear(txtboxYear.Text, out int year))
            {
                MessageBox.Show("Please enter a valid year in the format YYYY.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable revenueTable = new DataTable();
            revenueTable.Columns.Add("Year", typeof(int));
            revenueTable.Columns.Add("Month", typeof(string));
            revenueTable.Columns.Add("Monthly Revenue", typeof(string)); // Change type to string
            revenueTable.Columns.Add("Patients Per Month", typeof(int));
            revenueTable.Columns.Add("Yearly Revenue", typeof(string)); // Change type to string

            for (int month = 1; month <= 12; month++)
            {
                decimal monthlyRevenue = GetMonthlyRevenue(year, month);
                int patientsPerMonth = GetPatientsPerMonth(year, month);

                revenueTable.Rows.Add(year,
                    CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month),
                    $"{monthlyRevenue:C} €", // Format with Euro sign
                    patientsPerMonth,
                    $"{0:C} €"); // Placeholder for yearly revenue
            }

            decimal yearlyRevenue = revenueTable.AsEnumerable().Sum(r =>
            {
                if (decimal.TryParse(r["Monthly Revenue"].ToString().Replace(" €", string.Empty), out decimal monthlyRevenue))
                {
                    return monthlyRevenue;
                }
                return 0; // Return 0 if parsing fails
            });

            foreach (DataRow row in revenueTable.Rows)
            {
                row["Yearly Revenue"] = $"{yearlyRevenue:C} €"; // Format with Euro sign
            }

            grdYearlyRevenue.DataSource = revenueTable;

            // Display averages
            DisplayAverages(revenueTable);
        }
        private void DisplayAverages(DataTable revenueTable)
        {
            int totalPatients = revenueTable.AsEnumerable().Sum(r => (int)r["Patients Per Month"]);
            int monthCount = revenueTable.Rows.Count;

            decimal averagePatients = (decimal)totalPatients / monthCount;

            MessageBox.Show($"Average Patients Registered Per Month: {averagePatients:N2}", "Average Patients", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private decimal GetMonthlyRevenue(int year, int month)
        {
            decimal monthlyRevenue = 0;

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = @"
                SELECT SUM(FEES) AS MonthlyRevenue
                FROM APPOINTMENT
                WHERE EXTRACT(YEAR FROM ARRIVALDATE) = :year
                  AND EXTRACT(MONTH FROM ARRIVALDATE) = :month
                  AND PAYMENTSTATUS = 'PATIENT_PAID'
            ";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":year", OracleDbType.Int32).Value = year;
                    cmd.Parameters.Add(":month", OracleDbType.Int32).Value = month;

                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        decimal.TryParse(result.ToString(), out monthlyRevenue);
                    }
                }
            }

            return monthlyRevenue;
        }

        private int GetPatientsPerMonth(int year, int month)
        {
            int patientsPerMonth = 0;

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = @"
                SELECT COUNT(*) AS PatientsPerMonth
                FROM PATIENTS
                WHERE EXTRACT(YEAR FROM RegistrationDate) = :year
                AND EXTRACT(MONTH FROM RegistrationDate) = :month
            ";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":year", OracleDbType.Int32).Value = year;
                    cmd.Parameters.Add(":month", OracleDbType.Int32).Value = month;

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        patientsPerMonth = Convert.ToInt32(result);
                    }
                }
            }

            return patientsPerMonth;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add cell click handling logic here if needed
        }

        private void btnyearlyRev_Click(object sender, EventArgs e)
        {
            try
            {
                GetYearlyRevenue();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    } }