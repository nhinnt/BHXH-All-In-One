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
            this.gridcontroListMain = new DevExpress.XtraGrid.GridControl();
            this.gridviewListMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlTinh = new DevExpress.XtraGrid.GridControl();
            this.gridViewTinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontroListMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewListMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // gridcontroListMain
            // 
            this.gridcontroListMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridcontroListMain.Location = new System.Drawing.Point(268, -1);
            this.gridcontroListMain.MainView = this.gridviewListMain;
            this.gridcontroListMain.Name = "gridcontroListMain";
            this.gridcontroListMain.Size = new System.Drawing.Size(517, 502);
            this.gridcontroListMain.TabIndex = 3;
            this.gridcontroListMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviewListMain});
            this.gridcontroListMain.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // gridviewListMain
            // 
            this.gridviewListMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn4});
            this.gridviewListMain.GridControl = this.gridcontroListMain;
            this.gridviewListMain.Name = "gridviewListMain";
            this.gridviewListMain.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridviewListMain.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridviewListMain.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridviewListMain.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridviewListMain.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridviewListMain.OptionsView.ShowAutoFilterRow = true;
            this.gridviewListMain.OptionsView.ShowGroupPanel = false;
            this.gridviewListMain.OptionsView.ShowViewCaption = true;
            this.gridviewListMain.ViewCaption = "Danh mục Quận Huyện";
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "Mã";
            this.gridColumn7.FieldName = "MaQuanHuyen";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 150;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "Tên Quận Huyện";
            this.gridColumn8.FieldName = "TenQuanHuyen";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 448;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "IDQuocGia";
            this.gridColumn9.FieldName = "IDQuocGia";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "MaTinh";
            this.gridColumn4.FieldName = "MaTinh";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
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
            this.gridControlTinh.Location = new System.Drawing.Point(1, -1);
            this.gridControlTinh.MainView = this.gridViewTinh;
            this.gridControlTinh.Name = "gridControlTinh";
            this.gridControlTinh.Size = new System.Drawing.Size(261, 502);
            this.gridControlTinh.TabIndex = 27;
            this.gridControlTinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTinh});
            this.gridControlTinh.Click += new System.EventHandler(this.gridViewTinh_Click);
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
            this.gridViewTinh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridViewTinh_MouseDown);
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
            // frmListQuanHuyen
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gridControlTinh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gridcontroListMain);
            this.Name = "frmListQuanHuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục Quận Huyện";
            this.Load += new System.EventHandler(this.frmListQuanHuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontroListMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewListMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal DevExpress.XtraGrid.GridControl gridcontroListMain;
        internal DevExpress.XtraGrid.Views.Grid.GridView gridviewListMain;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        internal DevExpress.XtraEditors.SimpleButton btnThoat;
        internal DevExpress.XtraEditors.SimpleButton btnXoa;
        internal DevExpress.XtraEditors.SimpleButton btnSua;
        internal DevExpress.XtraEditors.SimpleButton btnThem;
        internal DevExpress.XtraGrid.GridControl gridControlTinh;
        internal DevExpress.XtraGrid.Views.Grid.GridView gridViewTinh;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}