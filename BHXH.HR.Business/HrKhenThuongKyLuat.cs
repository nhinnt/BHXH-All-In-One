using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHXH.HR.Business
{
   public class HrKhenThuongKyLuat
    {
        public static BindingSource GetData(string data)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

           // IEnumerable<BHXH.Data.HrKhenThuongKyLuat> list;
            var query = (from a in ctx.HrKhenThuongKyLuat
                         join b in ctx.ListKTKL on a.MaKTKL equals b.MaKTKL 
                         where a.MaNhanVien.ToString ()  == data 
                         orderby a.STT ascending 
                         select new
                         {
                             a.STT, 
                             b.LoaiKTKL,
                             b.TenKTKL,
                             a.Nam ,
                             a.KhenThuongKyLuatID 
                         }
                        ).ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = query;
            return bs;
        }
        public static BHXH.Data.HrKhenThuongKyLuat  New(string MaNhanVien, int STT, string MaKTKL, string Nam, string GhiChu)

        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.HrKhenThuongKyLuat n = new Data.HrKhenThuongKyLuat();
            n.MaNhanVien = new Guid(MaNhanVien);
            n.STT = STT;
            n.MaKTKL = MaKTKL; ;
            n.Nam = Nam;
            n.GhiChu = GhiChu;
            n.KhenThuongKyLuatID  = Guid.NewGuid();
            ctx.HrKhenThuongKyLuat.Add(n);

            try
            {
                ctx.SaveChanges();
                ctx.Dispose();
                return n;
            }
            catch (Exception)
            {
                return null;
            }

            finally
            { }
        }
    }
}
