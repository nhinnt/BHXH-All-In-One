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
    public partial class frmNewNoiKCB : Form
    {
        public frmNewNoiKCB()
        {
            InitializeComponent();
        }

        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
             DialogResult d = MessageBox.Show("Bạn có muốn thêm mới Nơi khám chữa bệnh?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
              if (d == DialogResult.OK)
            {
                  if (BHXH.List.Business.ListNoiKCB.IsExisted(txtMa.Text, txtTen.Text) != null)
                          MessageBox.Show("Đã tồn tại bằng cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (BHXH.List.Business.ListNoiKCB.New(txtMa.Text, txtTen.Text) != null)
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNewNoiKCB
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "frmNewNoiKCB";
            this.Load += new System.EventHandler(this.frmNewNoiKCB_Load);
            this.ResumeLayout(false);

        }

        private void frmNewNoiKCB_Load(object sender, EventArgs e)
        {

        }
    }
}
