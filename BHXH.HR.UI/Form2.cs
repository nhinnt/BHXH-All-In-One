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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BHXH.HR.UI.Report.CrystalReportLyLich2C cr1 = new BHXH.HR.UI.Report.CrystalReportLyLich2C();
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var result = (from a in ctx.HrNhanVien

                          join cvdang in ctx.ListChucVuDang on a.MaCapUy equals cvdang.MaChucVu
                          join cvdangkiem in ctx.ListChucVuDang on a.MaCapUyKiem equals cvdangkiem.MaChucVu
                          join cv in ctx.ListChucVu on a.MaChucVu equals cv.MaChucVu
                          ///////quá trình đào tạo
                          join b in ctx.HrChiTietDaoTao on a.MaNhanVien equals b.MaNhanVien
                          join lh in ctx.ListLHDaoTao on b.MaLHDaoTao equals lh.MaLHDaoTao
                          join bc in ctx.ListBangCap on b.MaBangCap equals bc.MaBangCap
                          ///////quá trình công tác
                         // join c in ctx.HrQuaTrinhCongTac on a.MaNhanVien equals c.MaNhanVien

                          where b.MaNhanVien.ToString() == "706f5bff-d372-412a-9a17-21cfb316c993"//BHXH.HR.UI.frmHrNhanVien.bientoancuc.MaNhanVien.ToString()
                          select new
                          {
                              a.TenNhanVien,
                              a.GioiTinh,
                              a.TenKhac,
                              TenChucVuDang = cvdang.TenChucVu,
                              TenChucVuDangKiem = cvdangkiem.TenChucVu,
                              TenChucVu = cv.TenChucVu,
                              a.PCChucVu,
                              /////đào tạo
                              b.TenTruong,
                              b.NganhHoc,
                              b.ThoiGian,
                              TenLHDaoTao = lh.TenLHDaoTao,
                              TenBangCap = bc.TenBangCap,
                              /////qt công tác
                             // ThoiGianCongTac = c.ThoiGian,
                              //c.CongViec,

                          }
                       ).ToList();
            this.GridControlDSNhanVien.DataSource = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            BHXH.HR.UI.frmInLyLich2C f = new BHXH.HR.UI.frmInLyLich2C();
            f.WindowState = FormWindowState.Maximized;
            f.ShowDialog();
           
        }

        private void GridControlDSNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
