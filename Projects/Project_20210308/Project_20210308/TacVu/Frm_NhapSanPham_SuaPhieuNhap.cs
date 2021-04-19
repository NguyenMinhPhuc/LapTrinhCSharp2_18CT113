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
    public partial class Frm_NhapSanPham_SuaPhieuNhap : Form
    {
        public Frm_NhapSanPham_SuaPhieuNhap()
        {
            InitializeComponent();
        }
        public string maPhieuNhap = string.Empty;
        private void Frm_NhapSanPham_SuaPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadGiaoDien();
        }

        private void LoadGiaoDien()
        {
            this.Text = string.Format("Sửa thông tin phiếu nhập: [{0}]", maPhieuNhap);
            gbThongTinPhieuNhap.Text = string.Format("Thông tin phiếu nhập: [{0}]", maPhieuNhap);
            gbChiTietPhieuNhap.Text = string.Format("Chi tiết phiếu nhập [{0}]", maPhieuNhap);
        }
    }
}
