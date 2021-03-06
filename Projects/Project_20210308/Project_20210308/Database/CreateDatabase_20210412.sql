USE [Data_BanHang_HocTap]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 12/04/2021 13:22:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieuNhap] [char](9) NOT NULL,
	[MaSP] [int] NOT NULL,
	[SoLuongNhap] [int] NOT NULL,
	[DonGiaNhap] [float] NOT NULL,
	[SoLuongNhapTon] [int] NOT NULL,
 CONSTRAINT [pf_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChucNang]    Script Date: 12/04/2021 13:22:01 ******/
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
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 12/04/2021 13:22:01 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiChucNang]    Script Date: 12/04/2021 13:22:01 ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/04/2021 13:22:01 ******/
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
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 12/04/2021 13:22:01 ******/
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
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 12/04/2021 13:22:01 ******/
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
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/04/2021 13:22:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSP] [nvarchar](100) NOT NULL,
	[SoTon] [int] NOT NULL,
	[MaDVT] [int] NOT NULL,
	[IsDelete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/04/2021 13:22:01 ******/
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
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NgaySinh], [DienThoai], [TenDangNhap], [MatKhau], [MaTaiKhoan], [TinhTrang]) VALUES (N'NV0000001', N'Admin', 1, CAST(N'1989-05-04' AS Date), N'0941090099', N'admin', 0x0100DE232226F743D46B11A1C7B42F139CB45E3C9812BB92B5B5, N'TK0000001', 1)
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
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__SanPham__4CF9DC141920BF5C]    Script Date: 12/04/2021 13:22:01 ******/
ALTER TABLE [dbo].[SanPham] ADD UNIQUE NONCLUSTERED 
(
	[TenSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] ADD  DEFAULT ((0)) FOR [SoLuongNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] ADD  DEFAULT ((0)) FOR [DonGiaNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] ADD  DEFAULT ((0)) FOR [SoLuongNhapTon]
GO
ALTER TABLE [dbo].[DonViTinh] ADD  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  DEFAULT (getdate()) FOR [NgayNhap]
GO
ALTER TABLE [dbo].[SanPham] ADD  DEFAULT ((0)) FOR [SoTon]
GO
ALTER TABLE [dbo].[SanPham] ADD  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [fk_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_ChiTietPhieuNhap_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [fk_ChiTietPhieuNhap_SanPham]
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
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_PhieuNhap_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [fk_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [Fk_SanPham_DVT_maDVT] FOREIGN KEY([MaDVT])
REFERENCES [dbo].[DonViTinh] ([MaDVT])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [Fk_SanPham_DVT_maDVT]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [Ck_SoTonLonHonHayBang0] CHECK  (([SoTon]>=(0)))
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [Ck_SoTonLonHonHayBang0]
GO
/****** Object:  StoredProcedure [dbo].[PSP_ChiTietPhieuNhap_Select]    Script Date: 12/04/2021 13:22:01 ******/
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
/****** Object:  StoredProcedure [dbo].[PSP_NhanVien_CheckLogin]    Script Date: 12/04/2021 13:22:01 ******/
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
/****** Object:  StoredProcedure [dbo].[PSP_NhanVien_Delete]    Script Date: 12/04/2021 13:22:01 ******/
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
/****** Object:  StoredProcedure [dbo].[PSP_NhanVien_InsertUpdate]    Script Date: 12/04/2021 13:22:01 ******/
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
/****** Object:  StoredProcedure [dbo].[PSP_NhanVien_Select]    Script Date: 12/04/2021 13:22:01 ******/
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
/****** Object:  StoredProcedure [dbo].[PSP_PhieuNhap_LayMaxMaPhieuNhap]    Script Date: 12/04/2021 13:22:01 ******/
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
/****** Object:  StoredProcedure [dbo].[PSP_TaiKhoan_LayLoaiThaiKhoancbo]    Script Date: 12/04/2021 13:22:01 ******/
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
