using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListNgoaiNgu    
    {
        public static IEnumerable<BHXH.Data.ListNgoaiNgu> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListNgoaiNgu> list;

            var query = from c in ctx.ListNgoaiNgu select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListNgoaiNgu New(string MaNgoaiNgu, string TenNgoaiNgu)
           
        {
            if (MaNgoaiNgu == "" || TenNgoaiNgu == "")
                return null;
            if (IsExisted(MaNgoaiNgu, TenNgoaiNgu) != null)
                return IsExisted(MaNgoaiNgu, TenNgoaiNgu);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListNgoaiNgu n = new Data.ListNgoaiNgu();
            n.MaNgoaiNgu = MaNgoaiNgu;
            n.TenNgoaiNgu = TenNgoaiNgu;
            ctx.ListNgoaiNgu.Add(n);

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
        public static void Edit(string MaNgoaiNgu, string TenNgoaiNgu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListNgoaiNgu
                        where c.MaNgoaiNgu == MaNgoaiNgu
                        select c;
            BHXH.Data.ListNgoaiNgu n = query.First();
            n.MaNgoaiNgu = MaNgoaiNgu;
            n.TenNgoaiNgu = TenNgoaiNgu;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListNgoaiNgu IsExisted(string MaNgoaiNgu, string TenNgoaiNgu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListNgoaiNgu
                        where c.MaNgoaiNgu == MaNgoaiNgu && c.TenNgoaiNgu == TenNgoaiNgu
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaNgoaiNgu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            Data.ListNgoaiNgu obj = GetNationality(MaNgoaiNgu);

            ctx.ListNgoaiNgu.Attach(obj);
            ctx.ListNgoaiNgu.Remove(obj);
            
            ctx.SaveChanges();


        }

        public static BHXH.Data.ListNgoaiNgu GetNationality(string MaNgoaiNgu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListNgoaiNgu
                        where c.MaNgoaiNgu == MaNgoaiNgu
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
