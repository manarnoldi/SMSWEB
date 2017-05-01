using SchoolManagementSystemModel.Academics;
using SchoolManagementSystemModel.School;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Models.Initialisation
{
    public static class ModelService
    {
        public static void InsertPostalCodes()
        {
            SchoolContext dbcontext = new SchoolContext();

            string path = HttpContext.Current.Server.MapPath(@"~/Models/Initialisation/PostalCodesKenya.txt");

            string[] postalCodesFile = File.ReadAllLines(path);

            foreach (string postalCodeLine in postalCodesFile)
            {
                string postalNameText = postalCodeLine.Split('-')[0];
                int postalCodeText = Int32.Parse(postalCodeLine.Split('-')[1]);

                PostalCode postalCode = new PostalCode() { Code = postalCodeText, PostalName = postalNameText };
                dbcontext.PostalCode.Add(postalCode);
            }
            dbcontext.SaveChanges();
        }

        public static void InsertConfigParams()
        {
            SchoolContext dbcontext = new SchoolContext();

            dbcontext.ConfigParams.Add(new ConfigParams() { ParamCategory ="Teacher", ParamType = "Lessons", ParamName ="Lessons", Value = 30 });
            dbcontext.ConfigParams.Add(new ConfigParams() { ParamCategory = "Student", ParamType = "Subjects", ParamName = "Form 1", Value = 8 });
            dbcontext.ConfigParams.Add(new ConfigParams() { ParamCategory = "Student", ParamType = "Subjects", ParamName = "Form 2", Value = 8 });
            dbcontext.ConfigParams.Add(new ConfigParams() { ParamCategory = "Student", ParamType = "Subjects", ParamName = "Form 3", Value = 15 });
            dbcontext.ConfigParams.Add(new ConfigParams() { ParamCategory = "Student", ParamType = "Subjects", ParamName = "Form 4", Value = 15 });
            dbcontext.SaveChanges();
        }
    }
}