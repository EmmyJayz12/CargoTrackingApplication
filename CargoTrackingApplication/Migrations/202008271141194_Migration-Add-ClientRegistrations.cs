namespace CargoTrackingApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationAddClientRegistrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientRegistrations",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        ShippersFirstName = c.String(nullable: false),
                        ShippersLastName = c.String(nullable: false),
                        ShippersPhone = c.String(nullable: false),
                        ShippersCountryName = c.String(nullable: false),
                        ReceiversFirstName = c.String(nullable: false),
                        ReceiversLastName = c.String(nullable: false),
                        ReceiversPhone = c.String(nullable: false),
                        ReceiversEmail = c.String(nullable: false),
                        ReceiversCountryName = c.String(nullable: false),
                        TrackingId = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        weight = c.String(nullable: false),
                        Invoice = c.String(nullable: false),
                        BookingMode = c.String(nullable: false),
                        TotalFreight = c.String(nullable: false),
                        DeliveryMode = c.String(nullable: false),
                        PickupDate = c.String(nullable: false),
                        PickTime = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        Comment = c.String(nullable: false),
                        ReceiversAddress = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClientRegistrations");
        }
    }
}
