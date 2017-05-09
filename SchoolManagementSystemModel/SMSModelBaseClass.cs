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
        [StringLength(128)]
        [Column(TypeName ="nvarchar")]
        [ScaffoldColumn(false)]
        public string CreateBy { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(128)]
        [Column(TypeName = "nvarchar")]
        [ScaffoldColumn(false)]
        public string ModifyBy { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public DateTime ModifyDate { get; set; }

    }
}
