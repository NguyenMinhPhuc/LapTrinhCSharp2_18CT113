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
            TaoMaTaiKhoan();
            txtTenTaiKhoan.Focus();
        }

        private void TaoMaTaiKhoan()
        {
            object obj = bd.LayMaxIDTaiKhoan(ref err);
            if(obj!=null)
            {
                txtMaTaiKhoan.Text = string.Format("TK{0:0000000}", Convert.ToInt32(obj));
            }
        }

        private void HienThiDanhSachTaiKhoan()
        {
            dtDanhSachTaiKhoan = new DataTable();
            dtDanhSachTaiKhoan = bd.LayDanhSachTaiKhoan(ref err, ref rows);
            dgvDanhSachTaiKhoan.DataSource = dtDanhSachTaiKhoan.DefaultView;
        }
        private void InsertUpdateTaiKhoan()
        {
            if (!string.IsNullOrEmpty(txtMaTaiKhoan.Text))
            {
                if (!string.IsNullOrEmpty(txtTenTaiKhoan.Text))
                {
                    if (bd.InsertVaUpdateTaiKhoan(ref err, ref rows, txtMaTaiKhoan.Text, txtTenTaiKhoan.Text))
                    {
                        HienThiDanhSachTaiKhoan();
                        TaoMaTaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Err: {0}", err), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(string.Format("Err: {0}", "Chưa tạo mã tài khoản"), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(string.Format("Err: {0}", "Chưa tạo mã tài khoản"), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            InsertUpdateTaiKhoan();
          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            InsertUpdateTaiKhoan();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        string maTaiKhoanXoa = string.Empty;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maTaiKhoanXoa))
            {
                if (bd.DeleteTaiKhoan(ref err, ref rows, maTaiKhoanXoa))
                {
                    HienThiDanhSachTaiKhoan();
                    maTaiKhoanXoa = string.Empty;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
            }
          
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

        private void dgvDanhSachTaiKhoan_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachTaiKhoan.Rows.Count>0)
            {
                txtMaTaiKhoan.Text = dgvDanhSachTaiKhoan.CurrentRow.Cells["colMaTaiKhoan"].Value.ToString();
                maTaiKhoanXoa = dgvDanhSachTaiKhoan.CurrentRow.Cells["colMaTaiKhoan"].Value.ToString();
                txtTenTaiKhoan.Text = dgvDanhSachTaiKhoan.CurrentRow.Cells["colTenTaiKhoan"].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TaoMaTaiKhoan();
            txtTenTaiKhoan.ResetText();
            txtTenTaiKhoan.Focus();
        }
    }
}
