using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam01_Connecttion
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        Database data;
        string err = string.Empty;
        private void Form1_Load(object sender, EventArgs e)
        {
            data = new Database(Application.StartupPath + @"\Connect.ini");
            if (data.KiemTraKetNoi(ref err))
            {
                MessageBox.Show("ket noi thanh cong");
                lblConnectionString.Text = data.ConnectionString;
            }
            else
            {
                Frm_KetNoi frmKetNoi = new Frm_KetNoi();
                frmKetNoi.ShowDialog();
                data = new Database(Application.StartupPath + @"\Connect.ini");
                lblConnectionString.Text = data.ConnectionString;
            }
                
        }
    }
}
