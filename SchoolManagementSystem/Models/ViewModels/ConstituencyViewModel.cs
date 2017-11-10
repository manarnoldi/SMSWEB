using SchoolManagementSystemModel.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Models.ViewModels
{
    public class ConstituencyViewModel
    {
        public Constituency Constituency { get; set; }

        public IEnumerable<Constituency> Constituencies { get; set; }

        public IEnumerable<County> Counties { get; set; }
    }
}