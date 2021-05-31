namespace GiaiBaiKiemTra
{
    partial class Frm_XemBaoCao
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
            this.reportDanhSach = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // reportDanhSach
            // 
            this.reportDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportDanhSach.Location = new System.Drawing.Point(0, 37);
            this.reportDanhSach.Name = "reportDanhSach";
            this.reportDanhSach.Size = new System.Drawing.Size(697, 537);
            this.reportDanhSach.TabIndex = 0;
            // 
            // cboLoaiSanPham
            // 
            this.cboLoaiSanPham.FormattingEnabled = true;
            this.cboLoaiSanPham.Location = new System.Drawing.Point(5, 8);
            this.cboLoaiSanPham.Name = "cboLoaiSanPham";
            this.cboLoaiSanPham.Size = new System.Drawing.Size(278, 21);
            this.cboLoaiSanPham.TabIndex = 1;
            this.cboLoaiSanPham.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSanPham_SelectedIndexChanged);
            // 
            // Frm_XemBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 574);
            this.Controls.Add(this.cboLoaiSanPham);
            this.Controls.Add(this.reportDanhSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_XemBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_XemBaoCao";
            this.Load += new System.EventHandler(this.Frm_XemBaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportDanhSach;
        private System.Windows.Forms.ComboBox cboLoaiSanPham;
    }
}