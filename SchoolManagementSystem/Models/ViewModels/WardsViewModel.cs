using SchoolManagementSystemModel.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Models.ViewModels
{
    public class WardsViewModel
    {
        public IEnumerable<Ward> Wards { get; set; }

        public Ward Ward { get; set; }

        public IEnumerable<County> Counties { get; set; }

        public IEnumerable<Constituency> Constituencies { get; set; }
    }
}