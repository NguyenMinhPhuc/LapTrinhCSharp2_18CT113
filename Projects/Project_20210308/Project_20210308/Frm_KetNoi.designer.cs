namespace Project_20210308
{
    partial class Frm_KetNoi
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
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbWinNT = new System.Windows.Forms.CheckBox();
            this.gbConnectToServer = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.ckbShowPassword = new System.Windows.Forms.CheckBox();
            this.gbConnectToServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server name:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(200, 45);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(472, 35);
            this.txtServerName.TabIndex = 1;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(200, 87);
            this.txtDatabaseName.Margin = new System.Windows.Forms.Padding(7);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(472, 35);
            this.txtDatabaseName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database name:";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(200, 129);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(7);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(472, 35);
            this.txtUserId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "User id:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(200, 171);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(7);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(472, 35);
            this.txtPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // ckbWinNT
            // 
            this.ckbWinNT.AutoSize = true;
            this.ckbWinNT.Location = new System.Drawing.Point(565, 216);
            this.ckbWinNT.Name = "ckbWinNT";
            this.ckbWinNT.Size = new System.Drawing.Size(107, 33);
            this.ckbWinNT.TabIndex = 8;
            this.ckbWinNT.Text = "WinNT";
            this.ckbWinNT.UseVisualStyleBackColor = true;
            this.ckbWinNT.CheckedChanged += new System.EventHandler(this.ckbWinNT_CheckedChanged);
            // 
            // gbConnectToServer
            // 
            this.gbConnectToServer.Controls.Add(this.ckbShowPassword);
            this.gbConnectToServer.Controls.Add(this.label1);
            this.gbConnectToServer.Controls.Add(this.ckbWinNT);
            this.gbConnectToServer.Controls.Add(this.txtServerName);
            this.gbConnectToServer.Controls.Add(this.txtPassword);
            this.gbConnectToServer.Controls.Add(this.label2);
            this.gbConnectToServer.Controls.Add(this.label4);
            this.gbConnectToServer.Controls.Add(this.txtDatabaseName);
            this.gbConnectToServer.Controls.Add(this.txtUserId);
            this.gbConnectToServer.Controls.Add(this.label3);
            this.gbConnectToServer.Location = new System.Drawing.Point(12, 12);
            this.gbConnectToServer.Name = "gbConnectToServer";
            this.gbConnectToServer.Size = new System.Drawing.Size(683, 258);
            this.gbConnectToServer.TabIndex = 9;
            this.gbConnectToServer.TabStop = false;
            this.gbConnectToServer.Text = "Connect to Server";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(397, 276);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(146, 37);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(549, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 37);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(12, 276);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(379, 37);
            this.btnCheck.TabIndex = 12;
            this.btnCheck.Text = "Check connect to server";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // ckbShowPassword
            // 
            this.ckbShowPassword.AutoSize = true;
            this.ckbShowPassword.Location = new System.Drawing.Point(200, 217);
            this.ckbShowPassword.Name = "ckbShowPassword";
            this.ckbShowPassword.Size = new System.Drawing.Size(204, 33);
            this.ckbShowPassword.TabIndex = 9;
            this.ckbShowPassword.Text = "Show password";
            this.ckbShowPassword.UseVisualStyleBackColor = true;
            this.ckbShowPassword.CheckedChanged += new System.EventHandler(this.ckbShowPassword_CheckedChanged);
            // 
            // Frm_KetNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 322);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.gbConnectToServer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Frm_KetNoi";
            this.Text = "Connect to server";
            this.Load += new System.EventHandler(this.Frm_KetNoi_Load);
            this.gbConnectToServer.ResumeLayout(false);
            this.gbConnectToServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbWinNT;
        private System.Windows.Forms.GroupBox gbConnectToServer;
        private System.Windows.Forms.CheckBox ckbShowPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheck;
    }
}