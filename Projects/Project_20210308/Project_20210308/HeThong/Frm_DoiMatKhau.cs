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

namespace Project_20210308.HeThong
{
    public partial class Frm_DoiMatKhau : Form
    {
        public Frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        BLL_TaiKhoan bd;
        string err = string.Empty;
        int rows = 0;
        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            bd = new BLL_TaiKhoan(Cls_Main.arrayPath, Cls_Main.fileType);
            if(Cls_Main.maTaiKhoan.Equals("TK0000001"))
            {
                gbCapLai.Enabled = true;
                LoadDuLieuComTaiKhoan();
            }
        }

        private void LoadDuLieuComTaiKhoan()
        {
           
            DataTable dt = new DataTable();
            dt = bd.LayTaiKhoanChoCbo(ref err, ref rows);
            if (dt.Rows.Count > 0)
            {
                cboTaiKhoan.DataSource = dt;
                cboTaiKhoan.ValueMember = "MaNhanVien";
                cboTaiKhoan.DisplayMember = "TenNhanVien";
                cboTaiKhoan.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapLaiMatKhau_Click(object sender, EventArgs e)
        {
            if (cboTaiKhoan.SelectedIndex > -1)
            {
                if (bd.CapLaiMatKhau(ref err, ref rows, cboTaiKhoan.SelectedValue.ToString()))
                {
                    this.Close();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            gbCapLai.Enabled = false;
            txtMatKhau1.ResetText();
            txtMatKhau2.ResetText();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtMatKhau1.Text)&&!string.IsNullOrEmpty(txtMatKhau2.Text))
            {
                if(bd.DoiMatKhau(ref err, ref rows,Cls_Main.maNhanVien,txtMatKhau2.Text))
                {
                    this.Close();
                }
            }
        }

        private void txtMatKhau2_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtMatKhau2.Text))
            {
                if(!txtMatKhau2.Text.Equals(txtMatKhau1.Text))
                {
                    MessageBox.Show("Mật khẩu nhập chưa khớp\n Xin vui lòng nhập lại");
                    txtMatKhau2.ResetText();
                    txtMatKhau2.Focus();
                }
            }
        }
    }
}
