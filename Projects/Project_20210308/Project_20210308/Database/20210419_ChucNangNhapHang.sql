--Các thủ tục được thêm mới trong buổi học 2021-04-19
--Tạo Trigger để kiểm Soát số lượng tồn của Sản phẩm
CREATE TRIGGER tg_ChiTietPhieuNhap_Insert ON dbo.ChiTietPhieuNhap
    FOR INSERT
AS
    UPDATE  dbo.SanPham
    SET     SoTon += SoLuongNhap
    FROM    Inserted
    WHERE   dbo.SanPham.MaSP = Inserted.MaSP;
GO
alter TRIGGER tg_ChiTietPhieuNhap_Delete ON dbo.ChiTietPhieuNhap
FOR DELETE
AS 
UPDATE  dbo.SanPham
    SET     SoTon -= SoLuongNhap
    FROM    Deleted
    WHERE   dbo.SanPham.MaSP = Deleted.MaSP;
    
    GO
alter Trigger tg_ChiTietPhieuNhap_Update On ChiTietPhieuNhap
For Update As

--Cập nhật số lượng tồn trong bảng SanPham
Update dbo.SanPham Set SoTon = SoTon - b.SoLuongNhap + c.SoLuongNhap
From SanPham a, DELETED b, INSERTED c
Where a.MaSP = b.MaSP And a.MaSP = c.MaSP


