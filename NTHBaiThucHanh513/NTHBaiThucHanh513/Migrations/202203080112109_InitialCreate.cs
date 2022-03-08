namespace NTHBaiThucHanh513.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khoas",
                c => new
                    {
                        MaKhoa = c.String(nullable: false, maxLength: 128),
                        TenKhoa = c.String(),
                    })
                .PrimaryKey(t => t.MaKhoa);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Khoas");
        }
    }
}
