using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHXH.HR.Business
{
    public class HrQuanHeGiaDinh
    {
        //public static IEnumerable<BHXH.Data.HrQuanHeGiaDinh> GetData(string code)
        public static BindingSource GetData(string data)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

               var query = (from c in ctx.HrQuanHeGiaDinh
                         join d in ctx.ListQuanHeGD on c.MaQuanHeGD equals d.MaQuanHeGD
                         where c.MaNhanVien.ToString() == data
                         select new
                         {
                             c.STT,
                             d.TenQuanHeGD,
                             c.HoTen,
                             c.NamSinh,
                             c.ChiTiet

                         }
                        ).ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = query;
            return bs;
        }
    }
}
