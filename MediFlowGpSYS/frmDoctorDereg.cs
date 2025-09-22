using System;
using System.Data;
using System.Windows.Forms;
using static MediFlowGpSYS.Utility;

namespace MediFlowGpSYS
{
    public partial class frmDoctorDereg : Form
    {
        frmMainMenu parent;
        public frmDoctorDereg()
        {
            InitializeComponent();
        }

        int MDNN;
        string nmdoc;
        string userdoc;

        public frmDoctorDereg(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void DeRegisterDocButton_Click(object sender, EventArgs e)
        {
            string doctorName = $"{nmdoc} {userdoc}";

            if (Utility.HasPendingAppointments(doctorName))
            {
                MessageBox.Show("You have scheduled appointments for this doctor. Please cancel the pending appointments before deregistering the doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if a doctor is selected
            if (MDNN == 0)
            {
                MessageBox.Show("No doctor selected. Please select a doctor you want to deregister", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to deregister Doctor with surname {userdoc}, forename {nmdoc} and mdn {MDNN}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Doctor.DeregisterDoctor(MDNN);
                MessageBox.Show($"Doctor with surname {userdoc}, forename {nmdoc} and mdn {MDNN} deregistered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Store the search text before reloading the doctors' data
                string searchText = txtboxSearch.Text;

                loaddoc(); // Reload the doctors' data

                // Reapply the search filter
                SearchByName(searchText);
            }
        }

        private DataTable dataTable;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
            SearchByName(grdDoctordereg, txtboxSearch.Text);
        }
        public static void SearchByName(DataGridView dataGrid, string searchName)
        {
            string filter = $" Surname LIKE '%{searchName}%'";
            ((DataTable)dataGrid.DataSource).DefaultView.RowFilter = filter;
        }

        void loaddoc()
        {
            DataTable doctorsData = Doctor.GetDoctors();
            grdDoctordereg.DataSource = doctorsData;
        }

        void search()
        {
            string doctorNameToSearch = txtboxSearch.Text.Trim();

            DataTable doctorsData = Doctor.GetDoctors();
            DataRow[] matchingDoctors = doctorsData.Select($"SURNAME = '{doctorNameToSearch}'");

            if (matchingDoctors.Length > 0)
            {
                grdDoctordereg.Visible = true;
                grdDoctordereg.DataSource = doctorsData;
            }
            else
            {
                grdDoctordereg.Visible = false;
                MessageBox.Show("Doctor does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchByName(string searchName)
        {
            string filter = $" Surname LIKE '%{searchName}%'";
            ((DataTable)grdDoctordereg.DataSource).DefaultView.RowFilter = filter;
        }

        private void searchTxtbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void frmDoctorDereg_Load(object sender, EventArgs e)
        {
            grdDoctordereg.Visible = false; // Hide the DataGrid initially
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private int mdn = -1;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the value of the cell in the second column (assuming name is in the second column)
            int docID = int.Parse(grdDoctordereg.Rows[e.RowIndex].Cells[0].Value.ToString());
            string namedoc = grdDoctordereg.Rows[e.RowIndex].Cells[1].Value.ToString();
            string surnamdoc = grdDoctordereg.Rows[e.RowIndex].Cells[2].Value.ToString();

            // Set the text of your TextBox
            MDNN = docID;
            nmdoc = namedoc;
            userdoc = surnamdoc;

            // Update the MessageBox message
            MessageBox.Show("Selected Doctor: Surname " + userdoc + ", Forename " + nmdoc + ", MDN " + MDNN, "Doctor Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


