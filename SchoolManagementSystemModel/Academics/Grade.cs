using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Academics
{
    public class Grade : SMSModelBaseClass
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string GradeName { get; set; }

        [Required]
        public float UpperMark { get; set; }

        [Required]
        public float LowerMark { get; set; }

        public int Points { get; set; }

        public virtual List<GradeRemark> GradeRemarks { get; set; }

    }
}
