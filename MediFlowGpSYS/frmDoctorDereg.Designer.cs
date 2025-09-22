
namespace MediFlowGpSYS
{
    partial class frmDoctorDereg
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
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.btnDoctordereg = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dOCTORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MediFlowGpSYS.DataSet1();
            this.dOCTORSTableAdapter = new MediFlowGpSYS.DataSet1TableAdapters.DOCTORSTableAdapter();
            this.grdDoctordereg = new System.Windows.Forms.DataGridView();
            this.mDNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDoctordereg)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(4, 2);
            this.backButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(170, 42);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(208, 117);
            this.txtboxSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(250, 31);
            this.txtboxSearch.TabIndex = 13;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.searchTxtbox_TextChanged);
            // 
            // btnDoctordereg
            // 
            this.btnDoctordereg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDoctordereg.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctordereg.Location = new System.Drawing.Point(574, 664);
            this.btnDoctordereg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDoctordereg.Name = "btnDoctordereg";
            this.btnDoctordereg.Size = new System.Drawing.Size(354, 77);
            this.btnDoctordereg.TabIndex = 15;
            this.btnDoctordereg.Text = "De-Register Doctor";
            this.btnDoctordereg.UseVisualStyleBackColor = false;
            this.btnDoctordereg.Click += new System.EventHandler(this.DeRegisterDocButton_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.Location = new System.Drawing.Point(40, 123);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(156, 36);
            this.lblSurname.TabIndex = 16;
            this.lblSurname.Text = "Enter Surname";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(516, 108);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 56);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dOCTORSBindingSource
            // 
            this.dOCTORSBindingSource.DataMember = "DOCTORS";
            this.dOCTORSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOCTORSTableAdapter
            // 
            this.dOCTORSTableAdapter.ClearBeforeFill = true;
            // 
            // grdDoctordereg
            // 
            this.grdDoctordereg.AutoGenerateColumns = false;
            this.grdDoctordereg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDoctordereg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mDNDataGridViewTextBoxColumn,
            this.fORENAMEDataGridViewTextBoxColumn,
            this.sURNAMEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn});
            this.grdDoctordereg.DataSource = this.dOCTORSBindingSource;
            this.grdDoctordereg.Location = new System.Drawing.Point(370, 264);
            this.grdDoctordereg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grdDoctordereg.Name = "grdDoctordereg";
            this.grdDoctordereg.RowHeadersWidth = 51;
            this.grdDoctordereg.Size = new System.Drawing.Size(806, 289);
            this.grdDoctordereg.TabIndex = 19;
            this.grdDoctordereg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            
            // 
            // mDNDataGridViewTextBoxColumn
            // 
            this.mDNDataGridViewTextBoxColumn.DataPropertyName = "MDN";
            this.mDNDataGridViewTextBoxColumn.HeaderText = "MDN";
            this.mDNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mDNDataGridViewTextBoxColumn.Name = "mDNDataGridViewTextBoxColumn";
            this.mDNDataGridViewTextBoxColumn.Width = 125;
            // 
            // fORENAMEDataGridViewTextBoxColumn
            // 
            this.fORENAMEDataGridViewTextBoxColumn.DataPropertyName = "FORENAME";
            this.fORENAMEDataGridViewTextBoxColumn.HeaderText = "FORENAME";
            this.fORENAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fORENAMEDataGridViewTextBoxColumn.Name = "fORENAMEDataGridViewTextBoxColumn";
            this.fORENAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // sURNAMEDataGridViewTextBoxColumn
            // 
            this.sURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sURNAMEDataGridViewTextBoxColumn.Name = "sURNAMEDataGridViewTextBoxColumn";
            this.sURNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.Width = 125;
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.HeaderText = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            this.pHONEDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmDoctorDereg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 866);
            this.Controls.Add(this.grdDoctordereg);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.btnDoctordereg);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmDoctorDereg";
            this.Text = "deregisterDoctorMenu";
            this.Load += new System.EventHandler(this.frmDoctorDereg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDoctordereg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Button btnDoctordereg;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnSearch;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dOCTORSBindingSource;
        private DataSet1TableAdapters.DOCTORSTableAdapter dOCTORSTableAdapter;
		private System.Windows.Forms.DataGridView grdDoctordereg;
		private System.Windows.Forms.DataGridViewTextBoxColumn mDNDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fORENAMEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sURNAMEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
	}
}