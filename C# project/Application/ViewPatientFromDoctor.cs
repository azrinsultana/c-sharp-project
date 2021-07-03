using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class ViewPatientFromDoctor : Form
    {
        DoctorEntity dra;
        public ViewPatientFromDoctor()
        {
            InitializeComponent();
        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            WelcomePage d = new WelcomePage();
            this.Close();
            d.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DoctorHomePage d = new DoctorHomePage(dra);
            this.Close();
            d.Show();
        }
    }
}
