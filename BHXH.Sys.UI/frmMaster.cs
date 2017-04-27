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

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
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
                NavBarControlDSNhanVien.Groups.Add(group);
                var queryNhanVien = from c in ctx.HrNhanVien join p in ctx.SysUser on c.MaNhanVien equals p.MaNhanVien
                                
                                    where c.MaPhongBan == MaPhongBan
                                    select new
                                    {
                                        c.MaNhanVien,
                                        c.TenNhanVien
                                    };
                foreach (var qNV in queryNhanVien)
                {
                    NavBarItem item = new NavBarItem();
                    item.Caption = qNV.TenNhanVien;
                    item.Tag = qNV.MaNhanVien;
                    group.ItemLinks.Add(item);
                }
            }

        }

      
        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            BHXH.Sys.Business.Users.Resetpass(txtHoTen.Text);
        }

        private void NavBarControlDSNhanVien_Click(object sender, EventArgs e)
        {
          
        }

        private void NavBarControlDSNhanVien_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string UserID = e.Link.Item.Tag.ToString();

            txtHoTen.Text = BHXH.Sys.Business.Users.GetName(UserID).TenNhanVien;
        }
    }
}
 
