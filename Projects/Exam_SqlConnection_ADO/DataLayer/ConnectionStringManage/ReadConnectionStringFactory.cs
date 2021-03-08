using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.ConnectionStringManage;

namespace DataLayer.ConnectionStringManage
{
   public class ReadConnectionStringFactory:IReadConnectFactory
    {
        IReadConnectString readConnectionString;

        internal IReadConnectString ReadConnectionString
        {
            get { return readConnectionString; }
            set { readConnectionString = value; }
        }
       public void CreateReadConnectionString(FileConnectType fileType)
        {
            switch (fileType)
            {
               case FileConnectType.INI:
                    readConnectionString = new ReadConnectionStringByText();
                    break;
               case FileConnectType.APPCONFIG:
                    readConnectionString = new ReadConnectionStringByAppConfig();
                    break;
               case FileConnectType.REGEDIT:
                    readConnectionString = new ReadConnectionStringByRegedit();
                    break;
               case FileConnectType.BINARY:
                    readConnectionString = new ReadConnectionStringByBinary();
                    break;
                default:
                      readConnectionString = new ReadConnectionStringByText();
                    break;
            }
        }
    }
}
