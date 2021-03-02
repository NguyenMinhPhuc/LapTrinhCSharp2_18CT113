using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer
{
    public class Database 
    {
        private SqlConnection cnn;
        private string connectionString = string.Empty; //"Data Source=172.16.61.11;Initial Catalog=QuanLyVay;User ID=lop18ct113;Password=123456789";

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        ReadConnectionString readconnect;
        public Database(string path)
        {
            readconnect = new ReadConnectionString();

            cnn = new SqlConnection();
            cnn.ConnectionString = readconnect.DocChuoiKetNoiTuFile(path);
            connectionString = cnn.ConnectionString;
           
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
