using DataLayer.ConnectionStringManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DatabaseManager
{
   public class Database:IDisposable
    {
        SqlConnection sqlConnection;//Khai báo đối tượng của ADO.NET
        ReadConnectionStringFactory readConnect;//Đối tượng đọc chuỗi kết nối từ file.
       //Khai báo đối tượng Lưu chuỗi kết nối.
        public SqlConnectionStringBuilder connectionStringBuilder;
       //Khai báo kiểu file lưu trữ chuỗi kết nối. 
       public FileConnectType fileType;
        public void Dispose()
        {
            if (sqlConnection != null)
            {
                sqlConnection.Dispose();
                sqlConnection = null;
            }
        }
       /// <summary>
       /// Hàm tạo đối tượng Database với tham số 
       /// </summary>
       /// <param name="path">Mảng chữa đường dẫn file chữa kết nối</param>
       /// <param name="fileType">Kiểu file chữa kết nối</param>
        public Database(string[] path, FileConnectType fileType)
        {
            connectionStringBuilder = new SqlConnectionStringBuilder();//Khởi tạo đối tượng string chứa kết nối
            readConnect = new ReadConnectionStringFactory();//Khởi tạo đối tượng đọc kết nối
            readConnect.CreateReadConnectionString(fileType);//Gọi phương thực tạo đối tượng đọc kết nối.
            connectionStringBuilder = readConnect.ReadConnectionString.ReadConnectionString(path[(int)fileType]);//Đọc chuỗi kết nối từ file và lưu vào trong đối tượng SqlConnectionStringBuilder.
            this.fileType = fileType;//Lưu lại Kiểu file chứa chuỗi kết nối

            //Khởi tạo đối tượng SqlConnection.
            sqlConnection = new SqlConnection() { ConnectionString = connectionStringBuilder.ToString() /*Gán giá trị cho biến chứa chuỗi kết nối của SqlConnection.*/ };
        }
        public void WriteConnectTionString(string[] path, SqlConnectionStringBuilder connectionString)
        {
            readConnect.ReadConnectionString.WriteConnectionString(path[(int)fileType], connectionString);
        }
        public bool KiemTraKetNoi(ref string err)
        {
            try
            {
                sqlConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        #region Phần code cho buổi học 15-03-2021
      //Khai báo đối tượng SqlCommand
       private SqlCommand sqlCommand;

        //Khai báo 1 phương thức để thực thi thủ tục (store Proceduce) trong Sql Và trả về kiểu SqlDataReader
       public SqlDataReader MyExcuteReader(ref string err,string commandText,CommandType commandType,params SqlParameter[] param)
       {
           SqlDataReader dataReader = null;

           try
           {
               //mở kết nối
               if (sqlConnection.State == ConnectionState.Open)
                   sqlConnection.Close();
               sqlConnection.Open();
               //Khởi tạo đối tượng SqlCommand
               sqlCommand = new SqlCommand() { Connection = sqlConnection, CommandText = commandText, CommandType = commandType, CommandTimeout = 3000 };
               if (param != null)
               {
                   foreach (SqlParameter item in param)
                   {
                       sqlCommand.Parameters.Add(item);
                   }
               }
               dataReader = sqlCommand.ExecuteReader();
           }
           catch (Exception ex)
           {
               err = ex.Message;
           }
           
           return dataReader;
       }
       
       public bool MyExecuteNonQuery(ref string err,ref int rows, string commandText, CommandType commandType, params SqlParameter[] param)
       {
           bool result = false;
           try  {
               //mở kết nối
               if (sqlConnection.State == ConnectionState.Open)
                   sqlConnection.Close();
               sqlConnection.Open();
               //Khởi tạo đối tượng SqlCommand
               sqlCommand = new SqlCommand() { Connection = sqlConnection, CommandText = commandText, CommandType = commandType, CommandTimeout = 3000 };
               if (param != null){
                   foreach (SqlParameter item in param){
                       sqlCommand.Parameters.Add(item);
                   }
               }
               rows = sqlCommand.ExecuteNonQuery();
               result = true;
           }
           catch (Exception ex) {
               err = ex.Message;
           }
           finally { sqlConnection.Close(); }

           return result;
       }

       SqlDataAdapter dataAdapter;
       public DataTable MyGetDataTable(ref string err,ref int rows,  string commandText, CommandType commandType, params SqlParameter[] param)
       {
           DataTable result=new DataTable();
           try
           {
               //mở kết nối
               if (sqlConnection.State == ConnectionState.Open)
                   sqlConnection.Close();
               sqlConnection.Open();
               //Khởi tạo đối tượng SqlCommand
               sqlCommand = new SqlCommand() { Connection = sqlConnection, CommandText = commandText, CommandType = commandType, CommandTimeout = 3000 };
               if (param != null)
               {
                   foreach (SqlParameter item in param)
                   {
                       sqlCommand.Parameters.Add(item);
                   }
               }
              //thuc thi Command
               dataAdapter = new SqlDataAdapter(sqlCommand);
              rows= dataAdapter.Fill(result);
           }
           catch (Exception ex)
           {
               err = ex.Message;
           }
           finally { sqlConnection.Close(); }

           return result;
       }
        #endregion
    }
}
