USE [BHXH]
GO
/****** Object:  Table [dbo].[ListNgoaiNgu]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListNgoaiNgu](
	[MaNgoaiNgu] [nvarchar](255) NOT NULL,
	[TenNgoaiNgu] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNgoaiNgu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListNghiepVu]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListNghiepVu](
	[MaNghiepVu] [nvarchar](255) NOT NULL,
	[TenNghiepVu] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNghiepVu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListNganHang]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListNganHang](
	[MaNganHang] [nvarchar](255) NOT NULL,
	[TenNganHang] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNganHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListLoaiTB]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListLoaiTB](
	[MaLoaiTB] [nvarchar](255) NOT NULL,
	[TenLoaiTB] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiTB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListLHDaoTao]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListLHDaoTao](
	[MaLHDaoTao] [nvarchar](255) NOT NULL,
	[TenLHDaoTao] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLHDaoTao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListKTKL]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListKTKL](
	[MaKTKL] [nvarchar](255) NOT NULL,
	[TenKTKL] [nvarchar](255) NULL,
	[LoaiKTKL] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKTKL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListHopDong]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListHopDong](
	[MaHopDong] [nvarchar](255) NOT NULL,
	[TenHopDong] [nvarchar](255) NULL,
	[LoaiHopDong] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHopDong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListHonNhan]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListHonNhan](
	[MaHonNhan] [nvarchar](255) NOT NULL,
	[TenHonNhan] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHonNhan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListDienCS]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListDienCS](
	[MaDienCS] [nvarchar](255) NOT NULL,
	[TenDienCS] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDienCS] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListDanToc]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ListDanToc](
	[MaDanToc] [char](2) NOT NULL,
	[TenDanToc] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDanToc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TenDanToc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ListCMDaoTao]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListCMDaoTao](
	[MaCMDaoTao] [nvarchar](255) NOT NULL,
	[TenCMDaoTao] [nvarchar](255) NULL,
	[LoaiCMDaoTao] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCMDaoTao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListChucVuDang]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListChucVuDang](
	[MaChucVu] [nvarchar](255) NOT NULL,
	[TenChucVu] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListChucVu]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListChucVu](
	[MaChucVu] [nvarchar](255) NOT NULL,
	[TenChucVu] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListChucDanh]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListChucDanh](
	[MaChucDanh] [nvarchar](255) NOT NULL,
	[TenChucDanh] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucDanh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListChiBo]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListChiBo](
	[MaChiBo] [nvarchar](255) NOT NULL,
	[TenChiBo] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiBo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListCapKTKL]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListCapKTKL](
	[MaCapKTKL] [nvarchar](255) NOT NULL,
	[TenCapKTKL] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCapKTKL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListBangCap]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListBangCap](
	[MaBangCap] [nvarchar](255) NOT NULL,
	[TenBangCap] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBangCap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HrTyLeBHXH]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HrTyLeBHXH](
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
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HrThangBangLuong]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HrThangBangLuong](
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
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HrQuaTrinhLuong]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HrQuaTrinhLuong](
	[MaNhanVien] [uniqueidentifier] NOT NULL,
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
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HrQuaTrinhCongTac]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HrQuaTrinhCongTac](
	[MaNhanVien] [uniqueidentifier] NOT NULL,
	[STT] [numeric](5, 0) NULL,
	[ThoiGian] [nvarchar](50) NULL,
	[CongViec] [nvarchar](300) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HrQuaTrinhBHXH]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HrQuaTrinhBHXH](
	[MaNhanVien] [uniqueidentifier] NOT NULL,
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
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HrQuanHeGiaDinh]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HrQuanHeGiaDinh](
	[MaNhanVien] [uniqueidentifier] NOT NULL,
	[STT] [numeric](5, 0) NULL,
	[MaQuanHeGD] [numeric](20, 0) NULL,
	[HoTen] [nvarchar](50) NULL,
	[NamSinh] [varchar](4) NULL,
	[ChiTiet] [ntext] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HrPSLuong]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HrPSLuong](
	[Thang] [varchar](2) NULL,
	[Nam] [varchar](4) NULL,
	[MaNhanVien] [uniqueidentifier] NOT NULL,
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
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HrPSBHXH]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HrPSBHXH](
	[Thang] [varchar](2) NULL,
	[Nam] [varchar](4) NULL,
	[MaNhanVien] [uniqueidentifier] NOT NULL,
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
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HrNhanVien]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HrNhanVien](
	[MaNhanVien] [uniqueidentifier] NOT NULL,
	[TenNhanVien] [nvarchar](255) NULL,
	[MaPhongBan] [nvarchar](20) NULL,
	[SoHieuNV] [nvarchar](20) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[TenKhac] [nvarchar](255) NULL,
	[MaCapUy] [nvarchar](20) NULL,
	[MaCapUyKiem] [nvarchar](20) NULL,
	[MaChucVu] [nvarchar](20) NULL,
	[MaChucDanh] [nvarchar](20) NULL,
	[PCChucVu] [numeric](6, 3) NULL,
	[NgayBoNhiem] [datetime] NULL,
	[NgaySinh] [datetime] NULL,
	[NoiSinh] [nvarchar](100) NULL,
	[MaTinhQQ] [nvarchar](20) NULL,
	[MaQuanQQ] [nvarchar](20) NULL,
	[MaphuongQQ] [nvarchar](20) NULL,
	[MatinhTQ] [nvarchar](20) NULL,
	[MaQuanTQ] [nvarchar](20) NULL,
	[MaPhuongTQ] [nvarchar](20) NULL,
	[SoNha] [nvarchar](100) NULL,
	[DTNha] [nvarchar](50) NULL,
	[DTCoQuan] [nvarchar](50) NULL,
	[DTDiDong] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[DTNguoiNha] [nvarchar](50) NULL,
	[TenNguoiNha] [nvarchar](50) NULL,
	[MaDanToc] [nvarchar](20) NULL,
	[MaTonGiao] [nvarchar](20) NULL,
	[MaThanhPhanGD] [nvarchar](20) NULL,
	[NgheTruocTD] [nvarchar](100) NULL,
	[NgayTD] [datetime] NULL,
	[NgayCQ] [datetime] NULL,
	[CoQuanTD] [nvarchar](100) NULL,
	[NgayCM] [datetime] NULL,
	[NgayDang] [datetime] NULL,
	[NgayDangCT] [datetime] NULL,
	[MaChiBo] [nvarchar](20) NULL,
	[NgayTCXH] [datetime] NULL,
	[NgayNhapNgu] [datetime] NULL,
	[NgayXuatNgu] [datetime] NULL,
	[QuanHam] [nvarchar](50) NULL,
	[MaTDVanHoa] [nvarchar](20) NULL,
	[MaTDDaoTao] [nvarchar](20) NULL,
	[MaTDLLCT] [nvarchar](20) NULL,
	[MaNgoaiNgu] [nvarchar](20) NULL,
	[MaTDNgoaiNgu] [nvarchar](20) NULL,
	[CVDangLam] [nvarchar](100) NULL,
	[MaNgach] [nvarchar](20) NULL,
	[Bac] [varchar](2) NULL,
	[HSL] [numeric](6, 3) NULL,
	[DHDuocPhong] [nvarchar](50) NULL,
	[SoTruongCT] [nvarchar](50) NULL,
	[CVLamLN] [nvarchar](50) NULL,
	[KhenThuong] [nvarchar](50) NULL,
	[KyLuat] [nvarchar](50) NULL,
	[SucKhoe] [nvarchar](50) NULL,
	[ChieuCao] [nvarchar](10) NULL,
	[CanNang] [nvarchar](10) NULL,
	[NhomMau] [nvarchar](10) NULL,
	[SoCMND] [nvarchar](50) NULL,
	[MaLoaiTB] [numeric](20, 0) NULL,
	[GDLietSy] [bit] NULL,
	[TuDay] [ntext] NULL,
	[CheDoCu] [ntext] NULL,
	[TCNuocNgoai] [ntext] NULL,
	[TNNuocNgoai] [ntext] NULL,
	[SoBHXH] [varchar](20) NULL,
	[TheBHYT] [varchar](20) NULL,
	[MaTinhKCB] [nvarchar](20) NULL,
	[MaNoiKCB] [nvarchar](20) NULL,
	[TaiKhoanATM] [varchar](20) NULL,
	[MaNganHang] [nvarchar](20) NULL,
	[NgayCMND] [datetime] NULL,
	[NoiCMND] [nvarchar](50) NULL,
	[NgayNangLuong] [datetime] NULL,
	[DaNLTruocTH] [bit] NULL,
	[AnhNV] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HrNgayCong]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HrNgayCong](
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
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HrLuongToiThieu]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HrLuongToiThieu](
	[NgayTu] [datetime] NULL,
	[NgayDen] [datetime] NULL,
	[MucLuong] [numeric](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HrKhenThuongKyLuat]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HrKhenThuongKyLuat](
	[MaNhanVien] [uniqueidentifier] NOT NULL,
	[STT] [numeric](5, 0) NULL,
	[MaKTKL] [nvarchar](20) NULL,
	[Nam] [varchar](4) NULL,
	[GhiChu] [ntext] NULL,
	[MaPhongBan] [nvarchar](20) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HrHSLTangThem]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HrHSLTangThem](
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
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ListQuanHeGD]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListQuanHeGD](
	[MaQuanHeGD] [nvarchar](255) NOT NULL,
	[TenQuanHeGD] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaQuanHeGD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListPhongBan]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListPhongBan](
	[MaPhongBan] [nvarchar](255) NOT NULL,
	[TenPhongBan] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhongBan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListTonGiao]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListTonGiao](
	[MaTonGiao] [nvarchar](255) NOT NULL,
	[TenTonGiao] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTonGiao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListTinh]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListTinh](
	[MaTinh] [nchar](2) NOT NULL,
	[TenTinh] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTinh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TenTinh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListThanhPhanGD]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListThanhPhanGD](
	[MaThanhPhanGD] [nvarchar](255) NOT NULL,
	[TenThanhPhanGD] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThanhPhanGD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListTDVanHoa]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListTDVanHoa](
	[MaTDVanHoa] [nvarchar](255) NOT NULL,
	[TenTDVanHoa] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTDVanHoa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListTDQLNN]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListTDQLNN](
	[MaTDQLNN] [nvarchar](255) NOT NULL,
	[TenTDQLNN] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTDQLNN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListTDNgoaiNgu]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListTDNgoaiNgu](
	[MaTDNgoaiNgu] [nvarchar](255) NOT NULL,
	[TenTDNgoaiNgu] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTDNgoaiNgu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListTDLLCT]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListTDLLCT](
	[MaTDLLCT] [nvarchar](255) NOT NULL,
	[TenTDLLCT] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTDLLCT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListTDDaoTao]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListTDDaoTao](
	[MaTDDaoTao] [nvarchar](255) NOT NULL,
	[TenTDDaoTao] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTDDaoTao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListQuocGia]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ListQuocGia](
	[MaQuocGia] [char](2) NOT NULL,
	[TenQuocGia] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaQuocGia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TenQuocGia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ListQuanHuyen]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListQuanHuyen](
	[QuanHuyenID] [numeric](18, 0) NOT NULL,
	[MaQuanHuyen] [nvarchar](2) NULL,
	[TenQuanHuyen] [nvarchar](255) NULL,
	[MaTinh] [nchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[QuanHuyenID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListNoiKCB]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListNoiKCB](
	[MaNoiKCB] [nvarchar](255) NULL,
	[TenNoiKCB] [nvarchar](255) NULL,
	[MaTinh] [nchar](2) NULL,
	[MaKCBDayDu] [nvarchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKCBDayDu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListXaPhuong]    Script Date: 04/15/2017 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListXaPhuong](
	[XaPhuongID] [numeric](18, 0) NOT NULL,
	[MaXaPhuong] [nchar](2) NULL,
	[TenXaPhuong] [nvarchar](255) NULL,
	[QuanHuyenID] [numeric](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[XaPhuongID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF__NhanVien__MaNhan__5B438874]    Script Date: 04/15/2017 10:49:53 ******/
ALTER TABLE [dbo].[HrNhanVien] ADD  DEFAULT (newid()) FOR [MaNhanVien]
GO
/****** Object:  ForeignKey [FK__ListNoiKC__MaTin__54968AE5]    Script Date: 04/15/2017 10:49:53 ******/
ALTER TABLE [dbo].[ListNoiKCB]  WITH CHECK ADD FOREIGN KEY([MaTinh])
REFERENCES [dbo].[ListTinh] ([MaTinh])
GO
/****** Object:  ForeignKey [FK__ListQuanH__MaTin__3EA749C6]    Script Date: 04/15/2017 10:49:53 ******/
ALTER TABLE [dbo].[ListQuanHuyen]  WITH CHECK ADD FOREIGN KEY([MaTinh])
REFERENCES [dbo].[ListTinh] ([MaTinh])
GO
/****** Object:  ForeignKey [FK__ListXaPhu__QuanH__436BFEE3]    Script Date: 04/15/2017 10:49:53 ******/
ALTER TABLE [dbo].[ListXaPhuong]  WITH CHECK ADD FOREIGN KEY([QuanHuyenID])
REFERENCES [dbo].[ListQuanHuyen] ([QuanHuyenID])
GO
