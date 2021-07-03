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
    public partial class SetAppointment : Form
    { 
        AppointmentEntity a;
        AppointmentRepo ar;
        DoctorEntity d;
        DoctorConsultingTimeEntity dct;
        DoctorConsultingTimeRepo dr;
       
        public SetAppointment()
        {
            InitializeComponent();
            dct = new DoctorConsultingTimeEntity();
            dr = new DoctorConsultingTimeRepo();
            lblDate.Hide();
            lblPatientId.Hide();
            tbPatientId.Hide();
            dateTimePicker1.Hide();
            btnDone.Hide();
            a = new AppointmentEntity();
            ar = new AppointmentRepo();
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            List<DoctorConsultingTimeEntity> listOfConsultingTime = dr.GetAllConsultingTime();
            this.tblDoctorConsultingTime.DataSource = listOfConsultingTime;
        }

        private void tblDoctorConsultingTime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
               a.DoctorId = tblDoctorConsultingTime.Rows[e.RowIndex].Cells[0].Value.ToString();
               a.DoctorName = tblDoctorConsultingTime.Rows[e.RowIndex].Cells[1].Value.ToString();
               dct.Saturday = tblDoctorConsultingTime.Rows[e.RowIndex].Cells[2].Value.ToString();
               dct.Sunday = tblDoctorConsultingTime.Rows[e.RowIndex].Cells[3].Value.ToString();
               dct.Monday = tblDoctorConsultingTime.Rows[e.RowIndex].Cells[4].Value.ToString();
               dct.Tuesday = tblDoctorConsultingTime.Rows[e.RowIndex].Cells[5].Value.ToString();
              dct.Wednesday = tblDoctorConsultingTime.Rows[e.RowIndex].Cells[6].Value.ToString();
               dct.Thrusday = tblDoctorConsultingTime.Rows[e.RowIndex].Cells[7].Value.ToString();
               dct.Friday = tblDoctorConsultingTime.Rows[e.RowIndex].Cells[8].Value.ToString();

            lblDate.Show();
            lblPatientId.Show();
            tbPatientId.Show();
            dateTimePicker1.Show();
            label2.Hide();
            btnDone.Show();
        }

        public void btnDone_Click(object sender, EventArgs e)
        {
            //a=new AppointmentEntity();
            //a.PatientId= tbPatientId.Text.ToString();
            try{
            AppointmentEntity atemp=ar.GetAppointment(tbPatientId.Text );
            a.PatientId =atemp.PatientId;
            a.PatientName = atemp.PatientName;
            a.PatientAge = atemp.PatientAge;
          
            a.PatientId = tbPatientId.Text;
            a.Date = dateTimePicker1.Value.ToLongDateString();
            if (ar.InsertAppointment(a))
            {

                MessageBox.Show("New appointment added");


            }
            else
            {
                MessageBox.Show("Can Not Add  " );
            }
        }
        catch (Exception exp)
        {
            MessageBox.Show("Invalid Data");
        }
        }

    }
}
