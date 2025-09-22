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
    public partial class frmRecordPayment : Form
    {

        frmMainMenu parent;
        private DataTable appointmentDataTable;
        private int appointmentID;
        private string doctorName;
        private string patientName;
        private DateTime appointmentDateTime;

        public frmRecordPayment()
        {
            InitializeComponent();
        }
        public frmRecordPayment(frmMainMenu parent)
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
        private void btnSetPaymentStatus_Click(object sender, EventArgs e)
        {
            if (appointmentID == 0)
            {
                MessageBox.Show("No appointment selected. Please select an appointment you want to Record the Payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to Record Payment for the Appointment with ID {appointmentID}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Appointment.RecordPayment(appointmentID);

                // Store the search text before reloading the appointments' data
                int searchAppointmentID = appointmentID;

                LoadAppointments(); // Reload the appointments' data

                // Reapply the search filter
                SearchByAppointmentID(searchAppointmentID);
            }
        }

        private void LoadAppointments()
        {
            appointmentDataTable = Appointment.GetAppointments();
            grdRecordPayment.DataSource = appointmentDataTable;
        }
        private void SearchByAppointmentID(int searchAppointmentID)
        {
            string filter = $"APPID = {searchAppointmentID}";
            appointmentDataTable.DefaultView.RowFilter = filter;
        }
        private void SearchAppointment()
        {
            int appointmentIDToSearch = 0;
            if (int.TryParse(txtboxAppId.Text.Trim(), out appointmentIDToSearch))
            {
                DataRow[] matchingAppointments = appointmentDataTable.Select($"APPID = {appointmentIDToSearch}");

                if (matchingAppointments.Length > 0)
                {
                    // Select the matching row in the DataGridView
                    foreach (DataGridViewRow row in grdRecordPayment.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == appointmentIDToSearch.ToString())
                        {
                            row.Selected = true;
                            grdRecordPayment.CurrentCell = row.Cells[0];
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Appointment with ID {appointmentIDToSearch} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }


        private void frmRecordPayment_Load(object sender, EventArgs e)
        {
            LoadAppointments();
            grdRecordPayment.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                appointmentID = int.Parse(grdRecordPayment.Rows[e.RowIndex].Cells[0].Value.ToString());
                doctorName = grdRecordPayment.Rows[e.RowIndex].Cells[1].Value.ToString();
                patientName = grdRecordPayment.Rows[e.RowIndex].Cells[2].Value.ToString();
                appointmentDateTime = (DateTime)grdRecordPayment.Rows[e.RowIndex].Cells[3].Value;

                MessageBox.Show($"Selected Appointment: Appointment ID {appointmentID}, Doctor '{doctorName}', Patient '{patientName}', Date/Time {appointmentDateTime.ToString("yyyy-MM-dd")}", "Appointment Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    

        private void grdRecordPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

