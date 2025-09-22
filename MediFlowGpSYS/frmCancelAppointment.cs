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
    public partial class frmCancelAppointment : Form
    {
        frmMainMenu parent;
        private DataTable appointmentDataTable;
        private int appointmentID;

        public frmCancelAppointment()
        {
            InitializeComponent();
        }

        public frmCancelAppointment(frmMainMenu parent)
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
            SearchAppointment();
        }

        private void frmCancelAppointment_Load(object sender, EventArgs e)
        {
            LoadAppointments();
            grdCancelAppointment.CellClick += dataGridView1_CellClick;
        }

        private void LoadAppointments()
        {
            appointmentDataTable = Utility.GetAppointments(); // Use Utility to get appointments
            grdCancelAppointment.DataSource = appointmentDataTable;
        }

        private void SearchAppointment()
        {
            int appointmentIDToSearch;
            if (int.TryParse(txtboxAppid.Text.Trim(), out appointmentIDToSearch))
            {
                DataRow[] matchingAppointments = appointmentDataTable.Select($"APPID = {appointmentIDToSearch}");

                if (matchingAppointments.Length > 0)
                {
                    MessageBox.Show($"Appointment with ID {appointmentIDToSearch} found.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Select the matching row in the DataGridView
                    foreach (DataGridViewRow row in grdCancelAppointment.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == appointmentIDToSearch.ToString())
                        {
                            row.Selected = true;
                            grdCancelAppointment.CurrentCell = row.Cells[0]; // Set the current cell to the selected cell
                            break;
                        }
                    }
                }
                else
                {
                    Utility.ShowError($"Appointment with ID {appointmentIDToSearch} not found."); // Use Utility to show error
                }
            }
            else
            {
                Utility.ShowError("Please enter a valid Appointment ID."); // Use Utility to show error
            }
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            // Check if an appointment is selected
            if (appointmentID == 0)
            {
                Utility.ShowError("No appointment selected. Please select an appointment you want to cancel."); // Use Utility to show error
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to cancel the appointment with ID {appointmentID}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Appointment.CancelAppointment(appointmentID); // Cancel appointment using existing logic
                Utility.ShowSuccess($"Appointment with ID {appointmentID} has been canceled successfully."); // Use Utility to show success

                // Store the search text before reloading the appointments' data
                int searchAppointmentID = appointmentID;

                LoadAppointments(); // Reload the appointments' data

                // Reapply the search filter
                SearchByAppointmentID(searchAppointmentID);
            }
        }

        private void SearchByAppointmentID(int searchAppointmentID)
        {
            string filter = $"APPID = {searchAppointmentID}";
            appointmentDataTable.DefaultView.RowFilter = filter;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Assuming the first column contains the appointment ID
            if (e.RowIndex >= 0)
            {
                appointmentID = Convert.ToInt32(grdCancelAppointment.Rows[e.RowIndex].Cells[0].Value);
            }
        }
    }
}