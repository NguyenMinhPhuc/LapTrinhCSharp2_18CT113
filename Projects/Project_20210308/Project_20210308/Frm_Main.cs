using DataLayer.ConnectionStringManager;
using DataLayer.DatabaseManager;
using Project_20210308.DanhMuc;
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
       
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            data = new Database(Cls_Main.arrayPath,Cls_Main.fileType);
            if (data.KiemTraKetNoi(ref err))
            {
                Frm_Login frm_Login = new Frm_Login();
                frm_Login.ShowDialog();
                lblTenNhanVien.Text = Cls_Main.tenNhanVien;
                lblConnectionString.Text = data.connectionStringBuilder.ToString();
            }
            else
            {
                Frm_KetNoi frmKetNoi = new Frm_KetNoi(data.fileType);
                frmKetNoi.ShowDialog();
                data = new Database(Cls_Main.arrayPath, Cls_Main.fileType);
                lblConnectionString.Text = data.connectionStringBuilder.ToString();
            }
            this.Text = data.connectionStringBuilder.ToString();
        }
      
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

     
    }
}
