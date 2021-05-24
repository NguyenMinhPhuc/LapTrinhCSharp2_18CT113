using Microsoft.Reporting.WinForms;
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
    public partial class Frm_XemBaoCao : Form
    {
        public Frm_XemBaoCao()
        {
            InitializeComponent();
        }
        BLL_QuanLySanPham bd;
        DataTable dtBaoCao;
        string err=string.Empty;
        int rows=0;
        void HienThiDanhsach(string loaiSanPham){
           
            dtBaoCao=new DataTable();
            dtBaoCao=bd.LayDanhSachSanPhamBaoCao(ref err, ref rows);
        }
        void HienThiReport(string loaiSanPham)
        {
           
            HienThiDanhsach(loaiSanPham);

            reportDanhSach.Clear();

            reportDanhSach.LocalReport.ReportEmbeddedResource = "GiaiBaiKiemTra.RpXemBaoCao.rdlc";
            reportDanhSach.LocalReport.DataSources.Clear();
            ReportDataSource newdatasource = new ReportDataSource("DS_SanPham", dtBaoCao);
            reportDanhSach.LocalReport.DataSources.Add(newdatasource);
            this.reportDanhSach.RefreshReport();
        }
        void LoadConbo()
        {
            //Sau khi load com bo xong
            trangThaiLoad = true;

        }
        private void Frm_XemBaoCao_Load(object sender, EventArgs e)
        {
            bd = new BLL_QuanLySanPham();
            LoadConbo();
            HienThiReport(cboLoaiSanPham.SelectedValue.ToString());
            
        }
        bool trangThaiLoad = false;
        private void cboLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLoaiSanPham.SelectedIndex>-1 && trangThaiLoad==true)
            {
                HienThiReport(cboLoaiSanPham.SelectedValue.ToString());
            }
        }
    }
}
