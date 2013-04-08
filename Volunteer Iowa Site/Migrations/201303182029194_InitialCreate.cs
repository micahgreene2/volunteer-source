namespace Volunteer_Iowa_Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Log",
                c => new
                    {
                        logID = c.Int(nullable: false, identity: true),
                        userID = c.Int(nullable: false),
                        orgID = c.Int(nullable: false),
                        eventID = c.Int(nullable: false),
                        hoursLogged = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.logID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Log");
        }
    }
}
