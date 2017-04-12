using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SchoolManagementSystemModel;
using SchoolManagementSystemModel.Academics;
using SchoolManagementSystemModel.School;
using SchoolManagementSystemModel.Student;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Models.Initialisation
{
    public class SchoolContext : IdentityDbContext
    {
        public SchoolContext() : base("SMSWEBConnection")
        {

        }

        public DbSet<Calendar> Calendar { get; set; }
        public DbSet<ClassHead> ClassHead { get; set; }
        public DbSet<ClassRoom> ClassRoom { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<PostalCode> PostalCode { get; set; }
        public DbSet<Posting> Posting { get; set; }
        public DbSet<PostingPeriod> PostingPeriod { get; set; }
        public DbSet<SchoolClass> SchoolClass { get; set; }
        public DbSet<SchoolDetails> SchoolDetails { get; set; }
        public DbSet<StaffDetails> StaffDetails { get; set; }

        public DbSet<AdmissionNo> AdmissionNo { get; set; }
        public DbSet<ClassAttendance> ClassAttendance { get; set; }
        public DbSet<KcpeResults> KCPEResults { get; set; }
        public DbSet<Parent> Parent { get; set; }
        public DbSet<StudentClass> StudentClass { get; set; }
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
            modelBuider.Entity<StaffDetails>()
                .HasRequired(cw => cw.CountyWard)
                .WithMany()
                .WillCascadeOnDelete(false);
            modelBuider.Entity<StudentDetails>()
                .HasRequired(cw => cw.CountyWard)
                .WithMany()
                .WillCascadeOnDelete(false);
            modelBuider.Entity<Parent>()
                .HasRequired(cw => cw.CountyWard)
                .WithMany()
                .WillCascadeOnDelete(false);
            modelBuider.Entity<SchoolDetails>()
                .HasRequired(cw => cw.CoutyWard)
                .WithMany()
                .WillCascadeOnDelete(false);
        }

        public override int SaveChanges()
        {
            foreach (var auditTrail in this.ChangeTracker.Entries().Where(e => e.Entity is SMSModelBaseClass && (e.State == EntityState.Added ||
            e.State == EntityState.Modified)).Select(e => e.Entity as SMSModelBaseClass))
            {
                auditTrail.ModifyDate = DateTime.Now;
                auditTrail.ModifyBy = HttpContext.Current.User.Identity.GetUserId();
                
                if (auditTrail.CreateDate == DateTime.MinValue)
                {
                    auditTrail.CreateDate = DateTime.Now;
                    auditTrail.CreateBy = HttpContext.Current.User.Identity.GetUserId();
                }
            }
            /**
            int result = base.SaveChanges();
            foreach (var history in this.ChangeTracker.Entries().Where(e => e.Entity is IModificationHistory).Select(e => e.Entity as IModificationHistory))
            {
                history.IsDirty = false;
            }
    **/
            return base.SaveChanges();
        }
    }
}
