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
    public partial class frmPatientDereg : Form
    {
        frmMainMenu parent;
        private DataTable dataTable;
        int patientID;
        string forename;
        string surname;

        public frmPatientDereg()
        {
            InitializeComponent();
        }

        public frmPatientDereg(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchSurname = txtboxSearch.Text;
            SearchPatient(searchSurname);
            FilterPatientsBySurname(searchSurname);
        }

        private void frmPatientDereg_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private int mdn = -1;

        private void LoadPatients()
        {
            dataTable = Utility.GetPatients();
            grdfrmPatientDereg.DataSource = dataTable;
        }

        private void SearchPatient(string surname)
        {
            // Fetch the search results from Utility and set it to the DataGridView
            DataTable resultTable = Utility.SearchPatient(surname);
            grdfrmPatientDereg.DataSource = resultTable;
        }

        private void FilterPatientsBySurname(string surname)
        {
            // Use the Utility method to filter and update the DataGridView
            Utility.FilterPatientsBySurname(surname, grdfrmPatientDereg);
        }

        private void btnDeRegPatient_Click_1(object sender, EventArgs e)
        {


            if (Utility.HasPendingAppointmentsForPatient(patientID))
            {
                MessageBox.Show("You have scheduled appointments for this Patient. Please cancel the pending appointments before deregistering the Patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if a patient is selected
            if (patientID == 0)
            {
                MessageBox.Show("No patient selected. Please select a patient you want to deregister", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to deregister Patient with surname " + surname + ", forename " + forename + " and Medical Record number" + patientID + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Patient patient = new Patient(); // Create an instance of the Patient class
                patient.DeregisterPatient(patientID);
                MessageBox.Show("Patient with surname " + surname + ", forename " + forename + " and Medical record Number " + patientID + " deregistered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Store the search text before reloading the patients' data
                string searchText = txtboxSearch.Text;

                LoadPatients(); // Reload the patients' data

                // Reapply the search filter
                FilterPatientsBySurname(searchText);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                patientID = int.Parse(grdfrmPatientDereg.Rows[e.RowIndex].Cells[0].Value.ToString());
                forename = grdfrmPatientDereg.Rows[e.RowIndex].Cells[1].Value.ToString();
                surname = grdfrmPatientDereg.Rows[e.RowIndex].Cells[2].Value.ToString();

                MessageBox.Show("Selected Patient: Surname " + surname + ", Forename " + forename + ", Patient ID " + patientID, "Patient Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}

