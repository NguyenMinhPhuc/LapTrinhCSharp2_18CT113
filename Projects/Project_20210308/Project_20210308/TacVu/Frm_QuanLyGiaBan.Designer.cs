namespace Project_20210308.TacVu
{
    partial class Frm_QuanLyGiaBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachGiaBan = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ckbLocSanPham = new System.Windows.Forms.CheckBox();
            this.bntThayDoiGiaBan = new System.Windows.Forms.Button();
            this.txtGiaBanMoi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGiaBan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lọc sản phẩm";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(17, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(435, 35);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGiaBanMoi);
            this.panel1.Controls.Add(this.bntThayDoiGiaBan);
            this.panel1.Controls.Add(this.ckbLocSanPham);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 125);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachGiaBan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 473);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dgvDanhSachGiaBan
            // 
            this.dgvDanhSachGiaBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachGiaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachGiaBan.Location = new System.Drawing.Point(3, 25);
            this.dgvDanhSachGiaBan.Name = "dgvDanhSachGiaBan";
            this.dgvDanhSachGiaBan.Size = new System.Drawing.Size(937, 445);
            this.dgvDanhSachGiaBan.TabIndex = 0;
            this.dgvDanhSachGiaBan.Click += new System.EventHandler(this.dgvDanhSachGiaBan_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 598);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(943, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ckbLocSanPham
            // 
            this.ckbLocSanPham.AutoSize = true;
            this.ckbLocSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLocSanPham.Location = new System.Drawing.Point(17, 83);
            this.ckbLocSanPham.Name = "ckbLocSanPham";
            this.ckbLocSanPham.Size = new System.Drawing.Size(329, 33);
            this.ckbLocSanPham.TabIndex = 2;
            this.ckbLocSanPham.Text = "Chọn lọc theo mã sản phẩm";
            this.ckbLocSanPham.UseVisualStyleBackColor = true;
            // 
            // bntThayDoiGiaBan
            // 
            this.bntThayDoiGiaBan.FlatAppearance.BorderSize = 0;
            this.bntThayDoiGiaBan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bntThayDoiGiaBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntThayDoiGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThayDoiGiaBan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bntThayDoiGiaBan.Location = new System.Drawing.Point(761, 12);
            this.bntThayDoiGiaBan.Name = "bntThayDoiGiaBan";
            this.bntThayDoiGiaBan.Size = new System.Drawing.Size(170, 104);
            this.bntThayDoiGiaBan.TabIndex = 3;
            this.bntThayDoiGiaBan.Text = "button1";
            this.bntThayDoiGiaBan.UseVisualStyleBackColor = true;
            this.bntThayDoiGiaBan.Click += new System.EventHandler(this.bntThayDoiGiaBan_Click);
            // 
            // txtGiaBanMoi
            // 
            this.txtGiaBanMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBanMoi.Location = new System.Drawing.Point(512, 41);
            this.txtGiaBanMoi.Name = "txtGiaBanMoi";
            this.txtGiaBanMoi.Size = new System.Drawing.Size(243, 35);
            this.txtGiaBanMoi.TabIndex = 4;
            this.txtGiaBanMoi.Text = "0";
            this.txtGiaBanMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Frm_QuanLyGiaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 620);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_QuanLyGiaBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý giá bán";
            this.Load += new System.EventHandler(this.Frm_QuanLyGiaBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGiaBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachGiaBan;
        private System.Windows.Forms.CheckBox ckbLocSanPham;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtGiaBanMoi;
        private System.Windows.Forms.Button bntThayDoiGiaBan;
    }
}