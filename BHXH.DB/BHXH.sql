﻿
/*
Created by: Le Nho Man
Created Date : 20170328
Edited Date
*/

CREATE DATABASE BHXH
USE BHXH
------------
CREATE TABLE [SysUsers]
( UserID  uniqueidentifier  DEFAULT (NEWID()) PRIMARY KEY,
LoginName NVARCHAR(50)  UNIQUE,
Pwd VARCHAR(32),
LastLogin DATETIME,
LastPwdChange DATETIME,
IsActive BIT ,
 MaNhanVien  uniqueidentifier  FOREIGN KEY REFERENCES Hr (EmployeeID),
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
RoleName NVARCHAR (255)  UNIQUE,
ParentRoleID  uniqueidentifier ,
Descriptions NVARCHAR(255),
CreatedDate Datetime DEFAULT (GETDATE())

)

CREATE TABLE SysUserRoles
(
UserRoleID   uniqueidentifier  DEFAULT (NEWID()) PRIMARY KEY,
UserID  uniqueidentifier ,
RoleID  uniqueidentifier ,
Descriptions NVARCHAR(255),
GrantedUserID uniqueidentifier ,
GrantedDate DATETIME DEFAULT GETDATE()
)
CREATE TABLE BHXH.dbo.ListQuocGia
(
MaQuocGia CHAR (2) PRIMARY KEY,
TenQuocGia NVARCHAR(255) UNIQUE
)
CREATE TABLE ListDanToc
(
MaDanToc CHAR (2) PRIMARY KEY,
TenDanToc NVARCHAR(255) UNIQUE
)

CREATE TABLE ListTinh
(MaTinh NCHAR(2) PRIMARY KEY,
TenTinh NVARCHAR(255) UNIQUE
)
CREATE TABLE ListQuanHuyen
(
QuanHuyenID NUMERIC (18) PRIMARY KEY ,
MaQuanHuyen NVARCHAR(2) ,
TenQuanHuyen NVARCHAR(255) ,
MaTinh NCHAR(2) FOREIGN KEY REFERENCES ListTinh(MaTinh)
)
CREATE TABLE ListXaPhuong
(
XaPhuongID NUMERIC (18) PRIMARY KEY ,
MaXaPhuong NCHAR(2),
TenXaPhuong NVARCHAR(255),
QuanHuyenID NUMERIC (18) FOREIGN KEY REFERENCES ListQuanHuyen(QuanHuyenID)
)
-----
CREATE TABLE [dbo].[ListBangCap](
	[MaBangCap] [nvarchar](255)  primary key  ,
	[TenBangCap] [nvarchar](255) 
) 
CREATE TABLE [dbo].[ListCapKTKL](
	[MaCapKTKL] [nvarchar](255) primary key ,
	[TenCapKTKL] [nvarchar](255) 
 ) 
CREATE TABLE [dbo].[ListChiBo](
	[MaChiBo] [nvarchar](255) primary key ,
	[TenChiBo] [nvarchar](255) 
 ) 
CREATE TABLE [dbo].[ListChucDanh](
		[MaChucDanh] [nvarchar](255) primary key ,
	[TenChucDanh] [nvarchar](255) 
 ) 
CREATE TABLE [dbo].[ListChucVu](
	[MaChucVu] [nvarchar](255) primary key ,
	[TenChucVu] [nvarchar](255) 
 ) 
CREATE TABLE [dbo].[ListChucVuDang](
	[MaChucVu] [nvarchar](255) primary key ,
	[TenChucVu] [nvarchar](255) 
 ) 
CREATE TABLE [dbo].[ListCMDaoTao](
	[MaCMDaoTao] [nvarchar](255) primary key ,
	[TenCMDaoTao] [nvarchar](255) ,
	[LoaiCMDaoTao] [nvarchar](20) 
 ) 

CREATE TABLE [dbo].[ListDienCS](
	[MaDienCS] [nvarchar](255) primary key  ,
	[TenDienCS] [nvarchar](255) 
) 
CREATE TABLE [dbo].[ListHonNhan](
	[MaHonNhan] [nvarchar](255) primary key ,
	[TenHonNhan] [nvarchar](255) 
 ) 
CREATE TABLE [dbo].[ListHopDong](
	[MaHopDong] [nvarchar](255) primary key ,
	[TenHopDong] [nvarchar](255) ,
	[LoaiHopDong] [nvarchar](20) 
 ) 
CREATE TABLE [dbo].[ListKTKL](
	[MaKTKL] [nvarchar](255) primary key ,
	[TenKTKL] [nvarchar](255) ,
	[LoaiKTKL] [nvarchar](20) 
 ) 
CREATE TABLE [dbo].[ListLHDaoTao](
	[MaLHDaoTao] [nvarchar](255) primary key ,
	[TenLHDaoTao] [nvarchar](255) 
 ) 
CREATE TABLE [dbo].[ListLoaiTB](
	[MaLoaiTB] [nvarchar](255) primary key ,
	[TenLoaiTB] [nvarchar](255) 
 ) 
CREATE TABLE [dbo].[ListNganHang](
	[MaNganHang] [nvarchar](255) primary key  ,
	[TenNganHang] [nvarchar](255) 
) 
CREATE TABLE [dbo].[ListNghiepVu](
[MaNghiepVu] [nvarchar](255) primary key ,
	[TenNghiepVu] [nvarchar](255) 
 ) 
CREATE TABLE [dbo].[ListNgoaiNgu](
	[MaNgoaiNgu] [nvarchar](255) primary key ,
	[TenNgoaiNgu] [nvarchar](255) 
 ) 

CREATE TABLE [dbo].[ListNoiKCB](
	
	[MaNoiKCB] [nvarchar](255)  ,
	[TenNoiKCB] [nvarchar](255) ,
	MaTinh Nchar(2) FOREIGN KEY REFERENCES ListTinh(MaTinh),
	MaKCBDayDu NVARCHAR(5) PRIMARY KEY 	
 ) 
CREATE TABLE [dbo].[ListPhongBan](
	[MaPhongBan] [nvarchar](255) primary key ,
	[TenPhongBan] [nvarchar](255) 
 ) 
 
CREATE TABLE [dbo].[ListQuan](
	[MaQuan] [nvarchar](255) primary key  ,
	[TenQuan] [nvarchar](255) 
) 
CREATE TABLE [dbo].[ListQuanHeGD](
	[MaQuanHeGD] [nvarchar](255) primary key ,
	[TenQuanHeGD] [nvarchar](255) 
 ) 
CREATE TABLE [dbo].[ListQuocGia](
	[MaQuocGia] [nvarchar](255) primary key ,
	[TenQuocGia] [nvarchar](255) 
 ) 
CREATE TABLE [dbo].[ListTDDaoTao](
	[MaTDDaoTao] [nvarchar](255) primary key ,
	[TenTDDaoTao] [nvarchar](255) 
 ) 
CREATE TABLE [dbo].[ListTDLLCT](
	[MaTDLLCT] [nvarchar](255) primary key ,
	[TenTDLLCT] [nvarchar](255) 
 ) 
CREATE TABLE [dbo].[ListTDNgoaiNgu](
	[MaTDNgoaiNgu] [nvarchar](255) primary key ,
	[TenTDNgoaiNgu] [nvarchar](255) 
 ) 
CREATE TABLE [dbo].[ListTDQLNN](
	[MaTDQLNN] [nvarchar](255) primary key ,
	[TenTDQLNN] [nvarchar](255) 
) 
CREATE TABLE [dbo].[ListTDVanHoa](
	[MaTDVanHoa] [nvarchar](255) primary key ,
	[TenTDVanHoa] [nvarchar](255) 
) 
CREATE TABLE [dbo].[ListThanhPhanGD](
	[MaThanhPhanGD] [nvarchar](255) primary key ,
	[TenThanhPhanGD] [nvarchar](255) 
) 

CREATE TABLE [dbo].[ListTonGiao](
	[MaTonGiao] [nvarchar](255) primary key ,
	[TenTonGiao] [nvarchar](255) 
) 

CREATE TABLE ListUnits
()
CREATE TABLE HrEmployees
()

CREATE TABLE HrHistory
()
select * from ListNationality