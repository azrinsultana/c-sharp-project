using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class CheckHealthStatus : Form
    {
        DoctorEntity dra;
        double wg = 0;
        double bm = 0;
        int cal = 0;
        PatientEntity p;
        HealthReportEntity hre;
        HealthReportRepo hrr;
        PatientRepo pr;
        public CheckHealthStatus()
        {
            InitializeComponent();
           // lblcalShow.Hide();

            //lblcallorieRes.Hide();
            pnlBMI.Hide();
            pnlCalorie.Hide();
            p = new PatientEntity();
            pr = new PatientRepo();
            hrr = new HealthReportRepo();
            hre = new HealthReportEntity();

        }

        private void btnhealthreport_Click(object sender, EventArgs e)
        {
            p= pr.GetPatient(tbpatientid.Text);
            hre.PId = tbpatientid.Text;
            hre.PId = p.UserId;
            hre.Name = p.Name;
            hre.Calorie = Convert.ToInt32(tbcalShow.Text);
            hre.Bmi = Convert.ToDouble(tbBmiShow.Text);
          //  MessageBox.Show(hre.PId + hre.Bmi + hre.Calorie);
            try
            {
                
                if(hrr.InsertHealthReport(hre))
                {
                     MessageBox.Show("Health Report Added.");

                }

            
           else
                   {
                       MessageBox.Show("Can Not Add  ");
                   }
               }
           

           catch (Exception exp)
           {
               MessageBox.Show("Invalid Data");
           }
        
          
          //  List<HealthReportEntity> listOfHealthReport = hrr.GetAllReport();
            
            

            HealthReportTable h = new HealthReportTable();
          //  h.tablehealthreport.DataSource = hrr.GetAllReport();
           this.Hide();
           h.Show();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            pnlBMI.Show();
            pnlCalorie.Hide();
        }

        private void btnBmiCalculate_Click(object sender, EventArgs e)

            
        { 
            if(tBHeightFoot.Text==null && TbHeightInch.Text !=null && tbWeight!=null)
        {
            MessageBox.Show("Please Enter Height in Foot");
        }
 else if(tBHeightFoot.Text!=null && TbHeightInch.Text ==null && tbWeight!=null)
        {
            MessageBox.Show("Please Enter Height in Inch");
        }
            else if(tBHeightFoot.Text !=null && TbHeightInch.Text !=null && tbWeight==null)
        {
            MessageBox.Show("Please Enter Weight");
        }
            else if(tBHeightFoot.Text==null && TbHeightInch.Text ==null && tbWeight!=null)
        {
            MessageBox.Show("Please Enter Height in Foot And Inch");
        }
            else  if(tBHeightFoot.Text !=null && TbHeightInch.Text ==null && tbWeight==null)
        {
            MessageBox.Show("Please Enter Height in Inch and Wight ");
        }
            else if(tBHeightFoot.Text=="" && TbHeightInch.Text =="" && tbWeight.Text=="")
        {
            MessageBox.Show("Please Enter All information");
        }
           
            else
            {
            double hf = Convert.ToDouble(tBHeightFoot.Text);
            double hi = Convert.ToDouble(TbHeightInch.Text);
            double heightInch = (hf * 12.00) + hi;
            double height = heightInch *0.0254;
            

            double weight=Convert.ToDouble(tbWeight.Text);
            wg = weight;
                if(height==0)
                {
               tbBmiShow.Text="Height cannot be 0";
                }
                   if(weight==0)
               {
                   MessageBox.Show("Enter accurate Weight");
               }
              
            double bmi=(weight/(height*height));

           // bmi = Math.Round(bmi, 2);
            tbBmiShow.Text = bmi.ToString();

            

          //  hre.Bmi = Convert.ToDouble(tbBmiShow.Text);
           // MessageBox.Show(+height+);
            if (bmi == 0 && bmi <= 15)
            {
                label5.Text = "Very severely underweight";
            }
            else if (bmi >= 15.000001 && bmi <= 16)
            {
                label5.Text = "Severely underweight ";
            }

            else if (bmi >= 16.000001 && bmi <= 18.5)
            {
                label5.Text = "Underweight  ";
            }
            else if (bmi >= 18.50001 && bmi <= 25)
            {
                label5.Text = "Normal Weight  ";
            }
            else if (bmi >= 25.000001 && bmi <= 30)
            {
                label5.Text = "Overweight  ";
            }
            else if (bmi >= 30.000001 && bmi <= 35)
            {
                label5.Text = " Obese Class I (Moderately obese)";
            }
            else if (bmi >= 35.000001 && bmi <= 40)
            {
                label5.Text = " Obese Class II (Severely obese)";
            }

            else if (bmi >= 40.000001 && bmi <= 45)
            {
                label5.Text = " Obese Class III (Very severely obese)";
            }

            else if (bmi >= 45.000001 && bmi <= 50)
            {
                label5.Text = " Obese Class IV (Morbidly obese)";
            }
            else if (bmi >= 50.000001 && bmi <= 60)
            {
                label5.Text = " Obese Class V (Super obese)";
            }
            else
                label5.Text = "Obese Class VI (Hyper obese)";
            }
            
        }

       
        private void btncalorie_Click(object sender, EventArgs e)
        {

            pnlCalorie.Show();

          // this.pnlCalorie.Location = new System.Drawing.Point(273, 86);
          // this.pnlCalorie.Size = new System.Drawing.Size(457,298);

           pnlBMI.Hide();

        }


        private void btnlogOut_Click(object sender, EventArgs e)
        {
            WelcomePage dp = new WelcomePage();
            this.Close();
            dp.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DoctorHomePage d = new DoctorHomePage(dra);
            this.Close();
            d.Show();
/*

            double heightft = Convert.ToDouble(tBHeightFoot.Text);
            double heightinch = Convert.ToDouble(TbHeightInch.Text);
            double height1 = (heightft * 12) + heightinch;
            double height = height1 * .0254;
            double heightCm = height * 100;
            int ibw = (int)(heightCm - 100);
            int calorie = ibw * 30;
            lblcallorieRes.Text = calorie.ToString();

            lblcalshow.Show();
            lblcallorieRes.Show();
 * */
        }

        private void btnCalloriecal_Click(object sender, EventArgs e)
        {
            double heightft = Convert.ToDouble(tbHeightInFt.Text);
            double heightinch = Convert.ToDouble(textBox3.Text);
            double height1 = (heightft * 12) + heightinch;
            double height = height1 * 0.0254;
            double heightCm = height * 100;
            int ibw = (int)(heightCm - 100);
            int calorie = ibw * 30;
            tbcalShow.Text = calorie.ToString();
            cal = calorie;
            tbcalShow.Show();
            hre.Calorie = Convert.ToInt32(tbcalShow.Text);
           // lblcalloris.eReShow();
           
        }

        private void tBHeightFoot_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBmiShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int calorie = cal;
            if (calorie <= 1000)
            {
                DietChart1 d1 = new DietChart1();
                this.Close();
                d1.Show();
            }
            else if (calorie <= 1200 && calorie >= 1000)
            {
                DietChart2 d2 = new DietChart2();
                this.Close();
                d2.Show();
            }
            else if (calorie <= 1400 && calorie >= 1200)
            {
                DietChart3 d3 = new DietChart3();
                this.Close();
                d3.Show();
            }
            else if (calorie <= 1600 && calorie >= 1400)
            {
                DietChart4 d4 = new DietChart4();
                this.Close();
                d4.Show();
            }
            else if (calorie <= 1800 && calorie >= 1600)
            {
                DietChart5 d5 = new DietChart5();
                this.Close();
                d5.Show();
            }
            else if (calorie <= 2000 && calorie >= 1800)
            {
                DietChart6 d6 = new DietChart6();
                this.Close();
                d6.Show();
            }
            else if (calorie <= 2200 && calorie >= 2000)
            {
                DietChart6 d6 = new DietChart6();
                this.Close();
                d6.Show();
            }
            else if (calorie <= 2400 && calorie >= 2200)
            {
                DietChart8 d8 = new DietChart8();
                this.Close();
                d8.Show();
            }
            else if (calorie <= 2600 && calorie >= 2400)
            {
                DietChart9 d9 = new DietChart9();
                this.Close();
                d9.Show();
            }
            else
            {
                DietChart10 d10 = new DietChart10();
                this.Close();
                d10.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            p = pr.GetPatient(tbpatientid.Text);
            hre.PId = tbpatientid.Text;
            hre.PId = p.UserId;
            hre.Name = p.Name;
            hre.Calorie = Convert.ToInt32(tbcalShow.Text);
            hre.Bmi = Convert.ToDouble(tbBmiShow.Text);
            MessageBox.Show(hre.PId + hre.Bmi + hre.Calorie);
            try
            {

                if (hrr.InsertHealthReport(hre))
                {
                    MessageBox.Show("Health Report Added.");

                }


                else
                {
                    MessageBox.Show("Can Not Add  ");
                }
            }


            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data");
            }



            HealthReportTable h = new HealthReportTable();
            this.Hide();
            h.Show();
        }

       
       


    }
}
