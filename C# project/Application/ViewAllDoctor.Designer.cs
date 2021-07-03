namespace App
{
    partial class ViewAllDoctor
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
            this.btnViewAllDoctor = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.TableDoctor = new System.Windows.Forms.DataGridView();
            this.pnllbl = new System.Windows.Forms.Panel();
            this.tbDegree = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbphone1 = new System.Windows.Forms.TextBox();
            this.tbuserid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbphnnumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lblPName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnlogOut = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TableDoctor)).BeginInit();
            this.pnllbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewAllDoctor
            // 
            this.btnViewAllDoctor.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllDoctor.Location = new System.Drawing.Point(460, 316);
            this.btnViewAllDoctor.Name = "btnViewAllDoctor";
            this.btnViewAllDoctor.Size = new System.Drawing.Size(205, 35);
            this.btnViewAllDoctor.TabIndex = 73;
            this.btnViewAllDoctor.Text = "View ALL";
            this.btnViewAllDoctor.UseVisualStyleBackColor = true;
            this.btnViewAllDoctor.Click += new System.EventHandler(this.btnViewAllDoctor_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(194, 337);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(179, 35);
            this.btndelete.TabIndex = 72;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(17, 337);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 35);
            this.btnUpdate.TabIndex = 71;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // TableDoctor
            // 
            this.TableDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableDoctor.Location = new System.Drawing.Point(409, 39);
            this.TableDoctor.Name = "TableDoctor";
            this.TableDoctor.Size = new System.Drawing.Size(340, 271);
            this.TableDoctor.TabIndex = 68;
            this.TableDoctor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableDoctor_CellClick);
            // 
            // pnllbl
            // 
            this.pnllbl.Controls.Add(this.tbDegree);
            this.pnllbl.Controls.Add(this.label1);
            this.pnllbl.Controls.Add(this.radioButton2);
            this.pnllbl.Controls.Add(this.radioButton1);
            this.pnllbl.Controls.Add(this.tbaddress);
            this.pnllbl.Controls.Add(this.label5);
            this.pnllbl.Controls.Add(this.label3);
            this.pnllbl.Controls.Add(this.tbphone1);
            this.pnllbl.Controls.Add(this.tbuserid);
            this.pnllbl.Controls.Add(this.label6);
            this.pnllbl.Controls.Add(this.tbphnnumber);
            this.pnllbl.Controls.Add(this.label7);
            this.pnllbl.Controls.Add(this.tbname);
            this.pnllbl.Controls.Add(this.lblPName);
            this.pnllbl.Location = new System.Drawing.Point(41, 39);
            this.pnllbl.Name = "pnllbl";
            this.pnllbl.Size = new System.Drawing.Size(362, 283);
            this.pnllbl.TabIndex = 74;
            // 
            // tbDegree
            // 
            this.tbDegree.Location = new System.Drawing.Point(143, 171);
            this.tbDegree.Multiline = true;
            this.tbDegree.Name = "tbDegree";
            this.tbDegree.Size = new System.Drawing.Size(195, 33);
            this.tbDegree.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 97;
            this.label1.Text = "Degree:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(226, 112);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 31);
            this.radioButton2.TabIndex = 96;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(158, 112);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 31);
            this.radioButton1.TabIndex = 95;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tbaddress
            // 
            this.tbaddress.Location = new System.Drawing.Point(143, 210);
            this.tbaddress.Multiline = true;
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(212, 55);
            this.tbaddress.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 28);
            this.label5.TabIndex = 93;
            this.label5.Text = "Address :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 92;
            this.label3.Text = "Gender :";
            // 
            // tbphone1
            // 
            this.tbphone1.Location = new System.Drawing.Point(143, 86);
            this.tbphone1.Name = "tbphone1";
            this.tbphone1.ReadOnly = true;
            this.tbphone1.Size = new System.Drawing.Size(35, 20);
            this.tbphone1.TabIndex = 91;
            this.tbphone1.Text = "+880";
            // 
            // tbuserid
            // 
            this.tbuserid.Location = new System.Drawing.Point(143, 8);
            this.tbuserid.Name = "tbuserid";
            this.tbuserid.Size = new System.Drawing.Size(187, 20);
            this.tbuserid.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 89;
            this.label6.Text = "User Id:";
            // 
            // tbphnnumber
            // 
            this.tbphnnumber.Location = new System.Drawing.Point(184, 86);
            this.tbphnnumber.Name = "tbphnnumber";
            this.tbphnnumber.Size = new System.Drawing.Size(147, 20);
            this.tbphnnumber.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(9, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 27);
            this.label7.TabIndex = 87;
            this.label7.Text = "Phone Number:";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(142, 35);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(188, 20);
            this.tbname.TabIndex = 86;
            // 
            // lblPName
            // 
            this.lblPName.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.ForeColor = System.Drawing.Color.Black;
            this.lblPName.Location = new System.Drawing.Point(11, 35);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(62, 24);
            this.lblPName.TabIndex = 85;
            this.lblPName.Text = "Name :";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Navy;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(-1, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 32);
            this.btnBack.TabIndex = 75;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnlogOut
            // 
            this.btnlogOut.BackColor = System.Drawing.Color.DarkRed;
            this.btnlogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogOut.ForeColor = System.Drawing.Color.White;
            this.btnlogOut.Location = new System.Drawing.Point(697, 1);
            this.btnlogOut.Name = "btnlogOut";
            this.btnlogOut.Size = new System.Drawing.Size(75, 28);
            this.btnlogOut.TabIndex = 76;
            this.btnlogOut.Text = "Logout";
            this.btnlogOut.UseVisualStyleBackColor = false;
            this.btnlogOut.Click += new System.EventHandler(this.btnlogOut_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(557, 367);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(196, 20);
            this.textBox5.TabIndex = 78;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(434, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 77;
            this.label2.Text = "Search Doctor";
            // 
            // ViewAllDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlogOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnllbl);
            this.Controls.Add(this.btnViewAllDoctor);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.TableDoctor);
            this.Name = "ViewAllDoctor";
            this.Text = "ViewAllDoctor";
            ((System.ComponentModel.ISupportInitialize)(this.TableDoctor)).EndInit();
            this.pnllbl.ResumeLayout(false);
            this.pnllbl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableDoctor;
        private System.Windows.Forms.Panel pnllbl;
        private System.Windows.Forms.TextBox tbDegree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbphone1;
        private System.Windows.Forms.TextBox tbuserid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbphnnumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lblPName;
        public System.Windows.Forms.Button btnViewAllDoctor;
        public System.Windows.Forms.Button btndelete;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnlogOut;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
    }
}