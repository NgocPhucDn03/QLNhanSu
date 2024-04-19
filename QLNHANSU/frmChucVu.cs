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
    public partial class frmChucVu : DevExpress.XtraEditors.XtraForm
    {
        public frmChucVu()
        {
            InitializeComponent();
            _CHUCVU = new CHUCVU();
        }
        BusinessLayer.CHUCVU _CHUCVU;
        bool _them;
        string _id;
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
            gcDanhSach.DataSource = _CHUCVU.getList();
            gvDanhSach.OptionsBehavior.Editable = false;


        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            _them = false;
            _CHUCVU = new BusinessLayer.CHUCVU();
            _ShowHide(true);
            loadData();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ShowHide(false);
            _them = true;
          
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
                _CHUCVU.Delete(tbMa.Text);
                _CHUCVU.Delete(tbTen.Text);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
           
            _ShowHide(true);
            SaveData();
            loadData();
            _them = false;
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
                DataLayer.CHUCVU DT = new DataLayer.CHUCVU();
                DT.MACV = tbMa.Text;
                DT.TENCHUCVU = tbTen.Text;
                _CHUCVU.Add(DT);

            }
            else
            {
                var DT = _CHUCVU.getItem(tbMa.Text);
                DT.TENCHUCVU = tbTen.Text;
                _CHUCVU.Update(DT);
            }

        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                tbTen.Text = gvDanhSach.GetFocusedRowCellValue("TENCHUCVU").ToString();
                tbMa.Text = gvDanhSach.GetFocusedRowCellValue("MACV").ToString();
            }
        }
    }
}