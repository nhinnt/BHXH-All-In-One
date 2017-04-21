namespace BHXH.List.UI
{
    partial class frmEditTonGiao
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
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SimpleButtonGhi = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButtonThoat = new DevExpress.XtraEditors.SimpleButton();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(31, 74);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(14, 13);
            this.LabelControl1.TabIndex = 12;
            this.LabelControl1.Text = "Mã";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(31, 102);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(42, 13);
            this.LabelControl2.TabIndex = 13;
            this.LabelControl2.Text = "Tôn Giáo";
            this.LabelControl2.Click += new System.EventHandler(this.LabelControl2_Click);
            // 
            // SimpleButtonGhi
            // 
            this.SimpleButtonGhi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SimpleButtonGhi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SimpleButtonGhi.Appearance.Options.UseFont = true;
            this.SimpleButtonGhi.Location = new System.Drawing.Point(122, 142);
            this.SimpleButtonGhi.Name = "SimpleButtonGhi";
            this.SimpleButtonGhi.Size = new System.Drawing.Size(69, 24);
            this.SimpleButtonGhi.TabIndex = 16;
            this.SimpleButtonGhi.Text = "&Ghi";
            this.SimpleButtonGhi.Click += new System.EventHandler(this.SimpleButtonGhi_Click);
            // 
            // SimpleButtonThoat
            // 
            this.SimpleButtonThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SimpleButtonThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SimpleButtonThoat.Appearance.Options.UseFont = true;
            this.SimpleButtonThoat.Location = new System.Drawing.Point(228, 142);
            this.SimpleButtonThoat.Name = "SimpleButtonThoat";
            this.SimpleButtonThoat.Size = new System.Drawing.Size(69, 24);
            this.SimpleButtonThoat.TabIndex = 17;
            this.SimpleButtonThoat.Text = "&Thoát";
            this.SimpleButtonThoat.Click += new System.EventHandler(this.SimpleButtonThoat_Click);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(122, 67);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(175, 20);
            this.txtMa.TabIndex = 18;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(122, 99);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(175, 20);
            this.txtTen.TabIndex = 19;
            // 
            // frmEditTonGiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 240);
            this.ControlBox = false;
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.SimpleButtonThoat);
            this.Controls.Add(this.SimpleButtonGhi);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.LabelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditTonGiao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Tôn Giáo";
            this.Load += new System.EventHandler(this.frmEditListBangCap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.SimpleButton SimpleButtonGhi;
        internal DevExpress.XtraEditors.SimpleButton SimpleButtonThoat;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
    }
}