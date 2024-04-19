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
    public partial class frmPhongBan : DevExpress.XtraEditors.XtraForm
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }
        BusinessLayer.PHONGBAN _PHONGBAN;
        bool _them;
        string _id;
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            _them = false;
            _PHONGBAN = new BusinessLayer.PHONGBAN();
            _ShowHide(true);
            loadData();
        }
        void _ShowHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnDong.Enabled = kt;
            btnXoa.Enabled = kt;
            tbTen.Enabled = !kt;
            tbMa.Enabled = !kt;

        }
        void loadData()
        {
            gcDanhSach.DataSource = _PHONGBAN.getList();
            gvDanhSach.OptionsBehavior.Editable = false;


        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

       

        
       

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            if (_them)
            {
                DataLayer.PHONGBAN tg = new DataLayer.PHONGBAN();
                tg.MAPB = tbMa.Text;
                tg.TENPHONGBAN = tbTen.Text;
                _PHONGBAN.Add(tg);

            }
            else
            {
                var tg = _PHONGBAN.getItem(tbMa.Text);

                tg.TENPHONGBAN = tbTen.Text;
                _PHONGBAN.Update(tg);
            }

        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                tbTen.Text = gvDanhSach.GetFocusedRowCellValue("TENPHONGBAN").ToString();
                tbMa.Text = gvDanhSach.GetFocusedRowCellValue("MAPB").ToString();
            }  
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _PHONGBAN.Delete(tbMa.Text);
                _PHONGBAN.Delete(tbTen.Text);
                loadData();
            }
        }

        private void btThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ShowHide(false);
            _them = true;
            tbTen.Text = string.Empty;
            tbMa.Text = string.Empty;
        }
      
        private void btSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ShowHide(false);
            _them = false;
        }

        private void btLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _ShowHide(true);
        }

        private void btHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _ShowHide(true);
        }

        private void btDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}