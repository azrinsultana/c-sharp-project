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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LoginForm loginFrom = new LoginForm();
            this.Hide();
            loginFrom.Show();

        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            LoginFormReceptionist lr = new LoginFormReceptionist();
            this.Hide();
            lr.Show();

        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            DoctorLoginForm dlf = new DoctorLoginForm();
            this.Visible = false;
            dlf.Visible = true;





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
