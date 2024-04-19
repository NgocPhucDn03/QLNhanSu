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
    public partial class frmBaoHiemXaHoi : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoHiemXaHoi()
        {
            InitializeComponent();
            _BHXH = new BusinessLayer.BAOHIEMXAHOI();
            _Nhanvien = new BusinessLayer.NHANVIEN();
        }
        BusinessLayer.NHANVIEN _Nhanvien;
        BusinessLayer.BAOHIEMXAHOI _BHXH;
        bool _them;
        int _id;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmBaoHiemXaHoi_Load(object sender, EventArgs e)
        {
            _ShowHide(true);
            loadData();
            loadNV();
            // LoadLoai();
            splitContainer1.Panel1Collapsed = true;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _BHXH.getList();
            gvDanhSach.OptionsBehavior.Editable = false;

        }
        void loadNV()
        {
            slkNhanVien.Properties.DataSource = _Nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
        }
        void _ShowHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnDong.Enabled = kt;
            btnXoa.Enabled = kt;
            tbDong.Enabled = !kt;
            tbMa.Enabled = !kt;
            tbLamviec.Enabled = !kt;
            tbNoi.Enabled = !kt;
            dtNgay.Enabled = !kt;
            slkNhanVien.Enabled = !kt;
            // cboLoai.Enabled = !kt;

        }
        void _reset()
        {
            tbMa.Text = string.Empty;
            tbDong.Text = string.Empty;
            tbNoi.Text = string.Empty;
            tbLamviec.Text = string.Empty;
          


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
                _BHXH.Delete(_id,1);

                loadData();

            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = true;
            _ShowHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _ShowHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btTimKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                DataLayer.BAOHIEMXAHOI bhxh = new DataLayer.BAOHIEMXAHOI();
                bhxh.MABAOHIEM = tbMa.Text;
                bhxh.NOICAP = tbNoi.Text;
                bhxh.THOIGIANDONGBH = tbDong.Text;
                bhxh.THOIGIANLAMVIEC = tbLamviec.Text;
                bhxh.NGAYCAP = dtNgay.Value;
                bhxh.LBH_ID = 2;
                bhxh.MANV = slkNhanVien.EditValue.ToString();
                _BHXH.Add(bhxh);

            }
            else
            {
                var bhxh = _BHXH.getItem(_id);
                bhxh.MABAOHIEM = tbMa.Text;
                bhxh.NOICAP = tbNoi.Text;
                bhxh.THOIGIANDONGBH = tbDong.Text;
                bhxh.THOIGIANLAMVIEC = tbLamviec.Text;
                bhxh.NGAYCAP = dtNgay.Value;
                bhxh.LBH_ID = 2;
                bhxh.MANV = slkNhanVien.EditValue.ToString();
                _BHXH.Update(bhxh);
            }
        }
            private void gvDanhSach_Click(object sender, EventArgs e)
        {
                if (gvDanhSach.RowCount > 0)
                {
                    _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                    var bhxh = _BHXH.getItem(_id);
                    tbMa.Text = gvDanhSach.GetFocusedRowCellValue("MABAOHIEM").ToString();
                    tbNoi.Text = gvDanhSach.GetFocusedRowCellValue("NOICAP").ToString();
                    tbLamviec.Text = gvDanhSach.GetFocusedRowCellValue("THOIGIANLAMVIEC").ToString();
                    tbDong.Text = gvDanhSach.GetFocusedRowCellValue("THOIGIANDONGBH").ToString();
                     dtNgay.Value = bhxh.NGAYCAP.Value;
                    //cboLoai.SelectedValue = bhxh.LBH_ID;
                    slkNhanVien.EditValue = bhxh.MANV;
                }
            }
    }
}