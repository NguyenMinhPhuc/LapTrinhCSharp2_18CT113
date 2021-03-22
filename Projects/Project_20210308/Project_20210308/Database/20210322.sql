alter PROC PSP_NhanVien_Select
AS
    SELECT ROW_NUMBER() OVER ( ORDER BY ( SELECT   1
                                         ) ) AS STT,  MaNhanVien ,
            TenNhanVien ,
            GioiTinh ,
			CASE GioiTinh WHEN 1 THEN N'Nam'ELSE N'Nữ'END AS GioiTinhText,
            NgaySinh ,
            DienThoai ,
            TenDangNhap ,
            MaTaiKhoan
    FROM    dbo.NhanVien
    WHERE   TinhTrang = 1;--1: nhan vien dang hoat dong; 0: nhân viên đã bị xóa
	GO
CREATE PROC PSP_NhanVien_InsertUpdate
@MaNhanVien CHAR(9),
@TenNhanVien NVARCHAR(50),
@GioiTinh BIT,
@NgaySinh DATE,
@DienThoai VARCHAR(20),
@TenDangNhap VARCHAR(50),
@MatKhau VARCHAR(50),
@MaTaiKhoan CHAR(9) 
AS
IF EXISTS (SELECT 1 FROM dbo.NhanVien WHERE MaNhanVien=@MaNhanVien AND TinhTrang=1)
BEGIN--Update
   UPDATE dbo.NhanVien
   SET TenNhanVien=@TenNhanVien,
	GioiTinh=@GioiTinh,
	NgaySinh=@NgaySinh,
	DienThoai=@DienThoai
	WHERE MaNhanVien=@MaNhanVien
END--End Update
BEGIN
    INSERT INTO dbo.NhanVien ( MaNhanVien ,TenNhanVien ,GioiTinh ,NgaySinh ,
              DienThoai ,TenDangNhap , MatKhau , MaTaiKhoan)
    VALUES  ( @MaNhanVien , @TenNhanVien , @GioiTinh , @NgaySinh ,@DienThoai , @TenDangNhap ,pwdencrypt(@MatKhau) , @MaTaiKhoan)
END
GO
CREATE PROC PSP_NhanVien_Delete
@MaNhanVien CHAR(9)
AS
IF EXISTS (SELECT 1 FROM dbo.NhanVien WHERE MaNhanVien=@MaNhanVien AND TinhTrang=1)
BEGIN
    UPDATE dbo.NhanVien
	SET TinhTrang=0
	WHERE MaNhanVien=@MaNhanVien
END

GO
CREATE PROC PSP_TaiKhoan_LayLoaiThaiKhoancbo
AS
SELECT MaTaiKhoan,TenTaiKhoan
FROM dbo.TaiKhoan 
WHERE TinhTrang=1