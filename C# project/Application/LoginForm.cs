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
    public partial class LoginForm : Form
    {
        internal Admin admin;
        internal AdminRepo ar;
        public LoginForm()
        {   

            InitializeComponent();
            ar = new AdminRepo();
            admin =new Admin();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pnlSignIn.BackColor = Color.FromArgb(100, 0, 0, 0);
  
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string userName = TbUsername.Text;
            string password = TBPassword.Text;
            admin = ar.GetUser(userName, password);

            if (admin != null)
            {
                AdminHomePage ahp = new AdminHomePage(admin);
                this.Visible = false;
                ahp.Visible = true;

            }
            else
                MessageBox.Show("Invlid Username or Password");
            
            
           
        }

        private void TBPassword_Enter(object sender, EventArgs e)
        {
            
        }

        private void TbUsername_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            btnLogin_Click(sender, e);
        }

        private void TBPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            WelcomePage wp = new WelcomePage();
            this.Close();
           wp.Show();
        }

        private void pnlSignIn_Paint(object sender, PaintEventArgs e)
        {

        }

       

     

       

      
        
    }
}
