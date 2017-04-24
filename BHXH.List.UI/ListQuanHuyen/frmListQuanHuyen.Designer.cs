namespace BHXH.List.UI
{
    partial class frmListQuanHuyen
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
        ///
        private void InitializeComponent()
        {
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlTinh = new DevExpress.XtraGrid.GridControl();
            this.gridViewTinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewQuanHuyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlQuanHuyen = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuanHuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuanHuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(698, 525);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 24);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(611, 525);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 24);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "&Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Location = new System.Drawing.Point(525, 525);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 24);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "&Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Location = new System.Drawing.Point(433, 525);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 24);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "&Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gridControlTinh
            // 
            this.gridControlTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlTinh.Location = new System.Drawing.Point(0, -1);
            this.gridControlTinh.MainView = this.gridViewTinh;
            this.gridControlTinh.Name = "gridControlTinh";
            this.gridControlTinh.Size = new System.Drawing.Size(261, 568);
            this.gridControlTinh.TabIndex = 27;
            this.gridControlTinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTinh});
            // 
            // gridViewTinh
            // 
            this.gridViewTinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridViewTinh.GridControl = this.gridControlTinh;
            this.gridViewTinh.Name = "gridViewTinh";
            this.gridViewTinh.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridViewTinh.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewTinh.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewTinh.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewTinh.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewTinh.OptionsView.ShowAutoFilterRow = true;
            this.gridViewTinh.OptionsView.ShowGroupPanel = false;
            this.gridViewTinh.OptionsView.ShowViewCaption = true;
            this.gridViewTinh.ViewCaption = "Danh mục Tỉnh";
            this.gridViewTinh.MouseEnter += new System.EventHandler(this.gridViewTinh_MouseEnter);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Mã";
            this.gridColumn1.FieldName = "MaTinh";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 150;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Tên Tỉnh";
            this.gridColumn2.FieldName = "TenTinh";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 448;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "IDQuocGia";
            this.gridColumn3.FieldName = "IDQuocGia";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Mã";
            this.gridColumn4.FieldName = "MaXQuanHuyen";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 150;
            // 
            // gridViewQuanHuyen
            // 
            this.gridViewQuanHuyen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gridViewQuanHuyen.GridControl = this.gridControlQuanHuyen;
            this.gridViewQuanHuyen.Name = "gridViewQuanHuyen";
            this.gridViewQuanHuyen.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridViewQuanHuyen.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewQuanHuyen.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewQuanHuyen.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewQuanHuyen.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewQuanHuyen.OptionsView.ShowAutoFilterRow = true;
            this.gridViewQuanHuyen.OptionsView.ShowGroupPanel = false;
            this.gridViewQuanHuyen.OptionsView.ShowViewCaption = true;
            this.gridViewQuanHuyen.ViewCaption = "Danh mục Quận Huyện";
            this.gridViewQuanHuyen.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewQuanHuyen_RowCellClick);
            this.gridViewQuanHuyen.MouseEnter += new System.EventHandler(this.gridViewQuanHuyen_MouseEnter);
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Tên Quận Huyện";
            this.gridColumn5.FieldName = "TenQuanHuyen";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 166;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "IDQuocGia";
            this.gridColumn6.FieldName = "IDQuocGia";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "QHID";
            this.gridColumn10.FieldName = "QuanHuyenID";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn10.Width = 20;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn11.AppearanceHeader.Options.UseFont = true;
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.Caption = "Mã";
            this.gridColumn11.FieldName = "MaQuanHuyen";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            this.gridColumn11.Width = 48;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "QHID";
            this.gridColumn12.FieldName = "QuanHuyenID";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // gridControlQuanHuyen
            // 
            this.gridControlQuanHuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlQuanHuyen.Location = new System.Drawing.Point(267, -1);
            this.gridControlQuanHuyen.MainView = this.gridViewQuanHuyen;
            this.gridControlQuanHuyen.Name = "gridControlQuanHuyen";
            this.gridControlQuanHuyen.Size = new System.Drawing.Size(518, 520);
            this.gridControlQuanHuyen.TabIndex = 28;
            this.gridControlQuanHuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewQuanHuyen});
            this.gridControlQuanHuyen.Click += new System.EventHandler(this.gridControlQuanHuyen_Click);
            // 
            // frmListQuanHuyen
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gridControlQuanHuyen);
            this.Controls.Add(this.gridControlTinh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "frmListQuanHuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục Quận Huyện";
            this.Load += new System.EventHandler(this.frmListQuanHuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuanHuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuanHuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal DevExpress.XtraEditors.SimpleButton btnThoat;
        internal DevExpress.XtraEditors.SimpleButton btnXoa;
        internal DevExpress.XtraEditors.SimpleButton btnSua;
        internal DevExpress.XtraEditors.SimpleButton btnThem;
        internal DevExpress.XtraGrid.GridControl gridControlTinh;
        internal DevExpress.XtraGrid.Views.Grid.GridView gridViewTinh;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        internal DevExpress.XtraGrid.Views.Grid.GridView gridViewQuanHuyen;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        internal DevExpress.XtraGrid.GridControl gridControlQuanHuyen;
    }
}