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
    public partial class frmEditHonNhan: Form
    {
        public frmEditHonNhan(string MaHonNhan)
        {
            InitializeComponent();
            maHonNhan= MaHonNhan;
         
        }
        string maHonNhan= "";
        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
         
        DialogResult d=    MessageBox.Show("Bạn có muốn sửa Hôn Nhân?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.List.Business.ListHonNhan.Edit(txtMa.Text, txtTen.Text);
            
               
                MessageBox.Show("Bạn đã sửa thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        void InitData()
        {

            txtMa.Text = maHonNhan;
            txtTen.Text = BHXH.List.Business.ListHonNhan.GetNationality(maHonNhan).TenHonNhan;
        }

        private void SimpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditListHonNhan_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void LabelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
