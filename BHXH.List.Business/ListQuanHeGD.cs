using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListQuanHeGD    
    {
        public static IEnumerable<BHXH.Data.ListQuanHeGD> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListQuanHeGD> list;

            var query = from c in ctx.ListQuanHeGD select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListQuanHeGD New(string MaQuanHeGD, string TenQuanHeGD)
           
        {
            if (MaQuanHeGD == "" || TenQuanHeGD == "")
                return null;
            if (IsExisted(MaQuanHeGD, TenQuanHeGD) != null)
                return IsExisted(MaQuanHeGD, TenQuanHeGD);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListQuanHeGD n = new Data.ListQuanHeGD();
            n.MaQuanHeGD = MaQuanHeGD;
            n.TenQuanHeGD = TenQuanHeGD;
            ctx.ListQuanHeGD.Add(n);

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
        public static void Edit(string MaQuanHeGD, string TenQuanHeGD)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListQuanHeGD
                        where c.MaQuanHeGD == MaQuanHeGD
                        select c;
            BHXH.Data.ListQuanHeGD n = query.First();
            n.MaQuanHeGD = MaQuanHeGD;
            n.TenQuanHeGD = TenQuanHeGD;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListQuanHeGD IsExisted(string MaQuanHeGD, string TenQuanHeGD)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListQuanHeGD
                        where c.MaQuanHeGD == MaQuanHeGD && c.TenQuanHeGD == TenQuanHeGD
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaQuanHeGD)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListQuanHeGD { MaQuanHeGD = MaQuanHeGD };
            ctx.ListQuanHeGD.Attach(obj);
            ctx.ListQuanHeGD.Remove(obj);

            ctx.SaveChanges();


        }

        public static BHXH.Data.ListQuanHeGD GetData(string MaQuanHeGD)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListQuanHeGD
                        where c.MaQuanHeGD == MaQuanHeGD
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
