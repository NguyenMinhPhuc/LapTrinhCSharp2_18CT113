using DataLayer.ConnectionStringManage;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DatabaseManager
{
    public class Database : IDisposable
    {
        SqlConnection cnn;
        ReadConnectionStringFactory readConnect;
        public SqlConnectionStringBuilder connectionStringBuilder;
        public FileConnectType fileType;
        public void Dispose()
        {
            if (cnn != null)
            {
                cnn.Dispose();
                cnn = null;
            }
        }

        public Database(string[] path, FileConnectType fileType)
        {
            connectionStringBuilder = new SqlConnectionStringBuilder();
            readConnect = new ReadConnectionStringFactory();
            readConnect.CreateReadConnectionString(fileType);
            connectionStringBuilder = readConnect.ReadConnectionString.ReadConnectionString(path[(int)fileType]);
            this.fileType = fileType;
            cnn = new SqlConnection();
            cnn.ConnectionString = connectionStringBuilder.ToString();
        }
        public void WriteConnectTionString(string[] path, SqlConnectionStringBuilder connectionString)
        {
            readConnect.ReadConnectionString.WriteConnectionString(path[(int)fileType], connectionString);
        }
        public bool KiemTraKetNoi(ref string err)
        {
            try
            {
                cnn.Open();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
