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
    public partial class frmNewHonNhan : Form
    {
        public frmNewHonNhan()
        {
            InitializeComponent();
        }

        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
             DialogResult d = MessageBox.Show("Bạn có muốn thêm mới Tình Trạng Hôn Nhân?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
              if (d == DialogResult.OK)
            {
                  if (BHXH.List.Business.ListHonNhan.IsExisted(txtMa.Text, txtTen.Text) != null)
                          MessageBox.Show("Đã tồn tại Tình Trạng Hôn Nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (BHXH.List.Business.ListHonNhan.New(txtMa.Text, txtTen.Text) != null)
                  {                   
                MessageBox.Show("Bạn đã thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }
                     else
                    {
                    MessageBox.Show("Có lỗi xảy ra\n Thêm mới không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
               
            }}

        private void SimpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
