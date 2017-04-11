using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Academics
{
    public class Grade
    {
        public int id { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string gradeName { get; set; }

        [Required]
        public float upperMark { get; set; }

        [Required]
        public float lowerMark { get; set; }

        public int points { get; set; }
    }
}
