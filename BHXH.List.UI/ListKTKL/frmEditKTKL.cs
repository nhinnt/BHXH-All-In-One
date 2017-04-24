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
    public partial class frmEditKTKL : Form
    {
        public frmEditKTKL(string MaKTKL)
        {
            InitializeComponent();
            maKTKL = MaKTKL;
         
        }
        string maKTKL = "";
        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
         
        DialogResult d=    MessageBox.Show("Bạn có muốn sửa Loại Khen Thưởng Kỷ Luật?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.List.Business.ListKTKL.Edit(txtMa.Text, txtTen.Text, txtLoai.Text);
            //    BHXH.List.Business.ListKTKL.Edit(txtMa.Text, txtTen.Text);
               
                MessageBox.Show("Bạn đã sửa thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        void InitData()
        {

            txtMa.Text = maKTKL;
            txtTen.Text = BHXH.List.Business.ListKTKL.GetData(maKTKL).TenKTKL;
            txtLoai.Text = BHXH.List.Business.ListKTKL.GetData(maKTKL).LoaiKTKL;
        }

        private void SimpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditListKTKL_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void LabelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
