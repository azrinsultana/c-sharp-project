using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repository
{
   public class DoctorRepo:IDoctor
    {
        DatabaseConnectionClass dcc;
      public DoctorRepo()
      {     
          
          dcc = new DatabaseConnectionClass();

      }
      public bool InsertDoctor(DoctorEntity d)
      {
          string query = "INSERT into Doctors VALUES('" + d.UserId + "', '" + d.Name + "', " + d.PhoneNumber + ", '" + d.Gender + "', '" + d.JoiningDate + "','"+ d.Degree+"' ,'" + d.Address + "', '" + d.Password + "')";
          try
          {
              dcc.ConnectWithDB();
              int n = dcc.ExecuteSQL(query);
              dcc.CloseConnection();
              return true;
          }
          catch (Exception exp) { return false; }
      }

      public List<DoctorEntity> GetAllDoctor()
      {
          List<DoctorEntity> listOfDoctor = new List<DoctorEntity>();
          string query = "SELECT * FROM Doctors";
          dcc.ConnectWithDB();
          SqlDataReader sdr = dcc.GetData(query);

          while (sdr.Read())
          {
              DoctorEntity d = new DoctorEntity();
              d.UserId = sdr["UserId"].ToString();
              d.Name = sdr["Name"].ToString();
             
              d.PhoneNumber = sdr["PhoneNumber"].ToString();
             
              d.Gender = sdr["Gender"].ToString();
             
              d.JoiningDate = sdr["JoiningDate"].ToString();
              d.Degree = sdr["Degree"].ToString();
              d.Address = sdr["Address"].ToString();
             d.Password = sdr["Password"].ToString();
              listOfDoctor.Add(d);
          }
          dcc.CloseConnection();

          return listOfDoctor;
      }

      public bool UpdateDoctor(DoctorEntity d)
      {
         
          string query = "UPDATE Doctors SET Name='" + d.Name + "', PhoneNumber='" + d.PhoneNumber + "', Gender='" + d.Gender + "',Degree= '" + d.Degree + "' ,Address='" + d.Address + "' where UserId='"+d.UserId+"'" ;
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
          finally
          {
              dcc.CloseConnection();
          }
      }
      public bool DeleteDoctor(DoctorEntity d)
      {
          string query = "DELETE from Doctors WHERE UserId= '"+d.UserId+"'";
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
          finally
          {
              dcc.CloseConnection();



          }
      }

      public DoctorEntity GetUser(string UserId, string Password)
      {

          DoctorEntity d = null;
          string query = "SELECT * from Doctors WHERE UserId ='" +UserId + "'AND Password='" + Password + "'";
          dcc.ConnectWithDB();
          SqlDataReader sdr = dcc.GetData(query);

          while (sdr.Read())
          {
              d = new DoctorEntity();
              d.UserId = sdr["UserId"].ToString();
              d.Password = sdr["Password"].ToString();


          }
          dcc.CloseConnection();
          return d;

      }

      public DoctorEntity GetDoctor(string UserId)
      {

          DoctorEntity d = null;
          string query = "SELECT Name ,UserId,PhoneNumber,JoiningDate,Password,Degree,Address ,Gender from Doctors WHERE UserId ='" + UserId + "'";
          dcc.ConnectWithDB();
          SqlDataReader sdr = dcc.GetData(query);

          while (sdr.Read())
          {
              
              d = new DoctorEntity();
              d.UserId = sdr["UserId"].ToString();
              d.Name = sdr["Name"].ToString();
              d.PhoneNumber = sdr["PhoneNumber"].ToString();
              d.JoiningDate = sdr["JoiningDate"].ToString();
              d.Password = sdr["Password"].ToString();
              d.Degree = sdr["Degree"].ToString();
              d.Address = sdr["Address"].ToString();
              d.Gender = sdr["Gender"].ToString();
              //d.Password = sdr["Password"].ToString();


          }
          dcc.CloseConnection();
          return d;

      }
        

    }
}
