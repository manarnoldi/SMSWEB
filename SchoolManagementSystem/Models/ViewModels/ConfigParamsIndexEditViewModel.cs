using SchoolManagementSystemModel.Academics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Models.ViewModels
{
    public class ConfigParamsIndexEditViewModel
    {
        public IEnumerable<ConfigParams> ConfigParameters { get; set; }

        public ConfigParams ConfigParameter { get; set; }
    }
}