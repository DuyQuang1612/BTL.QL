namespace PMQLSQA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_column_NhanVien_MaNhanVien : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.SanPham");
            CreateTable(
                "dbo.HoaDon",
                c => new
                    {
                        MaHoaDon = c.String(nullable: false, maxLength: 128, unicode: false),
                        NgayLapHoaDon = c.DateTime(nullable: false),
                        TenSanPham = c.String(),
                        DonGia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SoLuongSanPham = c.Int(nullable: false),
                        KhachHang = c.String(),
                        NhanVienLapHoaDon = c.String(),
                    })
                .PrimaryKey(t => t.MaHoaDon);
            
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenNhanVien = c.String(),
                        GioiTinh = c.String(),
                        SoDienThoai = c.String(),
                        TenDangNhapNhanVien = c.String(),
                        MatKhauNhanVien = c.String(),
                    })
                .PrimaryKey(t => t.MaNhanVien);
            
            AlterColumn("dbo.SanPham", "MaSanPham", c => c.String(nullable: false, maxLength: 128, unicode: false));
            AddPrimaryKey("dbo.SanPham", "MaSanPham");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.SanPham");
            AlterColumn("dbo.SanPham", "MaSanPham", c => c.String(nullable: false, maxLength: 128));
            DropTable("dbo.NhanVien");
            DropTable("dbo.HoaDon");
            AddPrimaryKey("dbo.SanPham", "MaSanPham");
        }
    }
}
