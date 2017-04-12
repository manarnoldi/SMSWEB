using SchoolManagementSystemModel.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemModel.Academics
{
    public class Examination: SMSModelBaseClass
    {
        public int Id { get; set; }

        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }

        public int CalendarId { get; set; }

        public virtual Calendar Calendar { get; set; }

        public int SchoolClassId { get; set; }

        public virtual SchoolClass SchoolClass { get; set; }

        public int ExamNameId { get; set; }

        public virtual ExamName ExamName { get; set; }

        public double ExamMark { get; set; }

        public double TypeTotalMark { get; set; }

        public double TypeContrMark { get; set; }

        public virtual List<ExamResult> ExamResults { get; set; }
    }
}
