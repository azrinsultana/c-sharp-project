using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repository
{
   public class LoginReceptionistRepo
    {
         DatabaseConnectionClass dcc;

         public LoginReceptionistRepo()
        {
            dcc = new DatabaseConnectionClass();
        }

         public ReceptionistEntity GetUser(string id, string password)
         {
             
             ReceptionistEntity rep = null;
             string query = "SELECT * from Receptionists WHERE UserName ='"+id+"'AND Password='"+password+"'";
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
        
    }
}
