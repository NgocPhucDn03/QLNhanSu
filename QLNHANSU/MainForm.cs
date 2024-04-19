using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNHANSU
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {
           frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
        void openForm(Type typeForm)
        {
            foreach (var frm in MdiChildren)
            {
                if (frm.GetType()==typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f =(Form) Activator.CreateInstance(typeForm);
            f.MdiParent= this;
            f.Show();
        }
        private void btnChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmChucVu));
        }
        private void btnQuocTich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmQuocTich));
        }

      

        private void btnTonGiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTonGiao));
        }

        private void btnDanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmDanToc));
        }

        private void btnTrinhDo_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTrinhDo));
        }

        private void btnHoSo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmHoSo));
        }

        private void btnBaoHiemYTe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmBaoHiemYTe));
        }

        private void btnPhongban_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmPhongBan));
        }

        private void btnBaoHiemNhanSu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmBaoHiemXaHoi));
        }

        private void btnPhieuNghiPhep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmNghiPhep));
        }

        private void btnHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmHopDong));
        }

        private void btnTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTaiKhoan));
        }

        private void btnPhieuLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmLuong));
        }

        private void btnLoaiBaoHiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmLoaiBaoHiem));
        }
    }
}
