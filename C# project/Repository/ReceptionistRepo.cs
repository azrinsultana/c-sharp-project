using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repository
{
   public class ReceptionistRepo
    {
         DatabaseConnectionClass dcc;

         public ReceptionistRepo()
        {
            dcc = new DatabaseConnectionClass();
        }

         public ReceptionistEntity GetUser(string id, string password)
         {
             ReceptionistEntity rep = null;
             string query = "SELECT UserName, Password from Receptionists WHERE UserName ='"+id+"'AND Password='"+password+"'";
             dcc.ConnectWithDB();
             SqlDataReader sdr = dcc.GetData(query);

             while (sdr.Read())
             {
                 rep = new ReceptionistEntity();
                 rep.Id = sdr["UserName"].ToString();
                 rep.Password = sdr["Password"].ToString();
                 

             }
             dcc.CloseConnection();
             return rep;

         }
        
         

         public bool InsertReceptionist(ReceptionistEntity r)
        {
            string query = "INSERT into Receptionists VALUES('" + r.Name + "', '" + r.Id + "', '" + r.Password + "', " + r.PhoneNumber + ", '" + r.Gender + "', '" + r.JoiningDate + "', '" + r.Address + "', '" + r.Salary + "')";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp) { return false; }
        }

         public List<ReceptionistEntity> GetAllReceptionist()
         {
             List<ReceptionistEntity> listOfReceptionist = new List<ReceptionistEntity>();
             string query = "SELECT * FROM Receptionists";
             dcc.ConnectWithDB();
             SqlDataReader sdr = dcc.GetData(query);

             while (sdr.Read())
             {
                 ReceptionistEntity rep = new ReceptionistEntity();
                 rep.Name = sdr["Name"].ToString();
                 rep.Id = sdr["UserName"].ToString();
                 rep.PhoneNumber = sdr["PhnNumber"].ToString();
                 rep.Salary = Convert.ToDouble(sdr["Salary"]);
                 rep.Gender = sdr["Gender"].ToString();
                 rep.Address= sdr["Address"].ToString();
                 rep.JoiningDate= sdr["JoiningDate"].ToString();
                 rep.Password= sdr["Password"].ToString();
                 listOfReceptionist.Add(rep);
             }
             dcc.CloseConnection();

             return listOfReceptionist;
         }

        public bool DeleteReceptionist(ReceptionistEntity r)
         {
             string query = "DELETE from Receptionists WHERE UserName= '" + r.Id + "'";
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

      public bool UpdateRceptionist(ReceptionistEntity r)
        {
            string query = "UPDATE Receptionists SET  Name = '" + r.Name + "', PhnNumber = '" + r.PhoneNumber + "', Salary = " + r.Salary + ", Address = '" + r.Address + "' WHERE UserName = '" + r.Id + "'";
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
    }
}
