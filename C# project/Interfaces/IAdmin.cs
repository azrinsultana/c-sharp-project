using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
  public  interface IAdmin
    {
      Admin GetUser(string adminUserName, string adminPassword);

    }
}
