using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHXH.HR.Business
{
    public class HrQuanHeGiaDinh
    {
        public static BindingSource GetData(string data)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = (from a in ctx.HrQuanHeGiaDinh
                         join b in ctx.ListQuanHeGD  on a.MaQuanHeGD  equals b.MaQuanHeGD 
                         where a.MaNhanVien.ToString() == data
                         orderby a.STT ascending
                         select new
                         {
                             a.STT,
                             b.TenQuanHeGD,
                             a.HoTen,
                             a.NamSinh,
                             a.ChiTiet,
                             a.QuanHeGiaDinhID
                         }
                        ).ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = query;
            return bs;
        }
        public static void Delete(string QuanHeGiaDinhID)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.HrQuanHeGiaDinh  { QuanHeGiaDinhID = new Guid(QuanHeGiaDinhID) };
            ctx.HrQuanHeGiaDinh.Attach(obj);
            ctx.HrQuanHeGiaDinh.Remove(obj);

            ctx.SaveChanges();
            ctx.Dispose();
        }
        public static BHXH.Data.HrQuanHeGiaDinh New(string MaNhanVien, int STT, string MaQuanHeGD, string HoTen, string NamSinh, string ChiTiet)

        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.HrQuanHeGiaDinh n = new Data.HrQuanHeGiaDinh();
            n.MaNhanVien = new Guid(MaNhanVien);
            n.STT = STT;
            n.MaQuanHeGD  = MaQuanHeGD;
            n.HoTen = HoTen;
            n.NamSinh = NamSinh;
            n.QuanHeGiaDinhID  = Guid.NewGuid();
            ctx.HrQuanHeGiaDinh.Add(n);

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
        public static void Edit(string QuanHeGiaDinhID, string MaQuanHeGD, string HoTen, string NamSinh, string ChiTiet)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.HrQuanHeGiaDinh 
                        where c.QuanHeGiaDinhID.ToString() == QuanHeGiaDinhID
                        select c;
            BHXH.Data.HrQuanHeGiaDinh n = query.First();
            n.MaQuanHeGD  = MaQuanHeGD;
            n.HoTen = HoTen;
            n.NamSinh = NamSinh;
            n.ChiTiet = ChiTiet;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { ctx.Dispose(); }
        }
    }
}
