USE [BHXH]
GO
/****** Object:  Table [dbo].[HrHSLTangThem]    Script Date: 04/25/2017 10:36:26 ******/
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
	[Thang12] [numeric](4, 2) NULL,
	[HSLTangThemID] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HSLTangThemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SysRoles]    Script Date: 04/25/2017 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysRoles](
	[RoleID] [nvarchar](255) NOT NULL,
	[RoleName] [nvarchar](255) NULL,
	[ParentRoleID] [nvarchar](255) NULL,
	[Descriptions] [nvarchar](255) NULL,
	[CreatedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListNgoaiNgu]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListNghiepVu]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListNganHang]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListLoaiTB]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListLHDaoTao]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListKTKL]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListHopDong]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListHonNhan]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListDienCS]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListDanToc]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListCMDaoTao]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListChucVuDang]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListChucVu]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListChucDanh]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListChiBo]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListCapKTKL]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListBangCap]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[HrTyLeBHXH]    Script Date: 04/25/2017 10:36:26 ******/
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
	[TyLeKPCDNLD] [numeric](5, 2) NULL,
	[TyLeBHXHID] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TyLeBHXHID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HrThangBangLuong]    Script Date: 04/25/2017 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HrThangBangLuong](
	[MaNgach] [nvarchar](255) NOT NULL,
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
	[Bac12] [numeric](6, 3) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNgach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HrNgayCong]    Script Date: 04/25/2017 10:36:26 ******/
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
	[Thang12] [numeric](2, 0) NULL,
	[NgayCongID] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NgayCongID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HrLuongToiThieu]    Script Date: 04/25/2017 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HrLuongToiThieu](
	[NgayTu] [datetime] NULL,
	[NgayDen] [datetime] NULL,
	[MucLuong] [numeric](18, 0) NULL,
	[LuongToiThieuID] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LuongToiThieuID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListQuanHeGD]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListPhongBan]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListTonGiao]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListTinh]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListThanhPhanGD]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListTDVanHoa]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListTDQLNN]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListTDNgoaiNgu]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListTDLLCT]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListTDDaoTao]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListQuocGia]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListQuanHuyen]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListNoiKCB]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[ListXaPhuong]    Script Date: 04/25/2017 10:36:26 ******/
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
/****** Object:  Table [dbo].[HrNhanVien]    Script Date: 04/25/2017 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HrNhanVien](
	[MaNhanVien] [uniqueidentifier] NOT NULL,
	[TenNhanVien] [nvarchar](255) NULL,
	[MaPhongBan] [nvarchar](255) NULL,
	[SoHieuNV] [nvarchar](20) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[TenKhac] [nvarchar](255) NULL,
	[MaCapUy] [nvarchar](255) NULL,
	[MaCapUyKiem] [nvarchar](255) NULL,
	[MaChucVu] [nvarchar](255) NULL,
	[MaChucDanh] [nvarchar](255) NULL,
	[PCChucVu] [numeric](6, 3) NULL,
	[NgayBoNhiem] [datetime] NULL,
	[NgaySinh] [datetime] NULL,
	[NoiSinh] [nvarchar](100) NULL,
	[MaTinhQQ] [nchar](2) NULL,
	[QuanHuyenIDQQ] [numeric](18, 0) NULL,
	[XaPhuongIDQQ] [numeric](18, 0) NULL,
	[MatinhTQ] [nchar](2) NULL,
	[QuanHuyenIDTQ] [numeric](18, 0) NULL,
	[XaPhuongIDTQ] [numeric](18, 0) NULL,
	[SoNha] [nvarchar](100) NULL,
	[DTNha] [nvarchar](50) NULL,
	[DTCoQuan] [nvarchar](50) NULL,
	[DTDiDong] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[DTNguoiNha] [nvarchar](50) NULL,
	[TenNguoiNha] [nvarchar](50) NULL,
	[MaDanToc] [char](2) NULL,
	[MaTonGiao] [nvarchar](255) NULL,
	[MaThanhPhanGD] [nvarchar](255) NULL,
	[NgheTruocTD] [nvarchar](100) NULL,
	[NgayTD] [datetime] NULL,
	[NgayCQ] [datetime] NULL,
	[CoQuanTD] [nvarchar](100) NULL,
	[NgayCM] [datetime] NULL,
	[NgayDang] [datetime] NULL,
	[NgayDangCT] [datetime] NULL,
	[NgayTCXH] [datetime] NULL,
	[NgayNhapNgu] [datetime] NULL,
	[NgayXuatNgu] [datetime] NULL,
	[QuanHam] [nvarchar](50) NULL,
	[MaTDVanHoa] [nvarchar](255) NULL,
	[MaTDDaoTao] [nvarchar](255) NULL,
	[MaTDLLCT] [nvarchar](255) NULL,
	[MaNgoaiNgu] [nvarchar](255) NULL,
	[MaTDNgoaiNgu] [nvarchar](255) NULL,
	[CVDangLam] [nvarchar](100) NULL,
	[MaNgach] [nvarchar](255) NULL,
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
	[MaLoaiTB] [nvarchar](255) NULL,
	[GDLietSy] [bit] NULL,
	[TuDay] [ntext] NULL,
	[CheDoCu] [ntext] NULL,
	[TCNuocNgoai] [ntext] NULL,
	[TNNuocNgoai] [ntext] NULL,
	[SoBHXH] [varchar](20) NULL,
	[TheBHYT] [varchar](20) NULL,
	[MaTinhKCB] [nvarchar](255) NULL,
	[MaNoiKCB] [nvarchar](255) NULL,
	[TaiKhoanATM] [varchar](20) NULL,
	[MaNganHang] [nvarchar](255) NULL,
	[NgayCMND] [datetime] NULL,
	[NoiCMND] [nvarchar](50) NULL,
	[NgayNangLuong] [datetime] NULL,
	[DaNLTruocTH] [bit] NULL,
	[AnhNV] [image] NULL,
	[MaChiBo] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HrKhenThuongKyLuat]    Script Date: 04/25/2017 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HrKhenThuongKyLuat](
	[MaNhanVien] [uniqueidentifier] NOT NULL,
	[STT] [numeric](5, 0) NULL,
	[MaKTKL] [nvarchar](255) NULL,
	[Nam] [varchar](4) NULL,
	[GhiChu] [ntext] NULL,
	[MaPhongBan] [nvarchar](255) NULL,
	[KhenThuongKyLuat] [uniqueidentifier] NOT NULL,
	[KhenThuongKyLuatID] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KhenThuongKyLuatID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HrQuaTrinhLuong]    Script Date: 04/25/2017 10:36:26 ******/
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
	[CongViec] [nvarchar](100) NULL,
	[QuaTrinhLuongID] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuaTrinhLuongID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HrQuaTrinhCongTac]    Script Date: 04/25/2017 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HrQuaTrinhCongTac](
	[MaNhanVien] [uniqueidentifier] NOT NULL,
	[STT] [numeric](5, 0) NULL,
	[ThoiGian] [nvarchar](50) NULL,
	[CongViec] [nvarchar](300) NULL,
	[QuaTrinhCongTacID] [uniqueidentifier] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HrQuaTrinhBHXH]    Script Date: 04/25/2017 10:36:26 ******/
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
	[CongViec] [nvarchar](255) NULL,
	[QuaTrinhBHXHID] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuaTrinhBHXHID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HrQuanHeGiaDinh]    Script Date: 04/25/2017 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HrQuanHeGiaDinh](
	[MaNhanVien] [uniqueidentifier] NOT NULL,
	[STT] [numeric](5, 0) NULL,
	[MaQuanHeGD] [nvarchar](255) NULL,
	[HoTen] [nvarchar](50) NULL,
	[NamSinh] [varchar](4) NULL,
	[ChiTiet] [ntext] NULL,
	[QuanHeGiaDinhID] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuanHeGiaDinhID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HrPSLuong]    Script Date: 04/25/2017 10:36:26 ******/
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
	[MaNgach] [numeric](18, 0) NULL,
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
	[MaPhongNL] [numeric](18, 0) NULL,
	[PSLuong] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PSLuong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HrPSBHXH]    Script Date: 04/25/2017 10:36:26 ******/
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
	[MaNgach] [nvarchar](255) NULL,
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
	[MaPhongBan] [nvarchar](255) NULL,
	[DotPS] [nvarchar](10) NULL,
	[NgayNangLuong] [datetime] NULL,
	[PSBHXHID] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PSBHXHID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SysUser]    Script Date: 04/25/2017 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SysUser](
	[UserID] [nvarchar](255) NOT NULL,
	[Pwd] [varchar](32) NULL,
	[LastLogin] [datetime] NULL,
	[LastPwdChange] [datetime] NULL,
	[IsActive] [bit] NULL,
	[MaNhanVien] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SysUserSettings]    Script Date: 04/25/2017 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysUserSettings](
	[UserSettingID] [uniqueidentifier] NOT NULL,
	[UserID] [nvarchar](255) NULL,
	[Setting1] [nvarchar](1) NULL,
	[Setting2] [nvarchar](1) NULL,
	[CreatedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserSettingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysUserRoles]    Script Date: 04/25/2017 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysUserRoles](
	[UserRoleID] [uniqueidentifier] NOT NULL,
	[UserID] [nvarchar](255) NULL,
	[RoleID] [nvarchar](255) NULL,
	[Descriptions] [nvarchar](255) NULL,
	[GrantedUserID] [uniqueidentifier] NULL,
	[GrantedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserRoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysLogs]    Script Date: 04/25/2017 10:36:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysLogs](
	[LogID] [uniqueidentifier] NOT NULL,
	[ErrorMessage] [nvarchar](max) NULL,
	[EventType] [nvarchar](255) NULL,
	[Descriptions] [nvarchar](255) NULL,
	[EventDate] [datetime] NULL,
	[UserID] [nvarchar](255) NULL,
	[Postion] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF__HrHSLTang__HSLTa__7D2E8C24]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrHSLTangThem] ADD  DEFAULT (newid()) FOR [HSLTangThemID]
GO
/****** Object:  Default [DF_HrKhenThuongKyLuat_KhenThuongKyLuat]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrKhenThuongKyLuat] ADD  CONSTRAINT [DF_HrKhenThuongKyLuat_KhenThuongKyLuat]  DEFAULT (newid()) FOR [KhenThuongKyLuat]
GO
/****** Object:  Default [DF__HrKhenThu__KhenT__00FF1D08]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrKhenThuongKyLuat] ADD  DEFAULT (newid()) FOR [KhenThuongKyLuatID]
GO
/****** Object:  Default [DF__HrLuongTo__Luong__04CFADEC]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrLuongToiThieu] ADD  DEFAULT (newid()) FOR [LuongToiThieuID]
GO
/****** Object:  Default [DF__HrNgayCon__NgayC__08A03ED0]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNgayCong] ADD  DEFAULT (newid()) FOR [NgayCongID]
GO
/****** Object:  Default [DF__HrNhanVie__MaNha__004002F9]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien] ADD  DEFAULT (newid()) FOR [MaNhanVien]
GO
/****** Object:  Default [DF__HrPSBHXH__PSBHXH__0C70CFB4]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrPSBHXH] ADD  DEFAULT (newid()) FOR [PSBHXHID]
GO
/****** Object:  Default [DF__HrPSLuong__PSLuo__10416098]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrPSLuong] ADD  DEFAULT (newid()) FOR [PSLuong]
GO
/****** Object:  Default [DF__HrQuanHeG__QuanH__1411F17C]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrQuanHeGiaDinh] ADD  DEFAULT (newid()) FOR [QuanHeGiaDinhID]
GO
/****** Object:  Default [DF__HrQuaTrin__QuaTr__17E28260]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrQuaTrinhBHXH] ADD  DEFAULT (newid()) FOR [QuaTrinhBHXHID]
GO
/****** Object:  Default [DF_HrQuaTrinhCongTac_QuaTrinhCongTacID]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrQuaTrinhCongTac] ADD  CONSTRAINT [DF_HrQuaTrinhCongTac_QuaTrinhCongTacID]  DEFAULT (newid()) FOR [QuaTrinhCongTacID]
GO
/****** Object:  Default [DF__HrQuaTrin__QuaTr__1BB31344]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrQuaTrinhLuong] ADD  DEFAULT (newid()) FOR [QuaTrinhLuongID]
GO
/****** Object:  Default [DF__HrTyLeBHX__TyLeB__1F83A428]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrTyLeBHXH] ADD  DEFAULT (newid()) FOR [TyLeBHXHID]
GO
/****** Object:  Default [DF__SysLogs__LogID__41D8BC2C]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[SysLogs] ADD  DEFAULT (newid()) FOR [LogID]
GO
/****** Object:  Default [DF__SysLogs__EventDa__42CCE065]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[SysLogs] ADD  DEFAULT (getdate()) FOR [EventDate]
GO
/****** Object:  Default [DF__SysRoles__Create__36670980]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[SysRoles] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF__SysUser__Created__2818EA29]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[SysUser] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF__SysUserRo__UserR__3B2BBE9D]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[SysUserRoles] ADD  DEFAULT (newid()) FOR [UserRoleID]
GO
/****** Object:  Default [DF__SysUserRo__Grant__3D14070F]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[SysUserRoles] ADD  DEFAULT (getdate()) FOR [GrantedDate]
GO
/****** Object:  Default [DF__SysUserSe__UserS__2CDD9F46]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[SysUserSettings] ADD  DEFAULT (newid()) FOR [UserSettingID]
GO
/****** Object:  Default [DF__SysUserSe__Creat__2EC5E7B8]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[SysUserSettings] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  ForeignKey [FK__HrKhenThu__MaKTK__16644E42]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrKhenThuongKyLuat]  WITH CHECK ADD FOREIGN KEY([MaKTKL])
REFERENCES [dbo].[ListKTKL] ([MaKTKL])
GO
/****** Object:  ForeignKey [FK__HrKhenThu__MaNha__119F9925]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrKhenThuongKyLuat]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[HrNhanVien] ([MaNhanVien])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaCap__02284B6B]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaCapUy])
REFERENCES [dbo].[ListChucVuDang] ([MaChucVu])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaCap__031C6FA4]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaCapUyKiem])
REFERENCES [dbo].[ListChucVuDang] ([MaChucVu])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaCap__041093DD]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaCapUy])
REFERENCES [dbo].[ListChucVuDang] ([MaChucVu])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaCap__0504B816]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaCapUyKiem])
REFERENCES [dbo].[ListChucVuDang] ([MaChucVu])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaCap__5832119F]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaCapUy])
REFERENCES [dbo].[ListChucVuDang] ([MaChucVu])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaCap__592635D8]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaCapUyKiem])
REFERENCES [dbo].[ListChucVuDang] ([MaChucVu])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaCap__5A1A5A11]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaCapUy])
REFERENCES [dbo].[ListChucVuDang] ([MaChucVu])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaCap__5B0E7E4A]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaCapUyKiem])
REFERENCES [dbo].[ListChucVuDang] ([MaChucVu])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaChu__05F8DC4F]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaChucDanh])
REFERENCES [dbo].[ListChucDanh] ([MaChucDanh])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaChu__06ED0088]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaChucDanh])
REFERENCES [dbo].[ListChucDanh] ([MaChucDanh])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaChu__5C02A283]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaChucDanh])
REFERENCES [dbo].[ListChucDanh] ([MaChucDanh])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaChu__5CF6C6BC]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaChucDanh])
REFERENCES [dbo].[ListChucDanh] ([MaChucDanh])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaDan__07E124C1]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaDanToc])
REFERENCES [dbo].[ListDanToc] ([MaDanToc])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaDan__08D548FA]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaDanToc])
REFERENCES [dbo].[ListDanToc] ([MaDanToc])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaDan__5DEAEAF5]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaDanToc])
REFERENCES [dbo].[ListDanToc] ([MaDanToc])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaDan__5EDF0F2E]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaDanToc])
REFERENCES [dbo].[ListDanToc] ([MaDanToc])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaNga__09C96D33]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaNganHang])
REFERENCES [dbo].[ListNganHang] ([MaNganHang])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaNga__0ABD916C]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaNganHang])
REFERENCES [dbo].[ListNganHang] ([MaNganHang])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaNga__0BB1B5A5]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaNgach])
REFERENCES [dbo].[HrThangBangLuong] ([MaNgach])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaNga__0CA5D9DE]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaNgach])
REFERENCES [dbo].[HrThangBangLuong] ([MaNgach])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaNga__5FD33367]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaNganHang])
REFERENCES [dbo].[ListNganHang] ([MaNganHang])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaNga__60C757A0]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaNganHang])
REFERENCES [dbo].[ListNganHang] ([MaNganHang])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaNga__61BB7BD9]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaNgach])
REFERENCES [dbo].[HrThangBangLuong] ([MaNgach])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaNga__62AFA012]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaNgach])
REFERENCES [dbo].[HrThangBangLuong] ([MaNgach])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaNgo__0D99FE17]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaNgoaiNgu])
REFERENCES [dbo].[ListNgoaiNgu] ([MaNgoaiNgu])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaNgo__0E8E2250]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaNgoaiNgu])
REFERENCES [dbo].[ListNgoaiNgu] ([MaNgoaiNgu])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaNgo__63A3C44B]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaNgoaiNgu])
REFERENCES [dbo].[ListNgoaiNgu] ([MaNgoaiNgu])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaNgo__6497E884]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaNgoaiNgu])
REFERENCES [dbo].[ListNgoaiNgu] ([MaNgoaiNgu])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaPho__0F824689]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaPhongBan])
REFERENCES [dbo].[ListPhongBan] ([MaPhongBan])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaPho__10766AC2]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaPhongBan])
REFERENCES [dbo].[ListPhongBan] ([MaPhongBan])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaPho__658C0CBD]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaPhongBan])
REFERENCES [dbo].[ListPhongBan] ([MaPhongBan])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaPho__668030F6]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaPhongBan])
REFERENCES [dbo].[ListPhongBan] ([MaPhongBan])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTDD__116A8EFB]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDDaoTao])
REFERENCES [dbo].[ListTDDaoTao] ([MaTDDaoTao])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTDD__125EB334]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDDaoTao])
REFERENCES [dbo].[ListTDDaoTao] ([MaTDDaoTao])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTDD__6774552F]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDDaoTao])
REFERENCES [dbo].[ListTDDaoTao] ([MaTDDaoTao])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTDD__68687968]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDDaoTao])
REFERENCES [dbo].[ListTDDaoTao] ([MaTDDaoTao])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTDL__1352D76D]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDLLCT])
REFERENCES [dbo].[ListTDLLCT] ([MaTDLLCT])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTDL__1446FBA6]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDLLCT])
REFERENCES [dbo].[ListTDLLCT] ([MaTDLLCT])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTDL__695C9DA1]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDLLCT])
REFERENCES [dbo].[ListTDLLCT] ([MaTDLLCT])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTDL__6A50C1DA]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDLLCT])
REFERENCES [dbo].[ListTDLLCT] ([MaTDLLCT])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTDN__153B1FDF]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDNgoaiNgu])
REFERENCES [dbo].[ListTDNgoaiNgu] ([MaTDNgoaiNgu])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTDN__162F4418]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDNgoaiNgu])
REFERENCES [dbo].[ListTDNgoaiNgu] ([MaTDNgoaiNgu])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTDN__6B44E613]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDNgoaiNgu])
REFERENCES [dbo].[ListTDNgoaiNgu] ([MaTDNgoaiNgu])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTDN__6C390A4C]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDNgoaiNgu])
REFERENCES [dbo].[ListTDNgoaiNgu] ([MaTDNgoaiNgu])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTDV__17236851]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDVanHoa])
REFERENCES [dbo].[ListTDVanHoa] ([MaTDVanHoa])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTDV__18178C8A]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDVanHoa])
REFERENCES [dbo].[ListTDVanHoa] ([MaTDVanHoa])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTDV__6D2D2E85]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDVanHoa])
REFERENCES [dbo].[ListTDVanHoa] ([MaTDVanHoa])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTDV__6E2152BE]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDVanHoa])
REFERENCES [dbo].[ListTDVanHoa] ([MaTDVanHoa])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTha__190BB0C3]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaThanhPhanGD])
REFERENCES [dbo].[ListThanhPhanGD] ([MaThanhPhanGD])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTha__19FFD4FC]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaThanhPhanGD])
REFERENCES [dbo].[ListThanhPhanGD] ([MaThanhPhanGD])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTha__6F1576F7]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaThanhPhanGD])
REFERENCES [dbo].[ListThanhPhanGD] ([MaThanhPhanGD])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTha__70099B30]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaThanhPhanGD])
REFERENCES [dbo].[ListThanhPhanGD] ([MaThanhPhanGD])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTin__1AF3F935]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTinhQQ])
REFERENCES [dbo].[ListTinh] ([MaTinh])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__Matin__1BE81D6E]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MatinhTQ])
REFERENCES [dbo].[ListTinh] ([MaTinh])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__Matin__1CDC41A7]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MatinhTQ])
REFERENCES [dbo].[ListTinh] ([MaTinh])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTin__1DD065E0]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTinhQQ])
REFERENCES [dbo].[ListTinh] ([MaTinh])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__Matin__1EC48A19]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MatinhTQ])
REFERENCES [dbo].[ListTinh] ([MaTinh])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__Matin__1FB8AE52]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MatinhTQ])
REFERENCES [dbo].[ListTinh] ([MaTinh])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTin__70FDBF69]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTinhQQ])
REFERENCES [dbo].[ListTinh] ([MaTinh])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__Matin__71F1E3A2]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MatinhTQ])
REFERENCES [dbo].[ListTinh] ([MaTinh])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__Matin__72E607DB]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MatinhTQ])
REFERENCES [dbo].[ListTinh] ([MaTinh])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTin__73DA2C14]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTinhQQ])
REFERENCES [dbo].[ListTinh] ([MaTinh])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__Matin__74CE504D]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MatinhTQ])
REFERENCES [dbo].[ListTinh] ([MaTinh])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__Matin__75C27486]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MatinhTQ])
REFERENCES [dbo].[ListTinh] ([MaTinh])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTon__20ACD28B]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTonGiao])
REFERENCES [dbo].[ListTonGiao] ([MaTonGiao])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTon__21A0F6C4]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTonGiao])
REFERENCES [dbo].[ListTonGiao] ([MaTonGiao])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTon__76B698BF]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTonGiao])
REFERENCES [dbo].[ListTonGiao] ([MaTonGiao])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__MaTon__77AABCF8]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([MaTonGiao])
REFERENCES [dbo].[ListTonGiao] ([MaTonGiao])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__QuanH__22951AFD]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([QuanHuyenIDQQ])
REFERENCES [dbo].[ListQuanHuyen] ([QuanHuyenID])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__QuanH__23893F36]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([QuanHuyenIDTQ])
REFERENCES [dbo].[ListQuanHuyen] ([QuanHuyenID])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__QuanH__247D636F]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([QuanHuyenIDQQ])
REFERENCES [dbo].[ListQuanHuyen] ([QuanHuyenID])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__QuanH__257187A8]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([QuanHuyenIDTQ])
REFERENCES [dbo].[ListQuanHuyen] ([QuanHuyenID])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__QuanH__789EE131]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([QuanHuyenIDQQ])
REFERENCES [dbo].[ListQuanHuyen] ([QuanHuyenID])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__QuanH__7993056A]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([QuanHuyenIDTQ])
REFERENCES [dbo].[ListQuanHuyen] ([QuanHuyenID])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__QuanH__7A8729A3]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([QuanHuyenIDQQ])
REFERENCES [dbo].[ListQuanHuyen] ([QuanHuyenID])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__QuanH__7B7B4DDC]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([QuanHuyenIDTQ])
REFERENCES [dbo].[ListQuanHuyen] ([QuanHuyenID])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__XaPhu__2665ABE1]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([XaPhuongIDQQ])
REFERENCES [dbo].[ListXaPhuong] ([XaPhuongID])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__XaPhu__2759D01A]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([XaPhuongIDTQ])
REFERENCES [dbo].[ListXaPhuong] ([XaPhuongID])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__XaPhu__284DF453]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([XaPhuongIDQQ])
REFERENCES [dbo].[ListXaPhuong] ([XaPhuongID])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__XaPhu__2942188C]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([XaPhuongIDTQ])
REFERENCES [dbo].[ListXaPhuong] ([XaPhuongID])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__XaPhu__7C6F7215]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([XaPhuongIDQQ])
REFERENCES [dbo].[ListXaPhuong] ([XaPhuongID])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__XaPhu__7D63964E]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([XaPhuongIDTQ])
REFERENCES [dbo].[ListXaPhuong] ([XaPhuongID])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__XaPhu__7E57BA87]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([XaPhuongIDQQ])
REFERENCES [dbo].[ListXaPhuong] ([XaPhuongID])
GO
/****** Object:  ForeignKey [FK__HrNhanVie__XaPhu__7F4BDEC0]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrNhanVien]  WITH CHECK ADD FOREIGN KEY([XaPhuongIDTQ])
REFERENCES [dbo].[ListXaPhuong] ([XaPhuongID])
GO
/****** Object:  ForeignKey [FK__HrPSBHXH__MaNgac__0539C240]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrPSBHXH]  WITH CHECK ADD FOREIGN KEY([MaNgach])
REFERENCES [dbo].[HrThangBangLuong] ([MaNgach])
GO
/****** Object:  ForeignKey [FK__HrPSBHXH__MaNhan__035179CE]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrPSBHXH]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[HrNhanVien] ([MaNhanVien])
GO
/****** Object:  ForeignKey [FK__HrPSBHXH__MaPhon__062DE679]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrPSBHXH]  WITH CHECK ADD FOREIGN KEY([MaPhongBan])
REFERENCES [dbo].[ListPhongBan] ([MaPhongBan])
GO
/****** Object:  ForeignKey [FK__HrPSLuong__MaNha__07220AB2]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrPSLuong]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[HrNhanVien] ([MaNhanVien])
GO
/****** Object:  ForeignKey [FK__HrQuanHeG__MaNha__0AF29B96]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrQuanHeGiaDinh]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[HrNhanVien] ([MaNhanVien])
GO
/****** Object:  ForeignKey [FK__HrQuanHeG__MaQua__0DCF0841]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrQuanHeGiaDinh]  WITH CHECK ADD FOREIGN KEY([MaQuanHeGD])
REFERENCES [dbo].[ListQuanHeGD] ([MaQuanHeGD])
GO
/****** Object:  ForeignKey [FK__HrQuaTrin__MaNha__0FB750B3]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrQuaTrinhBHXH]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[HrNhanVien] ([MaNhanVien])
GO
/****** Object:  ForeignKey [FK__HrQuaTrin__MaNha__0EC32C7A]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrQuaTrinhCongTac]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[HrNhanVien] ([MaNhanVien])
GO
/****** Object:  ForeignKey [FK__HrQuaTrin__MaNha__10AB74EC]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[HrQuaTrinhLuong]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[HrNhanVien] ([MaNhanVien])
GO
/****** Object:  ForeignKey [FK__ListNoiKC__MaTin__54968AE5]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[ListNoiKCB]  WITH CHECK ADD FOREIGN KEY([MaTinh])
REFERENCES [dbo].[ListTinh] ([MaTinh])
GO
/****** Object:  ForeignKey [FK__ListQuanH__MaTin__30242045]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[ListQuanHuyen]  WITH CHECK ADD FOREIGN KEY([MaTinh])
REFERENCES [dbo].[ListTinh] ([MaTinh])
GO
/****** Object:  ForeignKey [FK__ListQuanH__QuanH__3118447E]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[ListQuanHuyen]  WITH CHECK ADD FOREIGN KEY([QuanHuyenID])
REFERENCES [dbo].[ListQuanHuyen] ([QuanHuyenID])
GO
/****** Object:  ForeignKey [FK__ListXaPhu__QuanH__320C68B7]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[ListXaPhuong]  WITH CHECK ADD FOREIGN KEY([QuanHuyenID])
REFERENCES [dbo].[ListQuanHuyen] ([QuanHuyenID])
GO
/****** Object:  ForeignKey [FK__SysLogs__UserID__43C1049E]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[SysLogs]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[SysUser] ([UserID])
GO
/****** Object:  ForeignKey [FK__SysUser__MaNhanV__2724C5F0]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[SysUser]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[HrNhanVien] ([MaNhanVien])
GO
/****** Object:  ForeignKey [FK__SysUserRo__UserI__3C1FE2D6]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[SysUserRoles]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[SysUser] ([UserID])
GO
/****** Object:  ForeignKey [FK__SysUserSe__UserI__2DD1C37F]    Script Date: 04/25/2017 10:36:26 ******/
ALTER TABLE [dbo].[SysUserSettings]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[SysUser] ([UserID])
GO
