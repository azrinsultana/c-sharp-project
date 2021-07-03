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
    
    public partial class ViewAllDoctor : Form
    {
        internal Admin admin;
        DoctorEntity d;
        DoctorRepo dr;

        public ViewAllDoctor()
        {
            InitializeComponent();
            d = new DoctorEntity();
            dr = new DoctorRepo();
            TableDoctor.Location = new Point(41, 30);
            TableDoctor.Height = 271;
            TableDoctor.Width = 720;
            pnllbl.Hide();
            
        }

        public void btnViewAllDoctor_Click(object sender, EventArgs e)
        {
            List<DoctorEntity> listOfDoctor = dr.GetAllDoctor();
            this.TableDoctor.DataSource = listOfDoctor;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btndelete.Enabled = true;
            btnUpdate.Enabled = false;
            d.UserId = tbuserid.Text;
            d.Name = tbname.Text;
            d.PhoneNumber = tbphone1.Text + tbphnnumber.Text;
            if (radioButton1.Checked)
            {
                d.Gender = "Male";
            }
            else
            {
                d.Gender = "Female";
            }
            d.Degree = tbDegree.Text;
            d.Address = tbaddress.Text;
          
          
            if (dr.UpdateDoctor(d))
            {

                MessageBox.Show("Doctor detail updated");

            }
            else
                MessageBox.Show(" doctor Not updated");
           
        }

        private void TableDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TableDoctor.Location = new Point(410, 30);
            pnllbl.Show();
            TableDoctor.Height = 271;
            TableDoctor.Width = 340;
            tbuserid.Text = TableDoctor.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbname.Text = TableDoctor.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbphnnumber.Text = (TableDoctor.Rows[e.RowIndex].Cells[2].Value.ToString()).Substring(4);
            if (TableDoctor.Rows[e.RowIndex].Cells[3].Value.ToString() == "Male")
            {
                radioButton1.Checked = true;
            }
            else
                radioButton2.Checked = true;
            tbDegree.Text = TableDoctor.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbaddress.Text = TableDoctor.Rows[e.RowIndex].Cells[6].Value.ToString();
           
        }

       private void btndelete_Click(object sender, EventArgs e)
        {
            btndelete.Enabled = false;
            btnUpdate.Enabled = true;
            d.UserId = tbuserid.Text;
            if (dr.DeleteDoctor(d))
            {
                MessageBox.Show(" doctor Deleted");
                btnViewAllDoctor_Click(sender, e);

            }
            else { MessageBox.Show("Can not Delete"); }
        }

       private void btnBack_Click(object sender, EventArgs e)
       {
           AdminHomePage ahp=new AdminHomePage(admin);
           this.Close();
           ahp.Show();

       }

       private void btnlogOut_Click(object sender, EventArgs e)
       {
           WelcomePage wp = new WelcomePage();
           this.Close();
           wp.Show();

       }

       private void textBox5_TextChanged(object sender, EventArgs e)
       {
           List<DoctorEntity> listOfDoctor = dr.GetAllDoctor();
           string keyword = textBox5.Text.ToLower();
           List<DoctorEntity> searchedList = listOfDoctor.FindAll(x => ((x.UserId.ToLower()).Contains(keyword)) || ((x.Name.ToLower()).Contains(keyword)) || ((x.PhoneNumber.ToLower()).Contains(keyword)) || ((x.Gender.ToLower()).Contains(keyword)) || ((x.Degree.ToLower()).Contains(keyword)) || ((x.Address.ToLower()).Contains(keyword)));

           TableDoctor.DataSource = searchedList;
       }

       
    }
}
