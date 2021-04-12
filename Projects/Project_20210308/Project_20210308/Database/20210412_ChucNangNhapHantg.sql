--Tạo phiếu nhâp
CREATE PROC PSP_PhieuNhap_Insert
    @MaPhieuNhap CHAR(9) ,
    @MaNhanVien CHAR(9)
AS
    IF NOT EXISTS ( SELECT  1
                    FROM    [dbo].[PhieuNhap]
                    WHERE   MaPhieuNhap = @MaPhieuNhap )
        BEGIN
            INSERT  INTO [dbo].[PhieuNhap]
                    ( MaPhieuNhap ,
                      NgayNhap ,
                      MaNhanVien
                    )
            VALUES  ( @MaPhieuNhap ,
                      GETDATE() ,
                      @MaNhanVien
                    );
        END;
GO
CREATE PROC PSP_PhieuNhap_Delete --'210400001'
    @MaPhieuNhap CHAR(9)
AS
    IF EXISTS ( SELECT  1
                FROM    PhieuNhap
                WHERE   MaPhieuNhap = @MaPhieuNhap )
        BEGIN
            DELETE  [dbo].[PhieuNhap]
            WHERE   MaPhieuNhap = @MaPhieuNhap;
        END;
GO
ALTER PROC PSP_PhieuNhap_Delete --'210400001'
    @MaPhieuNhap CHAR(9)
AS
    SET XACT_ABORT ON;
    BEGIN TRAN;
    IF EXISTS ( SELECT  1
                FROM    PhieuNhap
                WHERE   MaPhieuNhap = @MaPhieuNhap )
        BEGIN
            IF EXISTS ( SELECT  1
                        FROM    [dbo].[ChiTietPhieuNhap]
                        WHERE   MaPhieuNhap = @MaPhieuNhap )
                BEGIN
                    DELETE  [dbo].[ChiTietPhieuNhap]
                    WHERE   MaPhieuNhap = @MaPhieuNhap;
                END;
            DELETE  [dbo].[PhieuNhap]
            WHERE   MaPhieuNhap = @MaPhieuNhap;
        END;
    COMMIT;

GO
ALTER TABLE PhieuNhap
ADD StatusPhieuNhap BIT NOT NULL DEFAULT(0);
GO
CREATE PROC PSP_PhieuNhap_KiemTraStatusPhieuNhap
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
		--
		GO
  CREATE PROC PSP_SanPham_KiemTraSanPhamTheoTen
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
 