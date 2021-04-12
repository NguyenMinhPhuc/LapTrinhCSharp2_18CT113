USE Data_BanHang_HocTap
GO
CREATE PROC PSP_TaiKhoan_LayLoaiThaiKhoancbo
AS
SELECT MaTaiKhoan,TenTaiKhoan
FROM dbo.TaiKhoan 
WHERE TinhTrang= 1 