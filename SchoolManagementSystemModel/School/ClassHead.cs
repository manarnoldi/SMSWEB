using SchoolManagementSystemModel.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.School
{
    public class ClassHead: SMSModelBaseClass
    {
        public int Id { get; set; }

        public int SchoolClassId { get; set; }

        public virtual SchoolClass SchoolClass { get; set; }

        public int StudentDetailsId { get; set; }

        public virtual StudentDetails StudentDetails { get; set; }
        
        public int StaffDetailsId { get; set; }

        public virtual StaffDetails StaffDetails { get; set; }
    }
}
