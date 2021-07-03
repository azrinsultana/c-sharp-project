using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repository
{
   public class AppointmentRepo:IAppointment


    {
          DatabaseConnectionClass dcc;
          AppointmentEntity a;
          public AppointmentRepo()
        {
            dcc = new DatabaseConnectionClass();
            a = new AppointmentEntity();
        }
       public AppointmentEntity GetAppointment(string UserId)
       {
        

           AppointmentEntity a = null;
           string query = "SELECT Name ,UserId,Age from Patients WHERE UserId ='" + UserId + "'";
           dcc.ConnectWithDB();
           SqlDataReader sdr = dcc.GetData(query);

           while (sdr.Read())
           {
               a = new AppointmentEntity();
               a.PatientId = sdr["UserId"].ToString();
               a.PatientName = sdr["Name"].ToString();
               a.PatientAge = sdr["Age"].ToString();
               //d.Password = sdr["Password"].ToString();
          

           }
           dcc.CloseConnection();
           return a;

       }

       public bool InsertAppointment(AppointmentEntity a)
       {
           string query = "INSERT into Appointments VALUES('" +a.DoctorId + "', '" + a.DoctorName+ "',' " + a.PatientId + "', '" + a.PatientName + "', '" + a.PatientAge + "','" + a.Date + "')";
           try
           {
               dcc.ConnectWithDB();
               int n = dcc.ExecuteSQL(query);
               dcc.CloseConnection();
               return true;
           }
           catch (Exception exp) { return false; }
       }
       public List<AppointmentEntity> GetAllAppointment(string userid)
       {
           List<AppointmentEntity> listOfAppointment = new List<AppointmentEntity>();
           string query = "SELECT * FROM Appointments where DoctorId ='"+userid+"'   " ;
           dcc.ConnectWithDB();
           SqlDataReader sdr = dcc.GetData(query);

           while (sdr.Read())
           {
               AppointmentEntity anew = new AppointmentEntity();

               anew.DoctorId = sdr["DoctorId"].ToString();
               anew.DoctorName = sdr["DoctorName"].ToString();
               anew.PatientId = sdr["PatientId"].ToString();
               anew.PatientName = sdr["PatientName"].ToString();
               anew.PatientAge = sdr["PatientAge"].ToString();
               anew.Date = sdr["Date"].ToString();




               listOfAppointment.Add(anew);
           }
           dcc.CloseConnection();

           return listOfAppointment;
       }
    }
}
