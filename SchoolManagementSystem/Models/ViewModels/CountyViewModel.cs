using SchoolManagementSystemModel.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Models.ViewModels
{
    public class CountyViewModel
    {
        public County County { get; set; }

        public IEnumerable<County> Counties { get; set; }
    }
}