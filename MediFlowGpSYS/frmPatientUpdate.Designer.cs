
namespace MediFlowGpSYS
{
    partial class frmPatientUpdate
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
            this.lblForename = new System.Windows.Forms.Label();
            this.txtboxForename = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtboxPhone = new System.Windows.Forms.TextBox();
            this.lblMedicalCard = new System.Windows.Forms.Label();
            this.btnMedicalCardYes = new System.Windows.Forms.RadioButton();
            this.btnMedicalCardNo = new System.Windows.Forms.RadioButton();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.btnPatientUpdate = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(2, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 22);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(12, 52);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(62, 13);
            this.lblForename.TabIndex = 13;
            this.lblForename.Tag = "";
            this.lblForename.Text = "Forename";
            this.lblForename.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtboxForename
            // 
            this.txtboxForename.Location = new System.Drawing.Point(80, 49);
            this.txtboxForename.Name = "txtboxForename";
            this.txtboxForename.Size = new System.Drawing.Size(100, 20);
            this.txtboxForename.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Tag = "";
            this.lblEmail.Text = "Email";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(80, 137);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(100, 20);
            this.txtboxEmail.TabIndex = 18;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(8, 192);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 13);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Tag = "";
            this.lblPhone.Text = "Phone no";
            // 
            // txtboxPhone
            // 
            this.txtboxPhone.Location = new System.Drawing.Point(80, 189);
            this.txtboxPhone.Name = "txtboxPhone";
            this.txtboxPhone.Size = new System.Drawing.Size(100, 20);
            this.txtboxPhone.TabIndex = 20;
            // 
            // lblMedicalCard
            // 
            this.lblMedicalCard.AutoSize = true;
            this.lblMedicalCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalCard.Location = new System.Drawing.Point(6, 235);
            this.lblMedicalCard.Name = "lblMedicalCard";
            this.lblMedicalCard.Size = new System.Drawing.Size(81, 13);
            this.lblMedicalCard.TabIndex = 21;
            this.lblMedicalCard.Tag = "";
            this.lblMedicalCard.Text = "Medical Card";
            // 
            // btnMedicalCardYes
            // 
            this.btnMedicalCardYes.AutoSize = true;
            this.btnMedicalCardYes.Location = new System.Drawing.Point(93, 233);
            this.btnMedicalCardYes.Name = "btnMedicalCardYes";
            this.btnMedicalCardYes.Size = new System.Drawing.Size(43, 17);
            this.btnMedicalCardYes.TabIndex = 23;
            this.btnMedicalCardYes.TabStop = true;
            this.btnMedicalCardYes.Text = "Yes";
            this.btnMedicalCardYes.UseVisualStyleBackColor = true;
            // 
            // btnMedicalCardNo
            // 
            this.btnMedicalCardNo.AutoSize = true;
            this.btnMedicalCardNo.Location = new System.Drawing.Point(142, 233);
            this.btnMedicalCardNo.Name = "btnMedicalCardNo";
            this.btnMedicalCardNo.Size = new System.Drawing.Size(39, 17);
            this.btnMedicalCardNo.TabIndex = 24;
            this.btnMedicalCardNo.TabStop = true;
            this.btnMedicalCardNo.Text = "No";
            this.btnMedicalCardNo.UseVisualStyleBackColor = true;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(8, 285);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(88, 13);
            this.lblAddress.TabIndex = 25;
            this.lblAddress.Tag = "";
            this.lblAddress.Text = "Home Address";
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Location = new System.Drawing.Point(102, 282);
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(161, 20);
            this.txtboxAddress.TabIndex = 26;
            // 
            // btnPatientUpdate
            // 
            this.btnPatientUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPatientUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientUpdate.Location = new System.Drawing.Point(217, 329);
            this.btnPatientUpdate.Name = "btnPatientUpdate";
            this.btnPatientUpdate.Size = new System.Drawing.Size(177, 40);
            this.btnPatientUpdate.TabIndex = 27;
            this.btnPatientUpdate.Text = "Update Patient";
            this.btnPatientUpdate.UseVisualStyleBackColor = false;
            this.btnPatientUpdate.Click += new System.EventHandler(this.btnPatientUpdate_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(13, 96);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(56, 13);
            this.lblSurname.TabIndex = 28;
            this.lblSurname.Tag = "";
            this.lblSurname.Text = "Surname";
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.Location = new System.Drawing.Point(80, 96);
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(100, 20);
            this.txtboxSurname.TabIndex = 29;
            // 
            // frmPatientUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 385);
            this.Controls.Add(this.txtboxSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.btnPatientUpdate);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnMedicalCardNo);
            this.Controls.Add(this.btnMedicalCardYes);
            this.Controls.Add(this.lblMedicalCard);
            this.Controls.Add(this.txtboxPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtboxForename);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPatientUpdate";
            this.Text = "UpdatePatient Menu";
            this.Load += new System.EventHandler(this.frmPatientUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtboxForename;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtboxPhone;
        private System.Windows.Forms.Label lblMedicalCard;
        private System.Windows.Forms.RadioButton btnMedicalCardYes;
        private System.Windows.Forms.RadioButton btnMedicalCardNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.Button btnPatientUpdate;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtboxSurname;
    }
}