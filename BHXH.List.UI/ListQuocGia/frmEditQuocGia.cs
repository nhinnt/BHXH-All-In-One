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
    public partial class frmEditQuocGia : Form
    {
        public frmEditQuocGia(string NationalityCode)
        {
            InitializeComponent();
            nationalityCode = NationalityCode;
         
        }
        string nationalityCode = "";
        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
         
        DialogResult d=    MessageBox.Show("Bạn có muốn sửa quốc gia?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.List.Business.ListQuocGia.Edit(txtMa.Text, txtTen.Text);
               
                MessageBox.Show("Bạn đã sửa thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        void InitData()
        {

            txtMa.Text = nationalityCode;
            txtTen.Text = BHXH.List.Business.ListQuocGia.GetNationality(nationalityCode).TenQuocGia;
        }

        private void SimpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditNationlity_Load(object sender, EventArgs e)
        {
            InitData();
        }
    }
}
