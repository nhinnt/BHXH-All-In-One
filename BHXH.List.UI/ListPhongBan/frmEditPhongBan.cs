using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHXH.List.UI
{
    public partial class frmEditPhongBan : Form
    {
        public frmEditPhongBan(string MaPhongBan)
        {
            InitializeComponent();
            maPhongBan = MaPhongBan;
         
        }
        string maPhongBan = "";
        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
         
        DialogResult d=    MessageBox.Show("Bạn có muốn sửa Phòng Ban?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.List.Business.ListPhongBan.Edit(txtMa.Text, txtTen.Text);
            //    BHXH.List.Business.ListPhongBan.Edit(txtMa.Text, txtTen.Text);
               
                MessageBox.Show("Bạn đã sửa thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        void InitData()
        {

            txtMa.Text = maPhongBan;
            txtTen.Text = BHXH.List.Business.ListPhongBan.GetNationality(maPhongBan).TenPhongBan;
        }

        private void SimpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditListPhongBan_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void LabelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
