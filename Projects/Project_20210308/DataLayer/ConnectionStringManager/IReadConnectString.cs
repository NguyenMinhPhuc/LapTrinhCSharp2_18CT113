using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ConnectionStringManager
{
   public interface IReadConnectString
    {
       SqlConnectionStringBuilder ReadConnectionString(string path);
       void WriteConnectionString(string path, SqlConnectionStringBuilder connectionString);
    }
}
