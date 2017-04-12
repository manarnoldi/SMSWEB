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
    public class Department :SMSModelBaseClass
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }
        
        public int StaffDetailsId { get; set; }

        public virtual StaffDetails StaffDetails { get; set; }

        public Status status { get; set; }
    }
}
