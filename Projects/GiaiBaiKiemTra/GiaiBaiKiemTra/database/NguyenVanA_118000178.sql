CREATE PROC SP_SanPham_Select
AS
SELECT MaSP, TenSP, DonViTinh, DonGia, CONVERT(BIT,0 ) AS [DELETE]
FROM dbo.SanPham
GO
CREATE PROC SP_SanPham_Delete
@MaSP INT AS
DELETE dbo.SanPham
WHERE MaSP=@MaSP
GO
CREATE PROC SP_SanPham_Insert

 @TenSP NVARCHAR(255), @DonViTinh NVARCHAR(255), @DonGia FLOAT
 AS
 INSERT INTO SanPham( TenSP, DonViTinh, DonGia)
 VALUES( @TenSP, @DonViTinh, @DonGia)
 GO
 CREATE PROC SP_SanPham_BaoCao
 AS
 SELECT ROW_NUMBER() OVER ( ORDER BY ( SELECT   1
                                         ) ) AS STT, MaSP, TenSP, DonViTinh, DonGia
 FROM dbo.SanPham