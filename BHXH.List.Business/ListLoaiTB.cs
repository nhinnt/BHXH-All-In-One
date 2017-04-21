using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListLoaiTB    
    {
        public static IEnumerable<BHXH.Data.ListLoaiTB> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListLoaiTB> list;

            var query = from c in ctx.ListLoaiTB select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListLoaiTB New(string MaLoaiTB, string TenLoaiTB)
           
        {
            if (MaLoaiTB == "" || TenLoaiTB == "")
                return null;
            if (IsExisted(MaLoaiTB, TenLoaiTB) != null)
                return IsExisted(MaLoaiTB, TenLoaiTB);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListLoaiTB n = new Data.ListLoaiTB();
            n.MaLoaiTB = MaLoaiTB;
            n.TenLoaiTB = TenLoaiTB;
            ctx.ListLoaiTB.Add(n);

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
        public static void Edit(string MaLoaiTB, string TenLoaiTB)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListLoaiTB
                        where c.MaLoaiTB == MaLoaiTB
                        select c;
            BHXH.Data.ListLoaiTB n = query.First();
            n.MaLoaiTB = MaLoaiTB;
            n.TenLoaiTB = TenLoaiTB;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListLoaiTB IsExisted(string MaLoaiTB, string TenLoaiTB)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListLoaiTB
                        where c.MaLoaiTB == MaLoaiTB && c.TenLoaiTB == TenLoaiTB
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaLoaiTB)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            Data.ListLoaiTB obj = GetNationality(MaLoaiTB);

            ctx.ListLoaiTB.Attach(obj);
            ctx.ListLoaiTB.Remove(obj);
            
            ctx.SaveChanges();


        }

        public static BHXH.Data.ListLoaiTB GetNationality(string MaLoaiTB)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListLoaiTB
                        where c.MaLoaiTB == MaLoaiTB
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
