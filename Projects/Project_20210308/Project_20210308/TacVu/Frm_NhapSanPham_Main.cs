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
using Commons;
using System.IO;

using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace Project_20210308.TacVu
{
    public partial class Frm_NhapSanPham_Main : Form
    {
        public Frm_NhapSanPham_Main()
        {
            InitializeComponent();
        }
        private BLL_NhapSanPham bd;
        private string err = string.Empty;
        private int rows = 0;
        //khai báo biến kiểu table dùng để chứa chi tiết nhập
        System.Data.DataTable dtChiTietNhap;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void Frm_NhapSanPham_Main_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhapSanPham(Cls_Main.arrayPath, Cls_Main.fileType); 
         
            HienThiDanhSach();   
            LayTenColumn(cboTenColumn, dtChiTietNhap);
            cboTenColumn.Text = "MaPhieuNhap";
          
        }

        private void HienThiDanhSach()
        {
            dtChiTietNhap = new System.Data.DataTable();
            dtChiTietNhap = bd.LayChiTietNhapSanPham(ref err, ref rows);
            btnSort.Text = "Tăng";
            DataView dvChiTietNhapHang = dtChiTietNhap.DefaultView;
            if (cboTenColumn.SelectedIndex > -1)
            {
                dvChiTietNhapHang.Sort = string.Format("{0} ASC", cboTenColumn.Text);
            }
            else
            {
                dvChiTietNhapHang.Sort = string.Format("MaPhieuNhap ASC");
            }

            dgvChiTietNhap.DataSource = dvChiTietNhapHang;
        }
        private void LayTenColumn(ComboBox cbo,System.Data.DataTable dt)
        {
            foreach (DataColumn item in dt.Columns)
            {
                if (item.DataType.Name.Equals("String"))
                {
                    cbo.Items.Add(item.ColumnName);
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtChiTietNhap.DefaultView;
            dv.RowFilter = "";
            if(txtSearch.Text.Length>0)
            {
                dv.RowFilter = string.Format("{0} like '%{1}%'",cboTenColumn.Text,txtSearch.Text);
            }else
            {
                dv.RowFilter = "";
            }
            dgvChiTietNhap.DataSource = dv;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_NhapSanPham_Modifies frmNhapSanPham = new Frm_NhapSanPham_Modifies();
            frmNhapSanPham.ShowDialog();
            HienThiDanhSach();
        }
        string maPhieuNhap = string.Empty;
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maPhieuNhap))
            {
                Frm_NhapSanPham_SuaPhieuNhap frmSuaPhieuNhap = new Frm_NhapSanPham_SuaPhieuNhap();
                frmSuaPhieuNhap.maPhieuNhap = maPhieuNhap;
                frmSuaPhieuNhap.ShowDialog();
                HienThiDanhSach();
                maPhieuNhap = string.Empty;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maPhieuNhap))
            {
                if (MessageBox.Show(string.Format("Có chắc chắn muốn xóa phiếu nhập {0} hay không\n Chọn Ok để đồng ý xóa, Ngược lại chọn Cancel ", maPhieuNhap), "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    //gọi hàm xóa
                    if (bd.DeletePhieuNhap(ref err, ref rows, maPhieuNhap))
                    {
                        HienThiDanhSach();
                    }
                }
                maPhieuNhap = string.Empty;
            }
            else
            {
                MessageBox.Show("Chưa chọn mã phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvChiTietNhap_Click(object sender, EventArgs e)
        {
            if(dgvChiTietNhap.Rows.Count>0)
            {
                maPhieuNhap = dgvChiTietNhap.CurrentRow.Cells["colMaPhieuNhap"].Value.ToString();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            DataView dv = dtChiTietNhap.DefaultView;
          
            if (btnSort.Text.Equals("Tăng"))
            {
                btnSort.Text = "Giảm";
                dv.Sort = string.Format("{0} DESC",cboTenColumn.Text);
            }
            else
            {
                btnSort.Text = "Tăng";
                dv.Sort = string.Format("{0} ASC", cboTenColumn.Text);
            }
            dgvChiTietNhap.DataSource = dv;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.AddExtension = true;
            saveDialog.DefaultExt = "xls";
            saveDialog.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
           
            if(saveDialog.ShowDialog()==DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveDialog.FileName, FileMode.CreateNew, FileAccess.Write, FileShare.Write))
                {
                    using(StreamWriter sw=new StreamWriter(fs,UTF8Encoding.Unicode))
                    {
                        string line = ExportExcel.MyExportExcel(dgvChiTietNhap, "Danh sách phiếu nhập", Cls_Main.tenNhanVien);
                        sw.Write(line);
                    }
                }
            }
            
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.AddExtension = true;
            saveDialog.DefaultExt = "xls";
            saveDialog.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveDialog.FileName;
            }

           ExportExcel.ExportExcelByInterop(filePath,dgvChiTietNhap,1,"Arial",16,12);
        }

        private void ExportExcelByInterop(string filePath)
        {
            Excel.Application xlApp = new Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("khong tao file Application Excel");
                return;
            }

            xlApp.Visible = false;
            object misValue = System.Reflection.Missing.Value;
            Workbook wb = xlApp.Workbooks.Add(misValue);
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            if (ws == null)
            {
                MessageBox.Show("khong tao worksheet");
                return;
            }

            //khoi bao mot so thuoc tinhs
            int row = 1;
            string fontName = "Arial";
            int fontsizeTieude = 14;
            int fonsizeNoiDung = 12;

            //Them Tieu de
            Range row1_TieuDe = ws.get_Range("A1", "J1");
            row1_TieuDe.Merge();
            row1_TieuDe.Font.Bold = true;
            row1_TieuDe.Font.Name = fontName;
            row1_TieuDe.Font.Size = fontsizeTieude;
            row1_TieuDe.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            row1_TieuDe.Value2 = "Danh Sach ...";

            //Phan tieu de cua noi dung
            Range row3;
            row = 3;
            string[] tencot = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int col = 0;
            for (int i = 0; i < dgvChiTietNhap.ColumnCount; i++)
            {
                if (dgvChiTietNhap.Columns[i].Visible == true)
                {
                    row3 = ws.get_Range(tencot[col] + "3", tencot[col] + "3");
                    row3.Font.Bold = true;
                    row3.Font.Name = fontName;
                    row3.Font.Size = fontsizeTieude;
                    row3.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    row3.Value2 = dgvChiTietNhap.Columns[i].HeaderText;
                    col++;
                }
            }
            row = 4;
            //noi dung
            for (int i = 0; i < dgvChiTietNhap.RowCount; i++)
            {
                DataRow dr = dtChiTietNhap.Rows[i];
                dynamic[] arr ={
                                   dr["STT"].ToString(),
                                   dr["TenSP"].ToString(),
                                   Convert.ToDateTime(dr["NgayNhap"].ToString()).ToShortDateString(),
                                  Convert.ToInt32( dr["SoLuongNhap"].ToString()),
                                  dr["TenDVT"].ToString(),
                                 Convert.ToDouble( dr["DonGianhap"].ToString()),
                                 Convert.ToDouble( dr["ThanhTien"].ToString()),
                                  dr["TenNhanVien"],
                                 Convert.ToInt32( dr["SoLuongNhapTon"].ToString()),
                                  dr["MaPhieuNhap"].ToString()
                              };
                Range rowData = ws.get_Range("A" + row.ToString(), "J" + row.ToString());
                rowData.Font.Size = fonsizeNoiDung;
                rowData.Font.Name = fontName;
                rowData.Value2 = arr;
                row++;
            }

            //Dong khung table
            BorderAround(ws.get_Range("A3", "J" + (row-1).ToString()));
            //Save
            wb.SaveAs(filePath);
            wb.Close();
            xlApp.Quit();
            releaseObject(ws);
            releaseObject(wb);
            releaseObject(xlApp);
        }


        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        //Hàm thu hồi bộ nhớ cho COM Excel
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }

    }
}
