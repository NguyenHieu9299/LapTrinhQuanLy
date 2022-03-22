namespace NTHBaiTapLon513.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cap_nhat_5_bảng : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DangNhaps", "MatKhau", c => c.String(nullable: false));
            AlterColumn("dbo.HoaDonBanHangs", "Soluong", c => c.Int(nullable: false));
            AlterColumn("dbo.HoaDonBanHangs", "DonGia", c => c.Int(nullable: false));
            AlterColumn("dbo.HoaDonBanHangs", "ThanhTien", c => c.Int(nullable: false));
            AlterColumn("dbo.NCCs", "SoDienThoai", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NCCs", "SoDienThoai", c => c.String());
            AlterColumn("dbo.HoaDonBanHangs", "ThanhTien", c => c.String());
            AlterColumn("dbo.HoaDonBanHangs", "DonGia", c => c.String());
            AlterColumn("dbo.HoaDonBanHangs", "Soluong", c => c.String());
            AlterColumn("dbo.DangNhaps", "MatKhau", c => c.String());
        }
    }
}
