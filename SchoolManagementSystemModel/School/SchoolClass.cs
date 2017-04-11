using SchoolManagementSystemModel.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.School
{
    public class SchoolClass
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string name { get; set; }

        [Required]
        [StringLength(10)]
        [Column(TypeName = "varchar")]
        public string stream { get; set; }

        public int year { get; set; }

        public Boolean status { get; set; }

        public string createdBy { get; set; }

        public DateTime createdDate { get; set; }

        public string modifiedBy { get; set; }

        public DateTime modifyDate { get; set; }

        public virtual List<ClassHead> ClassHeads {get; set; }
    }
}
