using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Khai báo thêm namespace
using System.Data;
using System.Data.SqlClient;


namespace DataLayer.DatabaseManager
{
    public class Database
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter dataApdapter;

        string connectionString = "server=MinhPhuc;Database=HoaDon;integrated security=true";
        public Database()
        {
            sqlConnection = new SqlConnection() { ConnectionString = connectionString };
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


        //Khai báo 1 phương thức để thực thi thủ tục (store Proceduce) trong Sql Và trả về kiểu SqlDataReader
        public SqlDataReader MyExcuteReader(ref string err, string commandText, CommandType commandType, params SqlParameter[] param)
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

        public bool MyExecuteNonQuery(ref string err, ref int rows, string commandText, CommandType commandType, params SqlParameter[] param)
        {
            bool result = false;
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
                rows = sqlCommand.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally { sqlConnection.Close(); }

            return result;
        }

        SqlDataAdapter dataAdapter;
        public DataTable MyGetDataTable(ref string err, ref int rows, string commandText, CommandType commandType, params SqlParameter[] param)
        {
            DataTable result = new DataTable();
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
                rows = dataAdapter.Fill(result);
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally { sqlConnection.Close(); }

            return result;
        }

        public object MyExecuteScalar(ref string err, string commandText, CommandType commandType, params SqlParameter[] param)
        {
            object result = null;
            try
            {
                if (sqlConnection.State == ConnectionState.Open)     //mở kết nối
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
                result = sqlCommand.ExecuteScalar();
            }
            catch (Exception ex) { err = ex.Message; }
            finally { sqlConnection.Close(); }
            return result;
        }
        #endregion
    }
}
