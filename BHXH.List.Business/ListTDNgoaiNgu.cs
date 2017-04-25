using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListTDNgoaiNgu    
    {
        public static IEnumerable<BHXH.Data.ListTDNgoaiNgu> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListTDNgoaiNgu> list;

            var query = from c in ctx.ListTDNgoaiNgu select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListTDNgoaiNgu New(string MaTDNgoaiNgu, string TenTDNgoaiNgu)
           
        {
            if (MaTDNgoaiNgu == "" || TenTDNgoaiNgu == "")
                return null;
            if (IsExisted(MaTDNgoaiNgu, TenTDNgoaiNgu) != null)
                return IsExisted(MaTDNgoaiNgu, TenTDNgoaiNgu);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListTDNgoaiNgu n = new Data.ListTDNgoaiNgu();
            n.MaTDNgoaiNgu = MaTDNgoaiNgu;
            n.TenTDNgoaiNgu = TenTDNgoaiNgu;
            ctx.ListTDNgoaiNgu.Add(n);

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
        public static void Edit(string MaTDNgoaiNgu, string TenTDNgoaiNgu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDNgoaiNgu
                        where c.MaTDNgoaiNgu == MaTDNgoaiNgu
                        select c;
            BHXH.Data.ListTDNgoaiNgu n = query.First();
            n.MaTDNgoaiNgu = MaTDNgoaiNgu;
            n.TenTDNgoaiNgu = TenTDNgoaiNgu;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListTDNgoaiNgu IsExisted(string MaTDNgoaiNgu, string TenTDNgoaiNgu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDNgoaiNgu
                        where c.MaTDNgoaiNgu == MaTDNgoaiNgu && c.TenTDNgoaiNgu == TenTDNgoaiNgu
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaTDNgoaiNgu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListTDNgoaiNgu { MaTDNgoaiNgu = MaTDNgoaiNgu };
            ctx.ListTDNgoaiNgu.Attach(obj);
            ctx.ListTDNgoaiNgu.Remove(obj);

            ctx.SaveChanges();

        }

        public static BHXH.Data.ListTDNgoaiNgu GetData(string MaTDNgoaiNgu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDNgoaiNgu
                        where c.MaTDNgoaiNgu == MaTDNgoaiNgu
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
