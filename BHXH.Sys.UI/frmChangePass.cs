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
          //  LoadPhongBan();

        }
   
      
        private void cbMaPB_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  LoadNhanVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            //Guid g = new Guid(cbMaNV.SelectedValue.ToString());
            
            //DialogResult d = MessageBox.Show("Bạn có muốn thêm mới tài khoản?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (d == DialogResult.OK)
            //{
            //    if (BHXH.Sys.Business.Users.IsExisted(txtUser.Text) != null)
            //        MessageBox.Show("Đã tồn tại tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            //    else if (BHXH.Sys.Business.Users.ChangePass(g, txtUser.Text, BHXH.Util.MyMD5.Encrypt( txtPwd.Text),true) != null)
            //    {
            //        MessageBox.Show("Bạn đã thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Có lỗi xảy ra\n Thêm mới không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }

            //}


           
            }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
           // txtUser.Text = txtUser.Text.ToUpper();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            //txtUser.Text = txtUser.Text.ToUpper();
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
          //  txtUser.Text = BHXH.Util.TextUtil.TrimAccent(txtUser.Text.ToUpper());
          //  txtHoten.Text = BHXH.Sys.Business.Users;
        }

        private void cbKhoa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
