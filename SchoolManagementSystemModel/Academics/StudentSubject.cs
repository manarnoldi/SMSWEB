using SchoolManagementSystemModel.School;
using SchoolManagementSystemModel.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Academics
{
    public class StudentSubject
    {
        public int Id { get; set; }

        public int ClassId { get; set; }

        public virtual SchoolClass SchoolClass { get; set; }

        public int StudId { get; set; }

        public virtual Student.StudentDetails student { get; set; }

        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
