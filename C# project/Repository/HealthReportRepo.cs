using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repository
{
   public class HealthReportRepo:IHealthReport
    {
        
         DatabaseConnectionClass dcc;

         public HealthReportRepo()
        {
             
            dcc = new DatabaseConnectionClass();
        }
         public bool InsertHealthReport(HealthReportEntity hre)
        {
             
             string query = "INSERT into HealthReports VALUES('" + hre.PId + "','" + hre.Name + "',  '" + hre.Bmi+ "','" + hre.Calorie + "')";
             try
             {
                 dcc.ConnectWithDB();
                 int n = dcc.ExecuteSQL(query);
                 dcc.CloseConnection();
                 return true;
             }

             catch (Exception exp) { return false; }
         }
             

          
             
         }

       
         }
        
    

