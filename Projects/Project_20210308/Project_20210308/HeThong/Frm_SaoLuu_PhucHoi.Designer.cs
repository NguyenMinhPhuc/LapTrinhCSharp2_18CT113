namespace Project_20210308.HeThong
{
    partial class Frm_SaoLuu_PhucHoi
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
            this.lblpath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ckbPhucHoi = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpath.Location = new System.Drawing.Point(-2, 53);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(180, 29);
            this.lblpath.TabIndex = 0;
            this.lblpath.Text = " Đường dẫn file:";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(196)))), ((int)(((byte)(244)))));
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(12, 85);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(680, 35);
            this.txtPath.TabIndex = 1;
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(196)))), ((int)(((byte)(244)))));
            this.btnChon.FlatAppearance.BorderSize = 0;
            this.btnChon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(695, 85);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(62, 35);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "...";
            this.btnChon.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(51)))), ((int)(((byte)(237)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(473, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thực hiện";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ckbPhucHoi
            // 
            this.ckbPhucHoi.AutoSize = true;
            this.ckbPhucHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(51)))), ((int)(((byte)(237)))));
            this.ckbPhucHoi.FlatAppearance.BorderSize = 0;
            this.ckbPhucHoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ckbPhucHoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbPhucHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPhucHoi.ForeColor = System.Drawing.Color.White;
            this.ckbPhucHoi.Location = new System.Drawing.Point(12, 17);
            this.ckbPhucHoi.Name = "ckbPhucHoi";
            this.ckbPhucHoi.Size = new System.Drawing.Size(217, 33);
            this.ckbPhucHoi.TabIndex = 4;
            this.ckbPhucHoi.Text = "Thác tác phục hồi";
            this.ckbPhucHoi.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 132);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(769, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblErr
            // 
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(16, 17);
            this.lblErr.Text = "...";
            // 
            // Frm_SaoLuu_PhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 154);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ckbPhucHoi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblpath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_SaoLuu_PhucHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sao lưu phục hồi dữ liệu";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox ckbPhucHoi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
    }
}