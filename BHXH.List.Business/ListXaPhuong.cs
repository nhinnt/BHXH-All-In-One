using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListXaPhuong    
    {
        public static IEnumerable<BHXH.Data.ListXaPhuong> GetAll(string XaPhuong)
        { int a = int.Parse(XaPhuong);
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListXaPhuong> list;

            var query = from c in ctx.ListXaPhuong
                        where c.QuanHuyenID == a
                        select c;

            list = query.ToList();

            return list;
        }

        //public static BHXH.Data.ListXaPhuong New(int XaPhuongID, string MaXaPhuong, string TenXaPhuong, int QuanHuyenID)

        //{
        //if (MaXaPhuong == "" || TenXaPhuong == "" || XaPhuongID ==0 || QuanHuyenID == 0)
        //    return null;
        //if (IsExisted( XaPhuongID, MaXaPhuong, TenXaPhuong, QuanHuyenID) != null)
        //    return IsExisted(XaPhuongID, MaXaPhuong, TenXaPhuong, QuanHuyenID);
        //  BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
        //BHXH.Data.ListXaPhuong n = new Data.ListXaPhuong();
        //n.XaPhuongID = XaPhuongID;
        //n.MaXaPhuong = MaXaPhuong;
        //n.TenXaPhuong = TenXaPhuong;
        //n.QuanHuyenID = QuanHuyenID;

        //ctx.ListXaPhuong.Add(n);

        //try
        //{
        //    ctx.SaveChanges();
        //    return n;
        //}
        //catch (Exception)
        //{
        //    return null;
        //}

        //finally
        //{ }



        //}
        //public static void Edit(int XaPhuongID, string MaXaPhuong, string TenXaPhuong, int QuanHuyenID)
        //{
        //    BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
        //    var query = from c in ctx.ListXaPhuong
        //                where c.XaPhuongID == XaPhuongID
        //                select c;
        //    BHXH.Data.ListXaPhuong n = query.First();
        //    n.MaXaPhuong = MaXaPhuong;
        //    n.TenXaPhuong = TenXaPhuong;

        //    try
        //    {
        //        ctx.SaveChanges();
        //    }
        //    finally
        //    { }
        //}
        //public static Data.ListXaPhuong IsExisted(int XaPhuongID, string MaXaPhuong, string TenXaPhuong, int QuanHuyenID)
        //{
        //    BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
        //    var query = from c in ctx.ListXaPhuong
        //                where c.XaPhuongID == XaPhuongID && c.TenXaPhuong == TenXaPhuong
        //                select c;
        //    if (query.Count() > 0)
        //        return query.First();
        //    else
        //        return null;



        //}

        //public static void Delete(int XaPhuongID)
        //{
        //    BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
        //    Data.ListXaPhuong obj = GetData(XaPhuongID);

        //    ctx.ListXaPhuong.Attach(obj);
        //    ctx.ListXaPhuong.Remove(obj);

        //    ctx.SaveChanges();


        //}

        //public static BHXH.Data.ListXaPhuong GetData(int XaPhuongID)
        //{
        //    BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
        //    var query = from c in ctx.ListXaPhuong
        //                where c.XaPhuongID == XaPhuongID
        //                select c;

        //    return query.ToList().First();


        //}
        //public void STT()
        //{ }
    }
}
