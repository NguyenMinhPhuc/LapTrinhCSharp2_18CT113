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
    public partial class Frm_ThongTinSinhVien : Form
    {
        public Frm_ThongTinSinhVien()
        {
            InitializeComponent();
        }

        private void Frm_ThongTinSinhVien_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.Text = DateTime.Now.ToString();
            HienThiThongTin();
        }

        private void HienThiThongTin()
        {
            lblMaSinhVien.Text = "118000189";
            lblHoVaTen.Text = "Nguyen Minh Phuc";
            lblSoMay.Text = "06";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
