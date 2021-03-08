using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ConnectionStringManager
{
   public enum FileConnectType
    {
       INI=0,//lưu vào file INI
       APPCONFIG=1,//Lưu vào file App.cofig
       REGEDIT=2,
       BINARY=3
    }
}
