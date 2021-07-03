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
    public partial class DoctorAppointmentList : Form
    {
       DoctorEntity d;
        AppointmentEntity a;
        AppointmentRepo ar;
        public DoctorAppointmentList(DoctorEntity dra)
        {
            InitializeComponent();
            a = new AppointmentEntity();
            ar = new AppointmentRepo();
            this.d = dra;
           
           
        }
       

        private void btnBack_Click(object sender, EventArgs e)
        {
            DoctorHomePage da = new DoctorHomePage(d);
            this.Close();
            da.Show();
        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
          WelcomePage dl = new WelcomePage();
            this.Close();
            dl.Show();
        }

        public void btnViwAllAppoinment_Click(object sender, EventArgs e)
        {
           
            List<AppointmentEntity> listOfAppointment = ar.GetAllAppointment(d.UserId); 
            this.dataGridView1.DataSource= listOfAppointment;

        }

      
      
    }
}
