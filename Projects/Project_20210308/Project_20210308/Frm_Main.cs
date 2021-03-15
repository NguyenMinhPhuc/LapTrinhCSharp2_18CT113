using DataLayer.ConnectionStringManager;
using DataLayer.DatabaseManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
       
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            data = new Database(Cls_Main.arrayPath,Cls_Main.fileType);
            if (data.KiemTraKetNoi(ref err))
            {
                Frm_Login frm_Login = new Frm_Login();
                frm_Login.ShowDialog();
                lblTenNhanVien.Text = Cls_Main.tenNhanVien;
                lblConnectionString.Text = data.connectionStringBuilder.ToString();
            }
            else
            {
                Frm_KetNoi frmKetNoi = new Frm_KetNoi(data.fileType);
                frmKetNoi.ShowDialog();
                data = new Database(Cls_Main.arrayPath, Cls_Main.fileType);
                lblConnectionString.Text = data.connectionStringBuilder.ToString();
            }
            this.Text = data.connectionStringBuilder.ToString();
        }
        
        private void btnLayNhanVien_Click(object sender, EventArgs e)
        {
            SqlDataReader dataReader = data.MyExcuteReader(ref err,"Select * from NhanVien", CommandType.Text, null);
            string line=string.Empty;
            while(dataReader.Read())
            {
                line += string.Format("{0}--{1}\n", dataReader["MaNhanVien"].ToString(), dataReader["TenNhanVien"].ToString());
            }
            MessageBox.Show(line, "Danh sách Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
