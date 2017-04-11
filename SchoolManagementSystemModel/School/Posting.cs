using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.School
{
    public class Posting
    {
        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string name { get; set; }

        public int SchPostingPeriodId { get; set; }

        public virtual PostingPeriod SchPostingPeriod { get; set; }
    }
}
