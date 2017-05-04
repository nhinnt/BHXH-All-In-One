using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListPhongBan    
    {
        public static IEnumerable<BHXH.Data.ListPhongBan> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListPhongBan> list;

            var query = from c in ctx.ListPhongBan select c;

            list = query.ToList();
            ctx.Dispose();
            return list;
           
        }

        public static BHXH.Data.ListPhongBan New(string MaPhongBan, string TenPhongBan)
           
        {
            if (MaPhongBan == "" || TenPhongBan == "")
                return null;
            if (IsExisted(MaPhongBan, TenPhongBan) != null)
                return IsExisted(MaPhongBan, TenPhongBan);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListPhongBan n = new Data.ListPhongBan();
            n.MaPhongBan = MaPhongBan;
            n.TenPhongBan = TenPhongBan;
            ctx.ListPhongBan.Add(n);

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
        public static void Edit(string MaPhongBan, string TenPhongBan)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListPhongBan
                        where c.MaPhongBan == MaPhongBan
                        select c;
            BHXH.Data.ListPhongBan n = query.First();
            n.MaPhongBan = MaPhongBan;
            n.TenPhongBan = TenPhongBan;

            try
            {
                ctx.SaveChanges();
            }
            finally
            {
                ctx.Dispose();
            }
        }
        public static Data.ListPhongBan IsExisted(string MaPhongBan, string TenPhongBan)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListPhongBan
                        where c.MaPhongBan == MaPhongBan && c.TenPhongBan == TenPhongBan
                        select c;
            if (query.Count() > 0)
            {
                ctx.Dispose();
                return query.First();
            }
            else
                return null;
     


        }

        public static void Delete(string MaPhongBan)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListPhongBan { MaPhongBan = MaPhongBan };
            ctx.ListPhongBan.Attach(obj);
            ctx.ListPhongBan.Remove(obj);

            ctx.SaveChanges();
            ctx.Dispose();

        }

        public static BHXH.Data.ListPhongBan GetData(string MaPhongBan)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListPhongBan
                        where c.MaPhongBan == MaPhongBan
                        select c;
            ctx.Dispose();

            return query.ToList().First();
          
        }
       // public void STT()
       // { }
    }
}
