using DataLayer.ConnectionStringManager;
using Project_20210308.BussinessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Project_20210308
{

    public class Cls_Main
    {


        public static string[] arrayPath = new string[] {
            Application.StartupPath+@"\Connect.ini",
            Application.StartupPath + @"\App.config",
            ""};
        public static FileConnectType fileType = FileConnectType.INI;
        public static Hashtable BangPhanQuyen = new Hashtable();

        public static BLL_DangNhap bd = new BLL_DangNhap(arrayPath, fileType);
        public static void LayThongTinQuyenTheoUser(ref string err, ref int rows, string maNhanVien)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = bd.LayBangPhanQuyen(ref err, ref rows, maNhanVien);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        if (!Cls_Main.BangPhanQuyen.ContainsKey(item["KyHieu"].ToString()))
                        {
                            Cls_Main.BangPhanQuyen.Add(item["KyHieu"].ToString(), Convert.ToInt32(item["GiaTriQuyen"].ToString()));
                        }
                        else
                        {
                            Cls_Main.BangPhanQuyen[item["KyHieu"].ToString()] = Convert.ToInt32(item["GiaTriQuyen"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                err = ex.Message;
            }

        }
        public static bool KiemTraQuyen(int tongQuyen, int value)
        {

            return (tongQuyen & value) == value;
        }
        public static string tenNhanVien = string.Empty;
        public static string maTaiKhoan = string.Empty;
        public static string maNhanVien = string.Empty;

    }
}
