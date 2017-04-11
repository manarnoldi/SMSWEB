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

        public virtual StudentDetails StuStudent { get; set; }

        public int CalendarId { get; set; }

        public virtual Calendar SchCalendar { get; set; }

        public DateTime Date { get; set; }

        public Boolean Status { get; set; }
    }
}
