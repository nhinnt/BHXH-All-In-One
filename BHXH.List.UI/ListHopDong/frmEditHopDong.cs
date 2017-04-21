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
    public partial class frmEditHopDong : Form
    {
        public frmEditHopDong(string MaHopDong)
        {
            InitializeComponent();
            maHopDong = MaHopDong;
         
        }
        string maHopDong = "";
        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
         
        DialogResult d=    MessageBox.Show("Bạn có muốn sửa Loại Hợp Đồng?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.List.Business.ListHopDong.Edit(txtMa.Text, txtTen.Text, txtLoai.Text);
            //    BHXH.List.Business.ListHopDong.Edit(txtMa.Text, txtTen.Text);
               
                MessageBox.Show("Bạn đã sửa thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        void InitData()
        {

            txtMa.Text = maHopDong;
            txtTen.Text = BHXH.List.Business.ListHopDong.GetNationality(maHopDong).TenHopDong;
            txtLoai.Text = BHXH.List.Business.ListHopDong.GetNationality(maHopDong).LoaiHopDong;
        }

        private void SimpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditListHopDong_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void LabelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
