using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListHonNhan    
    {
        public static IEnumerable<BHXH.Data.ListHonNhan> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListHonNhan> list;

            var query = from c in ctx.ListHonNhan select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListHonNhan New(string MaHonNhan, string TenHonNhan)
           
        {
            if (MaHonNhan == "" || TenHonNhan == "")
                return null;
            if (IsExisted(MaHonNhan, TenHonNhan) != null)
                return IsExisted(MaHonNhan, TenHonNhan);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListHonNhan n = new Data.ListHonNhan();
            n.MaHonNhan = MaHonNhan;
            n.TenHonNhan = TenHonNhan;
            ctx.ListHonNhan.Add(n);

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
        public static void Edit(string MaHonNhan, string TenHonNhan)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListHonNhan
                        where c.MaHonNhan == MaHonNhan
                        select c;
            BHXH.Data.ListHonNhan n = query.First();
            n.MaHonNhan = MaHonNhan;
            n.TenHonNhan = TenHonNhan;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListHonNhan IsExisted(string MaHonNhan, string TenHonNhan)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListHonNhan
                        where c.MaHonNhan == MaHonNhan && c.TenHonNhan == TenHonNhan
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaHonNhan)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListHonNhan { MaHonNhan = MaHonNhan };
            ctx.ListHonNhan.Attach(obj);
            ctx.ListHonNhan.Remove(obj);

            ctx.SaveChanges();


        }

        public static BHXH.Data.ListHonNhan GetData(string MaHonNhan)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListHonNhan
                        where c.MaHonNhan == MaHonNhan
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
