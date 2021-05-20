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
    public class BLL_TaiKhoan:BLL_Base
    {
        public BLL_TaiKhoan(string[] path, FileConnectType fileTyle)
            : base(path, fileTyle)
        {
            
        }
        public DataTable LayDanhSachTaiKhoan(ref string err, ref int rows)
        {
            return data.MyGetDataTable(ref err, ref rows, "PSP_TaiKhoan_Select", CommandType.StoredProcedure, null);
        }
        public bool InsertVaUpdateTaiKhoan(ref string err, ref int rows, string maTaiKhoan,string tenTaiKhoan)
        {
            return data.MyExecuteNonQuery(ref err, ref rows, "PSP_TaiKhoan_InsertUpdate", CommandType.StoredProcedure,
                new SqlParameter("@MaTaiKhoan", maTaiKhoan),
                new SqlParameter("@TenTaiKhoan", tenTaiKhoan));
        }

        public bool DeleteTaiKhoan(ref string err, ref int rows, string maTaiKhoan)
        {
            return data.MyExecuteNonQuery(ref err, ref rows, "PSP_TaiKhoan_Delete",CommandType.StoredProcedure, new SqlParameter("@MaTaiKhoan", maTaiKhoan));
        }

        public object LayMaxIDTaiKhoan(ref string err)
        {
            return data.MyExecuteScalar(ref err ,"PSP_TaiKhoan_MaxID",CommandType.StoredProcedure, null);
        }

        public DataTable LayTaiKhoanChoCbo(ref string err, ref int rows)
        {
            return data.MyGetDataTable(ref err, ref rows, "PSP_NhanVien_LayNhanVienChoCombo", CommandType.StoredProcedure, null);
        }
        public bool CapLaiMatKhau(ref string err, ref int rows, string maNhanVien)
        {
            return data.MyExecuteNonQuery(ref err, ref rows, "PSP_TaiKhoan_CapLaiPass", CommandType.StoredProcedure, new SqlParameter("@MaNhanVien", maNhanVien));
        }
            public bool DoiMatKhau(ref string err, ref int rows, string maNhanVien,string matKhau)
        {
            return data.MyExecuteNonQuery(ref err, ref rows, "PSP_TaiKhoan_ThayDoiMatKhau", CommandType.StoredProcedure, new SqlParameter("@MaNhanVien", maNhanVien),
                new SqlParameter("@MatKhau", matKhau));
        }
    }
}
