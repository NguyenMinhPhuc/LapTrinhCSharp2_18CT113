CREATE DATABASE QuanLyBanHang_WF
GO 
USE [QuanLyBanHang_WF]
GO
/****** Object:  Table [dbo].[ChucNang]    Script Date: 15/03/2021 13:40:03 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiChucNang]    Script Date: 15/03/2021 13:40:03 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 15/03/2021 13:40:03 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 15/03/2021 13:40:03 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 15/03/2021 13:40:03 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ChucNang] ON 

GO
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang], [KyHieu], [TinhTrang], [MaNhomChucNang]) VALUES (13, N'Đăng Xuất', N'Frm_LogIn', 1, 1)
GO
SET IDENTITY_INSERT [dbo].[ChucNang] OFF
GO
INSERT [dbo].[LoaiChucNang] ([MaNhomChucNang], [TenNhomChucNang], [TinhTrang]) VALUES (1, N'HeThong', 1)
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NgaySinh], [DienThoai], [TenDangNhap], [MatKhau], [MaTaiKhoan], [TinhTrang]) VALUES (N'NV0000001', N'Admin', 1, CAST(N'1989-05-04' AS Date), N'0941090099', N'admin', 0x01004D9E15CA10CBB41732627614C403AB13F8CFB4531AA42240, N'TK0000001', 1)
GO
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen]) VALUES (13, N'TK0000001', 15)
GO
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [TinhTrang]) VALUES (N'TK0000001', N'Admin', 1)
GO
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [TinhTrang]) VALUES (N'TK0000002', N'User Bán hàng', 1)
GO
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [TinhTrang]) VALUES (N'TK0000003', N'User Kho', 1)
GO
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [TinhTrang]) VALUES (N'TK0000004', N'User Hỗ trợ KT', 0)
GO
ALTER TABLE [dbo].[ChucNang]  WITH CHECK ADD  CONSTRAINT [FK_ChucNang_LoaiChucNang] FOREIGN KEY([MaNhomChucNang])
REFERENCES [dbo].[LoaiChucNang] ([MaNhomChucNang])
GO
ALTER TABLE [dbo].[ChucNang] CHECK CONSTRAINT [FK_ChucNang_LoaiChucNang]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_ChucNang] FOREIGN KEY([MaChucNang])
REFERENCES [dbo].[ChucNang] ([MaChucNang])
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_ChucNang]
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_TaiKhoan]
GO
--//////////////////////////////////////////////////////////
--Thủ tục kiểm tra đăng nhập.
CREATE PROC PSP_NhanVien_CheckLogin
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
EXEC PSP_NhanVien_CheckLogin 'admin','123456'
--Mẫu đổi mật khẩu
UPDATE dbo.NhanVien
SET MatKhau=pwdencrypt('123456')
WHERE TenDangNhap='admin'