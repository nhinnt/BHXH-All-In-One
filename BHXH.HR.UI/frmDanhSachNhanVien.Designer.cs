namespace BHXH.HR.UI
{
    partial class frmDanhSachNhanVien
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
            this.GridViewDSNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridControlDSNhanVien = new DevExpress.XtraGrid.GridControl();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lookUpEditDMPhongBan = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditBoPhan = new DevExpress.XtraEditors.LookUpEdit();
            this.labelBoPhan = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditPhongBan = new DevExpress.XtraEditors.LookUpEdit();
            this.lblPhongBan = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SimpleButtonThoat = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButtonXoa = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButtonGhiSua = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButtonSua = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButtonMoi = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButtonQua = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButtonGhi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlDSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).BeginInit();
            this.SplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDMPhongBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditBoPhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPhongBan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewDSNhanVien
            // 
            this.GridViewDSNhanVien.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GridViewDSNhanVien.Appearance.FooterPanel.Options.UseFont = true;
            this.GridViewDSNhanVien.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.GridViewDSNhanVien.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridViewDSNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn1,
            this.GridColumn2});
            this.GridViewDSNhanVien.GridControl = this.GridControlDSNhanVien;
            this.GridViewDSNhanVien.Name = "GridViewDSNhanVien";
            this.GridViewDSNhanVien.OptionsBehavior.FocusLeaveOnTab = true;
            this.GridViewDSNhanVien.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.GridViewDSNhanVien.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewDSNhanVien.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.GridViewDSNhanVien.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.GridViewDSNhanVien.OptionsView.ShowAutoFilterRow = true;
            this.GridViewDSNhanVien.OptionsView.ShowFooter = true;
            this.GridViewDSNhanVien.OptionsView.ShowGroupPanel = false;
            this.GridViewDSNhanVien.OptionsView.ShowViewCaption = true;
            this.GridViewDSNhanVien.ViewCaption = "Danh sách cán bộ, công chức, viên chức";
            this.GridViewDSNhanVien.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GridViewDSNhanVien_MouseDown);
            this.GridViewDSNhanVien.MouseEnter += new System.EventHandler(this.GridViewDSNhanVien_MouseEnter);
            // 
            // GridColumn1
            // 
            this.GridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GridColumn1.AppearanceHeader.Options.UseFont = true;
            this.GridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumn1.Caption = "Mã";
            this.GridColumn1.FieldName = "MaNhanVien";
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.OptionsColumn.ReadOnly = true;
            this.GridColumn1.Visible = true;
            this.GridColumn1.VisibleIndex = 0;
            this.GridColumn1.Width = 150;
            // 
            // GridColumn2
            // 
            this.GridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GridColumn2.AppearanceHeader.Options.UseFont = true;
            this.GridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumn2.Caption = "Họ và tên";
            this.GridColumn2.FieldName = "TenNhanVien";
            this.GridColumn2.Name = "GridColumn2";
            this.GridColumn2.OptionsColumn.ReadOnly = true;
            this.GridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TenNhanVien", "Tổng số : {0:#,##0} ")});
            this.GridColumn2.Visible = true;
            this.GridColumn2.VisibleIndex = 1;
            this.GridColumn2.Width = 374;
            // 
            // GridControlDSNhanVien
            // 
            this.GridControlDSNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlDSNhanVien.Location = new System.Drawing.Point(0, 51);
            this.GridControlDSNhanVien.MainView = this.GridViewDSNhanVien;
            this.GridControlDSNhanVien.Name = "GridControlDSNhanVien";
            this.GridControlDSNhanVien.Size = new System.Drawing.Size(917, 298);
            this.GridControlDSNhanVien.TabIndex = 0;
            this.GridControlDSNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewDSNhanVien,
            this.GridView2});
            this.GridControlDSNhanVien.Click += new System.EventHandler(this.GridControlDSNhanVien_Click);
            this.GridControlDSNhanVien.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GridControlDSNhanVien_MouseDown);
            // 
            // GridView2
            // 
            this.GridView2.GridControl = this.GridControlDSNhanVien;
            this.GridView2.Name = "GridView2";
            this.GridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Location = new System.Drawing.Point(11, 18);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(51, 13);
            this.LabelControl3.TabIndex = 13;
            this.LabelControl3.Text = "Phòng ban";
            // 
            // SplitContainerControl1
            // 
            this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.SplitContainerControl1.Horizontal = false;
            this.SplitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerControl1.Name = "SplitContainerControl1";
            this.SplitContainerControl1.Panel1.Controls.Add(this.lookUpEditDMPhongBan);
            this.SplitContainerControl1.Panel1.Controls.Add(this.LabelControl3);
            this.SplitContainerControl1.Panel1.Controls.Add(this.GridControlDSNhanVien);
            this.SplitContainerControl1.Panel1.Text = "Panel1";
            this.SplitContainerControl1.Panel2.Controls.Add(this.lookUpEditBoPhan);
            this.SplitContainerControl1.Panel2.Controls.Add(this.labelBoPhan);
            this.SplitContainerControl1.Panel2.Controls.Add(this.lookUpEditPhongBan);
            this.SplitContainerControl1.Panel2.Controls.Add(this.lblPhongBan);
            this.SplitContainerControl1.Panel2.Controls.Add(this.txtTenNhanVien);
            this.SplitContainerControl1.Panel2.Controls.Add(this.txtMaNhanVien);
            this.SplitContainerControl1.Panel2.Controls.Add(this.LabelControl2);
            this.SplitContainerControl1.Panel2.Controls.Add(this.LabelControl1);
            this.SplitContainerControl1.Panel2.Controls.Add(this.SimpleButtonThoat);
            this.SplitContainerControl1.Panel2.Controls.Add(this.SimpleButtonXoa);
            this.SplitContainerControl1.Panel2.Controls.Add(this.SimpleButtonGhiSua);
            this.SplitContainerControl1.Panel2.Controls.Add(this.SimpleButtonSua);
            this.SplitContainerControl1.Panel2.Controls.Add(this.SimpleButtonMoi);
            this.SplitContainerControl1.Panel2.Controls.Add(this.SimpleButtonQua);
            this.SplitContainerControl1.Panel2.Controls.Add(this.SimpleButtonGhi);
            this.SplitContainerControl1.Panel2.Text = "Panel2";
            this.SplitContainerControl1.Size = new System.Drawing.Size(917, 494);
            this.SplitContainerControl1.SplitterPosition = 128;
            this.SplitContainerControl1.TabIndex = 1;
            this.SplitContainerControl1.Text = "SplitContainerControl1";
            // 
            // lookUpEditDMPhongBan
            // 
            this.lookUpEditDMPhongBan.AllowDrop = true;
            this.lookUpEditDMPhongBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditDMPhongBan.EditValue = "";
            this.lookUpEditDMPhongBan.Location = new System.Drawing.Point(70, 16);
            this.lookUpEditDMPhongBan.Name = "lookUpEditDMPhongBan";
            this.lookUpEditDMPhongBan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDMPhongBan.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenPhongBan", 40, "Tên phòng ban")});
            this.lookUpEditDMPhongBan.Properties.DropDownRows = 20;
            this.lookUpEditDMPhongBan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditDMPhongBan.Size = new System.Drawing.Size(846, 20);
            this.lookUpEditDMPhongBan.TabIndex = 145;
            this.lookUpEditDMPhongBan.EditValueChanged += new System.EventHandler(this.lookUpEditDMPhongBan_EditValueChanged);
            // 
            // lookUpEditBoPhan
            // 
            this.lookUpEditBoPhan.AllowDrop = true;
            this.lookUpEditBoPhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditBoPhan.EditValue = "";
            this.lookUpEditBoPhan.Location = new System.Drawing.Point(504, 66);
            this.lookUpEditBoPhan.Name = "lookUpEditBoPhan";
            this.lookUpEditBoPhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditBoPhan.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenBoPhan", 40, "Tên bộ phận")});
            this.lookUpEditBoPhan.Properties.DropDownRows = 20;
            this.lookUpEditBoPhan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditBoPhan.Size = new System.Drawing.Size(405, 20);
            this.lookUpEditBoPhan.TabIndex = 146;
            this.lookUpEditBoPhan.Visible = false;
            this.lookUpEditBoPhan.EditValueChanged += new System.EventHandler(this.lookUpEditBoPhan_EditValueChanged);
            // 
            // labelBoPhan
            // 
            this.labelBoPhan.Location = new System.Drawing.Point(459, 69);
            this.labelBoPhan.Name = "labelBoPhan";
            this.labelBoPhan.Size = new System.Drawing.Size(39, 13);
            this.labelBoPhan.TabIndex = 13;
            this.labelBoPhan.Text = "Bộ phận";
            this.labelBoPhan.Visible = false;
            // 
            // lookUpEditPhongBan
            // 
            this.lookUpEditPhongBan.AllowDrop = true;
            this.lookUpEditPhongBan.EditValue = "";
            this.lookUpEditPhongBan.Location = new System.Drawing.Point(91, 66);
            this.lookUpEditPhongBan.Name = "lookUpEditPhongBan";
            this.lookUpEditPhongBan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditPhongBan.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenPhongBan", 40, "Tên phòng ban")});
            this.lookUpEditPhongBan.Properties.DropDownRows = 20;
            this.lookUpEditPhongBan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditPhongBan.Size = new System.Drawing.Size(352, 20);
            this.lookUpEditPhongBan.TabIndex = 146;
            this.lookUpEditPhongBan.Visible = false;
            this.lookUpEditPhongBan.EditValueChanged += new System.EventHandler(this.lookUpEditPhongBan_EditValueChanged);
            this.lookUpEditPhongBan.Leave += new System.EventHandler(this.lookUpEditPhongBan_Leave);
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.Location = new System.Drawing.Point(7, 69);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(51, 13);
            this.lblPhongBan.TabIndex = 13;
            this.lblPhongBan.Text = "Phòng ban";
            this.lblPhongBan.Visible = false;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNhanVien.Enabled = false;
            this.txtTenNhanVien.Location = new System.Drawing.Point(91, 39);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(818, 21);
            this.txtTenNhanVien.TabIndex = 27;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(91, 8);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(818, 21);
            this.txtMaNhanVien.TabIndex = 26;
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(7, 39);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(47, 13);
            this.LabelControl2.TabIndex = 23;
            this.LabelControl2.Text = "Họ và tên";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(7, 12);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(14, 13);
            this.LabelControl1.TabIndex = 22;
            this.LabelControl1.Text = "Mã";
            // 
            // SimpleButtonThoat
            // 
            this.SimpleButtonThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SimpleButtonThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SimpleButtonThoat.Appearance.Options.UseFont = true;
            this.SimpleButtonThoat.Location = new System.Drawing.Point(834, 92);
            this.SimpleButtonThoat.Name = "SimpleButtonThoat";
            this.SimpleButtonThoat.Size = new System.Drawing.Size(75, 24);
            this.SimpleButtonThoat.TabIndex = 21;
            this.SimpleButtonThoat.Text = "Thoát";
            // 
            // SimpleButtonXoa
            // 
            this.SimpleButtonXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SimpleButtonXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SimpleButtonXoa.Appearance.Options.UseFont = true;
            this.SimpleButtonXoa.Location = new System.Drawing.Point(753, 92);
            this.SimpleButtonXoa.Name = "SimpleButtonXoa";
            this.SimpleButtonXoa.Size = new System.Drawing.Size(75, 24);
            this.SimpleButtonXoa.TabIndex = 19;
            this.SimpleButtonXoa.Text = "Xoá";
            this.SimpleButtonXoa.Click += new System.EventHandler(this.SimpleButtonXoa_Click);
            // 
            // SimpleButtonGhiSua
            // 
            this.SimpleButtonGhiSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SimpleButtonGhiSua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SimpleButtonGhiSua.Appearance.Options.UseFont = true;
            this.SimpleButtonGhiSua.Enabled = false;
            this.SimpleButtonGhiSua.Location = new System.Drawing.Point(665, 94);
            this.SimpleButtonGhiSua.Name = "SimpleButtonGhiSua";
            this.SimpleButtonGhiSua.Size = new System.Drawing.Size(75, 24);
            this.SimpleButtonGhiSua.TabIndex = 18;
            this.SimpleButtonGhiSua.Text = "Ghi";
            this.SimpleButtonGhiSua.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // SimpleButtonSua
            // 
            this.SimpleButtonSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SimpleButtonSua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SimpleButtonSua.Appearance.Options.UseFont = true;
            this.SimpleButtonSua.Location = new System.Drawing.Point(584, 94);
            this.SimpleButtonSua.Name = "SimpleButtonSua";
            this.SimpleButtonSua.Size = new System.Drawing.Size(75, 24);
            this.SimpleButtonSua.TabIndex = 18;
            this.SimpleButtonSua.Text = "Sửa";
            this.SimpleButtonSua.Click += new System.EventHandler(this.SimpleButtonSua_Click);
            // 
            // SimpleButtonMoi
            // 
            this.SimpleButtonMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SimpleButtonMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SimpleButtonMoi.Appearance.Options.UseFont = true;
            this.SimpleButtonMoi.Location = new System.Drawing.Point(6, 94);
            this.SimpleButtonMoi.Name = "SimpleButtonMoi";
            this.SimpleButtonMoi.Size = new System.Drawing.Size(75, 24);
            this.SimpleButtonMoi.TabIndex = 17;
            this.SimpleButtonMoi.Text = "Mới";
            this.SimpleButtonMoi.Click += new System.EventHandler(this.SimpleButtonMoi_Click_1);
            // 
            // SimpleButtonQua
            // 
            this.SimpleButtonQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SimpleButtonQua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SimpleButtonQua.Appearance.Options.UseFont = true;
            this.SimpleButtonQua.Location = new System.Drawing.Point(168, 94);
            this.SimpleButtonQua.Name = "SimpleButtonQua";
            this.SimpleButtonQua.Size = new System.Drawing.Size(75, 24);
            this.SimpleButtonQua.TabIndex = 16;
            this.SimpleButtonQua.Text = "Qua";
            this.SimpleButtonQua.Click += new System.EventHandler(this.SimpleButtonQua_Click);
            // 
            // SimpleButtonGhi
            // 
            this.SimpleButtonGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SimpleButtonGhi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SimpleButtonGhi.Appearance.Options.UseFont = true;
            this.SimpleButtonGhi.Enabled = false;
            this.SimpleButtonGhi.Location = new System.Drawing.Point(87, 94);
            this.SimpleButtonGhi.Name = "SimpleButtonGhi";
            this.SimpleButtonGhi.Size = new System.Drawing.Size(75, 24);
            this.SimpleButtonGhi.TabIndex = 15;
            this.SimpleButtonGhi.Text = "Ghi";
            this.SimpleButtonGhi.Click += new System.EventHandler(this.SimpleButtonGhi_Click);
            // 
            // frmDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 494);
            this.Controls.Add(this.SplitContainerControl1);
            this.Name = "frmDanhSachNhanVien";
            this.Text = "Danh sách cán bộ, CC, VC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhSachNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlDSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).EndInit();
            this.SplitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDMPhongBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditBoPhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPhongBan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridViewDSNhanVien;
        internal DevExpress.XtraGrid.GridControl GridControlDSNhanVien;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView2;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDMPhongBan;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.SimpleButton SimpleButtonThoat;
        internal DevExpress.XtraEditors.SimpleButton SimpleButtonXoa;
        internal DevExpress.XtraEditors.SimpleButton SimpleButtonSua;
        internal DevExpress.XtraEditors.SimpleButton SimpleButtonMoi;
        internal DevExpress.XtraEditors.SimpleButton SimpleButtonGhi;
        internal DevExpress.XtraEditors.SimpleButton SimpleButtonQua;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPhongBan;
        internal DevExpress.XtraEditors.LabelControl lblPhongBan;
        internal DevExpress.XtraEditors.SimpleButton SimpleButtonGhiSua;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditBoPhan;
        internal DevExpress.XtraEditors.LabelControl labelBoPhan;
    }
}