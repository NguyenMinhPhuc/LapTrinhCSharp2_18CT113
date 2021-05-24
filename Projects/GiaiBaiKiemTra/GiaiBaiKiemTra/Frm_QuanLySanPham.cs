using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiBaiKiemTra
{
    public partial class Frm_QuanLySanPham : Form
    {
        public Frm_QuanLySanPham()
        {
            InitializeComponent();
        }
        BLL_QuanLySanPham bd;
        string err = string.Empty;
        int rows = 0;

        DataTable dtDanhSachSanPham;
        private void Frm_QuanLySanPham_Load(object sender, EventArgs e)
        {
            bd = new BLL_QuanLySanPham();
            HienThiDanhSachSanPham();
        }

        private void HienThiDanhSachSanPham()
        {
            dtDanhSachSanPham = new DataTable();
            dtDanhSachSanPham = bd.LayDanhSachSanPham(ref err, ref rows);
            dgvDanhSachSanPham.DataSource = dtDanhSachSanPham.DefaultView;
            lblSoLuongSanPham.Text = dtDanhSachSanPham.Rows.Count.ToString() ;
        }

        private void dgvDanhSachSanPham_Click(object sender, EventArgs e)
        {
            SetValueToControl();
        }

        private void SetValueToControl()
        {
            if(dgvDanhSachSanPham.Rows.Count>0)
            {
                lblMaSanPham.Text = dgvDanhSachSanPham.CurrentRow.Cells["colMaSP"].Value.ToString();
                txtTenSanPham.Text = dgvDanhSachSanPham.CurrentRow.Cells["colTenSP"].Value.ToString();
                txtDonViTinh.Text = dgvDanhSachSanPham.CurrentRow.Cells["colDonViTinh"].Value.ToString();
                txtDonGia.Text = dgvDanhSachSanPham.CurrentRow.Cells["colDonGia"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = dgvDanhSachSanPham.Rows.Count-1; i >= 0; i--)
            {
                if(Convert.ToBoolean(dgvDanhSachSanPham.Rows[i].Cells["colDelete"].Value.ToString()))
                {
                    bd.XoaSanPham(ref err, ref rows, dgvDanhSachSanPham.Rows[i].Cells["colMaSP"].Value.ToString());
                }
            }
            HienThiDanhSachSanPham();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            XoaControl();
        }

        private void XoaControl()
        {
            lblMaSanPham.Text = "0";
            txtDonGia.ResetText();
            txtDonViTinh.ResetText();
            txtTenSanPham.ResetText();
            txtTenSanPham.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtTenSanPham.Text))
            {
                if(!string.IsNullOrEmpty(txtDonViTinh.Text))
                {
                    if(!string.IsNullOrEmpty(txtDonGia.Text))
                    {
                        if (bd.ThemSanPham(ref err, ref rows, txtTenSanPham.Text, txtDonViTinh.Text, Convert.ToDouble(txtDonGia.Text)))
                        {
                            HienThiDanhSachSanPham();
                            XoaControl();
                        }
                        else
                        {
                            MessageBox.Show("Them loi", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("chua co gia", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("chua co don vi tinh", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chua cos ten sp", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            Frm_XemBaoCao frmXemBaoCao = new Frm_XemBaoCao();
            frmXemBaoCao.ShowDialog();
        }
    }
}
