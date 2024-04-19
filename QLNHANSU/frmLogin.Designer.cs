using System.Drawing;
using System.Windows.Forms;

namespace QLNHANSU
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.quenmatkahu = new System.Windows.Forms.Label();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.matkhau = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.tendangnhap = new System.Windows.Forms.Label();
            this.dangnhaptaikhoan = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.quenmatkahu);
            this.panel1.Controls.Add(this.btnDangnhap);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.matkhau);
            this.panel1.Controls.Add(this.txtuser);
            this.panel1.Controls.Add(this.tendangnhap);
            this.panel1.Controls.Add(this.dangnhaptaikhoan);
            this.panel1.Location = new System.Drawing.Point(491, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 317);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(171, 261);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(151, 39);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // quenmatkahu
            // 
            this.quenmatkahu.AccessibleDescription = "";
            this.quenmatkahu.AutoSize = true;
            this.quenmatkahu.BackColor = System.Drawing.Color.White;
            this.quenmatkahu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quenmatkahu.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quenmatkahu.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.quenmatkahu.Location = new System.Drawing.Point(196, 231);
            this.quenmatkahu.Name = "quenmatkahu";
            this.quenmatkahu.Size = new System.Drawing.Size(98, 15);
            this.quenmatkahu.TabIndex = 6;
            this.quenmatkahu.Text = "Quên mật khẩu?";
            this.quenmatkahu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDangnhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.ForeColor = System.Drawing.Color.White;
            this.btnDangnhap.Location = new System.Drawing.Point(14, 261);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(151, 39);
            this.btnDangnhap.TabIndex = 5;
            this.btnDangnhap.Text = "ĐĂNG NHẬP";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // matkhau
            // 
            this.matkhau.AccessibleDescription = "";
            this.matkhau.AutoSize = true;
            this.matkhau.BackColor = System.Drawing.Color.White;
            this.matkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matkhau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.matkhau.Location = new System.Drawing.Point(20, 154);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(85, 20);
            this.matkhau.TabIndex = 3;
            this.matkhau.Text = "Mật khẩu";
            this.matkhau.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(30, 105);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(273, 32);
            this.txtuser.TabIndex = 2;
            // 
            // tendangnhap
            // 
            this.tendangnhap.AccessibleDescription = "";
            this.tendangnhap.AutoSize = true;
            this.tendangnhap.BackColor = System.Drawing.Color.White;
            this.tendangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tendangnhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendangnhap.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.tendangnhap.Location = new System.Drawing.Point(20, 72);
            this.tendangnhap.Name = "tendangnhap";
            this.tendangnhap.Size = new System.Drawing.Size(125, 20);
            this.tendangnhap.TabIndex = 1;
            this.tendangnhap.Text = "Tên đăng nhập";
            this.tendangnhap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dangnhaptaikhoan
            // 
            this.dangnhaptaikhoan.AccessibleDescription = "";
            this.dangnhaptaikhoan.AutoSize = true;
            this.dangnhaptaikhoan.BackColor = System.Drawing.Color.White;
            this.dangnhaptaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangnhaptaikhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhaptaikhoan.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.dangnhaptaikhoan.Location = new System.Drawing.Point(20, 34);
            this.dangnhaptaikhoan.Name = "dangnhaptaikhoan";
            this.dangnhaptaikhoan.Size = new System.Drawing.Size(293, 23);
            this.dangnhaptaikhoan.TabIndex = 0;
            this.dangnhaptaikhoan.Text = "ĐĂNG NHẬP VÀO TÀI KHOẢN";
            this.dangnhaptaikhoan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(30, 190);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(273, 32);
            this.password.TabIndex = 4;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(896, 783);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label dangnhaptaikhoan;
        private Label matkhau;
        private TextBox txtuser;
        private Label tendangnhap;
        private Button btnDangnhap;
        private Label quenmatkahu;
        private Button btnThoat;
        private CheckBox btremem;
        private LinkLabel linkforget;
        private TextBox password;
    }
}