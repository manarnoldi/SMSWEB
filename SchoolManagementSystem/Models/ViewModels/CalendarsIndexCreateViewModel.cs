using SchoolManagementSystemModel.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Models.ViewModels
{
    public class CalendarsIndexCreateViewModel
    {
        public IEnumerable<Calendar> Calendars { get; set; }

        public Calendar CreateCalendar { get; set; }
    }
}