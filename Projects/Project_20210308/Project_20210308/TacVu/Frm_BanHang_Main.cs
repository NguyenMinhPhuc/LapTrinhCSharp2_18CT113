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
    public partial class Frm_BanHang_Main : Form
    {
        public Frm_BanHang_Main()
        {
            InitializeComponent();
        }
        BLL_BanHang bd;
        string err = string.Empty;
        int rows = 0;
        DataTable dtDanhSachSanPhamBan;
        string maHD = string.Empty;
        DataTable dtChiTietHoaDon;
        string maSP;
        int soLuongBan;
        double donGiaBan;
        private void dgvDanhSachSanPham_DoubleClick(object sender, EventArgs e)
        {
            //Chọn sản phẩm bán
            //Them du lieu vao trong bang chi tiet ba.
           
            ThemSanPham(maHD, maSP, soLuongBan, donGiaBan, dtpNgayLap.Value, Cls_Main.maNhanVien); 
        }

        private void ThemSanPham(string maHD, string maSP, int soLuongBan, double donGiaBan, DateTime ngayLap, string maNhanVien)
        {
            if (!string.IsNullOrEmpty(maHD) && !string.IsNullOrEmpty(maSP))
            {
                if (bd.InsertHoaDon(ref err, ref rows, maHD, maSP, soLuongBan, donGiaBan, ngayLap, maNhanVien))
                {
                    HienThiChiTietHoaDon(maHD);
                    HienThiDanhSachSanPham();
                }
                else
                {
                    MessageBox.Show(string.Format("Err: {0}",err), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(string.Format("Chưa chọn tạo mã hóa đơn hoặc mã sản phẩm"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        double tongThanhTien = 0;
        private void HienThiChiTietHoaDon(string maHD)
        {
            dtChiTietHoaDon = new DataTable();
            dtChiTietHoaDon = bd.LayChiTietHoaDon(ref err, ref rows, maHD);
            foreach (DataRow item in dtChiTietHoaDon.Rows)
            {
                tongThanhTien += Convert.ToDouble(item["ThanhTien"].ToString());
            }
            dgvDanhSachChiTietHoaDon.DataSource = dtChiTietHoaDon.DefaultView;
            txtTongThanhTien.Text = string.Format("{0:#,###0}", tongThanhTien);
        }

        private void Frm_BanHang_Main_Load(object sender, EventArgs e)
        {
            bd = new BLL_BanHang(Cls_Main.arrayPath,Cls_Main.fileType);
            HienThiDanhSachSanPham();
            TaoMaHoaDon(dtpNgayLap.Value);
            lblTenNhanVien.Text = Cls_Main.tenNhanVien;
        }

        private void TaoMaHoaDon(DateTime ngayLap)
        {
            Object obj = bd.LayMaHDMax(ref err, ngayLap);
            if(obj!=null)
            {
                maHD = string.Format("{0}{1:00}{2:00}{3:000}", dtpNgayLap.Value.Year.ToString().Substring(2,2).Trim(), dtpNgayLap.Value.Month, dtpNgayLap.Value.Day, Convert.ToInt32(obj));
                lblMaHoaDon.Text = maHD;
            }
        }

        private void HienThiDanhSachSanPham()
        {
            dtDanhSachSanPhamBan = new DataTable();
            dtDanhSachSanPhamBan = bd.LayDanhSachSanPham(ref err, ref rows);
            dgvDanhSachSanPham.DataSource = dtDanhSachSanPhamBan.DefaultView;
        }

        private void txtLocDuLieu_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtDanhSachSanPhamBan.DefaultView;
            dv.RowFilter = "";
            if(!string.IsNullOrEmpty(txtLocDuLieu.Text))
            {

                if(ckbMaSanpham.Checked)
                {
                    dv.RowFilter = string.Format("MaSP like '{0}'", txtLocDuLieu.Text);
                }
                else
                {
                    dv.RowFilter = string.Format("TenSP like '{0}'", txtLocDuLieu.Text);
                }
            }else
            {
                dv.RowFilter = "";
            }
            dgvDanhSachSanPham.DataSource = dv;
        }

        private void dgvDanhSachSanPham_Click(object sender, EventArgs e)
        {
            maSP = dgvDanhSachSanPham.CurrentRow.Cells["colMaSP"].Value.ToString();
            soLuongBan = 1;
            donGiaBan = Convert.ToDouble(dgvDanhSachSanPham.CurrentRow.Cells["colDonGia"].Value.ToString());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            pnlThanhToan.Visible = true;
            lblTongThanhTien.Text = txtTongThanhTien.Text;
            lblTienKhachDua.Text = txtTienKhachDua.Text;
            lblTienThoiLai.Text = txtTienThoiLai.Text;
         
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            //in xong hoa don thi thoat

            //ẩn
            pnlThanhToan.Visible = false;
        }
    }
}
