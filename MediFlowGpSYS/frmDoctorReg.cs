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


namespace MediFlowGpSYS
{
    public partial class frmDoctorReg : Form
    {
        frmMainMenu parent;

        public frmDoctorReg()
        {
            InitializeComponent();
        }

        public frmDoctorReg(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void registerDoctorMenu_Load(object sender, EventArgs e)
        {
            txtboxForename.TabIndex = 0;
            txtboxSurname.TabIndex = 1;
            txtboxMDN.TabIndex = 2;
            txtboxEmail.TabIndex = 3;
            txtboxPhone.TabIndex = 4;
            btnRegDoctor.TabIndex = 5;
            btnBack.TabIndex = 6;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void RegisterDocButton_Click(object sender, EventArgs e)
        {
            // Validate input data
            if (!Utility.ValidationHelper.IsValidForename(txtboxForename.Text))
            {
                MessageBox.Show("Forename must be entered and must contain at least one alphabetic character!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxForename.Focus();
                return;
            }

            if (!Utility.ValidationHelper.IsValidSurname(txtboxSurname.Text))
            {
                MessageBox.Show("Surname must be entered and must contain at least one alphabetic character!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxSurname.Focus();
                return;
            }

            if (!Utility.ValidationHelper.IsValidMDN(txtboxMDN.Text))
            {
                MessageBox.Show("Medical Doctor Number must be a 3-digit positive number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxMDN.Focus();
                return;
            }

            if (!Utility.ValidationHelper.IsValidEmail(txtboxEmail.Text))
            {
                MessageBox.Show("Invalid email format", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxEmail.Focus();
                return;
            }

            if (!Utility.ValidationHelper.IsValidPhoneNumber(txtboxPhone.Text))
            {
                MessageBox.Show("Phone Number must be 10 or 12 digits!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxPhone.Focus();
                return;
            }
            // Display confirmation message


            // Create an instance of the Doctor class
            Doctor newDoctor = new Doctor();
            newDoctor.SetForename(txtboxForename.Text);
            newDoctor.SetSurname(txtboxSurname.Text); // Set the surname
            newDoctor.SetMDN(Convert.ToInt32(txtboxMDN.Text));
            newDoctor.SetEmail(txtboxEmail.Text);
            newDoctor.SetPhone(txtboxPhone.Text);

            // Invoke the static RegisterDoctor method with the required arguments
            Doctor.RegisterDoctor(Convert.ToInt32(txtboxMDN.Text),newDoctor.GetForename(), newDoctor.GetSurname(), newDoctor.GetEmail(), newDoctor.GetPhone());

            

            // Reset UI or perform any other necessary actions
            txtboxForename.Clear();
            txtboxSurname.Clear(); // Clear the surname textbox
            txtboxMDN.Clear();
            txtboxEmail.Clear();
            txtboxPhone.Clear();
            txtboxForename.Focus();
        }

        private void txtboxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxMDN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


