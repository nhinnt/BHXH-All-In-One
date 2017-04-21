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
    public partial class frmEditQuanHuyen : Form
    {
        public frmEditQuanHuyen(string MaQuanHuyen)
        {
            InitializeComponent();
            maQuanHuyen = MaQuanHuyen;
         
        }
        string maQuanHuyen = "";
        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
         
        DialogResult d=    MessageBox.Show("Bạn có muốn sửa Quận Huyện?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.List.Business.ListQuanHuyen.Edit(txtMa.Text, txtTen.Text);
            //    BHXH.List.Business.ListQuanHuyen.Edit(txtMa.Text, txtTen.Text);
               
                MessageBox.Show("Bạn đã sửa thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        void InitData()
        {

            txtMa.Text = maQuanHuyen;
            txtTen.Text = BHXH.List.Business.ListQuanHuyen.GetNationality(maQuanHuyen).TenQuanHuyen;
        }

        private void SimpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditListQuanHuyen_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void LabelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
