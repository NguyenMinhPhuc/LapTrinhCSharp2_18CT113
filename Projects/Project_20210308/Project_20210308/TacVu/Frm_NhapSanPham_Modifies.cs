using Project_20210308.BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_20210308.TacVu
{
    public partial class Frm_NhapSanPham_Modifies : Form
    {
        public Frm_NhapSanPham_Modifies()
        {
            InitializeComponent();
        }
        BLL_NhapSanPham bd;
        string err = string.Empty;
        string maPhieuNhap = string.Empty;
        private void Frm_NhapSanPham_Modifies_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhapSanPham(Cls_Main.arrayPath,Cls_Main.fileType);
            TaoMaPhieuNhap( DateTime.Now);
        }

        private void TaoMaPhieuNhap(DateTime dateTime)
        {
            object obj = bd.LayMaxPhieuNhap(ref err, dateTime);
            maPhieuNhap=string.Format("{0:00}{1:00}{2:00000}",dateTime.Year%100,dateTime.Month,Convert.ToInt32(obj.ToString()));

            lblMaPhieuNhap.Text = maPhieuNhap;
        }
    }
}
