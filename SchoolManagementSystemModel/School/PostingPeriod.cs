using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.School
{
    public class PostingPeriod
    {
        [Key, ForeignKey("SchPosting")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SchPostingId { get; set; }

        [Required]
        public DateTime startDate { get; set; }

        [Required]
        public DateTime endDate { get; set; }

        public Boolean status { get; set; }

        public virtual Posting SchPosting { get; set; }
    }
}
