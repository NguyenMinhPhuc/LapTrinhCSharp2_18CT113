using DataLayer.ConnectionStringManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_20210308
{
 public  class Cls_Main
    {

    public static string[] arrayPath = new string[] {
            Application.StartupPath+@"\Connect.ini",
            Application.StartupPath + @"\App.config",
            ""};
    public static FileConnectType fileType = FileConnectType.INI;

    public static string tenNhanVien = string.Empty;
    public static string maTaiKhoan = string.Empty;
    public static string maNhanVien = string.Empty;
    }
}
