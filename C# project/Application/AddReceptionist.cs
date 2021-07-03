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
    public partial class AddReceptionist : Form
    {
        internal Admin admin;
        ReceptionistEntity r;
        ReceptionistRepo rr;
        public AddReceptionist()
        {
            InitializeComponent();
            r= new ReceptionistEntity();
            rr=new ReceptionistRepo();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
             int p = new Random().Next(99999999)+10000000;
            try
            {
                r.Id = this.tbid.Text;
                r.Password = p + "";

                r.Name = this.tbname.Text;
               // r.Name = this.EmpNameTB.Text;
                
                r.PhoneNumber = tbphone1.Text +tbphnnumber.Text;
                double sal = Convert.ToDouble(this.tbsalary.Text);
                r.Salary = sal;
                r.Address = this.tbaddress.Text;
                r.JoiningDate=this.dateTimePicker1.Value.Date.ToShortDateString();
                if(radioButton1.Checked){
                      r.Gender="Male";
                }
                else{
                    r.Gender="Female";}

                

                
                if (rr.InsertReceptionist(r))
                {
                    
                        MessageBox.Show("Receptionist Added. Id : " + r.Id + " & Password : " + r.Password);
                       
                    
                }
                else
                {
                    MessageBox.Show("Can Not Add  " + r.JoiningDate + r.Gender);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data");
            }
        }

        private void tbphnnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddReceptionist_Load(object sender, EventArgs e)
        {

        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            WelcomePage lf = new WelcomePage();
            this.Close();
            lf.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHomePage ahp = new AdminHomePage(admin);
            this.Close();
            ahp.Show();
        }
        }

    
}
