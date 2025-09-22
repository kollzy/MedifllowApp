
namespace MediFlowGpSYS
{
    partial class frmRecordPayment
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
            this.lblAppId = new System.Windows.Forms.Label();
            this.txtboxAppId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSetPaymentStatus = new System.Windows.Forms.Button();
            this.grdRecordPayment = new System.Windows.Forms.DataGridView();
            this.aPPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVALDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVALTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYMENTSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPOINTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet8 = new MediFlowGpSYS.DataSet8();
            this.aPPOINTMENTTableAdapter = new MediFlowGpSYS.DataSet8TableAdapters.APPOINTMENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecordPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, -2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(170, 42);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAppId
            // 
            this.lblAppId.AutoSize = true;
            this.lblAppId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppId.Location = new System.Drawing.Point(16, 167);
            this.lblAppId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAppId.Name = "lblAppId";
            this.lblAppId.Size = new System.Drawing.Size(73, 13);
            this.lblAppId.TabIndex = 22;
            this.lblAppId.Tag = "";
            this.lblAppId.Text = "Enter Appid";
            // 
            // txtboxAppId
            // 
            this.txtboxAppId.Location = new System.Drawing.Point(184, 165);
            this.txtboxAppId.Margin = new System.Windows.Forms.Padding(6);
            this.txtboxAppId.Name = "txtboxAppId";
            this.txtboxAppId.Size = new System.Drawing.Size(196, 31);
            this.txtboxAppId.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(454, 158);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 38);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSetPaymentStatus
            // 
            this.btnSetPaymentStatus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSetPaymentStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPaymentStatus.Location = new System.Drawing.Point(568, 644);
            this.btnSetPaymentStatus.Margin = new System.Windows.Forms.Padding(6);
            this.btnSetPaymentStatus.Name = "btnSetPaymentStatus";
            this.btnSetPaymentStatus.Size = new System.Drawing.Size(574, 58);
            this.btnSetPaymentStatus.TabIndex = 32;
            this.btnSetPaymentStatus.Text = "Set Payment Status";
            this.btnSetPaymentStatus.UseVisualStyleBackColor = false;
            this.btnSetPaymentStatus.Click += new System.EventHandler(this.btnSetPaymentStatus_Click);
            // 
            // grdRecordPayment
            // 
            this.grdRecordPayment.AutoGenerateColumns = false;
            this.grdRecordPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRecordPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aPPIDDataGridViewTextBoxColumn,
            this.dOCTORNAMEDataGridViewTextBoxColumn,
            this.mRNDataGridViewTextBoxColumn,
            this.aRRIVALDATEDataGridViewTextBoxColumn,
            this.aRRIVALTIMEDataGridViewTextBoxColumn,
            this.fEESDataGridViewTextBoxColumn,
            this.aPPSTATUSDataGridViewTextBoxColumn,
            this.pAYMENTSTATUSDataGridViewTextBoxColumn});
            this.grdRecordPayment.DataSource = this.aPPOINTMENTBindingSource;
            this.grdRecordPayment.Location = new System.Drawing.Point(296, 256);
            this.grdRecordPayment.Margin = new System.Windows.Forms.Padding(6);
            this.grdRecordPayment.Name = "grdRecordPayment";
            this.grdRecordPayment.Size = new System.Drawing.Size(1102, 325);
            this.grdRecordPayment.TabIndex = 33;
            this.grdRecordPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.grdRecordPayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRecordPayment_CellContentClick);
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
            this.aPPOINTMENTBindingSource.DataSource = this.dataSet8;
            // 
            // dataSet8
            // 
            this.dataSet8.DataSetName = "DataSet8";
            this.dataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPPOINTMENTTableAdapter
            // 
            this.aPPOINTMENTTableAdapter.ClearBeforeFill = true;
            // 
            // frmRecordPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 941);
            this.Controls.Add(this.grdRecordPayment);
            this.Controls.Add(this.btnSetPaymentStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtboxAppId);
            this.Controls.Add(this.lblAppId);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecordPayment";
            this.Text = "frmRecordPayment";
            this.Load += new System.EventHandler(this.frmRecordPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRecordPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAppId;
        private System.Windows.Forms.TextBox txtboxAppId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSetPaymentStatus;
        private System.Windows.Forms.DataGridView grdRecordPayment;
        private DataSet8 dataSet8;
        private System.Windows.Forms.BindingSource aPPOINTMENTBindingSource;
        private DataSet8TableAdapters.APPOINTMENTTableAdapter aPPOINTMENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVALDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVALTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAYMENTSTATUSDataGridViewTextBoxColumn;
    }
}