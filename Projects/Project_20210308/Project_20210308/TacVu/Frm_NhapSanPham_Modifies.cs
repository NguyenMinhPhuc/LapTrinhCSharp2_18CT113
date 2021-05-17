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
            dtDonViTinh = bd.LayCboDonViTinh(ref err, ref rows);
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
           
            //Cập nhật thuộc tính StatusPhieuNhap=1
            if (bd.CapNhatTrangThaiPhieuNhap(ref err, ref rows, maPhieuNhap))
            { 
                statusPhieuNhap = true;
               
            //Thực hiện In Phiếu nhập 
                Frm_InPhieuNhap frmInPhieuNhap = new Frm_InPhieuNhap(maPhieuNhap);
                frmInPhieuNhap.ShowDialog();
                maPhieuNhap = string.Empty; 
                this.Close();
            }
                

        }
        private void Frm_NhapSanPham_Modifies_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!statusPhieuNhap)
            {
                if (MessageBox.Show(string.Format("Việc tắt của sổ nhập hàng khi trạng thái nhập chưa hoàn thành sẽ gây thiếu tính nhất quán trong dữ liệu\n Do đó, Phiếu nhập {0} sẽ bị xóa khỏi dữ liệu.\n Nếu không muốn xóa phiếu nhập và quay lại hoàn thành phiếu nhập này hãy chọn Cacel, Ngược lại chọn OK", maPhieuNhap), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    //Xóa
                    if (bd.DeletePhieuNhap(ref err, ref rows, maPhieuNhap))
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else { e.Cancel = true; }


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
            object obj = bd.LayMaSanPhamMax(ref err);
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
            if (!string.IsNullOrEmpty(txtMaSanPham.Text))
            {
                if(!string.IsNullOrEmpty(txtTenSanPham.Text))
                {
                    if(!string.IsNullOrEmpty(txtSoLuong.Text)&&Convert.ToInt32(txtSoLuong.Text)>0)
                    {
                        if (!string.IsNullOrEmpty(txtDonGia.Text) && Convert.ToInt32(txtDonGia.Text) > 0)
                        {
                            if(cboDonViTinh.SelectedIndex>=0)
                            {
                                //Lấy value của control
                                SetDataPhieuNhap();
                                //Insert data vào sql
                               if( bd.InsertChiTietPhieuNhap(ref err,ref rows,sanPham,chiTietPhieuNhap))
                               {
                                   if(MessageBox.Show(string.Format("Có tiếp tục nhập cho phiếu nhập {0}\n Ok để tiếp tục Cancel để kết thúc",maPhieuNhap),"Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
                                   {
                                       ResetControl();//tiếp tục nhập sp mới
                                   }
                                   else { 
                                       this.Close();//không nhập tiếp 
                                   }
                               }
                            }
                            else { MessageBox.Show("Chưa chọn DVT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        }
                        else { MessageBox.Show("Chưa nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    }
                    else { MessageBox.Show("Chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                else { MessageBox.Show("Chưa có tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Chưa có mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }
        SanPham sanPham=null;
        ChiTietPhieuNhap chiTietPhieuNhap=null;
        private void SetDataPhieuNhap()
        {
            sanPham = new SanPham() {
                MaSP=txtMaSanPham.Text,
                TenSP=txtTenSanPham.Text,
                MaDVT=Convert.ToInt32(cboDonViTinh.SelectedValue.ToString()),
                SoTon=0
            };
            chiTietPhieuNhap = new ChiTietPhieuNhap() { 
                MaPhieuNhap=maPhieuNhap,
                MaSP = txtMaSanPham.Text,
                SoLuongNhap=Convert.ToInt32(txtSoLuong.Text),
                DonGiaNhap=Convert.ToDouble(txtDonGia.Text),
                SoLuongNhapTon = Convert.ToInt32(txtSoLuong.Text)
            };
        }

        

        private void ResetControl()
        {
            txtMaSanPham.ResetText();
            txtTenSanPham.ResetText();
            txtSoLuong.Text = "0";
            txtDonGia.Text = "0";
            LoadCboDonViTinh();
            txtTenSanPham.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetControl_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

    }
}
