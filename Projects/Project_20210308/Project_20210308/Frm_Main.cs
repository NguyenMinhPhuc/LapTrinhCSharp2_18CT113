using Commons;
using DataLayer.ConnectionStringManager;
using DataLayer.DatabaseManager;
using Project_20210308.BussinessLayer;
using Project_20210308.DanhMuc;
using Project_20210308.HeThong;
using Project_20210308.TacVu;
using Project_20210308.ThongKe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_20210308
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        Database data;
        string err = string.Empty;
        int rows = 0;
        BLL_DangNhap bd;
       
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            data = new Database(Cls_Main.arrayPath,Cls_Main.fileType);
            if (data.KiemTraKetNoi(ref err))
            {
                Frm_Login frm_Login = new Frm_Login();
                frm_Login.ShowDialog(); 
            }
            else
            {
                Frm_KetNoi frmKetNoi = new Frm_KetNoi(data.fileType);
                frmKetNoi.ShowDialog();
                data = new Database(Cls_Main.arrayPath, Cls_Main.fileType);
                lblConnectionString.Text = data.connectionStringBuilder.ToString();
                
            }
            this.Text = data.connectionStringBuilder.ToString();
            bd = new BLL_DangNhap(Cls_Main.arrayPath, Cls_Main.fileType);
            lblTenNhanVien.Text = Cls_Main.tenNhanVien;
            lblConnectionString.Text = data.connectionStringBuilder.ToString();
            Cls_Main.LayThongTinQuyenTheoUser(ref err, ref rows, Cls_Main.maNhanVien);
            bd.KiemTraPhieuNhap(ref err, ref rows);
        }

    //    private void LayThongTinQuyenTheoUser(string maNhanVien)
    //    {
    //        try
    //        {
    //DataTable dt = new DataTable();
    //        dt = bd.LayBangPhanQuyen(ref err, ref rows, maNhanVien);
    //        if(dt.Rows.Count>0)
    //        {
    //            foreach (DataRow item in dt.Rows)
    //            {
    //                if (!Cls_Main.BangPhanQuyen.ContainsKey(item["KyHieu"].ToString()))
    //                {
    //                    Cls_Main.BangPhanQuyen.Add(item["KyHieu"].ToString(), Convert.ToInt32(item["GiaTriQuyen"].ToString()));
    //                }
    //            }
    //        }
    //        }
    //        catch (Exception ex)
    //        {

    //            err = ex.Message;
    //        }
        
    //    }
      
        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
          
        }

        private void mnuEmployee_Click(object sender, EventArgs e)
        {
            Frm_NhanVien_Main frmNhanVien = new Frm_NhanVien_Main();
            
            frmNhanVien.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuNhapSanPham_Click(object sender, EventArgs e)
        {
            Frm_NhapSanPham_Main frmNhapSanPham = new Frm_NhapSanPham_Main();
            frmNhapSanPham.ShowDialog();
        }

        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            Frm_BanHang_Main frmBanHang = new Frm_BanHang_Main();
            frmBanHang.ShowDialog();
        }

        private void mnuThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            Frm_ThongKeDoanhThu frmThongKeDoanhThu = new Frm_ThongKeDoanhThu();
            frmThongKeDoanhThu.ShowDialog();
        }

        private void mnuPhanQuyen_Click(object sender, EventArgs e)
        {
            if (Cls_Main.KiemTraQuyen(Convert.ToInt32(Cls_Main.BangPhanQuyen["Frm_PhanQuyen"]),(int)PermissionType.Display))
            {
                Frm_PhanQuyen frmPhanQuyen = new Frm_PhanQuyen();
                frmPhanQuyen.ShowDialog();
            }
            else
            {
                MessageBox.Show(string.Format("Tài khoản {0} không có quyền trong chức năng này!!!\n Xin vui lòng chọn chức năng khác", Cls_Main.tenNhanVien), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
            }
        }

        private void mnuQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            Frm_TaiKhoan_Main frmTaiKhoan = new Frm_TaiKhoan_Main();
            frmTaiKhoan.ShowDialog();
        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            Frm_NhaCungCap_Main frmNhaCungCap = new Frm_NhaCungCap_Main();
            frmNhaCungCap.ShowDialog();
        }

        private void mnuLoaiSanPham_Click(object sender, EventArgs e)
        {
            Frm_LoaiSanPham_Main frmLoaiSanPham = new Frm_LoaiSanPham_Main();
            frmLoaiSanPham.ShowDialog();
        }

        private void mnuKiemTon_Click(object sender, EventArgs e)
        {
            Frm_KiemHangTon_Main frmKiemTon = new Frm_KiemHangTon_Main();
            frmKiemTon.ShowDialog();
        }

        private void mnuThongTin_Click(object sender, EventArgs e)
        {
            Frm_ThongTin frmThongTin = new Frm_ThongTin();
            frmThongTin.ShowDialog();
        }

        private void mnuHuongDanSuDung_Click(object sender, EventArgs e)
        {
            Frm_HuongDanSuDung frmHuongDan = new Frm_HuongDanSuDung();
            frmHuongDan.ShowDialog();
        }

        private void mnuSaoLuuPhucHoi_Click(object sender, EventArgs e)
        {
            Frm_SaoLuu_PhucHoi frmSaoLuu = new Frm_SaoLuu_PhucHoi();
            frmSaoLuu.ShowDialog();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            Frm_DoiMatKhau frmDoiMatKhau = new Frm_DoiMatKhau();
            frmDoiMatKhau.ShowDialog();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            Frm_Login frmLogin = new Frm_Login();
            frmLogin.ShowDialog();

            this.Text = data.connectionStringBuilder.ToString();
            bd = new BLL_DangNhap(Cls_Main.arrayPath, Cls_Main.fileType);
            lblTenNhanVien.Text = Cls_Main.tenNhanVien;
            lblConnectionString.Text = data.connectionStringBuilder.ToString();
            Cls_Main.LayThongTinQuyenTheoUser(ref err, ref rows, Cls_Main.maNhanVien);
            bd.KiemTraPhieuNhap(ref err, ref rows);

        }

     
    }
}
