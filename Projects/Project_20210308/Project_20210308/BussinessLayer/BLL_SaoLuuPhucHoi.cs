using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.ConnectionStringManager;
using System.Data.SqlClient;
using System.Data;


namespace Project_20210308.BussinessLayer
{
    public class BLL_SaoLuuPhucHoi: BLL_Base
    {
        public BLL_SaoLuuPhucHoi(string[] path, FileConnectType fileTyle)
            : base(path, fileTyle)
        {
            
        }

        public bool SaoLuu(ref string err,ref int rows, string path)
        {
            return data.MyExecuteNonQuery(ref err, ref rows, "PSP_SaoLuuDuLieu", CommandType.StoredProcedure, new SqlParameter("@duongdan", path));
        }
        public bool PhucHoi(string sql, ref string err,ref int rows)
        {
            return data.MyExecuteNonQuery(ref err, ref rows,sql, CommandType.Text,  null);
        }
    }
}
