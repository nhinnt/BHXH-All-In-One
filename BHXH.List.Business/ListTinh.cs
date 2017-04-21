using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BHXH.List.Business
{
    public class ListTinh
    {
        public static IEnumerable<BHXH.Data.ListTinh> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListTinh> list;

            var query = from c in ctx.ListTinh select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListTinh New(string MaTinh, string TenTinh)
           
        {
            if (MaTinh == "" || TenTinh == "")
                return null;
            if (IsExisted(MaTinh, TenTinh) != null)
                return IsExisted(MaTinh, TenTinh);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListTinh n = new Data.ListTinh();
            n.MaTinh = MaTinh;
            n.TenTinh = TenTinh;
            ctx.ListTinh.Add(n);

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
        public static void Edit(string MaTinh, string TenTinh)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTinh
                        where c.MaTinh == MaTinh
                        select c;
            BHXH.Data.ListTinh n = query.First();
            n.MaTinh = MaTinh;
            n.TenTinh = TenTinh;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListTinh IsExisted(string MaTinh, string TenTinh)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTinh
                        where c.MaTinh == MaTinh && c.TenTinh == TenTinh
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaTinh)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
           //ctx.
            
           ctx.ListTinh.Attach(obj);
            ctx.ListTinh.Remove(obj);
          
            
            ctx.SaveChanges();


        }

        public static BHXH.Data.ListTinh GetNationality(string MaTinh)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTinh
                        where c.MaTinh == MaTinh
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
