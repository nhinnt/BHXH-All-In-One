﻿namespace BHXH.Sys.UI
{
    partial class frmChangePass
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
            this.lblPwd = new DevExpress.XtraEditors.LabelControl();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.txtPwdNew = new System.Windows.Forms.TextBox();
            this.lblPwdnew = new DevExpress.XtraEditors.LabelControl();
            this.txtPassAgain = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lblPwd
            // 
            this.lblPwd.Location = new System.Drawing.Point(20, 19);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(58, 13);
            this.lblPwd.TabIndex = 33;
            this.lblPwd.Text = "Mật khẩu cũ";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(118, 12);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(200, 20);
            this.txtPwd.TabIndex = 34;
            // 
            // btnGhi
            // 
            this.btnGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGhi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGhi.Appearance.Options.UseFont = true;
            this.btnGhi.Location = new System.Drawing.Point(118, 125);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(103, 29);
            this.btnGhi.TabIndex = 35;
            this.btnGhi.Text = "&Đổi mật khẩu";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(243, 125);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 29);
            this.btnThoat.TabIndex = 37;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtPwdNew
            // 
            this.txtPwdNew.Location = new System.Drawing.Point(118, 47);
            this.txtPwdNew.Name = "txtPwdNew";
            this.txtPwdNew.Size = new System.Drawing.Size(200, 20);
            this.txtPwdNew.TabIndex = 40;
            // 
            // lblPwdnew
            // 
            this.lblPwdnew.Location = new System.Drawing.Point(20, 54);
            this.lblPwdnew.Name = "lblPwdnew";
            this.lblPwdnew.Size = new System.Drawing.Size(63, 13);
            this.lblPwdnew.TabIndex = 39;
            this.lblPwdnew.Text = "Mật khẩu mới";
            // 
            // txtPassAgain
            // 
            this.txtPassAgain.Location = new System.Drawing.Point(118, 82);
            this.txtPassAgain.Name = "txtPassAgain";
            this.txtPassAgain.Size = new System.Drawing.Size(200, 20);
            this.txtPassAgain.TabIndex = 42;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 89);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 13);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "Nhập lại mật khẩu";
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 166);
            this.Controls.Add(this.txtPassAgain);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPwdNew);
            this.Controls.Add(this.lblPwdnew);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Name = "frmChangePass";
            this.Text = "Thay đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmChangePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal DevExpress.XtraEditors.LabelControl lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        internal DevExpress.XtraEditors.SimpleButton btnGhi;
        internal DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.TextBox txtPwdNew;
        internal DevExpress.XtraEditors.LabelControl lblPwdnew;
        private System.Windows.Forms.TextBox txtPassAgain;
        internal DevExpress.XtraEditors.LabelControl labelControl1;
    }
}