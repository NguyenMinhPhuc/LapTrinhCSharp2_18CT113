using DataLayer.ConnectionStringManage;
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

namespace ProjectTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Database data;
        string err = string.Empty;
        string[] arrayPath = new string[] {
            Application.StartupPath+@"\Connect.ini",
            Application.StartupPath + @"\App.config",
            ""};
        private void Form1_Load(object sender, EventArgs e)
        {
            data = new Database(arrayPath, FileConnectType.BINARY);
            if(data.KiemTraKetNoi(ref err))
            {
                MessageBox.Show("Thanh công");
            }
            else
            {
                MessageBox.Show("Ko Thanh công");
            }
            this.Text = data.connectionStringBuilder.ToString();
        }
        //Ghi lại chuỗi kết nối
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder cn = new SqlConnectionStringBuilder();
            cn.DataSource = @"MINHPHUC\SQLEXPRESS";
            cn.InitialCatalog = "QuanLyVay";
            cn.IntegratedSecurity = true;
            cn.UserID = "lop18ct113";
            cn.Password = "123456789";
            data.WriteConnectTionString(arrayPath, cn);
        }
    }
}
