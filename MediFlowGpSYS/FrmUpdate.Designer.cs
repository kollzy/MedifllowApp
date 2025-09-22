
namespace MediFlowGpSYS
{
    partial class FrmUpdate
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
            this.backButton = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdatePatient = new System.Windows.Forms.Button();
            this.grdFrmUpdate = new System.Windows.Forms.DataGridView();
            this.mRNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDICALCARDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new MediFlowGpSYS.DataSet3();
            this.pATIENTSTableAdapter = new MediFlowGpSYS.DataSet3TableAdapters.PATIENTSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdFrmUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(0, 4);
            this.backButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(170, 42);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(44, 138);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(156, 37);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Text = "Enter Surname";
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(212, 137);
            this.txtboxSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(250, 31);
            this.txtboxSearch.TabIndex = 18;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(500, 123);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 56);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdatePatient.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePatient.Location = new System.Drawing.Point(478, 610);
            this.btnUpdatePatient.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(354, 77);
            this.btnUpdatePatient.TabIndex = 23;
            this.btnUpdatePatient.Text = " Update Patient Details";
            this.btnUpdatePatient.UseVisualStyleBackColor = false;
            this.btnUpdatePatient.Click += new System.EventHandler(this.btnUpdatePatient_Click);
            // 
            // grdFrmUpdate
            // 
            this.grdFrmUpdate.AutoGenerateColumns = false;
            this.grdFrmUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFrmUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mRNDataGridViewTextBoxColumn,
            this.fORENAMEDataGridViewTextBoxColumn,
            this.sURNAMEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn,
            this.mEDICALCARDDataGridViewTextBoxColumn});
            this.grdFrmUpdate.DataSource = this.pATIENTSBindingSource;
            this.grdFrmUpdate.Location = new System.Drawing.Point(114, 258);
            this.grdFrmUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grdFrmUpdate.Name = "grdFrmUpdate";
            this.grdFrmUpdate.RowHeadersWidth = 51;
            this.grdFrmUpdate.Size = new System.Drawing.Size(1498, 288);
            this.grdFrmUpdate.TabIndex = 24;
            this.grdFrmUpdate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            this.grdFrmUpdate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
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
            this.pATIENTSBindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pATIENTSTableAdapter
            // 
            this.pATIENTSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 804);
            this.Controls.Add(this.grdFrmUpdate);
            this.Controls.Add(this.btnUpdatePatient);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmUpdate";
            this.Text = "FrmUpdateMenu";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFrmUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdatePatient;
        private System.Windows.Forms.DataGridView grdFrmUpdate;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource pATIENTSBindingSource;
        private DataSet3TableAdapters.PATIENTSTableAdapter pATIENTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDICALCARDDataGridViewTextBoxColumn;
    }
}