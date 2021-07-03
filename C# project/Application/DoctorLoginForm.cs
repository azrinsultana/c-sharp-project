using Entity;
using Repository;
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
    public partial class DoctorLoginForm : Form
    {
        DoctorEntity d;
        DoctorRepo dr;
        public DoctorLoginForm()
        {
            InitializeComponent();
            d = new DoctorEntity();
            dr = new DoctorRepo();
        }

        private void btnLogingDoctor_Click(object sender, EventArgs e)
        {
            string u = TbUsername.Text;
            string p = TBPassword.Text;
            d = dr.GetUser(u, p);
            if (d != null)
            {
                DoctorHomePage dp = new DoctorHomePage(d);
                this.Visible = false;
                dp.Visible = true;
            }
            else
                MessageBox.Show("Invali userid or pass");

}

        private void btnBack_Click(object sender, EventArgs e)
        {

            WelcomePage wp = new WelcomePage();
            this.Close();
            wp.Show();
        }
        
}
}