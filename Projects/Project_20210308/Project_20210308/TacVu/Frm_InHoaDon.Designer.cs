namespace Project_20210308.TacVu
{
    partial class Frm_InHoaDon
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
            this.rp_InHoaDon_Viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rp_InHoaDon_Viewer
            // 
            this.rp_InHoaDon_Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp_InHoaDon_Viewer.Location = new System.Drawing.Point(0, 0);
            this.rp_InHoaDon_Viewer.Name = "rp_InHoaDon_Viewer";
            this.rp_InHoaDon_Viewer.Size = new System.Drawing.Size(652, 764);
            this.rp_InHoaDon_Viewer.TabIndex = 0;
            // 
            // Frm_InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 764);
            this.Controls.Add(this.rp_InHoaDon_Viewer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Frm_InHoaDon";
            this.Text = "Frm_InHoaDon";
            this.Load += new System.EventHandler(this.Frm_InHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp_InHoaDon_Viewer;
    }
}