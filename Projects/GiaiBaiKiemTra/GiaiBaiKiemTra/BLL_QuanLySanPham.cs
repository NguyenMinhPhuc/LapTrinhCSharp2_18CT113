using DataLayer.DatabaseManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiBaiKiemTra
{
    public class BLL_QuanLySanPham
    {
        Database data;
        public BLL_QuanLySanPham()
        {
            data = new Database();
        }
        public DataTable LayDanhSachSanPham(ref string err, ref int rows )
        {
            return data.MyGetDataTable(ref err, ref rows, "SP_SanPham_Select", CommandType.StoredProcedure, null);
        }

        public DataTable LayDanhSachSanPhamBaoCao(ref string err, ref int rows)
        {
            return data.MyGetDataTable(ref err, ref rows, "SP_SanPham_BaoCao", CommandType.StoredProcedure, null);
        }
        public bool XoaSanPham(ref string err,ref int rows, string maSP)
        {
            return data.MyExecuteNonQuery(ref err, ref rows, "SP_SanPham_Delete", CommandType.StoredProcedure, new SqlParameter("@MaSP", maSP));
        }

        public bool ThemSanPham(ref string err, ref int rows, string tenSP,string donViTinh,double donGia)
        {
            return data.MyExecuteNonQuery(ref err, ref rows, "SP_SanPham_Insert", CommandType.StoredProcedure, 
                new SqlParameter("@TenSP", tenSP), 
                new SqlParameter("@DonViTinh", donViTinh), 
                new SqlParameter("@DonGia", donGia));
        }
    }
}
