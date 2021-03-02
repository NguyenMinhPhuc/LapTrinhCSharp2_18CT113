using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam01_Connecttion
{
    public partial class Frm_KetNoi : Form
    {
        public Frm_KetNoi()
        {
            InitializeComponent();
        }
        ReadConnectionString readFile;
        Database data;
        string path = Application.StartupPath + @"\Connect.ini";
        string ConnectionString = string.Empty;
        string err = string.Empty;
        private void Frm_KetNoi_Load(object sender, EventArgs e)
        {
            readFile = new ReadConnectionString();
            if (File.Exists(path))
            {
                ConnectionString = readFile.DocChuoiKetNoiTuFile(path);
                txtServerName.Text = readFile.ServerName;
                txtDatabaseName.Text = readFile.DatabaseName;
                txtUserId.Text = readFile.Uid;
                txtPassword.Text = readFile.Pwd;
                ckbWinNT.Checked = readFile.WinNT;
                txtPassword.UseSystemPasswordChar = !ckbShowPassword.Checked;
            }
        }

        private void ckbWinNT_CheckedChanged(object sender, EventArgs e)
        {
            txtUserId.Enabled = !ckbWinNT.Checked;
            txtPassword.Enabled = !ckbWinNT.Checked;
        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =!ckbShowPassword.Checked;
          
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Lưu file kết nối
            readFile.ServerName = txtServerName.Text;
            readFile.DatabaseName = txtDatabaseName.Text;
            readFile.Uid = txtUserId.Text;
            readFile.Pwd = txtPassword.Text;
            readFile.WinNT = ckbWinNT.Checked;
            readFile.GhiChuoiKetNoiVaoFile(path);
            //Kiểm tra kết nối
            data = new Database(path);
            if(data.KiemTraKetNoi(ref err))
            {
                MessageBox.Show(string.Format("Kết nối thành công\nChuỗi kết nối hiện tại là {0}",data.ConnectionString),"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Format("Kết nối không thành công\nChi tiết lối {0}", err), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
