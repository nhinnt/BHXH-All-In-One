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
    public partial class frmLyLich2C : Form
    {
        public frmLyLich2C()
        {
            InitializeComponent();
            
            
        }
       
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            BHXH.HR.UI.Report.rptLyLich2C  cr1 = new BHXH.HR.UI.Report.rptLyLich2C();
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var result = (from a in ctx.HrNhanVien
                         join b in ctx.HrChiTietDaoTao on a.MaNhanVien equals b.MaNhanVien
                         join c in ctx.HrQuaTrinhCongTac  on a.MaNhanVien  equals c.MaNhanVien
                         where a.MaNhanVien.ToString() == BHXH.HR.UI.frmHrNhanVien.bientoancuc.MaNhanVien.ToString()
                          select new
                         {
                             a.TenNhanVien,
                             a.SoHieuNV 

                         }
                        ).ToList();

           if (result == null)
            {
                MessageBox.Show("null");
            }
            else
            {
                cr1.Load(@"rptLyLich2C.rpt");
                cr1.SetDataSource(result);
                crystalReportViewer1.ReportSource = cr1;
            }
        }
    }
}
