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
    public partial class frmLogin : Form
    {   
        public frmLogin()
        {
            InitializeComponent();
            cbMaPB.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void ButtonChon_Click(object sender, EventArgs e)
        {
                      

            if(txtPwd.Text.Trim()=="")
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Sys.Business.Sys.LoginedUser = BHXH.Sys.Business.Users.Login(txtUserID.Text.Trim(), txtPwd.Text);

            if (Sys.Business.Sys.LoginedUser == null)
                MessageBox.Show("Đăng nhập không thành công\n Kiểm tra lại tên đăng nhập hoặc mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (CheckBoxGhiPassW.Checked == true)
                {
                    BHXH.Sys.Business.Settings.SavePasswordSetting(txtUserID.Text.Trim(), txtPwd.Text);
                }
                this.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            InitData();
        }
        void LoadPhongBan()
        {

            cbMaPB.DataSource = BHXH.Sys.Business.Users.GetPhongBan();
            cbMaPB.DisplayMember = "TenPhongBan";
            cbMaPB.ValueMember = "MaPhongBan";
            cbUser.SelectedIndex = -1;

        }
        void LoadNhanVien()
        {

            try
            {
                cbUser.DataSource = BHXH.Sys.Business.Users.Getuser(cbMaPB.SelectedValue.ToString());
                
                    cbUser.DisplayMember = "TenNhanVien";
                cbUser.ValueMember = "MaNhanVien";
                
            }
            catch (Exception)
            {
                
            }
        }
        void InitData()
        {
            LoadPhongBan();
        
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMaPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserID_Leave(object sender, EventArgs e)
        {
            txtUserID.Text = BHXH.Util.TextUtil.TrimAccent(txtUserID.Text.ToUpper());
        }
    }
}
