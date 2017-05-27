using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.School
{
   public class County : SMSModelBaseClass
    {
        public int Id{ get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string CountyName { get; set; }

        public virtual List<Constituency> Constituency { get; set; }
    }
}
