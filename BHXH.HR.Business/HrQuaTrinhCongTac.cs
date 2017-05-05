using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.HR.Business
{
    public class HrQuaTrinhCongTac
    {


        public static IEnumerable<BHXH.Data.HrQuaTrinhCongTac> GetData(string code)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.HrQuaTrinhCongTac> list;

            var query = (from c in ctx.HrQuaTrinhCongTac
                        where c.MaNhanVien.ToString ()  == code
                        select c);

            list = query.ToList();
            return list;
        }
        //public static BHXH.Data.HrQuaTrinhCongTac New(string TenNhanVien, string MaPhongBan)

        //{

        //    BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
        //    BHXH.Data.HrQuaTrinhCongTac n = new Data.HrQuaTrinhCongTac();
        //    n.MaNhanVien = Guid.NewGuid();
        //    n. = TenNhanVien;
        //    n.MaPhongBan = MaPhongBan;
        //    ctx.HrNhanVien.Add(n);

        //    try
        //    {
        //        ctx.SaveChanges();
        //        return n;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }

        //    finally
        //    { }
        //}
    }
}
