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
    public partial class ViewAllReceptionist : Form
    {
        internal Admin admin;
        ReceptionistRepo rr;
        ReceptionistEntity r;
        public ViewAllReceptionist()
        {
            InitializeComponent();
            rr = new ReceptionistRepo();
            r = new ReceptionistEntity();

        }

        private void btnUpdateReceptionist_Click(object sender, EventArgs e)
        {
            r.Name = tbname.Text;
            r.Id = tbid.Text;
            r.PhoneNumber = tbphone1.Text + tbphnnumber.Text;
            r.Address = tbaddress.Text;
            r.Salary = Convert.ToDouble(tbsalary.Text);

            if (rr.UpdateRceptionist(r))
            {
                MessageBox.Show("Receptionist detail updated");
            }
            else
                MessageBox.Show("Not updated");

        }

        public void btnViewAllReceptionist_Click(object sender, EventArgs e)
        {
            List<ReceptionistEntity> listOfReceptionist = rr.GetAllReceptionist();
            this.TableReceptionist.DataSource=  listOfReceptionist;

        }

        private void TableReceptionist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbid.Text = TableReceptionist.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbname.Text = TableReceptionist.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbphnnumber.Text =( TableReceptionist.Rows[e.RowIndex].Cells[2].Value.ToString()).Substring(4);
            tbsalary.Text = TableReceptionist.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbaddress.Text = TableReceptionist.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btndeleteReceptionist_Click(object sender, EventArgs e)
        {
            
            r.Id = tbid.Text;
            if (rr.DeleteReceptionist(r))
            {
                MessageBox.Show("Deleted");
                btnViewAllReceptionist_Click(sender, e);

            }
            else { MessageBox.Show("Can not Delete"); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHomePage ahp = new AdminHomePage(admin);
            this.Close();
            ahp.Show();
        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            WelcomePage lf = new WelcomePage();
            this.Close();
            lf.Show();
        }
    }
}
