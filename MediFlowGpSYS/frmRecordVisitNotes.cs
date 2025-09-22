using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediFlowGpSYS
{
    public partial class frmRecordVisitNotes : Form
    {
        frmMainMenu parent;
        private DataTable appointmentDataTable;
        private int appointmentID;
        private string doctorName;
        private string patientName;
        private DateTime appointmentDateTime;
        public frmRecordVisitNotes()
        {
            InitializeComponent();
        }
        public frmRecordVisitNotes(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchAppointment();
        }

        private void btnRecordvistNotes_Click(object sender, EventArgs e)
        {
            {
                // Check if an appointment is selected
                if (appointmentID== 0)
                {
                    MessageBox.Show(" Please select The Appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to record the Appointment with apppId" + appointmentID+ "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
                    frmSetVisitNotes patientUpdateForm = new frmSetVisitNotes(appointmentID);
                    patientUpdateForm.ShowDialog();

                    // Refresh the appointment list after updating
                    LoadAppointments();
                }
            }
        }
        private void SearchByAppointmentID(int searchAppointmentID)
        {
            string filter = $"APPID = {searchAppointmentID}";
            appointmentDataTable.DefaultView.RowFilter = filter;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmRecordVisitNotes_Load(object sender, EventArgs e)
        {
            LoadAppointments();
           

        }

      

        
        private void LoadAppointments()
        {
            appointmentDataTable = Appointment.GetAppointments();
            grdRecordVisitNotes.DataSource = appointmentDataTable;
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
                    foreach (DataGridViewRow row in grdRecordVisitNotes.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == appointmentIDToSearch.ToString())
                        {
                            row.Selected = true;
                            grdRecordVisitNotes.CurrentCell = row.Cells[0];
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

        private void grdRecordVisitNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                if (e.RowIndex >= 0)
                {
                    appointmentID = int.Parse(grdRecordVisitNotes.Rows[e.RowIndex].Cells[0].Value.ToString());
                    doctorName = grdRecordVisitNotes.Rows[e.RowIndex].Cells[1].Value.ToString();
                    patientName = grdRecordVisitNotes.Rows[e.RowIndex].Cells[2].Value.ToString();
                    appointmentDateTime = (DateTime)grdRecordVisitNotes.Rows[e.RowIndex].Cells[3].Value;

                    MessageBox.Show($"Selected Appointment: Appointment ID {appointmentID}, Doctor '{doctorName}', Patient '{patientName}', Date/Time {appointmentDateTime.ToString("yyyy-MM-dd")}", "Appointment Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        
    }
    }
    

