using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListTDDaoTao    
    {
        public static IEnumerable<BHXH.Data.ListTDDaoTao> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListTDDaoTao> list;

            var query = from c in ctx.ListTDDaoTao select c;

            list = query.ToList();
            ctx.Dispose();
            return list;
          

        }

        public static BHXH.Data.ListTDDaoTao New(string MaTDDaoTao, string TenTDDaoTao)
           
        {
            if (MaTDDaoTao == "" || TenTDDaoTao == "")
                return null;
            if (IsExisted(MaTDDaoTao, TenTDDaoTao) != null)
                return IsExisted(MaTDDaoTao, TenTDDaoTao);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListTDDaoTao n = new Data.ListTDDaoTao();
            n.MaTDDaoTao = MaTDDaoTao;
            n.TenTDDaoTao = TenTDDaoTao;
            ctx.ListTDDaoTao.Add(n);

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
        public static void Edit(string MaTDDaoTao, string TenTDDaoTao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDDaoTao
                        where c.MaTDDaoTao == MaTDDaoTao
                        select c;
            BHXH.Data.ListTDDaoTao n = query.First();
            n.MaTDDaoTao = MaTDDaoTao;
            n.TenTDDaoTao = TenTDDaoTao;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { ctx.Dispose(); }
        }
        public static Data.ListTDDaoTao IsExisted(string MaTDDaoTao, string TenTDDaoTao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDDaoTao
                        where c.MaTDDaoTao == MaTDDaoTao && c.TenTDDaoTao == TenTDDaoTao
                        select c;
            if (query.Count() > 0)
            {
                ctx.Dispose();
                return query.First();
            }
            else
                return null;
 


        }

        public static void Delete(string MaTDDaoTao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListTDDaoTao { MaTDDaoTao = MaTDDaoTao };
            ctx.ListTDDaoTao.Attach(obj);
            ctx.ListTDDaoTao.Remove(obj);

            ctx.SaveChanges();
            ctx.Dispose();

        }

        public static BHXH.Data.ListTDDaoTao GetData(string MaTDDaoTao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDDaoTao
                        where c.MaTDDaoTao == MaTDDaoTao
                        select c;
            ctx.Dispose();
            return query.ToList().First();
        

        }
       // public void STT()
       // { }
    }
}
