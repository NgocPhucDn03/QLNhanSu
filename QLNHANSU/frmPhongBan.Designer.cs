namespace QLNHANSU
{
    partial class frmPhongBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhongBan));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTen = new DevExpress.XtraEditors.LabelControl();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.txtMa = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENPHONGBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btThem = new DevExpress.XtraBars.BarButtonItem();
            this.btSua = new DevExpress.XtraBars.BarButtonItem();
            this.btXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btTimkiem = new DevExpress.XtraBars.BarButtonItem();
            this.btDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(374, 187);
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtTen);
            this.splitContainer1.Panel1.Controls.Add(this.tbTen);
            this.splitContainer1.Panel1.Controls.Add(this.tbMa);
            this.splitContainer1.Panel1.Controls.Add(this.txtMa);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(782, 504);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.TabIndex = 5;
            // 
            // txtTen
            // 
            this.txtTen.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Appearance.Options.UseFont = true;
            this.txtTen.Location = new System.Drawing.Point(153, 57);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(41, 22);
            this.txtTen.TabIndex = 3;
            this.txtTen.Text = "Tên :";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(225, 57);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(231, 23);
            this.tbTen.TabIndex = 2;
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(225, 28);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(231, 23);
            this.tbMa.TabIndex = 1;
            // 
            // txtMa
            // 
            this.txtMa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtMa.Appearance.Options.UseFont = true;
            this.txtMa.Location = new System.Drawing.Point(153, 28);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(37, 22);
            this.txtMa.TabIndex = 0;
            this.txtMa.Text = "Mã :";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(782, 334);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAPB,
            this.TENPHONGBAN});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // MAPB
            // 
            this.MAPB.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MAPB.AppearanceHeader.Options.UseFont = true;
            this.MAPB.Caption = "MÃ PHÒNG BAN";
            this.MAPB.FieldName = "MAPB";
            this.MAPB.MaxWidth = 200;
            this.MAPB.MinWidth = 200;
            this.MAPB.Name = "MAPB";
            this.MAPB.Visible = true;
            this.MAPB.VisibleIndex = 0;
            this.MAPB.Width = 200;
            // 
            // TENPHONGBAN
            // 
            this.TENPHONGBAN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TENPHONGBAN.AppearanceHeader.Options.UseFont = true;
            this.TENPHONGBAN.Caption = "TÊN PHÒNG BAN";
            this.TENPHONGBAN.FieldName = "TENPHONGBAN";
            this.TENPHONGBAN.MaxWidth = 200;
            this.TENPHONGBAN.MinWidth = 200;
            this.TENPHONGBAN.Name = "TENPHONGBAN";
            this.TENPHONGBAN.Visible = true;
            this.TENPHONGBAN.VisibleIndex = 1;
            this.TENPHONGBAN.Width = 200;
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 4;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Tìm kiếm";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 6;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.LargeImage")));
            this.btnDong.Name = "btnDong";
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(782, 30);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 504);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4,
            this.bar5});
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.DockControls.Add(this.barDockControl5);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barCheckItem1,
            this.btThem,
            this.btSua,
            this.btXoa,
            this.btLuu,
            this.btHuy,
            this.btDong,
            this.btTimkiem});
            this.barManager2.MainMenu = this.bar4;
            this.barManager2.MaxItemId = 8;
            this.barManager2.StatusBar = this.bar5;
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.FloatLocation = new System.Drawing.Point(237, 147);
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btTimkiem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // btThem
            // 
            this.btThem.Caption = "Thêm";
            this.btThem.Id = 1;
            this.btThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.btThem.Name = "btThem";
            this.btThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btThem_ItemClick);
            // 
            // btSua
            // 
            this.btSua.Caption = "Sửa";
            this.btSua.Id = 2;
            this.btSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.btSua.Name = "btSua";
            this.btSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btSua_ItemClick);
            // 
            // btXoa
            // 
            this.btXoa.Caption = "Xóa";
            this.btXoa.Id = 3;
            this.btXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.btXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.btXoa.Name = "btXoa";
            this.btXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // btLuu
            // 
            this.btLuu.Caption = "Lưu";
            this.btLuu.Id = 4;
            this.btLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.btLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.btLuu.Name = "btLuu";
            this.btLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btLuu_ItemClick);
            // 
            // btHuy
            // 
            this.btHuy.Caption = "Hủy";
            this.btHuy.Id = 5;
            this.btHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.btHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.btHuy.Name = "btHuy";
            this.btHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btHuy_ItemClick);
            // 
            // btTimkiem
            // 
            this.btTimkiem.Caption = "Tìm kiếm";
            this.btTimkiem.Id = 7;
            this.btTimkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.btTimkiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.btTimkiem.Name = "btTimkiem";
            // 
            // btDong
            // 
            this.btDong.Caption = "Đóng";
            this.btDong.Id = 6;
            this.btDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.btDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.btDong.Name = "btDong";
            this.btDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btDong_ItemClick);
            // 
            // bar5
            // 
            this.bar5.BarName = "Status bar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Status bar";
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl2.Location = new System.Drawing.Point(0, 0);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(782, 30);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl3.Location = new System.Drawing.Point(0, 534);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(782, 20);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl4.Location = new System.Drawing.Point(0, 30);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 504);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl5.Location = new System.Drawing.Point(782, 30);
            this.barDockControl5.Manager = this.barManager2;
            this.barDockControl5.Size = new System.Drawing.Size(0, 504);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 0;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 554);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl5);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl2);
            this.Name = "frmPhongBan";
            this.Text = "Phòng ban";
            this.Load += new System.EventHandler(this.frmPhongBan_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl txtTen;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbMa;
        private DevExpress.XtraEditors.LabelControl txtMa;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn MAPB;
        private DevExpress.XtraGrid.Columns.GridColumn TENPHONGBAN;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btThem;
        private DevExpress.XtraBars.BarButtonItem btSua;
        private DevExpress.XtraBars.BarButtonItem btXoa;
        private DevExpress.XtraBars.BarButtonItem btLuu;
        private DevExpress.XtraBars.BarButtonItem btHuy;
        private DevExpress.XtraBars.BarButtonItem btTimkiem;
        private DevExpress.XtraBars.BarButtonItem btDong;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
    }
}