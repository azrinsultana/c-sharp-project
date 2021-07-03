namespace App
{
    partial class AdminHomePage
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
            this.lblwelcomeadmin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddReceptionist = new System.Windows.Forms.Button();
            this.btnViewReceptionistList = new System.Windows.Forms.Button();
            this.btnViewDoctor = new System.Windows.Forms.Button();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.btnlogOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnmanagereceptionish = new System.Windows.Forms.Button();
            this.btnmanagedoctor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblwelcomeadmin
            // 
            this.lblwelcomeadmin.BackColor = System.Drawing.Color.Teal;
            this.lblwelcomeadmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblwelcomeadmin.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcomeadmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblwelcomeadmin.Location = new System.Drawing.Point(0, 0);
            this.lblwelcomeadmin.Name = "lblwelcomeadmin";
            this.lblwelcomeadmin.Size = new System.Drawing.Size(784, 61);
            this.lblwelcomeadmin.TabIndex = 0;
            this.lblwelcomeadmin.Text = "Welcome Admin";
            this.lblwelcomeadmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Manage Receptionist";
            // 
            // btnAddReceptionist
            // 
            this.btnAddReceptionist.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddReceptionist.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReceptionist.ForeColor = System.Drawing.Color.White;
            this.btnAddReceptionist.Location = new System.Drawing.Point(382, 269);
            this.btnAddReceptionist.Name = "btnAddReceptionist";
            this.btnAddReceptionist.Size = new System.Drawing.Size(129, 30);
            this.btnAddReceptionist.TabIndex = 7;
            this.btnAddReceptionist.Text = "Add Receptionist";
            this.btnAddReceptionist.UseVisualStyleBackColor = false;
            this.btnAddReceptionist.Click += new System.EventHandler(this.btnAddReceptionist_Click);
            // 
            // btnViewReceptionistList
            // 
            this.btnViewReceptionistList.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnViewReceptionistList.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReceptionistList.ForeColor = System.Drawing.Color.White;
            this.btnViewReceptionistList.Location = new System.Drawing.Point(382, 233);
            this.btnViewReceptionistList.Name = "btnViewReceptionistList";
            this.btnViewReceptionistList.Size = new System.Drawing.Size(129, 30);
            this.btnViewReceptionistList.TabIndex = 8;
            this.btnViewReceptionistList.Text = "View Receptionist ";
            this.btnViewReceptionistList.UseVisualStyleBackColor = false;
            this.btnViewReceptionistList.Click += new System.EventHandler(this.btnViewReceptionistList_Click);
            // 
            // btnViewDoctor
            // 
            this.btnViewDoctor.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnViewDoctor.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDoctor.ForeColor = System.Drawing.Color.White;
            this.btnViewDoctor.Location = new System.Drawing.Point(176, 233);
            this.btnViewDoctor.Name = "btnViewDoctor";
            this.btnViewDoctor.Size = new System.Drawing.Size(129, 30);
            this.btnViewDoctor.TabIndex = 10;
            this.btnViewDoctor.Text = "View Doctor";
            this.btnViewDoctor.UseVisualStyleBackColor = false;
            this.btnViewDoctor.Click += new System.EventHandler(this.btnViewDoctor_Click);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddDoctor.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDoctor.ForeColor = System.Drawing.Color.White;
            this.btnAddDoctor.Location = new System.Drawing.Point(176, 269);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(129, 30);
            this.btnAddDoctor.TabIndex = 9;
            this.btnAddDoctor.Text = "Add Doctor";
            this.btnAddDoctor.UseVisualStyleBackColor = false;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // btnlogOut
            // 
            this.btnlogOut.BackColor = System.Drawing.Color.DarkRed;
            this.btnlogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogOut.ForeColor = System.Drawing.Color.White;
            this.btnlogOut.Location = new System.Drawing.Point(697, 12);
            this.btnlogOut.Name = "btnlogOut";
            this.btnlogOut.Size = new System.Drawing.Size(75, 23);
            this.btnlogOut.TabIndex = 42;
            this.btnlogOut.Text = "Logout";
            this.btnlogOut.UseVisualStyleBackColor = false;
            this.btnlogOut.Click += new System.EventHandler(this.btnlogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Navy;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(4, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 43;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnmanagereceptionish
            // 
            this.btnmanagereceptionish.BackgroundImage = global::App.Properties.Resources.receptionist_icon_transparent;
            this.btnmanagereceptionish.Location = new System.Drawing.Point(392, 148);
            this.btnmanagereceptionish.Name = "btnmanagereceptionish";
            this.btnmanagereceptionish.Size = new System.Drawing.Size(112, 79);
            this.btnmanagereceptionish.TabIndex = 2;
            this.btnmanagereceptionish.UseVisualStyleBackColor = true;
            this.btnmanagereceptionish.MouseHover += new System.EventHandler(this.btnmanagereceptionish_MouseHover);
            // 
            // btnmanagedoctor
            // 
            this.btnmanagedoctor.BackgroundImage = global::App.Properties.Resources.Doctor_icon2;
            this.btnmanagedoctor.Location = new System.Drawing.Point(185, 148);
            this.btnmanagedoctor.Name = "btnmanagedoctor";
            this.btnmanagedoctor.Size = new System.Drawing.Size(112, 79);
            this.btnmanagedoctor.TabIndex = 1;
            this.btnmanagedoctor.UseVisualStyleBackColor = true;
            this.btnmanagedoctor.MouseEnter += new System.EventHandler(this.btnmanagedoctor_MouseEnter);
            this.btnmanagedoctor.MouseHover += new System.EventHandler(this.btnmanagedoctor_MouseHover);
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnlogOut);
            this.Controls.Add(this.btnViewDoctor);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.btnViewReceptionistList);
            this.Controls.Add(this.btnAddReceptionist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnmanagereceptionish);
            this.Controls.Add(this.btnmanagedoctor);
            this.Controls.Add(this.lblwelcomeadmin);
            this.Name = "AdminHomePage";
            this.Text = "AdminHomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwelcomeadmin;
        private System.Windows.Forms.Button btnmanagedoctor;
        private System.Windows.Forms.Button btnmanagereceptionish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddReceptionist;
        private System.Windows.Forms.Button btnViewReceptionistList;
        private System.Windows.Forms.Button btnViewDoctor;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Button btnlogOut;
        private System.Windows.Forms.Button btnExit;
    }
}