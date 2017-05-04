namespace BHXH.Sys.UI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.CheckBoxGhiPassW = new System.Windows.Forms.CheckBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.lblPhongBan = new DevExpress.XtraEditors.LabelControl();
            this.cbMaPB = new System.Windows.Forms.ComboBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(21, 46);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(139, 143);
            this.PictureBox1.TabIndex = 36;
            this.PictureBox1.TabStop = false;
            // 
            // CheckBoxGhiPassW
            // 
            this.CheckBoxGhiPassW.AutoSize = true;
            this.CheckBoxGhiPassW.Location = new System.Drawing.Point(276, 172);
            this.CheckBoxGhiPassW.Name = "CheckBoxGhiPassW";
            this.CheckBoxGhiPassW.Size = new System.Drawing.Size(104, 17);
            this.CheckBoxGhiPassW.TabIndex = 30;
            this.CheckBoxGhiPassW.Text = "Lưu lại mật khẩu";
            this.CheckBoxGhiPassW.UseVisualStyleBackColor = true;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(277, 129);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(190, 20);
            this.txtPwd.TabIndex = 29;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(185, 132);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 13);
            this.Label2.TabIndex = 33;
            this.Label2.Text = "Mật khẩu";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(185, 50);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(76, 13);
            this.Label1.TabIndex = 34;
            this.Label1.Text = "Người sử dụng";
            this.Label1.Visible = false;
            // 
            // cbUser
            // 
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(276, 46);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(190, 21);
            this.cbUser.TabIndex = 28;
            this.cbUser.Visible = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(390, 202);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 25);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(275, 202);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 25);
            this.btnChon.TabIndex = 31;
            this.btnChon.Text = "&Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.ButtonChon_Click);
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.Location = new System.Drawing.Point(188, 23);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(51, 13);
            this.lblPhongBan.TabIndex = 38;
            this.lblPhongBan.Text = "Phòng Ban";
            this.lblPhongBan.Visible = false;
            // 
            // cbMaPB
            // 
            this.cbMaPB.FormattingEnabled = true;
            this.cbMaPB.Location = new System.Drawing.Point(276, 15);
            this.cbMaPB.Name = "cbMaPB";
            this.cbMaPB.Size = new System.Drawing.Size(190, 21);
            this.cbMaPB.TabIndex = 37;
            this.cbMaPB.Visible = false;
            this.cbMaPB.SelectedIndexChanged += new System.EventHandler(this.cbMaPB_SelectedIndexChanged);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(276, 96);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(190, 20);
            this.txtUserID.TabIndex = 29;
            this.txtUserID.Leave += new System.EventHandler(this.txtUserID_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tên đăng nhập";
            this.label3.Click += new System.EventHandler(this.Label2_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 264);
            this.Controls.Add(this.lblPhongBan);
            this.Controls.Add(this.cbMaPB);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.CheckBoxGhiPassW);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChon);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmLogin";
            this.Text = "Đăng nhập hệ thống";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.CheckBox CheckBoxGhiPassW;
        internal System.Windows.Forms.TextBox txtPwd;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cbUser;
        internal System.Windows.Forms.Button btnThoat;
        internal System.Windows.Forms.Button btnChon;
        internal DevExpress.XtraEditors.LabelControl lblPhongBan;
        private System.Windows.Forms.ComboBox cbMaPB;
        internal System.Windows.Forms.TextBox txtUserID;
        internal System.Windows.Forms.Label label3;
    }
}