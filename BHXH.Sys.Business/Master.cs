using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.Sys.Business
{
    public class Master
    {
        public static IEnumerable<BHXH.Data.SysRoles> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.SysRoles> list;

            var query = from c in ctx.SysRoles select c;
            list = query.ToList();

          
            ctx.Dispose();
            return list;

        }
    }
}
