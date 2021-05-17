using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.ConnectionStringManager;
using System.Data.SqlClient;

namespace Project_20210308.BussinessLayer
{
    public class BLL_ThongKe:BLL_Base
    {
        public BLL_ThongKe(string[] path, FileConnectType fileTyle)
            : base(path, fileTyle)
        {
            
        }
        public DataTable GetNhanVienForCombo(ref string err,ref int rows)
        {
            return data.MyGetDataTable(ref err, ref rows, "PSP_NhanVien_LayNhanVienChoCombo", CommandType.StoredProcedure, null);
        }
        public DataTable GetDoanhThuWithDateTime(ref string err, ref int rows,DateTime beginDate,DateTime endDate)
        {
            return data.MyGetDataTable(ref err, ref rows, "PSP_ThongKe_DoanhThuTheoNgayThang", CommandType.StoredProcedure,
                new SqlParameter("@BeginDate", beginDate),
                new SqlParameter("@EndDate", endDate));
        }



    }
}
