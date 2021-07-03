using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
   public class DoctorEntity
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string userId;

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
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
        string degree;

        public string Degree
        {
            get { return degree; }
            set { degree = value; }
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
