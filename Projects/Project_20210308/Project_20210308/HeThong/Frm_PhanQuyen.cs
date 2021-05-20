using Project_20210308.BussinessLayer;
using Project_20210308.DanhMuc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_20210308.HeThong
{
    public partial class Frm_PhanQuyen : Form
    {
        public Frm_PhanQuyen()
        {
            InitializeComponent();
            TongQuyenTrenForm = Convert.ToInt32(Cls_Main.BangPhanQuyen[this.Name.ToString()].ToString());
        }
        BLL_PhanQuyen bd;
        string err = string.Empty;
        int rows = 0;
        DataTable dtChiTietPhanQuyen;
        bool statusLoadcbo = false;
        int TongQuyenTrenForm = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Frm_TaiKhoan_Main frmTaiKhoan = new Frm_TaiKhoan_Main();
            frmTaiKhoan.ShowDialog();
            LoadCboTaiKhoan();
        }

        private void LoadCboTaiKhoan()
        {
            DataTable dt = new DataTable();
            dt = bd.LayTaiKhoanChoCbo(ref err, ref rows);
            if (dt.Rows.Count > 0)
            {
                cboTaiKhoan.DataSource = dt;
                cboTaiKhoan.ValueMember = "MaTaiKhoan";
                cboTaiKhoan.DisplayMember = "TenTaiKhoan";
                cboTaiKhoan.SelectedIndex = 0;
                statusLoadcbo = true;
            }
            else
            {
                DialogResult result = MessageBox.Show("Chưa có tài khoản\nXin vui lòng tạo loại tài khoản", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    Frm_TaiKhoan_Main frmTaiKhoan = new Frm_TaiKhoan_Main();
                    frmTaiKhoan.ShowDialog();
                    LoadCboTaiKhoan();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void Frm_PhanQuyen_Load(object sender, EventArgs e)
        {
            bd = new BLL_PhanQuyen(Cls_Main.arrayPath, Cls_Main.fileType);
            LoadCboTaiKhoan();
            HienThiChiTietPhanQuyen(cboTaiKhoan.SelectedValue.ToString());
        }

        private void HienThiChiTietPhanQuyen(string maTaiKhoan)
        {
            dtChiTietPhanQuyen = new DataTable();
            dtChiTietPhanQuyen = bd.LayDanhSachPhanQuyen(ref err, ref rows, maTaiKhoan);

            CheckQuyeen(dtChiTietPhanQuyen);
            dgvPhanQuyen.DataSource = dtChiTietPhanQuyen.DefaultView;
            CheckLaiCheckBox(false);
        }
        void CheckQuyeen(DataTable dtChiTietPhanQuyen)
        {
            for (int i = 0; i < dtChiTietPhanQuyen.Rows.Count; i++)
            {
                int tongQuyen = Convert.ToInt16(dtChiTietPhanQuyen.Rows[i]["GiaTriQuyen"].ToString());
                if (tongQuyen > 0)
                {
                    if ((tongQuyen & 1) == 1)
                    {
                        dtChiTietPhanQuyen.Rows[i]["Xem"] = true;
                    }
                    if ((tongQuyen & 2) == 2)
                    {
                        dtChiTietPhanQuyen.Rows[i]["Them"] = true;
                    }
                    if ((tongQuyen & 4) == 4)
                    {
                        dtChiTietPhanQuyen.Rows[i]["Sua"] = true;
                    }
                    if ((tongQuyen & 8) == 8)
                    {
                        dtChiTietPhanQuyen.Rows[i]["Xoa"] = true;
                    }
                }
            }

        }
        private void CheckLaiCheckBox(bool _checked)
        {
            ckbXem.Checked = _checked;
            ckbThem.Checked = _checked;
            ckbSua.Checked = _checked;
            ckbXoa.Checked = _checked;
        }
        private void cboTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTaiKhoan.SelectedIndex > -1 && statusLoadcbo == true)
            {
                maTaiKhoan = cboTaiKhoan.SelectedValue.ToString();
                HienThiChiTietPhanQuyen(maTaiKhoan);
               
            }
        }
        string maChucNang, maTaiKhoan;
        private void dgvPhanQuyen_Click(object sender, EventArgs e)
        {
            if (dgvPhanQuyen.Rows.Count > 0)
            {
                ckbXem.Checked = Convert.ToBoolean(dgvPhanQuyen.CurrentRow.Cells["colXem"].Value.ToString());

                ckbThem.Checked = Convert.ToBoolean(dgvPhanQuyen.CurrentRow.Cells["colThem"].Value.ToString());

                ckbSua.Checked = Convert.ToBoolean(dgvPhanQuyen.CurrentRow.Cells["colSua"].Value.ToString());

                ckbXoa.Checked = Convert.ToBoolean(dgvPhanQuyen.CurrentRow.Cells["colXoa"].Value.ToString());

                maChucNang = dgvPhanQuyen.CurrentRow.Cells["colMaChucNang"].Value.ToString();
                maTaiKhoan = dgvPhanQuyen.CurrentRow.Cells["colMaTaiKhoan"].Value.ToString();

            }
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            if (Cls_Main.KiemTraQuyen(TongQuyenTrenForm, 2) || Cls_Main.KiemTraQuyen(TongQuyenTrenForm, 4))
            {
                CapNhatQuyenChoUser();
            }
            else
            {
                MessageBox.Show(string.Format("Tài khoản {0} không có quyền trong chức năng này!!!\n Xin vui lòng chọn chức năng khác", Cls_Main.tenNhanVien), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CapNhatQuyenChoUser()
        {
            if (statusThayDoiQuyen)
            {
                if (!string.IsNullOrEmpty(maChucNang) && !string.IsNullOrEmpty(maTaiKhoan))
                {
                    if (bd.CapNhatQuyenChoUser(ref err, ref rows, maTaiKhoan, maChucNang, tongQuyenThayDoi))
                    {
                        HienThiChiTietPhanQuyen(cboTaiKhoan.SelectedValue.ToString());
                        statusThayDoiQuyen = false;
                        tongQuyenThayDoi = 0;
                        maChucNang = string.Empty;
                        maTaiKhoan = string.Empty;
                        Cls_Main.LayThongTinQuyenTheoUser(ref err, ref rows, Cls_Main.maNhanVien);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn chức năng");
                }
            }
        }

        int tongQuyenThayDoi = 0;
        bool statusThayDoiQuyen = false;
        private void TinhTongQuyenThayDoi(CheckBox ckb, int value)
        {
            statusThayDoiQuyen = true;
            if (ckb.Checked == true)
                tongQuyenThayDoi += value;
            else
                tongQuyenThayDoi -= value;
            lblTongQuyenThayDoi.Text = tongQuyenThayDoi.ToString();
        }
        private void ckbXem_CheckedChanged(object sender, EventArgs e)
        {
            TinhTongQuyenThayDoi(ckbXem, 1);
        }

        private void ckbThem_CheckedChanged(object sender, EventArgs e)
        {
            TinhTongQuyenThayDoi(ckbThem, (int)Commons.PermissionType.Add);
        }

        private void ckbSua_CheckedChanged(object sender, EventArgs e)
        {
            TinhTongQuyenThayDoi(ckbSua, 4);
        }

        private void ckbXoa_CheckedChanged(object sender, EventArgs e)
        {
            TinhTongQuyenThayDoi(ckbXoa, 8);
        }

        private void btnCopyQuyen_Click(object sender, EventArgs e)
        {
            pnlSaoChepQuyen.Visible = true;
            LoadCboTaiKhoanDich();
        }

        private void LoadCboTaiKhoanDich()
        {
            DataTable dt = new DataTable();
            dt = bd.LayTaiKhoanChoCbo(ref err, ref rows);
            if (dt.Rows.Count > 0)
            {
                cboTaiKhoanDich.DataSource = dt;
                cboTaiKhoanDich.ValueMember = "MaTaiKhoan";
                cboTaiKhoanDich.DisplayMember = "TenTaiKhoan";
                cboTaiKhoanDich.SelectedIndex = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlSaoChepQuyen.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bd.CopyQuyenChoUser(ref err,ref rows,maTaiKhoan,cboTaiKhoanDich.SelectedValue.ToString()))//Thực hiện sao chép thành công
            {
                pnlSaoChepQuyen.Visible = false;
                HienThiChiTietPhanQuyen(cboTaiKhoan.SelectedValue.ToString());
            }
        }
    }
}
