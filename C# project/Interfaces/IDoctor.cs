using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
   public interface IDoctor
    {
       DoctorEntity GetUser(string UserId, string Password);
        bool InsertDoctor(DoctorEntity d);
        List<DoctorEntity> GetAllDoctor();
        bool UpdateDoctor(DoctorEntity d);
        bool DeleteDoctor(DoctorEntity d);
      

    }
}
