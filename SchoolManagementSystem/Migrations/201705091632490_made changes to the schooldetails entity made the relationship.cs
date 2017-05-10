namespace SchoolManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madechangestotheschooldetailsentitymadetherelationship : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.SchoolDetails", new[] { "PostalCode_Id" });
            RenameColumn(table: "dbo.SchoolDetails", name: "PostalCode_Id", newName: "PostalCodeId");
            AlterColumn("dbo.SchoolDetails", "PostalCodeId", c => c.Int(nullable: false));
            CreateIndex("dbo.SchoolDetails", "PostalCodeId");
            DropColumn("dbo.SchoolDetails", "PostalId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SchoolDetails", "PostalId", c => c.Int(nullable: false));
            DropIndex("dbo.SchoolDetails", new[] { "PostalCodeId" });
            AlterColumn("dbo.SchoolDetails", "PostalCodeId", c => c.Int());
            RenameColumn(table: "dbo.SchoolDetails", name: "PostalCodeId", newName: "PostalCode_Id");
            CreateIndex("dbo.SchoolDetails", "PostalCode_Id");
        }
    }
}
