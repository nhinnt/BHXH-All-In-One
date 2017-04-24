using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListKTKL    
    {
        public static IEnumerable<BHXH.Data.ListKTKL> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListKTKL> list;

            var query = from c in ctx.ListKTKL select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListKTKL New(string MaKTKL, string TenKTKL, string LoaiKTKL)
           
        {
            if (MaKTKL == "" || TenKTKL == "" || LoaiKTKL=="")
                return null;
            if (IsExisted(MaKTKL, TenKTKL, LoaiKTKL) != null)
                return IsExisted(MaKTKL, TenKTKL, LoaiKTKL);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListKTKL n = new Data.ListKTKL();
            n.MaKTKL = MaKTKL;
            n.TenKTKL = TenKTKL;
            n.LoaiKTKL = LoaiKTKL;
            ctx.ListKTKL.Add(n);

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
        public static void Edit(string MaKTKL, string TenKTKL, string LoaiKTKL)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListKTKL
                        where c.MaKTKL == MaKTKL || c.LoaiKTKL== LoaiKTKL
                        select c;
            BHXH.Data.ListKTKL n = query.First();
            n.MaKTKL = MaKTKL;
            n.TenKTKL = TenKTKL;
            n.LoaiKTKL = LoaiKTKL;
            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListKTKL IsExisted(string MaKTKL, string TenKTKL, string LoaiKTKL)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListKTKL
                        where c.MaKTKL == MaKTKL && c.TenKTKL == TenKTKL && c.LoaiKTKL== LoaiKTKL
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaKTKL)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListKTKL { MaKTKL = MaKTKL };
            ctx.ListKTKL.Attach(obj);
            ctx.ListKTKL.Remove(obj);

            ctx.SaveChanges();


        }

        public static BHXH.Data.ListKTKL GetData(string MaKTKL)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListKTKL
                        where c.MaKTKL == MaKTKL
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
