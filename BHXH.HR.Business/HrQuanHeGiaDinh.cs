using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.HR.Business
{
   public class HrQuanHeGiaDinh
    {
        public static IEnumerable<BHXH.Data.HrQuanHeGiaDinh> GetData(string code)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.HrQuanHeGiaDinh> list;
            //var query= (from c in ctx.HrQuanHeGiaDinh 
            //            join d in ctx.ListQuanHeGD  on c.MaQuanHeGD  equals d.MaQuanHeGD 
            //            where c.MaQuanHeGD  == d.MaQuanHeGD   s 
            //            select new 
            //            {

            //            }
            //            )

            var query = (from c in ctx.HrQuanHeGiaDinh
                         where c.MaNhanVien.ToString() == code
                         select c);

            list = query.ToList();
            return list;
        }
    }

}
