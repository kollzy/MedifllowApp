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
    public partial class frmRecordArrivalDepartures : Form
    {
        frmMainMenu parent;
        private DataTable appointmentDataTable;
        private int appointmentID;
        private string doctorName;
        private string patientName;
        private DateTime appointmentDateTime;

        public frmRecordArrivalDepartures()
        {
            InitializeComponent();
        }
        public frmRecordArrivalDepartures(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchAppointment();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnSetAppStatus_Click(object sender, EventArgs e)
        {
            if (appointmentID == 0)
            {
                MessageBox.Show("No appointment selected. Please select an appointment you want to Update the Appointment Status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to set the Appointment with ID {appointmentID} to ARRIVED?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Appointment.RecordArrivalDepartures(appointmentID);

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

        private void frmRecordArrivalDepartures_Load(object sender, EventArgs e)
        {
            LoadAppointments();
            grdRecordArrDep.CellClick += dataGridView1_CellClick;
        }

        private void LoadAppointments()
        {
            appointmentDataTable = Appointment.GetAppointments();
            grdRecordArrDep.DataSource = appointmentDataTable;
        }

        private void SearchAppointment()
        {
            int appointmentIDToSearch = 0;
            if (int.TryParse(txtboxAppid.Text.Trim(), out appointmentIDToSearch))
            {
                DataRow[] matchingAppointments = appointmentDataTable.Select($"APPID = {appointmentIDToSearch}");

                if (matchingAppointments.Length > 0)
                {
                    // Select the matching row in the DataGridView
                    foreach (DataGridViewRow row in grdRecordArrDep.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == appointmentIDToSearch.ToString())
                        {
                            row.Selected = true;
                            grdRecordArrDep.CurrentCell = row.Cells[0];
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Appointment with ID {appointmentIDToSearch} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Appointment ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                appointmentID = int.Parse(grdRecordArrDep.Rows[e.RowIndex].Cells[0].Value.ToString());
                doctorName = grdRecordArrDep.Rows[e.RowIndex].Cells[1].Value.ToString();
                patientName = grdRecordArrDep.Rows[e.RowIndex].Cells[2].Value.ToString();
                appointmentDateTime = (DateTime)grdRecordArrDep.Rows[e.RowIndex].Cells[3].Value;

                MessageBox.Show($"Selected Appointment: Appointment ID {appointmentID}, Doctor '{doctorName}', Patient '{patientName}', Date/Time {appointmentDateTime.ToString("yyyy-MM-dd")}", "Appointment Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grdRecordArrDep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
    

