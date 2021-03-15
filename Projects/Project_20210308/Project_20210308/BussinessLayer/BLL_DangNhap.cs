using DataLayer.ConnectionStringManager;
using DataLayer.DatabaseManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_20210308.BussinessLayer
{
   public class BLL_DangNhap:BLL_Basic
    {
       public BLL_DangNhap(string[] path, FileConnectType fileTyle)
           : base(path, fileTyle)
       {
           
       }       

       public SqlDataReader KiemTraDangNhap(ref string err,string tenDangNhap,string matKhau)
       {
           return data.MyExcuteReader(ref err,"PSP_NhanVien_CheckLogin", CommandType.StoredProcedure,
               new SqlParameter("@TenDangNhap", tenDangNhap),
               new SqlParameter("@MatKhau", matKhau));
       }
    }
}
