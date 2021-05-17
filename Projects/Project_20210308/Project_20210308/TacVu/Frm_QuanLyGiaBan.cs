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
    public partial class Frm_QuanLyGiaBan : Form
    {
        public Frm_QuanLyGiaBan()
        {
            InitializeComponent();
        }
        BLL_GiaBan bd;
        string err = string.Empty;
        int rows = 0;
        DataTable dtDanhSachGiaBan;
        string maSanPham = string.Empty;
        double donGiaHienHanh = 0;
        private void Frm_QuanLyGiaBan_Load(object sender, EventArgs e)
        {
            bd = new BLL_GiaBan(Cls_Main.arrayPath,Cls_Main.fileType);
            HienThiDanhSachGiaBanHienHanh();
        }

        private void HienThiDanhSachGiaBanHienHanh()
        {
            dtDanhSachGiaBan = new DataTable();
            dtDanhSachGiaBan = bd.LayDanhSachGiaBanHienHanh(ref err, ref rows);
            dgvDanhSachGiaBan.DataSource = dtDanhSachGiaBan.DefaultView;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                DataView dv = dtDanhSachGiaBan.DefaultView;
                dv.RowFilter = "";
                if(ckbLocSanPham.Checked)
                {
                    dv.RowFilter = string.Format("MaSP like '{0}'",txtSearch.Text);
                }
                else
                {
                    dv.RowFilter = string.Format("TenSP like '{0}'", txtSearch.Text);
                }
                dgvDanhSachGiaBan.DataSource = dv;
            }
        }

        private void dgvDanhSachGiaBan_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachGiaBan.Rows.Count>0)
            {
                maSanPham = dgvDanhSachGiaBan.CurrentRow.Cells["colMaSP"].Value.ToString();
            }
        }

        private void bntThayDoiGiaBan_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(maSanPham)&&!string.IsNullOrEmpty(txtGiaBanMoi.Text))
            {
                if(bd.DoiGiaBanHienHanh(ref err,ref rows,maSanPham,Convert.ToDouble(txtGiaBanMoi.Text)))
                {
                    MessageBox.Show("Doi gia thanh cong");
                }
            }
            else
            {
                MessageBox.Show("Chua chon san pham");
            }
        }
    }
}
