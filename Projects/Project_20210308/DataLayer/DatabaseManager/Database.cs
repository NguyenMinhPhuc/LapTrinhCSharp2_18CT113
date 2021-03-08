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
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionStringBuilder.ToString();//Gán giá trị cho biến chứa chuỗi kết nối của SqlConnection.
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

        #region Phần code cho buổi học 14-03-2021
       //Khai báo đối tượng SqlCommand
        SqlCommand sqlCommand;
       //Khởi tạo đối tượng SqlCommand trong phương thức
       //Xây dựng phương thức Lấy database trả về SqlReader
        public SqlDataReader MyExcuteDataReader(ref string err,string commandText, CommandType commandType,params SqlParameter[] paramList )
        {
            SqlDataReader dataReader = null;
            try
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
                sqlConnection.Open();//Mở kết nối
                sqlCommand = new SqlCommand();//Khởi tạo đối tượng command
                sqlCommand.Connection = sqlConnection;//gán cho command một kết nối
                sqlCommand.CommandText = commandText;//Gán cho command một thủ tục, hoặc sql query 
                sqlCommand.CommandType = commandType;//gán cho Command một kiểu command
                sqlCommand.CommandTimeout = 600;//Cho thời gian timeout 
                if(paramList!=null)//Kiểm tra nếu có tham số thì add Parameter cho command
                foreach (SqlParameter item in paramList)
                {
                    sqlCommand.Parameters.Add(item);
                }
                dataReader = sqlCommand.ExecuteReader();//Thực thi phương thức của command trả vể một đối tượng SqlDataReader.
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return dataReader;
        }
        #endregion
    }
}
