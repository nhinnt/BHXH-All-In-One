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
            ctx.Dispose();
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
            { ctx.Dispose(); }
        }
        public static Data.ListTonGiao IsExisted(string MaTonGiao, string TenTonGiao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTonGiao
                        where c.MaTonGiao == MaTonGiao && c.TenTonGiao == TenTonGiao
                        select c;
            if (query.Count() > 0)
            {
                ctx.Dispose();
                return query.First();
            }
            else
                return null;
          


        }

        public static void Delete(string MaTonGiao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListTonGiao { MaTonGiao = MaTonGiao };
            ctx.ListTonGiao.Attach(obj);
            ctx.ListTonGiao.Remove(obj);

            ctx.SaveChanges();
            ctx.Dispose();

        }

        public static BHXH.Data.ListTonGiao GetTonGiao(string MaTonGiao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTonGiao
                        where c.MaTonGiao == MaTonGiao
                        select c;
            ctx.Dispose();

            return query.ToList().First();
       
        }
       // public void STT()
       // { }
    }
}
