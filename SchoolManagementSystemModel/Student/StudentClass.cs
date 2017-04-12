using SchoolManagementSystemModel.Enums;
using SchoolManagementSystemModel.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Student
{
    public class StudentClass : SMSModelBaseClass
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public virtual StudentDetails student { get; set; }

        public int ClassId { get; set; }

        public virtual SchoolClass SchoolClass { get; set;}
        
        public Status Status { get; set; }
    }
}
