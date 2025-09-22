namespace MediFlowGpSYS
{
    partial class frmSetVisitNotes
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
            this.txtboxNotes = new System.Windows.Forms.TextBox();
            this.lblnotes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxFee = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSetnotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxNotes
            // 
            this.txtboxNotes.Location = new System.Drawing.Point(194, 106);
            this.txtboxNotes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtboxNotes.Name = "txtboxNotes";
            this.txtboxNotes.Size = new System.Drawing.Size(556, 31);
            this.txtboxNotes.TabIndex = 0;
            // 
            // lblnotes
            // 
            this.lblnotes.AutoSize = true;
            this.lblnotes.Location = new System.Drawing.Point(12, 112);
            this.lblnotes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblnotes.Name = "lblnotes";
            this.lblnotes.Size = new System.Drawing.Size(172, 25);
            this.lblnotes.TabIndex = 1;
            this.lblnotes.Text = "Enter Visit Notes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Fee";
            // 
            // txtboxFee
            // 
            this.txtboxFee.Location = new System.Drawing.Point(130, 179);
            this.txtboxFee.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtboxFee.Name = "txtboxFee";
            this.txtboxFee.Size = new System.Drawing.Size(136, 31);
            this.txtboxFee.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(-3, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(170, 42);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSetnotes
            // 
            this.btnSetnotes.Location = new System.Drawing.Point(299, 242);
            this.btnSetnotes.Name = "btnSetnotes";
            this.btnSetnotes.Size = new System.Drawing.Size(320, 71);
            this.btnSetnotes.TabIndex = 15;
            this.btnSetnotes.Text = "Set Notes and Fee";
            this.btnSetnotes.UseVisualStyleBackColor = true;
            this.btnSetnotes.Click += new System.EventHandler(this.btnSetnotes_Click);
            // 
            // frmSetVisitNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 865);
            this.Controls.Add(this.btnSetnotes);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtboxFee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnotes);
            this.Controls.Add(this.txtboxNotes);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmSetVisitNotes";
            this.Text = "frmSetVisitNotes";
            this.Load += new System.EventHandler(this.frmSetVisitNotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxNotes;
        private System.Windows.Forms.Label lblnotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxFee;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSetnotes;
    }
}