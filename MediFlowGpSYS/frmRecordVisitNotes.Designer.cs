
namespace MediFlowGpSYS
{
    partial class frmRecordVisitNotes
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
            this.btnRecordvistNotes = new System.Windows.Forms.Button();
            this.mEDICALHISTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet10 = new MediFlowGpSYS.DataSet10();
            this.dataSet9 = new MediFlowGpSYS.DataSet9();
            this.aPPOINTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPPOINTMENTTableAdapter = new MediFlowGpSYS.DataSet9TableAdapters.APPOINTMENTTableAdapter();
            this.mEDICALHISTORYTableAdapter = new MediFlowGpSYS.DataSet10TableAdapters.MEDICALHISTORYTableAdapter();
            this.grdRecordVisitNotes = new System.Windows.Forms.DataGridView();
            this.aPPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVALDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVALTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYMENTSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISITNOTESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPOINTMENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet12 = new MediFlowGpSYS.DataSet12();
            this.aPPOINTMENTTableAdapter1 = new MediFlowGpSYS.DataSet12TableAdapters.APPOINTMENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICALHISTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecordVisitNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(170, 42);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAppid
            // 
            this.lblAppid.AutoSize = true;
            this.lblAppid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppid.Location = new System.Drawing.Point(48, 137);
            this.lblAppid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAppid.Name = "lblAppid";
            this.lblAppid.Size = new System.Drawing.Size(74, 13);
            this.lblAppid.TabIndex = 20;
            this.lblAppid.Tag = "";
            this.lblAppid.Text = "Enter AppId";
            // 
            // txtboxAppid
            // 
            this.txtboxAppid.Location = new System.Drawing.Point(216, 131);
            this.txtboxAppid.Margin = new System.Windows.Forms.Padding(6);
            this.txtboxAppid.Name = "txtboxAppid";
            this.txtboxAppid.Size = new System.Drawing.Size(196, 31);
            this.txtboxAppid.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(496, 131);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 38);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRecordvistNotes
            // 
            this.btnRecordvistNotes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRecordvistNotes.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordvistNotes.Location = new System.Drawing.Point(616, 715);
            this.btnRecordvistNotes.Margin = new System.Windows.Forms.Padding(6);
            this.btnRecordvistNotes.Name = "btnRecordvistNotes";
            this.btnRecordvistNotes.Size = new System.Drawing.Size(444, 65);
            this.btnRecordvistNotes.TabIndex = 30;
            this.btnRecordvistNotes.Text = "Record Visit Notes";
            this.btnRecordvistNotes.UseVisualStyleBackColor = false;
            this.btnRecordvistNotes.Click += new System.EventHandler(this.btnRecordvistNotes_Click);
            // 
            // mEDICALHISTORYBindingSource
            // 
            this.mEDICALHISTORYBindingSource.DataMember = "MEDICALHISTORY";
            this.mEDICALHISTORYBindingSource.DataSource = this.dataSet10;
            // 
            // dataSet10
            // 
            this.dataSet10.DataSetName = "DataSet10";
            this.dataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet9
            // 
            this.dataSet9.DataSetName = "DataSet9";
            this.dataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPPOINTMENTBindingSource
            // 
            this.aPPOINTMENTBindingSource.DataMember = "APPOINTMENT";
            this.aPPOINTMENTBindingSource.DataSource = this.dataSet9;
            // 
            // aPPOINTMENTTableAdapter
            // 
            this.aPPOINTMENTTableAdapter.ClearBeforeFill = true;
            // 
            // mEDICALHISTORYTableAdapter
            // 
            this.mEDICALHISTORYTableAdapter.ClearBeforeFill = true;
            // 
            // grdRecordVisitNotes
            // 
            this.grdRecordVisitNotes.AutoGenerateColumns = false;
            this.grdRecordVisitNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRecordVisitNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aPPIDDataGridViewTextBoxColumn,
            this.dOCTORNAMEDataGridViewTextBoxColumn,
            this.mRNDataGridViewTextBoxColumn,
            this.aRRIVALDATEDataGridViewTextBoxColumn,
            this.aRRIVALTIMEDataGridViewTextBoxColumn,
            this.fEESDataGridViewTextBoxColumn,
            this.aPPSTATUSDataGridViewTextBoxColumn,
            this.pAYMENTSTATUSDataGridViewTextBoxColumn,
            this.vISITNOTESDataGridViewTextBoxColumn});
            this.grdRecordVisitNotes.DataSource = this.aPPOINTMENTBindingSource1;
            this.grdRecordVisitNotes.Location = new System.Drawing.Point(24, 302);
            this.grdRecordVisitNotes.Margin = new System.Windows.Forms.Padding(6);
            this.grdRecordVisitNotes.Name = "grdRecordVisitNotes";
            this.grdRecordVisitNotes.Size = new System.Drawing.Size(1822, 383);
            this.grdRecordVisitNotes.TabIndex = 31;
            this.grdRecordVisitNotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRecordVisitNotes_CellClick);
           
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
            // vISITNOTESDataGridViewTextBoxColumn
            // 
            this.vISITNOTESDataGridViewTextBoxColumn.DataPropertyName = "VISITNOTES";
            this.vISITNOTESDataGridViewTextBoxColumn.HeaderText = "VISITNOTES";
            this.vISITNOTESDataGridViewTextBoxColumn.Name = "vISITNOTESDataGridViewTextBoxColumn";
            // 
            // aPPOINTMENTBindingSource1
            // 
            this.aPPOINTMENTBindingSource1.DataMember = "APPOINTMENT";
            this.aPPOINTMENTBindingSource1.DataSource = this.dataSet12;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet12";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPPOINTMENTTableAdapter1
            // 
            this.aPPOINTMENTTableAdapter1.ClearBeforeFill = true;
            // 
            // frmRecordVisitNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 941);
            this.Controls.Add(this.grdRecordVisitNotes);
            this.Controls.Add(this.btnRecordvistNotes);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtboxAppid);
            this.Controls.Add(this.lblAppid);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecordVisitNotes";
            this.Text = "frmRecordVisitNotes";
            this.Load += new System.EventHandler(this.frmRecordVisitNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mEDICALHISTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecordVisitNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAppid;
        private System.Windows.Forms.TextBox txtboxAppid;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRecordvistNotes;
        private DataSet9 dataSet9;
        private System.Windows.Forms.BindingSource aPPOINTMENTBindingSource;
        private DataSet9TableAdapters.APPOINTMENTTableAdapter aPPOINTMENTTableAdapter;
        private DataSet10 dataSet10;
        private System.Windows.Forms.BindingSource mEDICALHISTORYBindingSource;
        private DataSet10TableAdapters.MEDICALHISTORYTableAdapter mEDICALHISTORYTableAdapter;
        private System.Windows.Forms.DataGridView grdRecordVisitNotes;
        private DataSet12 dataSet12;
        private System.Windows.Forms.BindingSource aPPOINTMENTBindingSource1;
        private DataSet12TableAdapters.APPOINTMENTTableAdapter aPPOINTMENTTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVALDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVALTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAYMENTSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISITNOTESDataGridViewTextBoxColumn;
    }
}