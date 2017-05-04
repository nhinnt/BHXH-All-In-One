using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListBangCap   
    {
        public static IEnumerable<BHXH.Data.ListBangCap> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListBangCap> list;

            var query = from c in ctx.ListBangCap select c;

            list = query.ToList();
            ctx.Dispose();
            return list;
        }

        public static BHXH.Data.ListBangCap New(string MaBangCap, string TenBangCap)
           
        {
            if (MaBangCap== "" || TenBangCap== "")
                return null;
            if ( IsExisted (MaBangCap, TenBangCap) != null)
                return IsExisted (MaBangCap, TenBangCap);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListBangCap n = new Data.ListBangCap();
            n.MaBangCap= MaBangCap;
            n.TenBangCap= TenBangCap;
            ctx.ListBangCap.Add(n);

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
        public static void Edit(string MaBangCap, string TenBangCap)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListBangCap
                        where c.MaBangCap== MaBangCap
                        select c;
            BHXH.Data.ListBangCap n = query.First();
            n.MaBangCap= MaBangCap;
            n.TenBangCap= TenBangCap;

            try
            {
                ctx.SaveChanges();
            }
            finally
            {
                ctx.Dispose();
            }
        }
        public static Data.ListBangCap IsExisted(string MaBangCap, string TenBangCap)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListBangCap
                        where c.MaBangCap== MaBangCap&& c.TenBangCap== TenBangCap
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;

            //ctx.Dispose();

        }

        public static void Delete(string MaBangCap)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var obj = new Data.ListBangCap { MaBangCap = MaBangCap };
           
            ctx.ListBangCap.Attach(obj);
        ctx.ListBangCap.Remove(obj);


          ctx.SaveChanges();

            ctx.Dispose();
        }

        public static BHXH.Data.ListBangCap GetData(string MaBangCap)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListBangCap
                        where c.MaBangCap == MaBangCap
                        select c;

            return query.ToList().First();
            //ctx.Dispose();

        }
        // public void STT()
        // { }
    }
}
