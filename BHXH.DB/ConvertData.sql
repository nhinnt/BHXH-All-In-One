INSERT INTO listProvinces
SELECT MaTinh ProvinceCode, TenTinh ProvinceName FROM Nhansu_DaNang.dbo.DMTinh


INSERT INTO ListDistricts (ProvinceCode,DistrictID,DistrictCode,DistrictName)
SELECT   (SELECT MaTinh FROM NhanSu_DaNang.dbo.DMTinh t WHERE t.IDtinh=q.IDTinh )as ProvinceCode ,
IDquan DistrictID, MaQuan DistrictCode,Tenquan DistrictName
FROM NhanSu_DaNang.dbo.DMQuan q

INSERT INTO ListCommunes ( DistrictID,  CommuneID,  CommuneName, CommuneCode)
SELECT IDquan DistrictID, IDPhuong CommuneID, TenPhuong CommuneName,MaPhuong CommuneCode
FROM NhanSu_DaNang.dbo.DMPhuong

  INSERT INTO [BHXH].[dbo].[ListEthnics]
SELECT * FROM Mis.dbo.ListEthnic
