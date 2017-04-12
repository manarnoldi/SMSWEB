using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.School
{
    public class Posting : SMSModelBaseClass
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        public virtual List<PostingPeriod> PostingPeriods { get; set; }
    }
}
