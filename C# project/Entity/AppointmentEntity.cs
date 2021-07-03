using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
  public   class AppointmentEntity 
    {
       
        string doctorId;

        public string DoctorId
        {
            get { return doctorId; }
            set { doctorId = value; }
        }
        string doctorName;

        public string DoctorName
        {
            get { return doctorName; }
            set { doctorName = value; }
        }
        string patientId;

        public string PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }
        string patientName;

        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }
        string patientAge;

        public string PatientAge
        {
            get { return patientAge; }
            set { patientAge = value; }
        }

       

        string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
      
    }
}
