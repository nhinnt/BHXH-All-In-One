using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.HR.Business
{
public    class HrThangBangLuong
    {
        public static BHXH.Data.HrThangBangLuong GetTenNgach(string MaNgach)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.HrThangBangLuong
                        where c.MaNgach.ToString() == MaNgach.ToString()
                        select c;

            return query.ToList().First();

        }
    }
}
