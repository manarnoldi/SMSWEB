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

                case "ConfigParams":
                    count = dbcontext.ConfigParams.Count();
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
            else if (CountNumberOfItems("ConfigParams") <= 0)
            {
                ModelService.InsertPostalCodes();
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