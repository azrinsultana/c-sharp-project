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
    public partial class LoginFormReceptionist : Form
    {
        ReceptionistEntity rep;
        LoginReceptionistRepo rr;
        
        public LoginFormReceptionist()
        {
            InitializeComponent();
            rep = new ReceptionistEntity();
            rr = new LoginReceptionistRepo();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string u = this.tbRecUser.Text;
            string p = this.tbRecPass.Text;
           // MessageBox.Show("u");
            rep = rr.GetUser(u, p);

            if (rep != null)
            {
                ReceptionistHomePage rhp = new ReceptionistHomePage();
                this.Visible = false;
                rhp.Visible = true;

            }
            else
            {
                //MessageBox.Show("u");

                MessageBox.Show("Invlid Username or Password");
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WelcomePage wp = new WelcomePage();
            this.Close();
            wp.Show();
        }
    }
}
