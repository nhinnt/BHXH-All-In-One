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
    public partial class frmEditNgoaiNgu : Form
    {
        public frmEditNgoaiNgu(string MaNgoaiNgu)
        {
            InitializeComponent();
            maNgoaiNgu = MaNgoaiNgu;
         
        }
        string maNgoaiNgu = "";
        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
         
        DialogResult d=    MessageBox.Show("Bạn có muốn sửa Ngoại Ngữ?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.List.Business.ListNgoaiNgu.Edit(txtMa.Text, txtTen.Text);
            //    BHXH.List.Business.ListNgoaiNgu.Edit(txtMa.Text, txtTen.Text);
               
                MessageBox.Show("Bạn đã sửa thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        void InitData()
        {

            txtMa.Text = maNgoaiNgu;
            txtTen.Text = BHXH.List.Business.ListNgoaiNgu.GetData(maNgoaiNgu).TenNgoaiNgu;
        }

        private void SimpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditListNgoaiNgu_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void LabelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
