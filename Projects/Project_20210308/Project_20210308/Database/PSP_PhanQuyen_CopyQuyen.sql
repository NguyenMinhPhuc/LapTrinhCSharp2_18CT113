alter PROC PSP_PhanQuyen_CopyQuyen-- 'TK0000005','TK0000001'
   @MaTaiKhoanNguoi CHAR(9),  @MaTaiKhoanDich CHAR(9) 
   
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
                    AND MaTaiKhoan = @MaTaiKhoanNguoi;
 
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
    SELECT * FROM dbo.PhanQuyen
    WHERE MaTaiKhoan IN ('TK0000001','TK0000005','TK0000004')