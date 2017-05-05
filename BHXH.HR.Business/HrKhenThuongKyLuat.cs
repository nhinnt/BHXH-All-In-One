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
                         select new
                         {
                             a.STT,
                             b.LoaiKTKL,
                             b.TenKTKL,
                             a.Nam 
                         }
                        ).ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = query;
            return bs;
        }
    }
}
