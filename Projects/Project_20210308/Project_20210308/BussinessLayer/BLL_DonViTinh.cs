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
    public class BLL_DonViTinh:BLL_Base
    {
        public BLL_DonViTinh(string[] path, FileConnectType fileTyle)
            : base(path, fileTyle)
        {
            
        }
        public DataTable GetListDonViTinh(ref string err, ref int rows)
        {
            return data.MyGetDataTable(ref err, ref rows, "", CommandType.StoredProcedure, null);
        }
        public bool InsertUpdateDonViTinh(ref string err,ref int rows,DonViTinh donViTinh)
        {
            return data.MyExecuteNonQuery(ref err, ref rows, "", CommandType.StoredProcedure,
                new SqlParameter("@MaDVT", donViTinh.MaDVT),
                new SqlParameter("@TenDVT", donViTinh.TenDVT));
        }

        public bool DeleteDonViTinh(ref string err, ref int rows, DonViTinh donViTinh)
        {
            return data.MyExecuteNonQuery(ref err, ref rows, "", CommandType.StoredProcedure,
                new SqlParameter("@MaDVT", donViTinh.MaDVT));
        }
    }
}
