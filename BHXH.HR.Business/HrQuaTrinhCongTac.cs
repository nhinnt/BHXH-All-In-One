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
                         where c.MaNhanVien.ToString() == code
                         orderby c.STT ascending 
                         select c);

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.HrQuaTrinhCongTac New(string MaNhanVien, int STT, string ThoiGian, string CongViec)

        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.HrQuaTrinhCongTac n = new Data.HrQuaTrinhCongTac();
            n.MaNhanVien = new Guid(MaNhanVien);
            n.STT = STT;
            n.ThoiGian = ThoiGian;
            n.CongViec = CongViec;
            n.QuaTrinhCongTacID = Guid.NewGuid();
            ctx.HrQuaTrinhCongTac.Add(n);

            try
            {
                ctx.SaveChanges();
                ctx.Dispose();
                return n;
            }
            catch (Exception)
            {
                return null;
            }

            finally
            { }
        }
         public static void Delete(string QuaTrinhCongTacID)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.HrQuaTrinhCongTac { QuaTrinhCongTacID = new Guid(QuaTrinhCongTacID) };
            ctx.HrQuaTrinhCongTac.Attach(obj);
            ctx.HrQuaTrinhCongTac.Remove(obj);

            ctx.SaveChanges();
            ctx.Dispose();
        }
        public static void Edit(string QuaTrinhCongTacID, string ThoiGian, string CongViec)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.HrQuaTrinhCongTac 
                        where c.QuaTrinhCongTacID.ToString() == QuaTrinhCongTacID
                        select c;
            BHXH.Data.HrQuaTrinhCongTac n = query.First();
            n.ThoiGian  = ThoiGian;
            n.CongViec  = CongViec;
            
            try
            {
                ctx.SaveChanges();
            }
            finally
            { ctx.Dispose(); }
        }
    }
}
