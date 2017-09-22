namespace SchoolManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removedchangestocalendarieaddedcalculatedcolumnyear : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Calendar", "year");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Calendar", "year", c => c.Int(nullable: false));
        }
    }
}
