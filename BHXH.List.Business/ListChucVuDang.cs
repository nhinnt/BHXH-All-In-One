using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListChucVuDang    
    {
        public static IEnumerable<BHXH.Data.ListChucVuDang> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListChucVuDang> list;

            var query = from c in ctx.ListChucVuDang select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListChucVuDang New(string MaChucVu, string TenChucVu)
           
        {
            if (MaChucVu == "" || TenChucVu == "")
                return null;
            if (IsExisted(MaChucVu, TenChucVu) != null)
                return IsExisted(MaChucVu, TenChucVu);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListChucVuDang n = new Data.ListChucVuDang();
            n.MaChucVu = MaChucVu;
            n.TenChucVu = TenChucVu;
            ctx.ListChucVuDang.Add(n);

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
        public static void Edit(string MaChucVu, string TenChucVu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListChucVuDang
                        where c.MaChucVu == MaChucVu
                        select c;
            BHXH.Data.ListChucVuDang n = query.First();
            n.MaChucVu = MaChucVu;
            n.TenChucVu = TenChucVu;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListChucVuDang IsExisted(string MaChucVu, string TenChucVu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListChucVuDang
                        where c.MaChucVu == MaChucVu && c.TenChucVu == TenChucVu
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaChucVu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListChucVuDang { MaChucVu = MaChucVu };
            ctx.ListChucVuDang.Attach(obj);
            ctx.ListChucVuDang.Remove(obj);

            ctx.SaveChanges();


        }

        public static BHXH.Data.ListChucVuDang GetData(string MaChucVu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListChucVuDang
                        where c.MaChucVu == MaChucVu
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
