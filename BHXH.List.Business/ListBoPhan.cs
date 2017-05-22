using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListBoPhan
    {
        public static IEnumerable<BHXH.Data.ListBoPhan> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListBoPhan> list;

            var query = from c in ctx.ListBoPhan select c;

            list = query.ToList();
            ctx.Dispose();
            return list;
        }
        public static BHXH.Data.ListBoPhan  GetData(string MaPhongBan)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListBoPhan
                        where c.MaPhongBan  == MaPhongBan
                        select c;
            ctx.Dispose();

            return query.ToList().First();

        }
    }
}
