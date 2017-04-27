using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraBars;
using System.Data.Entity;
using DevExpress.XtraGrid.Views.Grid;
namespace BHXH.List.UI
{
    public partial class frmListQuocGia : XtraForm
    {
        public frmListQuocGia()
        {
            InitializeComponent();
            gridviewListNationlity.CustomDrawRowIndicator += GridviewListNationlity_CustomDrawRowIndicator;//STT

        }


        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void frmListNationlity_Load(object sender, EventArgs e)
        {
            InitData();
         

        }
      
        private void GridviewListNationlity_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
           UIHelpers.DevGridView.DanhSoThuTu(this, gridviewListNationlity, e);

        }
       
        void InitData()
        {

            gridcontrolListNationlity.DataSource = BHXH.List.Business.ListQuocGia.GetAll();

        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNewQuocGia f = new frmNewQuocGia();
            f.ShowDialog();
            InitData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                string code = gridviewListNationlity.GetRowCellValue(gridviewListNationlity.GetSelectedRows().First(), "MaQuocGia").ToString();
                //"NationlityCode").ToString();
                frmEditQuocGia f = new frmEditQuocGia(code);
                f.ShowDialog();
                InitData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn phải chọn dòng cần sửa. \n Chi tiết: " + ex.Message,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string code = gridviewListNationlity.GetRowCellValue(gridviewListNationlity.GetSelectedRows().First(), "MaQuocGia").ToString();
                //"NationlityCode").ToString();
                DialogResult d = MessageBox.Show("Bạn có muốn xóa tài khoản", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    BHXH.List.Business.ListQuocGia.Delete(code);
                    MessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Bạn phải chọn dòng cần xóa. \n Chi tiết: " + ex.Message);
            //}
            finally
            { InitData();
            }
        }
    }
}
