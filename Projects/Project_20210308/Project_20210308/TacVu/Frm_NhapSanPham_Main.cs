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
    public partial class Frm_NhapSanPham_Main : Form
    {
        public Frm_NhapSanPham_Main()
        {
            InitializeComponent();
        }
        private BLL_NhapSanPham bd;
        private string err = string.Empty;
        private int rows = 0;
        //khai báo biến kiểu table dùng để chứa chi tiết nhập
        DataTable dtChiTietNhap;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void Frm_NhapSanPham_Main_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhapSanPham(Cls_Main.arrayPath, Cls_Main.fileType); 
         
            HienThiDanhSach();   
            LayTenColumn(cboTenColumn, dtChiTietNhap);
            cboTenColumn.Text = "MaPhieuNhap";
          
        }

        private void HienThiDanhSach()
        {
            dtChiTietNhap = new DataTable();
            dtChiTietNhap = bd.LayChiTietNhapSanPham(ref err, ref rows);
            btnSort.Text = "Tăng";
            DataView dvChiTietNhapHang = dtChiTietNhap.DefaultView;
            if (cboTenColumn.SelectedIndex > -1)
            {
                dvChiTietNhapHang.Sort = string.Format("{0} ASC", cboTenColumn.Text);
            }
            else
            {
                dvChiTietNhapHang.Sort = string.Format("MaPhieuNhap ASC");
            }

            dgvChiTietNhap.DataSource = dvChiTietNhapHang;
        }
        private void LayTenColumn(ComboBox cbo,DataTable dt)
        {
            foreach (DataColumn item in dt.Columns)
            {
                if (item.DataType.Name.Equals("String"))
                {
                    cbo.Items.Add(item.ColumnName);
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtChiTietNhap.DefaultView;
            dv.RowFilter = "";
            if(txtSearch.Text.Length>0)
            {
                dv.RowFilter = string.Format("{0} like '%{1}%'",cboTenColumn.Text,txtSearch.Text);
            }else
            {
                dv.RowFilter = "";
            }
            dgvChiTietNhap.DataSource = dv;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_NhapSanPham_Modifies frmNhapSanPham = new Frm_NhapSanPham_Modifies();
            frmNhapSanPham.ShowDialog();
            HienThiDanhSach();
        }
        string maPhieuNhap = string.Empty;
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maPhieuNhap))
            {
                Frm_NhapSanPham_SuaPhieuNhap frmSuaPhieuNhap = new Frm_NhapSanPham_SuaPhieuNhap();
                frmSuaPhieuNhap.maPhieuNhap = maPhieuNhap;
                frmSuaPhieuNhap.ShowDialog();
                HienThiDanhSach();
                maPhieuNhap = string.Empty;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maPhieuNhap))
            {
                if (MessageBox.Show(string.Format("Có chắc chắn muốn xóa phiếu nhập {0} hay không\n Chọn Ok để đồng ý xóa, Ngược lại chọn Cancel ", maPhieuNhap), "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    //gọi hàm xóa
                    if (bd.DeletePhieuNhap(ref err, ref rows, maPhieuNhap))
                    {
                        HienThiDanhSach();

                    }
                }

                maPhieuNhap = string.Empty;

            }
            else
            {
                MessageBox.Show("Chưa chọn mã phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvChiTietNhap_Click(object sender, EventArgs e)
        {
            if(dgvChiTietNhap.Rows.Count>0)
            {
                maPhieuNhap = dgvChiTietNhap.CurrentRow.Cells["colMaPhieuNhap"].Value.ToString();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            DataView dv = dtChiTietNhap.DefaultView;
          
            if (btnSort.Text.Equals("Tăng"))
            {
                btnSort.Text = "Giảm";
                dv.Sort = string.Format("{0} DESC",cboTenColumn.Text);
            }
            else
            {
                btnSort.Text = "Tăng";
                dv.Sort = string.Format("{0} ASC", cboTenColumn.Text);
            }
            dgvChiTietNhap.DataSource = dv;
        }
    }
}
