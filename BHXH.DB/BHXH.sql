
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
DistrictCode NCHAR(2) ,
DistrictName NVARCHAR(2) UNIQUE,
ProvinceCode NCHAR(2) FOREIGN KEY REFERENCES ListProvinces(ProviceCode)
)
CREATE TABLE ListCommunes
(
CommuneID uniqueidentifier PRIMARY KEY DEFAULT NEWID(),
CommuneCode NCHAR(2),
DistrictID FOREIGN KEY REFERENCES ListDistricts(DistrictID)
)
CREATE TABLE ListUnits
()
CREATE TABLE HrEmployees
()

CREATE TABLE HrHistory
()