using SchoolManagementSystemModel.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Models.ViewModels
{
    public class PostalCodesViewModel
    {
        public IEnumerable<PostalCode> PostalCodes { get; set; }

        public PostalCode PostalCode { get; set; }
    }
}