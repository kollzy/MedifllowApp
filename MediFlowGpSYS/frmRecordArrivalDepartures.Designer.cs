
namespace MediFlowGpSYS
{
    partial class frmRecordArrivalDepartures
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
            this.btnSetAppStatus = new System.Windows.Forms.Button();
            this.aPPOINTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdRecordArrDep = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPOINTMENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet7 = new MediFlowGpSYS.DataSet7();
            this.aPPOINTMENTTableAdapter = new MediFlowGpSYS.DataSet7TableAdapters.APPOINTMENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecordArrDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(16, 6);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(170, 42);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAppid
            // 
            this.lblAppid.AutoSize = true;
            this.lblAppid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppid.Location = new System.Drawing.Point(62, 150);
            this.lblAppid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAppid.Name = "lblAppid";
            this.lblAppid.Size = new System.Drawing.Size(73, 13);
            this.lblAppid.TabIndex = 21;
            this.lblAppid.Tag = "";
            this.lblAppid.Text = "Enter Appid";
            // 
            // txtboxAppid
            // 
            this.txtboxAppid.Location = new System.Drawing.Point(220, 144);
            this.txtboxAppid.Margin = new System.Windows.Forms.Padding(6);
            this.txtboxAppid.Name = "txtboxAppid";
            this.txtboxAppid.Size = new System.Drawing.Size(196, 31);
            this.txtboxAppid.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(496, 144);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 38);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSetAppStatus
            // 
            this.btnSetAppStatus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSetAppStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAppStatus.Location = new System.Drawing.Point(608, 613);
            this.btnSetAppStatus.Margin = new System.Windows.Forms.Padding(6);
            this.btnSetAppStatus.Name = "btnSetAppStatus";
            this.btnSetAppStatus.Size = new System.Drawing.Size(574, 58);
            this.btnSetAppStatus.TabIndex = 31;
            this.btnSetAppStatus.Text = "Set Appointment Status To Arrived";
            this.btnSetAppStatus.UseVisualStyleBackColor = false;
            this.btnSetAppStatus.Click += new System.EventHandler(this.btnSetAppStatus_Click);
            // 
            // grdRecordArrDep
            // 
            this.grdRecordArrDep.AutoGenerateColumns = false;
            this.grdRecordArrDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRecordArrDep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.grdRecordArrDep.DataSource = this.aPPOINTMENTBindingSource1;
            this.grdRecordArrDep.Location = new System.Drawing.Point(318, 246);
            this.grdRecordArrDep.Margin = new System.Windows.Forms.Padding(6);
            this.grdRecordArrDep.Name = "grdRecordArrDep";
            this.grdRecordArrDep.Size = new System.Drawing.Size(1168, 275);
            this.grdRecordArrDep.TabIndex = 32;
            this.grdRecordArrDep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.grdRecordArrDep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRecordArrDep_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "APPID";
            this.dataGridViewTextBoxColumn1.HeaderText = "APPID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DOCTORNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "DOCTORNAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MRN";
            this.dataGridViewTextBoxColumn3.HeaderText = "MRN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ARRIVALDATE";
            this.dataGridViewTextBoxColumn4.HeaderText = "ARRIVALDATE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ARRIVALTIME";
            this.dataGridViewTextBoxColumn5.HeaderText = "ARRIVALTIME";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FEES";
            this.dataGridViewTextBoxColumn6.HeaderText = "FEES";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "APPSTATUS";
            this.dataGridViewTextBoxColumn7.HeaderText = "APPSTATUS";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PAYMENTSTATUS";
            this.dataGridViewTextBoxColumn8.HeaderText = "PAYMENTSTATUS";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // aPPOINTMENTBindingSource1
            // 
            this.aPPOINTMENTBindingSource1.DataMember = "APPOINTMENT";
            this.aPPOINTMENTBindingSource1.DataSource = this.dataSet7;
            // 
            // dataSet7
            // 
            this.dataSet7.DataSetName = "DataSet7";
            this.dataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPPOINTMENTTableAdapter
            // 
            this.aPPOINTMENTTableAdapter.ClearBeforeFill = true;
            // 
            // frmRecordArrivalDepartures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 941);
            this.Controls.Add(this.grdRecordArrDep);
            this.Controls.Add(this.btnSetAppStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtboxAppid);
            this.Controls.Add(this.lblAppid);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecordArrivalDepartures";
            this.Text = "frmRecordArrivalDepartures";
            this.Load += new System.EventHandler(this.frmRecordArrivalDepartures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecordArrDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAppid;
        private System.Windows.Forms.TextBox txtboxAppid;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSetAppStatus;
        private System.Windows.Forms.BindingSource dataSet7BindingSource;
       
        private System.Windows.Forms.BindingSource aPPOINTMENTBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVALDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVALTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAYMENTSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView grdRecordArrDep;
        private DataSet7 dataSet7;
        private System.Windows.Forms.BindingSource aPPOINTMENTBindingSource1;
        private DataSet7TableAdapters.APPOINTMENTTableAdapter aPPOINTMENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}