namespace SchoolManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reversedpreviousmigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Calendar", "StartDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Calendar", "EndDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Calendar", "EndDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Calendar", "StartDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
    }
}
