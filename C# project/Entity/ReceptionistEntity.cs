 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
   public class ReceptionistEntity
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
     
        }
        string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        string joiningDate;

        public string JoiningDate
        {
            get { return joiningDate; }
            set { joiningDate = value; }
        }
        double salary;


        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
