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
using BusinessLayer;

namespace QLNHANSU
{
    public partial class frmDanToc : DevExpress.XtraEditors.XtraForm
    {
        public frmDanToc()
        {
            InitializeComponent();
        }
        BusinessLayer.DANTOC _DANTOC;
        bool _them;
        string _id;
        private void frmDanToc_Load(object sender, EventArgs e)
        {
            _them = false;
            _DANTOC = new BusinessLayer.DANTOC();
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
            gcDanhSach.DataSource = _DANTOC.getList();
            gvDanhSach.OptionsBehavior.Editable = false;


        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ShowHide(false);
            _them = true;
            tbTen.Text = string.Empty;
            tbMa.Text = string.Empty;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ShowHide(false);
            _them = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _DANTOC.Delete(tbMa.Text);
                _DANTOC.Delete(tbTen.Text);

                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
           
            
            _ShowHide(true);
            SaveData();
            _them = false;
            loadData();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _ShowHide(true);
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
       
        void SaveData()
        {
            if (_them)
            {
                DataLayer.DANTOC DT = new DataLayer.DANTOC();
                DT.MADT = tbMa.Text;
                DT.TENDANTOC = tbTen.Text;
                _DANTOC.Add(DT);

            }
            else
            {
                var DT = _DANTOC.getItem(tbMa.Text);
                DT.TENDANTOC = tbTen.Text;
                _DANTOC.Update(DT);
            }

        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                tbTen.Text = gvDanhSach.GetFocusedRowCellValue("TENDANTOC").ToString();
                tbMa.Text = gvDanhSach.GetFocusedRowCellValue("MADT").ToString();
            }
        }

        private void frmDanToc_LocationChanged(object sender, EventArgs e)
        {

        }
    }
}