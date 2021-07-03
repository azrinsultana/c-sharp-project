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
    public partial class ReceptionistHomePage : Form
    {
        public ReceptionistHomePage()
        {
            InitializeComponent();
          
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            RegistrationPatient rp = new RegistrationPatient();
            this.Visible = false;
            rp.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void btnManagePatient_Click(object sender, EventArgs e)
        {
            ManagePatient mp = new ManagePatient();
            mp.btnViewAllPatient_Click(sender, e);
           this.Hide();
           mp.Show();
        }

        private void btnDoctorList_Click(object sender, EventArgs e)
        {
            
            /*
            vd.btndelete.Hide();
            vd.btnUpdate.Hide();
            vd.btnViewAllDoctor.Hide();
           vd.btnViewAllDoctor_Click(sender, e);
             * */
           //this.Hide();
           // vd.Show();


        }

        private void btnReceptionistProfile_Click(object sender, EventArgs e)
        {
            ReceptionistProfile p = new ReceptionistProfile();
            this.Close();
            p.Show();

          
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            SetAppointment sa = new SetAppointment();
            this.Close();
            sa.Show();
        }

        private void ReceptionistHomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            WelcomePage lfr = new WelcomePage();
            this.Close();
            lfr.Show();
        }
    }
}
