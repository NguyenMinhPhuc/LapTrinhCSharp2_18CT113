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
    public class BLL_BanHang: BLL_Base
    {
        public BLL_BanHang(string[] path, FileConnectType fileTyle)
            : base(path, fileTyle)
        {
            
        }

        public DataTable LayDanhSachSanPham(ref string err, ref int rows)
        {
            return data.MyGetDataTable(ref err, ref rows, "PSP_SanPham_LayDanhSachBan", CommandType.StoredProcedure, null);
        }
        public DataTable LayChiTietHoaDon(ref string err, ref int rows,string maHD)
        {
            return data.MyGetDataTable(ref err, ref rows, "PSP_ChiTietHoaDon_Select", CommandType.StoredProcedure, new SqlParameter("@MaHD", maHD));
        }
    //    PSP_ChiTietHoaDon_InsertChiTietHoaDon
    //@MaHD CHAR(9) ,
    //@MaSP CHAR(9) ,
    //@SoLuongBan INT ,
    //@DonGiaBan FLOAT ,
    //@NgayLap DATE ,
    //@MaNhanVien CHAR(9)
        public bool InsertHoaDon(ref string err, ref int rows, string maHD,string maSP,int soLuongBan,double donGia,DateTime ngayLap,string maNhanVien)
        {
            SqlParameter[] param = new SqlParameter[] { 
                new SqlParameter("@MaHD",maHD),
                new SqlParameter("@MaSP",maSP),
                new SqlParameter("@SoLuongBan",soLuongBan),
                new SqlParameter("@DonGiaBan",donGia),
                new SqlParameter("@NgayLap",ngayLap),
                new SqlParameter("@MaNhanVien",maNhanVien)
            };
            return data.MyExecuteNonQuery(ref err, ref rows, "PSP_ChiTietHoaDon_InsertChiTietHoaDon", CommandType.StoredProcedure, param);
        }

        public object LayMaHDMax(ref string err, DateTime ngayLap)
        {
            return data.MyExecuteScalar(ref err, "PSP_HoaDon_MaxID", CommandType.StoredProcedure, new SqlParameter("@NgayLap", ngayLap))
;
        }
    }
}
