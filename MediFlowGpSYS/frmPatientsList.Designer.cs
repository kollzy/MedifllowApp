
namespace MediFlowGpSYS
{
    partial class frmPatientsList
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPatientList = new System.Windows.Forms.Button();
            this.grdfrmPatientList = new System.Windows.Forms.DataGridView();
            this.mRNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDICALCARDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new MediFlowGpSYS.DataSet4();
            this.pATIENTSTableAdapter = new MediFlowGpSYS.DataSet4TableAdapters.PATIENTSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdfrmPatientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(4, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(170, 42);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPatientList
            // 
            this.btnPatientList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPatientList.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientList.Location = new System.Drawing.Point(704, 613);
            this.btnPatientList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPatientList.Name = "btnPatientList";
            this.btnPatientList.Size = new System.Drawing.Size(236, 60);
            this.btnPatientList.TabIndex = 21;
            this.btnPatientList.Text = "List all Patients";
            this.btnPatientList.UseVisualStyleBackColor = false;
            this.btnPatientList.Click += new System.EventHandler(this.btnPatientList_Click);
            // 
            // grdfrmPatientList
            // 
            this.grdfrmPatientList.AutoGenerateColumns = false;
            this.grdfrmPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdfrmPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mRNDataGridViewTextBoxColumn,
            this.fORENAMEDataGridViewTextBoxColumn,
            this.sURNAMEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn,
            this.mEDICALCARDDataGridViewTextBoxColumn});
            this.grdfrmPatientList.DataSource = this.pATIENTSBindingSource;
            this.grdfrmPatientList.Location = new System.Drawing.Point(104, 192);
            this.grdfrmPatientList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grdfrmPatientList.Name = "grdfrmPatientList";
            this.grdfrmPatientList.RowHeadersWidth = 51;
            this.grdfrmPatientList.Size = new System.Drawing.Size(1498, 288);
            this.grdfrmPatientList.TabIndex = 25;
            this.grdfrmPatientList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
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
            this.pATIENTSBindingSource.DataSource = this.dataSet4;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pATIENTSTableAdapter
            // 
            this.pATIENTSTableAdapter.ClearBeforeFill = true;
            // 
            // frmPatientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 840);
            this.Controls.Add(this.grdfrmPatientList);
            this.Controls.Add(this.btnPatientList);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPatientsList";
            this.Text = "frmPatientsList";
            this.Load += new System.EventHandler(this.frmPatientsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdfrmPatientList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPatientList;
        private System.Windows.Forms.DataGridView grdfrmPatientList;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource pATIENTSBindingSource;
        private DataSet4TableAdapters.PATIENTSTableAdapter pATIENTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDICALCARDDataGridViewTextBoxColumn;
    }
}