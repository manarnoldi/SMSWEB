namespace SchoolManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedfieldparametercategorytotableConfigParams : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ConfigParams", "ParamCategory", c => c.String(nullable: false, maxLength: 30, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ConfigParams", "ParamCategory");
        }
    }
}
