using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListTDVanHoa   
    {
        public static IEnumerable<BHXH.Data.ListTDVanHoa> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListTDVanHoa> list;

            var query = from c in ctx.ListTDVanHoa select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListTDVanHoa New(string MaTDVanHoa, string TenTDVanHoa)
           
        {
            if (MaTDVanHoa== "" || TenTDVanHoa== "")
                return null;
            if (IsExisted(MaTDVanHoa, TenTDVanHoa) != null)
                return IsExisted(MaTDVanHoa, TenTDVanHoa);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListTDVanHoa n = new Data.ListTDVanHoa();
            n.MaTDVanHoa= MaTDVanHoa;
            n.TenTDVanHoa= TenTDVanHoa;
            ctx.ListTDVanHoa.Add(n);

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
        public static void Edit(string MaTDVanHoa, string TenTDVanHoa)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDVanHoa
                        where c.MaTDVanHoa == MaTDVanHoa
                        select c;
            BHXH.Data.ListTDVanHoa n = query.First();
            n.MaTDVanHoa= MaTDVanHoa;
            n.TenTDVanHoa= TenTDVanHoa;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListTDVanHoa IsExisted(string MaTDVanHoa, string TenTDVanHoa)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDVanHoa
                        where c.MaTDVanHoa == MaTDVanHoa && c.TenTDVanHoa == TenTDVanHoa
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaTDVanHoa)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            Data.ListTDVanHoa obj = GetNationality(MaTDVanHoa);

            ctx.ListTDVanHoa.Attach(obj);
            ctx.ListTDVanHoa.Remove(obj);
            
            ctx.SaveChanges();


        }

        public static BHXH.Data.ListTDVanHoa GetNationality(string MaTDVanHoa)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDVanHoa
                        where c.MaTDVanHoa== MaTDVanHoa
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
