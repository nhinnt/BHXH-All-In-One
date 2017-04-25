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
    public partial class frmEditCMDaoTao : Form
    {
        public frmEditCMDaoTao(string MaCMDaoTao)
        {
            InitializeComponent();
            maCMDaoTao = MaCMDaoTao;
         
        }
        string maCMDaoTao = "";
        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
         
        DialogResult d=    MessageBox.Show("Bạn có muốn sửa Chuyên môn đào tạo?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.List.Business.ListCMDaoTao.Edit(txtMa.Text, txtTen.Text, cbbLoai.Text);
            //    BHXH.List.Business.ListCMDaoTao.Edit(txtMa.Text, txtTen.Text);
               
                MessageBox.Show("Bạn đã sửa thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        void InitData()
        {

            txtMa.Text = maCMDaoTao;
            txtTen.Text = BHXH.List.Business.ListCMDaoTao.GetData(maCMDaoTao).TenCMDaoTao;
            cbbLoai.Text = BHXH.List.Business.ListCMDaoTao.GetData(maCMDaoTao).LoaiCMDaoTao;
        }

        private void SimpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditListCMDaoTao_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void LabelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
