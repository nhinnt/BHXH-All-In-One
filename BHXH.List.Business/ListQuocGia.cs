using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListQuocGia
    {
        public static IEnumerable<BHXH.Data.ListQuocGia> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListQuocGia> list;

            var query = from c in ctx.ListQuocGia select c;

            list = query.ToList();
            ctx.Dispose();
            return list;
          
        }

        public static BHXH.Data.ListQuocGia New(string MaQuocGia, string TenQuocGia)
           
        {
            if (MaQuocGia == "" || TenQuocGia == "")
                return null;
            if (IsExisted(MaQuocGia, TenQuocGia) != null)
                return IsExisted(MaQuocGia, TenQuocGia);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListQuocGia n = new Data.ListQuocGia();
            n.MaQuocGia = MaQuocGia;
            n.TenQuocGia = TenQuocGia;
            ctx.ListQuocGia.Add(n);

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
        public static void Edit(string MaQuocGia, string TenQuocGia)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListQuocGia
                        where c.MaQuocGia == MaQuocGia
                        select c;
            BHXH.Data.ListQuocGia n = query.First();
            n.MaQuocGia = MaQuocGia;
            n.TenQuocGia = TenQuocGia;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { ctx.Dispose(); }
        }
        public static Data.ListQuocGia IsExisted(string MaQuocGia, string TenQuocGia)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListQuocGia
                        where c.MaQuocGia == MaQuocGia && c.TenQuocGia == TenQuocGia
                        select c;
            if (query.Count() > 0)
            {
                ctx.Dispose();
                return query.First();
            }
            else
                return null;
          


        }

        public static void Delete(string MaQuocGia)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListQuocGia { MaQuocGia = MaQuocGia };
            ctx.ListQuocGia.Attach(obj);
            ctx.ListQuocGia.Remove(obj);

            ctx.SaveChanges();
            ctx.Dispose();

        }

        public static BHXH.Data.ListQuocGia GetData(string MaQuocGia)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListQuocGia
                        where c.MaQuocGia == MaQuocGia
                        select c;
            ctx.Dispose();
            return query.ToList().First();
          

        }
       // public void STT()
       // { }
    }
}
