using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.ConnectionStringManager;

namespace Project_20210308.BussinessLayer
{
    public class BLL_BanHang: BLL_Base
    {
        public BLL_BanHang(string[] path, FileConnectType fileTyle)
            : base(path, fileTyle)
        {
            
        }

    }
}
