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
    public partial class frmTrinhDo : DevExpress.XtraEditors.XtraForm
    {
        public frmTrinhDo()
        {
            InitializeComponent();
        }
        BusinessLayer.TRINHDO _TRINHDO;
        bool _them;
        string _id;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
           
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
            gcDanhSach.DataSource = _TRINHDO.getList();
            gvDanhSach.OptionsBehavior.Editable = false;


        }
        private void frmTrinhDo_Load(object sender, EventArgs e)
        {
            _them = false;
            _TRINHDO = new BusinessLayer.TRINHDO();
            _ShowHide(true);
            loadData();
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
                _TRINHDO.Delete(tbMa.Text);
                _TRINHDO.Delete(tbTen.Text);
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
                DataLayer.TRINHDO DT = new DataLayer.TRINHDO();
                DT.MATD = tbMa.Text;
                DT.TENTRINHDO = tbTen.Text;
                _TRINHDO.Add(DT);

            }
            else
            {
                var DT = _TRINHDO.getItem(tbMa.Text);        
                DT.TENTRINHDO = tbTen.Text;
                _TRINHDO.Update(DT);
            }

        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                tbTen.Text = gvDanhSach.GetFocusedRowCellValue("TENTRINHDO").ToString();
                tbMa.Text = gvDanhSach.GetFocusedRowCellValue("MATD").ToString();
            }
        }
    }
}