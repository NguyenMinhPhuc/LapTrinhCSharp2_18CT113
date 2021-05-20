using DataLayer;
using DataLayer.ConnectionStringManager;
using DataLayer.DatabaseManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_20210308
{
    public partial class Frm_KetNoi : Form
    {
        public Frm_KetNoi(  FileConnectType fileType)
        {
            InitializeComponent();
            this.fileType = fileType;
        }
        ReadConnectionStringFactory readFile;
        Database data;
        FileConnectType fileType;

        string err = string.Empty;
        string[] arrayPath = new string[] {
            Application.StartupPath+@"\Connect.ini",
            Application.StartupPath + @"\App.config",
            "",
             Application.StartupPath + @"\Connect.Bat",
        };
        SqlConnectionStringBuilder ConnectionString = new SqlConnectionStringBuilder();
        private void Frm_KetNoi_Load(object sender, EventArgs e)
        {
            readFile = new ReadConnectionStringFactory();
            readFile.CreateReadConnectionString(fileType);
            if (File.Exists(arrayPath[(int)fileType]))
            {
                ConnectionString = readFile.ReadConnectionString.ReadConnectionString(arrayPath[(int)fileType]);
                txtServerName.Text = ConnectionString.DataSource;
                txtDatabaseName.Text = ConnectionString.InitialCatalog;
                txtUserId.Text = ConnectionString.UserID;
                txtPassword.Text = ConnectionString.Password;
                ckbWinNT.Checked = ConnectionString.IntegratedSecurity;
                txtPassword.UseSystemPasswordChar = !ckbShowPassword.Checked;
            }
            HienThiCachLuuFile(fileType);
               
        }

        private void HienThiCachLuuFile(FileConnectType fileType)
        {
            switch (fileType)
            {
                case FileConnectType.INI:
                    this.Text = string.Format("Connect to server -- [{0}]", "Lưu trên file INI");
                    break;
                case FileConnectType.APPCONFIG:
                    this.Text = string.Format("Connect to server -- [{0}]", "Lưu trên file Appconfig");
                    break;
                case FileConnectType.REGEDIT:
                    this.Text = string.Format("Connect to server -- [{0}]", "Lưu trên Regedit");
                    break;
                case FileConnectType.BINARY:
                    this.Text = string.Format("Connect to server -- [{0}]", "Lưu trên file Binary");
                    break;
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
            ConnectionString.DataSource = txtServerName.Text;
            ConnectionString.InitialCatalog = txtDatabaseName.Text;
            ConnectionString.UserID = txtUserId.Text;
            ConnectionString.Password = txtPassword.Text;
            ConnectionString.IntegratedSecurity = ckbWinNT.Checked;
            readFile.ReadConnectionString.WriteConnectionString(arrayPath[(int)fileType], ConnectionString);
            Cls_Main.connectionStringBuilder = ConnectionString;
            //Kiểm tra kết nối
            data = new Database(arrayPath, fileType);
            if (data.KiemTraKetNoi(ref err))
            {
                MessageBox.Show(string.Format("Kết nối thành công\nChuỗi kết nối hiện tại là {0}",data.connectionStringBuilder.ToString()),"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
