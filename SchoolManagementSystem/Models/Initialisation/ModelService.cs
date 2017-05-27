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
            using (SchoolContext dbcontext = new SchoolContext())
            {
                string path = HttpContext.Current.Server.MapPath(@"~/Models/Initialisation/PostalCodesKenya.txt");

                string[] postalCodesFile = File.ReadAllLines(path);

                foreach (string postalCodeLine in postalCodesFile)
                {
                    string postalNameText = (postalCodeLine.Split('-')[0]).ToUpper();
                    int postalCodeText = Int32.Parse(postalCodeLine.Split('-')[1]);

                    PostalCode postalCode = new PostalCode() { Code = postalCodeText, PostalName = postalNameText };
                    dbcontext.PostalCode.Add(postalCode);
                }
                dbcontext.SaveChanges();
            }
        }

        public static void InsertConfigParams()
        {
            using (SchoolContext dbcontext = new SchoolContext())
            {
                dbcontext.ConfigParams.Add(new ConfigParams() { ParamCategory = "Teacher", ParamType = "Lessons", ParamName = "Lessons", Value = 30 });
                dbcontext.ConfigParams.Add(new ConfigParams() { ParamCategory = "Student", ParamType = "Subjects", ParamName = "Form 1", Value = 8 });
                dbcontext.ConfigParams.Add(new ConfigParams() { ParamCategory = "Student", ParamType = "Subjects", ParamName = "Form 2", Value = 8 });
                dbcontext.ConfigParams.Add(new ConfigParams() { ParamCategory = "Student", ParamType = "Subjects", ParamName = "Form 3", Value = 15 });
                dbcontext.ConfigParams.Add(new ConfigParams() { ParamCategory = "Student", ParamType = "Subjects", ParamName = "Form 4", Value = 15 });
                dbcontext.SaveChanges();
            }
        }

        public static void InsertCounty()
        {
            using (SchoolContext dbcontext = new SchoolContext())
            {
                string path = HttpContext.Current.Server.MapPath(@"~/Models/Initialisation/Counties.txt");

                string[] Counties = File.ReadAllLines(path);

                foreach (string CountyLine in Counties)
                {
                    string countyName = CountyLine;

                    County County = new County() { CountyName = countyName };

                    dbcontext.County.Add(County);
                }
                dbcontext.SaveChanges();
            }
        }

        public static void InsertConstituency()
        {
            using (SchoolContext dbcontext = new SchoolContext())
            {
                string path = HttpContext.Current.Server.MapPath(@"~/Models/Initialisation/Constituencies.txt");

                string[] Constituencies = File.ReadAllLines(path);

                foreach (string ConstituencyLine in Constituencies)
                {
                    string constituencyName = ConstituencyLine.Split('=')[0];

                    string countyName = ConstituencyLine.Split('=')[1];

                    var CountyId = dbcontext.County.Where(n => n.CountyName == countyName).Select(f => f.Id ).FirstOrDefault();

                    County County = dbcontext.County.Find(CountyId) ;

                    Constituency Constituency = new Constituency() { Name = constituencyName, County = County };

                    dbcontext.Constituency.Add(Constituency);
                }
                dbcontext.SaveChanges();
            }
        }

        public static void InsertWard()
        {
            using (SchoolContext dbcontext = new SchoolContext())
            {
                string path = HttpContext.Current.Server.MapPath(@"~/Models/Initialisation/Wards.txt");

                string[] Wards = File.ReadAllLines(path);

                foreach (string WardLine in Wards)
                {
                    string wardName = WardLine.Split('=')[0];

                    string constituencyName = WardLine.Split('=')[1];

                    var ConstituencyId = dbcontext.Constituency.Where(n => n.Name == constituencyName).Select(c => c.Id).FirstOrDefault();

                    Constituency Constituency = dbcontext.Constituency.Find(ConstituencyId);
                    
                    Ward Ward = new Ward() { Name = wardName, Constituency = Constituency };

                    dbcontext.Ward.Add(Ward);
                }
                dbcontext.SaveChanges();
            }
        }
    }
}