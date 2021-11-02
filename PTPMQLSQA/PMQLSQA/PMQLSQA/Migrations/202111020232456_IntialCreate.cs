namespace PMQLSQA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128, unicode: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.SanPham",
                c => new
                    {
                        MaSanPham = c.String(nullable: false, maxLength: 128),
                        TenSanPham = c.String(),
                        GiaSanPham = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        XuatSu = c.String(),
                    })
                .PrimaryKey(t => t.MaSanPham);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SanPham");
            DropTable("dbo.Account");
        }
    }
}
