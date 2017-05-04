using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListNghiepVu    
    {
        public static IEnumerable<BHXH.Data.ListNghiepVu> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListNghiepVu> list;

            var query = from c in ctx.ListNghiepVu select c;

            list = query.ToList();
            ctx.Dispose();
            return list;
           
        }

        public static BHXH.Data.ListNghiepVu New(string MaNghiepVu, string TenNghiepVu)
           
        {
            if (MaNghiepVu == "" || TenNghiepVu == "")
                return null;
            if (IsExisted(MaNghiepVu, TenNghiepVu) != null)
                return IsExisted(MaNghiepVu, TenNghiepVu);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListNghiepVu n = new Data.ListNghiepVu();
            n.MaNghiepVu = MaNghiepVu;
            n.TenNghiepVu = TenNghiepVu;
            ctx.ListNghiepVu.Add(n);

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
        public static void Edit(string MaNghiepVu, string TenNghiepVu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListNghiepVu
                        where c.MaNghiepVu == MaNghiepVu
                        select c;
            BHXH.Data.ListNghiepVu n = query.First();
            n.MaNghiepVu = MaNghiepVu;
            n.TenNghiepVu = TenNghiepVu;

            try
            {
                ctx.SaveChanges();
            }
            finally
            {
                ctx.Dispose();
            }
        }
        public static Data.ListNghiepVu IsExisted(string MaNghiepVu, string TenNghiepVu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListNghiepVu
                        where c.MaNghiepVu == MaNghiepVu && c.TenNghiepVu == TenNghiepVu
                        select c;
            if (query.Count() > 0)
            {
                ctx.Dispose();
                return query.First();
            }
            else
                return null;
        


        }

        public static void Delete(string MaNghiepVu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListNghiepVu { MaNghiepVu = MaNghiepVu };
            ctx.ListNghiepVu.Attach(obj);
            ctx.ListNghiepVu.Remove(obj);

            ctx.SaveChanges();

            ctx.Dispose();
        }

        public static BHXH.Data.ListNghiepVu GetData(string MaNghiepVu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListNghiepVu
                        where c.MaNghiepVu == MaNghiepVu
                        select c;
            ctx.Dispose();
            return query.ToList().First();
           

        }
       // public void STT()
       // { }
    }
}
