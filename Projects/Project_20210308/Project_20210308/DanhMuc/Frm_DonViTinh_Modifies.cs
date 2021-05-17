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
    public partial class Frm_DonViTinh_Modifies : Form
    {
        public Frm_DonViTinh_Modifies()
        {
            InitializeComponent();
        }
        BLL_DonViTinh bd;
        public DonViTinh donViTinh=new DonViTinh();
        public bool isAdd = false;

        string err = string.Empty;
        int rows = 0;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_DonViTinh_Modifies_Load(object sender, EventArgs e)
        {
            if(isAdd)
            {
                //Them
                txtMaDVT.Text = "0";
                txtTenDVT.Focus();
            }
            else
            {
                //Sua
                LoadDonViTinhRoForm(donViTinh);
            }
        }

        private void LoadDonViTinhRoForm(DonViTinh donViTinh)
        {
           if(donViTinh!=null)
           {
               txtMaDVT.Text = donViTinh.MaDVT.ToString();
               txtTenDVT.Text = donViTinh.TenDVT;
               txtTenDVT.Focus();
           }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtTenDVT.Text))
            {
                SetValueToDonViTinh();
                if (bd.InsertUpdateDonViTinh(ref err, ref rows, donViTinh))
                {
                    MessageBox.Show("Thanh cong");
                    this.Close();
                }else
                {
                    lblErr.Text = err;
                    lblErr.ForeColor = Color.Red;
                }
            }
        }

        private void SetValueToDonViTinh()
        {
            donViTinh = new DonViTinh() { 
                MaDVT=Convert.ToInt32(txtMaDVT.Text),
                TenDVT=txtTenDVT.Text
            };
        }
    }
}
