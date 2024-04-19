using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANSU
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            myInit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtuser.BorderStyle = BorderStyle.Fixed3D;
        }
        private void myInit()
        {
            Label lb = new Label();
            lb.BackColor = SystemColors.Window;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Application.Exit(); 
            this.Close();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = password.Text;
            if (user == "lannhi12" && pass == "123")
            {
                MessageBox.Show("Đăng nhập thành công");

                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}