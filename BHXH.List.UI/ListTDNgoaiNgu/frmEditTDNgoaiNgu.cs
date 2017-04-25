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
    public partial class frmEditTDNgoaiNgu : Form
    {
        public frmEditTDNgoaiNgu(string MaTDNgoaiNgu)
        {
            InitializeComponent();
            maTDNgoaiNgu = MaTDNgoaiNgu;
         
        }
        string maTDNgoaiNgu = "";
        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
         
        DialogResult d=    MessageBox.Show("Bạn có muốn sửa Trình Độ Ngoại Ngữ?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.List.Business.ListTDNgoaiNgu.Edit(txtMa.Text, txtTen.Text);
            //    BHXH.List.Business.ListTDNgoaiNgu.Edit(txtMa.Text, txtTen.Text);
               
                MessageBox.Show("Bạn đã sửa thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        void InitData()
        {

            txtMa.Text = maTDNgoaiNgu;
            txtTen.Text = BHXH.List.Business.ListTDNgoaiNgu.GetData(maTDNgoaiNgu).TenTDNgoaiNgu;
        }

        private void SimpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditListTDNgoaiNgu_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void LabelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
