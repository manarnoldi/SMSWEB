namespace SchoolManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedschoolDetailstablenamecolumntoindexedandunique : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.SchoolDetails", "Name", unique: true, name: "IX_SchoolDetails_Name");
            CreateIndex("dbo.SchoolDetails", "EmailAddress", unique: true, name: "IX_SchoolDetails_Email");
        }
        
        public override void Down()
        {
            DropIndex("dbo.SchoolDetails", "IX_SchoolDetails_Email");
            DropIndex("dbo.SchoolDetails", "IX_SchoolDetails_Name");
        }
    }
}
