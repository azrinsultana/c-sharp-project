namespace App
{
    partial class ManagePatient
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdatePatient = new System.Windows.Forms.Button();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.PatientTable = new System.Windows.Forms.DataGridView();
            this.pnlmanagepatient = new System.Windows.Forms.Panel();
            this.btnDeletePnl = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.tbphone1 = new System.Windows.Forms.TextBox();
            this.tbphnnumber = new System.Windows.Forms.TextBox();
            this.tbPatientUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPatientAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBlood = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPatientAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPatientName = new System.Windows.Forms.TextBox();
            this.lblPName = new System.Windows.Forms.Label();
            this.btnViewAllPatient = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnlogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PatientTable)).BeginInit();
            this.pnlmanagepatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(563, 369);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(196, 20);
            this.textBox5.TabIndex = 34;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(440, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 28);
            this.label6.TabIndex = 33;
            this.label6.Text = "Search Patient";
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdatePatient.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePatient.ForeColor = System.Drawing.Color.Black;
            this.btnUpdatePatient.Location = new System.Drawing.Point(184, 366);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(140, 34);
            this.btnUpdatePatient.TabIndex = 35;
            this.btnUpdatePatient.Text = "Update Patient";
            this.btnUpdatePatient.UseVisualStyleBackColor = false;
            this.btnUpdatePatient.Click += new System.EventHandler(this.btnUpdatePatient_Click);
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDeletePatient.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePatient.Location = new System.Drawing.Point(38, 366);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(140, 34);
            this.btnDeletePatient.TabIndex = 36;
            this.btnDeletePatient.Text = "Delete Patient";
            this.btnDeletePatient.UseVisualStyleBackColor = false;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // PatientTable
            // 
            this.PatientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientTable.Location = new System.Drawing.Point(38, 31);
            this.PatientTable.Name = "PatientTable";
            this.PatientTable.Size = new System.Drawing.Size(721, 323);
            this.PatientTable.TabIndex = 37;
            this.PatientTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientTable_CellClick);
       //     this.PatientTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientTable_CellContentClick);
            // 
            // pnlmanagepatient
            // 
            this.pnlmanagepatient.Controls.Add(this.btnDeletePnl);
            this.pnlmanagepatient.Controls.Add(this.btnDone);
            this.pnlmanagepatient.Controls.Add(this.tbphone1);
            this.pnlmanagepatient.Controls.Add(this.tbphnnumber);
            this.pnlmanagepatient.Controls.Add(this.tbPatientUserId);
            this.pnlmanagepatient.Controls.Add(this.label1);
            this.pnlmanagepatient.Controls.Add(this.tbPatientAddress);
            this.pnlmanagepatient.Controls.Add(this.label5);
            this.pnlmanagepatient.Controls.Add(this.cmbBlood);
            this.pnlmanagepatient.Controls.Add(this.label4);
            this.pnlmanagepatient.Controls.Add(this.radioButton3);
            this.pnlmanagepatient.Controls.Add(this.radioButton1);
            this.pnlmanagepatient.Controls.Add(this.label3);
            this.pnlmanagepatient.Controls.Add(this.tbPatientAge);
            this.pnlmanagepatient.Controls.Add(this.label2);
            this.pnlmanagepatient.Controls.Add(this.label7);
            this.pnlmanagepatient.Controls.Add(this.tbPatientName);
            this.pnlmanagepatient.Controls.Add(this.lblPName);
            this.pnlmanagepatient.Location = new System.Drawing.Point(159, 44);
            this.pnlmanagepatient.Name = "pnlmanagepatient";
            this.pnlmanagepatient.Size = new System.Drawing.Size(513, 298);
            this.pnlmanagepatient.TabIndex = 38;
            this.pnlmanagepatient.Visible = false;
            // 
            // btnDeletePnl
            // 
            this.btnDeletePnl.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePnl.Location = new System.Drawing.Point(118, 238);
            this.btnDeletePnl.Name = "btnDeletePnl";
            this.btnDeletePnl.Size = new System.Drawing.Size(234, 27);
            this.btnDeletePnl.TabIndex = 80;
            this.btnDeletePnl.Text = "Done";
            this.btnDeletePnl.UseVisualStyleBackColor = true;
            this.btnDeletePnl.Click += new System.EventHandler(this.btnDeletePnl_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(118, 261);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(234, 27);
            this.btnDone.TabIndex = 79;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // tbphone1
            // 
            this.tbphone1.Location = new System.Drawing.Point(264, 94);
            this.tbphone1.Name = "tbphone1";
            this.tbphone1.ReadOnly = true;
            this.tbphone1.Size = new System.Drawing.Size(35, 20);
            this.tbphone1.TabIndex = 78;
            this.tbphone1.Text = "+880";
            // 
            // tbphnnumber
            // 
            this.tbphnnumber.Location = new System.Drawing.Point(305, 94);
            this.tbphnnumber.Name = "tbphnnumber";
            this.tbphnnumber.Size = new System.Drawing.Size(151, 20);
            this.tbphnnumber.TabIndex = 77;
            // 
            // tbPatientUserId
            // 
            this.tbPatientUserId.Location = new System.Drawing.Point(247, 16);
            this.tbPatientUserId.Name = "tbPatientUserId";
            this.tbPatientUserId.Size = new System.Drawing.Size(209, 20);
            this.tbPatientUserId.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(58, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 28);
            this.label1.TabIndex = 75;
            this.label1.Text = "User Id:";
            // 
            // tbPatientAddress
            // 
            this.tbPatientAddress.Location = new System.Drawing.Point(247, 181);
            this.tbPatientAddress.Multiline = true;
            this.tbPatientAddress.Name = "tbPatientAddress";
            this.tbPatientAddress.Size = new System.Drawing.Size(209, 40);
            this.tbPatientAddress.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(61, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 73;
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
            this.cmbBlood.Location = new System.Drawing.Point(247, 154);
            this.cmbBlood.Name = "cmbBlood";
            this.cmbBlood.Size = new System.Drawing.Size(209, 21);
            this.cmbBlood.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(58, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 71;
            this.label4.Text = "Blood Group :";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.Red;
            this.radioButton3.Location = new System.Drawing.Point(354, 123);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 35);
            this.radioButton3.TabIndex = 70;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Female";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Red;
            this.radioButton1.Location = new System.Drawing.Point(283, 123);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 35);
            this.radioButton1.TabIndex = 69;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(61, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 68;
            this.label3.Text = "Gender :";
            // 
            // tbPatientAge
            // 
            this.tbPatientAge.Location = new System.Drawing.Point(247, 68);
            this.tbPatientAge.Name = "tbPatientAge";
            this.tbPatientAge.Size = new System.Drawing.Size(209, 20);
            this.tbPatientAge.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(58, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 33);
            this.label2.TabIndex = 66;
            this.label2.Text = "Age :";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(61, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 25);
            this.label7.TabIndex = 65;
            this.label7.Text = "Phone Number:";
            // 
            // tbPatientName
            // 
            this.tbPatientName.Location = new System.Drawing.Point(247, 42);
            this.tbPatientName.Name = "tbPatientName";
            this.tbPatientName.Size = new System.Drawing.Size(209, 20);
            this.tbPatientName.TabIndex = 64;
            // 
            // lblPName
            // 
            this.lblPName.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.ForeColor = System.Drawing.Color.Black;
            this.lblPName.Location = new System.Drawing.Point(61, 46);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(90, 28);
            this.lblPName.TabIndex = 63;
            this.lblPName.Text = "Name :";
            // 
            // btnViewAllPatient
            // 
            this.btnViewAllPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllPatient.Location = new System.Drawing.Point(330, 371);
            this.btnViewAllPatient.Name = "btnViewAllPatient";
            this.btnViewAllPatient.Size = new System.Drawing.Size(113, 23);
            this.btnViewAllPatient.TabIndex = 39;
            this.btnViewAllPatient.Text = "View All";
            this.btnViewAllPatient.UseVisualStyleBackColor = true;
            this.btnViewAllPatient.Click += new System.EventHandler(this.btnViewAllPatient_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Navy;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnlogOut
            // 
            this.btnlogOut.BackColor = System.Drawing.Color.DarkRed;
            this.btnlogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogOut.ForeColor = System.Drawing.Color.White;
            this.btnlogOut.Location = new System.Drawing.Point(684, 2);
            this.btnlogOut.Name = "btnlogOut";
            this.btnlogOut.Size = new System.Drawing.Size(75, 23);
            this.btnlogOut.TabIndex = 41;
            this.btnlogOut.Text = "Logout";
            this.btnlogOut.UseVisualStyleBackColor = false;
            this.btnlogOut.Click += new System.EventHandler(this.btnlogOut_Click);
            // 
            // ManagePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnlogOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewAllPatient);
            this.Controls.Add(this.pnlmanagepatient);
            this.Controls.Add(this.PatientTable);
            this.Controls.Add(this.btnUpdatePatient);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Name = "ManagePatient";
            this.Text = "ManagePatient";
            ((System.ComponentModel.ISupportInitialize)(this.PatientTable)).EndInit();
            this.pnlmanagepatient.ResumeLayout(false);
            this.pnlmanagepatient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdatePatient;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Panel pnlmanagepatient;
        public System.Windows.Forms.DataGridView PatientTable;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox tbphone1;
        private System.Windows.Forms.TextBox tbphnnumber;
        private System.Windows.Forms.TextBox tbPatientUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPatientAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBlood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPatientAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPatientName;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Button btnDeletePnl;
        private System.Windows.Forms.Button btnViewAllPatient;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnlogOut;
    }
}