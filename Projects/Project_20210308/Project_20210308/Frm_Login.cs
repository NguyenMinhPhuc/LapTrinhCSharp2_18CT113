using DataLayer.ConnectionStringManager;
using Project_20210308.BussinessLayer;
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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        BLL_DangNhap bd;
       
        string err = string.Empty;
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            //Khoi tạo BLL_DangNhap
            bd = new BLL_DangNhap(Cls_Main.arrayPath, Cls_Main.fileType);
            txtTenDangNhap.Text = "admin";
            txtMatKhau.Text = "123456";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(KiemTraDangNhap(txtTenDangNhap.Text,txtMatKhau.Text))
            {
                this.Close();
            }else
            {
                MessageBox.Show(string.Format("Đăng nhập không thành công\n Xin đăng nhập lại\n{0}",err), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            SqlDataReader dataReader = bd.KiemTraDangNhap(ref err,tenDangNhap, matKhau);
            bool result = false;
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    if (dataReader["result"].ToString().Equals("1"))
                    {
                        //Lấy thêm thông tin đăng nhập nếu muốn.
                        Cls_Main.tenNhanVien = dataReader["TenNhanVien"].ToString();
                        Cls_Main.maTaiKhoan = dataReader["MaTaiKhoan"].ToString();
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            return result;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
