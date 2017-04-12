namespace SchoolManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdmissionNo",
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
                "dbo.Calendar",
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
                "dbo.ClassAttendance",
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
                .ForeignKey("dbo.Calendar", t => t.CalendarId)
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PostalCode", t => t.PostalCode_Id)
                .ForeignKey("dbo.CountyWard", t => t.CountyWardId)
                .Index(t => t.CountyWardId)
                .Index(t => t.PostalCode_Id);
            
            CreateTable(
                "dbo.SchoolClass",
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
                "dbo.ClassHead",
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
                .ForeignKey("dbo.SchoolClass", t => t.SchoolClassId)
                .ForeignKey("dbo.StaffDetails", t => t.StaffDetailsId)
                .ForeignKey("dbo.StudentDetails", t => t.StudentDetailsId)
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PostalCode", t => t.PostalCode_Id)
                .ForeignKey("dbo.CountyWard", t => t.CountyWardId)
                .Index(t => t.CountyWardId)
                .Index(t => t.PostalCode_Id);
            
            CreateTable(
                "dbo.CountyWard",
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
                "dbo.Parent",
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CountyWard", t => t.CountyWardId)
                .ForeignKey("dbo.PostalCode", t => t.PostalCodeId)
                .Index(t => t.PostalCodeId)
                .Index(t => t.CountyWardId);
            
            CreateTable(
                "dbo.PostalCode",
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CountyWard", t => t.CoutyWardId)
                .ForeignKey("dbo.PostalCode", t => t.PostalCode_Id)
                .Index(t => t.CoutyWardId)
                .Index(t => t.PostalCode_Id);
            
            CreateTable(
                "dbo.StudentParent",
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
                .ForeignKey("dbo.Parent", t => t.ParentId)
                .ForeignKey("dbo.StudentDetails", t => t.StudentDetailsId)
                .Index(t => t.StudentDetailsId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.Department",
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
                .ForeignKey("dbo.StaffDetails", t => t.StaffDetailsId)
                .Index(t => t.StaffDetailsId);
            
            CreateTable(
                "dbo.StaffSubject",
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
                .ForeignKey("dbo.SchoolClass", t => t.SchoolClassId)
                .ForeignKey("dbo.StaffDetails", t => t.StaffDetailsId)
                .ForeignKey("dbo.Subject", t => t.SubjectId)
                .Index(t => t.StaffDetailsId)
                .Index(t => t.SubjectId)
                .Index(t => t.SchoolClassId);
            
            CreateTable(
                "dbo.Subject",
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
                .ForeignKey("dbo.SubjectCategory", t => t.SubjectCategoryId)
                .Index(t => t.SubjectCategoryId);
            
            CreateTable(
                "dbo.Examination",
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
                .ForeignKey("dbo.Calendar", t => t.CalendarId)
                .ForeignKey("dbo.ExamName", t => t.ExamNameId)
                .ForeignKey("dbo.SchoolClass", t => t.SchoolClassId)
                .ForeignKey("dbo.Subject", t => t.SubjectId)
                .Index(t => t.SubjectId)
                .Index(t => t.CalendarId)
                .Index(t => t.SchoolClassId)
                .Index(t => t.ExamNameId);
            
            CreateTable(
                "dbo.ExamName",
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
                "dbo.ExamResult",
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
                .ForeignKey("dbo.Examination", t => t.ExaminationId)
                .ForeignKey("dbo.StudentDetails", t => t.StudentDetailsId)
                .Index(t => t.ExaminationId)
                .Index(t => t.StudentDetailsId);
            
            CreateTable(
                "dbo.GradeRemark",
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
                .ForeignKey("dbo.Grade", t => t.GradeId)
                .ForeignKey("dbo.Subject", t => t.SubjectId)
                .Index(t => t.SubjectId)
                .Index(t => t.GradeId);
            
            CreateTable(
                "dbo.Grade",
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
                "dbo.StudentSubject",
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
                .ForeignKey("dbo.SchoolClass", t => t.SchoolClassId)
                .ForeignKey("dbo.StudentDetails", t => t.StudentDetailsId)
                .ForeignKey("dbo.Subject", t => t.SubjectId)
                .Index(t => t.SchoolClassId)
                .Index(t => t.StudentDetailsId)
                .Index(t => t.SubjectId);
            
            CreateTable(
                "dbo.SubjectCategory",
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
                "dbo.StudentClass",
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
                .ForeignKey("dbo.SchoolClass", t => t.SchoolClass_Id)
                .ForeignKey("dbo.StudentDetails", t => t.StudentId)
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
                .ForeignKey("dbo.StudentDetails", t => t.StudentDetailsId)
                .Index(t => t.StudentDetailsId);
            
            CreateTable(
                "dbo.ClassRoom",
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
                "dbo.Posting",
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
                "dbo.PostingPeriod",
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
                .ForeignKey("dbo.Posting", t => t.PostingId)
                .Index(t => t.PostingId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(maxLength: 150),
                        ClaimValue = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(maxLength: 500),
                        SecurityStamp = c.String(maxLength: 500),
                        PhoneNumber = c.String(maxLength: 50),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.PostingPeriod", "PostingId", "dbo.Posting");
            DropForeignKey("dbo.KcpeResults", "StudentDetailsId", "dbo.StudentDetails");
            DropForeignKey("dbo.SchoolClass", "StudentDetails_Id", "dbo.StudentDetails");
            DropForeignKey("dbo.StudentClass", "StudentId", "dbo.StudentDetails");
            DropForeignKey("dbo.StudentClass", "SchoolClass_Id", "dbo.SchoolClass");
            DropForeignKey("dbo.ClassHead", "StudentDetailsId", "dbo.StudentDetails");
            DropForeignKey("dbo.Subject", "SubjectCategoryId", "dbo.SubjectCategory");
            DropForeignKey("dbo.StudentSubject", "SubjectId", "dbo.Subject");
            DropForeignKey("dbo.StudentSubject", "StudentDetailsId", "dbo.StudentDetails");
            DropForeignKey("dbo.StudentSubject", "SchoolClassId", "dbo.SchoolClass");
            DropForeignKey("dbo.StaffSubject", "SubjectId", "dbo.Subject");
            DropForeignKey("dbo.GradeRemark", "SubjectId", "dbo.Subject");
            DropForeignKey("dbo.GradeRemark", "GradeId", "dbo.Grade");
            DropForeignKey("dbo.Examination", "SubjectId", "dbo.Subject");
            DropForeignKey("dbo.Examination", "SchoolClassId", "dbo.SchoolClass");
            DropForeignKey("dbo.ExamResult", "StudentDetailsId", "dbo.StudentDetails");
            DropForeignKey("dbo.ExamResult", "ExaminationId", "dbo.Examination");
            DropForeignKey("dbo.Examination", "ExamNameId", "dbo.ExamName");
            DropForeignKey("dbo.Examination", "CalendarId", "dbo.Calendar");
            DropForeignKey("dbo.StaffSubject", "StaffDetailsId", "dbo.StaffDetails");
            DropForeignKey("dbo.StaffSubject", "SchoolClassId", "dbo.SchoolClass");
            DropForeignKey("dbo.Department", "StaffDetailsId", "dbo.StaffDetails");
            DropForeignKey("dbo.StudentDetails", "CountyWardId", "dbo.CountyWard");
            DropForeignKey("dbo.StaffDetails", "CountyWardId", "dbo.CountyWard");
            DropForeignKey("dbo.StudentParent", "StudentDetailsId", "dbo.StudentDetails");
            DropForeignKey("dbo.StudentParent", "ParentId", "dbo.Parent");
            DropForeignKey("dbo.StudentDetails", "PostalCode_Id", "dbo.PostalCode");
            DropForeignKey("dbo.StaffDetails", "PostalCode_Id", "dbo.PostalCode");
            DropForeignKey("dbo.SchoolDetails", "PostalCode_Id", "dbo.PostalCode");
            DropForeignKey("dbo.SchoolDetails", "CoutyWardId", "dbo.CountyWard");
            DropForeignKey("dbo.Parent", "PostalCodeId", "dbo.PostalCode");
            DropForeignKey("dbo.Parent", "CountyWardId", "dbo.CountyWard");
            DropForeignKey("dbo.ClassHead", "StaffDetailsId", "dbo.StaffDetails");
            DropForeignKey("dbo.ClassHead", "SchoolClassId", "dbo.SchoolClass");
            DropForeignKey("dbo.ClassAttendance", "StudentDetails_Id", "dbo.StudentDetails");
            DropForeignKey("dbo.ClassAttendance", "CalendarId", "dbo.Calendar");
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.PostingPeriod", new[] { "PostingId" });
            DropIndex("dbo.KcpeResults", new[] { "StudentDetailsId" });
            DropIndex("dbo.StudentClass", new[] { "SchoolClass_Id" });
            DropIndex("dbo.StudentClass", new[] { "StudentId" });
            DropIndex("dbo.StudentSubject", new[] { "SubjectId" });
            DropIndex("dbo.StudentSubject", new[] { "StudentDetailsId" });
            DropIndex("dbo.StudentSubject", new[] { "SchoolClassId" });
            DropIndex("dbo.GradeRemark", new[] { "GradeId" });
            DropIndex("dbo.GradeRemark", new[] { "SubjectId" });
            DropIndex("dbo.ExamResult", new[] { "StudentDetailsId" });
            DropIndex("dbo.ExamResult", new[] { "ExaminationId" });
            DropIndex("dbo.Examination", new[] { "ExamNameId" });
            DropIndex("dbo.Examination", new[] { "SchoolClassId" });
            DropIndex("dbo.Examination", new[] { "CalendarId" });
            DropIndex("dbo.Examination", new[] { "SubjectId" });
            DropIndex("dbo.Subject", new[] { "SubjectCategoryId" });
            DropIndex("dbo.StaffSubject", new[] { "SchoolClassId" });
            DropIndex("dbo.StaffSubject", new[] { "SubjectId" });
            DropIndex("dbo.StaffSubject", new[] { "StaffDetailsId" });
            DropIndex("dbo.Department", new[] { "StaffDetailsId" });
            DropIndex("dbo.StudentParent", new[] { "ParentId" });
            DropIndex("dbo.StudentParent", new[] { "StudentDetailsId" });
            DropIndex("dbo.SchoolDetails", new[] { "PostalCode_Id" });
            DropIndex("dbo.SchoolDetails", new[] { "CoutyWardId" });
            DropIndex("dbo.Parent", new[] { "CountyWardId" });
            DropIndex("dbo.Parent", new[] { "PostalCodeId" });
            DropIndex("dbo.StaffDetails", new[] { "PostalCode_Id" });
            DropIndex("dbo.StaffDetails", new[] { "CountyWardId" });
            DropIndex("dbo.ClassHead", new[] { "StaffDetailsId" });
            DropIndex("dbo.ClassHead", new[] { "StudentDetailsId" });
            DropIndex("dbo.ClassHead", new[] { "SchoolClassId" });
            DropIndex("dbo.SchoolClass", new[] { "StudentDetails_Id" });
            DropIndex("dbo.StudentDetails", new[] { "PostalCode_Id" });
            DropIndex("dbo.StudentDetails", new[] { "CountyWardId" });
            DropIndex("dbo.ClassAttendance", new[] { "StudentDetails_Id" });
            DropIndex("dbo.ClassAttendance", new[] { "CalendarId" });
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.PostingPeriod");
            DropTable("dbo.Posting");
            DropTable("dbo.ConfigParams");
            DropTable("dbo.ClassRoom");
            DropTable("dbo.KcpeResults");
            DropTable("dbo.StudentClass");
            DropTable("dbo.SubjectCategory");
            DropTable("dbo.StudentSubject");
            DropTable("dbo.Grade");
            DropTable("dbo.GradeRemark");
            DropTable("dbo.ExamResult");
            DropTable("dbo.ExamName");
            DropTable("dbo.Examination");
            DropTable("dbo.Subject");
            DropTable("dbo.StaffSubject");
            DropTable("dbo.Department");
            DropTable("dbo.StudentParent");
            DropTable("dbo.SchoolDetails");
            DropTable("dbo.PostalCode");
            DropTable("dbo.Parent");
            DropTable("dbo.CountyWard");
            DropTable("dbo.StaffDetails");
            DropTable("dbo.ClassHead");
            DropTable("dbo.SchoolClass");
            DropTable("dbo.StudentDetails");
            DropTable("dbo.ClassAttendance");
            DropTable("dbo.Calendar");
            DropTable("dbo.AdmissionNo");
        }
    }
}
