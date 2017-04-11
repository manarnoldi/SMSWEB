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
    public class StudentDetails
    {
        public int id { get; set; }

        public int admNo { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string firstName { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string middleName { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string lastName { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string gender { get; set; }

        [StringLength(30)]
        [Column(TypeName ="varchar")]
        public string ward { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string county { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string religion { get; set; }
        
        public DateTime dateOfBirth { get; set; }

        public DateTime dateOfAdmission { get; set; }

        public Boolean status { get; set; }
        
        public Boolean disabled { get; set; }

        public Byte[] Image { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string studentCategory { get; set; }

        [Required]
        public int currentClassId { get; set; }

        public string createdBy { get; set; }

        public DateTime createdDate { get; set; }

        public string modifiedBy { get; set; }

        public DateTime modifyDate { get; set; }

        public virtual List<SchoolClass> classes { get; set; }

        public virtual List<ClassHead> ClassHeads { get; set; }

        public virtual List<StudentParent> StuStudentParents { get; set; }
    }
}
