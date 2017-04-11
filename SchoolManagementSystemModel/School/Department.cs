using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.School
{
    public class Department
    {
        public int id { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string name { get; set; }
        
        public int departmentHeadId { get; set; }

        public Boolean status { get; set; }

        public string createdBy { get; set; }

        public DateTime createdDate { get; set; }

        public string modifiedBy { get; set; }

        public DateTime modifyDate { get; set; }
    }
}
