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
using static DevExpress.Data.Helpers.FindSearchRichParser;
using System.Data.Entity;

namespace QLNHANSU
{
    
    public partial class frmNghiPhep : DevExpress.XtraEditors.XtraForm
    {
        public frmNghiPhep()
        {
            InitializeComponent();
            _Nghiphep = new BusinessLayer.NGHIPHEP();
        }
        BusinessLayer.NGHIPHEP _Nghiphep;
        BusinessLayer.NHANVIEN _Nhanvien;
        bool _them;
        string _id;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmNghiPhep_Load(object sender, EventArgs e)
        {
            _ShowHide(true);
            loadData();
            
            splitContainer1.Panel1Collapsed = true;
            loadCombo();
        }
        void _ShowHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnDong.Enabled = kt;
            btnXoa.Enabled = kt;
            tbMa.Enabled = !kt;
            tbLoaiNghiPhep.Enabled = !kt;
            tbSoNgay.Enabled = !kt;
            tbTrangThai.Enabled = !kt;
            dtKetThuc.Enabled = !kt;
            dtBatDau.Enabled = !kt;
            cboNhanVien.Enabled=!kt;
        }
        void _reset()
        {
            tbMa.Text = string.Empty;
            tbLoaiNghiPhep.Text = string.Empty;
            tbSoNgay.Text = string.Empty;
            tbTrangThai.Text= string.Empty;
          
        }
        void loadData()
        {
            gcDanhSach.DataSource = _Nghiphep.getList();
            gvDanhSach.OptionsBehavior.Editable = false;

        }
        void loadCombo()
        { 
            cboNhanVien.DataSource = _Nghiphep.getList();
            cboNhanVien.DisplayMember = "MANV";
            cboNhanVien.ValueMember = "MANV";
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
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
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

        private void btTimKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void SaveData()
        {
            if(_them)
            {
                DataLayer.NGHIPHEP np = new DataLayer.NGHIPHEP();
                np.MANP = tbMa.Text;
                np.LOAINGHIPHEP = tbLoaiNghiPhep.Text;
                np.TRANGTHAI = tbTrangThai.Text;
                np.SONGAY = int.Parse(tbSoNgay.Text.ToString());
                np.MANV = cboNhanVien.SelectedValue.ToString();
                np.NGAYBATDAU = dtBatDau.Value;
                np.NGAYKETTHUC = dtKetThuc.Value;
                _Nghiphep.Add(np);
            }else
            {
                var np = _Nghiphep.getItem(_id);
                np.MANP = tbMa.Text;
                np.LOAINGHIPHEP = tbLoaiNghiPhep.Text;
                np.TRANGTHAI = tbTrangThai.Text;
                np.SONGAY = int.Parse(tbSoNgay.Text.ToString());
                np.MANV = cboNhanVien.SelectedValue.ToString();
                np.NGAYBATDAU = dtBatDau.Value;
                np.NGAYKETTHUC = dtKetThuc.Value;
                _Nghiphep.Update(np);
            }
            
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = gvDanhSach.GetFocusedRowCellValue("MANP").ToString();
                var np = _Nghiphep.getItem(_id);
                tbMa.Text = gvDanhSach.GetFocusedRowCellValue("MANP").ToString();
                tbLoaiNghiPhep.Text = gvDanhSach.GetFocusedRowCellValue("LOAINGHIPHEP").ToString();
                tbSoNgay.Text = gvDanhSach.GetFocusedRowCellValue("SONGAY").ToString();
                tbTrangThai.Text = gvDanhSach.GetFocusedRowCellValue("TRANGTHAI").ToString();
                dtBatDau.Value = np.NGAYBATDAU.Value;
                dtKetThuc.Value = np.NGAYKETTHUC.Value;
                cboNhanVien.SelectedValue = np.MANV;

            }
        }
        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMa_Click(object sender, EventArgs e)
        {

        }

        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}