USE [BHXH]
GO

/****** Object:  Table [dbo].[DSNhanVien]    Script Date: 04/13/2017 08:31:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] uniqueidentifier NOT NULL PRIMARY KEY,
	[TenNhanVien] [nvarchar](255) NULL,
	[MaPhongBan] [numeric](20, 0) NULL,  --mã phòng ban
	[SoHieuNV] [nvarchar](20) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[TenKhac] [nvarchar](255) NULL,
	[MaCapUy] [numeric](20, 0) NULL,   --mã chức vụ Đảng
	[MaCapUyKiem] [numeric](20, 0) NULL,--mã chức vụ Đảng kiêm
	[MaChucVu] [numeric](20, 0) NULL,  --Chức vụ 
	[MaChucDanh] [numeric](20, 0) NULL,-- Chức danh
	[PCChucVu] [numeric](6, 3) NULL, 
	[NgayBoNhiem] [datetime] NULL,
	[NgaySinh] [datetime] NULL,
	[NoiSinh] [nvarchar](100) NULL,
	[MaTinhQQ] [numeric](20, 0) NULL,-- mã tỉnh quê quán
	[MaQuanQQ] [numeric](20, 0) NULL,--mã quận quê quán
	[MaphuongQQ] [numeric](20, 0) NULL,--mã phường quê quán
	[MatinhTQ] [numeric](20, 0) NULL,  -- mã tỉnh trú quán
	[MaQuanTQ] [numeric](20, 0) NULL, -- mã quận trú quán
	[MaPhuongTQ] [numeric](20, 0) NULL,  -- mã phường trú quán
	[SoNha] [nvarchar](100) NULL,
	[DTNha] [nvarchar](50) NULL,
	[DTCoQuan] [nvarchar](50) NULL,
	[DTDiDong] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[DTNguoiNha] [nvarchar](50) NULL,
	[TenNguoiNha] [nvarchar](50) NULL,
	[MaDanToc] [numeric](20, 0) NULL,  --Mã dân tộc
	[MaTonGiao] [numeric](20, 0) NULL,  --Mã tôn giáo
	[MaThanhPhanGD] [numeric](20, 0) NULL, --Mã thành phần gia đình
	[NgheTruocTD] [nvarchar](100) NULL,  --nghề trước khi tuyển dụng
	[NgayTD] [datetime] NULL, --Ngày tuyển dụng
	[NgayCQ] [datetime] NULL, --Ngày vào cơ quan
	[CoQuanTD] [nvarchar](100) NULL, --cơ quan tuyển dụng
	[NgayCM] [datetime] NULL,--ngày tham gia cách mạng
	[NgayDang] [datetime] NULL, --ngày vào Đảng
	[NgayDangCT] [datetime] NULL, ---ngày vào Đảng chính thức
	[MaChiBo] [numeric](20, 0) NULL,  --mã chi bộ
	[NgayTCXH] [datetime] NULL, --ngày tham gia tổ chức xã hội
	[NgayNhapNgu] [datetime] NULL,
	[NgayXuatNgu] [datetime] NULL,
	[QuanHam] [nvarchar](50) NULL,
	[MaTDVanHoa] [numeric](20, 0) NULL, 
	[MaTDDaoTao] [numeric](20, 0) NULL,
	[MaTDLLCT] [numeric](20, 0) NULL,
	[MaNgoaiNgu] [numeric](20, 0) NULL,  --mã ngoại ngữ
	[MaTDNgoaiNgu] [numeric](20, 0) NULL,  -- Mã trình độ ngoại ngữ
	[CVDangLam] [nvarchar](100) NULL,
	[MaNgach] [numeric](20, 0) NULL,--mã ngạch
	[Bac] [varchar](2) NULL,
	[HSL] [numeric](6, 3) NULL,
	[DHDuocPhong] [nvarchar](50) NULL, --danh hiệu được phong
	[SoTruongCT] [nvarchar](50) NULL, --sở trường công tác
	[CVLamLN] [nvarchar](50) NULL,  ---công việc làm lâu nhất
	[KhenThuong] [nvarchar](50) NULL,
	[KyLuat] [nvarchar](50) NULL,
	[SucKhoe] [nvarchar](50) NULL,
	[ChieuCao] [nvarchar](10) NULL,
	[CanNang] [nvarchar](10) NULL,
	[NhomMau] [nvarchar](10) NULL,
	[SoCMND] [nvarchar](50) NULL,
	[MaLoaiTB] [numeric](20, 0) NULL, --mã loại thương binh
	[GDLietSy] [bit] NULL,
	[TuDay] [ntext] NULL,
	[CheDoCu] [ntext] NULL,
	[TCNuocNgoai] [ntext] NULL,  ---tổ chức nước ngoài
	[TNNuocNgoai] [ntext] NULL,---thân nhân nước ngoài
	[SoBHXH] [varchar](20) NULL,
	[TheBHYT] [varchar](20) NULL,
	[MaTinhKCB] [numeric](20, 0) NULL,--mã tỉnh khám chữa bệnh (proviceCode của bảng ListNoiKCB)
	[MaNoiKCB] [numeric](20, 0) NULL,  --Mã nơi khám chữa bệnh
	[TaiKhoanATM] [varchar](20) NULL,
	[IDNganHang] [numeric](18, 0) NULL,
	[NgayCMND] [datetime] NULL,
	[NoiCMND] [nvarchar](50) NULL,
	[NgayNangLuong] [datetime] NULL,
	[DaNLTruocTH] [bit] NULL,  --đã nâng luwong trước thời hạn
	[AnhNV] [image] NULL
)
----------------------------Bảng quan hệ gia đình-------------------------
CREATE TABLE [dbo].[QuanHeGiaDinh](
	[MaNhanVien] uniqueidentifier NOT NULL,
	[STT] [numeric](5, 0) NULL,
	[MaQuanHeGD] [numeric](20, 0) NULL,
	[HoTen] [nvarchar](50) NULL,
	[NamSinh] [varchar](4) NULL,
	[ChiTiet] [ntext] NULL
) 

------------------------Bảng quá trình công tác------------------------------
CREATE TABLE [dbo].[QuaTrinhCongTac](
	[MaNhanVien] uniqueidentifier NOT NULL,
	[STT] [numeric](5, 0) NULL,
	[ThoiGian] [nvarchar](50) NULL,
	[CongViec] [nvarchar](300) NULL
) 
----------------Bảng quá trình tham gia BHXH (hồ sơ trước khi sử dugj chương trình)------------------
CREATE TABLE [dbo].[QuaTrinhBHXH](
	[MaNhanVien] uniqueidentifier NOT NULL,
	[STT] [numeric](5, 0) NULL,
	[Loai] [varchar](2) NULL,
	[TuThang] [varchar](7) NULL,
	[DenThang] [varchar](7) NULL,
	[SoThang] [numeric](3, 0) NULL,
	[MucLuong] [numeric](12, 0) NULL,
	[HSL] [numeric](6, 3) NULL,
	[PCChucVu] [numeric](6, 3) NULL,
	[PCThamNien] [numeric](6, 3) NULL,
	[PCKhuVuc] [numeric](6, 3) NULL,
	[CongViec] [nvarchar](255) NULL
	)
-----------------------Bảng quá trình Lương (hồ sơ trước khi sử dụng chương trình)---------------------------------
CREATE TABLE [dbo].[QuaTrinhLuong](
	[MaNhanVien] uniqueidentifier NOT NULL,
	[STT] [numeric](5, 0) NULL,
	[Loai] [varchar](2) NULL,
	[TuThang] [varchar](7) NULL,
	[DenThang] [varchar](7) NULL,
	[SoThang] [numeric](3, 0) NULL,
	[MucLuong] [numeric](12, 0) NULL,
	[HSL] [numeric](6, 3) NULL,
	[PCChucVu] [numeric](6, 3) NULL,
	[PCThamNien] [numeric](6, 3) NULL,
	[PCDocHai] [numeric](6, 3) NULL,
	[PCTrachNhiem] [numeric](6, 3) NULL,
	[PCKhuVuc] [numeric](6, 3) NULL,
	[CongViec] [nvarchar](100) NULL
) 
-------------------------------quá trình khen thưởng kỹ luật-------------------------------
CREATE TABLE [dbo].[KhenThuongKyLuat](
    [MaNhanVien] uniqueidentifier NOT NULL,
	[STT] [numeric](5, 0) NULL,
	[LoaiKTKL] [nvarchar](12) NULL,
	[IDKTKL] [numeric](18, 0) NULL,
	[Nam] [varchar](4) NULL,
	[GhiChu] [ntext] NULL,
	[IDPhongBan] [numeric](18, 0) NULL
	)
	---------------Quá trình tham gia BHXH (quá trình từ khi bắt đầu sử dụng chương trình)--------------------------
		CREATE TABLE [dbo].[PSBHXH](
	--[IDPSBHXH] [numeric](18, 0) NULL,
	[Thang] [varchar](2) NULL,
	[Nam] [varchar](4) NULL,
	[MaNhanVien] uniqueidentifier NOT NULL,
	[MaNgach] [numeric](20, 0) NULL,
	[Bac] [varchar](2) NULL,
	[HSL] [numeric](6, 3) NULL,
	[MucLuong] [numeric](18, 0) NULL,
	[CongTacPhi] [nvarchar](10) NULL,
	[PCChucVu] [numeric](6, 3) NULL,
	[PCTrachNhiem] [numeric](6, 3) NULL,
	[PCThamNien] [numeric](6, 3) NULL,
	[PCDocHai] [numeric](6, 3) NULL,
	[TuThang] [varchar](7) NULL,
	[DenThang] [varchar](7) NULL,
	[LoaiPS] [varchar](2) NULL,
	[IDPhong] [numeric](18, 0) NULL,
	[DotPS] [nvarchar](10) NULL,
	[NgayNangLuong] [datetime] NULL
)
---------------QUÁ TRÌNH LƯƠNG (quá trình từ khi bắt đầu sử dụng chương trình)------------------------------------------
CREATE TABLE [dbo].[PSLuong](
	--[IDPSLuong] [numeric](18, 0) NULL,
	[Thang] [varchar](2) NULL,
	[Nam] [varchar](4) NULL,
	[MaNhanVien] uniqueidentifier NOT NULL,
	[IDNgach] [numeric](18, 0) NULL,
	[Bac] [varchar](2) NULL,
	[HSL] [numeric](6, 3) NULL,
	[MucLuong] [numeric](18, 0) NULL,
	[CongTacPhi] [nvarchar](10) NULL,
	[PCChucVu] [numeric](6, 3) NULL,
	[PCTrachNhiem] [numeric](6, 3) NULL,
	[PCThamNien] [numeric](6, 3) NULL,
	[PCDocHai] [numeric](6, 3) NULL,
	[TuThang] [varchar](7) NULL,
	[DenThang] [varchar](7) NULL,
	[LoaiPS] [varchar](2) NULL,
	[IDPhongNL] [numeric](18, 0) NULL
) 
--------------------Danh mục thang bảng lương-------------------------------
CREATE TABLE [dbo].[ThangBangLuong](
	[MaNgach] [nvarchar](10) NULL,
	[TenNgach] [nvarchar](100) NULL,
	[ThangNL] [numeric](5, 0) NULL,
	[TongBac] [numeric](5, 0) NULL,
	[Bac01] [numeric](6, 3) NULL,
	[Bac02] [numeric](6, 3) NULL,
	[Bac03] [numeric](6, 3) NULL,
	[Bac04] [numeric](6, 3) NULL,
	[Bac05] [numeric](6, 3) NULL,
	[Bac06] [numeric](6, 3) NULL,
	[Bac07] [numeric](6, 3) NULL,
	[Bac08] [numeric](6, 3) NULL,
	[Bac09] [numeric](6, 3) NULL,
	[Bac10] [numeric](6, 3) NULL,
	[Bac11] [numeric](6, 3) NULL,
	[Bac12] [numeric](6, 3) NULL
)
-------------------------Danh mục tỉ lệ đóng BHXH----------------------------------------
CREATE TABLE [dbo].[TyLeBHXH](
	[NgayTu] [datetime] NULL,
	[NgayDen] [datetime] NULL,
	[TyLeBHXH] [numeric](5, 2) NULL,
	[TyLeBHXHNLD] [numeric](5, 2) NULL,
	[TyLeBHYT] [numeric](5, 2) NULL,
	[TyLeBHYTNLD] [numeric](5, 2) NULL,
	[TyLeBHTN] [numeric](5, 2) NULL,
	[TyLeBHTNNLD] [numeric](5, 2) NULL,
	[TyLeKPCD] [numeric](5, 2) NULL,
	[TyLeKPCDNLD] [numeric](5, 2) NULL
)
------------------------Danh mục hệ số lương tăng thêm-------------------------------------
CREATE TABLE [dbo].[HSLTangThem](
	[Nam] [varchar](4) NULL,
	[Thang01] [numeric](4, 2) NULL,
	[Thang02] [numeric](4, 2) NULL,
	[Thang03] [numeric](4, 2) NULL,
	[Thang04] [numeric](4, 2) NULL,
	[Thang05] [numeric](4, 2) NULL,
	[Thang06] [numeric](4, 2) NULL,
	[Thang07] [numeric](4, 2) NULL,
	[Thang08] [numeric](4, 2) NULL,
	[Thang09] [numeric](4, 2) NULL,
	[Thang10] [numeric](4, 2) NULL,
	[Thang11] [numeric](4, 2) NULL,
	[Thang12] [numeric](4, 2) NULL
)
----------------------Danh mục luwong tối thiểu-------------------------
CREATE TABLE [dbo].[LuongToiThieu](
	[NgayTu] [datetime] NULL,
	[NgayDen] [datetime] NULL,
	[MucLuong] [numeric](18, 0) NULL
)
-----------------------Danh mục ngày công--------------------------------
CREATE TABLE [dbo].[NgayCong](
	[Nam] [varchar](4) NULL,
	[Thang01] [numeric](2, 0) NULL,
	[Thang02] [numeric](2, 0) NULL,
	[Thang03] [numeric](2, 0) NULL,
	[Thang04] [numeric](2, 0) NULL,
	[Thang05] [numeric](2, 0) NULL,
	[Thang06] [numeric](2, 0) NULL,
	[Thang07] [numeric](2, 0) NULL,
	[Thang08] [numeric](2, 0) NULL,
	[Thang09] [numeric](2, 0) NULL,
	[Thang10] [numeric](2, 0) NULL,
	[Thang11] [numeric](2, 0) NULL,
	[Thang12] [numeric](2, 0) NULL
)

SET ANSI_PADDING OFF
GO


