using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MediFlowGpSYS
{
    public partial class frmMedicalCardAnalysis : Form
    {
        private frmMainMenu parent;

        public frmMedicalCardAnalysis()
        {
            InitializeComponent();
        }

        public frmMedicalCardAnalysis(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }

        private void frmMedicalCardAnalysis_Load(object sender, EventArgs e)
        {
            // Initialize the data grid view
            grdMedicalCardAnalysis.ColumnCount = 2;
            grdMedicalCardAnalysis.Columns[0].HeaderText = "Medical Card";
            grdMedicalCardAnalysis.Columns[1].HeaderText = "Count";
        }

        private void btnGetMedicalCard_Click(object sender, EventArgs e)
        {
            DisplayMedicalCardCounts();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisplayMedicalCardCounts();
        }

        private void DisplayMedicalCardCounts()
        {
            // Validate year input using the utility class
            if (!Utility.IsValidYear(txtboxYear.Text, out int year))
            {
                MessageBox.Show("Please enter a valid year in the format YYYY.", "Invalid Year", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Initialize counts
            int withMedicalCard = 0;
            int withoutMedicalCard = 0;

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                try
                {
                    conn.Open();
                    string sql = @"
            SELECT MEDICALCARD, COUNT(*) AS COUNT 
            FROM PATIENTS 
            WHERE EXTRACT(YEAR FROM RegistrationDate) = :year 
            GROUP BY MEDICALCARD";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.Parameters.Add(":year", OracleDbType.Int32).Value = year;

                    OracleDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string medicalCard = reader.GetString(0);
                        int count = reader.GetInt32(1);

                        if (medicalCard.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                        {
                            withMedicalCard = count;
                        }
                        else if (medicalCard.Equals("No", StringComparison.OrdinalIgnoreCase))
                        {
                            withoutMedicalCard = count;
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return;
                }
                finally
                {
                    conn.Close();
                }
            }

            // Update the data grid view
            grdMedicalCardAnalysis.Rows.Clear();
            grdMedicalCardAnalysis.Rows.Add(new[] { "Medical Card", withMedicalCard.ToString() });
            grdMedicalCardAnalysis.Rows.Add(new[] { "No Medical Card", withoutMedicalCard.ToString() });
        }
    }
}