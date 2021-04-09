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
            frmNhanVienModifies.isAdd = true;
            frmNhanVienModifies.ShowDialog();
            DisplayNhanVien();
        }
        NhanVien nhanVien;
        private void dgvDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachNhanVien.RowCount>0)
            {
                nhanVien = new NhanVien()
                {
                    MaNhanVien=dgvDanhSachNhanVien.CurrentRow.Cells["colMaNhanVien"].Value.ToString(),
                    TenNhanVien = dgvDanhSachNhanVien.CurrentRow.Cells["colTenNhanVien"].Value.ToString(),
                    GioiTinh = Convert.ToBoolean(dgvDanhSachNhanVien.CurrentRow.Cells["colGioiTinh"].Value.ToString()),
                    NgaySinh =Convert.ToDateTime(dgvDanhSachNhanVien.CurrentRow.Cells["colNgaySinh"].Value.ToString()),
                    DienThoai = dgvDanhSachNhanVien.CurrentRow.Cells["colDienThoai"].Value.ToString(),
                    TenDangNhap = dgvDanhSachNhanVien.CurrentRow.Cells["colTenDangNhap"].Value.ToString(),
                    MaTaiKhoan = dgvDanhSachNhanVien.CurrentRow.Cells["colMaTaiKhoan"].Value.ToString()
                };
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (nhanVien != null)
            {
                Frm_NhanVien_Modifies frmNhanVien = new Frm_NhanVien_Modifies();
                frmNhanVien.nhanVien = nhanVien;
                frmNhanVien.isAdd = false;
                frmNhanVien.ShowDialog();
                DisplayNhanVien();
                nhanVien = null;
            }
            else
            {
                MessageBox.Show("chua cos nhan vien");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(nhanVien!=null)
            {
                if(bd.DeleteNhanVien(ref err, ref rows,nhanVien))
                {
                    MessageBox.Show("Thanh cong");
                    DisplayNhanVien();
                }
                else
                {
                    MessageBox.Show(string.Format("Thanh cong\n Err: {0}",err));
                }
            }
            else
            {
                MessageBox.Show("Chua chon nhan vien muon xoa");
            }
        }
    }
} 
