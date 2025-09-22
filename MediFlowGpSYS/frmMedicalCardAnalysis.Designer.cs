namespace MediFlowGpSYS
{
    partial class frmMedicalCardAnalysis
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
            this.lblGetYear = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grdMedicalCardAnalysis = new System.Windows.Forms.DataGridView();
            this.txtboxYear = new System.Windows.Forms.MaskedTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Medical_Card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicalCardAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGetYear
            // 
            this.lblGetYear.AutoSize = true;
            this.lblGetYear.Location = new System.Drawing.Point(27, 68);
            this.lblGetYear.Name = "lblGetYear";
            this.lblGetYear.Size = new System.Drawing.Size(57, 13);
            this.lblGetYear.TabIndex = 1;
            this.lblGetYear.Text = "Enter Year";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(2, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 22);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grdMedicalCardAnalysis
            // 
            this.grdMedicalCardAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMedicalCardAnalysis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medical_Card,
            this.Column1});
            this.grdMedicalCardAnalysis.Location = new System.Drawing.Point(387, 24);
            this.grdMedicalCardAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.grdMedicalCardAnalysis.Name = "grdMedicalCardAnalysis";
            this.grdMedicalCardAnalysis.RowTemplate.Height = 33;
            this.grdMedicalCardAnalysis.Size = new System.Drawing.Size(272, 119);
            this.grdMedicalCardAnalysis.TabIndex = 15;
            // 
            // txtboxYear
            // 
            this.txtboxYear.Location = new System.Drawing.Point(90, 65);
            this.txtboxYear.Name = "txtboxYear";
            this.txtboxYear.Size = new System.Drawing.Size(135, 20);
            this.txtboxYear.TabIndex = 17;
         
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(241, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 20);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Medical_Card
            // 
            this.Medical_Card.HeaderText = "Medical Card";
            this.Medical_Card.Name = "Medical_Card";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No Medical Card";
            this.Column1.Name = "Column1";
            // 
            // frmMedicalCardAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtboxYear);
            this.Controls.Add(this.grdMedicalCardAnalysis);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblGetYear);
            this.Name = "frmMedicalCardAnalysis";
            this.Text = "frmMedicalCardAnalysis";
            this.Load += new System.EventHandler(this.frmMedicalCardAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicalCardAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGetYear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grdMedicalCardAnalysis;
        private System.Windows.Forms.MaskedTextBox txtboxYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medical_Card;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}