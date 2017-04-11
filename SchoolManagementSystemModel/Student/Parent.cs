using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Student
{
    public class Parent
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string firstName { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string middleName { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string lastName { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string emailAddress { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string phoneNo { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string ward { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string county { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string occupation { get; set; }

        public virtual List<StudentParent> StuStudentParents { get; set; }
    }
}
