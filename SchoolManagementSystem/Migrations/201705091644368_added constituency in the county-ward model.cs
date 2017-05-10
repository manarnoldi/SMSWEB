namespace SchoolManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedconstituencyinthecountywardmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CountyWard", "Constituency", c => c.String(nullable: false, maxLength: 30, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CountyWard", "Constituency");
        }
    }
}
