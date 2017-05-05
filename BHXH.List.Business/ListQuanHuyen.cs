using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListQuanHuyen
    {
        public static IEnumerable<BHXH.Data.ListQuanHuyen> GetAll(string code)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListQuanHuyen> list;

            var query = from c in ctx.ListQuanHuyen
                        where c.MaQuanHuyen == code
                        select c;

            list = query.ToList();
            return list;
        }
        public static IEnumerable<BHXH.Data.ListQuanHuyen> GetToTinh(string MaTinh)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListQuanHuyen> list;

            var query = from c in ctx.ListQuanHuyen
                        where c.MaTinh  == MaTinh
                        select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListQuanHuyen New( string MaQuanHuyen, string TenQuanHuyen)
           
        {
            if (MaQuanHuyen == "" || TenQuanHuyen == "")
                return null;
            if (IsExisted(MaQuanHuyen, TenQuanHuyen) != null)
                return IsExisted(MaQuanHuyen, TenQuanHuyen);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListQuanHuyen n = new Data.ListQuanHuyen();
            n.MaQuanHuyen = MaQuanHuyen;
            n.TenQuanHuyen = TenQuanHuyen;
            ctx.ListQuanHuyen.Add(n);

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
        public static void Edit(string MaQuanHuyen, string TenQuanHuyen)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListQuanHuyen
                        where c.MaQuanHuyen == MaQuanHuyen
                        select c;
            BHXH.Data.ListQuanHuyen n = query.First();
            n.MaQuanHuyen = MaQuanHuyen;
            n.TenQuanHuyen = TenQuanHuyen;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListQuanHuyen IsExisted(string MaQuanHuyen, string TenQuanHuyen)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListQuanHuyen
                        where c.MaQuanHuyen == MaQuanHuyen && c.TenQuanHuyen == TenQuanHuyen
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(decimal QuanHuyenID)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListQuanHuyen { QuanHuyenID = QuanHuyenID };
            ctx.ListQuanHuyen.Attach(obj);
            ctx.ListQuanHuyen.Remove(obj);

            ctx.SaveChanges();


        }

        public static BHXH.Data.ListQuanHuyen GetData(int QuanHuyenID)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

                        return ctx.ListQuanHuyen.SingleOrDefault(x=>x.QuanHuyenID== QuanHuyenID);


        }
       // public void STT()
       // { }
    }
}
