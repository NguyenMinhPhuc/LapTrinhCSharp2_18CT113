using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.ConnectionStringManager;
using System.Data;
using System.Data.SqlClient;
using Project_20210308.DAO;

namespace Project_20210308.BussinessLayer
{
    public class BLL_NhapSanPham:BLL_Basic
    {
        public BLL_NhapSanPham(string[] path, FileConnectType fileTyle)
            : base(path, fileTyle)
        {
            
        }

        public DataTable LayChiTietNhapSanPham(ref string err,ref int rows)
        {
            return data.MyGetDataTable(ref err, ref rows, "PSP_ChiTietPhieuNhap_Select", CommandType.StoredProcedure, null);
        }

        public object LayMaxPhieuNhap(ref string err,DateTime date)
        {
            return data.MyExecuteScalar(ref err, "PSP_PhieuNhap_LayMaxMaPhieuNhap", CommandType.StoredProcedure,
                new SqlParameter("@Year", date.Year),
                new SqlParameter("@Month", date.Month));
        }
        public bool InsertPhieuNhap(ref string err, ref int rows, PhieuNhap phieuNhap)
        {
            return data.MyExecuteNonQuery(ref err, ref rows, "PSP_PhieuNhap_Insert", CommandType.StoredProcedure,
                new SqlParameter("@MaPhieuNhap", phieuNhap.MaPhieuNhap),
                 new SqlParameter("@MaNhanVien", phieuNhap.MaNhanVien));
        }

        public bool DeletePhieuNhap(ref string err, ref int rows, string maPhieuNhap)
        {
            return data.MyExecuteNonQuery(ref err, ref rows, "PSP_PhieuNhap_Delete", CommandType.StoredProcedure,
                new SqlParameter("@MaPhieuNhap", maPhieuNhap));
        }

        public DataTable KiemTraSanPhamTonTai(ref string err,ref int rows,string tenSanPham)
        {
            return data.MyGetDataTable(ref err, ref rows, "PSP_SanPham_KiemTraSanPhamTheoTen", CommandType.StoredProcedure, new SqlParameter("@TenSanPham", tenSanPham));
        }
    }
}
