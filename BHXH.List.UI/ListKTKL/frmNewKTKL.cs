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
    public partial class frmNewKTKL : Form
    {
        public frmNewKTKL()
        {
            InitializeComponent();


      
        }

        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
             DialogResult d = MessageBox.Show("Bạn có muốn thêm mới Loại Khen Thưởng Kỷ Luật?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
              if (d == DialogResult.OK)
            {
                  if (BHXH.List.Business.ListKTKL.IsExisted(txtMa.Text, txtTen.Text, txtLoai.Text) != null)
                          MessageBox.Show("Đã tồn tại Loại Khen Thưởng Kỷ Luật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (BHXH.List.Business.ListKTKL.New(txtMa.Text, txtTen.Text, txtLoai.Text) != null)
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

        private void frmNewKTKL_Load(object sender, EventArgs e)
        {

        }
    }
}
