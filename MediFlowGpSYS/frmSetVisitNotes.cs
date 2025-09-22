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
    public partial class frmSetVisitNotes : Form
    {

        private int appointmentID;
        public frmSetVisitNotes(int appointmentID)
        {
            InitializeComponent();
            this.appointmentID = appointmentID;
        }

        private void frmSetVisitNotes_Load(object sender, EventArgs e)
        {

        }
        public void setVisitnotes(int fee, string notes)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();

                string updateQuery = "UPDATE APPOINTMENT SET Fees = :fee, VISITNOTES = :notes WHERE APPID = :appointmentID";

                using (OracleCommand cmd = new OracleCommand(updateQuery, conn))
                {
                    cmd.Parameters.Add("fee", OracleDbType.Int32).Value = fee;
                    cmd.Parameters.Add("notes", OracleDbType.Varchar2).Value = notes;
                    cmd.Parameters.Add("appointmentID", OracleDbType.Int32).Value = this.appointmentID;

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Appointment details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update appointment details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmRecordVisitNotes frmUpdate = new frmRecordVisitNotes();
            frmUpdate.Show();
            this.Close();
        }

        private void btnSetnotes_Click(object sender, EventArgs e)
        {
            // Validate notes
            if (string.IsNullOrWhiteSpace(txtboxNotes.Text))
            {
                MessageBox.Show("Notes must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxNotes.Focus();
                return;
            }

            // Validate fee
            if (string.IsNullOrWhiteSpace(txtboxFee.Text))
            {
                MessageBox.Show("Fee must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxFee.Focus();
                return;
            }

            // Check if the fee contains at least one digit and a decimal point
            bool hasDigit = false;
            bool hasDecimalPoint = false;
            foreach (char c in txtboxFee.Text)
            {
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
                else if (c == '.')
                {
                    hasDecimalPoint = true;
                }
            }

            if (!hasDigit || !hasDecimalPoint)
            {
                MessageBox.Show("Fee must be a valid decimal value.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxFee.Focus();
                return;
            }

            // All validations passed, call the setVisitnotes method
            decimal fee = decimal.Parse(txtboxFee.Text);
            setVisitnotes((int)fee, txtboxNotes.Text);


            // Go back to frmrecordvisistnotes page
            frmRecordVisitNotes form = new frmRecordVisitNotes();
            form.Show();
            this.Close();
        }
    }
}