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
    public partial class frmEditNganHang : Form
    {
        public frmEditNganHang(string MaNganHang)
        {
            InitializeComponent();
            maNganHang = MaNganHang;
         
        }
        string maNganHang = "";
        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
         
        DialogResult d=    MessageBox.Show("Bạn có muốn sửa Ngân Hàng?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.List.Business.ListNganHang.Edit(txtMa.Text, txtTen.Text);
            //    BHXH.List.Business.ListNganHang.Edit(txtMa.Text, txtTen.Text);
               
                MessageBox.Show("Bạn đã sửa thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        void InitData()
        {

            txtMa.Text = maNganHang;
            txtTen.Text = BHXH.List.Business.ListNganHang.GetNationality(maNganHang).TenNganHang;
        }

        private void SimpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditListNganHang_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void LabelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
