
/*
Created by: Le Nho Man
Created Date : 20170328
Edited Date
*/

CREATE DATABASE BHXH
USE BHXH
------------
CREATE TABLE [SysUsers]
( UserID  NVARCHAR(255)  PRIMARY KEY,
Pwd VARCHAR(32),
LastLogin DATETIME,
LastPwdChange DATETIME,
IsActive BIT ,
 MaNhanVien  uniqueidentifier  FOREIGN KEY REFERENCES HrNhanVien (MaNhanVien),
 CreatedDate DATETIME DEFAULT GETDATE()
)

CREATE TABLE SysUserSettings
(
UserSettingID  uniqueidentifier  DEFAULT (NEWID()) PRIMARY KEY,
UserID   NVARCHAR(255)  FOREIGN KEY REFERENCES [SysUsers] (UserID),
Setting1 NVARCHAR,
Setting2 NVARCHAR,
CreatedDate DATETIME DEFAULT GETDATE()
)
CREATE TABLE SysRoles
(
RoleID  NVARCHAR (255) PRIMARY KEY,
RoleName NVARCHAR (255)  UNIQUE,
ParentRoleID   NVARCHAR (255)  ,
Descriptions NVARCHAR(255),
CreatedDate Datetime DEFAULT (GETDATE())
)

CREATE TABLE SysUserRoles
(
UserRoleID   uniqueidentifier  DEFAULT (NEWID()) PRIMARY KEY,
UserID   NVARCHAR(255)  FOREIGN KEY REFERENCES [SysUsers] (UserID),
RoleID  NVARCHAR (255) ,
Descriptions NVARCHAR(255),
GrantedUserID uniqueidentifier ,
GrantedDate DATETIME DEFAULT GETDATE()
)
CREATE TABLE SysLogs
(
LogID  uniqueidentifier  DEFAULT (NEWID()) PRIMARY KEY,
ErrorMessage NVARCHAR(MAX),
EventType NVARCHAR(255),
Descriptions NVARCHAR(255),
EventDate DATETIME DEFAULT GETDATE(),
UserID NVARCHAR(255)  FOREIGN KEY REFERENCES [SysUsers] (UserID),
Postion NVARCHAR(255)
)