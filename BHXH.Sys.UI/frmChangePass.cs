﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BHXH.Sys.UI
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
            txtPwd.UseSystemPasswordChar = true;
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            InitData();

        }
        void InitData()
        {
   

        }
   
      
        private void cbMaPB_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            //string oldPass = BHXH.Util.MyMD5.Encrypt(txtPwd.Text);
            //MessageBox.Show(oldPass);
            //string newPass = BHXH.Util.MyMD5.Encrypt(txtPwdNew.Text);
            //if (txtPwdNew.Text == "")
            //    MessageBox.Show("Bạn chưa nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //{


            //    DialogResult d = MessageBox.Show("Bạn có muốn thay đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (d == DialogResult.Yes)
            //    {
            //        if (BHXH.Sys.Business.Users.Login(txtUser.Text, oldPass) != null)
            //        {
            //            BHXH.Sys.Business.Users.ChangePassword(BHXH.Sys.Business.Users, oldPass, newPass);

            //            MessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        else
            //            MessageBox.Show("Thay đổi mật khẩu thất bại\n Kiểm tra lại tên đăng nhập hoặc mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}




        }



       


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
