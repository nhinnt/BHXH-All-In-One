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
    public partial class frmNewQuocGia : Form
    {
        public frmNewQuocGia()
        {
            InitializeComponent();
        }

        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
           DialogResult d= MessageBox.Show("Bạn có muốn thêm mới quốc gia", "Thông báo", MessageBoxButtons.OKCancel);
            if (d == DialogResult.OK)
            {
                BHXH.List.Business.ListQuocGia.New(txtMa.Text, txtTen.Text);
            }
            MessageBox.Show("Bạn đã thêm mới thành công", "Thông báo");
        }

        private void SimpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
