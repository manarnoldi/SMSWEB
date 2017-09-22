using SchoolManagementSystemModel.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Models.ViewModels
{
    public class PostingPeriodsViewModel
    {
        public IEnumerable<PostingPeriod> PostingPeriods { get; set; }

        public PostingPeriod PostingPeriod { get; set; }

        public string PeriodName { get; set; }

        public int Year { get; set; }
    }
}