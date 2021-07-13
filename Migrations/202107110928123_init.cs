namespace WaterDelivery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        UserAddressId = c.Int(nullable: false),
                        WaterVolume = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Created_at = c.DateTime(nullable: false),
                        Updated_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .ForeignKey("dbo.UserAddresses", t => t.UserAddressId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.UserAddressId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        Number = c.String(),
                        Created_at = c.DateTime(nullable: false),
                        Updated_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "UserAddressId", "dbo.UserAddresses");
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserAddresses", "UserId", "dbo.Users");
            DropIndex("dbo.UserAddresses", new[] { "UserId" });
            DropIndex("dbo.Orders", new[] { "UserAddressId" });
            DropIndex("dbo.Orders", new[] { "UserId" });
            DropTable("dbo.UserAddresses");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
        }
    }
}
