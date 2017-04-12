using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Academics
{
    public class Subject : SMSModelBaseClass
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string SubjectName { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string SubjectCode { get; set; }

        public bool Compulsory { get; set; }

        public int SubjectCategoryId { get; set; }

        public bool Offered { get; set; }

        public virtual SubjectCategory SubjectCategory { get; set; }

        public virtual List<Examination> Examinations { get; set; }

        public virtual List<GradeRemark> GradeRemarks { get; set; }

        public virtual List<StaffSubject> StaffSubjects { get; set; }

        public virtual List<StudentSubject> StudentSubjects { get; set; }
    }
}
