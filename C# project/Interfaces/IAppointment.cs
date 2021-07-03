using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
  public  interface IAppointment
    {
        bool InsertAppointment(AppointmentEntity p);
        
    }
}
