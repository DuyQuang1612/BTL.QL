namespace PMQLSQA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_column_Kho_MatHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DonHang",
                c => new
                    {
                        NgayLapDonHang = c.DateTime(nullable: false),
                        TenSP = c.String(nullable: false),
                        GiaSP = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SoLuongSP = c.Int(nullable: false),
                        KhachHangMua = c.String(nullable: false),
                        NhanVienLapDonHang = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.NgayLapDonHang);
            
            CreateTable(
                "dbo.Kho",
                c => new
                    {
                        MatHang = c.String(nullable: false, maxLength: 128),
                        NgaySanXuat = c.DateTime(nullable: false),
                        NguonGoc = c.String(),
                        SoLuongSanPham = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MatHang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kho");
            DropTable("dbo.DonHang");
        }
    }
}
