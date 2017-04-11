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
        public string createdBy { get; set; }

        [Required]
        public DateTime createdDate { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string modifiedBy { get; set; }

        [Required]
        public DateTime modifyDate { get; set; }

    }
}
