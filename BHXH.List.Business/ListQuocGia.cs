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
            n.MaQuocGia = TenQuocGia;
            ctx.ListQuocGia.Add(n);

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
            { }
        }
        public static Data.ListQuocGia IsExisted(string MaQuocGia, string TenQuocGia)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListQuocGia
                        where c.MaQuocGia == MaQuocGia && c.TenQuocGia == TenQuocGia
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaQuocGia)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            Data.ListQuocGia obj = GetNationality(MaQuocGia);

            ctx.ListQuocGia.Attach(obj);
            ctx.ListQuocGia.Remove(obj);
            
            ctx.SaveChanges();


        }

        public static BHXH.Data.ListQuocGia GetNationality(string MaQuocGia)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListQuocGia
                        where c.MaQuocGia == MaQuocGia
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
