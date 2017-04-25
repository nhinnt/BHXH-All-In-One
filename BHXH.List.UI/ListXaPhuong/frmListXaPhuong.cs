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
    public partial class frmListXaPhuong : XtraForm
    {
        public frmListXaPhuong()
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

        private void frmListXaPhuong_Load(object sender, EventArgs e)
        {
           InitData();
            //gridViewQuanHuyen.Columns(gridColumn10)
         

        }
      
 
       
        void InitData()
        {
           
           
            gridControlTinh.DataSource = BHXH.List.Business.ListTinh.GetAll();

            
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
    //   frmNewXaPhuong f = new frmNewXaPhuong();
    //f.ShowDialog();
    //       InitData();
       }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

          //  try
          //  {
          //string code = gridviewListMain.GetRowCellValue(gridviewListMain.GetSelectedRows().First(), "MaXaPhuong").ToString();
  
          //    frmEditXaPhuong f = new frmEditXaPhuong(code);

          //f.ShowDialog();
          // InitData();
          //  }
          //  catch (Exception ex)
          //  {
          //      MessageBox.Show("Bạn phải chọn dòng cần sửa. \n Chi tiết: " + ex.Message,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
          //  }

        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string code = gridviewListMain.GetRowCellValue(gridviewListMain.GetSelectedRows().First(), "MaXaPhuong").ToString();
               
            //    DialogResult d = MessageBox.Show("Bạn có muốn xóa Quận Huyện", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (d == DialogResult.Yes)
            //    {
            //        BHXH.List.Business.ListXaPhuong.Delete(code);
            //        MessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Bạn phải chọn dòng cần xóa. \n Chi tiết: " + ex.Message);
            //}
            //finally
            //{
            //    InitData();
            //}
        }

     

        private void gridViewTinh_MouseEnter(object sender, EventArgs e)
        {
            string code = gridViewTinh.GetRowCellValue(gridViewTinh.GetSelectedRows().First(), "MaTinh").ToString();
        

            gridControlQuanHuyen.DataSource = BHXH.List.Business.ListQuanHuyen.GetAll(code);
        }

        private void gridViewQuanHuyen_MouseEnter(object sender, EventArgs e)
        {

            //try
            //{ 
            //string xaPhuong = gridViewQuanHuyen.GetRowCellValue(gridViewQuanHuyen.GetSelectedRows().First(), "QuanHuyenID").ToString();
            //    decimal a = decimal.Parse(xaPhuong);

            //gridcontroListMain.DataSource = BHXH.List.Business.ListXaPhuong.GetAll(a);
            //}
            //catch (Exception ex)
            
            //{
            //   // MessageBox.Show(ex.ToString());
            //}

        }
        private void gridViewQuanHuyen_RowCellClick(object sender, RowCellClickEventArgs e)
        {

        }

        private void gridControlQuanHuyen_Click(object sender, EventArgs e)
        {

        }
    }
}
        
