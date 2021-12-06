namespace PMQLSQA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_column_Account_Username : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.CreateAccount",
                c => new
                    {
                        MaUser = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Username = c.String(nullable: false, unicode: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.MaUser);
            
            CreateTable(
                "dbo.HoaDon",
                c => new
                    {
                        MaHoaDon = c.String(nullable: false, maxLength: 128, unicode: false),
                        NgayLapHoaDon = c.DateTime(nullable: false),
                        TenSanPham = c.String(nullable: false),
                        DonGia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SoLuongSanPham = c.Int(nullable: false),
                        KhachHang = c.String(nullable: false),
                        NhanVienLapHoaDon = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaHoaDon);
            
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenNhanVien = c.String(nullable: false),
                        GioiTinh = c.String(nullable: false),
                        SoDienThoai = c.String(nullable: false),
                        TenDangNhapNhanVien = c.String(nullable: false, unicode: false),
                        MatKhauNhanVien = c.String(),
                        ConfirmMatKhauNhanVien = c.String(),
                    })
                .PrimaryKey(t => t.MaNhanVien);
            
            CreateTable(
                "dbo.PhieuNhap",
                c => new
                    {
                        MaPhieuNhap = c.String(nullable: false, maxLength: 128),
                        SanPhamNhap = c.String(nullable: false),
                        SoLuongNhap = c.Int(nullable: false),
                        NgayNhapHang = c.DateTime(nullable: false),
                        NguoiNhap = c.String(nullable: false),
                        NhaCungCap = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieuNhap);
            
            CreateTable(
                "dbo.PhieuXuat",
                c => new
                    {
                        MaPhieuXuat = c.String(nullable: false, maxLength: 128),
                        SanPhamXuat = c.String(nullable: false),
                        SoLuongXuat = c.Int(nullable: false),
                        NgayXuatHang = c.DateTime(nullable: false),
                        NguoiBan = c.String(nullable: false),
                        KhachHangMua = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieuXuat);
            
            CreateTable(
                "dbo.SanPham",
                c => new
                    {
                        MaSanPham = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenSanPham = c.String(nullable: false),
                        GiaSanPham = c.Decimal(nullable: false, precision: 18, scale: 2),
                        XuatXu = c.String(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        NgaySanXuat = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaSanPham);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SanPham");
            DropTable("dbo.PhieuXuat");
            DropTable("dbo.PhieuNhap");
            DropTable("dbo.NhanVien");
            DropTable("dbo.HoaDon");
            DropTable("dbo.CreateAccount");
            DropTable("dbo.Account");
        }
    }
}
