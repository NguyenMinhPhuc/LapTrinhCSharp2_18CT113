namespace GiaiBaiKiemTra
{
    partial class Frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuThongTinSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLySanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongTinSinhVien,
            this.mnuQuanLySanPham});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuThongTinSinhVien
            // 
            this.mnuThongTinSinhVien.Name = "mnuThongTinSinhVien";
            this.mnuThongTinSinhVien.Size = new System.Drawing.Size(207, 34);
            this.mnuThongTinSinhVien.Text = "Thông tin sinh viên";
            this.mnuThongTinSinhVien.Click += new System.EventHandler(this.mnuThongTinSinhVien_Click);
            // 
            // mnuQuanLySanPham
            // 
            this.mnuQuanLySanPham.Name = "mnuQuanLySanPham";
            this.mnuQuanLySanPham.Size = new System.Drawing.Size(198, 34);
            this.mnuQuanLySanPham.Text = "Quản lý sản phẩm";
            this.mnuQuanLySanPham.Click += new System.EventHandler(this.mnuQuanLySanPham_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 662);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLySanPham;
    }
}

