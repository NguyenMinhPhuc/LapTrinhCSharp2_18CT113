namespace Project_20210308.TacVu
{
    partial class Frm_NhapSanPham_SuaPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvChiTietNhap = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongNhapTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTinPhieuNhap = new System.Windows.Forms.GroupBox();
            this.gbChiTietPhieuNhap = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).BeginInit();
            this.gbThongTinPhieuNhap.SuspendLayout();
            this.gbChiTietPhieuNhap.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvChiTietNhap
            // 
            this.dgvChiTietNhap.AllowUserToAddRows = false;
            this.dgvChiTietNhap.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvChiTietNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiTietNhap.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiTietNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaSP,
            this.colTenSP,
            this.colNgayNhap,
            this.colSoLuongNhap,
            this.colMaDVT,
            this.colTenDVT,
            this.colDonGiaNhap,
            this.colThanhTien,
            this.colMaNhanVien,
            this.colTenNhanVien,
            this.colSoLuongNhapTon});
            this.dgvChiTietNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietNhap.Location = new System.Drawing.Point(3, 22);
            this.dgvChiTietNhap.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgvChiTietNhap.Name = "dgvChiTietNhap";
            this.dgvChiTietNhap.ReadOnly = true;
            this.dgvChiTietNhap.RowHeadersVisible = false;
            this.dgvChiTietNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietNhap.Size = new System.Drawing.Size(1154, 531);
            this.dgvChiTietNhap.TabIndex = 3;
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 50;
            // 
            // colMaSP
            // 
            this.colMaSP.DataPropertyName = "MaSP";
            this.colMaSP.HeaderText = "MaSP";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.ReadOnly = true;
            this.colMaSP.Visible = false;
            // 
            // colTenSP
            // 
            this.colTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSP.DataPropertyName = "TenSP";
            this.colTenSP.HeaderText = "Tên sản phẩm";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.DataPropertyName = "NgayNhap";
            this.colNgayNhap.HeaderText = "Ngày nhập";
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.ReadOnly = true;
            this.colNgayNhap.Width = 150;
            // 
            // colSoLuongNhap
            // 
            this.colSoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.colSoLuongNhap.HeaderText = "Số lượng";
            this.colSoLuongNhap.Name = "colSoLuongNhap";
            this.colSoLuongNhap.ReadOnly = true;
            // 
            // colMaDVT
            // 
            this.colMaDVT.DataPropertyName = "MaDVT";
            this.colMaDVT.HeaderText = "MaDVT";
            this.colMaDVT.Name = "colMaDVT";
            this.colMaDVT.ReadOnly = true;
            this.colMaDVT.Visible = false;
            // 
            // colTenDVT
            // 
            this.colTenDVT.DataPropertyName = "TenDVT";
            this.colTenDVT.HeaderText = "DVT";
            this.colTenDVT.Name = "colTenDVT";
            this.colTenDVT.ReadOnly = true;
            // 
            // colDonGiaNhap
            // 
            this.colDonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.colDonGiaNhap.HeaderText = "Đơn giá";
            this.colDonGiaNhap.Name = "colDonGiaNhap";
            this.colDonGiaNhap.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            this.colThanhTien.Width = 150;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.DataPropertyName = "MaNhanVien";
            this.colMaNhanVien.HeaderText = "maNhanVien";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.ReadOnly = true;
            this.colMaNhanVien.Visible = false;
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.DataPropertyName = "TenNhanVien";
            this.colTenNhanVien.HeaderText = "Tên nhân viên";
            this.colTenNhanVien.Name = "colTenNhanVien";
            this.colTenNhanVien.ReadOnly = true;
            this.colTenNhanVien.Width = 150;
            // 
            // colSoLuongNhapTon
            // 
            this.colSoLuongNhapTon.DataPropertyName = "SoLuongNhapTon";
            this.colSoLuongNhapTon.HeaderText = "Số tồn";
            this.colSoLuongNhapTon.Name = "colSoLuongNhapTon";
            this.colSoLuongNhapTon.ReadOnly = true;
            // 
            // gbThongTinPhieuNhap
            // 
            this.gbThongTinPhieuNhap.Controls.Add(this.btnHuy);
            this.gbThongTinPhieuNhap.Controls.Add(this.btnChinhSua);
            this.gbThongTinPhieuNhap.Controls.Add(this.txtDonGia);
            this.gbThongTinPhieuNhap.Controls.Add(this.txtSoLuong);
            this.gbThongTinPhieuNhap.Controls.Add(this.label7);
            this.gbThongTinPhieuNhap.Controls.Add(this.label6);
            this.gbThongTinPhieuNhap.Controls.Add(this.lblNhanVien);
            this.gbThongTinPhieuNhap.Controls.Add(this.label2);
            this.gbThongTinPhieuNhap.Controls.Add(this.dtpNgayNhap);
            this.gbThongTinPhieuNhap.Controls.Add(this.label4);
            this.gbThongTinPhieuNhap.Controls.Add(this.lblTenSP);
            this.gbThongTinPhieuNhap.Controls.Add(this.label3);
            this.gbThongTinPhieuNhap.Controls.Add(this.lblMaSP);
            this.gbThongTinPhieuNhap.Controls.Add(this.label1);
            this.gbThongTinPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbThongTinPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbThongTinPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.gbThongTinPhieuNhap.Name = "gbThongTinPhieuNhap";
            this.gbThongTinPhieuNhap.Size = new System.Drawing.Size(1160, 140);
            this.gbThongTinPhieuNhap.TabIndex = 4;
            this.gbThongTinPhieuNhap.TabStop = false;
            this.gbThongTinPhieuNhap.Text = "Thông tin phiếu nhập";
            // 
            // gbChiTietPhieuNhap
            // 
            this.gbChiTietPhieuNhap.Controls.Add(this.dgvChiTietNhap);
            this.gbChiTietPhieuNhap.Controls.Add(this.statusStrip1);
            this.gbChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbChiTietPhieuNhap.Location = new System.Drawing.Point(0, 140);
            this.gbChiTietPhieuNhap.Name = "gbChiTietPhieuNhap";
            this.gbChiTietPhieuNhap.Size = new System.Drawing.Size(1160, 581);
            this.gbChiTietPhieuNhap.TabIndex = 5;
            this.gbChiTietPhieuNhap.TabStop = false;
            this.gbChiTietPhieuNhap.Text = "Chi tiết phiếu nhập : ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1154, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP:";
            // 
            // lblMaSP
            // 
            this.lblMaSP.BackColor = System.Drawing.Color.White;
            this.lblMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.Location = new System.Drawing.Point(97, 37);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(244, 20);
            this.lblMaSP.TabIndex = 1;
            this.lblMaSP.Text = "N/A";
            // 
            // lblTenSP
            // 
            this.lblTenSP.BackColor = System.Drawing.Color.White;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(97, 75);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(244, 20);
            this.lblTenSP.TabIndex = 3;
            this.lblTenSP.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên SP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày nhập:";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(496, 34);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(244, 26);
            this.dtpNgayNhap.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhân viên:";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.BackColor = System.Drawing.Color.White;
            this.lblNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(97, 113);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(244, 20);
            this.lblNhanVien.TabIndex = 8;
            this.lblNhanVien.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Đơn giá:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(496, 72);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(244, 26);
            this.txtSoLuong.TabIndex = 10;
            this.txtSoLuong.Text = "0";
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(496, 108);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(244, 26);
            this.txtDonGia.TabIndex = 11;
            this.txtDonGia.Text = "0";
            this.txtDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnChinhSua.FlatAppearance.BorderSize = 0;
            this.btnChinhSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.ForeColor = System.Drawing.Color.White;
            this.btnChinhSua.Location = new System.Drawing.Point(801, 31);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(319, 32);
            this.btnChinhSua.TabIndex = 12;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(801, 69);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(319, 32);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // Frm_NhapSanPham_SuaPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 721);
            this.Controls.Add(this.gbChiTietPhieuNhap);
            this.Controls.Add(this.gbThongTinPhieuNhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_NhapSanPham_SuaPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa thông tin phiếu nhập";
            this.Load += new System.EventHandler(this.Frm_NhapSanPham_SuaPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).EndInit();
            this.gbThongTinPhieuNhap.ResumeLayout(false);
            this.gbThongTinPhieuNhap.PerformLayout();
            this.gbChiTietPhieuNhap.ResumeLayout(false);
            this.gbChiTietPhieuNhap.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiTietNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongNhapTon;
        private System.Windows.Forms.GroupBox gbThongTinPhieuNhap;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbChiTietPhieuNhap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}