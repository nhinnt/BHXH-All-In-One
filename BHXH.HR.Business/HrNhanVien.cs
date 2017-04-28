using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static BHXH.Data.HrNhanVien New(string GioiTinh)

        {
            //if (MaChucVu == "" || TenChucVu == "")
            //    return null;
            //if (IsExisted(MaChucVu, TenChucVu) != null)
            //    return IsExisted(MaChucVu, TenChucVu);
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.HrNhanVien n = new Data.HrNhanVien();
            n.MaPhongBan = GioiTinh;
            //n.TenChucVu = TenChucVu;
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

        public static void Edit(string MaNhanVien, string TenNhanVien, string SoHieuNV, string GioiTinh, string TenKhac, string MaCapUy, string MaCapUyKiem,
            string MaChucVu, string MaChucDanh, Decimal PCCV, DateTime NgayBoNhiem, DateTime NgaySinh, string SoNha, string DTNha, string DTCoQuan,
            string DTDiDong, string Email, string DTNguoiNha, string TenNguoiNha, string MaDanToc, string MaTonGiao, string MaTPGiaDinh,
            string NgheTruocTD, DateTime NgayTD, DateTime NgayCQ, string CoQuanTD, DateTime NgayCM, DateTime NgayDang, DateTime NgayDangCT,
            DateTime NgayTCXH, DateTime NgayNhapNgu, DateTime NgayXuatNgu, string QuanHam, string MaTDVanHoa, string MaTDDaoTao, string MaNgoaiNgu,
            string MaTDNgoaiNgu, string CVDangLam, string MaNgach, string Bac, Decimal HSL, string DHDuocPhong, string SoTruongCT, string CVLamLN,
            string KhenThuong, string KyLuat, string SucKhoe, string ChieuCao, string CanNang, string NhomMau, string SoCMND, string MaLoaiTB, Boolean GDLietSy)
        {
            
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.HrNhanVien
                        where c.MaNhanVien.ToString ()  == MaNhanVien //|| c.LoaiKTKL == LoaiKTKL
                        select c;
            BHXH.Data.HrNhanVien n = query.First();
            n.TenNhanVien   = TenNhanVien;
            n.SoHieuNV = SoHieuNV;
            n.GioiTinh  = GioiTinh;
            n.TenKhac = TenKhac ;
            n.MaCapUy = MaCapUy;
            n.MaCapUyKiem = MaCapUyKiem;
            n.MaChucVu = MaChucVu;
            n.MaChucDanh = MaChucDanh;
            n.PCChucVu = PCCV;
            n.NgayBoNhiem = NgayBoNhiem;
            n.NgaySinh = NgaySinh;
            n.SoNha = SoNha;
            n.DTNha = DTNha;
            n.DTCoQuan = DTCoQuan;
            n.DTDiDong = DTDiDong;
            n.Email = Email;
            n.DTNguoiNha = DTNguoiNha;
            n.TenNguoiNha = TenNguoiNha;
            n.MaDanToc  = MaDanToc;
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
        
            try
            {
                ctx.SaveChanges();
            }
            finally
            { }

        }
        //public static Data.HrNhanVien  IsExisted(string GioiTinh)
        //{
        //    BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
        //    var query = from c in ctx.HrNhanVien 
        //                where c.GioiTinh  == MaChucVu && c.TenChucVu == TenChucVu
        //                select c;
        //    if (query.Count() > 0)
        //        return query.First();
        //    else
        //        return null;



        //}

    }
}
