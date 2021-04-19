CREATE PROC PSP_ChiTietNhap_Insert
    @MaPhieuNhap CHAR(9) ,
    @MaSP INT ,
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
                            ( TenSP, SoTon, MaDVT, IsDelete )
                    VALUES  ( @TenSP, 0, @MaDVT, 0 );
	
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