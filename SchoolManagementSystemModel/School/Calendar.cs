using SchoolManagementSystemModel.Academics;
using SchoolManagementSystemModel.Enums;
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
    public class Calendar : SMSModelBaseClass
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string PeriodName { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public Status Status { get; set; }

        public virtual List<ClassAttendance> ClassAttendance {get; set; }

        public virtual List<Examination> Examinations { get; set; }
    }
}
