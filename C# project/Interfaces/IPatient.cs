using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    interface IPatient
    {
        List<PatientEntity> GetAllPatient();
        bool InsertPatient(PatientEntity p);
        bool UpdatePatient(PatientEntity p);
        bool DeletePatient(PatientEntity p);
        PatientEntity GetPatient(string UserId);

    }
}
