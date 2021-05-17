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
    public class BLL_GiaBan:BLL_Base
    {
        public BLL_GiaBan(string[] path, FileConnectType fileTyle)
            : base(path, fileTyle)
        {
            
        }
        public DataTable LayDanhSachGiaBanHienHanh(ref string err, ref int rows)
        {
            return data.MyGetDataTable(ref err, ref rows, "PSP_ChiTietGiaban_Select", CommandType.StoredProcedure, null);
        }

        public bool DoiGiaBanHienHanh(ref string err,ref int rows,string maSanPham,double giaBanHienHanh)
        {
            return data.MyExecuteNonQuery(ref err, ref rows, "PSP_ChiTietGiaBan_UpdateGia", CommandType.StoredProcedure,
                new SqlParameter("@MaSP", maSanPham),
                new SqlParameter("@GiaBanHienHanh", giaBanHienHanh));
        }
    }
}
