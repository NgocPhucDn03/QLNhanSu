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
    public partial class frmQuocTich : DevExpress.XtraEditors.XtraForm
    {
        public frmQuocTich()
        {
            InitializeComponent();
            _QUOCTICH = new QUOCTICH();
        }
        BusinessLayer.QUOCTICH _QUOCTICH;
        bool _them;
        string _id;
        private void frmQuocTich_Load(object sender, EventArgs e)
        {
            _them = false;
            _QUOCTICH = new BusinessLayer.QUOCTICH();
            _ShowHide(true);
            loadData();
        }
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
            gcDanhSach.DataSource = _QUOCTICH.getList();
            gvDanhSach.OptionsBehavior.Editable = false;


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
                _QUOCTICH.Delete(tbMa.Text);
                _QUOCTICH.Delete(tbTen.Text);
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
                DataLayer.QUOCTICH DT = new DataLayer.QUOCTICH();
                DT.MAQT = tbMa.Text;
                DT.TENQUOCTICH = tbTen.Text;
                _QUOCTICH.Add(DT);

            }
            else 
            {
                
                    // Sửa
                    var DT = _QUOCTICH.getItem(tbMa.Text); // Lấy thông tin cần sửa dựa trên _i   
                                                // Cập nhật giá trị của cả MAQT và TENQUOCTICH
                    DT.TENQUOCTICH = tbTen.Text;
                     
                _QUOCTICH.Update(DT);
                
            }

        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (!_them)
            {
                tbTen.Text = gvDanhSach.GetFocusedRowCellValue("TENQUOCTICH").ToString();
                tbMa.Text = gvDanhSach.GetFocusedRowCellValue("MAQT").ToString();
            }
        }
    }
}