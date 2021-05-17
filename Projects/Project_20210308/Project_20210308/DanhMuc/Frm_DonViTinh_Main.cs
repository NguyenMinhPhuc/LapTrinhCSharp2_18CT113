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
    public partial class Frm_DonViTinh_Main : Form
    {
        public Frm_DonViTinh_Main()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_DonViTinh_Modifies frmDonViTinh = new Frm_DonViTinh_Modifies();
            frmDonViTinh.isAdd = true;
            frmDonViTinh.ShowDialog();
            HienThiDanhSachDonViTinh();
        }
        string maDonViTinh = string.Empty;
        string err = string.Empty;
        int rows = 0;
        DataTable dtDonViTinh;
        DonViTinh donViTinh;
        BLL_DonViTinh bd;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(donViTinh!=null)
            {
                //Thuc hien xoa
                if(MessageBox.Show("","",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
                {
                    if(bd.DeleteDonViTinh(ref err,ref rows,donViTinh))
                    {
                        MessageBox.Show("Thanh cong");
                        donViTinh = null;
                    }
                    else
                    {
                        MessageBox.Show("khong Thanh cong \n"+err);
                    }
                }
                //Load lai
                HienThiDanhSachDonViTinh();
            }
        }

        private void HienThiDanhSachDonViTinh()
        {
            dtDonViTinh = new DataTable();
            dtDonViTinh = bd.GetListDonViTinh(ref err, ref rows);
            dgvDanhSachDonViTinh.DataSource = dtDonViTinh.DefaultView;
        }

        private void Frm_DonViTinh_Main_Load(object sender, EventArgs e)
        {
            bd = new BLL_DonViTinh(Cls_Main.arrayPath,Cls_Main.fileType);
            HienThiDanhSachDonViTinh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (donViTinh != null)
            {
                Frm_DonViTinh_Modifies frmDonViTinh = new Frm_DonViTinh_Modifies();
                frmDonViTinh.donViTinh = donViTinh;
                frmDonViTinh.isAdd = false;
                frmDonViTinh.ShowDialog();
                HienThiDanhSachDonViTinh();
            }
        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            HienThiDanhSachDonViTinh();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
