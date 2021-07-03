using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repository
{
   public class PatientRepo
    {
       DatabaseConnectionClass dcc;

         public PatientRepo()
        {
            dcc = new DatabaseConnectionClass();
        }

       
         public List<PatientEntity> GetAllPatient()
        {
            List<PatientEntity> listOfPatient = new List<PatientEntity>();
            string query = "SELECT * FROM Patients";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                PatientEntity p = new PatientEntity();
                p.UserId = sdr["UserId"].ToString();
                p.Name = sdr["Name"].ToString();
                p.PhoneNumber = sdr["PhoneNumber"].ToString();
                p.Gender = sdr["Gender"].ToString();
                p.Address = sdr["Address"].ToString();
               p.Age=Convert.ToInt32(sdr["Age"]);
                p.BloodGroup=sdr["BloodGroup"].ToString();
                listOfPatient.Add(p);
            }
            dcc.CloseConnection();

            return listOfPatient;
         }
       


      public bool InsertPatient(PatientEntity p)
         {
             string query = "INSERT into Patients VALUES('" + p.UserId + "', '" + p.Name + "', '" + p.Age + "', " + p.PhoneNumber + ", '" + p.Gender + "', '" + p.BloodGroup+ "', '" + p.Address +  "')";
             try
             {
                 dcc.ConnectWithDB();
                 int n = dcc.ExecuteSQL(query);
                 dcc.CloseConnection();
                 return true;
             }
             catch (Exception exp) { return false; }
         }

      public bool UpdatePatient(PatientEntity p)
      {
          string query = "UPDATE Patients SET UserId = '" + p.UserId + "', PhoneNumber = '" + p.PhoneNumber + "',  Address = '" + p.Address + "',Name='"+p.Name+"',BloodGroup='"+p.BloodGroup+"',Gender='"+p.Gender+"',Age='"+p.Age+"' WHERE UserId = '" + p.UserId + "'";
          try
          {
              dcc.ConnectWithDB();
              int n = dcc.ExecuteSQL(query);
              dcc.CloseConnection();
              return true;
          }
          catch (Exception exp)
          {
              return false;
          }
      }

      public bool DeletePatient(PatientEntity p)
      {
          string query = "DELETE from Patients WHERE UserId= '" + p.UserId + "'";
          try
          {
              dcc.ConnectWithDB();
              int n = dcc.ExecuteSQL(query);
              dcc.CloseConnection();
              return true;
          }
          catch (Exception exp)
          {
              return false;
          }
      }

      public PatientEntity GetPatient(string UserId)
      {

          PatientEntity p = null;
          string query = "SELECT Name ,UserId,Age,BloodGroup  from Patients WHERE UserId ='" + UserId + "'";
          dcc.ConnectWithDB();
          SqlDataReader sdr = dcc.GetData(query);

          while (sdr.Read())
          {

              p = new PatientEntity();
              p.UserId = sdr["UserId"].ToString();
              p.Name = sdr["Name"].ToString();
             
              p.Age = Convert.ToInt32(sdr["Age"]);
              p.BloodGroup = sdr["BloodGroup"].ToString();
          
              //d.Password = sdr["Password"].ToString();


          }
          dcc.CloseConnection();
          return p;

      }
        
    }
}
