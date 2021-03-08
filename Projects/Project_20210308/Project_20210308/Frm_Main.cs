using DataLayer.ConnectionStringManager;
using DataLayer.DatabaseManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        string[] arrayPath = new string[] {
            Application.StartupPath+@"\Connect.ini",
            Application.StartupPath + @"\App.config",
            ""};
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            data = new Database(arrayPath, FileConnectType.INI);
            if (data.KiemTraKetNoi(ref err))
            {
                MessageBox.Show("Thanh công");
                lblConnectionString.Text = data.connectionStringBuilder.ToString();
            }
            else
            {
                Frm_KetNoi frmKetNoi = new Frm_KetNoi(data.fileType);
                frmKetNoi.ShowDialog();
                data = new Database(arrayPath, FileConnectType.INI);
                lblConnectionString.Text = data.connectionStringBuilder.ToString();
            }
            this.Text = data.connectionStringBuilder.ToString();
        }
    }
}
