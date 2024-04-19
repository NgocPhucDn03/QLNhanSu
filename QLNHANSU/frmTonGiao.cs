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
using DataLayer;
using BusinessLayer;

namespace QLNHANSU
{
    public partial class frmTonGiao : DevExpress.XtraEditors.XtraForm
    {
        public frmTonGiao()
        {
            InitializeComponent();
        }
        BusinessLayer.TONGIAO _tongiao;
        bool _them;
        string _id;
    
        private void frmTonGiao_Load(object sender, EventArgs e)
        {
            _them = false;
            _tongiao = new BusinessLayer.TONGIAO();
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
            gcDanhSach.DataSource = _tongiao.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
            

        }
        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ShowHide(false);
            _them   = true; 
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
                _tongiao.Delete(tbMa.Text);
                _tongiao.Delete(tbTen.Text);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _ShowHide(true);
            
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void SaveData()
        {
            if (_them)
            {
                DataLayer.TONGIAO tg = new DataLayer.TONGIAO();
                tg.MATG = tbMa.Text;
                tg.TENTONGIAO = tbTen.Text;
                _tongiao.Add(tg);

            }
            else
            {
                var tg = _tongiao.getItem(tbMa.Text);
                
                 tg.TENTONGIAO=tbTen.Text;
                _tongiao.Update(tg);
            }
                      
        }

        private void tbTen_TextChanged(object sender, EventArgs e)
        {

        }



        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                tbTen.Text = gvDanhSach.GetFocusedRowCellValue("TENTONGIAO").ToString();
                tbMa.Text = gvDanhSach.GetFocusedRowCellValue("MATG").ToString();
            }
               
        }   
    }
}