using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListNoiKCB
    {
        public static IEnumerable<BHXH.Data.ListNoiKCB> GetAll(string ma)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListNoiKCB> list;

            var query = from c in ctx.ListNoiKCB
                        where c.MaTinh == ma
                        select c;

            list = query.ToList();
            ctx.Dispose();
            return list;
            
        }

        public static BHXH.Data.ListNoiKCB New(string MaNoiKCB, string TenNoiKCB)
           
        {
            if (MaNoiKCB == "" || TenNoiKCB == "")
                return null;
            if (IsExisted(MaNoiKCB, TenNoiKCB) != null)
                return IsExisted(MaNoiKCB, TenNoiKCB);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListNoiKCB n = new Data.ListNoiKCB();
            n.MaNoiKCB = MaNoiKCB;
            n.TenNoiKCB = TenNoiKCB;
            ctx.ListNoiKCB.Add(n);

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
        public static void Edit(string MaNoiKCB, string TenNoiKCB)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListNoiKCB
                        where c.MaNoiKCB == MaNoiKCB
                        select c;
            BHXH.Data.ListNoiKCB n = query.First();
            n.MaNoiKCB = MaNoiKCB;
            n.TenNoiKCB = TenNoiKCB;

            try
            {
                ctx.SaveChanges();
            }
            finally
            {
                ctx.Dispose();
            }
        }
        public static Data.ListNoiKCB IsExisted(string MaNoiKCB, string TenNoiKCB)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListNoiKCB
                        where c.MaNoiKCB == MaNoiKCB && c.TenNoiKCB == TenNoiKCB
                        select c;
            if (query.Count() > 0)
            {
                ctx.Dispose();
                return query.First();
            }
            else
                return null;
          


        }

        public static void Delete(string MaNoiKCB)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            Data.ListNoiKCB obj = GetNoiKCB(MaNoiKCB);

            ctx.ListNoiKCB.Attach(obj);
            ctx.ListNoiKCB.Remove(obj);
            
            ctx.SaveChanges();
            ctx.Dispose();

        }

        public static BHXH.Data.ListNoiKCB GetNoiKCB(string MaNoiKCB)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListNoiKCB
                        where c.MaNoiKCB == MaNoiKCB
                        select c;
            ctx.Dispose();
            return query.ToList().First();
            

        }
        public static BHXH.Data.ListNoiKCB GetNoiKCBTinh(string MaTinh)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListNoiKCB 
                        where c.MaTinh == MaTinh
                        select c ;
            ctx.Dispose();
            return query.ToList().First();
          

        }
        // public void STT()
        // { }
    }
}
