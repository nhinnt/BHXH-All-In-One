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
        public static BHXH.Data.ListChucVuDang  GetChucVuDang(string MaChucVuDang)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListChucVuDang 
                        where c.MaChucVu.ToString() == MaChucVuDang.ToString()
                        select c;

            return query.ToList().First();

        }
        public static BHXH.Data.ListChucVu GetChucVu(string MaChucVu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListChucVu
                        where c.MaChucVu.ToString() == MaChucVu.ToString()
                        select c;

            return query.ToList().First();

        }
        public static BHXH.Data.ListChucDanh GetChucDanh(string MaChucDanh)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListChucDanh 
                        where c.MaChucDanh.ToString() == MaChucDanh.ToString()
                        select c;

            return query.ToList().First();

        }
        public static BHXH.Data.ListTinh  GetTenTinh(string MaTinh)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTinh 
                        where c.MaTinh.ToString() == MaTinh.ToString()
                        select c;

            return query.ToList().First();

        }
        public static BHXH.Data.ListQuanHuyen GetTenQuan(string IDQuanHuyen)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListQuanHuyen 
                        where c.QuanHuyenID.ToString() == IDQuanHuyen.ToString()
                        select c;

            return query.ToList().First();

        }
        public static BHXH.Data.ListXaPhuong  GetTenPhuong(string IDXaPhuong)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListXaPhuong 
                        where c.XaPhuongID.ToString() == IDXaPhuong.ToString()
                        select c;

            return query.ToList().First();

        }
        public static BHXH.Data.ListDanToc  GetTenDanToc(string MaDanToc)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListDanToc 
                        where c.MaDanToc.ToString() == MaDanToc.ToString()
                        select c;

            return query.ToList().First();

        }
        public static BHXH.Data.ListTonGiao  GetTenTonGiao(string MaTonGiao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTonGiao
                        where c.MaTonGiao.ToString() == MaTonGiao.ToString()
                        select c;

            return query.ToList().First();

        }
        public static BHXH.Data.ListChiBo  GetTenChiBo(string MaChiBo)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListChiBo
                        where c.MaChiBo.ToString() == MaChiBo.ToString()
                        select c;

            return query.ToList().First();

        }
        public static BHXH.Data.ListTDVanHoa  GetTenTDVH(string MaTDVH)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDVanHoa 
                        where c.MaTDVanHoa.ToString() == MaTDVH.ToString()
                        select c;

            return query.ToList().First();

        }
        public static BHXH.Data.ListTDDaoTao  GetTenTDDT(string MaTDDT)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDDaoTao 
                        where c.MaTDDaoTao .ToString() == MaTDDT.ToString()
                        select c;

            return query.ToList().First();

        }
        public static BHXH.Data.ListTDLLCT  GetTenTDLLCT(string MaTDLLCT)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDLLCT 
                        where c.MaTDLLCT.ToString() == MaTDLLCT.ToString()
                        select c;

            return query.ToList().First();

        }
        public static BHXH.Data.ListNgoaiNgu GetTenNgoaiNgu(string MaNgoaiNgu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListNgoaiNgu
                        where c.MaNgoaiNgu.ToString() == MaNgoaiNgu.ToString()
                        select c;

            return query.ToList().First();

        }
        public static BHXH.Data.ListTDNgoaiNgu GetTenTDNgoaiNgu(string MaTDNgoaiNgu)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListTDNgoaiNgu
                        where c.MaTDNgoaiNgu.ToString() == MaTDNgoaiNgu.ToString()
                        select c;

            return query.ToList().First();

        }
        public static BHXH.Data.HrThangBangLuong  GetTenNgach(string MaNgach)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.HrThangBangLuong 
                        where c.MaNgach.ToString() == MaNgach.ToString()
                        select c;

            return query.ToList().First();

        }
        public static BHXH.Data.ListLoaiTB  GetTenLoaiTB(string MaLoaiTB)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListLoaiTB 
                        where c.MaLoaiTB.ToString() == MaLoaiTB.ToString()
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
       
    }
}
