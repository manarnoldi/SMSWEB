using SchoolManagementSystemModel.Academics;
using SchoolManagementSystemModel.Enums;
using SchoolManagementSystemModel.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.School
{
    public class SchoolClass: SMSModelBaseClass
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        [Column(TypeName = "varchar")]
        public string Stream { get; set; }

        public int Year { get; set; }

        public Status Status { get; set; }

        public virtual List<ClassHead> ClassHeads {get; set; }

        public virtual List<StudentClass> StudentClass { get; set; }

        public virtual List<Examination> Examinations { get; set; }

        public virtual List<StaffSubject> StaffSubjects { get; set; }

        public virtual List<StudentSubject> StudentSubjects { get; set; }
    }
}
