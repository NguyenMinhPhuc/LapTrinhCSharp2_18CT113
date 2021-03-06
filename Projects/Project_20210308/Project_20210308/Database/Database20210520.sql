USE [Data_BanHang_HocTap]
GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 05/20/2021 15:29:36 ******/
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
/****** Object:  Table [dbo].[SanPham]    Script Date: 05/20/2021 15:29:36 ******/
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
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoTon], [MaDVT], [IsDelete]) VALUES (N'SP0000002', N'kẹo biên hòa', 70, 1, 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoTon], [MaDVT], [IsDelete]) VALUES (N'SP0000003', N'bánh bibica', 0, 1, 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoTon], [MaDVT], [IsDelete]) VALUES (N'SP0000004', N'bánh đa', 70, 2, 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoTon], [MaDVT], [IsDelete]) VALUES (N'SP0000005', N'Test', 0, 1, 0)
/****** Object:  StoredProcedure [dbo].[PSP_SanPham_LayMaxMaSP]    Script Date: 05/20/2021 15:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_SanPham_LayMaxMaSP] --2021,5
     AS
     SELECT ISNULL(CONVERT(INT,SUBSTRING(MAX(maSP),3,9)),0)+1 as MaxID
     FROM dbo.SanPham
GO
/****** Object:  StoredProcedure [dbo].[PSP_SanPham_KiemTraSanPhamTheoTen]    Script Date: 05/20/2021 15:29:40 ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 05/20/2021 15:29:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTaiKhoan] [char](9) NOT NULL,
	[TenTaiKhoan] [nvarchar](50) NOT NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [IsDelete]) VALUES (N'TK0000001', N'Admin', 0)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [IsDelete]) VALUES (N'TK0000002', N'User Bán hàng', 0)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [IsDelete]) VALUES (N'TK0000003', N'User Kho', 0)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [IsDelete]) VALUES (N'TK0000004', N'User Hỗ trợ KT', 0)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [IsDelete]) VALUES (N'TK0000005', N'UserTest', 0)
/****** Object:  StoredProcedure [dbo].[PSP_TaiKhoan_SelectCbo]    Script Date: 05/20/2021 15:29:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_TaiKhoan_SelectCbo]
          AS
          SELECT MaTaiKhoan, TenTaiKhoan
          FROM dbo.TaiKhoan WHERE IsDelete=0
GO
/****** Object:  StoredProcedure [dbo].[PSP_TaiKhoan_Select]    Script Date: 05/20/2021 15:29:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_TaiKhoan_Select]
AS
SELECT 0 AS STT, MaTaiKhoan, TenTaiKhoan
FROM dbo.TaiKhoan
WHERE IsDelete=0
GO
/****** Object:  StoredProcedure [dbo].[PSP_TaiKhoan_MaxID]    Script Date: 05/20/2021 15:29:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_TaiKhoan_MaxID]
AS
SELECT ISNULL(CONVERT(INT,SUBSTRING(MAX(MaTaiKhoan),3,9)),0)+1 AS MaxID
FROM dbo.TaiKhoan
GO
/****** Object:  StoredProcedure [dbo].[PSP_TaiKhoan_LayLoaiThaiKhoancbo]    Script Date: 05/20/2021 15:29:41 ******/
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
/****** Object:  StoredProcedure [dbo].[PSP_TaiKhoan_InsertUpdate]    Script Date: 05/20/2021 15:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_TaiKhoan_InsertUpdate]
@MaTaiKhoan CHAR(9), @TenTaiKhoan NVARCHAR(50)
AS
IF EXISTS(SELECT 1 FROM dbo.TaiKhoan WHERE MaTaiKhoan=@MaTaiKhoan)
BEGIN
    --update
    UPDATE dbo.TaiKhoan
    SET TenTaiKhoan=@TenTaiKhoan
    WHERE MaTaiKhoan=@MaTaiKhoan
END
ELSE
BEGIN
    INSERT INTO TaiKhoan(MaTaiKhoan, TenTaiKhoan, IsDelete)
    VALUES(@MaTaiKhoan, @TenTaiKhoan, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[PSP_TaiKhoan_Delete]    Script Date: 05/20/2021 15:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_TaiKhoan_Delete]
@MaTaiKhoan CHAR(9)
AS
UPDATE dbo.TaiKhoan
SET IsDelete=1
WHERE MaTaiKhoan=@MaTaiKhoan
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 05/20/2021 15:29:36 ******/
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
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NgaySinh], [DienThoai], [TenDangNhap], [MatKhau], [MaTaiKhoan], [TinhTrang]) VALUES (N'NV0000001', N'Admin', 1, CAST(0xD1140B00 AS Date), N'0941090099', N'admin', 0x0100876F5A05A78DA48375C095E86747FB5EBFDF947F2F1D26E8, N'TK0000001', 1)
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 05/20/2021 15:29:36 ******/
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
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [NgayNhap], [MaNhanVien], [StatusPhieuNhap]) VALUES (N'210400002', CAST(0x0000AD0F010ADD8C AS DateTime), N'NV0000001', 1)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [NgayNhap], [MaNhanVien], [StatusPhieuNhap]) VALUES (N'210400003', CAST(0x0000AD0F010E32CA AS DateTime), N'NV0000001', 1)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [NgayNhap], [MaNhanVien], [StatusPhieuNhap]) VALUES (N'210500001', CAST(0x0000AD1D00F5D635 AS DateTime), N'NV0000001', 1)
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 05/20/2021 15:29:36 ******/
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
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSP], [SoLuongNhap], [DonGiaNhap], [SoLuongNhapTon]) VALUES (N'210400002', N'SP0000004', 20, 5000, 20)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSP], [SoLuongNhap], [DonGiaNhap], [SoLuongNhapTon]) VALUES (N'210400003', N'SP0000002', 10, 20000, 10)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSP], [SoLuongNhap], [DonGiaNhap], [SoLuongNhapTon]) VALUES (N'210500001', N'SP0000002', 20, 20000, 20)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSP], [SoLuongNhap], [DonGiaNhap], [SoLuongNhapTon]) VALUES (N'210500001', N'SP0000004', 10, 10000, 10)
/****** Object:  Trigger [tg_ChiTietPhieuNhap_Update]    Script Date: 05/20/2021 15:29:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Trigger [dbo].[tg_ChiTietPhieuNhap_Update] On [dbo].[ChiTietPhieuNhap]
For Update As

--Cập nhật số lượng tồn trong bảng SanPham
Update dbo.SanPham Set SoTon = SoTon - b.SoLuongNhap + c.SoLuongNhap
From SanPham a, DELETED b, INSERTED c
Where a.MaSP = b.MaSP And a.MaSP = c.MaSP
GO
/****** Object:  Trigger [tg_ChiTietPhieuNhap_Insert]    Script Date: 05/20/2021 15:29:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Các thủ tục được thêm mới trong buổi học 2021-04-19
--Tạo Trigger để kiểm Soát số lượng tồn của Sản phẩm
CREATE TRIGGER [dbo].[tg_ChiTietPhieuNhap_Insert] ON [dbo].[ChiTietPhieuNhap]
    FOR INSERT
AS
    UPDATE  dbo.SanPham
    SET     SoTon += SoLuongNhap
    FROM    Inserted
    WHERE   dbo.SanPham.MaSP = Inserted.MaSP;
GO
/****** Object:  Trigger [tg_ChiTietPhieuNhap_Delete]    Script Date: 05/20/2021 15:29:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tg_ChiTietPhieuNhap_Delete] ON [dbo].[ChiTietPhieuNhap]
FOR DELETE
AS 
UPDATE  dbo.SanPham
    SET     SoTon -= SoLuongNhap
    FROM    Deleted
    WHERE   dbo.SanPham.MaSP = Deleted.MaSP;
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 05/20/2021 15:29:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [char](9) NOT NULL,
	[NgayLap] [datetime] NULL,
	[MaNhanVien] [char](9) NOT NULL,
	[GiamGia] [float] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 05/20/2021 15:29:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [char](9) NOT NULL,
	[MaSP] [char](9) NOT NULL,
	[SoLuongBan] [int] NOT NULL,
	[DonGiaBan] [float] NOT NULL,
	[GiamGia] [float] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Trigger [tg_TuDongTruTonKhiBan_Insert]    Script Date: 05/20/2021 15:29:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--trigger  tru ton khi ban
--Chua test 2021-05-17
CREATE TRIGGER [dbo].[tg_TuDongTruTonKhiBan_Insert] ON [dbo].[ChiTietHoaDon]
    FOR INSERT
AS
    SET XACT_ABORT ON; 
    BEGIN TRAN;

    DECLARE @SoLuongBan INT;
    DECLARE @MaSP CHAR(9);
    SELECT  @SoLuongBan = SoLuongBan ,
            @MaSP = MaSP
    FROM    Inserted;

	--tru so luong nhap ton
    DECLARE @MaSPNhap CHAR(9);
    DECLARE @SoLuongNhapTon INT; 
    DECLARE _Users_Cur CURSOR FAST_FORWARD
    FOR
        SELECT  MaSP ,
                SoLuongNhapTon
        FROM    dbo.ChiTietPhieuNhap
        WHERE   MaSP = @MaSP
        ORDER BY MaPhieuNhap ASC;
 
    OPEN _Users_Cur;
    FETCH NEXT FROM _Users_Cur INTO @MaSP, @SoLuongNhapTon; 
    WHILE @@FETCH_STATUS = 0
        BEGIN
            IF @SoLuongBan > 0
                BEGIN
                  --Thuc hien thao tac cap nhat ton
                    IF @SoLuongBan <= @SoLuongNhapTon--TruongHopNhoHOn
                        BEGIN
                            UPDATE  dbo.ChiTietPhieuNhap
                            SET     SoLuongNhapTon-= @SoLuongBan
                            WHERE   MaSP = @MaSP;
                      
                            SET @SoLuongBan = 0;
                        END;
                    ELSE--truong hop > 
                        BEGIN
                            UPDATE  dbo.ChiTietPhieuNhap
                            SET     SoLuongNhapTon = 0
                            WHERE   MaSP = @MaSP;
                      
                            SET @SoLuongBan = @SoLuongNhapTon - @SoLuongBan;
                        END;
                END;
            FETCH NEXT FROM _Users_Cur INTO @MaSP, @SoLuongNhapTon;
        END;
    CLOSE _Users_Cur;
    DEALLOCATE _Users_Cur;
	--tru so luong ton san pham
    UPDATE  dbo.SanPham
    SET     SoTon-= @SoLuongBan
    WHERE   MaSP = @MaSP;
    COMMIT;
GO
/****** Object:  Table [dbo].[ChiTietGiaBan]    Script Date: 05/20/2021 15:29:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietGiaBan](
	[MaSP] [char](9) NOT NULL,
	[LanThayDoi] [int] NOT NULL,
	[NgayTao] [date] NOT NULL,
	[DonGia] [float] NOT NULL,
	[TinhTrang] [bit] NOT NULL,
	[NgayApDung] [date] NOT NULL,
 CONSTRAINT [PK_ChiTietGiaBan] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC,
	[LanThayDoi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietGiaBan] ([MaSP], [LanThayDoi], [NgayTao], [DonGia], [TinhTrang], [NgayApDung]) VALUES (N'SP0000005', 1, CAST(0x85420B00 AS Date), 0, 1, CAST(0x85420B00 AS Date))
/****** Object:  Trigger [TuDongThemGiaBan]    Script Date: 05/20/2021 15:29:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TuDongThemGiaBan] ON [dbo].[SanPham]
FOR INSERT
AS
    
DECLARE @MaSP CHAR(9)
SET @MaSP =(SELECT MaSP FROM Inserted)
INSERT INTO ChiTietGiaBan(MaSP, LanThayDoi, NgayTao, DonGia, TinhTrang, NgayApDung)
VALUES(@MaSP,1,GETDATE(),0,1,GETDATE())
GO
/****** Object:  StoredProcedure [dbo].[PSP_ChiTietNhap_Insert]    Script Date: 05/20/2021 15:29:40 ******/
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
/****** Object:  StoredProcedure [dbo].[PSP_ChiTietGiaBan_UpdateGia]    Script Date: 05/20/2021 15:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_ChiTietGiaBan_UpdateGia]
    @MaSP CHAR(9),
    @DonGia FLOAT
    AS
    SET XACT_ABORT ON
    BEGIN TRAN
    DECLARE @LanTaoMax INT
    SET @LanTaoMax=(SELECT MAX(LanThayDoi)+1 FROM dbo.ChiTietGiaBan WHERE MaSP=@MaSP)
    
		UPDATE	dbo.ChiTietGiaBan
		SET TinhTrang=0
		WHERE MaSP=@MaSP
		
		INSERT INTO dbo.ChiTietGiaBan
		        ( MaSP ,
		          LanThayDoi ,
		          NgayTao ,
		          DonGia ,
		          TinhTrang ,
		          NgayApDung
		        )
		VALUES  ( @MaSP , -- MaSP - char(9)
		          @LanTaoMax , -- LanThayDoi - int
		          GETDATE() , -- NgayTao - date
		          @DonGia , -- DonGia - float
		          1 , -- TinhTrang - bit
		          GETDATE()  -- NgayApDung - date
		        )
    COMMIT
GO
/****** Object:  StoredProcedure [dbo].[PSP_ChiTietGiaban_Select]    Script Date: 05/20/2021 15:29:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_ChiTietGiaban_Select]
AS
    SELECT  0 AS STT ,
            b.MaSP ,
            b.TenSP ,
           ISNULL( a.NgayTao ,GETDATE()) AS NgayTao,
             ISNULL( a.NgayApDung ,GETDATE()) AS NgayTao,
           ISNULL( a.DonGia,0)AS DonGiaHienHanh
    FROM    dbo.SanPham b LEFT join dbo.ChiTietGiaBan a
            ON b.MaSP = a.MaSP
    WHERE   b.IsDelete = 0 AND a.TinhTrang=1
    ORDER BY b.TenSP;
GO
/****** Object:  StoredProcedure [dbo].[PSP_PhieuNhap_LayMaxMaPhieuNhap]    Script Date: 05/20/2021 15:29:40 ******/
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
/****** Object:  StoredProcedure [dbo].[PSP_PhieuNhap_KiemTraStatusPhieuNhap]    Script Date: 05/20/2021 15:29:40 ******/
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
/****** Object:  StoredProcedure [dbo].[PSP_PhieuNhap_Insert]    Script Date: 05/20/2021 15:29:40 ******/
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
/****** Object:  StoredProcedure [dbo].[PSP_PhieuNhap_Delete]    Script Date: 05/20/2021 15:29:40 ******/
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
/****** Object:  StoredProcedure [dbo].[PSP_PhieuNhap_CapNhatTrangThai]    Script Date: 05/20/2021 15:29:40 ******/
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
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 05/20/2021 15:29:36 ******/
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
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaChucNang] ASC,
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (13, N'TK0000001', 11, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (13, N'TK0000002', 8, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (13, N'TK0000003', 5, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (13, N'TK0000004', 11, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (13, N'TK0000005', 11, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (17, N'TK0000001', 3, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (17, N'TK0000002', 0, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (17, N'TK0000003', 7, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (17, N'TK0000004', 3, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (17, N'TK0000005', 3, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (18, N'TK0000001', 15, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (18, N'TK0000002', 0, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (18, N'TK0000003', 0, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (18, N'TK0000004', 0, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (18, N'TK0000005', 15, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (19, N'TK0000001', 7, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (19, N'TK0000002', 0, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (19, N'TK0000003', 0, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (19, N'TK0000004', 7, 0)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen], [IsDelete]) VALUES (19, N'TK0000005', 7, 0)
/****** Object:  Table [dbo].[LoaiChucNang]    Script Date: 05/20/2021 15:29:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiChucNang](
	[MaNhomChucNang] [int] NOT NULL,
	[TenNhomChucNang] [nvarchar](50) NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_LoaiChucNang] PRIMARY KEY CLUSTERED 
(
	[MaNhomChucNang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LoaiChucNang] ([MaNhomChucNang], [TenNhomChucNang], [IsDelete]) VALUES (1, N'HeThong', 1)
/****** Object:  Table [dbo].[ChucNang]    Script Date: 05/20/2021 15:29:36 ******/
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
	[MaNhomChucNang] [int] NOT NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_ChucNang] PRIMARY KEY CLUSTERED 
(
	[MaChucNang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ChucNang] ON
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang], [KyHieu], [MaNhomChucNang], [IsDelete]) VALUES (13, N'Đăng Xuất', N'Frm_LogIn', 1, 0)
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang], [KyHieu], [MaNhomChucNang], [IsDelete]) VALUES (17, N'Đổi mật khẩu', N'Frm_DoiMatKhau', 1, 0)
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang], [KyHieu], [MaNhomChucNang], [IsDelete]) VALUES (18, N'Phân quyền', N'Frm_PhanQuyen', 1, 0)
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang], [KyHieu], [MaNhomChucNang], [IsDelete]) VALUES (19, N'Nhập hàng', N'Frm_NhapSanPham_Main', 1, 0)
SET IDENTITY_INSERT [dbo].[ChucNang] OFF
/****** Object:  Trigger [TuDongThemQuyen_Insert]    Script Date: 05/20/2021 15:29:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TuDongThemQuyen_Insert] ON [dbo].[ChucNang]
FOR INSERT
AS
    IF EXISTS ( SELECT  1
                FROM dbo.TaiKhoan 
                WHERE  IsDelete = 0 )
        BEGIN
            DECLARE @MaChucNang CHAR(9);
            SET @MaChucNang = ( SELECT  MaChucNang  
                              FROM      Inserted
                            );
    
           
			DECLARE @MaTaiKhoan CHAR(9);
            DECLARE _Users_Cur CURSOR FAST_FORWARD
            FOR
                SELECT  MaTaiKhoan
                FROM   dbo.TaiKhoan
                WHERE  IsDelete=0 ;
 
            OPEN _Users_Cur;
            FETCH NEXT FROM _Users_Cur INTO @MaTaiKhoan; 
            WHILE @@FETCH_STATUS = 0
                BEGIN
                    INSERT  INTO dbo.PhanQuyen 
                            ( MaChucNang, MaTaiKhoan, GiaTriQuyen)
                    VALUES  ( @MaChucNang,@MaTaiKhoan,0)
                            
                    FETCH NEXT FROM _Users_Cur INTO @MaTaiKhoan;
                END;
            CLOSE _Users_Cur;
            DEALLOCATE _Users_Cur;
        END;
GO
/****** Object:  StoredProcedure [dbo].[PSP_PhanQuyen_Update]    Script Date: 05/20/2021 15:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_PhanQuyen_Update]
          @MaTaiKhoan CHAR(9),
          @MaChucNang INT,
          @TongQuyen INT
          AS UPDATE 
          dbo.PhanQuyen
          SET GiaTriQuyen=@TongQuyen
          WHERE MaChucNang=@MaChucNang AND MaTaiKhoan=@MaTaiKhoan
GO
/****** Object:  StoredProcedure [dbo].[PSP_PhanQuyen_HienThiChiTietPhanQuyen]    Script Date: 05/20/2021 15:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_PhanQuyen_HienThiChiTietPhanQuyen] @MaTaiKhoan CHAR(9)
AS
    SELECT  ROW_NUMBER() OVER ( ORDER BY ( SELECT  b.TenChucNang
                                         ) ) AS STT ,
            a.MaTaiKhoan ,
            a.MaChucNang ,
            b.TenChucNang ,
            a.GiaTriQuyen ,
            CONVERT(BIT, 0) AS Xem ,
            CONVERT(BIT, 0) AS Them ,
            CONVERT(BIT, 0) AS Sua ,
            CONVERT(BIT, 0) AS Xoa
    FROM    dbo.PhanQuyen a
            JOIN dbo.ChucNang b ON b.MaChucNang = a.MaChucNang
            JOIN dbo.TaiKhoan c ON c.MaTaiKhoan = a.MaTaiKhoan
          WHERE a.MaTaiKhoan=@MaTaiKhoan
          ORDER BY b.TenChucNang
GO
/****** Object:  StoredProcedure [dbo].[PSP_PhanQuyen_CopyQuyen]    Script Date: 05/20/2021 15:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_PhanQuyen_CopyQuyen]-- 'TK0000005','TK0000001'
   @MaTaiKhoanNguon CHAR(9),  @MaTaiKhoanDich CHAR(9) 
   
AS
    BEGIN
        DECLARE @MaChucNangNguon CHAR(9);
        DECLARE @GiaTriQuyen INT;
        DECLARE _Users_Cur CURSOR FAST_FORWARD
        FOR --cau leenh lay danh sach
            SELECT  MaChucNang ,
                    GiaTriQuyen
            FROM    dbo.PhanQuyen
            WHERE   IsDelete = 0
                    AND MaTaiKhoan = @MaTaiKhoanNguon;
 
        OPEN _Users_Cur;
        FETCH NEXT FROM _Users_Cur INTO @MaChucNangNguon, @GiaTriQuyen;
        WHILE @@FETCH_STATUS = 0
            BEGIN --cau lenh thuc th
                UPDATE  dbo.PhanQuyen
                SET     GiaTriQuyen = @GiaTriQuyen
                WHERE   MaTaiKhoan = @MaTaiKhoanDich
                        AND MaChucNang = @MaChucNangNguon;
                            
                FETCH NEXT FROM _Users_Cur INTO @MaChucNangNguon, @GiaTriQuyen;
            END;
        CLOSE _Users_Cur;
        DEALLOCATE _Users_Cur;
    END;
GO
/****** Object:  Trigger [AutoInsertPermissionByCommand_Update]    Script Date: 05/20/2021 15:29:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AutoInsertPermissionByCommand_Update] ON [dbo].[ChucNang]
    FOR UPDATE
AS
    IF EXISTS ( SELECT  1
                FROM  TaiKhoan
                WHERE  IsDelete=0 )
        BEGIN
                DECLARE @MaTaiKhoan CHAR(9) ;
                 DECLARE @MaChucNang INT;
                SET @MaChucNang = ( SELECT    Inserted.MaChucNang
                                  FROM      Inserted
                                );
    
               
                DECLARE @IsDelete BIT;
				SET @IsDelete = ( SELECT    IsDelete
                                  FROM      Inserted
                                );
                DECLARE _Users_Cur CURSOR FAST_FORWARD
                FOR
                    SELECT  MaTaiKhoan
                    FROM  dbo.TaiKhoan 
                    WHERE   IsDelete=0
 
                OPEN _Users_Cur;
                FETCH NEXT FROM _Users_Cur INTO @MaTaiKhoan; 
                WHILE @@FETCH_STATUS = 0
                    BEGIN
                       UPDATE dbo.PhanQuyen
                       SET IsDelete=@IsDelete
                        WHERE   MaTaiKhoan = @MaTaiKhoan
                                AND MaChucNang = @MaChucNang;
                        FETCH NEXT FROM _Users_Cur INTO @MaTaiKhoan;
                    END;
            CLOSE _Users_Cur;
            DEALLOCATE _Users_Cur;
        END;
GO
/****** Object:  Trigger [AutoInsertPermissionByCommand_Delete]    Script Date: 05/20/2021 15:29:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AutoInsertPermissionByCommand_Delete] ON [dbo].[ChucNang]
    FOR DELETE
AS
    IF EXISTS ( SELECT  1
                FROM    dbo.TaiKhoan
                WHERE   IsDelete = 10 )
        BEGIN
         
            DECLARE @MaTaiKhoan CHAR(9);
            DECLARE @MaChucNang INT;
            SET @MaChucNang = ( SELECT  MaChucNang
                                FROM    Deleted
                              );
            DECLARE _Users_Cur CURSOR FAST_FORWARD
            FOR
                SELECT  MaTaiKhoan
                FROM    dbo.TaiKhoan
                WHERE   IsDelete = 0;
 
            OPEN _Users_Cur;
            FETCH NEXT FROM _Users_Cur INTO @MaTaiKhoan; 
            WHILE @@FETCH_STATUS = 0
                BEGIN
                    DELETE  dbo.PhanQuyen
                    WHERE   MaTaiKhoan = @MaTaiKhoan
                            AND MaChucNang = @MaChucNang;
                    FETCH NEXT FROM _Users_Cur INTO @MaTaiKhoan;
                END;
            CLOSE _Users_Cur;
            DEALLOCATE _Users_Cur;
        END;
GO
/****** Object:  Trigger [AutoInsertPermission_Update]    Script Date: 05/20/2021 15:29:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AutoInsertPermission_Update] ON [dbo].[TaiKhoan]
    FOR UPDATE
AS
    IF EXISTS ( SELECT  1
                FROM    dbo.ChucNang
                WHERE   IsDelete = 0 )
        BEGIN
                DECLARE @MaTaiKhoan CHAR(9);
                SET @MaTaiKhoan = ( SELECT    Inserted.MaTaiKhoan
                                  FROM      Inserted
                                );
    
                DECLARE @MaChucNang INT;
                DECLARE @IsDelete BIT;
				SET @IsDelete = ( SELECT    Inserted.IsDelete
                                  FROM      Inserted
                                );
                DECLARE _Command_Cur CURSOR FAST_FORWARD
                FOR
                    SELECT  MaChucNang
                    FROM    dbo.ChucNang
                    WHERE   IsDelete = 0;
 
                OPEN _Command_Cur;
                FETCH NEXT FROM _Command_Cur INTO @MaChucNang; 
                WHILE @@FETCH_STATUS = 0
                    BEGIN
                       UPDATE dbo.PhanQuyen
                       SET IsDelete=@IsDelete
                        WHERE   MaTaiKhoan = @MaTaiKhoan
                                AND MaChucNang = @MaChucNang;
                        FETCH NEXT FROM _Command_Cur INTO @MaChucNang;
                    END;
            CLOSE _Command_Cur;
            DEALLOCATE _Command_Cur;
        END;
GO
/****** Object:  Trigger [AutoInsertPermission_Insert]    Script Date: 05/20/2021 15:29:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AutoInsertPermission_Insert] ON [dbo].[TaiKhoan]
    FOR INSERT
AS
    IF EXISTS ( SELECT  1
                FROM    dbo.ChucNang
                WHERE   IsDelete = 0 )
        BEGIN
            DECLARE @UserName VARCHAR(20);
            SET @UserName = ( SELECT   Inserted.MaTaiKhoan
                              FROM      Inserted
                            );
    
            DECLARE @MaChucNang INT;
    
            DECLARE _Command_Cur CURSOR FAST_FORWARD
            FOR
                SELECT  MaChucNang
                FROM    dbo.ChucNang
                WHERE   IsDelete = 0;
 
            OPEN _Command_Cur;
            FETCH NEXT FROM _Command_Cur INTO @MaChucNang; 
            WHILE @@FETCH_STATUS = 0
                BEGIN
                    INSERT  INTO dbo.PhanQuyen
                            (MaChucNang, MaTaiKhoan, GiaTriQuyen, IsDelete 
                            )
                    VALUES  ( @MaChucNang,@UserName,0,0
                            );
                    FETCH NEXT FROM _Command_Cur INTO @MaChucNang;
                END;
            CLOSE _Command_Cur;
            DEALLOCATE _Command_Cur;
        END;
GO
/****** Object:  Trigger [AutoInsertPermission_Delete]    Script Date: 05/20/2021 15:29:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create TRIGGER [dbo].[AutoInsertPermission_Delete] ON [dbo].[TaiKhoan]
    FOR DELETE
AS
    IF EXISTS ( SELECT  1
                FROM    dbo.ChucNang
                WHERE   IsDelete = 0 )
        BEGIN
         
                DECLARE @MaTaiKhoan CHAR(9);
                SET @MaTaiKhoan = ( SELECT    Deleted.MaTaiKhoan
                                  FROM      Deleted
                                );
    
                DECLARE @MaChucNang INT;
    
                DECLARE _Command_Cur CURSOR FAST_FORWARD
                FOR
                    SELECT  MaChucNang
                    FROM    dbo.ChucNang
                    WHERE   IsDelete = 0;
 
                OPEN _Command_Cur;
                FETCH NEXT FROM _Command_Cur INTO @MaChucNang; 
                WHILE @@FETCH_STATUS = 0
                    BEGIN
                        DELETE  dbo.PhanQuyen
                        WHERE   MaTaiKhoan = @MaTaiKhoan
                                AND MaChucNang = @MaChucNang;
                        FETCH NEXT FROM _Command_Cur INTO @MaChucNang;
                    END;
             CLOSE _Command_Cur;
            DEALLOCATE _Command_Cur;
        END;
GO
/****** Object:  StoredProcedure [dbo].[PSP_ThongKe_DoanhThuTheoNgayThang]    Script Date: 05/20/2021 15:29:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_ThongKe_DoanhThuTheoNgayThang]
    @BeginDate DATE ,
    @EndDate DATE
AS
    SELECT  0 AS STT ,
            c.TenSP ,
            a.NgayLap ,
            b.SoLuongBan ,
            b.DonGiaBan ,
            b.SoLuongBan * b.DonGiaBan AS ThanhTien ,
            d.TenNhanVien
    FROM    dbo.HoaDon a
            JOIN dbo.ChiTietHoaDon b ON b.MaHD = a.MaHD
            JOIN dbo.SanPham c ON c.MaSP = b.MaSP
            JOIN dbo.NhanVien d ON d.MaNhanVien = a.MaNhanVien
            WHERE CONVERT(DATE,a.NgayLap) BETWEEN @BeginDate AND @EndDate
       ORDER BY a.NgayLap DESC, d.TenNhanVien
GO
/****** Object:  StoredProcedure [dbo].[PSP_TaiKhoan_ThayDoiMatKhau]    Script Date: 05/20/2021 15:29:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_TaiKhoan_ThayDoiMatKhau]
@MaNhanVien CHAR(9),
@MatKhau VARCHAR(20)
AS

UPDATE dbo.NhanVien
SET MatKhau=pwdEncrypt(@MatKhau)
WHERE MaNhanVien=@MaNhanVien
GO
/****** Object:  StoredProcedure [dbo].[PSP_TaiKhoan_CapLaiPass]    Script Date: 05/20/2021 15:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_TaiKhoan_CapLaiPass]
@MaNhanVien CHAR(9)
AS
DECLARE @TenDangNhap VARCHAR(50)
SET @TenDangNhap=(SELECT TenDangNhap FROM dbo.NhanVien WHERE MaNhanVien=@MaNhanVien)

UPDATE dbo.NhanVien
SET MatKhau=pwdEncrypt(@TenDangNhap)
WHERE MaNhanVien=@MaNhanVien
GO
/****** Object:  StoredProcedure [dbo].[PSP_PhanQuyen_LayBangPhanQuyen]    Script Date: 05/20/2021 15:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_PhanQuyen_LayBangPhanQuyen]
          @MaNhanVien CHAR(9)
          AS 
          DECLARE @MaTaiKhoan CHAR(9)
          SET @MaTaiKhoan =(SELECT MaTaiKhoan FROM dbo.NhanVien WHERE MaNhanVien=@MaNhanVien AND TinhTrang=1)
          
          SELECT a.MaChucNang, MaTaiKhoan, GiaTriQuyen,KyHieu
          FROM dbo.PhanQuyen a JOIN dbo.ChucNang b ON b.MaChucNang = a.MaChucNang
          WHERE MaTaiKhoan=@MaTaiKhoan
          and a.IsDelete=0
GO
/****** Object:  StoredProcedure [dbo].[PSP_NhanVien_Select]    Script Date: 05/20/2021 15:29:40 ******/
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
/****** Object:  StoredProcedure [dbo].[PSP_NhanVien_LayNhanVienChoCombo]    Script Date: 05/20/2021 15:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_NhanVien_LayNhanVienChoCombo]
       AS
       SELECT MaNhanVien,TenNhanVien
       FROM dbo.NhanVien
       WHERE TinhTrang=1
       ORDER BY TenNhanVien ASC
GO
/****** Object:  StoredProcedure [dbo].[PSP_NhanVien_LayMaxMaNV]    Script Date: 05/20/2021 15:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_NhanVien_LayMaxMaNV] --2021,5
     AS
     SELECT ISNULL(CONVERT(INT,SUBSTRING(MAX(MaNhanVien),3,9)),0)+1 as MaxID
     FROM dbo.NhanVien
GO
/****** Object:  StoredProcedure [dbo].[PSP_NhanVien_InsertUpdate]    Script Date: 05/20/2021 15:29:40 ******/
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
/****** Object:  StoredProcedure [dbo].[PSP_NhanVien_Delete]    Script Date: 05/20/2021 15:29:40 ******/
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
/****** Object:  StoredProcedure [dbo].[PSP_NhanVien_CheckLogin]    Script Date: 05/20/2021 15:29:40 ******/
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
/****** Object:  StoredProcedure [dbo].[PSP_SaoLuuDuLieu]    Script Date: 05/20/2021 15:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[PSP_SaoLuuDuLieu]
	@duongdan nvarchar(max)
as
begin
	declare @dbname nvarchar(50)
	set @dbname =  DB_NAME()
	BACKUP DATABASE @dbname
	TO  DISK = @duongdan
	WITH NOFORMAT, NOINIT,  
	SKIP, NOREWIND, NOUNLOAD,  STATS = 10
	select ErrorCode = 1
end
GO
/****** Object:  StoredProcedure [dbo].[PSP_PhieuNhap_InPhieuNhap]    Script Date: 05/20/2021 15:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_PhieuNhap_InPhieuNhap] @MaPhieuNhap CHAR(9)
AS
    SELECT  0 AS STT ,
            a.MaPhieuNhap ,
            c.TenNhanVien ,
            a.NgayNhap ,
            d.TenSP ,
            e.TenDVT ,
            b.SoLuongNhap ,
            b.DonGiaNhap ,
            ( b.SoLuongNhap * b.DonGiaNhap ) AS ThanhTien
    FROM    dbo.PhieuNhap a
            JOIN dbo.ChiTietPhieuNhap b ON b.MaPhieuNhap = a.MaPhieuNhap
            JOIN dbo.NhanVien c ON c.MaNhanVien = a.MaNhanVien
            JOIN dbo.SanPham d ON d.MaSP = b.MaSP
            JOIN dbo.DonViTinh e ON e.MaDVT = d.MaDVT
    WHERE   a.MaPhieuNhap = @MaPhieuNhap;
GO
/****** Object:  StoredProcedure [dbo].[PSP_ChiTietPhieuNhap_Select]    Script Date: 05/20/2021 15:29:40 ******/
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
            c.SoLuongNhapTon,c.MaPhieuNhap
    FROM    dbo.SanPham a
            JOIN dbo.DonViTinh b ON b.MaDVT = a.MaDVT
            JOIN dbo.ChiTietPhieuNhap c ON c.MaSP = a.MaSP
            JOIN dbo.PhieuNhap d ON d.MaPhieuNhap = c.MaPhieuNhap
            JOIN NhanVien e ON e.MaNhanVien = d.MaNhanVien
            WHERE a.IsDelete =0
            ORDER BY c.MaPhieuNhap DESC
GO
/****** Object:  StoredProcedure [dbo].[PSP_DonViTinh_SelectCbo]    Script Date: 05/20/2021 15:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PSP_DonViTinh_SelectCbo]
    AS
    SELECT MaDVT,TenDVT FROM dbo.DonViTinh WHERE IsDelete=0
GO
/****** Object:  Default [DF_ChiTietGiaBan_NgayTao]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChiTietGiaBan] ADD  CONSTRAINT [DF_ChiTietGiaBan_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
/****** Object:  Default [DF_ChiTietGiaBan_DonGia]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChiTietGiaBan] ADD  CONSTRAINT [DF_ChiTietGiaBan_DonGia]  DEFAULT ((0)) FOR [DonGia]
GO
/****** Object:  Default [DF_ChiTietGiaBan_TinhTrang]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChiTietGiaBan] ADD  CONSTRAINT [DF_ChiTietGiaBan_TinhTrang]  DEFAULT ((1)) FOR [TinhTrang]
GO
/****** Object:  Default [DF_ChiTietGiaBan_NgayApDung]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChiTietGiaBan] ADD  CONSTRAINT [DF_ChiTietGiaBan_NgayApDung]  DEFAULT (getdate()) FOR [NgayApDung]
GO
/****** Object:  Default [DF_ChiTietHoaDon_SoLuongBan]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  CONSTRAINT [DF_ChiTietHoaDon_SoLuongBan]  DEFAULT ((0)) FOR [SoLuongBan]
GO
/****** Object:  Default [DF_ChiTietHoaDon_DonGiaBan]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  CONSTRAINT [DF_ChiTietHoaDon_DonGiaBan]  DEFAULT ((0)) FOR [DonGiaBan]
GO
/****** Object:  Default [DF_ChiTietHoaDon_GiamGia]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  CONSTRAINT [DF_ChiTietHoaDon_GiamGia]  DEFAULT ((0)) FOR [GiamGia]
GO
/****** Object:  Default [DF__ChiTietPh__SoLuo__267ABA7A]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap] ADD  CONSTRAINT [DF__ChiTietPh__SoLuo__267ABA7A]  DEFAULT ((0)) FOR [SoLuongNhap]
GO
/****** Object:  Default [DF__ChiTietPh__DonGi__276EDEB3]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap] ADD  CONSTRAINT [DF__ChiTietPh__DonGi__276EDEB3]  DEFAULT ((0)) FOR [DonGiaNhap]
GO
/****** Object:  Default [DF__ChiTietPh__SoLuo__286302EC]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap] ADD  CONSTRAINT [DF__ChiTietPh__SoLuo__286302EC]  DEFAULT ((0)) FOR [SoLuongNhapTon]
GO
/****** Object:  Default [DF_ChucNang_MaNhomChucNang]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChucNang] ADD  CONSTRAINT [DF_ChucNang_MaNhomChucNang]  DEFAULT ((1)) FOR [MaNhomChucNang]
GO
/****** Object:  Default [DF_ChucNang_IsDelete]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChucNang] ADD  CONSTRAINT [DF_ChucNang_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF__DonViTinh__IsDel__1367E606]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[DonViTinh] ADD  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF_HoaDon_GiamGia]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [DF_HoaDon_GiamGia]  DEFAULT ((0)) FOR [GiamGia]
GO
/****** Object:  Default [DF_LoaiChucNang_IsDelete]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[LoaiChucNang] ADD  CONSTRAINT [DF_LoaiChucNang_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF_PhanQuyen_IsDelete]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[PhanQuyen] ADD  CONSTRAINT [DF_PhanQuyen_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF__PhieuNhap__NgayN__22AA2996]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[PhieuNhap] ADD  DEFAULT (getdate()) FOR [NgayNhap]
GO
/****** Object:  Default [DF_PhieuNhap_StatusPhieuNhap]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [DF_PhieuNhap_StatusPhieuNhap]  DEFAULT ((0)) FOR [StatusPhieuNhap]
GO
/****** Object:  Default [DF__SanPham__SoTon__1B0907CE]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [DF__SanPham__SoTon__1B0907CE]  DEFAULT ((0)) FOR [SoTon]
GO
/****** Object:  Default [DF__SanPham__IsDelet__1BFD2C07]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [DF__SanPham__IsDelet__1BFD2C07]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF_TaiKhoan_IsDelete]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[TaiKhoan] ADD  CONSTRAINT [DF_TaiKhoan_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Check [Ck_SoTonLonHonHayBang0]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [Ck_SoTonLonHonHayBang0] CHECK  (([SoTon]>=(0)))
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [Ck_SoTonLonHonHayBang0]
GO
/****** Object:  ForeignKey [FK_ChiTietGiaBan_SanPham]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChiTietGiaBan]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietGiaBan_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietGiaBan] CHECK CONSTRAINT [FK_ChiTietGiaBan_SanPham]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDon_HoaDon]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDon_SanPham]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
/****** Object:  ForeignKey [fk_ChiTietPhieuNhap_PhieuNhap]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [fk_ChiTietPhieuNhap_PhieuNhap]
GO
/****** Object:  ForeignKey [fk_ChiTietPhieuNhap_SanPham]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_ChiTietPhieuNhap_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [fk_ChiTietPhieuNhap_SanPham]
GO
/****** Object:  ForeignKey [FK_ChucNang_LoaiChucNang]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[ChucNang]  WITH CHECK ADD  CONSTRAINT [FK_ChucNang_LoaiChucNang] FOREIGN KEY([MaNhomChucNang])
REFERENCES [dbo].[LoaiChucNang] ([MaNhomChucNang])
GO
ALTER TABLE [dbo].[ChucNang] CHECK CONSTRAINT [FK_ChucNang_LoaiChucNang]
GO
/****** Object:  ForeignKey [FK_HoaDon_NhanVien]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
/****** Object:  ForeignKey [FK_NhanVien_TaiKhoan]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
GO
/****** Object:  ForeignKey [FK_PhanQuyen_ChucNang]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_ChucNang] FOREIGN KEY([MaChucNang])
REFERENCES [dbo].[ChucNang] ([MaChucNang])
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_ChucNang]
GO
/****** Object:  ForeignKey [FK_PhanQuyen_TaiKhoan]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_TaiKhoan]
GO
/****** Object:  ForeignKey [fk_PhieuNhap_NhanVien]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_PhieuNhap_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [fk_PhieuNhap_NhanVien]
GO
/****** Object:  ForeignKey [Fk_SanPham_DVT_maDVT]    Script Date: 05/20/2021 15:29:36 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [Fk_SanPham_DVT_maDVT] FOREIGN KEY([MaDVT])
REFERENCES [dbo].[DonViTinh] ([MaDVT])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [Fk_SanPham_DVT_maDVT]
GO
