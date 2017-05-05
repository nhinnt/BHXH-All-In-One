using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHXH.HR.Business
{
    public class HrQuaTrinhLuong
    {
        public static IEnumerable<BHXH.Data.HrQuaTrinhLuong> GetData(string code)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.HrQuaTrinhLuong> list;

            var query = (from c in ctx.HrQuaTrinhLuong
                         where c.MaNhanVien.ToString() == code
                         select c);

            list = query.ToList();
            return list;
        }
    }
}
