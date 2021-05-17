using Microsoft.Reporting.WinForms;
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

namespace Project_20210308.TacVu
{
    public partial class Frm_InPhieuNhap : Form
    {
        public Frm_InPhieuNhap(string maPhieuNhap)
        {
            InitializeComponent();
            this.maPhieuNhap = maPhieuNhap;
        }
        //Khai báo
        BLL_NhapSanPham bd;
        DataTable dtInPhieuNhap;
        public string maPhieuNhap;
        string err = string.Empty;
        int rows = 0;
        private void Frm_InPhieuNhap_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhapSanPham(Cls_Main.arrayPath,Cls_Main.fileType);

            HienThiReport(maPhieuNhap);
        }

        private void HienThiReport(string maPhieuNhap)
        {
          //Lay data
            dtInPhieuNhap = new DataTable();
            dtInPhieuNhap = bd.PhieuNhap_InPhieuNhap(ref err, ref rows, maPhieuNhap);

            //reset report
            rp_InPhieuNhap.Reset();
            //gan duong dan file report
            //rp_InPhieuNhap.LocalReport.ReportPath = @"D:\Projects\HocTap\C_Sharp-Programming\LapTrinhCSharp2_18CT113\Projects\Project_20210308\Project_20210308\TacVu\Rp_InPhieuNhap.rdlc";
            rp_InPhieuNhap.LocalReport.ReportEmbeddedResource = "Project_20210308.TacVu.Rp_InPhieuNhap.rdlc";
            //gan datasources
            rp_InPhieuNhap.LocalReport.DataSources.Clear();

            ReportDataSource newDataSource = new ReportDataSource("ds_InPhieuNhap", dtInPhieuNhap);
            rp_InPhieuNhap.LocalReport.DataSources.Add(newDataSource);

            rp_InPhieuNhap.RefreshReport();
        }
    }
}
