using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHXH.HR.Business
{
    public class HrQuaTrinhLuong
    {
        public static IEnumerable<BHXH.Data.HrQuaTrinhLuong> GetData(string code)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.HrQuaTrinhLuong> list;

            var query = (from c in ctx.HrQuaTrinhLuong
                         where c.MaNhanVien.ToString() == code
                         orderby c.STT ascending 
                         select c);

            list = query.ToList();
            return list;
        }
        public static BHXH.Data.HrQuaTrinhLuong New(string MaNhanVien, int STT, string Loai, string TuThang, string DenThang, int SoThang, Decimal? MucLuong,
            Decimal?  PCChucVu, Decimal? PCThamNien, Decimal? PCDocHai, Decimal? PCTrachNhiem, Decimal? PCKhuVuc, string CongViec)

        {

            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.HrQuaTrinhLuong n = new Data.HrQuaTrinhLuong();
            n.MaNhanVien = new Guid(MaNhanVien);
            n.STT = STT;
            n.Loai=Loai;
            
            n.TuThang  = TuThang;
            n.DenThang = DenThang;
            n.SoThang = SoThang;
            n.MucLuong = MucLuong;
            n.PCChucVu = PCChucVu;
            n.PCThamNien = PCThamNien;
            n.PCDocHai = PCDocHai;
            n.PCTrachNhiem = PCTrachNhiem;
            n.PCKhuVuc = PCKhuVuc;
            n.CongViec = CongViec;
            n.QuaTrinhLuongID = Guid.NewGuid();
            ctx.HrQuaTrinhLuong.Add(n);

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
    }
}
