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

        public Examination Examination { get; set; }

        public int StudentId { get; set; }

        public Student.StudentDetails Student { get; set; }

        [Required]
        public double MarkScored { get; set; }
    }
}
