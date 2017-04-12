using SchoolManagementSystemModel.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Academics
{
    public class ExamResult: SMSModelBaseClass
    {
        public int Id { get; set; }

        public int ExaminationId { get; set; }

        public virtual Examination Examination { get; set; }

        public int StudentDetailsId { get; set; }

        public virtual StudentDetails StudentDetails { get; set; }

        [Required]
        public double MarkScored { get; set; }
    }
}
