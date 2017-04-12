using SchoolManagementSystemModel.Academics;
using SchoolManagementSystemModel.Enums;
using SchoolManagementSystemModel.School;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Student
{
    public class StudentDetails : SMSModelBaseClass
    {
        public int Id { get; set; }

        public int AdmNo { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public int CountyWardId { get; set; }

        public virtual CountyWard CountyWard { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Religion { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateOfAdmission { get; set; }

        public Status Status { get; set; }

        public bool Disabled { get; set; }

        public StudentCategory StudentCategory { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string PostalAddress {get; set;}

        public virtual PostalCode PostalCode { get; set; }

        public byte[] Image { get; set; }

        public virtual List<SchoolClass> Classes { get; set; }

        public virtual List<StudentClass> StudentClass { get; set; }

        public virtual List<ClassHead> ClassHeads { get; set; }

        public virtual List<StudentParent> StudentParents { get; set; }

        public virtual List<ClassAttendance> ClassAttendance { get; set; }

        public virtual List<KcpeResults> KCPEResults { get; set; }

        public virtual List<ExamResult> ExamResults { get; set; }

        public virtual List<StudentSubject> StudentSubjects { get; set; }
    }
}
