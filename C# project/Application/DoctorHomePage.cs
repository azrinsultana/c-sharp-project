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
    public partial class DoctorHomePage : Form
    {
        DoctorEntity dra;
        
        public DoctorHomePage(DoctorEntity dra)
        {
            InitializeComponent();
           //d = new DoctorEntity();
            this.dra = dra;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            DoctorProfile d = new DoctorProfile(dra);
          
            this.Close();
            d.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            WelcomePage dlf = new WelcomePage();
            this.Close();
            dlf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewPatientFromDoctor vd = new ViewPatientFromDoctor();
            this.Close();
            vd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckHealthStatus c = new CheckHealthStatus();
            this.Close();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorAppointmentList da = new DoctorAppointmentList(dra);
            this.Close();
            da.Show();

        }

        private void btnSetapponitment_Click(object sender, EventArgs e)
        {
            
            AddDoctorConsultingTime ad = new AddDoctorConsultingTime(dra);
            this.Close();
            ad.Show();
        }

        
    }
}
