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
using static MediFlowGpSYS.Utility;

namespace MediFlowGpSYS
{
    public partial class frmPatientUpdate : Form
    {
        private int patientID; // Class-level variable to store the patientID

        public frmPatientUpdate(int patientID)
        {
            InitializeComponent();
            this.patientID = patientID; // Assign the constructor parameter to the class-level variable
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MRNLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            FrmUpdate frmUpdate = new FrmUpdate();
            frmUpdate.Show();
            this.Close();
        }
        public void UpdatePatient(string forename, string surname, string email, string address, string phoneNumber, bool medicalCard)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();

                string updateQuery = "UPDATE PATIENTS SET Forename = :forename, Surname = :surname, Email = :email, Address = :address, Phone = :phoneNumber, MedicalCard = :medicalCard WHERE MRN = :patientID";

                using (OracleCommand cmd = new OracleCommand(updateQuery, conn))
                {
                    cmd.Parameters.Add("forename", OracleDbType.Varchar2).Value = forename;
                    cmd.Parameters.Add("surname", OracleDbType.Varchar2).Value = surname;
                    cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
                    cmd.Parameters.Add("address", OracleDbType.Varchar2).Value = address;
                    cmd.Parameters.Add("phoneNumber", OracleDbType.Varchar2).Value = phoneNumber;
                    cmd.Parameters.Add("medicalCard", OracleDbType.Varchar2).Value = medicalCard ? "Yes" : "No";
                    cmd.Parameters.Add("patientID", OracleDbType.Int32).Value = this.patientID;

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Patient Data Updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update patient data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnPatientUpdate_Click(object sender, EventArgs e)
        {
            bool isAnyFieldUpdated = false; // Flag to track if any field is updated

            // Check if any field is updated
            if (!string.IsNullOrWhiteSpace(txtboxForename.Text) ||
                !string.IsNullOrWhiteSpace(txtboxSurname.Text) ||
                !string.IsNullOrWhiteSpace(txtboxEmail.Text) ||
                !string.IsNullOrWhiteSpace(txtboxPhone.Text) ||
                !string.IsNullOrWhiteSpace(txtboxAddress.Text) ||
                btnMedicalCardYes.Checked || btnMedicalCardNo.Checked)
            {
                isAnyFieldUpdated = true;
            }

            // Validate and update patient details
            if (isAnyFieldUpdated)
            {
                // Validate individual fields
                if (!ValidationHelper.IsValidForename(txtboxForename.Text))
                {
                    MessageBox.Show("Name must be entered and must be alphabets!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxForename.Focus();
                    return;
                }

                if (!ValidationHelper.IsValidSurname(txtboxSurname.Text))
                {
                    MessageBox.Show("Name must be entered and must be alphabets!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxSurname.Focus();
                    return;
                }

                if (!ValidationHelper.IsValidEmail(txtboxEmail.Text))
                {
                    MessageBox.Show("Invalid email format", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxEmail.Focus();
                    return;
                }

                if (!ValidationHelper.IsValidPhoneNumber(txtboxPhone.Text))
                {
                    MessageBox.Show("Phone Number must be 10 or 12 digits!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxPhone.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtboxAddress.Text))
                {
                    MessageBox.Show("Address must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxAddress.Focus();
                    return;
                }

                if (!btnMedicalCardYes.Checked && !btnMedicalCardNo.Checked)
                {
                    MessageBox.Show("Check the Medical Card Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update patient details
                string forename = txtboxForename.Text;
                string surname = txtboxSurname.Text;
                string email = txtboxEmail.Text;
                string phone = txtboxPhone.Text;
                string address = txtboxAddress.Text;
                bool hasMedicalCard = btnMedicalCardYes.Checked;

                // Parse phoneNumber from string to int
                int phoneNumber;
                if (!int.TryParse(txtboxPhone.Text, out phoneNumber))
                {
                    MessageBox.Show("Invalid Phone Number format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxPhone.Focus();
                    return;
                }

                // Call the UpdatePatient method with the updated input values
                UpdatePatient(forename, surname, email, address, phone, hasMedicalCard);
            }

            // Go back to FrmUpdate page
            FrmUpdate frmUpdate = new FrmUpdate();
            frmUpdate.Show();
            this.Close();
        }

        private void frmPatientUpdate_Load(object sender, EventArgs e)
        {

        }




        private void txtboxAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
