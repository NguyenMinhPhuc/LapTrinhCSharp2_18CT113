using Project_20210308.BussinessLayer;
using Project_20210308.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        int rows = 0;
        string maPhieuNhap = string.Empty;

        bool statusPhieuNhap = false;//false: phieu nhap chưa hoàn thành
        private void Frm_NhapSanPham_Modifies_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhapSanPham(Cls_Main.arrayPath,Cls_Main.fileType);
            TaoMaPhieuNhap( DateTime.Now);
            InsertPhieuNhap(maPhieuNhap, Cls_Main.maNhanVien);
            LoadCboDonViTinh();
            txtMaSanPham.Focus();
        }

        private void LoadCboDonViTinh()
        {
            DataTable dtDonViTinh = new DataTable();
            dtDonViTinh = null;//Lấy data trong bảng DonViTinh đưa vào comboBox
            cboDonViTinh.DataSource = dtDonViTinh;
            cboDonViTinh.ValueMember = "MaDVT";
            cboDonViTinh.DisplayMember = "TenDVT";
            cboDonViTinh.SelectedIndex = -1;
            cboDonViTinh.Text = "--- Chọn DVT ---";
        }

        private void InsertPhieuNhap(string maPhieuNhap, string maNhanVien)
        {
            PhieuNhap phieuNhap = new PhieuNhap()
            {
                MaPhieuNhap = maPhieuNhap,
                MaNhanVien = maNhanVien
            };
            if (bd.InsertPhieuNhap(ref err, ref rows, phieuNhap))
            {
                lblerr.Text = "Tạo phiếu thành công";
                lblerr.ForeColor = Color.Blue;
            }
            else
            {
                lblerr.Text = err;
                lblerr.ForeColor = Color.Red;
            }
        }

        private void TaoMaPhieuNhap(DateTime dateTime)
        {
            object obj = bd.LayMaxPhieuNhap(ref err, dateTime);
            maPhieuNhap=string.Format("{0:00}{1:00}{2:00000}",dateTime.Year%100,dateTime.Month,Convert.ToInt32(obj.ToString()));

            lblMaPhieuNhap.Text = maPhieuNhap;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            statusPhieuNhap = true;
            //Cập nhật thuộc tính StatusPhieuNhap=1

            //Thực hiện In Phiếu nhập

        }

        private void Frm_NhapSanPham_Modifies_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!statusPhieuNhap)
            {
                if (MessageBox.Show(string.Format("Việc tắt của sổ nhập hàng khi trạng thái nhập chưa hoàn thành sẽ gây thiếu tính nhất quán trong dữ liệu\n Do đó, Phiếu nhập {0} sẽ bị xóa khỏi dữ liệu.\n Nếu không muốn xóa phiếu nhập và quay lại hoàn thành phiếu nhập này hãy chọn Cacel, Ngược lại chọn OK", maPhieuNhap), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    //Xóa
                    if(bd.DeletePhieuNhap(ref err, ref rows, maPhieuNhap))
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else {e.Cancel = true; }
                    
            }
        }

        private void txtTenSanPham_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenSanPham.Text))
            {
                DataTable dtKiemTra = bd.KiemTraSanPhamTonTai(ref err, ref rows, txtTenSanPham.Text);
                if (dtKiemTra.Rows.Count > 0)
                {
                    if (dtKiemTra.Rows[0]["result"].ToString().Equals("1"))
                    {
                        //san pham da co
                        txtMaSanPham.Text = dtKiemTra.Rows[0]["MaSP"].ToString();
                        cboDonViTinh.SelectedValue = dtKiemTra.Rows[0]["MaDVT"].ToString();
                        txtDonGia.Text = "0";
                        txtSoLuong.Focus();
                    }
                    else
                    {
                        //san pham chua co
                        //tap moi ma san pham
                        txtMaSanPham.Text = TaoMaSanPham();
                        txtSoLuong.Focus();
                    }
                }
            }
        }

        private string TaoMaSanPham()
        {
            object obj = 1;
            return string.Format("SP{0:0000000}", Convert.ToInt32(obj));
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Kiểm tra chỉ cho phép nhập số
            string decimalString = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char decimalChar = Convert.ToChar(decimalString);

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { }
            else if (e.KeyChar == decimalChar && txtSoLuong.Text.IndexOf(decimalString) == -1)
            { }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Kiểm tra chỉ cho phép nhập số
            string decimalString = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char decimalChar = Convert.ToChar(decimalString);

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { }
            else if (e.KeyChar == decimalChar && txtDonGia.Text.IndexOf(decimalString) == -1)
            { }
            else
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Thực hiện lệnh thêm data vào trong bảng ChiTietPhieuNhap.
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Thực hiện lệnh hủy bỏ (xóa control) trở về trạng thái nhập ban đầu
        }
    }
}
