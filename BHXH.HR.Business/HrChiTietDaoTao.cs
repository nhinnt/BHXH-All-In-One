using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHXH.HR.Business
{
    public class HrChiTietDaoTao
    {
        public static BindingSource GetData(string data)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = (from a in ctx.HrNhanVien  
                         join b in ctx.HrChiTietDaoTao  on a.MaNhanVien  equals b.MaNhanVien 
                         join c in ctx.ListCMDaoTao on b.MaCMDaoTao equals c.MaCMDaoTao 
                         join d in ctx.ListLHDaoTao on b.MaLHDaoTao equals d.MaLHDaoTao 
                         join e in ctx.ListBangCap on b.MaBangCap equals e.MaBangCap 
                         where a.MaNhanVien.ToString() == data
                         orderby b.STT ascending 
                         select new
                         {
                             b.STT,
                             b.NganhHoc,
                             c.TenCMDaoTao,
                             b.TenTruong,
                             b.ThoiGian,
                             d.TenLHDaoTao,
                             e.TenBangCap,
                             b.XepLoai,
                             b.QuaTrinhDaoTaoID  

                         }
                        ).ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = query;
            return bs;
        }
        public static BHXH.Data.HrChiTietDaoTao  New( string MaNhanVien, int STT, string MaCMDaoTao, string TenTruong, string NganhHoc, 
            string ThoiGian, string MaLHDaoTao, string MaBangCap, string XepLoai)

        {
            //if (MaCMDaoTao == "" || TenCMDaoTao == "" || LoaiCMDaoTao == "")
            //    return null;
            //if (IsExisted(MaCMDaoTao, TenCMDaoTao, LoaiCMDaoTao) != null)
            //    return IsExisted(MaCMDaoTao, TenCMDaoTao, LoaiCMDaoTao);
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.HrChiTietDaoTao n = new Data.HrChiTietDaoTao();
            n.MaNhanVien = new Guid(MaNhanVien) ;
            n.STT = STT;
            n.MaCMDaoTao = MaCMDaoTao;
            n.TenTruong  = TenTruong;
            n.NganhHoc  = NganhHoc;
            n.ThoiGian = ThoiGian;
            n.MaLHDaoTao = MaLHDaoTao;
            n.MaBangCap = MaBangCap;
            n.XepLoai = XepLoai;
            n.QuaTrinhDaoTaoID = Guid.NewGuid();
            ctx.HrChiTietDaoTao.Add(n);

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
        //public static Data.HrChiTietDaoTao IsExisted(string MaChucVu, string TenChucVu)
        //{
        //    BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
        //    var query = from c in ctx.HrChiTietDaoTao
        //                where c.MaChucVu == MaChucVu && c.TenChucVu == TenChucVu
        //                select c;
        //    if (query.Count() > 0)
        //    {
        //        ctx.Dispose();
        //        return query.First();

        //    }
        //    else
        //        return null;



        //}
        public static void Delete(string QuaTrinhDaoTaoID)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.HrChiTietDaoTao  { QuaTrinhDaoTaoID = new Guid(QuaTrinhDaoTaoID) };
            ctx.HrChiTietDaoTao.Attach(obj);
            ctx.HrChiTietDaoTao.Remove(obj);

            ctx.SaveChanges();
            ctx.Dispose();
        }
        public static void Edit(string QuaTrinhDaoTaoID, string MaCMDaoTao,string TenTruong, string NganhHoc, string ThoiGian, string MaLHDaoTao, string XepLoai)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.HrChiTietDaoTao
                        where c.QuaTrinhDaoTaoID.ToString ()  == QuaTrinhDaoTaoID
                        select c;
            BHXH.Data.HrChiTietDaoTao  n = query.First();
            n.MaCMDaoTao  = MaCMDaoTao;
            n.TenTruong = TenTruong;
            n.NganhHoc = NganhHoc;
            n.ThoiGian = ThoiGian;
            n.MaLHDaoTao = MaLHDaoTao;
            n.XepLoai = XepLoai;
            try
            {
                ctx.SaveChanges();
            }
            finally
            { ctx.Dispose(); }
        }
        public static BindingSource GetDataReport(string data)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = (from a in ctx.HrNhanVien
                         join b in ctx.HrChiTietDaoTao on a.MaNhanVien equals b.MaNhanVien
                         join c in ctx.ListCMDaoTao on b.MaCMDaoTao equals c.MaCMDaoTao
                         join d in ctx.ListLHDaoTao on b.MaLHDaoTao equals d.MaLHDaoTao
                         join e in ctx.ListBangCap on b.MaBangCap equals e.MaBangCap
                         where a.MaNhanVien.ToString() == data
                         orderby b.STT ascending
                         select new
                         {
                             a.MaNhanVien,
                             b.STT,
                             b.NganhHoc,
                             c.TenCMDaoTao,
                             b.TenTruong,
                             b.ThoiGian,
                             d.TenLHDaoTao,
                             e.TenBangCap,
                             b.XepLoai,
                             b.QuaTrinhDaoTaoID

                         }
                        ).ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = query;
            return bs;
        }
    }
}
