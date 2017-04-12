using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Student
{
    public class KcpeResults: SMSModelBaseClass
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string SchoolName { get; set; }
        
        public int ExamYear { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string IndexNumber { get; set; }

        [Required]
        public float TotalMarks { get; set; }

        [Required]
        [StringLength(5)]
        [Column(TypeName = "varchar")]
        public string MeanGrade { get; set; }

        [Required]
        public float TotalOutOf { get; set; }

        public int StudentDetailsId { get; set; }

        public virtual StudentDetails StudentDetails { get; set; }
    }
}
