using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.ConnectionStringManager;
using System.Data;
using Project_20210308.DAO;
using System.Data.SqlClient;

namespace Project_20210308.BussinessLayer
{
    public class BLL_NhanVien:BLL_Base
    {
        public BLL_NhanVien(string[] path, FileConnectType fileTyle)
            : base(path, fileTyle)
        {
            
        }
        //Viết phương thức lấy nhân viên
        public DataTable GetDSNhanVien(ref string err,ref int rows)
        {
            return data.MyGetDataTable(ref err, ref rows, "PSP_NhanVien_Select", CommandType.StoredProcedure, null);
        }
        public bool InsertUpdateNhanVien(ref string err, ref int rows,NhanVien nhanVien)
        {
            return data.MyExecuteNonQuery(ref err, ref rows, "PSP_NhanVien_InsertUpdate", CommandType.StoredProcedure,
               new SqlParameter("@MaNhanVien",nhanVien.MaNhanVien),
               new SqlParameter("@TenNhanVien",nhanVien.TenNhanVien),
               new SqlParameter("@DienThoai",nhanVien.DienThoai),
               new SqlParameter("@NgaySinh",nhanVien.NgaySinh),
               new SqlParameter("@TenDangNhap",nhanVien.TenDangNhap),
               new SqlParameter("@MatKhau",nhanVien.MatKhau),
               new SqlParameter("@MaTaiKhoan",nhanVien.MaTaiKhoan),
               new SqlParameter("@GioiTinh",nhanVien.GioiTinh));
        }
        public bool DeleteNhanVien(ref string err, ref int rows, NhanVien nhanVien)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@MaNhanVien", nhanVien.MaNhanVien)
            };

            return data.MyExecuteNonQuery(ref err, ref rows, "PSP_NhanVien_Delete", CommandType.StoredProcedure,
               param);
        }

        public DataTable LayLoaiTaiKhoanCbo(ref string err,ref int rows)
        {
            return data.MyGetDataTable(ref err, ref rows, "PSP_TaiKhoan_LayLoaiThaiKhoancbo", CommandType.StoredProcedure, null);
        }
        public object GetMaxNhanVienID(ref string err)
        {
            return data.MyExecuteScalar(ref err, "PSP_NhanVien_LayMaxMaNV", CommandType.StoredProcedure, null);
        }
    }
}
