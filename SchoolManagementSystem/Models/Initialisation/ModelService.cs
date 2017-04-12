using SchoolManagementSystemModel.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Models.Initialisation
{
    public static class ModelService
    {
        public static void InsertPostalCodes()
        {
            SchoolContext dbcontext = new SchoolContext();
            string[] postalCodesFile = System.IO.File.ReadAllLines("PostalCodeKenya.txt");

            foreach (string postalCodeLine in postalCodesFile)
            {
                string postalNameText = postalCodeLine.Split('-')[0];
                int postalCodeText = Int32.Parse(postalCodeLine.Split('-')[1]);

                PostalCode postalCode = new PostalCode() { Code = postalCodeText, PostalName = postalNameText };
                dbcontext.PostalCode.Add(postalCode);
            }
            dbcontext.SaveChanges();
        }
    }
}