using SchoolManagementSystemModel.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Academics
{
    public class StaffSubject
    {
        public int Id { get; set; }

        public int StaffId { get; set; }

        public virtual StaffDetails Staff { get; set; }

        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }

        public int ClassId { get; set; }

        public virtual SchoolClass SchoolClass { get; set; }
    }
}
