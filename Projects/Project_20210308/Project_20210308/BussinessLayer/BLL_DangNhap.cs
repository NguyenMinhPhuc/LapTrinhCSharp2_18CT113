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
   public class BLL_DangNhap:BLL_Base
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

       public bool KiemTraPhieuNhap(ref string err, ref int rows)
       {
           return data.MyExecuteNonQuery(ref err, ref rows, "PSP_PhieuNhap_KiemTraStatusPhieuNhap", CommandType.StoredProcedure, null);
       }
       public DataTable LayBangPhanQuyen(ref string err, ref int rows,string maNhanViein)
       {
           return data.MyGetDataTable(ref err, ref rows, "PSP_PhanQuyen_LayBangPhanQuyen", CommandType.StoredProcedure, new SqlParameter("@MaNhanVien", maNhanViein));
       }
       
    }
}
