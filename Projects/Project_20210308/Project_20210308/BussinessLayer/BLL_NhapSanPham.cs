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
    }
}
