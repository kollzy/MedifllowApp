
namespace MediFlowGpSYS
{
    partial class frmPatientReg
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFname = new System.Windows.Forms.Label();
            this.txtboxForename = new System.Windows.Forms.TextBox();
            this.lblMRN = new System.Windows.Forms.Label();
            this.txtboxMRN = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtboxPhone = new System.Windows.Forms.TextBox();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnMedicalCard = new System.Windows.Forms.Label();
            this.btnPatientReg = new System.Windows.Forms.Button();
            this.btnMedicalCardYes = new System.Windows.Forms.RadioButton();
            this.btnMedicalCardNo = new System.Windows.Forms.RadioButton();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 22);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.backButton_Click);
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(12, 61);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(62, 13);
            this.lblFname.TabIndex = 12;
            this.lblFname.Tag = "";
            this.lblFname.Text = "Forename";
            // 
            // txtboxForename
            // 
            this.txtboxForename.Location = new System.Drawing.Point(87, 58);
            this.txtboxForename.Name = "txtboxForename";
            this.txtboxForename.Size = new System.Drawing.Size(100, 20);
            this.txtboxForename.TabIndex = 13;
            this.txtboxForename.TextChanged += new System.EventHandler(this.Nametxtbox_TextChanged);
            // 
            // lblMRN
            // 
            this.lblMRN.AutoSize = true;
            this.lblMRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRN.Location = new System.Drawing.Point(11, 137);
            this.lblMRN.Name = "lblMRN";
            this.lblMRN.Size = new System.Drawing.Size(116, 13);
            this.lblMRN.TabIndex = 14;
            this.lblMRN.Tag = "";
            this.lblMRN.Text = "Medical Record No";
            // 
            // txtboxMRN
            // 
            this.txtboxMRN.Location = new System.Drawing.Point(133, 134);
            this.txtboxMRN.Name = "txtboxMRN";
            this.txtboxMRN.Size = new System.Drawing.Size(100, 20);
            this.txtboxMRN.TabIndex = 15;
            this.txtboxMRN.TextChanged += new System.EventHandler(this.txtboxMDN_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 177);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Tag = "";
            this.lblEmail.Text = "Email";
            // 
            // txtboxPhone
            // 
            this.txtboxPhone.Location = new System.Drawing.Point(87, 206);
            this.txtboxPhone.Name = "txtboxPhone";
            this.txtboxPhone.Size = new System.Drawing.Size(100, 20);
            this.txtboxPhone.TabIndex = 17;
            this.txtboxPhone.TextChanged += new System.EventHandler(this.txtboxPhone_TextChanged);
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(87, 170);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(100, 20);
            this.txtboxEmail.TabIndex = 17;
            this.txtboxEmail.TextChanged += new System.EventHandler(this.txtboxEmail_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(13, 213);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 13);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Tag = "";
            this.lblPhone.Text = "Phone no";
            // 
            // btnMedicalCard
            // 
            this.btnMedicalCard.AutoSize = true;
            this.btnMedicalCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicalCard.Location = new System.Drawing.Point(12, 266);
            this.btnMedicalCard.Name = "btnMedicalCard";
            this.btnMedicalCard.Size = new System.Drawing.Size(81, 13);
            this.btnMedicalCard.TabIndex = 19;
            this.btnMedicalCard.Tag = "";
            this.btnMedicalCard.Text = "Medical Card";
            // 
            // btnPatientReg
            // 
            this.btnPatientReg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPatientReg.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientReg.Location = new System.Drawing.Point(280, 380);
            this.btnPatientReg.Name = "btnPatientReg";
            this.btnPatientReg.Size = new System.Drawing.Size(177, 40);
            this.btnPatientReg.TabIndex = 21;
            this.btnPatientReg.Text = "Register Patient";
            this.btnPatientReg.UseVisualStyleBackColor = false;
            this.btnPatientReg.Click += new System.EventHandler(this.RegisterDocButton_Click);
            // 
            // btnMedicalCardYes
            // 
            this.btnMedicalCardYes.AutoSize = true;
            this.btnMedicalCardYes.Location = new System.Drawing.Point(99, 264);
            this.btnMedicalCardYes.Name = "btnMedicalCardYes";
            this.btnMedicalCardYes.Size = new System.Drawing.Size(43, 17);
            this.btnMedicalCardYes.TabIndex = 22;
            this.btnMedicalCardYes.TabStop = true;
            this.btnMedicalCardYes.Text = "Yes";
            this.btnMedicalCardYes.UseVisualStyleBackColor = true;
            // 
            // btnMedicalCardNo
            // 
            this.btnMedicalCardNo.AutoSize = true;
            this.btnMedicalCardNo.Location = new System.Drawing.Point(148, 264);
            this.btnMedicalCardNo.Name = "btnMedicalCardNo";
            this.btnMedicalCardNo.Size = new System.Drawing.Size(39, 17);
            this.btnMedicalCardNo.TabIndex = 23;
            this.btnMedicalCardNo.TabStop = true;
            this.btnMedicalCardNo.Text = "No";
            this.btnMedicalCardNo.UseVisualStyleBackColor = true;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(11, 313);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(88, 13);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Tag = "";
            this.lblAddress.Text = "Home Address";
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Location = new System.Drawing.Point(99, 300);
            this.txtboxAddress.MinimumSize = new System.Drawing.Size(138, 40);
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(200, 40);
            this.txtboxAddress.TabIndex = 25;
            this.txtboxAddress.TextChanged += new System.EventHandler(this.AddressTxtbox_TextChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(11, 95);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(56, 13);
            this.lblSurname.TabIndex = 26;
            this.lblSurname.Tag = "";
            this.lblSurname.Text = "Surname";
            this.lblSurname.UseMnemonic = false;
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.Location = new System.Drawing.Point(87, 92);
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(100, 20);
            this.txtboxSurname.TabIndex = 27;
            this.txtboxSurname.TextChanged += new System.EventHandler(this.txtboxSurname_TextChanged);
            // 
            // frmPatientReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.txtboxSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnMedicalCardNo);
            this.Controls.Add(this.btnMedicalCardYes);
            this.Controls.Add(this.btnPatientReg);
            this.Controls.Add(this.btnMedicalCard);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.txtboxPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtboxMRN);
            this.Controls.Add(this.lblMRN);
            this.Controls.Add(this.txtboxForename);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.btnBack);
            this.Name = "frmPatientReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "registerPatient";
            this.Load += new System.EventHandler(this.registerPatientMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox txtboxForename;
        private System.Windows.Forms.Label lblMRN;
        private System.Windows.Forms.TextBox txtboxMRN;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtboxPhone;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label btnMedicalCard;
        private System.Windows.Forms.Button btnPatientReg;
        private System.Windows.Forms.RadioButton btnMedicalCardYes;
        private System.Windows.Forms.RadioButton btnMedicalCardNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtboxSurname;
    }
}