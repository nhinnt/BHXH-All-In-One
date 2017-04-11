
/*
<<<<<<< HEAD
<<<<<<< HEAD
Created by: Le Nho Man
Created Date : 20170328
Edited Date
=======
=======
>>>>>>> 26c6c0ef4d3e103c6f6d4fa57f801715be06d44b
Created by		: Le Nho Man
Created Date	: 20170328
Edited Date		:
Edited By		:
<<<<<<< HEAD
>>>>>>> 26c6c0ef4d3e103c6f6d4fa57f801715be06d44b
=======
>>>>>>> 26c6c0ef4d3e103c6f6d4fa57f801715be06d44b
*/

CREATE DATABASE BHXH
USE BHXH
------------
CREATE TABLE [SysUsers]
( UserID  uniqueidentifier  DEFAULT (NEWID()) PRIMARY KEY,
LoginName NVARCHAR(50) NOT NULL UNIQUE,
Pwd VARCHAR(32),
LastLogin DATETIME,
LastPwdChange DATETIME,
IsActive BIT ,
 EmployeeID  uniqueidentifier  FOREIGN KEY REFERENCES HrEmployees (EmployeeID),
 CreatedDate DATETIME DEFAULT GETDATE()
)

CREATE TABLE SysUserSettings
(
UserSettingID  uniqueidentifier  DEFAULT (NEWID()) PRIMARY KEY,
UserID  uniqueidentifier  FOREIGN KEY REFERENCES [SysUsers] (UserID),
Setting1 NVARCHAR,
Setting2 NVARCHAR,
CreatedDate DATETIME DEFAULT GETDATE()
)
CREATE TABLE SysRoles
(
RoleID  uniqueidentifier  DEFAULT (NEWID()) PRIMARY KEY,
RoleName NVARCHAR (255) NOT NULL UNIQUE,
ParentRoleID  uniqueidentifier ,
Descriptions NVARCHAR(255),
CreatedDate Datetime DEFAULT (GETDATE())

)

CREATE TABLE SysUserRoles
(
UserRoleID   uniqueidentifier  DEFAULT (NEWID()) PRIMARY KEY,
UserID  uniqueidentifier NOT NULL,
RoleID  uniqueidentifier NOT NULL,
Descriptions NVARCHAR(255),
GrantedUserID uniqueidentifier NOT NULL,
GrantedDate DATETIME DEFAULT GETDATE()
)


CREATE TABLE ListNationality
(
NationalityCode CHAR(2)   PRIMARY KEY,
NationalityName NVARCHAR(255) UNIQUE
)
CREATE TABLE ListEthnics
(
[EthnicCode] CHAR (2) PRIMARY KEY,
[EthnicName] NVARCHAR(255) UNIQUE
)

CREATE TABLE ListProvinces
(ProvinceCode NCHAR(2) PRIMARY KEY,
ProvinceName NVARCHAR(255) UNIQUE
)
CREATE TABLE ListDistricts
(
DistrictID NUMERIC (18) PRIMARY KEY ,
DistrictCode NVARCHAR(2) ,
DistrictName NVARCHAR(255) ,
ProvinceCode NCHAR(2) FOREIGN KEY REFERENCES ListProvinces(ProvinceCode)
)
CREATE TABLE ListCommunes
(
CommuneID NUMERIC (18) PRIMARY KEY ,
CommuneCode NCHAR(2),
CommuneName NVARCHAR(255),
DistrictID NUMERIC (18) FOREIGN KEY REFERENCES ListDistricts(DistrictID)
)
-----

CREATE TABLE [dbo].[ListBangCap](
	[MaBangCap] [nvarchar](255)  primary key not NULL ,
	[TenBangCap] [nvarchar](255) NULL
) ON [PRIMARY]
CREATE TABLE [dbo].[ListCapKTKL](
	[MaCapKTKL] [nvarchar](255) primary key not NULL,
	[TenCapKTKL] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListChiBo](
	[MaChiBo] [nvarchar](255) primary key not NULL,
	[TenChiBo] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListChucDanh](
		[MaChucDanh] [nvarchar](255) primary key not NULL,
	[TenChucDanh] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListChucVu](
	[MaChucVu] [nvarchar](255) primary key not NULL,
	[TenChucVu] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListChucVuDang](
	[MaChucVu] [nvarchar](255) primary key not NULL,
	[TenChucVu] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListCMDaoTao](
	[MaCMDaoTao] [nvarchar](255) primary key not NULL,
	[TenCMDaoTao] [nvarchar](255) NULL,
	[LoaiCMDaoTao] [nvarchar](20) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListDanToc](
	[MaDanToc] [nvarchar](255) primary key not NULL,
	[TenDanToc] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListDienCS](
	[MaDienCS] [nvarchar](255) primary key not NULL ,
	[TenDienCS] [nvarchar](255) NULL
) ON [PRIMARY]
CREATE TABLE [dbo].[ListHonNhan](
	[MaHonNhan] [nvarchar](255) primary key not NULL,
	[TenHonNhan] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListHopDong](
	[MaHopDong] [nvarchar](255) primary key not NULL,
	[TenHopDong] [nvarchar](255) NULL,
	[LoaiHopDong] [nvarchar](20) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListKTKL](
	[MaKTKL] [nvarchar](255) primary key not NULL,
	[TenKTKL] [nvarchar](255) NULL,
	[LoaiKTKL] [nvarchar](20) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListLHDaoTao](
	[MaLHDaoTao] [nvarchar](255) primary key not NULL,
	[TenLHDaoTao] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListLoaiTB](
	[MaLoaiTB] [nvarchar](255) primary key not NULL,
	[TenLoaiTB] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListNganHang](
	[MaNganHang] [nvarchar](255) primary key not NULL ,
	[TenNganHang] [nvarchar](255) NULL
) ON [PRIMARY]
CREATE TABLE [dbo].[ListNghiepVu](
[MaNghiepVu] [nvarchar](255) primary key not NULL,
	[TenNghiepVu] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListNgoaiNgu](
	[MaNgoaiNgu] [nvarchar](255) primary key not NULL,
	[TenNgoaiNgu] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListNoiKCB](
	[MaNoiKCB] [nvarchar](255) primary key not NULL,
	[TenNoiKCB] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListPhongBan](
	[MaPhongBan] [nvarchar](255) primary key not NULL,
	[TenPhongBan] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListPhuong](
	[MaPhuong] [nvarchar](255) primary key not NULL,
	[TenPhuong] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListQuan](
	[MaQuan] [nvarchar](255) primary key not NULL ,
	[TenQuan] [nvarchar](255) NULL
) ON [PRIMARY]
CREATE TABLE [dbo].[ListQuanHeGD](
	[MaQuanHeGD] [nvarchar](255) primary key not NULL,
	[TenQuanHeGD] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListQuocGia](
	[MaQuocGia] [nvarchar](255) primary key not NULL,
	[TenQuocGia] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListTDDaoTao](
	[MaTDDaoTao] [nvarchar](255) primary key not NULL,
	[TenTDDaoTao] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListTDLLCT](
	[MaTDLLCT] [nvarchar](255) primary key not NULL,
	[TenTDLLCT] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListTDNgoaiNgu](
	[MaTDNgoaiNgu] [nvarchar](255) primary key not NULL,
	[TenTDNgoaiNgu] [nvarchar](255) NULL
 ) ON [PRIMARY]
CREATE TABLE [dbo].[ListTDQLNN](
	[MaTDQLNN] [nvarchar](255) primary key not NULL,
	[TenTDQLNN] [nvarchar](255) NULL
) ON [PRIMARY]
CREATE TABLE [dbo].[ListTDVanHoa](
	[MaTDVanHoa] [nvarchar](255) primary key not NULL,
	[TenTDVanHoa] [nvarchar](255) NULL
) ON [PRIMARY]
CREATE TABLE [dbo].[ListThanhPhanGD](
	[MaThanhPhanGD] [nvarchar](255) primary key not NULL,
	[TenThanhPhanGD] [nvarchar](255) NULL
) ON [PRIMARY]
CREATE TABLE [dbo].[ListTinh](
	[MaTinh] [nvarchar](255) primary key not NULL,
	[TenTinh] [nvarchar](255) NULL
) ON [PRIMARY]
CREATE TABLE [dbo].[ListTonGiao](
	[MaTonGiao] [nvarchar](255) primary key not NULL,
	[TenTonGiao] [nvarchar](255) NULL
) ON [PRIMARY]

CREATE TABLE ListUnits
()
CREATE TABLE HrEmployees
()

CREATE TABLE HrHistory
()