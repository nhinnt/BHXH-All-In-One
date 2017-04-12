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

--Thuy modify 20170412--

INSERT INTO [BHXH].[dbo].ListBangCap     (MaBangCap,TenBangCap)
SELECT MaBangCap,TenBangCap  FROM NhanSu_DaNang.dbo.DMBangCap
    
INSERT INTO BHXH.dbo.ListCapKTKL ([MaCapKTKL],[TenCapKTKL])
SELECT [MaCapKTKL] ,[TenCapKTKL]  FROM [NhanSu_DaNang].[dbo].[DMCapKTKL]

INSERT INTO [BHXH].[dbo].[ListChiBo]([MaChiBo],[TenChiBo])
SELECT [MaChiBo],[TenChiBo] FROM [NhanSu_DaNang].[dbo].[DMChiBo]

INSERT INTO [BHXH].[dbo].[ListChucDanh]([MaChucDanh],[TenChucDanh])
SELECT [MaChucDanh],[TenChucDanh]  FROM [NhanSu_DaNang].[dbo].[DMChucDanh]
  
INSERT INTO [BHXH].[dbo].[ListChucVu] ([MaChucVu],[TenChucVu])
SELECT [MaChucVu] ,[TenChucVu]  FROM [NhanSu_DaNang].[dbo].[DMChucVu]
  
INSERT INTO [BHXH].[dbo].[ListChucVuDang]([MaChucVu],[TenChucVu])
SELECT [MaChucVu],[TenChucVu]  FROM [NhanSu_DaNang].[dbo].[DMChucVuDang]


INSERT INTO [BHXH].[dbo].[ListCMDaoTao]([MaCMDaoTao],[TenCMDaoTao],[LoaiCMDaoTao])
SELECT [MaCMDaoTao],[TenCMDaoTao],[LoaiCMDaoTao]  FROM [NhanSu_DaNang].[dbo].[DMCMDaoTao]
GROUP BY [MaCMDaoTao],[TenCMDaoTao],[LoaiCMDaoTao]


INSERT INTO [BHXH].[dbo].[ListDienCS]([MaDienCS],[TenDienCS])
SELECT [MaDienCS] ,[TenDienCS]  FROM [NhanSu_DaNang].[dbo].[DMDienCS]
     
  
INSERT INTO [BHXH].[dbo].[ListHonNhan]([MaHonNhan],[TenHonNhan])
SELECT [MaHonNhan],[TenHonNhan]  FROM [NhanSu_DaNang].[dbo].[DMHonNhan]
 
 
INSERT INTO [BHXH].[dbo].[ListHopDong]  ([MaHopDong],[TenHopDong],[LoaiHopDong])
SELECT [MaHopDong],[TenHopDong],[LoaiHopDong]  FROM [NhanSu_DaNang].[dbo].[DMHopDong]

  
INSERT INTO [BHXH].[dbo].[ListKTKL]([MaKTKL],[TenKTKL],[LoaiKTKL])
SELECT [MaKTKL],[TenKTKL],[LoaiKTKL]  FROM [NhanSu_DaNang].[dbo].[DMKTKL]
  
INSERT INTO [BHXH].[dbo].[ListLHDaoTao]([MaLHDaoTao],[TenLHDaoTao])
SELECT [MaLHDaoTao],[TenLHDaoTao] FROM [NhanSu_DaNang].[dbo].[DMLHDaoTao]
 
INSERT INTO [BHXH].[dbo].[ListLoaiTB]  ([MaLoaiTB],[TenLoaiTB])
SELECT[MaLoaiTB],[TenLoaiTB]  FROM [NhanSu_DaNang].[dbo].[DMLoaiTB]


INSERT INTO [BHXH].[dbo].[ListNganHang] ([MaNganHang] ,[TenNganHang])
SELECT [MaNganHang] ,[TenNganHang]  FROM [NhanSu_DaNang].[dbo].[DMNganHang]
     

INSERT INTO [BHXH].[dbo].[ListNghiepVu]   ([MaNghiepVu],[TenNghiepVu])
SELECT [MaNghiepVu],[TenNghiepVu] FROM [NhanSu_DaNang].[dbo].[DMNghiepVu]
   
INSERT INTO [BHXH].[dbo].[ListNgoaiNgu]    ([MaNgoaiNgu],[TenNgoaiNgu])
SELECT [MaNgoaiNgu],[TenNgoaiNgu]FROM [NhanSu_DaNang].[dbo].[DMNgoaiNgu]



INSERT INTO [BHXH].[dbo].[ListPhongBan]   ([MaPhongBan],[TenPhongBan])
SELECT [MaPhongBan],[TenPhongBan]  FROM [NhanSu_DaNang].[dbo].[DMPhongBan]
     
     
INSERT INTO [BHXH].[dbo].[ListQuanHeGD] ([MaQuanHeGD],[TenQuanHeGD])
SELECT [MaQuanHeGD],[TenQuanHeGD]  FROM [NhanSu_DaNang].[dbo].[DMQuanHeGD]
    
    
INSERT INTO [BHXH].[dbo].[ListTDDaoTao]  ([MaTDDaoTao],[TenTDDaoTao]) 
SELECT [MaTDDaoTao],[TenTDDaoTao]  FROM [NhanSu_DaNang].[dbo].[DMTDDaoTao]


INSERT INTO [BHXH].[dbo].[ListTDLLCT]([MaTDLLCT],[TenTDLLCT])
 SELECT [MaTDLLCT],[TenTDLLCT] FROM [NhanSu_DaNang].[dbo].[DMTDLLCT]


INSERT INTO [BHXH].[dbo].[ListTDNgoaiNgu]  ([MaTDNgoaiNgu],[TenTDNgoaiNgu])
   SELECT [MaTDNgoaiNgu],[TenTDNgoaiNgu]  FROM [NhanSu_DaNang].[dbo].[DMTDNgoaiNgu]
   
INSERT INTO [BHXH].[dbo].[ListTDQLNN] ([MaTDQLNN],[TenTDQLNN])
    SELECT [MaTDQLNN],[TenTDQLNN]  FROM [NhanSu_DaNang].[dbo].[DMTDQLNN]
    
    
INSERT INTO [BHXH].[dbo].[ListTDVanHoa]([MaTDVanHoa],[TenTDVanHoa])
SELECT [MaTDVanHoa],[TenTDVanHoa]  FROM [NhanSu_DaNang].[dbo].[DMTDVanHoa]


INSERT INTO [BHXH].[dbo].[ListThanhPhanGD]([MaThanhPhanGD],[TenThanhPhanGD])
SELECT [MaThanhPhanGD],[TenThanhPhanGD]  FROM [NhanSu_DaNang].[dbo].[DMThanhPhanGD]


INSERT INTO [BHXH].[dbo].[ListTonGiao]  ([MaTonGiao],[TenTonGiao])
SELECT [MaTonGiao],[TenTonGiao] FROM [NhanSu_DaNang].[dbo].[DMTonGiao]


INSERT INTO [BHXH].[dbo].[ListNoiKCB]  ( ProvinceCode, [MaNoiKCB],[TenNoiKCB])
SELECT  ProvinceCode=(SELECT Matinh FROM NhanSu_DaNang.dbo.DMTinh t WHERE t.IDTinh= k.IDTinh),
[MaNoiKCB],[TenNoiKCB]  FROM [NhanSu_DaNang].[dbo].[DMNoiKCB] k
WHERE (SELECT Matinh FROM NhanSu_DaNang.dbo.DMTinh t WHERE t.IDTinh= k.IDTinh) IS NOT NULL
  