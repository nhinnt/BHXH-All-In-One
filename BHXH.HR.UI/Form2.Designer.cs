namespace BHXH.HR.UI
{
    partial class Form2
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
            this.GridControlDSNhanVien = new DevExpress.XtraGrid.GridControl();
            this.GridViewDSNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlDSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // GridControlDSNhanVien
            // 
            this.GridControlDSNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlDSNhanVien.Location = new System.Drawing.Point(27, 76);
            this.GridControlDSNhanVien.MainView = this.GridViewDSNhanVien;
            this.GridControlDSNhanVien.Name = "GridControlDSNhanVien";
            this.GridControlDSNhanVien.Size = new System.Drawing.Size(650, 298);
            this.GridControlDSNhanVien.TabIndex = 1;
            this.GridControlDSNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewDSNhanVien,
            this.GridView2});
            this.GridControlDSNhanVien.Click += new System.EventHandler(this.GridControlDSNhanVien_Click);
            // 
            // GridViewDSNhanVien
            // 
            this.GridViewDSNhanVien.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GridViewDSNhanVien.Appearance.FooterPanel.Options.UseFont = true;
            this.GridViewDSNhanVien.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.GridViewDSNhanVien.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            // 
            // GridView2
            // 
            this.GridView2.GridControl = this.GridControlDSNhanVien;
            this.GridView2.Name = "GridView2";
            this.GridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GridControlDSNhanVien);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlDSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraGrid.GridControl GridControlDSNhanVien;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridViewDSNhanVien;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView2;
        private System.Windows.Forms.Button button1;
    }
}