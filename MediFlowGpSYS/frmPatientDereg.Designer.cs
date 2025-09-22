
namespace MediFlowGpSYS
{
    partial class frmPatientDereg
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeRegPatient = new System.Windows.Forms.Button();
            this.grdfrmPatientDereg = new System.Windows.Forms.DataGridView();
            this.mRNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDICALCARDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new MediFlowGpSYS.DataSet2();
            this.pATIENTSTableAdapter = new MediFlowGpSYS.DataSet2TableAdapters.PATIENTSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdfrmPatientDereg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Tag = "";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(4, 6);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(170, 42);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.Location = new System.Drawing.Point(72, 158);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(156, 37);
            this.lblSurname.TabIndex = 17;
            this.lblSurname.Text = "Enter Surname";
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(248, 156);
            this.txtboxSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(250, 31);
            this.txtboxSearch.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(576, 142);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 56);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeRegPatient
            // 
            this.btnDeRegPatient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeRegPatient.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeRegPatient.Location = new System.Drawing.Point(518, 681);
            this.btnDeRegPatient.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeRegPatient.Name = "btnDeRegPatient";
            this.btnDeRegPatient.Size = new System.Drawing.Size(354, 77);
            this.btnDeRegPatient.TabIndex = 20;
            this.btnDeRegPatient.Text = "De-Register Patient";
            this.btnDeRegPatient.UseVisualStyleBackColor = false;
            this.btnDeRegPatient.Click += new System.EventHandler(this.btnDeRegPatient_Click_1);
            // 
            // grdfrmPatientDereg
            // 
            this.grdfrmPatientDereg.AutoGenerateColumns = false;
            this.grdfrmPatientDereg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdfrmPatientDereg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mRNDataGridViewTextBoxColumn,
            this.fORENAMEDataGridViewTextBoxColumn,
            this.sURNAMEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn,
            this.mEDICALCARDDataGridViewTextBoxColumn});
            this.grdfrmPatientDereg.DataSource = this.pATIENTSBindingSource;
            this.grdfrmPatientDereg.Location = new System.Drawing.Point(78, 283);
            this.grdfrmPatientDereg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grdfrmPatientDereg.Name = "grdfrmPatientDereg";
            this.grdfrmPatientDereg.RowHeadersWidth = 51;
            this.grdfrmPatientDereg.Size = new System.Drawing.Size(1498, 288);
            this.grdfrmPatientDereg.TabIndex = 21;
            this.grdfrmPatientDereg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.grdfrmPatientDereg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // mRNDataGridViewTextBoxColumn
            // 
            this.mRNDataGridViewTextBoxColumn.DataPropertyName = "MRN";
            this.mRNDataGridViewTextBoxColumn.HeaderText = "MRN";
            this.mRNDataGridViewTextBoxColumn.Name = "mRNDataGridViewTextBoxColumn";
            // 
            // fORENAMEDataGridViewTextBoxColumn
            // 
            this.fORENAMEDataGridViewTextBoxColumn.DataPropertyName = "FORENAME";
            this.fORENAMEDataGridViewTextBoxColumn.HeaderText = "FORENAME";
            this.fORENAMEDataGridViewTextBoxColumn.Name = "fORENAMEDataGridViewTextBoxColumn";
            // 
            // sURNAMEDataGridViewTextBoxColumn
            // 
            this.sURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.Name = "sURNAMEDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.HeaderText = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            // 
            // mEDICALCARDDataGridViewTextBoxColumn
            // 
            this.mEDICALCARDDataGridViewTextBoxColumn.DataPropertyName = "MEDICALCARD";
            this.mEDICALCARDDataGridViewTextBoxColumn.HeaderText = "MEDICALCARD";
            this.mEDICALCARDDataGridViewTextBoxColumn.Name = "mEDICALCARDDataGridViewTextBoxColumn";
            // 
            // pATIENTSBindingSource
            // 
            this.pATIENTSBindingSource.DataMember = "PATIENTS";
            this.pATIENTSBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pATIENTSTableAdapter
            // 
            this.pATIENTSTableAdapter.ClearBeforeFill = true;
            // 
            // frmPatientDereg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 865);
            this.Controls.Add(this.grdfrmPatientDereg);
            this.Controls.Add(this.btnDeRegPatient);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmPatientDereg";
            this.Text = "deregisterPatientMenu";
            this.Load += new System.EventHandler(this.frmPatientDereg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdfrmPatientDereg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeRegPatient;
        private System.Windows.Forms.DataGridView grdfrmPatientDereg;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource pATIENTSBindingSource;
        private DataSet2TableAdapters.PATIENTSTableAdapter pATIENTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDICALCARDDataGridViewTextBoxColumn;
    }
}