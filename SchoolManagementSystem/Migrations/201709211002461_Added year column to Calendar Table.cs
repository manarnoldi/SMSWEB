namespace SchoolManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedyearcolumntoCalendarTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calendar", "Year", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calendar", "Year");
        }
    }
}
