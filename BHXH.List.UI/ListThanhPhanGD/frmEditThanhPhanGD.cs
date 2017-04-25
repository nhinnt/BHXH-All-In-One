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
    public partial class frmEditThanhPhanGD : Form
    {
        public frmEditThanhPhanGD(string MaThanhPhanGD)
        {
            InitializeComponent();
            maThanhPhanGD = MaThanhPhanGD;
         
        }
        string maThanhPhanGD = "";
        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
         
            DialogResult d= MessageBox.Show("Bạn có muốn sửa Thành Phần Gia Đình?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.List.Business.ListThanhPhanGD.Edit(txtMa.Text, txtTen.Text);
                         
                MessageBox.Show("Bạn đã sửa thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        void InitData()
        {

            txtMa.Text = maThanhPhanGD;
            txtTen.Text = BHXH.List.Business.ListThanhPhanGD.GetThanhPhanGD(maThanhPhanGD).TenThanhPhanGD;
        }

        private void SimpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditListThanhPhanGD_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void LabelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
