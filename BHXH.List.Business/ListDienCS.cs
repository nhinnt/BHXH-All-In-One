using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListDienCS    
    {
        public static IEnumerable<BHXH.Data.ListDienCS> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListDienCS> list;

            var query = from c in ctx.ListDienCS select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListDienCS New(string MaDienCS, string TenDienCS)
           
        {
            if (MaDienCS == "" || TenDienCS == "")
                return null;
            if (IsExisted(MaDienCS, TenDienCS) != null)
                return IsExisted(MaDienCS, TenDienCS);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListDienCS n = new Data.ListDienCS();
            n.MaDienCS = MaDienCS;
            n.TenDienCS = TenDienCS;
            ctx.ListDienCS.Add(n);

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
        public static void Edit(string MaDienCS, string TenDienCS)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListDienCS
                        where c.MaDienCS == MaDienCS
                        select c;
            BHXH.Data.ListDienCS n = query.First();
            n.MaDienCS = MaDienCS;
            n.TenDienCS = TenDienCS;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListDienCS IsExisted(string MaDienCS, string TenDienCS)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListDienCS
                        where c.MaDienCS == MaDienCS && c.TenDienCS == TenDienCS
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaDienCS)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListDienCS { MaDienCS = MaDienCS };
            ctx.ListDienCS.Attach(obj);
            ctx.ListDienCS.Remove(obj);

            ctx.SaveChanges();


        }

        public static BHXH.Data.ListDienCS GetData(string MaDienCS)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListDienCS
                        where c.MaDienCS == MaDienCS
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
