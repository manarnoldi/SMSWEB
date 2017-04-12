using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Academics
{
    public class ConfigParams: SMSModelBaseClass
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName ="varchar")]
        public string ParamType { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string ParamCategory { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string ParamName { get; set; }

        public int Value { get; set; }
    }
}
