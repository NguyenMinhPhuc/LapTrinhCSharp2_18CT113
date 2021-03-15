using DataLayer.ConnectionStringManager;
using DataLayer.DatabaseManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_20210308.BussinessLayer
{
    public class BLL_Basic : IDisposable
    {
      
      public Database data;
      public void Dispose()
      {
          if (data != null)
          {
              data.Dispose();
              data = null;
          }
      }
      public BLL_Basic(string[] path,FileConnectType fileTyle)
       {
           data = new Database(path, fileTyle);
       }
    }
}
