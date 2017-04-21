using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListChucDanh    
    {
        public static IEnumerable<BHXH.Data.ListChucDanh> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListChucDanh> list;

            var query = from c in ctx.ListChucDanh select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListChucDanh New(string MaChucDanh, string TenChucDanh)
           
        {
            if (MaChucDanh == "" || TenChucDanh == "")
                return null;
            if (  IsExisted(MaChucDanh, TenChucDanh) != null)
                return IsExisted(MaChucDanh, TenChucDanh);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListChucDanh n = new Data.ListChucDanh();
            n.MaChucDanh = MaChucDanh;
            n.TenChucDanh = TenChucDanh;
            ctx.ListChucDanh.Add(n);

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
        public static void  Edit(string MaChucDanh, string TenChucDanh)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListChucDanh
                        where c.MaChucDanh == MaChucDanh
                        select c;
            BHXH.Data.ListChucDanh n = query.First();
            n.MaChucDanh = MaChucDanh;
            n.TenChucDanh = TenChucDanh;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListChucDanh IsExisted(string MaChucDanh, string TenChucDanh)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListChucDanh
                        where c.MaChucDanh == MaChucDanh && c.TenChucDanh == TenChucDanh
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaChucDanh)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            Data.ListChucDanh obj = GetNationality(MaChucDanh);

            ctx.ListChucDanh.Attach(obj);
            ctx.ListChucDanh.Remove(obj);
            
            ctx.SaveChanges();


        }

        public static BHXH.Data.ListChucDanh GetNationality(string MaChucDanh)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListChucDanh
                        where c.MaChucDanh == MaChucDanh
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
