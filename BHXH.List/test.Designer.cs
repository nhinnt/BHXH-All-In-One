namespace BHXH.List.UI
{
    partial class test
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
            this.GridControlDMQuocGia = new DevExpress.XtraGrid.GridControl();
            this.GridViewDMQuocGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlDMQuocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDMQuocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // GridControlDMQuocGia
            // 
            this.GridControlDMQuocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlDMQuocGia.Location = new System.Drawing.Point(0, 0);
            this.GridControlDMQuocGia.MainView = this.GridViewDMQuocGia;
            this.GridControlDMQuocGia.Name = "GridControlDMQuocGia";
            this.GridControlDMQuocGia.Size = new System.Drawing.Size(284, 262);
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
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.GridControlDMQuocGia);
            this.Name = "test";
            this.Text = "test";
            ((System.ComponentModel.ISupportInitialize)(this.GridControlDMQuocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDMQuocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraGrid.GridControl GridControlDMQuocGia;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridViewDMQuocGia;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView2;
    }
}