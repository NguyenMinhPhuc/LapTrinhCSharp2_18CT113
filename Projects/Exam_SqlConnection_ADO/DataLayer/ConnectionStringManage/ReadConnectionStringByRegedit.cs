using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ConnectionStringManage
{
    public class ReadConnectionStringByRegedit : IReadConnectString
    {
        public System.Data.SqlClient.SqlConnectionStringBuilder ReadConnectionString(string path)
        {
            throw new NotImplementedException();
        }

        public void WriteConnectionString(string path, System.Data.SqlClient.SqlConnectionStringBuilder connectionString)
        {
            throw new NotImplementedException();
        }
    }
}
