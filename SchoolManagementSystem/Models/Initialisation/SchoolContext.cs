using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SchoolManagementSystem.Assets;
using SchoolManagementSystemModel;
using SchoolManagementSystemModel.Academics;
using SchoolManagementSystemModel.School;
using SchoolManagementSystemModel.Student;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Models.Initialisation
{
    public class SchoolContext : IdentityDbContext
    {
        internal readonly int CountyWard;

        public SchoolContext() : base("SMSWEBConnection")
        {
            Database.SetInitializer<SchoolContext>(null);
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public static SchoolContext Create()
        {
            return new SchoolContext();
        }

        //Identity and Authorization
        public DbSet<IdentityUserLogin> UserLogins { get; set; }
        public DbSet<IdentityUserClaim> UserClaims { get; set; }
        public DbSet<IdentityUserRole> UserRoles { get; set; }

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
        public DbSet<ToDoList> ToDoList { get; set; }
        public DbSet<CountyWard> CountyWards { get; set; }

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder) 
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            // Configure Asp Net Identity Tables
            modelBuilder.Entity<IdentityUser>().ToTable("User");
            modelBuilder.Entity<IdentityUser>().Property(u => u.PasswordHash).HasMaxLength(500);
            modelBuilder.Entity<IdentityUser>().Property(u => u.SecurityStamp).HasMaxLength(500);
            modelBuilder.Entity<IdentityUser>().Property(u => u.PhoneNumber).HasMaxLength(50);

            modelBuilder.Entity<IdentityRole>().ToTable("Role");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRole");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogin");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaim");
            modelBuilder.Entity<IdentityUserClaim>().Property(u => u.ClaimType).HasMaxLength(150);
            modelBuilder.Entity<IdentityUserClaim>().Property(u => u.ClaimValue).HasMaxLength(500);
            /**
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
                .WillCascadeOnDelete(false); **/
            base.OnModelCreating(modelBuilder);
        }
        /**
        public override int SaveChanges()
        {
            try
            {
                AddTimestamps();
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ve)
            {
                var errors = new List<string>();
                foreach (var e in ve.EntityValidationErrors)
                {
                    errors.AddRange(e.ValidationErrors.Select(e2 => string.Join("Validation Error :: ", e2.PropertyName, " : ", e2.ErrorMessage)));
                }
                var error = string.Join("\r\n", errors);
                var betterException = new Exception(error, ve);

                throw betterException;
            }

        }
        **/
        public override int SaveChanges()
        {
            try
            {
                AddTimestamps();
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join(" ",errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, "The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }
        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is SMSModelBaseClass && (x.State == EntityState.Added || x.State == EntityState.Modified));

            var currentUserId = !string.IsNullOrEmpty(HttpContext.Current?.User?.Identity?.GetUserId())
            ? HttpContext.Current.User.Identity.GetUserId()
            : "Anonymous";

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((SMSModelBaseClass)entity.Entity).CreateDate = DateTime.Now;
                    ((SMSModelBaseClass)entity.Entity).CreateBy = currentUserId;
                }

               entity.Property("CreateBy").IsModified = false;
               entity.Property("CreateDate").IsModified = false;

                ((SMSModelBaseClass)entity.Entity).ModifyDate = DateTime.Now;
                ((SMSModelBaseClass)entity.Entity).ModifyBy = currentUserId;
            }
        }

        public void JulieLermanUpdateTimeStamps()
        {
            foreach (var auditTrail in ChangeTracker.Entries().Where(e => e.Entity is SMSModelBaseClass && (e.State == EntityState.Added ||
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
        }

    }
}
