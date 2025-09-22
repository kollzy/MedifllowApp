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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void analysisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuRegDoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoctorReg nextForm = new frmDoctorReg(this);
            nextForm.Show();

        }

        private void listPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUpdate nextForm = new FrmUpdate();
            nextForm.Show();
        }

        private void removeDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoctorDereg nextForm = new frmDoctorDereg(this);
            nextForm.Show();
        }

        private void registerPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmPatientReg nextForm = new frmPatientReg(this);
            nextForm.Show();
        }

        private void deRegisterPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPatientDereg nextForm = new frmPatientDereg(this);
            nextForm.Show();
        }

        private void listPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPatientsList nextForm = new frmPatientsList(this);
            nextForm.Show();
        }

        private void mnuDoctors_Click(object sender, EventArgs e)
        {

        }

        private void makeAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMakeAppointment nextForm = new frmMakeAppointment(this);
            nextForm.Show();
        }

        private void cancelAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelAppointment nextForm = new frmCancelAppointment(this);
            nextForm.Show();
        }

        private void recordVisitNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRecordVisitNotes nextForm = new frmRecordVisitNotes(this);
            nextForm.Show();
        }

        private void recordArrivalDeparturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRecordArrivalDepartures nextForm = new frmRecordArrivalDepartures(this);
            nextForm.Show();
        }

        private void recordPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRecordPayment nextForm = new frmRecordPayment(this);
            nextForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyRevenue nextForm = new frmYearlyRevenue(this);
            nextForm.Show();
        }

        private void medicalCardAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMedicalCardAnalysis nextForm = new frmMedicalCardAnalysis(this);
            nextForm.Show();
        }
    }
}