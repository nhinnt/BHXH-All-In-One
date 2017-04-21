namespace BHXH.List.UI
{
    partial class frmNewCMDaoTao
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
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.listCMDaoTaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.listCMDaoTaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(44, 54);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(14, 13);
            this.LabelControl1.TabIndex = 12;
            this.LabelControl1.Text = "Mã";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(44, 80);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(76, 13);
            this.LabelControl2.TabIndex = 13;
            this.LabelControl2.Text = "Tên CM đào tạo";
            // 
            // btnGhi
            // 
            this.btnGhi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGhi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGhi.Appearance.Options.UseFont = true;
            this.btnGhi.Location = new System.Drawing.Point(130, 133);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(78, 24);
            this.btnGhi.TabIndex = 16;
            this.btnGhi.Text = "&Ghi";
            this.btnGhi.Click += new System.EventHandler(this.SimpleButtonGhi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(230, 133);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 24);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.SimpleButtonThoat_Click);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(130, 51);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(175, 20);
            this.txtMa.TabIndex = 18;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(130, 77);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(175, 20);
            this.txtTen.TabIndex = 19;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(44, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Loại CM đào tạo";
            // 
            // listCMDaoTaoBindingSource
            // 
            this.listCMDaoTaoBindingSource.DataSource = typeof(BHXH.List.Business.ListCMDaoTao);
            // 
            // cbbLoai
            // 
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Items.AddRange(new object[] {
            "Chuyên môn",
            "Chính trị",
            "QL Nhà nước",
            "Ngoại ngữ",
            "Tin học"});
            this.cbbLoai.Location = new System.Drawing.Point(130, 108);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(175, 21);
            this.cbbLoai.TabIndex = 23;
            // 
            // frmNewCMDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 240);
            this.ControlBox = false;
            this.Controls.Add(this.cbbLoai);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.LabelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewCMDaoTao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Chuyên môn đào tạo";
            this.Load += new System.EventHandler(this.frmNewCMDaoTao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listCMDaoTaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.SimpleButton btnGhi;
        internal DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        internal DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource listCMDaoTaoBindingSource;
        private System.Windows.Forms.ComboBox cbbLoai;
    }
}