using System;
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
            BHXH.Sys.Business.Users.Login("ABC","2");

            string userID = BHXH.Sys.Business.Sys.LoginedUser.UserID.ToString();
       //     if(Sys.Business.Sys.LoginedUser !=null)
               

            string oldPass = BHXH.Util.MyMD5.Encrypt(txtPwd.Text);
           
            string newPass = BHXH.Util.MyMD5.Encrypt(txtPwdNew.Text);
            string PassAgain = BHXH.Util.MyMD5.Encrypt(txtPassAgain.Text);
            if (txtPwdNew.Text == "")
                MessageBox.Show("Bạn chưa nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                
                
                DialogResult d = MessageBox.Show("Bạn có muốn thay đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    if (oldPass== BHXH.Sys.Business.Users.GetData(userID).Pwd.ToString())
                    {
                        if (newPass == PassAgain)
                        {
                            BHXH.Sys.Business.Users.ChangePassword(userID, oldPass, newPass);

                            MessageBox.Show("Bạn đã thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Thay đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Thay đổi mật khẩu thất bại\n Kiểm tra lại tên đăng nhập hoặc mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




        }



        private void txtUser_Leave(object sender, EventArgs e)
        {
          //  txtUser.Text = BHXH.Util.TextUtil.TrimAccent(txtUser.Text.ToUpper());
          //  txtHoten.Text = BHXH.Sys.Business.Users;
        }


       


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
