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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Database data;
        string err = string.Empty;
        private void Form1_Load(object sender, EventArgs e)
        {
            data = new Database(Application.StartupPath + @"\Connect.ini");
            if (data.KiemTraKetNoi(ref err))
                MessageBox.Show("ket noi thanh cong");
            else
                MessageBox.Show(string.Format("Ket noi khong thanh cong \n {0}", err));
        }
    }
}
