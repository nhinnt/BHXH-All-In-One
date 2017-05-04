using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListThanhPhanGD
    {
        public static IEnumerable<BHXH.Data.ListThanhPhanGD> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListThanhPhanGD> list;

            var query = from c in ctx.ListThanhPhanGD select c;

            list = query.ToList();
            ctx.Dispose();
            return list;
           
        }

        public static BHXH.Data.ListThanhPhanGD New(string MaThanhPhanGD, string TenThanhPhanGD)
           
        {
            if (MaThanhPhanGD == "" || TenThanhPhanGD == "")
                return null;
            if (IsExisted(MaThanhPhanGD, TenThanhPhanGD) != null)
                return IsExisted(MaThanhPhanGD, TenThanhPhanGD);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListThanhPhanGD n = new Data.ListThanhPhanGD();
            n.MaThanhPhanGD = MaThanhPhanGD;
            n.TenThanhPhanGD = TenThanhPhanGD;
            ctx.ListThanhPhanGD.Add(n);

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
        public static void Edit(string MaThanhPhanGD, string TenThanhPhanGD)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListThanhPhanGD
                        where c.MaThanhPhanGD == MaThanhPhanGD
                        select c;
            BHXH.Data.ListThanhPhanGD n = query.First();
            n.MaThanhPhanGD = MaThanhPhanGD;
            n.TenThanhPhanGD = TenThanhPhanGD;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { ctx.Dispose(); }
        }
        public static Data.ListThanhPhanGD IsExisted(string MaThanhPhanGD, string TenThanhPhanGD)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListThanhPhanGD
                        where c.MaThanhPhanGD == MaThanhPhanGD && c.TenThanhPhanGD == TenThanhPhanGD
                        select c;
            if (query.Count() > 0)
            {
                ctx.Dispose();
                return query.First();
            }
            else
                return null;
         


        }

        public static void Delete(string MaThanhPhanGD)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListThanhPhanGD { MaThanhPhanGD = MaThanhPhanGD };
            ctx.ListThanhPhanGD.Attach(obj);
            ctx.ListThanhPhanGD.Remove(obj);

            ctx.SaveChanges();
            ctx.Dispose();

        }

        public static BHXH.Data.ListThanhPhanGD GetThanhPhanGD(string MaThanhPhanGD)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListThanhPhanGD
                        where c.MaThanhPhanGD == MaThanhPhanGD
                        select c;
            ctx.Dispose();
            return query.ToList().First();
         
        }
       // public void STT()
       // { }
    }
}
