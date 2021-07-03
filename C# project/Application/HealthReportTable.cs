using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class HealthReportTable : Form
    {
       
        public HealthReportTable()
        {
            InitializeComponent();
        }

        private void tbsearchreport_Click(object sender, EventArgs e)
        {
            if (tbsearchreport.Text == "Patient ID")
            {
                tbsearchreport.Text = "";
            }
        }

        private void tbsearchreport_Enter(object sender, EventArgs e)
        {
            if (tbsearchreport.Text == "Patient ID")
            {
                tbsearchreport.Text = "";
            }
            if (tbsearchreport.Text == "")
            {
                tbsearchreport.ForeColor = Color.Black;
            }

        }

        private void tbsearchreport_TextChanged(object sender, EventArgs e)
        {
            tbsearchreport.ForeColor = Color.Black;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CheckHealthStatus ch = new CheckHealthStatus();
            this.Close();
            ch.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }
    }
}
