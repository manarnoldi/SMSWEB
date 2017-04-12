using SchoolManagementSystemModel.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.School
{
    public class PostingPeriod : SMSModelBaseClass
    {
        public int Id { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public Status Status { get; set; }

        public int PostingId { get; set; }

        public virtual Posting Posting { get; set; }
    }
}
