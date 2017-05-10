namespace SchoolManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedcreatedateandupdatedatecolumnstonullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdmissionNo", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.AdmissionNo", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.Calendar", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.Calendar", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.ClassAttendance", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.ClassAttendance", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.StudentDetails", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.StudentDetails", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.SchoolClass", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.SchoolClass", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.ClassHead", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.ClassHead", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.StaffDetails", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.StaffDetails", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.CountyWard", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.CountyWard", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.PostalCode", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.PostalCode", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.SchoolDetails", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.SchoolDetails", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.StudentParent", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.StudentParent", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.Department", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.Department", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.StaffSubject", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.StaffSubject", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.Subject", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.Subject", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.Examination", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.Examination", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.ExamName", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.ExamName", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.ExamResult", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.ExamResult", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.GradeRemark", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.GradeRemark", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.Grade", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.Grade", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.StudentSubject", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.StudentSubject", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.SubjectCategory", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.SubjectCategory", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.StudentClass", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.StudentClass", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.KcpeResults", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.KcpeResults", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.ToDoList", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.ToDoList", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.ClassRoom", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.ClassRoom", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.ConfigParams", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.ConfigParams", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.Posting", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.Posting", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.PostingPeriod", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.PostingPeriod", "ModifyDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PostingPeriod", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PostingPeriod", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Posting", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Posting", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ConfigParams", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ConfigParams", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ClassRoom", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ClassRoom", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ToDoList", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ToDoList", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.KcpeResults", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.KcpeResults", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StudentClass", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StudentClass", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SubjectCategory", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SubjectCategory", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StudentSubject", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StudentSubject", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Grade", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Grade", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.GradeRemark", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.GradeRemark", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ExamResult", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ExamResult", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ExamName", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ExamName", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Examination", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Examination", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Subject", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Subject", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StaffSubject", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StaffSubject", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Department", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Department", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StudentParent", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StudentParent", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SchoolDetails", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SchoolDetails", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PostalCode", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PostalCode", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CountyWard", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CountyWard", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StaffDetails", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StaffDetails", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ClassHead", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ClassHead", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SchoolClass", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SchoolClass", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StudentDetails", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StudentDetails", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ClassAttendance", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ClassAttendance", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Calendar", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Calendar", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AdmissionNo", "ModifyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AdmissionNo", "CreateDate", c => c.DateTime(nullable: false));
        }
    }
}
