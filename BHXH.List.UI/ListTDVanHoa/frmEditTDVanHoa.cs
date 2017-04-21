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
    public partial class frmEditTDVanHoa : Form
    {
        public frmEditTDVanHoa(string MaTDVanHoa)
        {
            InitializeComponent();
            maTDVanHoa = MaTDVanHoa;
         
        }
        string maTDVanHoa = "";
        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
         
        DialogResult d=    MessageBox.Show("Bạn có muốn sửa Trình Độ Văn Hóa?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.List.Business.ListTDVanHoa.Edit(txtMa.Text, txtTen.Text);
            //    BHXH.List.Business.ListTDVanHoa.Edit(txtMa.Text, txtTen.Text);
               
                MessageBox.Show("Bạn đã sửa thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        void InitData()
        {

            txtMa.Text = maTDVanHoa;
            txtTen.Text = BHXH.List.Business.ListTDVanHoa.GetNationality(maTDVanHoa).TenTDVanHoa;
        }

        private void SimpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditListTDVanHoa_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void LabelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
