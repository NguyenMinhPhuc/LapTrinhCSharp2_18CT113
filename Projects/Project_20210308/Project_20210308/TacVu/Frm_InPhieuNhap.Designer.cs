namespace Project_20210308.TacVu
{
    partial class Frm_InPhieuNhap
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
            this.rp_InPhieuNhap = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rp_InPhieuNhap
            // 
            this.rp_InPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp_InPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.rp_InPhieuNhap.Name = "rp_InPhieuNhap";
            this.rp_InPhieuNhap.Size = new System.Drawing.Size(1093, 479);
            this.rp_InPhieuNhap.TabIndex = 0;
            // 
            // Frm_InPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 479);
            this.Controls.Add(this.rp_InPhieuNhap);
            this.Name = "Frm_InPhieuNhap";
            this.Text = "Frm_InPhieuNhap";
            this.Load += new System.EventHandler(this.Frm_InPhieuNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp_InPhieuNhap;
    }
}