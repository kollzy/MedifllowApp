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
    public partial class frmPatientsList : Form
    {

        frmMainMenu parent;
        private DataTable dataTable;

        public frmPatientsList()
        {
            InitializeComponent();
        }
        public frmPatientsList(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void LoadPatients()
        {
            dataTable = Utility.GetPatients();
            grdfrmPatientList.DataSource = dataTable;
        }
        private void btnPatientList_Click(object sender, EventArgs e)
        {
         LoadPatients();

            // Bind the patient data to the DataGridView
         

            // Make the DataGridView visible
            grdfrmPatientList.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmPatientsList_Load(object sender, EventArgs e)
        {
            grdfrmPatientList.Visible = false;
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
