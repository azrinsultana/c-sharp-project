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
    public partial class Adddoctor : Form
    {
        internal Admin admin;
        DoctorEntity d;
        DoctorRepo dr;
        public Adddoctor()
        {
            InitializeComponent();
            d = new DoctorEntity();
            dr = new DoctorRepo();
        }

        private void btnDone_Click(object sender, EventArgs e)
        { int p = new Random().Next(99999999)+10000000;
        try
        {
            d.UserId = tbuserid.Text;
            d.Password = p + "";

            d.Name = this.tbname.Text;
            // r.Name = this.EmpNameTB.Text;

            d.PhoneNumber = tbphone1.Text + tbphnnumber.Text;
            d.Degree = tbDegree.Text;
            d.Address = this.tbaddress.Text;
            d.JoiningDate = this.dateTimePicker1.Value.Date.ToShortDateString();
            if (radioButton1.Checked)
            {
                d.Gender = "Male";
            }
            else
            {
                d.Gender = "Female";
            }




            if (dr.InsertDoctor(d))
            {

                MessageBox.Show("Doctor Added. Id : " + d.UserId + " & Password : " + d.Password);


            }
            else
            {
                MessageBox.Show("Can Not Add  " + d.JoiningDate + d.Gender);
            }
        }
        catch (Exception exp)
        {
            MessageBox.Show("Invalid Data");
        }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHomePage ahp = new AdminHomePage(admin);
            this.Close();
            ahp.Show();
        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            WelcomePage lf = new WelcomePage();
            this.Close();
            lf.Show();
        }
    }
}
