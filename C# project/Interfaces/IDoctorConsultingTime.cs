using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
   public interface IDoctorConsultingTime
    {
       bool InsertDoctorConsultingTime(DoctorConsultingTimeEntity d);
        List<DoctorConsultingTimeEntity> GetAllConsultingTime();
    }
}
