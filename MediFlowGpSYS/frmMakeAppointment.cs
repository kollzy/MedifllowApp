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
    public partial class frmMakeAppointment : Form
    {
        frmMainMenu parent;
        String selectedDoctorName;
        String selectedTime;

        public frmMakeAppointment()
        {
            InitializeComponent();
        }

        public frmMakeAppointment(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label1_Click_1(object sender, EventArgs e) { }

        private void label1_Click_2(object sender, EventArgs e) { }

        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Update available times in DataGridView when date changes
            UpdateDataGridViewWithAvailableTimes(datetimepickerArrDate.Value);
        }

        private void MRNLabel_Click(object sender, EventArgs e) { }

        private void frmMakeAppointment_Load(object sender, EventArgs e)
        {
            datetimepickerArrDate.MinDate = DateTime.Today;
            datetimepickerArrDate.Value = DateTime.Today;
            UpdateDataGridViewWithAvailableTimes(datetimepickerArrDate.Value);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnMakeAppointment_Click(object sender, EventArgs e)
        {
            // Use Utility.ValidationHelper to validate MRN
            if (!Utility.ValidationHelper.IsValidMDN(txtboxMRN.Text.Trim()))
            {
                Utility.ShowError("Medical Record Number must be 3 digits!");
                txtboxMRN.Focus();
                return;
            }

            // Validate doctor and time selection
            if (string.IsNullOrEmpty(selectedDoctorName) || string.IsNullOrEmpty(selectedTime))
            {
                Utility.ShowError("Please select a doctor and time from the available options!");
                return;
            }

            // Schedule the appointment
            Appointment.ScheduleAppointment(datetimepickerArrDate.Value, int.Parse(txtboxMRN.Text), selectedDoctorName, selectedTime);

            // Notify success
            Utility.ShowSuccess("Appointment Booked");

            // Update the DataGridView to remove the selected time for the selected doctor
            UpdateDataGridViewWithAvailableTimes(datetimepickerArrDate.Value);
        }



        public void UpdateDataGridViewWithAvailableTimes(DateTime appointmentDate)
        {
            Dictionary<string, List<string>> availableTimesForDoctors = Appointment.GetAvailableTimesForDoctors(appointmentDate);
            grdAvailableTimes.Rows.Clear();

            foreach (var doctor in availableTimesForDoctors.Keys)
            {
                foreach (var availableTime in availableTimesForDoctors[doctor])
                {
                    grdAvailableTimes.Rows.Add(doctor, availableTime);
                }
            }
        }

        private void btnGetAvailableTime_Click(object sender, EventArgs e)
        {
            UpdateDataGridViewWithAvailableTimes(datetimepickerArrDate.Value);
        }

        private void namespat()
        {
            string initialLetters = txtboxMRN.Text;
            Patient patient = new Patient();
            string patientFullName = patient.GetPATIENTSFullNameFromMDN(initialLetters);
            labelnamepat.Text = patientFullName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            namespat();
        }

        private void labelnamedoctor_TextChanged(object sender, EventArgs e) { }

        private void txtboxMDN_Click(object sender, EventArgs e) { }

        private void txtboxMRN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                namespat();
                string initialLetters = txtboxMRN.Text;
                List<string> matchingDoctors = Patient.SearchPationByMRN(initialLetters);
                txtboxMRN.AutoCompleteCustomSource.Clear();
                txtboxMRN.AutoCompleteCustomSource.AddRange(matchingDoctors.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = grdAvailableTimes.Rows[e.RowIndex];
                selectedDoctorName = selectedRow.Cells["Doctor_Name"].Value.ToString();
                selectedTime = selectedRow.Cells["Available_Times"].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateDataGridViewWithAvailableTimes(datetimepickerArrDate.Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void lblAvailableTime_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }
    }
}



