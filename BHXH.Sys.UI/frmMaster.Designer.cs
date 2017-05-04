namespace BHXH.Sys.UI
{
    partial class frmMaster
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
            this.navBarControlDSUser = new DevExpress.XtraNavBar.NavBarControl();
            this.tabQuanlyTK = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMo = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlDSUser)).BeginInit();
            this.tabQuanlyTK.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBarControlDSUser
            // 
            this.navBarControlDSUser.ActiveGroup = null;
            this.navBarControlDSUser.Location = new System.Drawing.Point(-4, -2);
            this.navBarControlDSUser.Name = "navBarControlDSUser";
            this.navBarControlDSUser.OptionsNavPane.ExpandedWidth = 134;
            this.navBarControlDSUser.Size = new System.Drawing.Size(134, 269);
            this.navBarControlDSUser.TabIndex = 0;
            this.navBarControlDSUser.Text = "navBarControlDSUser";
            this.navBarControlDSUser.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControlDSUser_LinkClicked);
            this.navBarControlDSUser.Click += new System.EventHandler(this.navBarControlDSUser_Click);
            // 
            // tabQuanlyTK
            // 
            this.tabQuanlyTK.Controls.Add(this.tabPage1);
            this.tabQuanlyTK.Controls.Add(this.tabPage2);
            this.tabQuanlyTK.Location = new System.Drawing.Point(136, -2);
            this.tabQuanlyTK.Name = "tabQuanlyTK";
            this.tabQuanlyTK.SelectedIndex = 0;
            this.tabQuanlyTK.Size = new System.Drawing.Size(485, 269);
            this.tabQuanlyTK.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnMo);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnKhoa);
            this.tabPage1.Controls.Add(this.btnThoat);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtMaNV);
            this.tabPage1.Controls.Add(this.txtUser);
            this.tabPage1.Controls.Add(this.txtHoTen);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(477, 243);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý tài khoản";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnMo
            // 
            this.btnMo.Location = new System.Drawing.Point(149, 161);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(93, 23);
            this.btnMo.TabIndex = 19;
            this.btnMo.Text = "Mở tài khoản";
            this.btnMo.UseVisualStyleBackColor = true;
            this.btnMo.Click += new System.EventHandler(this.btnMo_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(149, 201);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(219, 23);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Đặt lại mật khẩu";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Location = new System.Drawing.Point(149, 161);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(93, 23);
            this.btnKhoa.TabIndex = 17;
            this.btnKhoa.Text = "Khóa tài khoản";
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(293, 161);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(149, 128);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(219, 20);
            this.txtMaNV.TabIndex = 14;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(149, 85);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(219, 20);
            this.txtUser.TabIndex = 13;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(149, 42);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(219, 20);
            this.txtHoTen.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Họ và tên";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(477, 243);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phân Quyền chức năng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 263);
            this.Controls.Add(this.tabQuanlyTK);
            this.Controls.Add(this.navBarControlDSUser);
            this.Name = "frmMaster";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.frmMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlDSUser)).EndInit();
            this.tabQuanlyTK.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControlDSUser;
        private System.Windows.Forms.TabControl tabQuanlyTK;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMo;
    }
}