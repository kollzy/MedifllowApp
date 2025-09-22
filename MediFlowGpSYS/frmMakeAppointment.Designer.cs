
namespace MediFlowGpSYS
{
    partial class frmMakeAppointment
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
            this.grdAvailableTimes = new System.Windows.Forms.DataGridView();
            this.Doctor_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available_Times = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetAvailableTime = new System.Windows.Forms.Button();
            this.btnMakeAppointment = new System.Windows.Forms.Button();
            this.datetimepickerArrDate = new System.Windows.Forms.DateTimePicker();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.labelnamepat = new System.Windows.Forms.Label();
            this.txtboxMRN = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAvailableTimes
            // 
            this.grdAvailableTimes.AllowUserToAddRows = false;
            this.grdAvailableTimes.AllowUserToDeleteRows = false;
            this.grdAvailableTimes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAvailableTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAvailableTimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doctor_Name,
            this.Available_Times});
            this.grdAvailableTimes.Location = new System.Drawing.Point(412, 76);
            this.grdAvailableTimes.Margin = new System.Windows.Forms.Padding(2);
            this.grdAvailableTimes.Name = "grdAvailableTimes";
            this.grdAvailableTimes.ReadOnly = true;
            this.grdAvailableTimes.RowHeadersWidth = 51;
            this.grdAvailableTimes.RowTemplate.Height = 24;
            this.grdAvailableTimes.Size = new System.Drawing.Size(286, 108);
            this.grdAvailableTimes.TabIndex = 44;
            this.grdAvailableTimes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.grdAvailableTimes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Doctor_Name
            // 
            this.Doctor_Name.HeaderText = "Doctor Name";
            this.Doctor_Name.MinimumWidth = 6;
            this.Doctor_Name.Name = "Doctor_Name";
            this.Doctor_Name.ReadOnly = true;
            // 
            // Available_Times
            // 
            this.Available_Times.HeaderText = "Available Times";
            this.Available_Times.MinimumWidth = 6;
            this.Available_Times.Name = "Available_Times";
            this.Available_Times.ReadOnly = true;
            // 
            // btnGetAvailableTime
            // 
            this.btnGetAvailableTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGetAvailableTime.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAvailableTime.Location = new System.Drawing.Point(224, 131);
            this.btnGetAvailableTime.Name = "btnGetAvailableTime";
            this.btnGetAvailableTime.Size = new System.Drawing.Size(170, 26);
            this.btnGetAvailableTime.TabIndex = 41;
            this.btnGetAvailableTime.Text = "Get Available Time for Date";
            this.btnGetAvailableTime.UseVisualStyleBackColor = false;
            this.btnGetAvailableTime.Click += new System.EventHandler(this.btnGetAvailableTime_Click);
            // 
            // btnMakeAppointment
            // 
            this.btnMakeAppointment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMakeAppointment.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeAppointment.Location = new System.Drawing.Point(258, 287);
            this.btnMakeAppointment.Name = "btnMakeAppointment";
            this.btnMakeAppointment.Size = new System.Drawing.Size(177, 40);
            this.btnMakeAppointment.TabIndex = 40;
            this.btnMakeAppointment.Text = "Make Appointment";
            this.btnMakeAppointment.UseVisualStyleBackColor = false;
            this.btnMakeAppointment.Click += new System.EventHandler(this.btnMakeAppointment_Click);
            // 
            // datetimepickerArrDate
            // 
            this.datetimepickerArrDate.CustomFormat = "dd-MMM-yy";
            this.datetimepickerArrDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepickerArrDate.Location = new System.Drawing.Point(103, 137);
            this.datetimepickerArrDate.Margin = new System.Windows.Forms.Padding(2);
            this.datetimepickerArrDate.Name = "datetimepickerArrDate";
            this.datetimepickerArrDate.Size = new System.Drawing.Size(91, 20);
            this.datetimepickerArrDate.TabIndex = 39;
            this.datetimepickerArrDate.Value = new System.DateTime(2024, 4, 10, 0, 0, 0, 0);
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalDate.Location = new System.Drawing.Point(12, 141);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(74, 13);
            this.lblArrivalDate.TabIndex = 38;
            this.lblArrivalDate.Tag = "";
            this.lblArrivalDate.Text = "Arrival Date";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 22);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelnamepat
            // 
            this.labelnamepat.AutoSize = true;
            this.labelnamepat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnamepat.Location = new System.Drawing.Point(288, 102);
            this.labelnamepat.Name = "labelnamepat";
            this.labelnamepat.Size = new System.Drawing.Size(0, 13);
            this.labelnamepat.TabIndex = 45;
            this.labelnamepat.Tag = "";
            // 
            // txtboxMRN
            // 
            this.txtboxMRN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtboxMRN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtboxMRN.Location = new System.Drawing.Point(166, 95);
            this.txtboxMRN.Name = "txtboxMRN";
            this.txtboxMRN.Size = new System.Drawing.Size(100, 20);
            this.txtboxMRN.TabIndex = 37;
            this.txtboxMRN.TextChanged += new System.EventHandler(this.txtboxMRN_TextChanged);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(0, 102);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(160, 13);
            this.lblPatientName.TabIndex = 36;
            this.lblPatientName.Tag = "";
            this.lblPatientName.Text = "Patient Medical Record No";
            // 
            // frmMakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 356);
            this.Controls.Add(this.grdAvailableTimes);
            this.Controls.Add(this.btnGetAvailableTime);
            this.Controls.Add(this.btnMakeAppointment);
            this.Controls.Add(this.datetimepickerArrDate);
            this.Controls.Add(this.lblArrivalDate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelnamepat);
            this.Controls.Add(this.txtboxMRN);
            this.Controls.Add(this.lblPatientName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMakeAppointment";
            this.Text = "MakeAppointment Menu";
            this.Load += new System.EventHandler(this.frmMakeAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.DataGridView grdAvailableTimes;
		private System.Windows.Forms.Button btnGetAvailableTime;
		private System.Windows.Forms.Button btnMakeAppointment;
		private System.Windows.Forms.DateTimePicker datetimepickerArrDate;
		private System.Windows.Forms.Label lblArrivalDate;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label labelnamepat;
		private System.Windows.Forms.TextBox txtboxMRN;
		private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available_Times;
    }
}