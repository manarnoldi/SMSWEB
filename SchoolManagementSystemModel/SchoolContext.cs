using SchoolManagementSystemModel.Academics;
using SchoolManagementSystemModel.School;
using SchoolManagementSystemModel.Student;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel
{
    public class SchoolContext : DbContext
    {
        public DbSet<Calendar> Calendar { get; set; }
        public DbSet<ClassHead> ClassHead { get; set; }
        public DbSet<ClassRoom> ClassRoom { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Posting> Posting { get; set; }
        public DbSet<PostingPeriod> PostingPeriod { get; set; }
        public DbSet<SchoolClass> SchoolClass { get; set; }
        public DbSet<SchoolDetails> SchoolDetails { get; set; }
        public DbSet<StaffDetails> StaffDetails { get; set; }

        public DbSet<AdmNo> AdmNo { get; set; }
        public DbSet<ClassAttendance> ClassAttendance { get; set; }
        public DbSet<KcpeResults> KCPEResults { get; set; }
        public DbSet<Parent> Parent { get; set; }
        public DbSet<StuClass> StuClass { get; set; }
        public DbSet<StudentDetails> StudentDetails { get; set; }
        public DbSet<StudentParent> StudentParent { get; set; }

        public DbSet<ConfigParams> ConfigParams { get; set; }
        public DbSet<Examination> Examination { get; set; }
        public DbSet<ExamName> ExamName { get; set; }
        public DbSet<ExamResult> ExamResult { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<GradeRemark> GradeRemark { get; set; }
        public DbSet<StaffSubject> StaffSubject { get; set; }
        public DbSet<StudentSubject> StudentSubject { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<SubjectCategory> SubjectCategory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuider)
        {

        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
