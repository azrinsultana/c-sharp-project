namespace App
{
    partial class ReceptionistHomePage
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
            this.pnlReceptionistHomePage = new System.Windows.Forms.Panel();
            this.btnlogOut = new System.Windows.Forms.Button();
            this.lvlWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnManagePatient = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.pnlReceptionistHomePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReceptionistHomePage
            // 
            this.pnlReceptionistHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.pnlReceptionistHomePage.Controls.Add(this.btnlogOut);
            this.pnlReceptionistHomePage.Controls.Add(this.lvlWelcome);
            this.pnlReceptionistHomePage.Location = new System.Drawing.Point(1, 1);
            this.pnlReceptionistHomePage.Name = "pnlReceptionistHomePage";
            this.pnlReceptionistHomePage.Size = new System.Drawing.Size(785, 100);
            this.pnlReceptionistHomePage.TabIndex = 0;
            // 
            // btnlogOut
            // 
            this.btnlogOut.BackColor = System.Drawing.Color.DarkRed;
            this.btnlogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogOut.ForeColor = System.Drawing.Color.White;
            this.btnlogOut.Location = new System.Drawing.Point(696, 11);
            this.btnlogOut.Name = "btnlogOut";
            this.btnlogOut.Size = new System.Drawing.Size(75, 28);
            this.btnlogOut.TabIndex = 61;
            this.btnlogOut.Text = "Logout";
            this.btnlogOut.UseVisualStyleBackColor = false;
            this.btnlogOut.Click += new System.EventHandler(this.btnlogOut_Click);
            // 
            // lvlWelcome
            // 
            this.lvlWelcome.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlWelcome.ForeColor = System.Drawing.Color.White;
            this.lvlWelcome.Location = new System.Drawing.Point(120, 23);
            this.lvlWelcome.Name = "lvlWelcome";
            this.lvlWelcome.Size = new System.Drawing.Size(549, 58);
            this.lvlWelcome.TabIndex = 0;
            this.lvlWelcome.Text = "Welcome to Receptionist Home Page";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Set Appoinment";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "Manage Patient";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(498, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 34);
            this.label5.TabIndex = 12;
            this.label5.Text = "Register Patient";
            // 
            // btnManagePatient
            // 
            this.btnManagePatient.Image = global::App.Properties.Resources.DoctorList_icon;
            this.btnManagePatient.Location = new System.Drawing.Point(362, 171);
            this.btnManagePatient.Name = "btnManagePatient";
            this.btnManagePatient.Size = new System.Drawing.Size(113, 93);
            this.btnManagePatient.TabIndex = 11;
            this.btnManagePatient.UseVisualStyleBackColor = true;
            this.btnManagePatient.Click += new System.EventHandler(this.btnManagePatient_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Image = global::App.Properties.Resources.Doctor_icon2;
            this.btnAddPatient.Location = new System.Drawing.Point(504, 174);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(108, 87);
            this.btnAddPatient.TabIndex = 4;
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Image = global::App.Properties.Resources.Appointmnet_icon1;
            this.btnAppointment.Location = new System.Drawing.Point(183, 174);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(127, 93);
            this.btnAppointment.TabIndex = 3;
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // ReceptionistHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnManagePatient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnAppointment);
            this.Controls.Add(this.pnlReceptionistHomePage);
            this.Name = "ReceptionistHomePage";
            this.Text = "v";
            this.Load += new System.EventHandler(this.ReceptionistHomePage_Load);
            this.pnlReceptionistHomePage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReceptionistHomePage;
        private System.Windows.Forms.Label lvlWelcome;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnManagePatient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnlogOut;
    }
}