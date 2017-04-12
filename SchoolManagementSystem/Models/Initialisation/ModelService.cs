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

            //dbcontext.ConfigParams.Add(new ConfigParams() { ParamType = "Teacher", ParamName ="", Value, });
        }
    }
}