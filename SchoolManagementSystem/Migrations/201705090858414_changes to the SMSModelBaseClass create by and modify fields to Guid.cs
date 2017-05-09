namespace SchoolManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changestotheSMSModelBaseClasscreatebyandmodifyfieldstoGuid : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdmissionNo", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.AdmissionNo", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.Calendar", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.Calendar", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.ClassAttendance", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.ClassAttendance", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.StudentDetails", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.StudentDetails", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.SchoolClass", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.SchoolClass", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.ClassHead", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.ClassHead", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.StaffDetails", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.StaffDetails", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.CountyWard", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.CountyWard", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.PostalCode", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.PostalCode", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.SchoolDetails", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.SchoolDetails", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.StudentParent", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.StudentParent", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.Department", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.Department", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.StaffSubject", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.StaffSubject", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.Subject", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.Subject", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.Examination", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.Examination", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.ExamName", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.ExamName", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.ExamResult", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.ExamResult", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.GradeRemark", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.GradeRemark", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.Grade", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.Grade", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.StudentSubject", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.StudentSubject", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.SubjectCategory", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.SubjectCategory", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.StudentClass", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.StudentClass", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.KcpeResults", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.KcpeResults", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.ToDoList", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.ToDoList", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.ClassRoom", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.ClassRoom", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.ConfigParams", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.ConfigParams", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.Posting", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.Posting", "ModifyBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.PostingPeriod", "CreateBy", c => c.Guid(nullable: false));
            AlterColumn("dbo.PostingPeriod", "ModifyBy", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PostingPeriod", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.PostingPeriod", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Posting", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Posting", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.ConfigParams", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.ConfigParams", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.ClassRoom", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.ClassRoom", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.ToDoList", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.ToDoList", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.KcpeResults", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.KcpeResults", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.StudentClass", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.StudentClass", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.SubjectCategory", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.SubjectCategory", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.StudentSubject", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.StudentSubject", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Grade", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Grade", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.GradeRemark", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.GradeRemark", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.ExamResult", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.ExamResult", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.ExamName", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.ExamName", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Examination", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Examination", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Subject", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Subject", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.StaffSubject", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.StaffSubject", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Department", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Department", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.StudentParent", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.StudentParent", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.SchoolDetails", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.SchoolDetails", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.PostalCode", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.PostalCode", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.CountyWard", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.CountyWard", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.StaffDetails", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.StaffDetails", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.ClassHead", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.ClassHead", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.SchoolClass", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.SchoolClass", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.StudentDetails", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.StudentDetails", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.ClassAttendance", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.ClassAttendance", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Calendar", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Calendar", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AdmissionNo", "ModifyBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AdmissionNo", "CreateBy", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
    }
}
