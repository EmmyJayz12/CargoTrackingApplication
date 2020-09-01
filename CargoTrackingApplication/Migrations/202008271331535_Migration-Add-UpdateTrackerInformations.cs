namespace CargoTrackingApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationAddUpdateTrackerInformations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrackInfoUpdates",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        TrackingId = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        Status = c.String(nullable: false),
                        Location = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TrackInfoUpdates");
        }
    }
}
