using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BHXH.HR.Business
{
    public class HrNhanVien
    {
        public static BHXH.Data.HrNhanVien  GetNhanVien(string MaNhanVien)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.HrNhanVien
                        where c.MaNhanVien.ToString ()  == MaNhanVien.ToString()
                        select c;

            return query.ToList().First();

        }
       

        public static BHXH.Data.HrNhanVien  GetAnhNV(string MaNhanVien)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.HrNhanVien 
                        where c.MaNhanVien.ToString() == MaNhanVien.ToString()
                        select c;

            return query.ToList().First();

        }
        public static BHXH.Data.HrNhanVien New(string TenNhanVien, string MaPhongBan, string MaBoPhan)

        {
          
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.HrNhanVien n = new Data.HrNhanVien();
            n.MaNhanVien = Guid.NewGuid();
            n.TenNhanVien = TenNhanVien;
            n.MaPhongBan = MaPhongBan;
            n.MaBoPhan = MaBoPhan;
            ctx.HrNhanVien.Add(n);

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
        public static void Delete(string MaNhanVien)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var DeleteNV = (from c in ctx.HrNhanVien 
                                where c.MaNhanVien.ToString () == MaNhanVien
                                select c).SingleOrDefault();

            //I am trying to delete the record like below
            ctx.HrNhanVien.Remove(DeleteNV);
            ctx.SaveChanges();
        }


        public static void Edit(string MaNhanVien, string TenNhanVien, string SoHieuNV, string GioiTinh, string TenKhac, string MaCapUy, string MaCapUyKiem, string MaChucVu, string MaChucDanh, Decimal PCChucVu, DateTime? NgayBoNhiem,
            DateTime? NgaySinh, string MaTinhQQ, Decimal? QuanHuyenIDQQ, Decimal? XaPhuongIDQQ, string MaTinhTQ, Decimal? QuanHuyenIDTQ, Decimal? XaPhuongIDTQ, string SoNha, string DTNha, string DTCoQuan,
            string DTDiDong, string Email, string DTNguoiNha, string TenNguoiNha, string MaDanToc, string MaTonGiao, string MaTPGiaDinh, string NgheTruocTD, DateTime? NgayTD, DateTime? NgayCQ,
            string CoQuanTD, DateTime? NgayCM, DateTime? NgayDang, DateTime? NgayDangCT, DateTime? NgayTCXH, DateTime? NgayNhapNgu, DateTime? NgayXuatNgu, string QuanHam, string MaTDVanHoa, string MaTDDaoTao, string MaTDLLCT, string MaNgoaiNgu,
            string MaTDNgoaiNgu, string CVDangLam, string MaNgach, string Bac, Decimal? HSL, string DHDuocPhong, string SoTruongCT, string CVLamLN, string KhenThuong, string KyLuat, string SucKhoe, string ChieuCao, string CanNang,
            string NhomMau, string SoCMND, string MaLoaiTB, Boolean? GDLietSy, string SoBHXH, string TheBHYT, string TaiKhoanATM, DateTime? NgayNangLuong, Boolean DaLNTruocHan, DateTime? NgayCMND, string NoiCMND, string MaTinhKCB, string MaNoiKCB)

        {

            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.HrNhanVien
                        where c.MaNhanVien.ToString() == MaNhanVien //|| c.LoaiKTKL == LoaiKTKL
                        select c;
            BHXH.Data.HrNhanVien n = query.First();
            n.TenNhanVien = TenNhanVien;
            n.SoHieuNV = SoHieuNV;
            n.GioiTinh = GioiTinh;
            n.TenKhac = TenKhac;
            n.MaCapUy = MaCapUy;
            n.MaCapUyKiem = MaCapUyKiem;
            n.MaChucVu = MaChucVu;
            n.MaChucDanh = MaChucDanh;
            n.PCChucVu = PCChucVu;
            n.NgayBoNhiem = NgayBoNhiem;
            n.NgaySinh = NgaySinh;
            n.MaTinhQQ = MaTinhQQ;
            n.QuanHuyenIDQQ = QuanHuyenIDQQ;
            n.XaPhuongIDQQ = XaPhuongIDQQ;
            n.MatinhTQ = MaTinhTQ;
            n.QuanHuyenIDTQ = QuanHuyenIDTQ;
            n.XaPhuongIDTQ = XaPhuongIDTQ;
            n.SoNha = SoNha;
            n.DTNha = DTNha;
            n.DTCoQuan = DTCoQuan;
            n.DTDiDong = DTDiDong;
            n.Email = Email;
            n.DTNguoiNha = DTNguoiNha;
            n.TenNguoiNha = TenNguoiNha;
            n.MaDanToc = MaDanToc;
            n.MaTonGiao = MaTonGiao;
            n.MaThanhPhanGD = MaTPGiaDinh;
            n.NgheTruocTD = NgheTruocTD;
            n.NgayTD = NgayTD;
            n.NgayCQ = NgayCQ;
            n.CoQuanTD = CoQuanTD;
            n.NgayCM = NgayCM;
            n.NgayDang = NgayDang;
            n.NgayDangCT = NgayDangCT;
            n.NgayTCXH = NgayTCXH;
            n.NgayNhapNgu = NgayNhapNgu;
            n.NgayXuatNgu = NgayXuatNgu;
            n.QuanHam = QuanHam;
            n.MaTDVanHoa = MaTDVanHoa;
            n.MaTDDaoTao = MaTDDaoTao;
            n.MaTDLLCT = MaTDLLCT;
            n.MaNgoaiNgu = MaNgoaiNgu;
            n.MaTDNgoaiNgu = MaTDNgoaiNgu;
            n.CVDangLam = CVDangLam;
            n.MaNgach = MaNgach;
            n.Bac = Bac;
            n.HSL = HSL;
            n.DHDuocPhong = DHDuocPhong;
            n.SoTruongCT = SoTruongCT;
            n.CVLamLN = CVLamLN;
            n.KhenThuong = KhenThuong;
            n.KyLuat = KyLuat;
            n.SucKhoe = SucKhoe;
            n.ChieuCao = ChieuCao;
            n.CanNang = CanNang;
            n.NhomMau = NhomMau;
            n.SoCMND = SoCMND;
            n.MaLoaiTB = MaLoaiTB;
            n.GDLietSy = GDLietSy;

            n.SoBHXH = SoBHXH;
            n.TheBHYT = TheBHYT;
            n.TaiKhoanATM = TaiKhoanATM;
            n.NgayNangLuong = NgayNangLuong;
            n.DaNLTruocTH = DaLNTruocHan;
            n.NgayCMND = NgayCMND;
            n.NoiCMND = NoiCMND;
            n.MaTinhKCB = MaTinhKCB;
            n.MaNoiKCB = MaNoiKCB;
            try
            {

                ctx.SaveChanges();
            }
            finally
            {
                ctx.Dispose();
            }

        }
        public static IEnumerable<BHXH.Data.HrNhanVien> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.HrNhanVien > list;

            var query = from c in ctx.HrNhanVien  select c;

            list = query.ToList();
            return list;
        }
        public static IEnumerable<BHXH.Data.HrNhanVien> GetNhanVienPhongBan(string MaPhongBan)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.HrNhanVien> list;

            var query = from c in ctx.HrNhanVien
                        where c.MaPhongBan ==MaPhongBan
                        select c;

            list = query.ToList();
            return list;
        }
       
        public static IEnumerable<BHXH.Data.HrNhanVien> GetNhanVienBangCap(string MaBangCap)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.HrNhanVien> list;

            var query = from c in ctx.HrNhanVien
                        where c.MaTDDaoTao   == MaBangCap
                        select c;

            list = query.ToList();
            return list;
        }
        public static void EditNhanVienPhongBan(string MaNhanVien, string TenNhanVien, string MaPhongBan, string MaBoPhan)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.HrNhanVien 
                        where c.MaNhanVien.ToString() == MaNhanVien //|| c.MaPhongBan == MaPhongBan
                        select c;
            BHXH.Data.HrNhanVien  n = query.First();
            n.TenNhanVien  = TenNhanVien;
            n.MaPhongBan = MaPhongBan;
            n.MaBoPhan = MaBoPhan;
            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static BindingSource GetNhanVienSearchOnRequest()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = (from a in ctx.HrNhanVien
                         join b in ctx.ListPhongBan on a.MaPhongBan equals b.MaPhongBan
                         join c in ctx.ListChucVu on a.MaChucVu equals c.MaChucVu
                         join d in ctx.HrChiTietDaoTao on a.MaNhanVien equals d.MaNhanVien
                         join e in ctx.ListLHDaoTao on d.MaLHDaoTao equals e.MaLHDaoTao
                         join f in ctx.ListBangCap on d.MaBangCap equals f.MaBangCap
                         join g in ctx.ListCMDaoTao on d.MaCMDaoTao equals g.MaCMDaoTao
                         //orderby b.STT ascending
                         select new
                         {
                             a.TenNhanVien,
                             b.MaPhongBan,
                             b.TenPhongBan,
                             a.CVDangLam,
                             c.MaChucVu,
                             c.TenChucVu,
                             d.MaCMDaoTao,
                             g.TenCMDaoTao,
                             d.MaBangCap,
                             f.TenBangCap ,
                             d.MaLHDaoTao ,
                             e.TenLHDaoTao,
                             d.ThoiGian,
                             d.TenTruong,
                             d.XepLoai,   
                             d.STT    
                             }
                            ).ToList();

                BindingSource bs = new BindingSource();
                bs.DataSource = query;
                return bs;
            }
        }
}
