using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repository
{
  public  class AdminRepo : IAdmin
    {
      DatabaseConnectionClass dcc;
      public AdminRepo()
      {
          dcc = new DatabaseConnectionClass();

      }
      public Admin GetUser(string adminUserName, string adminPassword)
      {
          Admin admin = null;
          string query="SELECT * from Admins WHERE AdminUserName ='"+adminUserName+"'AND AdminPassword='"+adminPassword+"'";
          dcc.ConnectWithDB();
          SqlDataReader sdr = dcc.GetData(query);

          while (sdr.Read())
          {
              admin = new Admin();
              admin.AdminUserName = sdr["AdminUserName"].ToString();
              admin.AdminPassword = sdr["AdminPassword"].ToString();
            
          }
          dcc.CloseConnection();
          return admin;

      }
    }
}
