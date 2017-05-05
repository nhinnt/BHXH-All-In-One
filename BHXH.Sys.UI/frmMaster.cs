using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraNavBar;

namespace BHXH.Sys.UI
{
    public partial class frmMaster : Form
    {
        public frmMaster()
        {
            InitializeComponent();
            
        }

        private void navBarControlDSUser_Click(object sender, EventArgs e)
        {
           
        }

        private void frmMaster_Load(object sender, EventArgs e)
        {
            string MaPhongBan;
            MaPhongBan = "";
            BHXH.Data.BHXHEntities ctx = new BHXH.Data.BHXHEntities();
            var queryPhongBan = from c in ctx.ListPhongBan
                                    //where c.MaTDVanHoa == MaTDVanHoa
                                select new
                                {
                                    c.MaPhongBan,
                                    c.TenPhongBan
                                };


            foreach (var qPB in queryPhongBan)
            {
                NavBarGroup group = new NavBarGroup();

                group.Caption = qPB.TenPhongBan;
                group.Tag = qPB.MaPhongBan;
                MaPhongBan = qPB.MaPhongBan;
                navBarControlDSUser.Groups.Add(group);
                var queryNhanVien = from c in ctx.HrNhanVien
                                    join p in ctx.SysUser on c.MaNhanVien equals p.MaNhanVien

                                    where c.MaPhongBan == MaPhongBan
                                    select new
                                    {
                                        p.UserID,
                                        c.TenNhanVien
                                    };
                foreach (var qNV in queryNhanVien)
                {
                    NavBarItem item = new NavBarItem();
                    item.Caption = qNV.TenNhanVien;
                    item.Tag = qNV.UserID;
                    group.ItemLinks.Add(item);
                }
            }

        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void lbMaNV_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbUser_Click(object sender, EventArgs e)
        {

        }

        private void lbHoTen_Click(object sender, EventArgs e)
        {

        }

        private void navBarControlDSUser_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            loadThongTin(e.Link.Item.Tag.ToString());
            bool isActive = BHXH.Sys.Business.Users.GetData(e.Link.Item.Tag.ToString()).IsActive.Value;
         //   MessageBox.Show();
            if (isActive == true)
            {
                btnKhoa.Visible = true;
                btnMo.Visible = false;
            }

            else
            {
                btnKhoa.Visible = false;
                btnMo.Visible = true;
            }
               
           
        }
        void loadThongTin (string userID)
        {
           
            txtHoTen.Text = BHXH.Sys.Business.Users.GetName(userID).TenNhanVien.ToString();
            txtUser.Text = userID;
            txtMaNV.Text = BHXH.Sys.Business.Users.GetData(userID).MaNhanVien.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnReset_Click(object sender, EventArgs e)
        {
            BHXH.Sys.Business.Users.Resetpass(txtUser.Text);
            MessageBox.Show(BHXH.Sys.Business.Users.GetData(txtUser.Text).Pwd.ToString());
        }

        private void btnKhoa_Click_1(object sender, EventArgs e)
        {
            BHXH.Sys.Business.Users.KhoaTK(txtUser.Text, false);
            MessageBox.Show("Khóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
           
            {
                BHXH.Sys.Business.Users.KhoaTK(txtUser.Text, true);
                MessageBox.Show("Mở khóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
       

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            BHXH.Sys.Business.Users.Resetpass(txtUser.Text);
        }

        private void treeListPhanQuyen_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            treeListPhanQuyen.DataSource = BHXH.Sys.Business.Master.GetAll();

        }
    }
}
