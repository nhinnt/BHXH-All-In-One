using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.HR.Business
{
   public class HrQuaTrinhBHXH
    {
        public static IEnumerable<BHXH.Data.HrQuaTrinhBHXH> GetData(string code)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.HrQuaTrinhBHXH> list;

            var query = (from c in ctx.HrQuaTrinhBHXH
                         where c.MaNhanVien.ToString() == code
                         select c);

            list = query.ToList();
            return list;
        }
    }
}
