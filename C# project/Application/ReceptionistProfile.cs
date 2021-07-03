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
    public partial class ReceptionistProfile : Form
    {
        public ReceptionistProfile()
        {
            InitializeComponent();
        }

        private void ReceptionistProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            WelcomePage lfr = new WelcomePage();
            this.Close();
            lfr.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ReceptionistHomePage rhp = new ReceptionistHomePage();
            this.Close();
            rhp.Show();
        }

       

       
    }
}
