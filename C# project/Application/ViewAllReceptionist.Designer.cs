namespace App
{
    partial class ViewAllReceptionist
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
            this.tbphnnumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lblPName = new System.Windows.Forms.Label();
            this.tbsalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TableReceptionist = new System.Windows.Forms.DataGridView();
            this.tbid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateReceptionist = new System.Windows.Forms.Button();
            this.btndeleteReceptionist = new System.Windows.Forms.Button();
            this.btnViewAllReceptionist = new System.Windows.Forms.Button();
            this.tbphone1 = new System.Windows.Forms.TextBox();
            this.btnlogOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableReceptionist)).BeginInit();
            this.SuspendLayout();
            // 
            // tbphnnumber
            // 
            this.tbphnnumber.Location = new System.Drawing.Point(178, 149);
            this.tbphnnumber.Name = "tbphnnumber";
            this.tbphnnumber.Size = new System.Drawing.Size(147, 20);
            this.tbphnnumber.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 33);
            this.label7.TabIndex = 41;
            this.label7.Text = "Phone Number:";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(137, 110);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(188, 20);
            this.tbname.TabIndex = 40;
            // 
            // lblPName
            // 
            this.lblPName.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.ForeColor = System.Drawing.Color.Black;
            this.lblPName.Location = new System.Drawing.Point(5, 110);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(62, 33);
            this.lblPName.TabIndex = 39;
            this.lblPName.Text = "Name :";
            // 
            // tbsalary
            // 
            this.tbsalary.Location = new System.Drawing.Point(137, 188);
            this.tbsalary.Name = "tbsalary";
            this.tbsalary.Size = new System.Drawing.Size(188, 20);
            this.tbsalary.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 33);
            this.label1.TabIndex = 51;
            this.label1.Text = "Salary :";
            // 
            // tbaddress
            // 
            this.tbaddress.Location = new System.Drawing.Point(137, 237);
            this.tbaddress.Multiline = true;
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(212, 55);
            this.tbaddress.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 33);
            this.label5.TabIndex = 49;
            this.label5.Text = "Address :";
            // 
            // TableReceptionist
            // 
            this.TableReceptionist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableReceptionist.Location = new System.Drawing.Point(356, 57);
            this.TableReceptionist.Name = "TableReceptionist";
            this.TableReceptionist.Size = new System.Drawing.Size(416, 279);
            this.TableReceptionist.TabIndex = 53;
            this.TableReceptionist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableReceptionist_CellClick);
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(138, 62);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(187, 20);
            this.tbid.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 33);
            this.label6.TabIndex = 54;
            this.label6.Text = "ID:";
            // 
            // btnUpdateReceptionist
            // 
            this.btnUpdateReceptionist.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateReceptionist.Location = new System.Drawing.Point(12, 355);
            this.btnUpdateReceptionist.Name = "btnUpdateReceptionist";
            this.btnUpdateReceptionist.Size = new System.Drawing.Size(142, 35);
            this.btnUpdateReceptionist.TabIndex = 56;
            this.btnUpdateReceptionist.Text = "Update";
            this.btnUpdateReceptionist.UseVisualStyleBackColor = true;
            this.btnUpdateReceptionist.Click += new System.EventHandler(this.btnUpdateReceptionist_Click);
            // 
            // btndeleteReceptionist
            // 
            this.btndeleteReceptionist.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteReceptionist.Location = new System.Drawing.Point(189, 355);
            this.btndeleteReceptionist.Name = "btndeleteReceptionist";
            this.btndeleteReceptionist.Size = new System.Drawing.Size(179, 35);
            this.btndeleteReceptionist.TabIndex = 57;
            this.btndeleteReceptionist.Text = "Delete";
            this.btndeleteReceptionist.UseVisualStyleBackColor = true;
            this.btndeleteReceptionist.Click += new System.EventHandler(this.btndeleteReceptionist_Click);
            // 
            // btnViewAllReceptionist
            // 
            this.btnViewAllReceptionist.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllReceptionist.Location = new System.Drawing.Point(449, 355);
            this.btnViewAllReceptionist.Name = "btnViewAllReceptionist";
            this.btnViewAllReceptionist.Size = new System.Drawing.Size(288, 35);
            this.btnViewAllReceptionist.TabIndex = 58;
            this.btnViewAllReceptionist.Text = "View ALL";
            this.btnViewAllReceptionist.UseVisualStyleBackColor = true;
            this.btnViewAllReceptionist.Click += new System.EventHandler(this.btnViewAllReceptionist_Click);
            // 
            // tbphone1
            // 
            this.tbphone1.Location = new System.Drawing.Point(137, 149);
            this.tbphone1.Name = "tbphone1";
            this.tbphone1.ReadOnly = true;
            this.tbphone1.Size = new System.Drawing.Size(35, 20);
            this.tbphone1.TabIndex = 59;
            this.tbphone1.Text = "+880";
            // 
            // btnlogOut
            // 
            this.btnlogOut.BackColor = System.Drawing.Color.DarkRed;
            this.btnlogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogOut.ForeColor = System.Drawing.Color.White;
            this.btnlogOut.Location = new System.Drawing.Point(697, 12);
            this.btnlogOut.Name = "btnlogOut";
            this.btnlogOut.Size = new System.Drawing.Size(75, 28);
            this.btnlogOut.TabIndex = 60;
            this.btnlogOut.Text = "Logout";
            this.btnlogOut.UseVisualStyleBackColor = false;
            this.btnlogOut.Click += new System.EventHandler(this.btnlogOut_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Navy;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(10, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 32);
            this.btnBack.TabIndex = 61;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewAllReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnlogOut);
            this.Controls.Add(this.tbphone1);
            this.Controls.Add(this.btnViewAllReceptionist);
            this.Controls.Add(this.btndeleteReceptionist);
            this.Controls.Add(this.btnUpdateReceptionist);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TableReceptionist);
            this.Controls.Add(this.tbsalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbaddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbphnnumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lblPName);
            this.Name = "ViewAllReceptionist";
            this.Text = "ViewAllReceptionist";
            ((System.ComponentModel.ISupportInitialize)(this.TableReceptionist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbphnnumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.TextBox tbsalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView TableReceptionist;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateReceptionist;
        private System.Windows.Forms.Button btndeleteReceptionist;
        private System.Windows.Forms.Button btnViewAllReceptionist;
        private System.Windows.Forms.TextBox tbphone1;
        private System.Windows.Forms.Button btnlogOut;
        private System.Windows.Forms.Button btnBack;
    }
}