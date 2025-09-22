
namespace MediFlowGpSYS
{
    partial class frmCancelAppointment
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
            this.lblAppid = new System.Windows.Forms.Label();
            this.txtboxAppid = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancelAppointment = new System.Windows.Forms.Button();
            this.grdCancelAppointment = new System.Windows.Forms.DataGridView();
            this.aPPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVALDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVALTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYMENTSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPOINTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet6 = new MediFlowGpSYS.DataSet6();
            this.aPPOINTMENTTableAdapter = new MediFlowGpSYS.DataSet6TableAdapters.APPOINTMENTTableAdapter();
            this.dataSet11 = new MediFlowGpSYS.DataSet11();
            this.aPPOINTMENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aPPOINTMENTTableAdapter1 = new MediFlowGpSYS.DataSet11TableAdapters.APPOINTMENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdCancelAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 22);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAppid
            // 
            this.lblAppid.AutoSize = true;
            this.lblAppid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppid.Location = new System.Drawing.Point(236, 82);
            this.lblAppid.Name = "lblAppid";
            this.lblAppid.Size = new System.Drawing.Size(92, 13);
            this.lblAppid.TabIndex = 19;
            this.lblAppid.Tag = "";
            this.lblAppid.Text = "Appointment Id";
            // 
            // txtboxAppid
            // 
            this.txtboxAppid.Location = new System.Drawing.Point(334, 80);
            this.txtboxAppid.Name = "txtboxAppid";
            this.txtboxAppid.Size = new System.Drawing.Size(100, 20);
            this.txtboxAppid.TabIndex = 20;
          
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(484, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 20);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancelAppointment
            // 
            this.btnCancelAppointment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelAppointment.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAppointment.Location = new System.Drawing.Point(382, 457);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(182, 28);
            this.btnCancelAppointment.TabIndex = 30;
            this.btnCancelAppointment.Text = "Cancel Appointment";
            this.btnCancelAppointment.UseVisualStyleBackColor = false;
            this.btnCancelAppointment.Click += new System.EventHandler(this.btnCancelAppointment_Click);
            // 
            // grdCancelAppointment
            // 
            this.grdCancelAppointment.AutoGenerateColumns = false;
            this.grdCancelAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCancelAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aPPIDDataGridViewTextBoxColumn,
            this.dOCTORNAMEDataGridViewTextBoxColumn,
            this.mRNDataGridViewTextBoxColumn,
            this.aRRIVALDATEDataGridViewTextBoxColumn,
            this.aRRIVALTIMEDataGridViewTextBoxColumn,
            this.fEESDataGridViewTextBoxColumn,
            this.aPPSTATUSDataGridViewTextBoxColumn,
            this.pAYMENTSTATUSDataGridViewTextBoxColumn});
            this.grdCancelAppointment.DataSource = this.aPPOINTMENTBindingSource1;
            this.grdCancelAppointment.Location = new System.Drawing.Point(76, 135);
            this.grdCancelAppointment.Name = "grdCancelAppointment";
            this.grdCancelAppointment.Size = new System.Drawing.Size(847, 221);
            this.grdCancelAppointment.TabIndex = 31;
            this.grdCancelAppointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // aPPIDDataGridViewTextBoxColumn
            // 
            this.aPPIDDataGridViewTextBoxColumn.DataPropertyName = "APPID";
            this.aPPIDDataGridViewTextBoxColumn.HeaderText = "APPID";
            this.aPPIDDataGridViewTextBoxColumn.Name = "aPPIDDataGridViewTextBoxColumn";
            // 
            // dOCTORNAMEDataGridViewTextBoxColumn
            // 
            this.dOCTORNAMEDataGridViewTextBoxColumn.DataPropertyName = "DOCTORNAME";
            this.dOCTORNAMEDataGridViewTextBoxColumn.HeaderText = "DOCTORNAME";
            this.dOCTORNAMEDataGridViewTextBoxColumn.Name = "dOCTORNAMEDataGridViewTextBoxColumn";
            // 
            // mRNDataGridViewTextBoxColumn
            // 
            this.mRNDataGridViewTextBoxColumn.DataPropertyName = "MRN";
            this.mRNDataGridViewTextBoxColumn.HeaderText = "MRN";
            this.mRNDataGridViewTextBoxColumn.Name = "mRNDataGridViewTextBoxColumn";
            // 
            // aRRIVALDATEDataGridViewTextBoxColumn
            // 
            this.aRRIVALDATEDataGridViewTextBoxColumn.DataPropertyName = "ARRIVALDATE";
            this.aRRIVALDATEDataGridViewTextBoxColumn.HeaderText = "ARRIVALDATE";
            this.aRRIVALDATEDataGridViewTextBoxColumn.Name = "aRRIVALDATEDataGridViewTextBoxColumn";
            // 
            // aRRIVALTIMEDataGridViewTextBoxColumn
            // 
            this.aRRIVALTIMEDataGridViewTextBoxColumn.DataPropertyName = "ARRIVALTIME";
            this.aRRIVALTIMEDataGridViewTextBoxColumn.HeaderText = "ARRIVALTIME";
            this.aRRIVALTIMEDataGridViewTextBoxColumn.Name = "aRRIVALTIMEDataGridViewTextBoxColumn";
            // 
            // fEESDataGridViewTextBoxColumn
            // 
            this.fEESDataGridViewTextBoxColumn.DataPropertyName = "FEES";
            this.fEESDataGridViewTextBoxColumn.HeaderText = "FEES";
            this.fEESDataGridViewTextBoxColumn.Name = "fEESDataGridViewTextBoxColumn";
            // 
            // aPPSTATUSDataGridViewTextBoxColumn
            // 
            this.aPPSTATUSDataGridViewTextBoxColumn.DataPropertyName = "APPSTATUS";
            this.aPPSTATUSDataGridViewTextBoxColumn.HeaderText = "APPSTATUS";
            this.aPPSTATUSDataGridViewTextBoxColumn.Name = "aPPSTATUSDataGridViewTextBoxColumn";
            // 
            // pAYMENTSTATUSDataGridViewTextBoxColumn
            // 
            this.pAYMENTSTATUSDataGridViewTextBoxColumn.DataPropertyName = "PAYMENTSTATUS";
            this.pAYMENTSTATUSDataGridViewTextBoxColumn.HeaderText = "PAYMENTSTATUS";
            this.pAYMENTSTATUSDataGridViewTextBoxColumn.Name = "pAYMENTSTATUSDataGridViewTextBoxColumn";
            // 
            // aPPOINTMENTBindingSource
            // 
            this.aPPOINTMENTBindingSource.DataMember = "APPOINTMENT";
            this.aPPOINTMENTBindingSource.DataSource = this.dataSet6;
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "DataSet6";
            this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPPOINTMENTTableAdapter
            // 
            this.aPPOINTMENTTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet11";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPPOINTMENTBindingSource1
            // 
            this.aPPOINTMENTBindingSource1.DataMember = "APPOINTMENT";
            this.aPPOINTMENTBindingSource1.DataSource = this.dataSet11;
            // 
            // aPPOINTMENTTableAdapter1
            // 
            this.aPPOINTMENTTableAdapter1.ClearBeforeFill = true;
            // 
            // frmCancelAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 531);
            this.Controls.Add(this.grdCancelAppointment);
            this.Controls.Add(this.btnCancelAppointment);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtboxAppid);
            this.Controls.Add(this.lblAppid);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCancelAppointment";
            this.Text = "frmCancelAppointment";
            this.Load += new System.EventHandler(this.frmCancelAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCancelAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAppid;
        private System.Windows.Forms.TextBox txtboxAppid;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancelAppointment;
        private System.Windows.Forms.DataGridView grdCancelAppointment;
        private DataSet6 dataSet6;
        private System.Windows.Forms.BindingSource aPPOINTMENTBindingSource;
        private DataSet6TableAdapters.APPOINTMENTTableAdapter aPPOINTMENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVALDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVALTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAYMENTSTATUSDataGridViewTextBoxColumn;
        private DataSet11 dataSet11;
        private System.Windows.Forms.BindingSource aPPOINTMENTBindingSource1;
        private DataSet11TableAdapters.APPOINTMENTTableAdapter aPPOINTMENTTableAdapter1;
    }
}