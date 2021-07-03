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
    public partial class AdminHomePage : Form
    {
       // internal Admin admin;
        ReceptionistHomePage rhp;
      
        public AdminHomePage(Admin admin)
        {
            InitializeComponent();
           // lblwelcomeadmin.Text ="Welcome "+ admin.AdminUserName;
            btnAddReceptionist.Hide();
            btnViewReceptionistList.Hide();
            btnViewDoctor.Hide();
            btnAddDoctor.Hide();
        }

        private void btnmanagereceptionish_MouseHover(object sender, EventArgs e)
        {
            btnAddReceptionist.Show();
            btnViewReceptionistList.Show();
        }

        private void btnmanagedoctor_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnmanagedoctor_MouseEnter(object sender, EventArgs e)
        {
            btnViewDoctor.Show();
            btnAddDoctor.Show();
        }

        private void btnAddReceptionist_Click(object sender, EventArgs e)
        {
            AddReceptionist ar = new AddReceptionist();
            this.Hide();
            ar.Show();
        }

        private void btnViewReceptionistList_Click(object sender, EventArgs e)
        {
            ViewAllReceptionist var = new ViewAllReceptionist();
            this.Hide();
            var.Show();
            var.btnViewAllReceptionist_Click(sender, e);
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            Adddoctor d = new Adddoctor();
            this.Hide();
            d.Show();

        }

        private void btnViewDoctor_Click(object sender, EventArgs e)
        {
            ViewAllDoctor vd = new ViewAllDoctor();
            vd.btnViewAllDoctor_Click(sender, e);
            this.Hide();
            vd.Show();
        }

        private void btnmanagepatient_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            WelcomePage wp = new WelcomePage();
            this.Hide();
            wp.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
