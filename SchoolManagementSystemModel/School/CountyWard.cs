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
    public class CountyWard : SMSModelBaseClass
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string County { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Constituency { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Ward { get; set; }

        public virtual List<Parent> Parents { get; set; }

        public virtual List<StudentDetails> StudentDetails { get; set; }

        public virtual List<StaffDetails> StaffDetails { get; set; }

        public virtual List<SchoolDetails> SchoolDetails { get; set; }
    }
}
