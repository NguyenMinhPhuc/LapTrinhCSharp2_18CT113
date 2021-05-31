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
    public partial class Frm_InHoaDon : Form
    {
        public Frm_InHoaDon(string maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
        }
        string maHD = string.Empty;
        BLL_BanHang db;
        DataTable dtInHoaDon;
        string err = string.Empty;
        int rows=0;
        private void Frm_InHoaDon_Load(object sender, EventArgs e)
        {
            db = new BLL_BanHang(Cls_Main.arrayPath, Cls_Main.fileType);
            LayDuLieu(maHD);
            HienThiReport();
            this.rp_InHoaDon_Viewer.RefreshReport();
        }

        private void HienThiReport()
        {
            rp_InHoaDon_Viewer.Reset();
            rp_InHoaDon_Viewer.LocalReport.ReportEmbeddedResource = "Project_20210308.TacVu.rp_InHoaDon.rdlc";

            rp_InHoaDon_Viewer.LocalReport.DataSources.Clear();
            ReportDataSource newDataSource = new ReportDataSource("ds_InHoaDon", dtInHoaDon);
            rp_InHoaDon_Viewer.LocalReport.DataSources.Add(newDataSource);
        }

        private void LayDuLieu(string maHD)
        {
            dtInHoaDon = new DataTable();
            dtInHoaDon = db.InHoaDon(ref err, ref rows,maHD);
        }
    }
}
