using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel
{
    public class SMSModelBaseClass
    {
        [Required]
        [StringLength(50)]
        [Column(TypeName ="varchar")]
        [ScaffoldColumn(false)]
        public string CreateBy { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(50)]
        [ScaffoldColumn(false)]
        [Column(TypeName = "varchar")]
        public string ModifyBy { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public DateTime ModifyDate { get; set; }

    }
}
