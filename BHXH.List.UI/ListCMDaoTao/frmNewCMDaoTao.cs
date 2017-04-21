using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace BHXH.List.UI
{
    public partial class frmNewCMDaoTao : Form
    {
        public frmNewCMDaoTao()
        {
            InitializeComponent();


      
        }

        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
             DialogResult d = MessageBox.Show("Bạn có muốn thêm mới Chuyên môn đào tạo?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
              if (d == DialogResult.OK)
            {
                  if (BHXH.List.Business.ListCMDaoTao.IsExisted(txtMa.Text, txtTen.Text, cbbLoai.Text) != null)
                          MessageBox.Show("Đã tồn tại Chuyên môn đào tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (BHXH.List.Business.ListCMDaoTao.New(txtMa.Text, txtTen.Text, cbbLoai.Text) != null)
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

        private void frmNewCMDaoTao_Load(object sender, EventArgs e)
        {

        }
    }
}
