using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListDanToc    
    {
        public static IEnumerable<BHXH.Data.ListDanToc> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListDanToc> list;

            var query = from c in ctx.ListDanToc select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListDanToc New(string MaDanToc, string TenDanToc)
           
        {
            if (MaDanToc == "" || TenDanToc == "")
                return null;
            if (IsExisted(MaDanToc, TenDanToc) != null)
                return IsExisted(MaDanToc, TenDanToc);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListDanToc n = new Data.ListDanToc();
            n.MaDanToc = MaDanToc;
            n.TenDanToc = TenDanToc;
            ctx.ListDanToc.Add(n);

            try
            {
                ctx.SaveChanges();
                return n;
            }
            catch (Exception)
            {
                return null;
            }

            finally
            { }



        }
        public static void Edit(string MaDanToc, string TenDanToc)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListDanToc
                        where c.MaDanToc == MaDanToc
                        select c;
            BHXH.Data.ListDanToc n = query.First();
            n.MaDanToc = MaDanToc;
            n.TenDanToc = TenDanToc;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListDanToc IsExisted(string MaDanToc, string TenDanToc)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListDanToc
                        where c.MaDanToc == MaDanToc && c.TenDanToc == TenDanToc
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaDanToc)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListDanToc { MaDanToc = MaDanToc };
            ctx.ListDanToc.Attach(obj);
            ctx.ListDanToc.Remove(obj);

            ctx.SaveChanges();


        }

        public static BHXH.Data.ListDanToc GetData(string MaDanToc)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListDanToc
                        where c.MaDanToc == MaDanToc
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
