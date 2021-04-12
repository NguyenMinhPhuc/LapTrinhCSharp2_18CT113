USE Data_BanHang_HocTap
GO
--Tao bang Don vi tinh
CREATE TABLE DonViTinh
    (
      MaDVT INT IDENTITY(1, 1)
                NOT NULL
                PRIMARY KEY ,
      TenDVT NVARCHAR(10) NOT NULL ,
      IsDelete BIT DEFAULT ( 0 )
    );
    GO 
    --Tao bang san pham
CREATE TABLE SanPham
    (
      MaSP INT IDENTITY(1, 1)
               PRIMARY KEY ,
      TenSP NVARCHAR(100) NOT NULL
                          UNIQUE ,
      SoTon INT DEFAULT ( 0 )
                NOT NULL ,
      MaDVT INT NOT NULL ,
      IsDelete BIT NOT NULL
                   DEFAULT ( 0 ) ,
      CONSTRAINT Fk_SanPham_DVT_maDVT FOREIGN KEY ( MaDVT ) REFERENCES dbo.DonViTinh ( MaDVT ) ,
      CONSTRAINT Ck_SoTonLonHonHayBang0 CHECK ( SoTon >= 0 )
    );
    --Tao bang phieu nhap
CREATE TABLE PhieuNhap
    (
      MaPhieuNhap CHAR(9) NOT NULL
                          PRIMARY KEY ,
      NgayNhap DATETIME DEFAULT ( GETDATE() )
                        NOT NULL ,
      MaNhanVien CHAR(9) NOT NULL ,
      CONSTRAINT fk_PhieuNhap_NhanVien FOREIGN KEY ( MaNhanVien ) REFERENCES dbo.NhanVien ( MaNhanVien )
    );
    GO
    --Tao bang ChiTietPhieuNhap
CREATE TABLE ChiTietPhieuNhap
    (
      MaPhieuNhap CHAR(9) NOT NULL ,
      MaSP int NOT NULL ,
      SoLuongNhap INT DEFAULT ( 0 )
                      NOT NULL ,
      DonGiaNhap FLOAT DEFAULT ( 0 )
                       NOT NULL ,
      SoLuongNhapTon INT DEFAULT ( 0 )
                         NOT NULL ,
      CONSTRAINT pf_ChiTietPhieuNhap PRIMARY KEY ( MaPhieuNhap, MaSP ) ,
      CONSTRAINT fk_ChiTietPhieuNhap_PhieuNhap FOREIGN KEY ( MaPhieuNhap ) REFERENCES dbo.PhieuNhap ( MaPhieuNhap ) ,
      CONSTRAINT fk_ChiTietPhieuNhap_SanPham FOREIGN KEY ( MaSP ) REFERENCES dbo.SanPham ( MaSP )
    );
    GO 
--Thực hiện thủ tục để lấy danh sách nhập hàng
CREATE PROC PSP_ChiTietPhieuNhap_Select
AS
    SELECT  0 AS STT ,
            a.MaSP ,
            a.TenSP ,
            d.NgayNhap,
            c.SoLuongNhap ,
            a.MaDVT ,
            b.TenDVT,
            c.DonGiaNhap,
            (c.SoLuongNhap*c.DonGiaNhap)AS ThanhTien,
            d.MaNhanVien,
            TenNhanVien,
            c.SoLuongNhapTon
    FROM    dbo.SanPham a
            JOIN dbo.DonViTinh b ON b.MaDVT = a.MaDVT
            JOIN dbo.ChiTietPhieuNhap c ON c.MaSP = a.MaSP
            JOIN dbo.PhieuNhap d ON d.MaPhieuNhap = c.MaPhieuNhap
            JOIN NhanVien e ON e.MaNhanVien = d.MaNhanVien
            WHERE a.IsDelete =0
            ORDER BY c.MaPhieuNhap DESC   
       GO
     --lay ma phieu nhập lớn nhất
     CREATE PROC PSP_PhieuNhap_LayMaxMaPhieuNhap --2021,5
     @Year INT,
     @Month INT
     AS
     SELECT ISNULL(CONVERT(INT,SUBSTRING(MAX(MaPhieuNhap),5,9)),0)+1 as MaxID
     FROM dbo.PhieuNhap
     WHERE YEAR(NgayNhap)=@Year AND MONTH(NgayNhap)=@Month
     