namespace SchoolManagementSystemModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdmissionNoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdmNo = c.String(),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Calendars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PeriodName = c.String(nullable: false, maxLength: 30, unicode: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClassAttendances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudId = c.Int(nullable: false),
                        CalendarId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Attendance = c.Int(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                        StudentDetails_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Calendars", t => t.CalendarId, cascadeDelete: true)
                .ForeignKey("dbo.StudentDetails", t => t.StudentDetails_Id)
                .Index(t => t.CalendarId)
                .Index(t => t.StudentDetails_Id);
            
            CreateTable(
                "dbo.StudentDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdmNo = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 30, unicode: false),
                        MiddleName = c.String(maxLength: 30, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 30, unicode: false),
                        Gender = c.Int(nullable: false),
                        CountyWardId = c.Int(nullable: false),
                        Religion = c.String(maxLength: 30, unicode: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        DateOfAdmission = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Disabled = c.Boolean(nullable: false),
                        StudentCategory = c.Int(nullable: false),
                        PostalAddress = c.String(maxLength: 30, unicode: false),
                        Image = c.Binary(),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                        PostalCode_Id = c.Int(),
                        CountyWard_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PostalCodes", t => t.PostalCode_Id)
                .ForeignKey("dbo.CountyWards", t => t.CountyWard_Id)
                .ForeignKey("dbo.CountyWards", t => t.CountyWardId)
                .Index(t => t.CountyWardId)
                .Index(t => t.PostalCode_Id)
                .Index(t => t.CountyWard_Id);
            
            CreateTable(
                "dbo.SchoolClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20, unicode: false),
                        Stream = c.String(nullable: false, maxLength: 10, unicode: false),
                        Year = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                        StudentDetails_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StudentDetails", t => t.StudentDetails_Id)
                .Index(t => t.StudentDetails_Id);
            
            CreateTable(
                "dbo.ClassHeads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SchoolClassId = c.Int(nullable: false),
                        StudentDetailsId = c.Int(nullable: false),
                        StaffDetailsId = c.Int(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SchoolClasses", t => t.SchoolClassId, cascadeDelete: true)
                .ForeignKey("dbo.StaffDetails", t => t.StaffDetailsId, cascadeDelete: true)
                .ForeignKey("dbo.StudentDetails", t => t.StudentDetailsId, cascadeDelete: true)
                .Index(t => t.SchoolClassId)
                .Index(t => t.StudentDetailsId)
                .Index(t => t.StaffDetailsId);
            
            CreateTable(
                "dbo.StaffDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaffNo = c.String(nullable: false, maxLength: 20, unicode: false),
                        FirstName = c.String(nullable: false, maxLength: 15, unicode: false),
                        MiddleName = c.String(maxLength: 15, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 15, unicode: false),
                        IdNumber = c.Int(nullable: false),
                        PhoneNumber = c.String(maxLength: 30, unicode: false),
                        CountyWardId = c.Int(nullable: false),
                        Religion = c.String(maxLength: 30, unicode: false),
                        Gender = c.Int(nullable: false),
                        Email = c.String(maxLength: 30, unicode: false),
                        ContractType = c.Int(nullable: false),
                        StaffType = c.Int(nullable: false),
                        DateOfEmployment = c.DateTime(nullable: false),
                        Designation = c.String(nullable: false, maxLength: 30, unicode: false),
                        Status = c.Int(nullable: false),
                        PostalAddress = c.String(maxLength: 30, unicode: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                        PostalCode_Id = c.Int(),
                        CountyWard_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PostalCodes", t => t.PostalCode_Id)
                .ForeignKey("dbo.CountyWards", t => t.CountyWard_Id)
                .ForeignKey("dbo.CountyWards", t => t.CountyWardId)
                .Index(t => t.CountyWardId)
                .Index(t => t.PostalCode_Id)
                .Index(t => t.CountyWard_Id);
            
            CreateTable(
                "dbo.CountyWards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        County = c.String(nullable: false, maxLength: 30, unicode: false),
                        Ward = c.String(nullable: false, maxLength: 30, unicode: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50, unicode: false),
                        MiddleName = c.String(maxLength: 50, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 50, unicode: false),
                        EmailAddress = c.String(maxLength: 50, unicode: false),
                        PhoneNo = c.String(maxLength: 50, unicode: false),
                        PostalAddress = c.Int(nullable: false),
                        PostalCodeId = c.Int(nullable: false),
                        CountyWardId = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        Occupation = c.String(nullable: false, maxLength: 50, unicode: false),
                        CountyWard_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CountyWards", t => t.CountyWardId)
                .ForeignKey("dbo.PostalCodes", t => t.PostalCodeId, cascadeDelete: true)
                .ForeignKey("dbo.CountyWards", t => t.CountyWard_Id)
                .Index(t => t.PostalCodeId)
                .Index(t => t.CountyWardId)
                .Index(t => t.CountyWard_Id);
            
            CreateTable(
                "dbo.PostalCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        PostalName = c.String(nullable: false, maxLength: 30, unicode: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SchoolDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30, unicode: false),
                        PhoneNumber = c.String(maxLength: 30, unicode: false),
                        EmailAddress = c.String(maxLength: 30, unicode: false),
                        MobileNumber = c.String(maxLength: 30, unicode: false),
                        PostalAddress = c.Int(nullable: false),
                        PostalId = c.Int(nullable: false),
                        CoutyWardId = c.Int(nullable: false),
                        Logo = c.Binary(),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                        PostalCode_Id = c.Int(),
                        CountyWard_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CountyWards", t => t.CoutyWardId)
                .ForeignKey("dbo.PostalCodes", t => t.PostalCode_Id)
                .ForeignKey("dbo.CountyWards", t => t.CountyWard_Id)
                .Index(t => t.CoutyWardId)
                .Index(t => t.PostalCode_Id)
                .Index(t => t.CountyWard_Id);
            
            CreateTable(
                "dbo.StudentParents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentDetailsId = c.Int(nullable: false),
                        ParentId = c.Int(nullable: false),
                        Relationship = c.String(nullable: false, maxLength: 30, unicode: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Parents", t => t.ParentId, cascadeDelete: true)
                .ForeignKey("dbo.StudentDetails", t => t.StudentDetailsId, cascadeDelete: true)
                .Index(t => t.StudentDetailsId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30, unicode: false),
                        StaffDetailsId = c.Int(nullable: false),
                        status = c.Int(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StaffDetails", t => t.StaffDetailsId, cascadeDelete: true)
                .Index(t => t.StaffDetailsId);
            
            CreateTable(
                "dbo.StaffSubjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaffDetailsId = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        SchoolClassId = c.Int(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SchoolClasses", t => t.SchoolClassId, cascadeDelete: true)
                .ForeignKey("dbo.StaffDetails", t => t.StaffDetailsId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.StaffDetailsId)
                .Index(t => t.SubjectId)
                .Index(t => t.SchoolClassId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(nullable: false, maxLength: 30, unicode: false),
                        SubjectCode = c.String(nullable: false, maxLength: 30, unicode: false),
                        Compulsory = c.Boolean(nullable: false),
                        SubjectCategoryId = c.Int(nullable: false),
                        Offered = c.Boolean(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubjectCategories", t => t.SubjectCategoryId, cascadeDelete: true)
                .Index(t => t.SubjectCategoryId);
            
            CreateTable(
                "dbo.Examinations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectId = c.Int(nullable: false),
                        CalendarId = c.Int(nullable: false),
                        SchoolClassId = c.Int(nullable: false),
                        ExamNameId = c.Int(nullable: false),
                        ExamMark = c.Double(nullable: false),
                        TypeTotalMark = c.Double(nullable: false),
                        TypeContrMark = c.Double(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Calendars", t => t.CalendarId, cascadeDelete: true)
                .ForeignKey("dbo.ExamNames", t => t.ExamNameId, cascadeDelete: true)
                .ForeignKey("dbo.SchoolClasses", t => t.SchoolClassId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.SubjectId)
                .Index(t => t.CalendarId)
                .Index(t => t.SchoolClassId)
                .Index(t => t.ExamNameId);
            
            CreateTable(
                "dbo.ExamNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30, unicode: false),
                        ExamType = c.String(nullable: false, maxLength: 30, unicode: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExamResults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExaminationId = c.Int(nullable: false),
                        StudentDetailsId = c.Int(nullable: false),
                        MarkScored = c.Double(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Examinations", t => t.ExaminationId, cascadeDelete: true)
                .ForeignKey("dbo.StudentDetails", t => t.StudentDetailsId, cascadeDelete: true)
                .Index(t => t.ExaminationId)
                .Index(t => t.StudentDetailsId);
            
            CreateTable(
                "dbo.GradeRemarks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectId = c.Int(nullable: false),
                        GradeId = c.Int(nullable: false),
                        Remarks = c.String(nullable: false, maxLength: 100, unicode: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.GradeId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.SubjectId)
                .Index(t => t.GradeId);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GradeName = c.String(nullable: false, maxLength: 30, unicode: false),
                        UpperMark = c.Single(nullable: false),
                        LowerMark = c.Single(nullable: false),
                        Points = c.Int(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentSubjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SchoolClassId = c.Int(nullable: false),
                        StudentDetailsId = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SchoolClasses", t => t.SchoolClassId, cascadeDelete: true)
                .ForeignKey("dbo.StudentDetails", t => t.StudentDetailsId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.SchoolClassId)
                .Index(t => t.StudentDetailsId)
                .Index(t => t.SubjectId);
            
            CreateTable(
                "dbo.SubjectCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(nullable: false, maxLength: 30, unicode: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                        SchoolClass_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SchoolClasses", t => t.SchoolClass_Id)
                .ForeignKey("dbo.StudentDetails", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.SchoolClass_Id);
            
            CreateTable(
                "dbo.KcpeResults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SchoolName = c.String(nullable: false, maxLength: 30, unicode: false),
                        ExamYear = c.Int(nullable: false),
                        IndexNumber = c.String(nullable: false, maxLength: 30, unicode: false),
                        TotalMarks = c.Single(nullable: false),
                        MeanGrade = c.String(nullable: false, maxLength: 5, unicode: false),
                        TotalOutOf = c.Single(nullable: false),
                        StudentDetailsId = c.Int(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StudentDetails", t => t.StudentDetailsId, cascadeDelete: true)
                .Index(t => t.StudentDetailsId);
            
            CreateTable(
                "dbo.ClassRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30, unicode: false),
                        RoomType = c.String(nullable: false, maxLength: 20, unicode: false),
                        Sharable = c.Boolean(nullable: false),
                        Capacity = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ConfigParams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParamType = c.String(nullable: false, maxLength: 30, unicode: false),
                        ParamName = c.String(nullable: false, maxLength: 30, unicode: false),
                        Value = c.Int(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Postings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30, unicode: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PostingPeriods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        PostingId = c.Int(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyBy = c.String(nullable: false, maxLength: 50, unicode: false),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Postings", t => t.PostingId, cascadeDelete: true)
                .Index(t => t.PostingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostingPeriods", "PostingId", "dbo.Postings");
            DropForeignKey("dbo.KcpeResults", "StudentDetailsId", "dbo.StudentDetails");
            DropForeignKey("dbo.StudentDetails", "CountyWardId", "dbo.CountyWards");
            DropForeignKey("dbo.SchoolClasses", "StudentDetails_Id", "dbo.StudentDetails");
            DropForeignKey("dbo.StudentClasses", "StudentId", "dbo.StudentDetails");
            DropForeignKey("dbo.StudentClasses", "SchoolClass_Id", "dbo.SchoolClasses");
            DropForeignKey("dbo.ClassHeads", "StudentDetailsId", "dbo.StudentDetails");
            DropForeignKey("dbo.Subjects", "SubjectCategoryId", "dbo.SubjectCategories");
            DropForeignKey("dbo.StudentSubjects", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.StudentSubjects", "StudentDetailsId", "dbo.StudentDetails");
            DropForeignKey("dbo.StudentSubjects", "SchoolClassId", "dbo.SchoolClasses");
            DropForeignKey("dbo.StaffSubjects", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.GradeRemarks", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.GradeRemarks", "GradeId", "dbo.Grades");
            DropForeignKey("dbo.Examinations", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Examinations", "SchoolClassId", "dbo.SchoolClasses");
            DropForeignKey("dbo.ExamResults", "StudentDetailsId", "dbo.StudentDetails");
            DropForeignKey("dbo.ExamResults", "ExaminationId", "dbo.Examinations");
            DropForeignKey("dbo.Examinations", "ExamNameId", "dbo.ExamNames");
            DropForeignKey("dbo.Examinations", "CalendarId", "dbo.Calendars");
            DropForeignKey("dbo.StaffSubjects", "StaffDetailsId", "dbo.StaffDetails");
            DropForeignKey("dbo.StaffSubjects", "SchoolClassId", "dbo.SchoolClasses");
            DropForeignKey("dbo.Departments", "StaffDetailsId", "dbo.StaffDetails");
            DropForeignKey("dbo.StaffDetails", "CountyWardId", "dbo.CountyWards");
            DropForeignKey("dbo.StudentDetails", "CountyWard_Id", "dbo.CountyWards");
            DropForeignKey("dbo.StaffDetails", "CountyWard_Id", "dbo.CountyWards");
            DropForeignKey("dbo.SchoolDetails", "CountyWard_Id", "dbo.CountyWards");
            DropForeignKey("dbo.Parents", "CountyWard_Id", "dbo.CountyWards");
            DropForeignKey("dbo.StudentParents", "StudentDetailsId", "dbo.StudentDetails");
            DropForeignKey("dbo.StudentParents", "ParentId", "dbo.Parents");
            DropForeignKey("dbo.StudentDetails", "PostalCode_Id", "dbo.PostalCodes");
            DropForeignKey("dbo.StaffDetails", "PostalCode_Id", "dbo.PostalCodes");
            DropForeignKey("dbo.SchoolDetails", "PostalCode_Id", "dbo.PostalCodes");
            DropForeignKey("dbo.SchoolDetails", "CoutyWardId", "dbo.CountyWards");
            DropForeignKey("dbo.Parents", "PostalCodeId", "dbo.PostalCodes");
            DropForeignKey("dbo.Parents", "CountyWardId", "dbo.CountyWards");
            DropForeignKey("dbo.ClassHeads", "StaffDetailsId", "dbo.StaffDetails");
            DropForeignKey("dbo.ClassHeads", "SchoolClassId", "dbo.SchoolClasses");
            DropForeignKey("dbo.ClassAttendances", "StudentDetails_Id", "dbo.StudentDetails");
            DropForeignKey("dbo.ClassAttendances", "CalendarId", "dbo.Calendars");
            DropIndex("dbo.PostingPeriods", new[] { "PostingId" });
            DropIndex("dbo.KcpeResults", new[] { "StudentDetailsId" });
            DropIndex("dbo.StudentClasses", new[] { "SchoolClass_Id" });
            DropIndex("dbo.StudentClasses", new[] { "StudentId" });
            DropIndex("dbo.StudentSubjects", new[] { "SubjectId" });
            DropIndex("dbo.StudentSubjects", new[] { "StudentDetailsId" });
            DropIndex("dbo.StudentSubjects", new[] { "SchoolClassId" });
            DropIndex("dbo.GradeRemarks", new[] { "GradeId" });
            DropIndex("dbo.GradeRemarks", new[] { "SubjectId" });
            DropIndex("dbo.ExamResults", new[] { "StudentDetailsId" });
            DropIndex("dbo.ExamResults", new[] { "ExaminationId" });
            DropIndex("dbo.Examinations", new[] { "ExamNameId" });
            DropIndex("dbo.Examinations", new[] { "SchoolClassId" });
            DropIndex("dbo.Examinations", new[] { "CalendarId" });
            DropIndex("dbo.Examinations", new[] { "SubjectId" });
            DropIndex("dbo.Subjects", new[] { "SubjectCategoryId" });
            DropIndex("dbo.StaffSubjects", new[] { "SchoolClassId" });
            DropIndex("dbo.StaffSubjects", new[] { "SubjectId" });
            DropIndex("dbo.StaffSubjects", new[] { "StaffDetailsId" });
            DropIndex("dbo.Departments", new[] { "StaffDetailsId" });
            DropIndex("dbo.StudentParents", new[] { "ParentId" });
            DropIndex("dbo.StudentParents", new[] { "StudentDetailsId" });
            DropIndex("dbo.SchoolDetails", new[] { "CountyWard_Id" });
            DropIndex("dbo.SchoolDetails", new[] { "PostalCode_Id" });
            DropIndex("dbo.SchoolDetails", new[] { "CoutyWardId" });
            DropIndex("dbo.Parents", new[] { "CountyWard_Id" });
            DropIndex("dbo.Parents", new[] { "CountyWardId" });
            DropIndex("dbo.Parents", new[] { "PostalCodeId" });
            DropIndex("dbo.StaffDetails", new[] { "CountyWard_Id" });
            DropIndex("dbo.StaffDetails", new[] { "PostalCode_Id" });
            DropIndex("dbo.StaffDetails", new[] { "CountyWardId" });
            DropIndex("dbo.ClassHeads", new[] { "StaffDetailsId" });
            DropIndex("dbo.ClassHeads", new[] { "StudentDetailsId" });
            DropIndex("dbo.ClassHeads", new[] { "SchoolClassId" });
            DropIndex("dbo.SchoolClasses", new[] { "StudentDetails_Id" });
            DropIndex("dbo.StudentDetails", new[] { "CountyWard_Id" });
            DropIndex("dbo.StudentDetails", new[] { "PostalCode_Id" });
            DropIndex("dbo.StudentDetails", new[] { "CountyWardId" });
            DropIndex("dbo.ClassAttendances", new[] { "StudentDetails_Id" });
            DropIndex("dbo.ClassAttendances", new[] { "CalendarId" });
            DropTable("dbo.PostingPeriods");
            DropTable("dbo.Postings");
            DropTable("dbo.ConfigParams");
            DropTable("dbo.ClassRooms");
            DropTable("dbo.KcpeResults");
            DropTable("dbo.StudentClasses");
            DropTable("dbo.SubjectCategories");
            DropTable("dbo.StudentSubjects");
            DropTable("dbo.Grades");
            DropTable("dbo.GradeRemarks");
            DropTable("dbo.ExamResults");
            DropTable("dbo.ExamNames");
            DropTable("dbo.Examinations");
            DropTable("dbo.Subjects");
            DropTable("dbo.StaffSubjects");
            DropTable("dbo.Departments");
            DropTable("dbo.StudentParents");
            DropTable("dbo.SchoolDetails");
            DropTable("dbo.PostalCodes");
            DropTable("dbo.Parents");
            DropTable("dbo.CountyWards");
            DropTable("dbo.StaffDetails");
            DropTable("dbo.ClassHeads");
            DropTable("dbo.SchoolClasses");
            DropTable("dbo.StudentDetails");
            DropTable("dbo.ClassAttendances");
            DropTable("dbo.Calendars");
            DropTable("dbo.AdmissionNoes");
        }
    }
}
