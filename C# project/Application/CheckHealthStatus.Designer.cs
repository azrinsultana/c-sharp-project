namespace App
{
    partial class CheckHealthStatus
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
            this.btnBMI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btncalorie = new System.Windows.Forms.Button();
            this.btnhealthreport = new System.Windows.Forms.Button();
            this.pnlBMI = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBmiShow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBmiCalculate = new System.Windows.Forms.Button();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbHeightInch = new System.Windows.Forms.TextBox();
            this.tBHeightFoot = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.pnlCalorie = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbcalShow = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalloriecal = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbHeightInFt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlBMI.SuspendLayout();
            this.pnlCalorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBMI
            // 
            this.btnBMI.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBMI.Location = new System.Drawing.Point(11, 122);
            this.btnBMI.Margin = new System.Windows.Forms.Padding(2);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(135, 61);
            this.btnBMI.TabIndex = 0;
            this.btnBMI.Text = "Check BMI";
            this.btnBMI.UseVisualStyleBackColor = false;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(245, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Check Health Report";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.btnlogOut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 66);
            this.panel1.TabIndex = 2;
            // 
            // btnlogOut
            // 
            this.btnlogOut.BackColor = System.Drawing.Color.Maroon;
            this.btnlogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogOut.ForeColor = System.Drawing.Color.White;
            this.btnlogOut.Location = new System.Drawing.Point(696, 3);
            this.btnlogOut.Name = "btnlogOut";
            this.btnlogOut.Size = new System.Drawing.Size(75, 23);
            this.btnlogOut.TabIndex = 103;
            this.btnlogOut.Text = "Logout";
            this.btnlogOut.UseVisualStyleBackColor = false;
            this.btnlogOut.Click += new System.EventHandler(this.btnlogOut_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Navy;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(3, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 32);
            this.btnBack.TabIndex = 102;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btncalorie
            // 
            this.btncalorie.BackColor = System.Drawing.Color.YellowGreen;
            this.btncalorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalorie.Location = new System.Drawing.Point(11, 212);
            this.btncalorie.Margin = new System.Windows.Forms.Padding(2);
            this.btncalorie.Name = "btncalorie";
            this.btncalorie.Size = new System.Drawing.Size(135, 61);
            this.btncalorie.TabIndex = 3;
            this.btncalorie.Text = "Check Calorie";
            this.btncalorie.UseVisualStyleBackColor = false;
            this.btncalorie.Click += new System.EventHandler(this.btncalorie_Click);
            // 
            // btnhealthreport
            // 
            this.btnhealthreport.BackColor = System.Drawing.Color.YellowGreen;
            this.btnhealthreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhealthreport.Location = new System.Drawing.Point(9, 291);
            this.btnhealthreport.Margin = new System.Windows.Forms.Padding(2);
            this.btnhealthreport.Name = "btnhealthreport";
            this.btnhealthreport.Size = new System.Drawing.Size(137, 61);
            this.btnhealthreport.TabIndex = 4;
            this.btnhealthreport.Text = "Health Report";
            this.btnhealthreport.UseVisualStyleBackColor = false;
            this.btnhealthreport.Click += new System.EventHandler(this.btnhealthreport_Click);
            // 
            // pnlBMI
            // 
            this.pnlBMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(82)))));
            this.pnlBMI.Controls.Add(this.label5);
            this.pnlBMI.Controls.Add(this.label4);
            this.pnlBMI.Controls.Add(this.tbBmiShow);
            this.pnlBMI.Controls.Add(this.label3);
            this.pnlBMI.Controls.Add(this.btnBmiCalculate);
            this.pnlBMI.Controls.Add(this.tbWeight);
            this.pnlBMI.Controls.Add(this.label2);
            this.pnlBMI.Controls.Add(this.TbHeightInch);
            this.pnlBMI.Controls.Add(this.tBHeightFoot);
            this.pnlBMI.Controls.Add(this.lblHeight);
            this.pnlBMI.Location = new System.Drawing.Point(574, 151);
            this.pnlBMI.Name = "pnlBMI";
            this.pnlBMI.Size = new System.Drawing.Size(306, 283);
            this.pnlBMI.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(72, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 23);
            this.label5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "BMI Calculation";
            // 
            // tbBmiShow
            // 
            this.tbBmiShow.Location = new System.Drawing.Point(104, 195);
            this.tbBmiShow.Name = "tbBmiShow";
            this.tbBmiShow.Size = new System.Drawing.Size(65, 20);
            this.tbBmiShow.TabIndex = 7;
            this.tbBmiShow.TextChanged += new System.EventHandler(this.tbBmiShow_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "BMI :";
            // 
            // btnBmiCalculate
            // 
            this.btnBmiCalculate.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBmiCalculate.Location = new System.Drawing.Point(104, 135);
            this.btnBmiCalculate.Name = "btnBmiCalculate";
            this.btnBmiCalculate.Size = new System.Drawing.Size(106, 35);
            this.btnBmiCalculate.TabIndex = 5;
            this.btnBmiCalculate.Text = "Calculate";
            this.btnBmiCalculate.UseVisualStyleBackColor = true;
            this.btnBmiCalculate.Click += new System.EventHandler(this.btnBmiCalculate_Click);
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(123, 98);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(68, 20);
            this.tbWeight.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weight :";
            // 
            // TbHeightInch
            // 
            this.TbHeightInch.Location = new System.Drawing.Point(212, 53);
            this.TbHeightInch.Name = "TbHeightInch";
            this.TbHeightInch.Size = new System.Drawing.Size(68, 20);
            this.TbHeightInch.TabIndex = 2;
            // 
            // tBHeightFoot
            // 
            this.tBHeightFoot.Location = new System.Drawing.Point(123, 53);
            this.tBHeightFoot.Name = "tBHeightFoot";
            this.tBHeightFoot.Size = new System.Drawing.Size(68, 20);
            this.tBHeightFoot.TabIndex = 1;
            this.tBHeightFoot.TextChanged += new System.EventHandler(this.tBHeightFoot_TextChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.ForeColor = System.Drawing.Color.White;
            this.lblHeight.Location = new System.Drawing.Point(24, 53);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(85, 38);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Height :";
            // 
            // pnlCalorie
            // 
            this.pnlCalorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(82)))));
            this.pnlCalorie.Controls.Add(this.button1);
            this.pnlCalorie.Controls.Add(this.label6);
            this.pnlCalorie.Controls.Add(this.label7);
            this.pnlCalorie.Controls.Add(this.tbcalShow);
            this.pnlCalorie.Controls.Add(this.label8);
            this.pnlCalorie.Controls.Add(this.btnCalloriecal);
            this.pnlCalorie.Controls.Add(this.textBox3);
            this.pnlCalorie.Controls.Add(this.tbHeightInFt);
            this.pnlCalorie.Controls.Add(this.label10);
            this.pnlCalorie.Location = new System.Drawing.Point(173, 116);
            this.pnlCalorie.Name = "pnlCalorie";
            this.pnlCalorie.Size = new System.Drawing.Size(306, 283);
            this.pnlCalorie.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(95, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Diet Chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(75, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 23);
            this.label6.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(32, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 37);
            this.label7.TabIndex = 8;
            this.label7.Text = "Daily Calorie Intake";
            // 
            // tbcalShow
            // 
            this.tbcalShow.Location = new System.Drawing.Point(121, 195);
            this.tbcalShow.Name = "tbcalShow";
            this.tbcalShow.Size = new System.Drawing.Size(65, 20);
            this.tbcalShow.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 31);
            this.label8.TabIndex = 6;
            this.label8.Text = "Calorie :";
            // 
            // btnCalloriecal
            // 
            this.btnCalloriecal.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalloriecal.Location = new System.Drawing.Point(95, 135);
            this.btnCalloriecal.Name = "btnCalloriecal";
            this.btnCalloriecal.Size = new System.Drawing.Size(106, 35);
            this.btnCalloriecal.TabIndex = 5;
            this.btnCalloriecal.Text = "Calculate";
            this.btnCalloriecal.UseVisualStyleBackColor = true;
            this.btnCalloriecal.Click += new System.EventHandler(this.btnCalloriecal_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(221, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 20);
            this.textBox3.TabIndex = 2;
            // 
            // tbHeightInFt
            // 
            this.tbHeightInFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeightInFt.ForeColor = System.Drawing.Color.Black;
            this.tbHeightInFt.Location = new System.Drawing.Point(121, 71);
            this.tbHeightInFt.Name = "tbHeightInFt";
            this.tbHeightInFt.Size = new System.Drawing.Size(68, 22);
            this.tbHeightInFt.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(22, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 38);
            this.label10.TabIndex = 0;
            this.label10.Text = "Height :";
            // 
            // CheckHealthStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 534);
            this.Controls.Add(this.pnlCalorie);
            this.Controls.Add(this.pnlBMI);
            this.Controls.Add(this.btnhealthreport);
            this.Controls.Add(this.btncalorie);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBMI);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CheckHealthStatus";
            this.Text = "CheckHealthStatus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBMI.ResumeLayout(false);
            this.pnlBMI.PerformLayout();
            this.pnlCalorie.ResumeLayout(false);
            this.pnlCalorie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncalorie;
        private System.Windows.Forms.Button btnhealthreport;
        private System.Windows.Forms.Panel pnlBMI;
        private System.Windows.Forms.Button btnBmiCalculate;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbHeightInch;
        private System.Windows.Forms.TextBox tBHeightFoot;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBmiShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnlogOut;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlCalorie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalloriecal;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbHeightInFt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbcalShow;
        private System.Windows.Forms.Button button1;
    }
}