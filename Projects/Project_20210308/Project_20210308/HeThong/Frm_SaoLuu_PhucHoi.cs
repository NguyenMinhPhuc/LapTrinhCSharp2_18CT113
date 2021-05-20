using Project_20210308.BussinessLayer;
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

namespace Project_20210308.HeThong
{
    public partial class Frm_SaoLuu_PhucHoi : Form
    {
        public Frm_SaoLuu_PhucHoi()
        {
            InitializeComponent();
        }
        BLL_SaoLuuPhucHoi bd;
        string err = string.Empty;
        int rows = 0;
        private void btnChon_Click(object sender, EventArgs e)
        {
            if (ckbPhucHoi.Checked)
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Backup files (*.bak)|*.bak|All files (*.*)|*.*";
                open.RestoreDirectory = true;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = open.FileName;
                }
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Backup files (*.bak)|*.bak|All files (*.*)|*.*";
                save.RestoreDirectory = true;
                save.AddExtension = true;
                save.DefaultExt = "bak";
                save.FileName = string.Format("backup_{0:0000}{1:00}{2:00}{3:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Second);
                if(save.ShowDialog()==DialogResult.OK)
                {
                    txtPath.Text = save.FileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ckbPhucHoi.Checked)
            {
                //Phuc Hoi
                lblErr.Text = "Đang phục hồi dữ liệu...";
                lblErr.ForeColor = Color.Red;
                Application.DoEvents();
                string err = "";
                try
                {
                    string sql = string.Format("USE Master \n ALTER DATABASE {0} SET SINGLE_USER WITH ROLLBACK IMMEDIATE" + " RESTORE DATABASE {1} FROM DISK = N'{2}' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10" + " ALTER DATABASE {3} SET MULTI_USER", Cls_Main.connectionStringBuilder.InitialCatalog, Cls_Main.connectionStringBuilder.InitialCatalog, txtPath.Text, Cls_Main.connectionStringBuilder.InitialCatalog);
                    if (bd.PhucHoi(sql, ref err, ref rows))
                    {
                        lblErr.Text = "Đã phục hồi thành công";
                        lblErr.ForeColor = Color.White;
                    }
                    else
                    {
                        lblErr.Text = "Phục hồi không thành công" + err;
                        lblErr.ForeColor = Color.White;
                    }
                }
                catch (Exception ex)
                {
                    err = ex.Message;
                    lblErr.Text = "Sao lưu không thành công" + err;
                    lblErr.ForeColor = Color.Blue;
                  
                }
            }else
            {
                lblErr.Text = "Đang sao lưu dữ liệu...";
                lblErr.ForeColor = Color.Red;
                Application.DoEvents();
                if (File.Exists(txtPath.Text))
                {
                    File.Delete(txtPath.Text);
                }
               
                try
                {

                    if (bd.SaoLuu(ref err,ref rows, txtPath.Text))
                    {
                        lblErr.Text = "Đã sao lưu thành công";
                        lblErr.ForeColor = Color.White;
                    }
                    else
                    {
                        lblErr.Text = "Sao lưu không thành công" + err;
                        lblErr.ForeColor = Color.White;
                    }
                }
                catch (Exception ex)
                {
                    err = ex.Message;
                    lblErr.Text = "Sao lưu không thành công." + err;
                    lblErr.ForeColor = Color.Blue;
                   
                }
            }
        }

        private void Frm_SaoLuu_PhucHoi_Load(object sender, EventArgs e)
        {
            bd = new BLL_SaoLuuPhucHoi(Cls_Main.arrayPath, Cls_Main.fileType);
        }
    }
}
