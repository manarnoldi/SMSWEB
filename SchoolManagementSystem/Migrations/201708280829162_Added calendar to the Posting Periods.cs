namespace SchoolManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedcalendartothePostingPeriods : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.PostingPeriod", new[] { "PostingId" });
            RenameColumn(table: "dbo.PostingPeriod", name: "PostingId", newName: "Posting_Id");
            AddColumn("dbo.PostingPeriod", "Name", c => c.String(nullable: false, maxLength: 30, unicode: false));
            AddColumn("dbo.PostingPeriod", "CalendarId", c => c.Int(nullable: false));
            AlterColumn("dbo.PostingPeriod", "Posting_Id", c => c.Int());
            CreateIndex("dbo.PostingPeriod", "CalendarId");
            CreateIndex("dbo.PostingPeriod", "Posting_Id");
            AddForeignKey("dbo.PostingPeriod", "CalendarId", "dbo.Calendar", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostingPeriod", "CalendarId", "dbo.Calendar");
            DropIndex("dbo.PostingPeriod", new[] { "Posting_Id" });
            DropIndex("dbo.PostingPeriod", new[] { "CalendarId" });
            AlterColumn("dbo.PostingPeriod", "Posting_Id", c => c.Int(nullable: false));
            DropColumn("dbo.PostingPeriod", "CalendarId");
            DropColumn("dbo.PostingPeriod", "Name");
            RenameColumn(table: "dbo.PostingPeriod", name: "Posting_Id", newName: "PostingId");
            CreateIndex("dbo.PostingPeriod", "PostingId");
        }
    }
}
