CREATE DATABASE Data_BanHang_HocTap
GO 
USE [Data_BanHang_HocTap]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 04/19/2021 14:53:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTaiKhoan] [char](9) NOT NULL,
	[TenTaiKhoan] [nvarchar](50) NOT NULL,
	[TinhTrang] [bit] NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [TinhTrang]) VALUES (N'TK0000001', N'Admin', 1)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [TinhTrang]) VALUES (N'TK0000002', N'User Bán hàng', 1)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [TinhTrang]) VALUES (N'TK0000003', N'User Kho', 1)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [TinhTrang]) VALUES (N'TK0000004', N'User Hỗ trợ KT', 0)
/****** Object:  Table [dbo].[LoaiChucNang]    Script Date: 04/19/2021 14:53:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiChucNang](
	[MaNhomChucNang] [int] NOT NULL,
	[TenNhomChucNang] [nvarchar](50) NULL,
	[TinhTrang] [bit] NOT NULL,
 CONSTRAINT [PK_LoaiChucNang] PRIMARY KEY CLUSTERED 
(
	[MaNhomChucNang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LoaiChucNang] ([MaNhomChucNang], [TenNhomChucNang], [TinhTrang]) VALUES (1, N'HeThong', 1)
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 04/19/2021 14:53:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[MaDVT] [int] IDENTITY(1,1) NOT NULL,
	[TenDVT] [nvarchar](10) NOT NULL,
	[IsDelete] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDVT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DonViTinh] ON
INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT], [IsDelete]) VALUES (1, N'Bich', 0)
INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT], [IsDelete]) VALUES (2, N'Cái', 0)
INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT], [IsDelete]) VALUES (3, N'Thùng', 0)
INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT], [IsDelete]) VALUES (4, N'Lon', 0)
SET IDENTITY_INSERT [dbo].[DonViTinh] OFF
/****** Object:  Table [dbo].[NhanVien]    Script Date: 04/19/2021 14:53:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [char](9) NOT NULL,
	[TenNhanVien] [nvarchar](50) NOT NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [date] NULL,
	[DienThoai] [nvarchar](50) NULL,
	[TenDangNhap] [varchar](50) NULL,
	[MatKhau] [varbinary](128) NULL,
	[MaTaiKhoan] [char](9) NOT NULL,
	[TinhTrang] [bit] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NgaySinh], [DienThoai], [TenDangNhap], [MatKhau], [MaTaiKhoan], [TinhTrang]) VALUES (N'NV0000001', N'Admin', 1, CAST(0xD1140B00 AS Date), N'0941090099', N'admin', 0x0100DE232226F743D46B11A1C7B42F139CB45E3C9812BB92B5B5, N'TK0000001', 1)
/****** Object:  Table [dbo].[ChucNang]    Script Date: 04/19/2021 14:53:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChucNang](
	[MaChucNang] [int] IDENTITY(1,1) NOT NULL,
	[TenChucNang] [nvarchar](100) NULL,
	[KyHieu] [varchar](50) NULL,
	[TinhTrang] [bit] NOT NULL,
	[MaNhomChucNang] [int] NULL,
 CONSTRAINT [PK_ChucNang] PRIMARY KEY CLUSTERED 
(
	[MaChucNang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ChucNang] ON
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang], [KyHieu], [TinhTrang], [MaNhomChucNang]) VALUES (13, N'Đăng Xuất', N'Frm_LogIn', 1, 1)
SET IDENTITY_INSERT [dbo].[ChucNang] OFF
/****** Object:  StoredProcedure [dbo].[PSP_DonViTinh_SelectCbo]    Script Date: 04/19/2021 14:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_DonViTinh_SelectCbo]
    AS
    SELECT MaDVT,TenDVT FROM dbo.DonViTinh WHERE IsDelete=0
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 04/19/2021 14:53:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [char](9) NOT NULL,
	[TenSP] [nvarchar](100) NOT NULL,
	[SoTon] [int] NOT NULL,
	[MaDVT] [int] NOT NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK__SanPham__2725081C164452B1] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ__SanPham__4CF9DC141920BF5C] UNIQUE NONCLUSTERED 
(
	[TenSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoTon], [MaDVT], [IsDelete]) VALUES (N'SP0000001', N'keo bien hoa', 0, 1, 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoTon], [MaDVT], [IsDelete]) VALUES (N'SP0000002', N'kẹo biên hòa', 10, 1, 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoTon], [MaDVT], [IsDelete]) VALUES (N'SP0000003', N'bánh bibica', 0, 1, 0)
/****** Object:  StoredProcedure [dbo].[PSP_TaiKhoan_LayLoaiThaiKhoancbo]    Script Date: 04/19/2021 14:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_TaiKhoan_LayLoaiThaiKhoancbo]
AS
SELECT MaTaiKhoan,TenTaiKhoan
FROM dbo.TaiKhoan 
WHERE TinhTrang=1
GO
/****** Object:  StoredProcedure [dbo].[PSP_SanPham_LayMaxMaSP]    Script Date: 04/19/2021 14:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_SanPham_LayMaxMaSP] --2021,5
     AS
     SELECT ISNULL(CONVERT(INT,SUBSTRING(MAX(maSP),3,9)),0)+1 as MaxID
     FROM dbo.SanPham
GO
/****** Object:  StoredProcedure [dbo].[PSP_SanPham_KiemTraSanPhamTheoTen]    Script Date: 04/19/2021 14:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_SanPham_KiemTraSanPhamTheoTen]
  @TenSanPham NVARCHAR(100)
  AS
  IF EXISTS (SELECT 1 FROM SanPham WHERE TenSP=@TenSanPham)
  BEGIN
      SELECT 1 AS result,MaSP, TenSP, SoTon, MaDVT FROM SanPham
	  WHERE  TenSP=@TenSanPham
  END
  ELSE
  BEGIN
       SELECT 0 AS result,''AS TenSP,0 AS SoTon,0 AS MaDVT
  END
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 04/19/2021 14:53:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] [char](9) NOT NULL,
	[NgayNhap] [datetime] NOT NULL,
	[MaNhanVien] [char](9) NOT NULL,
	[StatusPhieuNhap] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [NgayNhap], [MaNhanVien], [StatusPhieuNhap]) VALUES (N'210400001', CAST(0x0000AD0F00F50A75 AS DateTime), N'NV0000001', 1)
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 04/19/2021 14:53:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaChucNang] [int] NOT NULL,
	[MaTaiKhoan] [char](9) NOT NULL,
	[GiaTriQuyen] [int] NOT NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaChucNang] ASC,
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen]) VALUES (13, N'TK0000001', 15)
/****** Object:  StoredProcedure [dbo].[PSP_NhanVien_Select]    Script Date: 04/19/2021 14:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_NhanVien_Select]
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
/****** Object:  StoredProcedure [dbo].[PSP_NhanVien_LayMaxMaNV]    Script Date: 04/19/2021 14:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_NhanVien_LayMaxMaNV] --2021,5
     AS
     SELECT ISNULL(CONVERT(INT,SUBSTRING(MAX(MaNhanVien),3,9)),0)+1 as MaxID
     FROM dbo.NhanVien
GO
/****** Object:  StoredProcedure [dbo].[PSP_NhanVien_InsertUpdate]    Script Date: 04/19/2021 14:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_NhanVien_InsertUpdate]
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
/****** Object:  StoredProcedure [dbo].[PSP_NhanVien_Delete]    Script Date: 04/19/2021 14:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_NhanVien_Delete]
@MaNhanVien CHAR(9)
AS
IF EXISTS (SELECT 1 FROM dbo.NhanVien WHERE MaNhanVien=@MaNhanVien AND TinhTrang=1)
BEGIN
    UPDATE dbo.NhanVien
	SET TinhTrang=0
	WHERE MaNhanVien=@MaNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[PSP_NhanVien_CheckLogin]    Script Date: 04/19/2021 14:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--//////////////////////////////////////////////////////////
--Thủ tục kiểm tra đăng nhập.
CREATE PROC [dbo].[PSP_NhanVien_CheckLogin]
@TenDangNhap VARCHAR(50),
@MatKhau VARCHAR(50)
AS
IF EXISTS (SELECT 1 FROM dbo.NhanVien WHERE TenDangNhap=@TenDangNhap AND pwdCompare(@MatKhau,[MatKhau])=1)
BEGIN
    SELECT 1 AS result, MaNhanVien, TenNhanVien, TenDangNhap, MaTaiKhoan
	FROM dbo.NhanVien 
	WHERE TenDangNhap=@TenDangNhap AND pwdCompare(@MatKhau,[MatKhau])=1 
END
ELSE
BEGIN
    SELECT 0 AS result,'' as MaNhanVien, '' AS TenNhanVien,''as TenDangNhap,''as MaTaiKhoan
END
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 04/19/2021 14:53:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieuNhap] [char](9) NOT NULL,
	[MaSP] [char](9) NOT NULL,
	[SoLuongNhap] [int] NOT NULL,
	[DonGiaNhap] [float] NOT NULL,
	[SoLuongNhapTon] [int] NOT NULL,
 CONSTRAINT [pf_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSP], [SoLuongNhap], [DonGiaNhap], [SoLuongNhapTon]) VALUES (N'210400001', N'SP0000002', 10, 20000, 10)
/****** Object:  StoredProcedure [dbo].[PSP_PhieuNhap_Insert]    Script Date: 04/19/2021 14:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Tạo phiếu nhâp
CREATE PROC [dbo].[PSP_PhieuNhap_Insert]
@MaPhieuNhap CHAR(9), 
@MaNhanVien CHAR(9)
AS
IF NOT EXISTS (SELECT 1 FROM [dbo].[PhieuNhap] WHERE MaPhieuNhap=@MaPhieuNhap)
BEGIN
    INSERT INTO [dbo].[PhieuNhap](MaPhieuNhap, NgayNhap, MaNhanVien)
	VALUES(@MaPhieuNhap, GETDATE(), @MaNhanVien)
END
GO
/****** Object:  StoredProcedure [dbo].[PSP_PhieuNhap_CapNhatTrangThai]    Script Date: 04/19/2021 14:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_PhieuNhap_CapNhatTrangThai]
     @MaPhieuNhap CHAR(9)
     as
     UPDATE dbo.PhieuNhap
     SET StatusPhieuNhap=1
     WHERE MaPhieuNhap=@MaPhieuNhap
GO
/****** Object:  StoredProcedure [dbo].[PSP_PhieuNhap_LayMaxMaPhieuNhap]    Script Date: 04/19/2021 14:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--lay ma phieu nhập lớn nhất
     CREATE PROC [dbo].[PSP_PhieuNhap_LayMaxMaPhieuNhap] --2021,5
     @Year INT,
     @Month INT
     AS
     SELECT ISNULL(CONVERT(INT,SUBSTRING(MAX(MaPhieuNhap),5,9)),0)+1 as MaxID
     FROM dbo.PhieuNhap
     WHERE YEAR(NgayNhap)=@Year AND MONTH(NgayNhap)=@Month
GO
/****** Object:  StoredProcedure [dbo].[PSP_PhieuNhap_KiemTraStatusPhieuNhap]    Script Date: 04/19/2021 14:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_PhieuNhap_KiemTraStatusPhieuNhap]
AS
    IF EXISTS ( SELECT  1
                FROM    PhieuNhap
                WHERE   StatusPhieuNhap = 0 )
        BEGIN
            SET XACT_ABORT ON; 
            BEGIN TRAN;
            DECLARE @MaPhieuNhap CHAR(9);
	--SELECT TOP 1 @MaPhieuNhap =MaPhieuNhap FROM PhieuNhap WHERE StatusPhieuNhap=0
            SET @MaPhieuNhap = ( SELECT TOP 1
                                        MaPhieuNhap
                                 FROM   PhieuNhap
                                 WHERE  StatusPhieuNhap = 0
                               );
            DELETE  [dbo].[ChiTietPhieuNhap]
            WHERE   MaPhieuNhap = @MaPhieuNhap;

            DELETE  PhieuNhap
            WHERE   MaPhieuNhap = @MaPhieuNhap;
            COMMIT;
        END;
GO
/****** Object:  StoredProcedure [dbo].[PSP_PhieuNhap_Delete]    Script Date: 04/19/2021 14:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_PhieuNhap_Delete] --'210400001'
    @MaPhieuNhap CHAR(9)
AS
SET XACT_ABORT ON
BEGIN TRAN
    IF EXISTS ( SELECT  1
                FROM    PhieuNhap
                WHERE   MaPhieuNhap = @MaPhieuNhap )
        BEGIN
            IF EXISTS ( SELECT  1
                        FROM    [dbo].[ChiTietPhieuNhap]
                        WHERE   MaPhieuNhap = @MaPhieuNhap )
                BEGIN
					DELETE [dbo].[ChiTietPhieuNhap]
					where  MaPhieuNhap = @MaPhieuNhap
                END
            DELETE  [dbo].[PhieuNhap]
            WHERE   MaPhieuNhap = @MaPhieuNhap
        END
COMMIT;
GO
/****** Object:  StoredProcedure [dbo].[PSP_ChiTietPhieuNhap_Select]    Script Date: 04/19/2021 14:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Thực hiện thủ tục để lấy danh sách nhập hàng
CREATE PROC [dbo].[PSP_ChiTietPhieuNhap_Select]
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
/****** Object:  StoredProcedure [dbo].[PSP_ChiTietNhap_Insert]    Script Date: 04/19/2021 14:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_ChiTietNhap_Insert]
    @MaPhieuNhap CHAR(9) ,
    @MaSP CHAR(9) ,
    @SoLuongNhap INT ,
    @DonGiaNhap FLOAT ,
    @MaDVT INT ,
    @TenSP NVARCHAR(100)
AS
    SET XACT_ABORT ON; 
    BEGIN TRAN;
    IF EXISTS ( SELECT  1
                FROM    dbo.ChiTietPhieuNhap
                WHERE   MaPhieuNhap = @MaPhieuNhap
                        AND MaSP = @MaSP )
        BEGIN --update so luong
            UPDATE  dbo.ChiTietPhieuNhap
            SET     SoLuongNhap+= @SoLuongNhap ,
                    SoLuongNhapTon = SoLuongNhap
            WHERE   MaPhieuNhap = @MaPhieuNhap
                    AND MaSP = @MaSP;
        END;--Update so luong
    ELSE
        BEGIN--Insert san pham moi
            IF NOT EXISTS ( SELECT  1
                            FROM    dbo.SanPham
                            WHERE   MaSP = @MaSP )
                BEGIN
                    INSERT  INTO dbo.SanPham
                            (MaSP, TenSP, SoTon, MaDVT, IsDelete )
                    VALUES  (@MaSP, @TenSP, 0, @MaDVT, 0 );
	
                END;
            INSERT  INTO ChiTietPhieuNhap
                    ( MaPhieuNhap ,
                      MaSP ,
                      SoLuongNhap ,
                      DonGiaNhap ,
                      SoLuongNhapTon
                    )
            VALUES  ( @MaPhieuNhap ,
                      @MaSP ,
                      @SoLuongNhap ,
                      @DonGiaNhap ,
                      @SoLuongNhap
                    );
        END;--insert san pham moi
--them vao so luong ton trong bang san pham
    UPDATE  dbo.SanPham
    SET     SoTon+= @SoLuongNhap
    WHERE   MaSP = @MaSP;
    COMMIT;
GO
/****** Object:  Default [DF__ChiTietPh__SoLuo__267ABA7A]    Script Date: 04/19/2021 14:53:50 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap] ADD  CONSTRAINT [DF__ChiTietPh__SoLuo__267ABA7A]  DEFAULT ((0)) FOR [SoLuongNhap]
GO
/****** Object:  Default [DF__ChiTietPh__DonGi__276EDEB3]    Script Date: 04/19/2021 14:53:50 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap] ADD  CONSTRAINT [DF__ChiTietPh__DonGi__276EDEB3]  DEFAULT ((0)) FOR [DonGiaNhap]
GO
/****** Object:  Default [DF__ChiTietPh__SoLuo__286302EC]    Script Date: 04/19/2021 14:53:50 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap] ADD  CONSTRAINT [DF__ChiTietPh__SoLuo__286302EC]  DEFAULT ((0)) FOR [SoLuongNhapTon]
GO
/****** Object:  Default [DF__DonViTinh__IsDel__1367E606]    Script Date: 04/19/2021 14:53:50 ******/
ALTER TABLE [dbo].[DonViTinh] ADD  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF__PhieuNhap__NgayN__22AA2996]    Script Date: 04/19/2021 14:53:50 ******/
ALTER TABLE [dbo].[PhieuNhap] ADD  DEFAULT (getdate()) FOR [NgayNhap]
GO
/****** Object:  Default [DF_PhieuNhap_StatusPhieuNhap]    Script Date: 04/19/2021 14:53:50 ******/
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [DF_PhieuNhap_StatusPhieuNhap]  DEFAULT ((0)) FOR [StatusPhieuNhap]
GO
/****** Object:  Default [DF__SanPham__SoTon__1B0907CE]    Script Date: 04/19/2021 14:53:50 ******/
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [DF__SanPham__SoTon__1B0907CE]  DEFAULT ((0)) FOR [SoTon]
GO
/****** Object:  Default [DF__SanPham__IsDelet__1BFD2C07]    Script Date: 04/19/2021 14:53:50 ******/
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [DF__SanPham__IsDelet__1BFD2C07]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Check [Ck_SoTonLonHonHayBang0]    Script Date: 04/19/2021 14:53:50 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [Ck_SoTonLonHonHayBang0] CHECK  (([SoTon]>=(0)))
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [Ck_SoTonLonHonHayBang0]
GO
/****** Object:  ForeignKey [fk_ChiTietPhieuNhap_PhieuNhap]    Script Date: 04/19/2021 14:53:50 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [fk_ChiTietPhieuNhap_PhieuNhap]
GO
/****** Object:  ForeignKey [fk_ChiTietPhieuNhap_SanPham]    Script Date: 04/19/2021 14:53:50 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_ChiTietPhieuNhap_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [fk_ChiTietPhieuNhap_SanPham]
GO
/****** Object:  ForeignKey [FK_ChucNang_LoaiChucNang]    Script Date: 04/19/2021 14:53:50 ******/
ALTER TABLE [dbo].[ChucNang]  WITH CHECK ADD  CONSTRAINT [FK_ChucNang_LoaiChucNang] FOREIGN KEY([MaNhomChucNang])
REFERENCES [dbo].[LoaiChucNang] ([MaNhomChucNang])
GO
ALTER TABLE [dbo].[ChucNang] CHECK CONSTRAINT [FK_ChucNang_LoaiChucNang]
GO
/****** Object:  ForeignKey [FK_NhanVien_TaiKhoan]    Script Date: 04/19/2021 14:53:50 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
GO
/****** Object:  ForeignKey [FK_PhanQuyen_ChucNang]    Script Date: 04/19/2021 14:53:50 ******/
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_ChucNang] FOREIGN KEY([MaChucNang])
REFERENCES [dbo].[ChucNang] ([MaChucNang])
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_ChucNang]
GO
/****** Object:  ForeignKey [FK_PhanQuyen_TaiKhoan]    Script Date: 04/19/2021 14:53:50 ******/
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_TaiKhoan]
GO
/****** Object:  ForeignKey [fk_PhieuNhap_NhanVien]    Script Date: 04/19/2021 14:53:50 ******/
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_PhieuNhap_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [fk_PhieuNhap_NhanVien]
GO
/****** Object:  ForeignKey [Fk_SanPham_DVT_maDVT]    Script Date: 04/19/2021 14:53:50 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [Fk_SanPham_DVT_maDVT] FOREIGN KEY([MaDVT])
REFERENCES [dbo].[DonViTinh] ([MaDVT])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [Fk_SanPham_DVT_maDVT]
GO
