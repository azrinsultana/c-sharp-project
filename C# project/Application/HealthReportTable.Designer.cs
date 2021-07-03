namespace App
{
    partial class HealthReportTable
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.tablehealthreport = new System.Windows.Forms.DataGridView();
            this.lblsearchreport = new System.Windows.Forms.Label();
            this.tbsearchreport = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablehealthreport)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.Teal;
            this.lbltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltitle.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltitle.Location = new System.Drawing.Point(0, 0);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(784, 50);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Patient Health Status Report";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablehealthreport
            // 
            this.tablehealthreport.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.tablehealthreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablehealthreport.Location = new System.Drawing.Point(23, 63);
            this.tablehealthreport.Margin = new System.Windows.Forms.Padding(2);
            this.tablehealthreport.Name = "tablehealthreport";
            this.tablehealthreport.RowTemplate.Height = 24;
            this.tablehealthreport.Size = new System.Drawing.Size(720, 275);
            this.tablehealthreport.TabIndex = 1;
            // 
            // lblsearchreport
            // 
            this.lblsearchreport.BackColor = System.Drawing.Color.Teal;
            this.lblsearchreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchreport.ForeColor = System.Drawing.SystemColors.Control;
            this.lblsearchreport.Location = new System.Drawing.Point(31, 351);
            this.lblsearchreport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsearchreport.Name = "lblsearchreport";
            this.lblsearchreport.Size = new System.Drawing.Size(183, 27);
            this.lblsearchreport.TabIndex = 2;
            this.lblsearchreport.Text = "See Individual Report";
            this.lblsearchreport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbsearchreport
            // 
            this.tbsearchreport.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsearchreport.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbsearchreport.Location = new System.Drawing.Point(231, 351);
            this.tbsearchreport.Margin = new System.Windows.Forms.Padding(2);
            this.tbsearchreport.Multiline = true;
            this.tbsearchreport.Name = "tbsearchreport";
            this.tbsearchreport.Size = new System.Drawing.Size(192, 28);
            this.tbsearchreport.TabIndex = 3;
            this.tbsearchreport.Text = "Patient ID";
            this.tbsearchreport.WordWrap = false;
            this.tbsearchreport.Click += new System.EventHandler(this.tbsearchreport_Click);
            this.tbsearchreport.TextChanged += new System.EventHandler(this.tbsearchreport_TextChanged);
            this.tbsearchreport.Enter += new System.EventHandler(this.tbsearchreport_Enter);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Navy;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(5, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 32);
            this.btnBack.TabIndex = 103;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 104;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HealthReportTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbsearchreport);
            this.Controls.Add(this.lblsearchreport);
            this.Controls.Add(this.tablehealthreport);
            this.Controls.Add(this.lbltitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HealthReportTable";
            this.Text = "HealthReportTable";
            ((System.ComponentModel.ISupportInitialize)(this.tablehealthreport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblsearchreport;
        private System.Windows.Forms.TextBox tbsearchreport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.DataGridView tablehealthreport;
    }
}