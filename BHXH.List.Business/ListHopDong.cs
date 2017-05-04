using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListHopDong    
    {
        public static IEnumerable<BHXH.Data.ListHopDong> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListHopDong> list;

            var query = from c in ctx.ListHopDong select c;

            list = query.ToList();
            ctx.Dispose();
            return list;
          
        }

        public static BHXH.Data.ListHopDong New(string MaHopDong, string TenHopDong, string LoaiHopDong)
           
        {
            if (MaHopDong == "" || TenHopDong == "" || LoaiHopDong=="")
                return null;
            if (IsExisted(MaHopDong, TenHopDong, LoaiHopDong) != null)
                return IsExisted(MaHopDong, TenHopDong, LoaiHopDong);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListHopDong n = new Data.ListHopDong();
            n.MaHopDong = MaHopDong;
            n.TenHopDong = TenHopDong;
            n.LoaiHopDong = LoaiHopDong;
            ctx.ListHopDong.Add(n);

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
        public static void Edit(string MaHopDong, string TenHopDong, string LoaiHopDong)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListHopDong
                        where c.MaHopDong == MaHopDong || c.LoaiHopDong== LoaiHopDong
                        select c;
            BHXH.Data.ListHopDong n = query.First();
            n.MaHopDong = MaHopDong;
            n.TenHopDong = TenHopDong;
            n.LoaiHopDong = LoaiHopDong;
            try
            {
                ctx.SaveChanges();
            }
            finally
            {
                ctx.Dispose();
            }
        }
        public static Data.ListHopDong IsExisted(string MaHopDong, string TenHopDong, string LoaiHopDong)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListHopDong
                        where c.MaHopDong == MaHopDong && c.TenHopDong == TenHopDong && c.LoaiHopDong== LoaiHopDong
                        select c;
            if (query.Count() > 0)
            {
                ctx.Dispose();
                return query.First();
            }
            else
                return null;



        }

        public static void Delete(string MaHopDong)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListHopDong { MaHopDong = MaHopDong };
            ctx.ListHopDong.Attach(obj);
            ctx.ListHopDong.Remove(obj);

            ctx.SaveChanges();
            ctx.Dispose();
        }

        public static BHXH.Data.ListHopDong GetData(string MaHopDong)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListHopDong
                        where c.MaHopDong == MaHopDong
                        select c;
            ctx.Dispose();
            return query.ToList().First();
           ;

        }
       // public void STT()
       // { }
    }
}
