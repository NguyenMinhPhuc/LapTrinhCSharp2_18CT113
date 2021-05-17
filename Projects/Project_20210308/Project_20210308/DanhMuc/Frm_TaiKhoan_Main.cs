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

namespace Project_20210308.DanhMuc
{
    public partial class Frm_TaiKhoan_Main : Form
    {
        public Frm_TaiKhoan_Main()
        {
            InitializeComponent();
        }
        BLL_TaiKhoan bd;
        string err = string.Empty;
        int rows=0;
        DataTable dtDanhSachTaiKhoan;


        private void Frm_TaiKhoan_Main_Load(object sender, EventArgs e)
        {
            bd = new BLL_TaiKhoan(Cls_Main.arrayPath, Cls_Main.fileType);
            HienThiDanhSachTaiKhoan();
            txtTenTaiKhoan.Focus();
        }

        private void HienThiDanhSachTaiKhoan()
        {
            //dtDanhSachTaiKhoan = new DataTable();
            //dtDanhSachTaiKhoan = null;
            //dgvDanhSachTaiKhoan.DataSource = dtDanhSachTaiKhoan.DefaultView;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            HienThiDanhSachTaiKhoan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            HienThiDanhSachTaiKhoan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            HienThiDanhSachTaiKhoan();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            Frm_NhanVien_Main frmNhanVien = new Frm_NhanVien_Main();
            frmNhanVien.ShowDialog();
        }
    }
}
