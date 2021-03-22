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
    public partial class Frm_NhanVien_Modifies : Form
    {
        public Frm_NhanVien_Modifies()
        {
            InitializeComponent();
        }
        BLL_NhanVien bd;
        string err = string.Empty;
        int rows = 0;
        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Frm_NhanVien_Modifies_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhanVien(Cls_Main.arrayPath, Cls_Main.fileType);
            LoadDataForCboTaiKhoan();

        }

        private void LoadDataForCboTaiKhoan()
        {
            DataTable dt = new DataTable();
            dt = bd.LayLoaiTaiKhoanCbo(ref err, ref rows);

            cboLoaiTaiKhoan.DataSource = dt;

            cboLoaiTaiKhoan.DisplayMember = "TenTaiKhoan";
            cboLoaiTaiKhoan.ValueMember = "MaTaiKhoan";
            cboLoaiTaiKhoan.SelectedIndex = -1;
            cboLoaiTaiKhoan.Text = "--Chọn tài khoản";
        }
    }
}
