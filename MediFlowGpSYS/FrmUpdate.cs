using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediFlowGpSYS
{
    public partial class FrmUpdate : Form
    {
        private frmMainMenu parent;
        private DataTable dataTable;
        private int patientID;
        private string forename;
        private string surname;

        public FrmUpdate()
        {
            InitializeComponent();
        }

        public FrmUpdate(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backButton_Click(object sender, EventArgs e)

        {
            frmMainMenu mainMenu = new frmMainMenu(); // Create a new instance of frmMainMenu
            mainMenu.Show(); // Show the frmMainMenu
            this.Hide(); // Hide the current FrmUpdate form
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchSurname = txtboxSearch.Text;
            SearchPatient(searchSurname);
            FilterPatientsBySurname(searchSurname);
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }


        private void LoadPatients()
        {
            dataTable = Utility.GetPatients();
            grdFrmUpdate.DataSource = dataTable;
        }

        private void SearchPatient(string surname)
        {
            DataTable resultTable = Utility.SearchPatient(surname);
            grdFrmUpdate.DataSource = resultTable;
        }

        private void FilterPatientsBySurname(string surname)
        {
            Utility.FilterPatientsBySurname(surname, grdFrmUpdate);
        }


        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            // Check if a patient is selected
            if (patientID == 0)
            {
                MessageBox.Show("No patient selected. Please select a patient you want to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to Update Patient details with surname " + surname + ", forename " + forename + " and Medical Record number" + patientID + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Open the frmPatientUpdate form 
                frmPatientUpdate patientUpdateForm = new frmPatientUpdate(patientID);
                patientUpdateForm.ShowDialog();

                // Refresh the patient list after updating
                LoadPatients();
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                patientID = int.Parse(grdFrmUpdate.Rows[e.RowIndex].Cells[0].Value.ToString());
                forename = grdFrmUpdate.Rows[e.RowIndex].Cells[1].Value.ToString();
                surname = grdFrmUpdate.Rows[e.RowIndex].Cells[2].Value.ToString();

                MessageBox.Show("Selected Patient: Surname " + surname + ", Forename " + forename + ", Patient ID " + patientID, "Patient Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

