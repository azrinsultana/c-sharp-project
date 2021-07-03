using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
   public class HealthReportEntity
    {
        string pId;

        public string PId
        {
            get { return pId; }
            set { pId = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        double bmi;

        public double Bmi
        {
            get { return bmi; }
            set { bmi = value; }
        }
        int calorie;

        public int Calorie
        {
            get { return calorie; }
            set { calorie = value; }
        }
   

     
      
    }
}
