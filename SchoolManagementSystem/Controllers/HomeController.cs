using EntityFramework.Extensions;
using SchoolManagementSystem.Models.Initialisation;
using SchoolManagementSystemModel.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        SchoolContext dbcontext = new SchoolContext();

        private int CountNumberOfItems(string ModelName)
        {
            int count = 0;
            switch (ModelName.ToLower())
            {
                case "postalcode":
                    count = dbcontext.PostalCode.Count();
                    break;

                case "configparams":
                    count = dbcontext.ConfigParams.Count();
                    break;

                case "county":
                    count = dbcontext.County.Count();
                    break;

                case "constituency":
                    count = dbcontext.Constituency.Count();
                    break;

                case "ward":
                    count = dbcontext.Ward.Count();
                    break;

                case "period":
                    count = dbcontext.Posting.Count();
                    break;

                default:
                    count = 0;
                    break;
            }
            return count;
        }

        public ActionResult Index()
        {
            //dbcontext.Database.ExecuteSqlCommand("TRUNCATE TABLE [PostalCode]");

            if (CountNumberOfItems("PostalCode") <= 0)
            {
                ModelService.InsertPostalCodes();
            }
            if (CountNumberOfItems("ConfigParams") <= 0)
            {
                ModelService.InsertConfigParams();
            }
            if (CountNumberOfItems("County") <= 0)
            {
                ModelService.InsertCounty();
            }
            if (CountNumberOfItems("Constituency") <= 0)
            {
                ModelService.InsertConstituency();
            }
            if (CountNumberOfItems("Ward") <= 0)
            {
                ModelService.InsertWard();
            }
            if (CountNumberOfItems("period") != 2)
            {
                dbcontext.Posting.RemoveRange(dbcontext.Posting);
                dbcontext.SaveChanges();
                ModelService.InsertPosting();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}