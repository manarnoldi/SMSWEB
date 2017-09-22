namespace SchoolManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedcalendartothePostingPeriods : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.PostingPeriod", new[] { "Posting_Id" });
            RenameColumn(table: "dbo.PostingPeriod", name: "Posting_Id", newName: "PostingId");
            AlterColumn("dbo.PostingPeriod", "PostingId", c => c.Int(nullable: false));
            CreateIndex("dbo.PostingPeriod", "PostingId");
            DropColumn("dbo.PostingPeriod", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PostingPeriod", "Name", c => c.String(nullable: false, maxLength: 30, unicode: false));
            DropIndex("dbo.PostingPeriod", new[] { "PostingId" });
            AlterColumn("dbo.PostingPeriod", "PostingId", c => c.Int());
            RenameColumn(table: "dbo.PostingPeriod", name: "PostingId", newName: "Posting_Id");
            CreateIndex("dbo.PostingPeriod", "Posting_Id");
        }
    }
}
