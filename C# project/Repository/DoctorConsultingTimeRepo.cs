using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace Repository
{
    public class DoctorConsultingTimeRepo:IDoctorConsultingTime
    {
        DatabaseConnectionClass dcc;
        public DoctorConsultingTimeRepo()
        {
            dcc = new DatabaseConnectionClass();
        }

        public DoctorEntity GetDoctor(string UserId)
        {

            DoctorEntity dra = null;
            string query = "SELECT Name ,UserId from Doctors WHERE UserId ='" + UserId + "'";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                dra = new DoctorEntity();
                dra.UserId = sdr["UserId"].ToString();
                dra.Name= sdr["Name"].ToString();
                //d.Password = sdr["Password"].ToString();


            }
            dcc.CloseConnection();
            return dra;

        }

       
        public bool InsertDoctorConsultingTime(DoctorConsultingTimeEntity d)
        {
            string query = "INSERT into Consultings VALUES('" + d.DoctorId + "','" + d.Name + "','" + d.Saturday + "','" + d.Sunday + "','" + d.Monday + "','" + d.Tuesday + "','" + d.Wednesday + "','" + d.Thrusday + "','" + d.Friday + "')";
            try
            {
                // Console.WriteLine("from relpo"+query);
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;

            }
            catch (Exception exp) { return false; }
        }

        public List<DoctorConsultingTimeEntity> GetAllConsultingTime()
        {
            List < DoctorConsultingTimeEntity > listOfConsultingTime = new List<DoctorConsultingTimeEntity>();
            string query = "SELECT * FROM Consultings";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                DoctorConsultingTimeEntity d = new DoctorConsultingTimeEntity();
                d.DoctorId = sdr["DoctorId"].ToString();
                d.Name = sdr["Name"].ToString();
                d.Saturday = sdr["Saturday"].ToString();
                d.Sunday = sdr["Sunday"].ToString();
                d.Monday = sdr["Monday"].ToString();
                d.Tuesday = sdr["Tuesday"].ToString();
                d.Wednesday = sdr["Wednesday"].ToString();
                d.Thrusday = sdr["Thursday"].ToString();
                d.Friday = sdr["Friday"].ToString();
               
                listOfConsultingTime.Add(d);
            }
            dcc.CloseConnection();

            return listOfConsultingTime;
        } 

    }
}
