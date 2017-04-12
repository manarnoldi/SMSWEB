using SchoolManagementSystemModel.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Academics
{
    public class StaffSubject : SMSModelBaseClass
    {
        public int Id { get; set; }

        public int StaffDetailsId { get; set; }

        public virtual StaffDetails StaffDetails { get; set; }

        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }

        public int SchoolClassId { get; set; }

        public virtual SchoolClass SchoolClass { get; set; }
    }
}
