
namespace MediFlowGpSYS
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.frmMainMenu1 = new System.Windows.Forms.MenuStrip();
            this.mnuDoctors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deRegisterPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordVisitNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordArrivalDeparturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalCardAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MediFlowGPSYSImg = new System.Windows.Forms.PictureBox();
            this.frmMainMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediFlowGPSYSImg)).BeginInit();
            this.SuspendLayout();
            // 
            // frmMainMenu1
            // 
            this.frmMainMenu1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.frmMainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoctors,
            this.patientsToolStripMenuItem,
            this.appointmentsToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.frmMainMenu1.Location = new System.Drawing.Point(0, 0);
            this.frmMainMenu1.Name = "frmMainMenu1";
            this.frmMainMenu1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.frmMainMenu1.Size = new System.Drawing.Size(748, 24);
            this.frmMainMenu1.TabIndex = 0;
            this.frmMainMenu1.TabStop = true;
            this.frmMainMenu1.Text = "FrmMainMenu";
            // 
            // mnuDoctors
            // 
            this.mnuDoctors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegDoc,
            this.removeDoctorToolStripMenuItem});
            this.mnuDoctors.Name = "mnuDoctors";
            this.mnuDoctors.Size = new System.Drawing.Size(60, 22);
            this.mnuDoctors.Text = "Doctors";
            this.mnuDoctors.Click += new System.EventHandler(this.mnuDoctors_Click);
            // 
            // mnuRegDoc
            // 
            this.mnuRegDoc.Name = "mnuRegDoc";
            this.mnuRegDoc.Size = new System.Drawing.Size(174, 22);
            this.mnuRegDoc.Text = "Register Doctor";
            this.mnuRegDoc.Click += new System.EventHandler(this.mnuRegDoc_Click);
            // 
            // removeDoctorToolStripMenuItem
            // 
            this.removeDoctorToolStripMenuItem.Name = "removeDoctorToolStripMenuItem";
            this.removeDoctorToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.removeDoctorToolStripMenuItem.Text = "De-Register Doctor";
            this.removeDoctorToolStripMenuItem.Click += new System.EventHandler(this.removeDoctorToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerPatientToolStripMenuItem,
            this.deRegisterPatientToolStripMenuItem,
            this.listPatientsToolStripMenuItem,
            this.listPatientToolStripMenuItem});
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.patientsToolStripMenuItem.Text = "Patients";
            this.patientsToolStripMenuItem.Click += new System.EventHandler(this.patientsToolStripMenuItem_Click);
            // 
            // registerPatientToolStripMenuItem
            // 
            this.registerPatientToolStripMenuItem.Name = "registerPatientToolStripMenuItem";
            this.registerPatientToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.registerPatientToolStripMenuItem.Text = "Register Patient";
            this.registerPatientToolStripMenuItem.Click += new System.EventHandler(this.registerPatientToolStripMenuItem_Click);
            // 
            // deRegisterPatientToolStripMenuItem
            // 
            this.deRegisterPatientToolStripMenuItem.Name = "deRegisterPatientToolStripMenuItem";
            this.deRegisterPatientToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.deRegisterPatientToolStripMenuItem.Text = "De-Register Patient";
            this.deRegisterPatientToolStripMenuItem.Click += new System.EventHandler(this.deRegisterPatientToolStripMenuItem_Click);
            // 
            // listPatientsToolStripMenuItem
            // 
            this.listPatientsToolStripMenuItem.Name = "listPatientsToolStripMenuItem";
            this.listPatientsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.listPatientsToolStripMenuItem.Text = "Update Patient";
            this.listPatientsToolStripMenuItem.Click += new System.EventHandler(this.listPatientsToolStripMenuItem_Click);
            // 
            // listPatientToolStripMenuItem
            // 
            this.listPatientToolStripMenuItem.Name = "listPatientToolStripMenuItem";
            this.listPatientToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.listPatientToolStripMenuItem.Text = "List Patient";
            this.listPatientToolStripMenuItem.Click += new System.EventHandler(this.listPatientToolStripMenuItem_Click);
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeAppointmentToolStripMenuItem,
            this.cancelAppointmentToolStripMenuItem,
            this.recordVisitNotesToolStripMenuItem,
            this.recordArrivalDeparturesToolStripMenuItem,
            this.recordPaymentToolStripMenuItem});
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            this.appointmentsToolStripMenuItem.Click += new System.EventHandler(this.appointmentsToolStripMenuItem_Click);
            // 
            // makeAppointmentToolStripMenuItem
            // 
            this.makeAppointmentToolStripMenuItem.Name = "makeAppointmentToolStripMenuItem";
            this.makeAppointmentToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.makeAppointmentToolStripMenuItem.Text = "Make Appointment";
            this.makeAppointmentToolStripMenuItem.Click += new System.EventHandler(this.makeAppointmentToolStripMenuItem_Click);
            // 
            // cancelAppointmentToolStripMenuItem
            // 
            this.cancelAppointmentToolStripMenuItem.Name = "cancelAppointmentToolStripMenuItem";
            this.cancelAppointmentToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.cancelAppointmentToolStripMenuItem.Text = "Cancel Appointment";
            this.cancelAppointmentToolStripMenuItem.Click += new System.EventHandler(this.cancelAppointmentToolStripMenuItem_Click);
            // 
            // recordVisitNotesToolStripMenuItem
            // 
            this.recordVisitNotesToolStripMenuItem.Name = "recordVisitNotesToolStripMenuItem";
            this.recordVisitNotesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.recordVisitNotesToolStripMenuItem.Text = "Record Visit Notes";
            this.recordVisitNotesToolStripMenuItem.Click += new System.EventHandler(this.recordVisitNotesToolStripMenuItem_Click);
            // 
            // recordArrivalDeparturesToolStripMenuItem
            // 
            this.recordArrivalDeparturesToolStripMenuItem.Name = "recordArrivalDeparturesToolStripMenuItem";
            this.recordArrivalDeparturesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.recordArrivalDeparturesToolStripMenuItem.Text = "Record Arrival/Departures";
            this.recordArrivalDeparturesToolStripMenuItem.Click += new System.EventHandler(this.recordArrivalDeparturesToolStripMenuItem_Click);
            // 
            // recordPaymentToolStripMenuItem
            // 
            this.recordPaymentToolStripMenuItem.Name = "recordPaymentToolStripMenuItem";
            this.recordPaymentToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.recordPaymentToolStripMenuItem.Text = "Record Payment";
            this.recordPaymentToolStripMenuItem.Click += new System.EventHandler(this.recordPaymentToolStripMenuItem_Click);
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyRevenueAnalysisToolStripMenuItem,
            this.medicalCardAnalysisToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.analysisToolStripMenuItem.Text = "Analysis";
            this.analysisToolStripMenuItem.Click += new System.EventHandler(this.analysisToolStripMenuItem_Click);
            // 
            // yearlyRevenueAnalysisToolStripMenuItem
            // 
            this.yearlyRevenueAnalysisToolStripMenuItem.Name = "yearlyRevenueAnalysisToolStripMenuItem";
            this.yearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.yearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly Revenue Analysis";
            this.yearlyRevenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.yearlyRevenueAnalysisToolStripMenuItem_Click);
            // 
            // medicalCardAnalysisToolStripMenuItem
            // 
            this.medicalCardAnalysisToolStripMenuItem.Name = "medicalCardAnalysisToolStripMenuItem";
            this.medicalCardAnalysisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.medicalCardAnalysisToolStripMenuItem.Text = "Medical Card Analysis";
            this.medicalCardAnalysisToolStripMenuItem.Click += new System.EventHandler(this.medicalCardAnalysisToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MediFlowGPSYSImg
            // 
            this.MediFlowGPSYSImg.Image = ((System.Drawing.Image)(resources.GetObject("MediFlowGPSYSImg.Image")));
            this.MediFlowGPSYSImg.Location = new System.Drawing.Point(6, 30);
            this.MediFlowGPSYSImg.Margin = new System.Windows.Forms.Padding(2);
            this.MediFlowGPSYSImg.Name = "MediFlowGPSYSImg";
            this.MediFlowGPSYSImg.Size = new System.Drawing.Size(736, 335);
            this.MediFlowGPSYSImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MediFlowGPSYSImg.TabIndex = 1;
            this.MediFlowGPSYSImg.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 371);
            this.Controls.Add(this.MediFlowGPSYSImg);
            this.Controls.Add(this.frmMainMenu1);
            this.MainMenuStrip = this.frmMainMenu1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainMenu";
            this.Text = "MediFlowGPSYS";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.frmMainMenu1.ResumeLayout(false);
            this.frmMainMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediFlowGPSYSImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip frmMainMenu1;
        private System.Windows.Forms.ToolStripMenuItem mnuDoctors;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox MediFlowGPSYSImg;
        private System.Windows.Forms.ToolStripMenuItem mnuRegDoc;
        private System.Windows.Forms.ToolStripMenuItem removeDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deRegisterPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordVisitNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordArrivalDeparturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicalCardAnalysisToolStripMenuItem;
    }
}

