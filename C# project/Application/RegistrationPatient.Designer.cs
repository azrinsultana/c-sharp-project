namespace App
{
    partial class RegistrationPatient
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
            this.btnPatientRegister = new System.Windows.Forms.Button();
            this.tbPatientAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBlood = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPatientAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPatientName = new System.Windows.Forms.TextBox();
            this.lblPName = new System.Windows.Forms.Label();
            this.tbPatientUserId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbphone1 = new System.Windows.Forms.TextBox();
            this.tbphnnumber = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnlogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPatientRegister
            // 
            this.btnPatientRegister.BackColor = System.Drawing.Color.Teal;
            this.btnPatientRegister.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientRegister.ForeColor = System.Drawing.Color.Black;
            this.btnPatientRegister.Location = new System.Drawing.Point(200, 365);
            this.btnPatientRegister.Name = "btnPatientRegister";
            this.btnPatientRegister.Size = new System.Drawing.Size(421, 34);
            this.btnPatientRegister.TabIndex = 17;
            this.btnPatientRegister.Text = "Resgiter ";
            this.btnPatientRegister.UseVisualStyleBackColor = false;
            this.btnPatientRegister.Click += new System.EventHandler(this.btnPatientRegister_Click);
            // 
            // tbPatientAddress
            // 
            this.tbPatientAddress.Location = new System.Drawing.Point(412, 285);
            this.tbPatientAddress.Multiline = true;
            this.tbPatientAddress.Name = "tbPatientAddress";
            this.tbPatientAddress.Size = new System.Drawing.Size(232, 45);
            this.tbPatientAddress.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(194, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 33);
            this.label5.TabIndex = 29;
            this.label5.Text = "Address :";
            // 
            // cmbBlood
            // 
            this.cmbBlood.FormattingEnabled = true;
            this.cmbBlood.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.cmbBlood.Location = new System.Drawing.Point(412, 243);
            this.cmbBlood.Name = "cmbBlood";
            this.cmbBlood.Size = new System.Drawing.Size(209, 21);
            this.cmbBlood.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(182, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 33);
            this.label4.TabIndex = 27;
            this.label4.Text = "Blood Group :";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.Red;
            this.radioButton3.Location = new System.Drawing.Point(532, 190);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 35);
            this.radioButton3.TabIndex = 26;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Female";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Red;
            this.radioButton1.Location = new System.Drawing.Point(440, 190);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 35);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(197, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 33);
            this.label3.TabIndex = 24;
            this.label3.Text = "Gender :";
            // 
            // tbPatientAge
            // 
            this.tbPatientAge.Location = new System.Drawing.Point(412, 103);
            this.tbPatientAge.Name = "tbPatientAge";
            this.tbPatientAge.Size = new System.Drawing.Size(209, 20);
            this.tbPatientAge.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(194, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 33);
            this.label2.TabIndex = 22;
            this.label2.Text = "Age :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(182, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "Phone Number:";
            // 
            // tbPatientName
            // 
            this.tbPatientName.Location = new System.Drawing.Point(412, 63);
            this.tbPatientName.Name = "tbPatientName";
            this.tbPatientName.Size = new System.Drawing.Size(209, 20);
            this.tbPatientName.TabIndex = 19;
            // 
            // lblPName
            // 
            this.lblPName.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.ForeColor = System.Drawing.Color.Black;
            this.lblPName.Location = new System.Drawing.Point(197, 67);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(90, 28);
            this.lblPName.TabIndex = 18;
            this.lblPName.Text = "Name :";
            // 
            // tbPatientUserId
            // 
            this.tbPatientUserId.Location = new System.Drawing.Point(412, 17);
            this.tbPatientUserId.Name = "tbPatientUserId";
            this.tbPatientUserId.Size = new System.Drawing.Size(209, 20);
            this.tbPatientUserId.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(197, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 28);
            this.label6.TabIndex = 31;
            this.label6.Text = "User Id:";
            // 
            // tbphone1
            // 
            this.tbphone1.Location = new System.Drawing.Point(421, 155);
            this.tbphone1.Name = "tbphone1";
            this.tbphone1.ReadOnly = true;
            this.tbphone1.Size = new System.Drawing.Size(35, 20);
            this.tbphone1.TabIndex = 62;
            this.tbphone1.Text = "+880";
            // 
            // tbphnnumber
            // 
            this.tbphnnumber.Location = new System.Drawing.Point(466, 155);
            this.tbphnnumber.Name = "tbphnnumber";
            this.tbphnnumber.Size = new System.Drawing.Size(151, 20);
            this.tbphnnumber.TabIndex = 61;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Navy;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 32);
            this.btnBack.TabIndex = 63;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnlogOut
            // 
            this.btnlogOut.BackColor = System.Drawing.Color.DarkRed;
            this.btnlogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogOut.ForeColor = System.Drawing.Color.White;
            this.btnlogOut.Location = new System.Drawing.Point(700, 9);
            this.btnlogOut.Name = "btnlogOut";
            this.btnlogOut.Size = new System.Drawing.Size(75, 28);
            this.btnlogOut.TabIndex = 64;
            this.btnlogOut.Text = "Logout";
            this.btnlogOut.UseVisualStyleBackColor = false;
            this.btnlogOut.Click += new System.EventHandler(this.btnlogOut_Click);
            // 
            // RegistrationPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 411);
            this.Controls.Add(this.btnlogOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbphone1);
            this.Controls.Add(this.tbphnnumber);
            this.Controls.Add(this.tbPatientUserId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPatientRegister);
            this.Controls.Add(this.tbPatientAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBlood);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPatientAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPatientName);
            this.Controls.Add(this.lblPName);
            this.Name = "RegistrationPatient";
            this.Text = "ManagePatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatientRegister;
        private System.Windows.Forms.TextBox tbPatientAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBlood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPatientAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPatientName;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.TextBox tbPatientUserId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbphone1;
        private System.Windows.Forms.TextBox tbphnnumber;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnlogOut;

    }
}