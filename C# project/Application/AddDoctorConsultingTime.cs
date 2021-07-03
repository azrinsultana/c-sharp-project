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
    public partial class AddDoctorConsultingTime : Form
    {
        DoctorConsultingTimeEntity dct;
        DoctorConsultingTimeRepo dr;
        DoctorEntity dc;
        
        public AddDoctorConsultingTime(DoctorEntity dra)
        {
            InitializeComponent();
            this.dc = dra;
           dct = new DoctorConsultingTimeEntity();
            dr = new DoctorConsultingTimeRepo();
            //this.tbuserid.Text = dc.UserId;
            DoctorEntity dc= dr.GetDoctor(dra.UserId);
            dct.Name = dc.Name;
            dct.DoctorId = dc.UserId;
            
            
        }
       
        
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(dc.Name);
            lvluserid.Text = dct.DoctorId;
           lvlName.Text = dct.Name;

           try
           {

               dct.Saturday = tbsaturday.Text;
               dct.Sunday = tbSuday.Text;
               dct.Monday = tbMonday.Text;
               dct.Tuesday = tbTuesday.Text;
               dct.Wednesday = tbWednesday.Text;
               dct.Thrusday = tbThrusday.Text;
               dct.Friday = tbFriday.Text;
               if(tbsaturday.Text == "" && tbSuday.Text == "" && tbMonday.Text == "" && tbTuesday.Text == "" && tbWednesday.Text == "" && tbThrusday.Text == "" && tbFriday.Text == "")
               {

                   MessageBox.Show("Please fill the necessary fields");
               }

               else
               {

                   if (dr.InsertDoctorConsultingTime(dct))
                   {

                       MessageBox.Show("Doctor Consulting Added.");


                   }
                   else
                   {
                       MessageBox.Show("Can Not Add  ");
                   }
               }
           }

           catch (Exception exp)
           {
               MessageBox.Show("Invalid Data");
           }
        
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       
        

        }

        
    
}
