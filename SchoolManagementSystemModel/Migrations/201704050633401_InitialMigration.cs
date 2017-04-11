namespace SchoolManagementSystemModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SchCalendars",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        periodName = c.String(nullable: false, maxLength: 30, unicode: false),
                        startDate = c.DateTime(nullable: false),
                        endDate = c.DateTime(nullable: false),
                        status = c.Boolean(nullable: false),
                        createdBy = c.String(),
                        createdDate = c.DateTime(nullable: false),
                        modifiedBy = c.String(),
                        modifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SchClasses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 20, unicode: false),
                        stream = c.String(nullable: false, maxLength: 10, unicode: false),
                        year = c.Int(nullable: false),
                        status = c.Boolean(nullable: false),
                        createdBy = c.String(),
                        createdDate = c.DateTime(nullable: false),
                        modifiedBy = c.String(),
                        modifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SchClassHeads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SchClassId = c.Int(nullable: false),
                        StuStudentId = c.Int(nullable: false),
                        SchStaffId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SchClasses", t => t.SchClassId, cascadeDelete: true)
                .ForeignKey("dbo.SchStaffs", t => t.SchStaffId, cascadeDelete: true)
                .ForeignKey("dbo.StuStudents", t => t.StuStudentId, cascadeDelete: true)
                .Index(t => t.SchClassId)
                .Index(t => t.StuStudentId)
                .Index(t => t.SchStaffId);
            
            CreateTable(
                "dbo.SchStaffs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        staffNo = c.String(nullable: false, maxLength: 20, unicode: false),
                        firstName = c.String(nullable: false, maxLength: 15, unicode: false),
                        middleName = c.String(maxLength: 15, unicode: false),
                        lastName = c.String(nullable: false, maxLength: 15, unicode: false),
                        idNumber = c.Int(nullable: false),
                        phoneNumber = c.String(maxLength: 30, unicode: false),
                        ward = c.String(maxLength: 30, unicode: false),
                        county = c.String(maxLength: 30, unicode: false),
                        religion = c.String(maxLength: 30, unicode: false),
                        staffType = c.String(nullable: false, maxLength: 30, unicode: false),
                        gender = c.String(maxLength: 30, unicode: false),
                        email = c.String(maxLength: 30, unicode: false),
                        employmentType = c.String(nullable: false, maxLength: 30, unicode: false),
                        dateOfEmployment = c.DateTime(nullable: false),
                        designation = c.String(nullable: false, maxLength: 30, unicode: false),
                        status = c.Boolean(nullable: false),
                        createdBy = c.String(),
                        createdDate = c.DateTime(nullable: false),
                        modifiedBy = c.String(),
                        modifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.StuStudents",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        admNo = c.Int(nullable: false),
                        firstName = c.String(nullable: false, maxLength: 30, unicode: false),
                        middleName = c.String(maxLength: 30, unicode: false),
                        lastName = c.String(nullable: false, maxLength: 30, unicode: false),
                        gender = c.String(nullable: false, maxLength: 30, unicode: false),
                        ward = c.String(maxLength: 30, unicode: false),
                        county = c.String(maxLength: 30, unicode: false),
                        religion = c.String(maxLength: 30, unicode: false),
                        dateOfBirth = c.DateTime(nullable: false),
                        dateOfAdmission = c.DateTime(nullable: false),
                        status = c.Boolean(nullable: false),
                        disabled = c.Boolean(nullable: false),
                        Image = c.Binary(),
                        studentCategory = c.String(maxLength: 30, unicode: false),
                        currentClassId = c.Int(nullable: false),
                        createdBy = c.String(),
                        createdDate = c.DateTime(nullable: false),
                        modifiedBy = c.String(),
                        modifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SchClassRooms",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 20, unicode: false),
                        roomType = c.String(nullable: false, maxLength: 20, unicode: false),
                        sharable = c.Boolean(nullable: false),
                        capacity = c.Int(nullable: false),
                        status = c.Boolean(nullable: false),
                        createdBy = c.String(),
                        createdDate = c.DateTime(nullable: false),
                        modifiedBy = c.String(),
                        modifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SchDepartments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 30, unicode: false),
                        departmentHeadId = c.Int(nullable: false),
                        status = c.Boolean(nullable: false),
                        createdBy = c.String(),
                        createdDate = c.DateTime(nullable: false),
                        modifiedBy = c.String(),
                        modifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SchPostings",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 30),
                        SchPostingPeriodId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SchPostingPeriods",
                c => new
                    {
                        SchPostingId = c.Int(nullable: false),
                        startDate = c.DateTime(nullable: false),
                        endDate = c.DateTime(nullable: false),
                        status = c.Boolean(nullable: false),
                        createdBy = c.String(),
                        createdDate = c.DateTime(nullable: false),
                        modifiedBy = c.String(),
                        modifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SchPostingId)
                .ForeignKey("dbo.SchPostings", t => t.SchPostingId)
                .Index(t => t.SchPostingId);
            
            CreateTable(
                "dbo.SchSchools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30, unicode: false),
                        PhoneNumber = c.String(maxLength: 15, unicode: false),
                        emailAddress = c.String(maxLength: 20, unicode: false),
                        MobileNumber = c.String(maxLength: 15, unicode: false),
                        boxNumber = c.Int(nullable: false),
                        zipCode = c.Int(nullable: false),
                        town = c.String(maxLength: 30, unicode: false),
                        ward = c.String(maxLength: 30, unicode: false),
                        county = c.String(maxLength: 30, unicode: false),
                        Logo = c.Binary(),
                        createdBy = c.String(),
                        createdDate = c.DateTime(nullable: false),
                        modifyBy = c.String(),
                        modifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StuStudentSchClasses",
                c => new
                    {
                        StuStudent_id = c.Int(nullable: false),
                        SchClass_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StuStudent_id, t.SchClass_id })
                .ForeignKey("dbo.StuStudents", t => t.StuStudent_id, cascadeDelete: true)
                .ForeignKey("dbo.SchClasses", t => t.SchClass_id, cascadeDelete: true)
                .Index(t => t.StuStudent_id)
                .Index(t => t.SchClass_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SchPostingPeriods", "SchPostingId", "dbo.SchPostings");
            DropForeignKey("dbo.SchClassHeads", "StuStudentId", "dbo.StuStudents");
            DropForeignKey("dbo.StuStudentSchClasses", "SchClass_id", "dbo.SchClasses");
            DropForeignKey("dbo.StuStudentSchClasses", "StuStudent_id", "dbo.StuStudents");
            DropForeignKey("dbo.SchClassHeads", "SchStaffId", "dbo.SchStaffs");
            DropForeignKey("dbo.SchClassHeads", "SchClassId", "dbo.SchClasses");
            DropIndex("dbo.StuStudentSchClasses", new[] { "SchClass_id" });
            DropIndex("dbo.StuStudentSchClasses", new[] { "StuStudent_id" });
            DropIndex("dbo.SchPostingPeriods", new[] { "SchPostingId" });
            DropIndex("dbo.SchClassHeads", new[] { "SchStaffId" });
            DropIndex("dbo.SchClassHeads", new[] { "StuStudentId" });
            DropIndex("dbo.SchClassHeads", new[] { "SchClassId" });
            DropTable("dbo.StuStudentSchClasses");
            DropTable("dbo.SchSchools");
            DropTable("dbo.SchPostingPeriods");
            DropTable("dbo.SchPostings");
            DropTable("dbo.SchDepartments");
            DropTable("dbo.SchClassRooms");
            DropTable("dbo.StuStudents");
            DropTable("dbo.SchStaffs");
            DropTable("dbo.SchClassHeads");
            DropTable("dbo.SchClasses");
            DropTable("dbo.SchCalendars");
        }
    }
}
