using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListCapKTKL    
    {
        public static IEnumerable<BHXH.Data.ListCapKTKL> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListCapKTKL> list;

            var query = from c in ctx.ListCapKTKL select c;

            list = query.ToList();

            return list;
         // //  ctx.Dispose();
        }

        public static BHXH.Data.ListCapKTKL New(string MaCapKTKL, string TenCapKTKL)
           
        {
            if (MaCapKTKL == "" || TenCapKTKL == "")
                return null;
            if (IsExisted(MaCapKTKL, TenCapKTKL) != null)
                return IsExisted(MaCapKTKL, TenCapKTKL);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListCapKTKL n = new Data.ListCapKTKL();
            n.MaCapKTKL = MaCapKTKL;
            n.TenCapKTKL = TenCapKTKL;
            ctx.ListCapKTKL.Add(n);

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
        public static void Edit(string MaCapKTKL, string TenCapKTKL)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListCapKTKL
                        where c.MaCapKTKL == MaCapKTKL
                        select c;
            BHXH.Data.ListCapKTKL n = query.First();
            n.MaCapKTKL = MaCapKTKL;
            n.TenCapKTKL = TenCapKTKL;

            try
            {
                ctx.SaveChanges();
            }
            finally
            {
                ctx.Dispose();
            }
        }
        public static Data.ListCapKTKL IsExisted(string MaCapKTKL, string TenCapKTKL)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListCapKTKL
                        where c.MaCapKTKL == MaCapKTKL && c.TenCapKTKL == TenCapKTKL
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;

            //ctx.Dispose();

        }

        public static void Delete(string MaCapKTKL)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListCapKTKL { MaCapKTKL = MaCapKTKL };
            ctx.ListCapKTKL.Attach(obj);
            ctx.ListCapKTKL.Remove(obj);

            ctx.SaveChanges();

            ctx.Dispose();
        }

        public static BHXH.Data.ListCapKTKL GetData(string MaCapKTKL)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListCapKTKL
                        where c.MaCapKTKL == MaCapKTKL
                        select c;

            return query.ToList().First();
            //ctx.Dispose();

        }
       // public void STT()
       // { }
    }
}
