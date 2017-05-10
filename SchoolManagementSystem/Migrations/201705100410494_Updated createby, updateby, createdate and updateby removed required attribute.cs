namespace SchoolManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatedcreatebyupdatebycreatedateandupdatebyremovedrequiredattribute : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdmissionNo", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.AdmissionNo", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.Calendar", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.Calendar", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.ClassAttendance", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.ClassAttendance", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.StudentDetails", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.StudentDetails", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.SchoolClass", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.SchoolClass", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.ClassHead", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.ClassHead", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.StaffDetails", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.StaffDetails", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.CountyWard", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.CountyWard", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.PostalCode", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.PostalCode", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.SchoolDetails", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.SchoolDetails", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.StudentParent", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.StudentParent", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.Department", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.Department", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.StaffSubject", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.StaffSubject", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.Subject", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.Subject", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.Examination", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.Examination", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.ExamName", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.ExamName", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.ExamResult", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.ExamResult", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.GradeRemark", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.GradeRemark", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.Grade", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.Grade", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.StudentSubject", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.StudentSubject", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.SubjectCategory", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.SubjectCategory", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.StudentClass", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.StudentClass", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.KcpeResults", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.KcpeResults", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.ToDoList", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.ToDoList", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.ClassRoom", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.ClassRoom", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.ConfigParams", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.ConfigParams", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.Posting", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.Posting", "ModifyBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.PostingPeriod", "CreateBy", c => c.String(maxLength: 128));
            AlterColumn("dbo.PostingPeriod", "ModifyBy", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PostingPeriod", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.PostingPeriod", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Posting", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Posting", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ConfigParams", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ConfigParams", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ClassRoom", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ClassRoom", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ToDoList", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ToDoList", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.KcpeResults", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.KcpeResults", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StudentClass", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StudentClass", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.SubjectCategory", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.SubjectCategory", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StudentSubject", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StudentSubject", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Grade", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Grade", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.GradeRemark", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.GradeRemark", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ExamResult", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ExamResult", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ExamName", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ExamName", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Examination", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Examination", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Subject", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Subject", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StaffSubject", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StaffSubject", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Department", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Department", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StudentParent", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StudentParent", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.SchoolDetails", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.SchoolDetails", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.PostalCode", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.PostalCode", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.CountyWard", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.CountyWard", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StaffDetails", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StaffDetails", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ClassHead", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ClassHead", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.SchoolClass", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.SchoolClass", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StudentDetails", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StudentDetails", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ClassAttendance", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ClassAttendance", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Calendar", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Calendar", "CreateBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.AdmissionNo", "ModifyBy", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.AdmissionNo", "CreateBy", c => c.String(nullable: false, maxLength: 128));
        }
    }
}
