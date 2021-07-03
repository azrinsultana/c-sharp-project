using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
   public class PatientEntity
    {
        string userId;

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
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
        string bloodGroup;

        public string BloodGroup
        {
            get { return bloodGroup; }
            set { bloodGroup = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
