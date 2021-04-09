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
        }

        private void HienThiDanhSach()
        {
            dtChiTietNhap = new DataTable();
            dtChiTietNhap = bd.LayChiTietNhapSanPham(ref err, ref rows);
            dgvChiTietNhap.DataSource = dtChiTietNhap.DefaultView;
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
    }
}
