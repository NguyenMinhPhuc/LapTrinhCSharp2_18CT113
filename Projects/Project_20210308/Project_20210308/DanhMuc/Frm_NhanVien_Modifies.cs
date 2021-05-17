using Project_20210308.BussinessLayer;
using Project_20210308.DAO;
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
        public bool isAdd = false;
        private void Frm_NhanVien_Modifies_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhanVien(Cls_Main.arrayPath, Cls_Main.fileType);
            LoadDataForCboTaiKhoan();
            //kiem tra them hay sua
            if(isAdd)
            {
               txtMaNhanVien.Text= SinhMaNhanVien();
               txtTenNhanVien.Focus();
            }
            else
            {
                //Gan thong tin nhan vien
                GanNhanVienVaoConstrol(nhanVien);
            }

        }

        private void GanNhanVienVaoConstrol(NhanVien nhanVien)
        {
            txtMaNhanVien.Text = nhanVien.MaNhanVien;
            txtTenNhanVien.Text = nhanVien.TenNhanVien;
            rdoGioiTinhNam.Checked = nhanVien.GioiTinh;
            dtpNgaySinh.Value = nhanVien.NgaySinh;
            txtDienThoai.Text = nhanVien.DienThoai;
            txtTenDangNhap.Text = nhanVien.TenDangNhap;
            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
            cboLoaiTaiKhoan.SelectedValue = nhanVien.MaTaiKhoan;
            cboLoaiTaiKhoan.Enabled = false;
        }

        private string SinhMaNhanVien()
        {
            string maNhanVien = string.Empty;
            object obj = bd.GetMaxNhanVienID(ref err);
            if(obj!=null)
            {
                maNhanVien = string.Format("NV{0:0000000}", Convert.ToInt32(obj));
            }
            return maNhanVien;
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                if(cboLoaiTaiKhoan.SelectedIndex>=0)
                {
                    //Lay du lieu vao nhan vien
                    LayDuLieuNhanVienTuConstrol();
                    //thực hiện lệnh insert
                   if( bd.InsertUpdateNhanVien(ref err,ref rows,nhanVien))
                   {
                       MessageBox.Show(string.Format("Thêm thành công, Xin vui lòng nhập lại"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       this.Close();
                   }else
	                {
                       MessageBox.Show(string.Format("Thêm không thành công \n{0}, Xin vui lòng nhập lại",err), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
	                }
                }
                else
                {
                    MessageBox.Show("Chưa chọn lại tài khoản, Xin vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chưa có mã nhân viên, Xin vui lòng nhập lại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        public NhanVien nhanVien=new NhanVien();
        private void LayDuLieuNhanVienTuConstrol()
        {
            nhanVien = new NhanVien()
            {
                MaNhanVien=txtMaNhanVien.Text,
                TenNhanVien=txtTenNhanVien.Text,
                GioiTinh=rdoGioiTinhNam.Checked,
                NgaySinh=dtpNgaySinh.Value,
                DienThoai=txtDienThoai.Text,
                TenDangNhap=txtTenDangNhap.Text,
                MatKhau=txtMatKhau.Text,
                MaTaiKhoan=cboLoaiTaiKhoan.SelectedValue.ToString()
            };
        }

        private void btnThemLoaiTaiKhoan_Click(object sender, EventArgs e)
        {
            Frm_TaiKhoan_Main frmTaiKhoan = new Frm_TaiKhoan_Main();
            frmTaiKhoan.ShowDialog();
            LoadDataForCboTaiKhoan();
        }
    }
}
