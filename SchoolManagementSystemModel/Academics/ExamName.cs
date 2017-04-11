using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Academics
{
    public class ExamName
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName ="varchar")]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string ExamType { get; set; }
    }
}
