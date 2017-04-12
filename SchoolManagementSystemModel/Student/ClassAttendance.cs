using SchoolManagementSystemModel.Enums;
using SchoolManagementSystemModel.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Student
{
    public class ClassAttendance : SMSModelBaseClass
    {
        public int Id { get; set; }

        public int StudId { get; set; }

        public virtual StudentDetails StudentDetails { get; set; }

        public int CalendarId { get; set; }

        public virtual Calendar Calendar { get; set; }

        public DateTime Date { get; set; }

        public Attendance Attendance { get; set; }
    }
}
