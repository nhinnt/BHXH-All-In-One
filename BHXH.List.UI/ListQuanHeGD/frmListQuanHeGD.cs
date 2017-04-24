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
    public partial class frmListQuanHeGD : XtraForm
    {
        public frmListQuanHeGD()
        {
            InitializeComponent();
            gridviewListMain.CustomDrawRowIndicator += GridviewListMain_CustomDrawRowIndicator;
          

        }

        private void GridviewListMain_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            UIHelpers.DevGridView.DanhSoThuTu(this, gridviewListMain, e);
        }

    
        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void frmListQuanHeGD_Load(object sender, EventArgs e)
        {
            InitData();
         

        }
      
 
       
        void InitData()
        {

            gridcontroListMain.DataSource = BHXH.List.Business.ListQuanHeGD.GetAll();

        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNewQuanHeGD f = new frmNewQuanHeGD();
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
          string code = gridviewListMain.GetRowCellValue(gridviewListMain.GetSelectedRows().First(), "MaQuanHeGD").ToString();
  
              frmEditQuanHeGD f = new frmEditQuanHeGD(code);

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
                string code = gridviewListMain.GetRowCellValue(gridviewListMain.GetSelectedRows().First(), "MaQuanHeGD").ToString();
               
                DialogResult d = MessageBox.Show("Bạn có muốn xóa Quan Hệ Gia Đình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    BHXH.List.Business.ListQuanHeGD.Delete(code);
                    MessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn phải chọn dòng cần xóa. \n Chi tiết: " + ex.Message);
            }
            finally
            {
                InitData();
            }
        }
    }
}
