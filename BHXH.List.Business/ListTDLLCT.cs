using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListTDLLCT    
    {
        public static IEnumerable<BHXH.Data.ListTDLLCT> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListTDLLCT> list;

            var query = from c in ctx.ListTDLLCT select c;

            list = query.ToList();
            ctx.Dispose();
            return list;
          
        }

        public static BHXH.Data.ListTDLLCT New(string MaTDLLCT, string TenTDLLCT)
           
        {
            if (MaTDLLCT == "" || TenTDLLCT == "")
                return null;
            if (IsExisted(MaTDLLCT, TenTDLLCT) != null)
                return IsExisted(MaTDLLCT, TenTDLLCT);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListTDLLCT n = new Data.ListTDLLCT();
            n.MaTDLLCT = MaTDLLCT;
            n.TenTDLLCT = TenTDLLCT;
            ctx.ListTDLLCT.Add(n);

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
        public static void Edit(string MaTDLLCT, string TenTDLLCT)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDLLCT
                        where c.MaTDLLCT == MaTDLLCT
                        select c;
            BHXH.Data.ListTDLLCT n = query.First();
            n.MaTDLLCT = MaTDLLCT;
            n.TenTDLLCT = TenTDLLCT;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { ctx.Dispose(); }
        }
        public static Data.ListTDLLCT IsExisted(string MaTDLLCT, string TenTDLLCT)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDLLCT
                        where c.MaTDLLCT == MaTDLLCT && c.TenTDLLCT == TenTDLLCT
                        select c;
            if (query.Count() > 0)
            {
                ctx.Dispose();
                return query.First();
            }
            else
                return null;
           


        }

        public static void Delete(string MaTDLLCT)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListTDLLCT { MaTDLLCT = MaTDLLCT };
            ctx.ListTDLLCT.Attach(obj);
            ctx.ListTDLLCT.Remove(obj);

            ctx.Dispose();

        }

        public static BHXH.Data.ListTDLLCT GetData(string MaTDLLCT)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDLLCT
                        where c.MaTDLLCT == MaTDLLCT
                        select c;
            ctx.Dispose();
            return query.ToList().First();
     

        }
       // public void STT()
       // { }
    }
}
