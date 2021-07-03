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
    public partial class ManagePatient : Form
    {
       // internal Admin admin;
        ReceptionistHomePage rhp;
        PatientEntity p;
        PatientRepo pr;
        public ManagePatient()
        {
            p = new PatientEntity();
            pr = new PatientRepo();
            rhp = new ReceptionistHomePage();
          
           
            InitializeComponent();
            btnUpdatePatient.Enabled = false;
            btnDeletePatient.Enabled = false;
            pnlmanagepatient.Hide();
        }

       
        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            pnlmanagepatient.Show();
            btnDeletePatient.Enabled = false;
            btnDeletePnl.Hide();
        }

        private void PatientTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbPatientUserId.Text = PatientTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbPatientName.Text = PatientTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbPatientAge.Text = PatientTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            
          tbphnnumber.Text = (PatientTable.Rows[e.RowIndex].Cells[3].Value.ToString()).Substring(4);

          if (PatientTable.Rows[e.RowIndex].Cells[4].Value.ToString() == "Male")
          {
              radioButton1.Checked = true;
          }
          else
              radioButton3.Checked = true;
          if (PatientTable.Rows[e.RowIndex].Cells[5].Value.ToString() == "A+")
          {
              cmbBlood.SelectedItem = "A+";
          }
          else if (PatientTable.Rows[e.RowIndex].Cells[5].Value.ToString() == "A-")
          {
              cmbBlood.SelectedItem = "A-";
          }
          else if (PatientTable.Rows[e.RowIndex].Cells[5].Value.ToString() == "B+")
          {
              cmbBlood.SelectedItem = "B+";
          }
          else if (PatientTable.Rows[e.RowIndex].Cells[5].Value.ToString() == "O+")
          {
              cmbBlood.SelectedItem = "O+";
          }
          else if (PatientTable.Rows[e.RowIndex].Cells[5].Value.ToString() == "O-")
          {
              cmbBlood.SelectedItem = "O-";
          }
          else if (PatientTable.Rows[e.RowIndex].Cells[5].Value.ToString() == "B-")
          {
              cmbBlood.SelectedItem = "B-";
          }
          else if (PatientTable.Rows[e.RowIndex].Cells[5].Value.ToString() == "AB+")
          {
              cmbBlood.SelectedItem = "AB+";
          }
          else
              cmbBlood.SelectedItem = "AB-";

          tbPatientAddress.Text = PatientTable.Rows[e.RowIndex].Cells[6].Value.ToString();

          btnUpdatePatient.Enabled = true;
          btnDeletePatient.Enabled = true;

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            
            p.UserId = tbPatientUserId.Text;
            p.Name = tbPatientName.Text;
            p.Age = Convert.ToInt32(tbPatientAge.Text);
            p.Address = tbPatientAddress.Text;
            p.PhoneNumber = tbphone1.Text + tbphnnumber.Text;
            if (radioButton1.Checked)
            {
                p.Gender = "Male";
            }
            else
            {
                p.Gender = "Female";
            }
            p.BloodGroup = cmbBlood.SelectedItem.ToString();
            if (pr.UpdatePatient(p))
            {
               
                MessageBox.Show("Patient detail updated");
                
            }
            else
          MessageBox.Show("Not updated"); 
                rhp.btnManagePatient_Click(sender, e);
            pnlmanagepatient.Hide();
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            btnDone.Hide();
            pnlmanagepatient.Show();
            btnUpdatePatient.Enabled = false;
        }

        private void btnDeletePnl_Click(object sender, EventArgs e)
        {

            p.UserId = tbPatientUserId.Text;
            if (pr.DeletePatient(p))
            {
                MessageBox.Show("Deleted");
               
                rhp.btnManagePatient_Click(sender, e);

            }
            else { MessageBox.Show("Can not Delete"); }
        }

        public void btnViewAllPatient_Click(object sender, EventArgs e)
        {
            List<PatientEntity> listOfPatient = pr.GetAllPatient();
           PatientTable.DataSource = listOfPatient;
        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            WelcomePage wp = new WelcomePage();
            this.Hide();
            wp.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ReceptionistHomePage rhp = new ReceptionistHomePage();
           
            this.Hide();
            rhp.Visible = true;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            List<PatientEntity> listOfPatient = pr.GetAllPatient();
            string keyword = textBox5.Text.ToLower();
            List<PatientEntity> searchedList = listOfPatient.FindAll(x => ((x.UserId.ToLower()).Contains(keyword)) || ((x.Name.ToLower()).Contains(keyword)) || ((x.PhoneNumber.ToLower()).Contains(keyword)) || ((x.Gender.ToLower()).Contains(keyword)) || ((x.BloodGroup.ToLower()).Contains(keyword)) || ((x.Address.ToLower()).Contains(keyword)));

            PatientTable.DataSource = searchedList;
        }

       
       
    }
}
