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
    public partial class DoctorProfile : Form
    {
       DoctorEntity dra;
       DoctorRepo dRepo;

        public DoctorProfile( DoctorEntity dra)
        {
            InitializeComponent();
           // dra = new DoctorEntity();
            this.dra = dra;
            tbuserid.Text = dra.UserId;
            dRepo = new DoctorRepo();
        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            WelcomePage dlf = new WelcomePage();
            this.Close();
            dlf.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DoctorHomePage d = new DoctorHomePage(dra);
            this.Close();
            d.Show();

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DoctorEntity d=dRepo.GetDoctor(dra.UserId);

           

                tbuserid.Text = d.UserId;
                tbname.Text = d.Name;
                tbaddress.Text = d.Address;
                tbDegree.Text = d.Degree;
                tbphnnumber.Text = d.PhoneNumber;
                textBox2.Text = d.Password;
                textBox3.Text = d.JoiningDate;
                textBox1.Text = d.Gender;
            
        }
    }
}
