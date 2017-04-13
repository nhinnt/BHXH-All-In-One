namespace BHXH.List.UI
{
    partial class frmListNationlity
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
            this.GridControlDMQuocGia = new DevExpress.XtraGrid.GridControl();
            this.GridViewDMQuocGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SimpleButtonThoat = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButtonXoa = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButtonSua = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButtonMoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlDMQuocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDMQuocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // GridControlDMQuocGia
            // 
            this.GridControlDMQuocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlDMQuocGia.Location = new System.Drawing.Point(0, 0);
            this.GridControlDMQuocGia.MainView = this.GridViewDMQuocGia;
            this.GridControlDMQuocGia.Name = "GridControlDMQuocGia";
            this.GridControlDMQuocGia.Size = new System.Drawing.Size(784, 561);
            this.GridControlDMQuocGia.TabIndex = 1;
            this.GridControlDMQuocGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewDMQuocGia,
            this.GridView2});
            // 
            // GridViewDMQuocGia
            // 
            this.GridViewDMQuocGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn1,
            this.GridColumn2,
            this.GridColumn3});
            this.GridViewDMQuocGia.GridControl = this.GridControlDMQuocGia;
            this.GridViewDMQuocGia.Name = "GridViewDMQuocGia";
            this.GridViewDMQuocGia.OptionsBehavior.FocusLeaveOnTab = true;
            this.GridViewDMQuocGia.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.GridViewDMQuocGia.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewDMQuocGia.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.GridViewDMQuocGia.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.GridViewDMQuocGia.OptionsView.ShowAutoFilterRow = true;
            this.GridViewDMQuocGia.OptionsView.ShowGroupPanel = false;
            this.GridViewDMQuocGia.OptionsView.ShowViewCaption = true;
            this.GridViewDMQuocGia.ViewCaption = "Danh mục quốc gia";
            // 
            // GridColumn1
            // 
            this.GridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GridColumn1.AppearanceHeader.Options.UseFont = true;
            this.GridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumn1.Caption = "Mã";
            this.GridColumn1.FieldName = "MaQuocGia";
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
            this.GridColumn2.Caption = "Quốc gia";
            this.GridColumn2.FieldName = "TenQuocGia";
            this.GridColumn2.Name = "GridColumn2";
            this.GridColumn2.OptionsColumn.ReadOnly = true;
            this.GridColumn2.Visible = true;
            this.GridColumn2.VisibleIndex = 1;
            this.GridColumn2.Width = 448;
            // 
            // GridColumn3
            // 
            this.GridColumn3.Caption = "IDQuocGia";
            this.GridColumn3.FieldName = "IDQuocGia";
            this.GridColumn3.Name = "GridColumn3";
            this.GridColumn3.OptionsColumn.ReadOnly = true;
            // 
            // GridView2
            // 
            this.GridView2.GridControl = this.GridControlDMQuocGia;
            this.GridView2.Name = "GridView2";
            this.GridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(784, 561);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView3});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Danh mục quốc gia";
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Mã";
            this.gridColumn4.FieldName = "MaQuocGia";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 150;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Quốc gia";
            this.gridColumn5.FieldName = "TenQuocGia";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 448;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "IDQuocGia";
            this.gridColumn6.FieldName = "IDQuocGia";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView4;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(784, 502);
            this.gridControl2.TabIndex = 3;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4,
            this.gridView5});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridView4.GridControl = this.gridControl2;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridView4.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView4.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.OptionsView.ShowViewCaption = true;
            this.gridView4.ViewCaption = "Danh mục quốc gia";
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "Mã";
            this.gridColumn7.FieldName = "NationalityCode";
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
            this.gridColumn8.Caption = "Quốc gia";
            this.gridColumn8.FieldName = "NationalityName";
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
            // gridView5
            // 
            this.gridView5.GridControl = this.gridControl2;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // SimpleButtonThoat
            // 
            this.SimpleButtonThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SimpleButtonThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SimpleButtonThoat.Appearance.Options.UseFont = true;
            this.SimpleButtonThoat.Location = new System.Drawing.Point(696, 525);
            this.SimpleButtonThoat.Name = "SimpleButtonThoat";
            this.SimpleButtonThoat.Size = new System.Drawing.Size(75, 24);
            this.SimpleButtonThoat.TabIndex = 21;
            this.SimpleButtonThoat.Text = "Thoát";
            this.SimpleButtonThoat.Click += new System.EventHandler(this.SimpleButtonThoat_Click);
            // 
            // SimpleButtonXoa
            // 
            this.SimpleButtonXoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SimpleButtonXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SimpleButtonXoa.Appearance.Options.UseFont = true;
            this.SimpleButtonXoa.Location = new System.Drawing.Point(609, 525);
            this.SimpleButtonXoa.Name = "SimpleButtonXoa";
            this.SimpleButtonXoa.Size = new System.Drawing.Size(75, 24);
            this.SimpleButtonXoa.TabIndex = 19;
            this.SimpleButtonXoa.Text = "Xoá";
            this.SimpleButtonXoa.Click += new System.EventHandler(this.SimpleButtonXoa_Click);
            // 
            // SimpleButtonSua
            // 
            this.SimpleButtonSua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SimpleButtonSua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SimpleButtonSua.Appearance.Options.UseFont = true;
            this.SimpleButtonSua.Location = new System.Drawing.Point(523, 525);
            this.SimpleButtonSua.Name = "SimpleButtonSua";
            this.SimpleButtonSua.Size = new System.Drawing.Size(75, 24);
            this.SimpleButtonSua.TabIndex = 18;
            this.SimpleButtonSua.Text = "Sửa";
            this.SimpleButtonSua.Click += new System.EventHandler(this.SimpleButtonSua_Click);
            // 
            // SimpleButtonMoi
            // 
            this.SimpleButtonMoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SimpleButtonMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SimpleButtonMoi.Appearance.Options.UseFont = true;
            this.SimpleButtonMoi.Location = new System.Drawing.Point(442, 525);
            this.SimpleButtonMoi.Name = "SimpleButtonMoi";
            this.SimpleButtonMoi.Size = new System.Drawing.Size(75, 24);
            this.SimpleButtonMoi.TabIndex = 17;
            this.SimpleButtonMoi.Text = "Mới";
            this.SimpleButtonMoi.Click += new System.EventHandler(this.SimpleButtonMoi_Click);
            // 
            // frmListNationlity
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.SimpleButtonThoat);
            this.Controls.Add(this.SimpleButtonXoa);
            this.Controls.Add(this.SimpleButtonSua);
            this.Controls.Add(this.SimpleButtonMoi);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.GridControlDMQuocGia);
            this.Name = "frmListNationlity";
            ((System.ComponentModel.ISupportInitialize)(this.GridControlDMQuocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDMQuocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraGrid.GridControl GridControlDMQuocGia;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridViewDMQuocGia;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView2;
        internal DevExpress.XtraGrid.GridControl gridControl1;
        internal DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        internal DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        internal DevExpress.XtraGrid.GridControl gridControl2;
        internal DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        internal DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        internal DevExpress.XtraEditors.SimpleButton SimpleButtonThoat;
        internal DevExpress.XtraEditors.SimpleButton SimpleButtonXoa;
        internal DevExpress.XtraEditors.SimpleButton SimpleButtonSua;
        internal DevExpress.XtraEditors.SimpleButton SimpleButtonMoi;
    }
}