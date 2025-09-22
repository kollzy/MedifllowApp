
using System;

namespace MediFlowGpSYS
{
    partial class frmDoctorReg
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
            this.lblForename = new System.Windows.Forms.Label();
            this.txtboxForename = new System.Windows.Forms.TextBox();
            this.txtboxMDN = new System.Windows.Forms.TextBox();
            this.lblMDN = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtboxPhone = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRegDoctor = new System.Windows.Forms.Button();
            this.lblsurname = new System.Windows.Forms.Label();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(0, 70);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(62, 13);
            this.lblForename.TabIndex = 0;
            this.lblForename.Tag = "";
            this.lblForename.Text = "Forename";
            // 
            // txtboxForename
            // 
            this.txtboxForename.Location = new System.Drawing.Point(61, 67);
            this.txtboxForename.Name = "txtboxForename";
            this.txtboxForename.Size = new System.Drawing.Size(100, 20);
            this.txtboxForename.TabIndex = 1;
            // 
            // txtboxMDN
            // 
            this.txtboxMDN.Location = new System.Drawing.Point(119, 144);
            this.txtboxMDN.Name = "txtboxMDN";
            this.txtboxMDN.Size = new System.Drawing.Size(100, 20);
            this.txtboxMDN.TabIndex = 2;
            this.txtboxMDN.TextChanged += new System.EventHandler(this.txtboxMDN_TextChanged);
            // 
            // lblMDN
            // 
            this.lblMDN.AutoSize = true;
            this.lblMDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDN.Location = new System.Drawing.Point(0, 151);
            this.lblMDN.Name = "lblMDN";
            this.lblMDN.Size = new System.Drawing.Size(113, 13);
            this.lblMDN.TabIndex = 3;
            this.lblMDN.Tag = "";
            this.lblMDN.Text = "Medical Doctor No";
            this.lblMDN.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(2, 196);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Tag = "";
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(45, 193);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(100, 20);
            this.txtboxEmail.TabIndex = 5;
            this.txtboxEmail.TextChanged += new System.EventHandler(this.txtboxEmail_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(0, 237);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Tag = "";
            this.lblPhone.Text = "Phone no";
            // 
            // txtboxPhone
            // 
            this.txtboxPhone.Location = new System.Drawing.Point(67, 234);
            this.txtboxPhone.Name = "txtboxPhone";
            this.txtboxPhone.Size = new System.Drawing.Size(100, 20);
            this.txtboxPhone.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 22);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.backButton_Click);
            // 
            // btnRegDoctor
            // 
            this.btnRegDoctor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegDoctor.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegDoctor.Location = new System.Drawing.Point(216, 268);
            this.btnRegDoctor.Name = "btnRegDoctor";
            this.btnRegDoctor.Size = new System.Drawing.Size(177, 40);
            this.btnRegDoctor.TabIndex = 11;
            this.btnRegDoctor.Text = "Register Doctor";
            this.btnRegDoctor.UseVisualStyleBackColor = false;
            this.btnRegDoctor.Click += new System.EventHandler(this.RegisterDocButton_Click);
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsurname.Location = new System.Drawing.Point(2, 110);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(56, 13);
            this.lblsurname.TabIndex = 12;
            this.lblsurname.Tag = "";
            this.lblsurname.Text = "Surname";
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.Location = new System.Drawing.Point(63, 107);
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(100, 20);
            this.txtboxSurname.TabIndex = 13;
            // 
            // frmDoctorReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 489);
            this.Controls.Add(this.txtboxSurname);
            this.Controls.Add(this.lblsurname);
            this.Controls.Add(this.btnRegDoctor);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtboxPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMDN);
            this.Controls.Add(this.txtboxMDN);
            this.Controls.Add(this.txtboxForename);
            this.Controls.Add(this.lblForename);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDoctorReg";
            this.Text = "registerDoctorMenu";
            this.Load += new System.EventHandler(this.registerDoctorMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtboxForename;
        private System.Windows.Forms.TextBox txtboxMDN;
        private System.Windows.Forms.Label lblMDN;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtboxPhone;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRegDoctor;
        private readonly EventHandler label1_Click;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.TextBox txtboxSurname;
    }
}