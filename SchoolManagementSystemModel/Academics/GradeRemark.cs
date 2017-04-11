using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Academics
{
    public class GradeRemark
    {
        public int Id { get; set; }

        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }

        public int GradeId { get; set; }

        public virtual Grade Grade { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar")]
        public string Remarks { get; set; }
    }
}
