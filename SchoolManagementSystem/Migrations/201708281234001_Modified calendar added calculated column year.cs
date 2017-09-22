namespace SchoolManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modifiedcalendaraddedcalculatedcolumnyear : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calendar", "year", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calendar", "year");
        }
    }
}
