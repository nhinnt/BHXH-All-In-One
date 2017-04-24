using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListTDQLNN   
    {
        public static IEnumerable<BHXH.Data.ListTDQLNN> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListTDQLNN> list;

            var query = from c in ctx.ListTDQLNN select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListTDQLNN New(string MaTDQLNN, string TenTDQLNN)
           
        {
            if (MaTDQLNN== "" || TenTDQLNN== "")
                return null;
            if (IsExisted(MaTDQLNN, TenTDQLNN) != null)
                return IsExisted(MaTDQLNN, TenTDQLNN);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListTDQLNN n = new Data.ListTDQLNN();
            n.MaTDQLNN= MaTDQLNN;
            n.TenTDQLNN= TenTDQLNN;
            ctx.ListTDQLNN.Add(n);

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
        public static void Edit(string MaTDQLNN, string TenTDQLNN)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDQLNN
                        where c.MaTDQLNN == MaTDQLNN
                        select c;
            BHXH.Data.ListTDQLNN n = query.First();
            n.MaTDQLNN= MaTDQLNN;
            n.TenTDQLNN= TenTDQLNN;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListTDQLNN IsExisted(string MaTDQLNN, string TenTDQLNN)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDQLNN
                        where c.MaTDQLNN == MaTDQLNN && c.TenTDQLNN == TenTDQLNN
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaTDQLNN)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListTDQLNN { MaTDQLNN = MaTDQLNN };
            ctx.ListTDQLNN.Attach(obj);
            ctx.ListTDQLNN.Remove(obj);

            ctx.SaveChanges();


        }

        public static BHXH.Data.ListTDQLNN GetData(string MaTDQLNN)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDQLNN
                        where c.MaTDQLNN== MaTDQLNN
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
