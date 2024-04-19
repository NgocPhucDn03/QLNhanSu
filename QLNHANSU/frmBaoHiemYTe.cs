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
    public partial class frmBaoHiemYTe : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoHiemYTe()
        {
            InitializeComponent();
            _BHYTE = new BusinessLayer.BAOHIEMYTE();
            _Nhanvien = new BusinessLayer.NHANVIEN();
        }
        BusinessLayer.BAOHIEMYTE _BHYTE;
        BusinessLayer.NHANVIEN _Nhanvien;
        bool _them;
        int _id;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //_PHONGBAN.Delete(_id);
                // loadData();
            }
        }
        private void frmBaoHiemYTe_Load(object sender, EventArgs e)
        {
            _ShowHide(true);
            loadData();
           loadNV();
           // LoadLoai();
            splitContainer1.Panel1Collapsed = true;

        }
        void loadData()
        {
            gcDanhSach.DataSource = _BHYTE.getList();
            gvDanhSach.OptionsBehavior.Editable = false;

        }
        void loadNV()
        {
            slkNhanVien.Properties.DataSource= _Nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
        }
        /*void LoadLoai()
        {
            cboLoai.DataSource = _Loaibaohiem.getList();
            cboLoai.ValueMember = "LBH_ID";
            cboLoai.DisplayMember = "TENBAOHIEM";
        }*/
        void _ShowHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnDong.Enabled = kt;
            btnXoa.Enabled = kt;
            tbMABH.Enabled = !kt;
            tbGiatri.Enabled = !kt;
            tbMavung.Enabled = !kt;
            tbNoicap.Enabled = !kt;
            tbNoikham.Enabled = !kt;
            slkNhanVien.Enabled = !kt;
           // cboLoai.Enabled = !kt;

        }
        void _reset()
        {
            tbMABH.Text = string.Empty;
            tbMavung.Text = string.Empty;
            tbNoikham.Text = string.Empty;
            tbNoicap.Text = string.Empty;
            tbGiatri.Text = string.Empty;


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
                _BHYTE.Delete(_id, 1);

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
                DataLayer.BAOHIEMYTE bhyt = new DataLayer.BAOHIEMYTE();
                bhyt.MABAOHIEM = tbMABH.Text;
                bhyt.NOICAP = tbNoicap.Text;
                bhyt.NOIKHAM = tbNoikham.Text;
                bhyt.GIATRISUDUNG = tbGiatri.Text;
                bhyt.MANV = slkNhanVien.EditValue.ToString();
                bhyt.MAVUNG = tbMavung.Text;
                bhyt.LBH_ID = 1;
                _BHYTE.Add(bhyt);

            }
            else
            {
                var bhyt = _BHYTE.getItem(_id);
                bhyt.MABAOHIEM = tbMABH.Text;
                bhyt.NOICAP = tbNoicap.Text;
                bhyt.NOIKHAM = tbNoikham.Text;
                bhyt.GIATRISUDUNG = tbGiatri.Text;
                bhyt.MAVUNG = tbMavung.Text;
                bhyt.LBH_ID = 1;
                bhyt.MANV = slkNhanVien.EditValue.ToString();
                _BHYTE.Update(bhyt);
            }

        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                var bhyt = _BHYTE.getItem(_id);
                tbMABH.Text = gvDanhSach.GetFocusedRowCellValue("MABAOHIEM").ToString();
                tbNoicap.Text = gvDanhSach.GetFocusedRowCellValue("NOICAP").ToString();
                tbNoikham.Text = gvDanhSach.GetFocusedRowCellValue("NOIKHAM").ToString();
                tbGiatri.Text = gvDanhSach.GetFocusedRowCellValue("GIATRISUDUNG").ToString();
                tbMavung.Text = gvDanhSach.GetFocusedRowCellValue("MAVUNG").ToString();
                //cboLoai.SelectedValue = bhyt.LBH_ID;
                slkNhanVien.EditValue = bhyt.MANV;
            }
        }
    }
}