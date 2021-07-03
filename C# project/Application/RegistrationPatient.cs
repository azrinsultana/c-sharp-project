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
    public partial class RegistrationPatient : Form
    {
        PatientEntity p;
        PatientRepo pr;

        public RegistrationPatient()
        {
            InitializeComponent();
            p = new PatientEntity();
            pr = new PatientRepo();
        }

        private void btnPatientRegister_Click(object sender, EventArgs e)
        {
            try{


            p.UserId = tbPatientUserId.Text;
            p.Name = tbPatientName.Text;
            p.Age =Convert.ToInt32( tbPatientAge.Text);
            p.Address = tbPatientAddress.Text;
            p.PhoneNumber = tbphone1.Text + tbphnnumber.Text;
            if (radioButton1.Checked)
            {
                p.Gender = "Male";
            }
            else
            {
                p.Gender = "Female";
            }
            p.BloodGroup = cmbBlood.SelectedItem.ToString();

             
                if (pr.InsertPatient(p))
                {
                    
                        MessageBox.Show("Patient Added. User Id : " + p.UserId);
                      // RegistrationPatient rp=new RegistrationPatient();
                       ReceptionistHomePage rhp = new ReceptionistHomePage();
                        this.Hide();
                        rhp.Show();
                    
                }
                else
                {
                    MessageBox.Show("Can Not Add  ");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ReceptionistHomePage rhp = new ReceptionistHomePage();
            this.Close();
            rhp.Show();
        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            WelcomePage lrf = new WelcomePage();
            this.Close();
            lrf.Show();
        }

      
     
    }
}
