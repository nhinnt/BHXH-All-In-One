using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHXH.HR.UI
{
    public partial class frmDanhSachNhanVien : Form
    {
        public BHXH.Data.HrNhanVien nv = null;
        public frmDanhSachNhanVien()
        {
            InitializeComponent();
        }

               
        private void frmDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            this.lookUpEditDMPhongBan.Properties.DataSource = BHXH.List.Business.ListPhongBan.GetAll();
            this.lookUpEditDMPhongBan.Properties.DisplayMember = "TenPhongBan";
            this.lookUpEditDMPhongBan.Properties.ValueMember = "MaPhongBan";
            this.GridControlDSNhanVien.DataSource = BHXH.HR.Business.HrNhanVien.GetAll();
            
        }

        private void SimpleButtonMoi_Click(object sender, EventArgs e)
        {
            
        }

        private void lookUpEditDMPhongBan_EditValueChanged(object sender, EventArgs e)
        {
            this.GridControlDSNhanVien.DataSource = BHXH.HR.Business.HrNhanVien.GetNhanVienPhongBan(lookUpEditDMPhongBan.EditValue.ToString());
        }

        private void SimpleButtonMoi_Click_1(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Enabled = true;
            SimpleButtonGhi.Enabled = true;
            txtTenNhanVien.Text = "";
            txtTenNhanVien.Focus();
            SimpleButtonMoi.Enabled = false;
            GridControlDSNhanVien.Enabled = false;


        }

        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
            if (lookUpEditDMPhongBan.Text == "")
            {
                MessageBox.Show("Chọn phòng ban cần thêm nhân viên");
            }
            else
            {
                DialogResult d = MessageBox.Show("Bạn có muốn lưu nhân viên mới", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    BHXH.HR.Business.HrNhanVien.New(txtTenNhanVien.Text, lookUpEditDMPhongBan.EditValue.ToString());
                }

                SimpleButtonMoi.Enabled = true;
                SimpleButtonGhi.Enabled = false;
                txtTenNhanVien.Enabled = false;
                txtTenNhanVien.Text = "";
                this.GridControlDSNhanVien.DataSource = BHXH.HR.Business.HrNhanVien.GetNhanVienPhongBan(lookUpEditDMPhongBan.EditValue.ToString());
                GridControlDSNhanVien.Enabled = true ;
            }
        }

        private void SimpleButtonQua_Click(object sender, EventArgs e)
        {
            SimpleButtonMoi.Enabled = true;
            SimpleButtonGhi.Enabled = false;
            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = false;
            txtTenNhanVien.Text = "";
            txtTenNhanVien.Focus();
            GridControlDSNhanVien.Enabled = true;

        }

        private void SimpleButtonXoa_Click(object sender, EventArgs e)
        {
            string st = txtMaNhanVien.Text;
            
            DialogResult d = MessageBox.Show("Bạn có muốn xóa nhân viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                try
                {
                    BHXH.HR.Business.HrNhanVien.Delete(st);
                    this.GridControlDSNhanVien.DataSource = BHXH.HR.Business.HrNhanVien.GetNhanVienPhongBan(lookUpEditDMPhongBan.EditValue.ToString());
                }
                catch
                {
                   // MessageBox.Show("Chọn nhân viên cần xóa");
                }
            }

        }

        private void GridControlDSNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void GridViewDSNhanVien_MouseEnter(object sender, EventArgs e)
        {
            txtMaNhanVien.Text  = GridViewDSNhanVien.GetRowCellValue(GridViewDSNhanVien.GetSelectedRows().First(), "MaNhanVien").ToString();
            txtTenNhanVien.Text = GridViewDSNhanVien.GetRowCellValue(GridViewDSNhanVien.GetSelectedRows().First(), "TenNhanVien").ToString();
            
        }

        private void GridControlDSNhanVien_MouseDown(object sender, MouseEventArgs e)
        {
            
                
        }

        private void GridViewDSNhanVien_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void SimpleButtonSua_Click(object sender, EventArgs e)
        {
            this.lblPhongBan.Visible = true;
            this.lookUpEditPhongBan.Visible = true;
            this.lookUpEditPhongBan.Properties.DataSource = BHXH.List.Business.ListPhongBan.GetAll();
            this.lookUpEditPhongBan.Properties.DisplayMember = "TenPhongBan";
            this.lookUpEditPhongBan.Properties.ValueMember = "MaPhongBan";
            txtTenNhanVien.Enabled = true;
            txtTenNhanVien.Focus();
            cmdGhi.Enabled = true;
            SimpleButtonSua.Enabled = false;


        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn sửa thông tin nhân viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                try
                {
                    BHXH.HR.Business.HrNhanVien.EditNhanVienPhongBan(txtMaNhanVien.Text ,txtTenNhanVien.Text, lookUpEditPhongBan.EditValue.ToString());
                    this.lblPhongBan.Visible =false ;
                    this.lookUpEditPhongBan.Visible = false ;
                    cmdGhi.Enabled = false ;
                    SimpleButtonSua.Enabled = true;
                    this.lblPhongBan.Visible = false ;
                    this.lookUpEditPhongBan.Visible = false ;
                    txtTenNhanVien.Enabled = false;
                    this.GridControlDSNhanVien.DataSource = BHXH.HR.Business.HrNhanVien.GetNhanVienPhongBan(lookUpEditDMPhongBan.EditValue.ToString());
                }
                catch
                {
                    
                }
            }
            
        }
    }
}
