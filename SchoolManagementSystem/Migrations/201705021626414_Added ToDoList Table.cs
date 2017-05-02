namespace SchoolManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedToDoListTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoList",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(nullable: false, maxLength: 30, unicode: false),
                        Content = c.String(nullable: false, maxLength: 150, unicode: false),
                        ToDoDate = c.DateTime(nullable: false),
                        TaskStatus = c.Int(nullable: false),
                        CalendarId = c.Int(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Calendar", t => t.CalendarId)
                .Index(t => t.CalendarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToDoList", "CalendarId", "dbo.Calendar");
            DropIndex("dbo.ToDoList", new[] { "CalendarId" });
            DropTable("dbo.ToDoList");
        }
    }
}
