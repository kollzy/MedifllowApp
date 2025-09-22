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
    public partial class frmPatientReg : Form
    {

        frmMainMenu parent;
        public frmPatientReg()
        {
            InitializeComponent();
        }
        public frmPatientReg(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void Nametxtbox_TextChanged(object sender, EventArgs e)
        {

        }



        private void registerPatientMenu_Load(object sender, EventArgs e)
        {
            txtboxForename.TabIndex = 0;
            txtboxSurname.TabIndex = 1;
            txtboxMRN.TabIndex = 2;
            txtboxEmail.TabIndex = 3;
            txtboxPhone.TabIndex = 4;
            btnMedicalCardYes.TabIndex = 5; btnMedicalCardNo.TabIndex = 6;
            txtboxAddress.TabIndex = 7;
            btnPatientReg.TabIndex = 8;
            btnBack.TabIndex = 9;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void AddressTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterDocButton_Click(object sender, EventArgs e)
        {
            // Validate forename
            if (!Utility.ValidationHelper.IsValidForename(txtboxForename.Text))
            {
                MessageBox.Show("Name must be entered and must contain only alphabets!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxForename.Focus();
                return;
            }

            // Validate surname
            if (!Utility.ValidationHelper.IsValidSurname(txtboxSurname.Text))
            {
                MessageBox.Show("Surname must be entered and must contain only alphabets!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxSurname.Focus();
                return;
            }

            // Validate Medical Record Number (MRN)
            if (!Utility.ValidationHelper.IsValidMDN(txtboxMRN.Text))
            {
                MessageBox.Show("Medical Record Number must be 3 digits!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxMRN.Focus();
                return;
            }

            // Validate email
            if (!Utility.ValidationHelper.IsValidEmail(txtboxEmail.Text))
            {
                MessageBox.Show("Invalid email format", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxEmail.Focus();
                return;
            }

            // Validate phone number
            if (!Utility.ValidationHelper.IsValidPhoneNumber(txtboxPhone.Text))
            {
                MessageBox.Show("Phone Number must be 10 or 12 digits!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxPhone.Focus();
                return;
            }

            // Validate address
            if (string.IsNullOrWhiteSpace(txtboxAddress.Text))
            {
                MessageBox.Show("Address must be entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxAddress.Focus();
                return;
            }

            // Validate medical card option
            if (!btnMedicalCardYes.Checked && !btnMedicalCardNo.Checked)
            {
                MessageBox.Show("Please select a Medical Card option!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Patient newPatient = new Patient();

            // Set patient properties using the provided textboxes
            newPatient.SetForename(txtboxForename.Text);
            newPatient.SetSurname(txtboxSurname.Text);
            newPatient.SetMRN(Convert.ToInt32(txtboxMRN.Text));
            newPatient.SetEmail(txtboxEmail.Text);
            newPatient.SetAddress(txtboxAddress.Text);
            newPatient.SetPhoneNumber(txtboxPhone.Text);
            bool medicalCard = btnMedicalCardYes.Checked;

            // Call the RegisterPatient method on the newPatient instance
            newPatient.RegisterPatient(
                Convert.ToInt32(txtboxMRN.Text),
                newPatient.GetForename(),
                newPatient.GetSurname(),
                newPatient.GetEmail(),
                newPatient.GetAddress(),
                newPatient.GetPhoneNumber(),
                medicalCard);

            // Reset UI or perform any other necessary actions
            txtboxForename.Clear();
            txtboxSurname.Clear();
            txtboxMRN.Clear();
            txtboxEmail.Clear();
            txtboxPhone.Clear();
            txtboxAddress.Clear();
            txtboxForename.Focus();
        }

        private void txtboxSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxMDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



