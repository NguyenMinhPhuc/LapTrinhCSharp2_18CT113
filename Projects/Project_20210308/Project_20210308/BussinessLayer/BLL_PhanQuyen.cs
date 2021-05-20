using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.ConnectionStringManager;
using System.Data;
using System.Data.SqlClient;

namespace Project_20210308.BussinessLayer
{
    public class BLL_PhanQuyen:BLL_Base
    {
        public BLL_PhanQuyen(string[] path, FileConnectType fileTyle)
            : base(path, fileTyle)
        {
            
        }
        public DataTable LayTaiKhoanChoCbo(ref string err, ref int rows)
        {
            return data.MyGetDataTable(ref err, ref rows, "PSP_TaiKhoan_SelectCbo", CommandType.StoredProcedure, null);
        }
        public DataTable LayDanhSachPhanQuyen(ref string err, ref int rows, string maTaiKhoan)
        {
            return data.MyGetDataTable(ref err, ref rows, "PSP_PhanQuyen_HienThiChiTietPhanQuyen", CommandType.StoredProcedure, new SqlParameter("@MaTaiKhoan", maTaiKhoan));
        }
        public bool CapNhatQuyenChoUser(ref string err,ref int rows,string maTaiKhoan,string maChucnang, int tongQuyen)
        {
            return data.MyExecuteNonQuery(ref err, ref rows, "PSP_PhanQuyen_Update", CommandType.StoredProcedure,
                new SqlParameter("@MaChucNang", maChucnang),
                new SqlParameter("@MaTaiKhoan", maTaiKhoan),
                new SqlParameter("@TongQuyen", tongQuyen));
        }
        public bool CopyQuyenChoUser(ref string err, ref int rows, string maTaiKhoanNguon, string maTaiKhoanDich)
        {
            return data.MyExecuteNonQuery(ref err, ref rows, "PSP_PhanQuyen_CopyQuyen", CommandType.StoredProcedure,
                new SqlParameter("@MaTaiKhoanNguon", maTaiKhoanNguon),
                new SqlParameter("@MaTaiKhoanDich", maTaiKhoanDich)
             );
        }
    }
}
