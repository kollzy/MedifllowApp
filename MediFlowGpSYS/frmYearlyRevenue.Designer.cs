namespace MediFlowGpSYS
{
    partial class frmYearlyRevenue
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxYear = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnyearlyRev = new System.Windows.Forms.Button();
            this.grdYearlyRevenue = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdYearlyRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Year";
            // 
            // txtboxYear
            // 
            this.txtboxYear.Location = new System.Drawing.Point(113, 44);
            this.txtboxYear.Name = "txtboxYear";
            this.txtboxYear.Size = new System.Drawing.Size(100, 20);
            this.txtboxYear.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 22);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnyearlyRev
            // 
            this.btnyearlyRev.Location = new System.Drawing.Point(235, 39);
            this.btnyearlyRev.Margin = new System.Windows.Forms.Padding(2);
            this.btnyearlyRev.Name = "btnyearlyRev";
            this.btnyearlyRev.Size = new System.Drawing.Size(162, 29);
            this.btnyearlyRev.TabIndex = 16;
            this.btnyearlyRev.Text = "Get Yearly Revenue Generated";
            this.btnyearlyRev.UseVisualStyleBackColor = true;
            this.btnyearlyRev.Click += new System.EventHandler(this.btnyearlyRev_Click);
            // 
            // grdYearlyRevenue
            // 
            this.grdYearlyRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdYearlyRevenue.Location = new System.Drawing.Point(62, 99);
            this.grdYearlyRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.grdYearlyRevenue.Name = "grdYearlyRevenue";
            this.grdYearlyRevenue.RowTemplate.Height = 33;
            this.grdYearlyRevenue.Size = new System.Drawing.Size(634, 193);
            this.grdYearlyRevenue.TabIndex = 17;
            this.grdYearlyRevenue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frmYearlyRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.grdYearlyRevenue);
            this.Controls.Add(this.btnyearlyRev);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtboxYear);
            this.Controls.Add(this.label1);
            this.Name = "frmYearlyRevenue";
            this.Text = "frmYearlyRevenue";
            this.Load += new System.EventHandler(this.frmYearlyRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdYearlyRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxYear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnyearlyRev;
        private System.Windows.Forms.DataGridView grdYearlyRevenue;
    }
}