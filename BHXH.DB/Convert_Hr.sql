----convert database NhanSu_DaNang to table NhanVien in database BHXH----------

-----------------------------------CONVERT TABLE NHANVIEN---------------------------


INSERT INTO [BHXH].[dbo].[NhanVien] (MaNhanVien,TenNhanVien, MaPhongBan,SoHieuNV,GioiTinh,TenKhac,MaCapUy,MaCapUyKiem,
MaChucVu,MaChucDanh,PCChucVu,NgayBoNhiem,NgaySinh,Noisinh,MaTinhQQ,MaQuanQQ,MaPhuongQQ,SoNha,DTNha,DTCoQuan,DTDiDong,Email,DTNguoiNha,
MaDanToc,MaTonGiao,MaThanhPhanGD,NgheTruocTD,NgayTD,NgayCQ,CoQuanTD,NgayCM,NgayDang,NgayDangCT,MaChiBo,NgayTCXH,NgayNhapNgu,NgayXuatNgu,QuanHam,
MaTDVanHoa,MaTDDaoTao,MaTDLLCT,MaNgoaiNgu,MaTDNgoaiNgu,CVDangLam,MaNgach,Bac,HSL,DHDuocPhong,SoTruongCT,CVLamLN,
KhenThuong,KyLuat,SucKhoe,ChieuCao,CanNang,NhomMau,SoCMND,MaLoaiTB,GDLietSy,TuDay,CheDoCu,TCNuocNgoai,TNNuocNgoai,SoBHXH,TheBHYT,MaNoiKCB,
TaiKhoanATM,MaNganHang,NgayCMND,NoiCMND,NgayNangLuong,DaNLTruocTH,AnhNV)
-------------
SELECT NEWID(), TenNhanVien, 
   MaPhongBan =(select MaPhongBan From NhanSu_DaNang.dbo.DMPhongBan p where p.IDPhongBan= DSNhanVien.IDPhongBan),
   SoHieuNV,Gioitinh,TenKhac,
   MaCapUy =(select MaChucVu From NhanSu_DaNang.dbo.DMChucVuDang  p where p.IDChucVu   = DSNhanVien.IDCapUy ),
   MaCapUyKiem =(select MaChucVu From NhanSu_DaNang.dbo.DMChucVuDang  p where p.IDChucVu   = DSNhanVien.IDCapUy ),
   MaChucVu=(select MaChucVu From NhanSu_DaNang.dbo.DMChucVu   p where p.IDChucVu  = DSNhanVien.IDChucVu  ),
   MaChucDanh=(select MaChucDanh From NhanSu_DaNang.dbo.DMChucDanh    p where p.IDChucDanh   = DSNhanVien.IDChucDanh ),
   PCChucVu,NgayBoNhiem,NgaySinh,NoiSinh,  
   MaTinhQQ=(select MaTinh From NhanSu_DaNang.dbo.DMTinh p where p.IDTinh    = DSNhanVien.IDTinhQQ),
   MaQuanQQ=(select MaQuan  From NhanSu_DaNang.dbo.DMQuan  p where p.IDQuan  = DSNhanVien.IDQuanQQ),
   MaPhuongQQ=(select MaQuan  From NhanSu_DaNang.dbo.DMQuan  p where p.IDQuan  = DSNhanVien.IDQuanQQ),
   SoNha,DTNha,DTCoQuan,DTDiDong,Email,DTNguoiNha,
   MaDanToc=(select MaDanToc  From NhanSu_DaNang.dbo.DMDanToc   p where p.IDDanToc   = DSNhanVien.IDDanToc),
   MaTonGiao=(select MaTonGiao  From NhanSu_DaNang.dbo.DMTonGiao  p where p.IDTonGiao = DSNhanVien.IDTonGiao),
   MaThanhPhanGD=(select MaThanhPhanGD  From NhanSu_DaNang.dbo.DMThanhPhanGD  p where p.IDThanhPhanGD  = DSNhanVien.IDThanhPhanGD),
   Nghe_TruocTD,Ngay_TD,Ngay_CQ,CoQuan_TD,Ngay_CM,Ngay_Dang,Ngay_DangCT,
   MaChiBo=(select MaChiBo  From NhanSu_DaNang.dbo.DMChiBo   p where p.IDChiBo   = DSNhanVien.IDChiBo ),
   Ngay_TCXH,NgayNhapNgu,NgayXuatNgu,QuanHam,
   MaTDVanHoa=(select MaTDVanHoa  From NhanSu_DaNang.dbo.DMTDVanHoa   p where p.IDTDVanHoa = DSNhanVien.IDTDVanHoa),
   MaTDDaoTao=(select MaTDDaoTao  From NhanSu_DaNang.dbo.DMTDDaoTao    p where p.IDTDDaoTao  = DSNhanVien.IDTDDaoTao),
   MaTDLLCT=(select MaTDLLCT  From NhanSu_DaNang.dbo.DMTDLLCT  p where p.IDTDLLCT  = DSNhanVien.IDTDLLCT),
   MaNgoaiNgu=(select MaNgoaiNgu  From NhanSu_DaNang.dbo.DMNgoaiNgu   p where p.IDNgoaiNgu   = DSNhanVien.IDNgoaiNgu),
   MaTDNgoaiNgu=(select MaTDNgoaiNgu  From NhanSu_DaNang.dbo.DMTDNgoaiNgu  p where p.IDTDNgoaiNgu  = DSNhanVien.IDTDNgoaiNgu),
   CVDangLam,
   MaNgach=(select MaNgach  From NhanSu_DaNang.dbo.ThangBangLuong  p where p.IDNgach = DSNhanVien.IDNgach),
   Bac,HSL,DHDuocPhong,SoTruongCT,CVLamLN,KhenThuong,KyLuat,SucKhoe,ChieuCao,CanNang,NhomMau,SoCMND,
   MaLoaiTB=(select MaLoaiTB  From NhanSu_DaNang.dbo.DMLoaiTB  p where p.IDLoaiTB  = DSNhanVien.IDLoaiTB),
   GDLietSy,TuDay,CheDoCu,TCNuocNgoai,TNNuocNgoai,SoBHXH,TheBHYT,
   MaNoiKCB=(select MaNoiKCB  From NhanSu_DaNang.dbo.DMNoiKCB  p where p.IDNoiKCB  = DSNhanVien.IDKCB),
   TaiKhoanATM,
   MaNganHang=(select MaNganHang  From NhanSu_DaNang.dbo.DMNganHang p where p.IDNganHang  = DSNhanVien.IDNganHang),
   Ngay_CMND,Noi_CMND,NgayNangLuong,DaNLTruocTH,AnhNV
 FROM [NhanSu_DaNang].[dbo].DSNhanVien 
    
      
GO
--------------CONVERT TABLE QuaTrinhCongTac--------------------
use BHXH
delete QuaTrinhCongTac 
INSERT INTO [BHXH].[dbo].QuaTrinhCongTac (MaNhanVien,STT,ThoiGian,CongViec)
-------------
SELECT c.MaNhanVien,A.STT,A.ThoiGian,A.CongViec 
FROM (([NhanSu_DaNang].dbo.QuaTrinhCongTac a inner join [NhanSu_DaNang].dbo.DSNhanVien b on a.IDNhanVien =b.IDNhanVien )
 inner join BHXH.dbo.NhanVien c  on b.TenNhanVien   =c.TenNhanVien and b.SoHieuNV =c.SoHieuNV) 
         
--------------CONVERT QUÁ TRÌNH LƯƠNG---------------------------------

delete BHXH.dbo.QuaTrinhLuong
INSERT INTO [BHXH].[dbo].QuaTrinhLuong (MaNhanVien,STT,Loai,TuThang,DenThang,MucLuong,HSL,PCChucVu,PCThamNien,PCDocHai,PCTrachNhiem,PCKhuVuc,CongViec)
-------------
SELECT c.MaNhanVien,STT,Loai,TuThang,DenThang,MucLuong,a.HSL,a.PCChucVu,PCThamNien,PCDocHai,PCTrachNhiem,PCKhuVuc,CongViec 
FROM (([NhanSu_DaNang].dbo.QuaTrinhLuong  a inner join [NhanSu_DaNang].dbo.DSNhanVien b on a.IDNhanVien =b.IDNhanVien )
 inner join BHXH.dbo.NhanVien c  on b.TenNhanVien   =c.TenNhanVien and b.SoHieuNV =c.SoHieuNV) 


--------------CONVERT QUÁ TRÌNH KHEN THƯỞNG KỸ LUẬT---------------------------------

delete BHXH.dbo.KhenThuongKyLuat  
INSERT INTO [BHXH].[dbo].KhenThuongKyLuat (MaNhanVien,STT,MaKTKL,Nam,GhiChu,MaPhongBan)
-------------
SELECT c.MaNhanVien,STT,a.IDKTKL,a.Nam,a.GhiChu,
MaPhongBan=(select MaPhongBan From NhanSu_DaNang.dbo.DMPhongBan p where p.IDPhongBan  = a.IDPhongBan) 
FROM (([NhanSu_DaNang].dbo.KhenThuongKyLuat a inner join [NhanSu_DaNang].dbo.DSNhanVien b on a.IDNhanVien =b.IDNhanVien )
 inner join BHXH.dbo.NhanVien c  on b.TenNhanVien   =c.TenNhanVien and b.SoHieuNV =c.SoHieuNV) 
----test
SELECT a.*,b.*
FROM bhxh.DBO.NhanVien a inner join bhxh.dbo.KhenThuongKyLuat  b on  a.manhanvien=b.manhanvien
where a.tennhanvien like N'%ĐInh văn hiệp%'

--------------CONVERT QUÁ TRÌNH THAM GIA BHXH---------------------------------

delete BHXH.dbo.QuaTrinhBHXH   
INSERT INTO [BHXH].[dbo].QuaTrinhBHXH (MaNhanVien,STT,Loai,TuThang,DenThang,SoThang,MucLuong,HSL,PCChucVu,PCThamNien,PCKhuVuc,CongViec)
-------------
SELECT c.MaNhanVien,STT,Loai,TuThang,DenThang,SoThang,MucLuong,a.HSL,a.PCChucVu,PCThamNien,PCKhuVuc,CongViec
FROM (([NhanSu_DaNang].dbo.QuaTrinhBHXH  a inner join [NhanSu_DaNang].dbo.DSNhanVien b on a.IDNhanVien =b.IDNhanVien )
 inner join BHXH.dbo.NhanVien c  on b.TenNhanVien   =c.TenNhanVien and b.SoHieuNV =c.SoHieuNV) 


--------------CONVERT QUAN HỆ GIA ĐÌNH---------------------------------

delete BHXH.dbo.QuanHeGiaDinh    
INSERT INTO [BHXH].[dbo].QuanHeGiaDinh (MaNhanVien,STT,MaQuanHeGD,HoTen,NamSinh,ChiTiet)
-------------
SELECT c.MaNhanVien,STT,
MaQuanHeHD=(select MaQuanHeGD From NhanSu_DaNang.dbo.DMQuanHeGD p where p.IDQuanHeGD = a.IDQuanHeGD),  
HoTen,NamSinh,ChiTiet 
FROM (([NhanSu_DaNang].dbo.QuanHeGiaDinh  a inner join [NhanSu_DaNang].dbo.DSNhanVien b on a.IDNhanVien =b.IDNhanVien )
 inner join BHXH.dbo.NhanVien c  on b.TenNhanVien   =c.TenNhanVien and b.SoHieuNV =c.SoHieuNV) 


--------------CONVERT DANH MỤC THANG BẢNG LƯƠNG---------------------------------

delete BHXH.dbo.ThangBangLuong     
INSERT INTO [BHXH].[dbo].ThangBangLuong (MaNgach,TenNgach,ThangNL,TongBac,Bac01,Bac02,Bac03,Bac04,Bac05,Bac06,Bac07,Bac08,Bac09,Bac10,Bac11,Bac12)
-------------
SELECT  MaNgach, TenNgach,ThangNL,TongBac,Bac01,Bac02,Bac03,Bac04,Bac05,Bac06,Bac07,Bac08,Bac09,Bac10,Bac11,Bac12
FROM [NhanSu_DaNang].dbo.ThangBangLuong 


--------------CONVERT DANH MỤC TỈ LỆ ĐÓNG BHXH---------------------------------

delete BHXH.dbo.TyLeBHXH      
INSERT INTO [BHXH].[dbo].TyleBHXH (NgayTu,NgayDen ,TyLeBHTN,TyLeBHTNNLD ,TyLeBHXH,TyLeBHXHNLD,TyLeBHYT ,TyLeBHYTNLD ,TyLeKPCD ,TyLeKPCDNLD)
-------------
SELECT  NgayTu,NgayDen ,TyLeBHTN,TyLeBHTNNLD ,TyLeBHXH,TyLeBHXHNLD,TyLeBHYT ,TyLeBHYTNLD ,TyLeKPCD ,TyLeKPCDNLD
FROM [NhanSu_DaNang].dbo.TyLeBHXH  


--------------CONVERT DANH MỤC HỆ SỐ LƯƠNG TĂNG THÊM--------------------------------

delete BHXH.dbo.HSLTangThem       
INSERT INTO [BHXH].[dbo].HSLTangThem (Nam,Thang01 ,Thang02 ,Thang03 ,Thang04 ,Thang05 ,Thang06 ,Thang07 ,Thang08 ,Thang09 ,Thang10 ,Thang11 ,Thang12 )
-------------
SELECT  Nam,Thang01 ,Thang02 ,Thang03 ,Thang04 ,Thang05 ,Thang06 ,Thang07 ,Thang08 ,Thang09 ,Thang10 ,Thang11 ,Thang12 
FROM [NhanSu_DaNang].dbo.HSLTangThem 


--------------CONVERT DANH MỤC LƯƠNG TỐI THIỂU--------------------------------

delete BHXH.dbo.LuongToiThieu        
INSERT INTO [BHXH].[dbo].LuongToiThieu (NgayTu,NgayDen,MucLuong)
-------------
SELECT  NgayTu,NgayDen,MucLuong
FROM [NhanSu_DaNang].dbo.LuongToiThieu 


--------------CONVERT DANH MỤC NGÀY CÔNG--------------------------------

delete BHXH.dbo.NgayCong         
INSERT INTO [BHXH].[dbo].NgayCong (Nam,Thang01 ,Thang02 ,Thang03 ,Thang04 ,Thang05 ,Thang06 ,Thang07 ,Thang08 ,Thang09 ,Thang10 ,Thang11 ,Thang12)
-------------
SELECT  Nam,Thang01 ,Thang02 ,Thang03 ,Thang04 ,Thang05 ,Thang06 ,Thang07 ,Thang08 ,Thang09 ,Thang10 ,Thang11 ,Thang12
FROM [NhanSu_DaNang].dbo.NgayCong 
