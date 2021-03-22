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

namespace Project_20210308.DanhMuc
{
    public partial class Frm_NhanVien_Main : Form
    {
        public Frm_NhanVien_Main()
        {
            InitializeComponent();
        }
        //khai báo
        BLL_NhanVien bd;
        DataTable dtNhanVien;
        string err = string.Empty;
        int rows = 0;
        private void Frm_NhanVien_Main_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhanVien(Cls_Main.arrayPath, Cls_Main.fileType);
            DisplayNhanVien();
        }

        private void DisplayNhanVien()
        {
            dtNhanVien = new DataTable();
            dtNhanVien = bd.GetDSNhanVien(ref err, ref rows);

            //Gán datatbase cho dataGridView
            dgvDanhSachNhanVien.DataSource = dtNhanVien.DefaultView;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayNhanVien();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frm_NhanVien_Modifies frmNhanVienModifies = new Frm_NhanVien_Modifies();
            frmNhanVienModifies.ShowDialog();
        }
    }
}
