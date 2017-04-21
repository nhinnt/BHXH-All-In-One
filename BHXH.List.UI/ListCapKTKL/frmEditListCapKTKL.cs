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
    public partial class frmEditCapKTKL : Form
    {
        public frmEditCapKTKL(string MaCapKTKL)
        {
            InitializeComponent();
            maCapKTKL = MaCapKTKL;
         
        }
        string maCapKTKL = "";
        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
         
        DialogResult d=    MessageBox.Show("Bạn có muốn sửa Bằng cấp?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.List.Business.ListCapKTKL.Edit(txtMa.Text, txtTen.Text);
        
               
                MessageBox.Show("Bạn đã sửa thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        void InitData()
        {

            txtMa.Text = maCapKTKL;
            txtTen.Text = BHXH.List.Business.ListCapKTKL.GetNationality(maCapKTKL).TenCapKTKL;
        }

        private void SimpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditListBangCap_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void LabelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
