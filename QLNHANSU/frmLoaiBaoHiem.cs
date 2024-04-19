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
using DataLayer;

namespace QLNHANSU
{
    public partial class frmLoaiBaoHiem : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiBaoHiem()
        {
            InitializeComponent();
            _LOAIBAOHIEM = new BusinessLayer.LOAIBAOHIEM();
        }
        BusinessLayer.LOAIBAOHIEM _LOAIBAOHIEM;
        bool _them;
        int _id;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }
        private void frmLoaiBaoHiem_Load(object sender, EventArgs e)
        {
            loadData();
            _them = false;
            _ShowHide(true);
           
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
            

        }
        void loadData()
        {
            gcDanhSach.DataSource = _LOAIBAOHIEM.getList();
            gvDanhSach.OptionsBehavior.Editable = false;


        }
        void SaveData()
        {
            if (_them)
            {
                DataLayer.LOAIBAOHIEM lbh = new DataLayer.LOAIBAOHIEM();
                lbh.TENBAOHIEM = tbTen.Text;
                _LOAIBAOHIEM.Add(lbh);

            }
            else
            {
                var lbh = _LOAIBAOHIEM.getItem(_id);
                lbh.TENBAOHIEM = tbTen.Text;
                _LOAIBAOHIEM.Update(lbh);
            }

        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ShowHide(false);
            _them = true;
           
           
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _ShowHide(false);
            
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _LOAIBAOHIEM.Delete(_id);
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
       
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (!_them) // Chỉ gán giá trị khi không trong chế độ thêm mới
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("LBH_ID").ToString());
                tbTen.Text = gvDanhSach.GetFocusedRowCellValue("TENBAOHIEM").ToString();
            }

        }
    }
}