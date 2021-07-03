using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
  public  interface IReceptionist
    {
        ReceptionistEntity GetUser(string UserName, string Password);
        bool InsertReceptionist(ReceptionistEntity r);
        bool DeleteReceptionist(ReceptionistEntity r);
        bool UpdateReceptionist(ReceptionistEntity r);
      //  ReceptionistEntity GetReceptionist(string Id);
        List<ReceptionistEntity> GetAllReceptionist();

      
    }
}
