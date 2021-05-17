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

namespace Project_20210308.ThongKe
{
    public partial class Frm_ThongKeDoanhThu : Form
    {
        public Frm_ThongKeDoanhThu()
        {
            InitializeComponent();
        }
        BLL_ThongKe bd;
        DataTable dtThongKeDoanhThu;
        string err = string.Empty;
        int rows = 0;
        private void Frm_ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            bd = new BLL_ThongKe(Cls_Main.arrayPath, Cls_Main.fileType);
            
            HienThiDoanhThu(dtpTuNgay.Value, dtpDenNgay.Value);
            LoadDataForComboNhanVien();
        }

        private void LoadDataForComboNhanVien()
        {
            DataTable dt = new DataTable();
            dt = bd.GetNhanVienForCombo(ref err, ref rows);
            cboNhanVien.DataSource = dt;
            cboNhanVien.ValueMember = "MaNhanVien";
            cboNhanVien.DisplayMember = "TenNhanVien";
            cboNhanVien.SelectedIndex = -1;
            cboNhanVien.Text = "---Chọn nhân viên---";
        }

        private void HienThiDoanhThu(DateTime beginDate, DateTime endDate)
        {
            dtThongKeDoanhThu = new DataTable();
            dtThongKeDoanhThu = bd.GetDoanhThuWithDateTime(ref err, ref rows, beginDate, endDate);
            dgvThongKeDoanhThu.DataSource = dtThongKeDoanhThu.DefaultView;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            HienThiDoanhThu(dtpTuNgay.Value, dtpDenNgay.Value);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = dtThongKeDoanhThu.DefaultView;
            dv.RowFilter = "";
            if(cboNhanVien.SelectedIndex>-1)
            {
                if(cboNhanVien.DataSource!=null)
                {
                    dv.RowFilter = string.Format("MaNhanVien = {0}", cboNhanVien.SelectedValue.ToString());
                }
            }
            dgvThongKeDoanhThu.DataSource = dv;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.AddExtension = true;
            save.DefaultExt = "xls";
            save.Filter = "";
            if(save.ShowDialog()==DialogResult.OK)
            {
                Commons.ExportExcel.ExportExcelByInterop(save.FileName, dgvThongKeDoanhThu, 1, "Arial", 14, 12);
                MessageBox.Show("Xuất file Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    
    }
}
