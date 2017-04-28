using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHXH.HR.Business
{
    public class HrChiTietDaoTao
    {
        public static BindingSource GetData(string data)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = (from a in ctx.HrNhanVien  
                         join b in ctx.HrChiTietDaoTao  on a.MaNhanVien  equals b.MaNhanVien 
                         join c in ctx.ListCMDaoTao on b.MaCMDaoTao equals c.MaCMDaoTao 
                         join d in ctx.ListLHDaoTao on b.MaLHDaoTao equals d.MaLHDaoTao 
                         join e in ctx.ListBangCap on b.MaBangCap equals e.MaBangCap 
                         where a.MaNhanVien.ToString() == data
                         select new
                         {
                             b.STT,
                             b.NganhHoc,
                             c.TenCMDaoTao,
                             b.ThoiGian,
                             d.TenLHDaoTao,
                             e.TenBangCap,
                             b.XepLoai 

                         }
                        ).ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = query;
            return bs;
        }
    }
}
