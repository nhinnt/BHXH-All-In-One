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
            { }
        }
        public static Data.ListTDLLCT IsExisted(string MaTDLLCT, string TenTDLLCT)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDLLCT
                        where c.MaTDLLCT == MaTDLLCT && c.TenTDLLCT == TenTDLLCT
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaTDLLCT)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            Data.ListTDLLCT obj = GetNationality(MaTDLLCT);

            ctx.ListTDLLCT.Attach(obj);
            ctx.ListTDLLCT.Remove(obj);
            
            ctx.SaveChanges();


        }

        public static BHXH.Data.ListTDLLCT GetNationality(string MaTDLLCT)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDLLCT
                        where c.MaTDLLCT == MaTDLLCT
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
