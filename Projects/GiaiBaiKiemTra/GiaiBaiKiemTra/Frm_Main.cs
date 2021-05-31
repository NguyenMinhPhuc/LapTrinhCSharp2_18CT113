using DataLayer.DatabaseManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiBaiKiemTra
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void mnuThongTinSinhVien_Click(object sender, EventArgs e)
        {
            Frm_ThongTinSinhVien frmThongTin = new Frm_ThongTinSinhVien();
            frmThongTin.MdiParent = this;
            frmThongTin.Show();
        }

        private void mnuQuanLySanPham_Click(object sender, EventArgs e)
        {
            Frm_QuanLySanPham frmQuanLySanPham = new Frm_QuanLySanPham();
            frmQuanLySanPham.MdiParent = this;
            frmQuanLySanPham.Show();
        }
        Database data;
        string err = string.Empty;
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            data = new Database();
            if(data.KiemTraKetNoi(ref err))
            {
                Frm_ThongTinSinhVien frmThongTin = new Frm_ThongTinSinhVien();
                frmThongTin.MdiParent = this;
                frmThongTin.Show();
            }

        }
    }
}
