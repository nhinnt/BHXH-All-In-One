using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListChucVu    
    {
        public static IEnumerable<BHXH.Data.ListChucVu> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListChucVu> list;

            var query = from c in ctx.ListChucVu select c;

            list = query.ToList();
            ctx.Dispose();
            return list;
          
        }

        public static BHXH.Data.ListChucVu New(string MaChucVu, string TenChucVu)
           
        {
            if (MaChucVu == "" || TenChucVu == "")
                return null;
            if (IsExisted(MaChucVu, TenChucVu) != null)
                return IsExisted(MaChucVu, TenChucVu);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListChucVu n = new Data.ListChucVu();
            n.MaChucVu = MaChucVu;
            n.TenChucVu = TenChucVu;
            ctx.ListChucVu.Add(n);

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
        public static void Edit(string MaChucVu, string TenChucVu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListChucVu
                        where c.MaChucVu == MaChucVu
                        select c;
            BHXH.Data.ListChucVu n = query.First();
            n.MaChucVu = MaChucVu;
            n.TenChucVu = TenChucVu;

            try
            {
                ctx.SaveChanges();
            }
            finally
            {
                ctx.Dispose();
            }
        }
        public static Data.ListChucVu IsExisted(string MaChucVu, string TenChucVu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListChucVu
                        where c.MaChucVu == MaChucVu && c.TenChucVu == TenChucVu
                        select c;
            if (query.Count() > 0)
            {
                ctx.Dispose();
                return query.First();
           
            }
            else
                return null;



        }

        public static void Delete(string MaChucVu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListChucVu { MaChucVu = MaChucVu };
            ctx.ListChucVu.Attach(obj);
            ctx.ListChucVu.Remove(obj);

            ctx.SaveChanges();
            ctx.Dispose();

        }

        public static BHXH.Data.ListChucVu GetData(string MaChucVu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListChucVu
                        where c.MaChucVu == MaChucVu
                        select c;
            ctx.Dispose();
            return query.ToList().First();
         

        }
       // public void STT()
       // { }
    }
}
