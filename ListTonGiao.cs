using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListTonGiao
    {
        public static IEnumerable<BHXH.Data.ListTonGiao> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListTonGiao> list;

            var query = from c in ctx.ListTonGiao select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListTonGiao New(string MaTonGiao, string TenTonGiao)
           
        {
            if (MaTonGiao == "" || TenTonGiao == "")
                return null;
            if (IsExisted(MaTonGiao, TenTonGiao) != null)
                return IsExisted(MaTonGiao, TenTonGiao);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListTonGiao n = new Data.ListTonGiao();
            n.MaTonGiao = MaTonGiao;
            n.TenTonGiao = TenTonGiao;
            ctx.ListTonGiao.Add(n);

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
        public static void Edit(string MaTonGiao, string TenTonGiao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTonGiao
                        where c.MaTonGiao == MaTonGiao
                        select c;
            BHXH.Data.ListTonGiao n = query.First();
            n.MaTonGiao = MaTonGiao;
            n.TenTonGiao = TenTonGiao;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListTonGiao IsExisted(string MaTonGiao, string TenTonGiao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTonGiao
                        where c.MaTonGiao == MaTonGiao && c.TenTonGiao == TenTonGiao
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaTonGiao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            Data.ListTonGiao obj = GetTonGiao(MaTonGiao);

            ctx.ListTonGiao.Attach(obj);
            ctx.ListTonGiao.Remove(obj);
            
            ctx.SaveChanges();


        }

        public static BHXH.Data.ListTonGiao GetTonGiao(string MaTonGiao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTonGiao
                        where c.MaTonGiao == MaTonGiao
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
