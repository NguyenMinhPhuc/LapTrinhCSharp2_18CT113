namespace Project_20210308.HeThong
{
    partial class Frm_PhanQuyen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTaiKhoan = new System.Windows.Forms.ComboBox();
            this.dgvPhanQuyen = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTongQuyenThayDoi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.ckbXoa = new System.Windows.Forms.CheckBox();
            this.ckbSua = new System.Windows.Forms.CheckBox();
            this.ckbThem = new System.Windows.Forms.CheckBox();
            this.ckbXem = new System.Windows.Forms.CheckBox();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colThem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSua = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTongQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Loại tài khoản:";
            // 
            // cboTaiKhoan
            // 
            this.cboTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.cboTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTaiKhoan.FormattingEnabled = true;
            this.cboTaiKhoan.Location = new System.Drawing.Point(63, 41);
            this.cboTaiKhoan.Name = "cboTaiKhoan";
            this.cboTaiKhoan.Size = new System.Drawing.Size(486, 37);
            this.cboTaiKhoan.TabIndex = 1;
            this.cboTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.cboTaiKhoan_SelectedIndexChanged);
            // 
            // dgvPhanQuyen
            // 
            this.dgvPhanQuyen.AllowUserToAddRows = false;
            this.dgvPhanQuyen.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            this.dgvPhanQuyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhanQuyen.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhanQuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colTenChucNang,
            this.colMaChucNang,
            this.colMaTaiKhoan,
            this.colXem,
            this.colThem,
            this.colSua,
            this.colXoa,
            this.colTongQuyen});
            this.dgvPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhanQuyen.Location = new System.Drawing.Point(3, 25);
            this.dgvPhanQuyen.Name = "dgvPhanQuyen";
            this.dgvPhanQuyen.ReadOnly = true;
            this.dgvPhanQuyen.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            this.dgvPhanQuyen.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPhanQuyen.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhanQuyen.RowTemplate.Height = 42;
            this.dgvPhanQuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanQuyen.Size = new System.Drawing.Size(1149, 586);
            this.dgvPhanQuyen.TabIndex = 2;
            this.dgvPhanQuyen.Click += new System.EventHandler(this.dgvPhanQuyen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPhanQuyen);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1155, 614);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết phân quyền";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 704);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1155, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblErr
            // 
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(16, 17);
            this.lblErr.Text = "...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTongQuyenThayDoi);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnThayDoi);
            this.panel1.Controls.Add(this.ckbXoa);
            this.panel1.Controls.Add(this.ckbSua);
            this.panel1.Controls.Add(this.ckbThem);
            this.panel1.Controls.Add(this.ckbXem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboTaiKhoan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 90);
            this.panel1.TabIndex = 5;
            // 
            // lblTongQuyenThayDoi
            // 
            this.lblTongQuyenThayDoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.lblTongQuyenThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongQuyenThayDoi.ForeColor = System.Drawing.Color.White;
            this.lblTongQuyenThayDoi.Location = new System.Drawing.Point(555, 6);
            this.lblTongQuyenThayDoi.Name = "lblTongQuyenThayDoi";
            this.lblTongQuyenThayDoi.Size = new System.Drawing.Size(396, 34);
            this.lblTongQuyenThayDoi.TabIndex = 8;
            this.lblTongQuyenThayDoi.Text = "0";
            this.lblTongQuyenThayDoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(19)))), ((int)(((byte)(209)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(367, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tạo loại tài khoản";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(19)))), ((int)(((byte)(209)))));
            this.btnThayDoi.FlatAppearance.BorderSize = 0;
            this.btnThayDoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThayDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayDoi.ForeColor = System.Drawing.Color.White;
            this.btnThayDoi.Location = new System.Drawing.Point(961, 6);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(191, 75);
            this.btnThayDoi.TabIndex = 6;
            this.btnThayDoi.Text = "Thay đổi";
            this.btnThayDoi.UseVisualStyleBackColor = false;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // ckbXoa
            // 
            this.ckbXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.ckbXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbXoa.ForeColor = System.Drawing.Color.Black;
            this.ckbXoa.Location = new System.Drawing.Point(856, 43);
            this.ckbXoa.Name = "ckbXoa";
            this.ckbXoa.Size = new System.Drawing.Size(95, 33);
            this.ckbXoa.TabIndex = 5;
            this.ckbXoa.Text = "Xoá";
            this.ckbXoa.UseVisualStyleBackColor = false;
            this.ckbXoa.CheckedChanged += new System.EventHandler(this.ckbXoa_CheckedChanged);
            // 
            // ckbSua
            // 
            this.ckbSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(196)))), ((int)(((byte)(244)))));
            this.ckbSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSua.Location = new System.Drawing.Point(756, 43);
            this.ckbSua.Name = "ckbSua";
            this.ckbSua.Size = new System.Drawing.Size(95, 33);
            this.ckbSua.TabIndex = 4;
            this.ckbSua.Text = "Sửa";
            this.ckbSua.UseVisualStyleBackColor = false;
            this.ckbSua.CheckedChanged += new System.EventHandler(this.ckbSua_CheckedChanged);
            // 
            // ckbThem
            // 
            this.ckbThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(207)))), ((int)(((byte)(224)))));
            this.ckbThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbThem.Location = new System.Drawing.Point(652, 43);
            this.ckbThem.Name = "ckbThem";
            this.ckbThem.Size = new System.Drawing.Size(95, 33);
            this.ckbThem.TabIndex = 3;
            this.ckbThem.Text = "Thêm";
            this.ckbThem.UseVisualStyleBackColor = false;
            this.ckbThem.CheckedChanged += new System.EventHandler(this.ckbThem_CheckedChanged);
            // 
            // ckbXem
            // 
            this.ckbXem.AutoSize = true;
            this.ckbXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.ckbXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbXem.Location = new System.Drawing.Point(555, 43);
            this.ckbXem.Name = "ckbXem";
            this.ckbXem.Size = new System.Drawing.Size(83, 33);
            this.ckbXem.TabIndex = 2;
            this.ckbXem.Text = "Xem";
            this.ckbXem.UseVisualStyleBackColor = false;
            this.ckbXem.CheckedChanged += new System.EventHandler(this.ckbXem_CheckedChanged);
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 60;
            // 
            // colTenChucNang
            // 
            this.colTenChucNang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenChucNang.DataPropertyName = "TenChucNang";
            this.colTenChucNang.HeaderText = "Tên chức năng";
            this.colTenChucNang.Name = "colTenChucNang";
            this.colTenChucNang.ReadOnly = true;
            // 
            // colMaChucNang
            // 
            this.colMaChucNang.DataPropertyName = "MaChucNang";
            this.colMaChucNang.HeaderText = "MaChucNang";
            this.colMaChucNang.Name = "colMaChucNang";
            this.colMaChucNang.ReadOnly = true;
            this.colMaChucNang.Visible = false;
            // 
            // colMaTaiKhoan
            // 
            this.colMaTaiKhoan.DataPropertyName = "MaTaiKhoan";
            this.colMaTaiKhoan.HeaderText = "maTaiKhoan";
            this.colMaTaiKhoan.Name = "colMaTaiKhoan";
            this.colMaTaiKhoan.ReadOnly = true;
            this.colMaTaiKhoan.Visible = false;
            // 
            // colXem
            // 
            this.colXem.DataPropertyName = "Xem";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.NullValue = false;
            this.colXem.DefaultCellStyle = dataGridViewCellStyle3;
            this.colXem.HeaderText = "Xem";
            this.colXem.Name = "colXem";
            this.colXem.ReadOnly = true;
            this.colXem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colXem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colThem
            // 
            this.colThem.DataPropertyName = "Them";
            this.colThem.HeaderText = "Thêm";
            this.colThem.Name = "colThem";
            this.colThem.ReadOnly = true;
            this.colThem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colThem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSua
            // 
            this.colSua.DataPropertyName = "Sua";
            this.colSua.HeaderText = "Sửa";
            this.colSua.Name = "colSua";
            this.colSua.ReadOnly = true;
            this.colSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colXoa
            // 
            this.colXoa.DataPropertyName = "Xoa";
            this.colXoa.HeaderText = "Xoá";
            this.colXoa.Name = "colXoa";
            this.colXoa.ReadOnly = true;
            this.colXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colXoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTongQuyen
            // 
            this.colTongQuyen.DataPropertyName = "GiaTriQuyen";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colTongQuyen.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTongQuyen.HeaderText = "Tổng quyền";
            this.colTongQuyen.Name = "colTongQuyen";
            this.colTongQuyen.ReadOnly = true;
            this.colTongQuyen.Width = 200;
            // 
            // Frm_PhanQuyen
            // 
            this.AcceptButton = this.btnThayDoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 726);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_PhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân quyền cho hệ thống";
            this.Load += new System.EventHandler(this.Frm_PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTaiKhoan;
        private System.Windows.Forms.DataGridView dgvPhanQuyen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.CheckBox ckbXoa;
        private System.Windows.Forms.CheckBox ckbSua;
        private System.Windows.Forms.CheckBox ckbThem;
        private System.Windows.Forms.CheckBox ckbXem;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTongQuyenThayDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTaiKhoan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colXem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colThem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSua;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongQuyen;
    }
}