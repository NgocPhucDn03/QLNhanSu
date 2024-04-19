using DataLayer;
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
    public partial class frmHoSo : DevExpress.XtraEditors.XtraForm
    {
        public frmHoSo()
        {
            InitializeComponent();
        }
        BusinessLayer.NHANVIEN _nhanvien;
        BusinessLayer.DANTOC _dantoc;
        BusinessLayer.TONGIAO _tongiao;
        BusinessLayer.CHUCVU _chucvu;
        BusinessLayer.PHONGBAN _phongban;
        BusinessLayer.TRINHDO _trinhdo;
        BusinessLayer.QUOCTICH _quoctich;
        bool _them;
        string _id;

        private void frmHoSo_Load(object sender, EventArgs e)
        {
            _them = false;
            _nhanvien = new BusinessLayer.NHANVIEN();
           _dantoc  = new  BusinessLayer.DANTOC();
            _tongiao= new  BusinessLayer.TONGIAO();
            _chucvu = new BusinessLayer.CHUCVU();
            _phongban = new BusinessLayer.PHONGBAN();
             _trinhdo=new BusinessLayer.TRINHDO();
             _quoctich = new BusinessLayer.QUOCTICH();
            _ShowHide(true);
            loadData();
            splitContainer1.Panel1Collapsed = true;
            loadCombo();
        }
        void loadCombo()
        {
          cboDantoc.DataSource = _dantoc.getList();
           cboDantoc.DisplayMember = "TENDANTOC";
           cboDantoc.ValueMember = "MADT";
            cboChucvu.DataSource = _chucvu.getList();
            cboChucvu.DisplayMember = "TENCHUCVU";
            cboChucvu.ValueMember = "MACV";
            cboQuoctich.DataSource = _quoctich.getList();
             cboQuoctich.DisplayMember = "TENQUOCTICH";
            cboQuoctich.ValueMember = "MAQT";
            cboTongiao.DataSource= _tongiao.getList();
            cboTongiao.DisplayMember = "TENTONGIAO";
            cboTongiao.ValueMember = "MATG";
            cboPhongban.DataSource = _phongban.getList();
            cboPhongban.DisplayMember = "TENPHONGBAN";
            cboPhongban.ValueMember = "MAPB";
            cboTrinhdo.DataSource = _trinhdo.getList();
            cboTrinhdo.DisplayMember = "TENTRINHDO";
            cboTrinhdo.ValueMember = "MATD";

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
            tbCCCD.Enabled = !kt;
            tbNoisinh.Enabled = !kt;
            tbSDT.Enabled = !kt;
            tbGioitinh.Enabled = !kt;
            tbEmail.Enabled = !kt;
            tbGhichu.Enabled = !kt;
            cboDantoc.Enabled = !kt;
            cboChucvu.Enabled = !kt;
            cboQuoctich.Enabled = !kt;
            cboTongiao.Enabled = !kt;
            cboPhongban.Enabled = !kt;
            cboTrinhdo.Enabled = !kt;
            dtNgaysinh.Enabled = !kt;


        }
        void _reset()
        {
            tbMa.Text = string.Empty;
            tbTen.Text = string.Empty;
            tbCCCD.Text = string.Empty;
            tbNoisinh.Text = string.Empty;
            tbGioitinh.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbSDT.Text = string.Empty;  

        }
        void loadData()
        {
            gcDanhSach.DataSource = _nhanvien.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;


        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ShowHide(false);
            _them = true;
            _reset();
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ShowHide(false);
            _them = false;
            splitContainer1.Panel1Collapsed = false;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                _nhanvien.Delete(tbMa.Text);
              

                loadData();

            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _ShowHide(true);
            splitContainer1.Panel1Collapsed = true;

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _ShowHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            if (_them)
            {
                DataLayer.NHANVIEN nv = new DataLayer.NHANVIEN();
                nv.MANV = tbMa.Text;
                nv.HOTEN = tbTen.Text;
                nv.CCCD = tbCCCD.Text;
                nv.NOISINH = tbNoisinh.Text;
                nv.SDT = tbSDT.Text;
                nv.GIOITINH = tbGioitinh.Text;
                nv.EMAIL = tbEmail.Text;
                nv.NGAYSINH = dtNgaysinh.Value;
                nv.GHICHU   = tbGhichu.Text;
                nv.MADT = cboDantoc.SelectedValue.ToString();
                nv.MACV = cboChucvu.SelectedValue.ToString();
                nv.MAQT = cboQuoctich.SelectedValue.ToString();
                nv.MATG = cboTongiao.SelectedValue.ToString();
                nv.MAPB = cboPhongban.SelectedValue.ToString();
                nv.MATD = cboTrinhdo.SelectedValue.ToString();
              

                _nhanvien.Add(nv);

            }
            else
            {
                var nv = _nhanvien.getItem(tbMa.Text);
              
                nv.HOTEN = tbTen.Text;
                nv.CCCD =   tbCCCD.Text;
                nv.NOISINH=tbNoisinh.Text;
                nv.SDT = tbSDT.Text;
                nv.NGAYSINH = dtNgaysinh.Value;
                nv.GIOITINH = tbGioitinh.Text;
                nv.EMAIL = tbEmail.Text;
                nv.GHICHU = tbGhichu.Text;
                nv.MADT =cboDantoc.SelectedValue.ToString();
                nv.MACV = cboChucvu.SelectedValue.ToString();
                nv.MAQT = cboQuoctich.SelectedValue.ToString();
                nv.MATG = cboTongiao.SelectedValue.ToString();
                nv.MAPB = cboPhongban.SelectedValue.ToString();
                nv.MATD = cboTrinhdo.SelectedValue.ToString();
                _nhanvien.Update(nv);
            }

        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {   _id= gvDanhSach.GetFocusedRowCellValue("MANV").ToString();
                var nv = _nhanvien.getItem(_id);
                tbTen.Text = gvDanhSach.GetFocusedRowCellValue("HOTEN").ToString();
                tbMa.Text = gvDanhSach.GetFocusedRowCellValue("MANV").ToString();
                dtNgaysinh.Value = nv.NGAYSINH.Value;
                tbCCCD.Text = gvDanhSach.GetFocusedRowCellValue("CCCD").ToString();
                tbNoisinh.Text = gvDanhSach.GetFocusedRowCellValue("NOISINH").ToString();
                tbSDT.Text = gvDanhSach.GetFocusedRowCellValue("SDT").ToString();
                tbGioitinh.Text = gvDanhSach.GetFocusedRowCellValue("GIOITINH").ToString();
                tbEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
                tbGhichu.Text = gvDanhSach.GetFocusedRowCellValue("GHICHU").ToString() ;
                cboDantoc.SelectedValue = nv.MADT;
                cboChucvu.SelectedValue = nv.MACV;
                cboQuoctich.SelectedValue = nv.MAQT;
                cboTongiao.SelectedValue = nv.MATG;
                 cboPhongban.SelectedValue =nv.MAPB;
                cboTrinhdo.SelectedValue = nv.MATD;


            }
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTen_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}