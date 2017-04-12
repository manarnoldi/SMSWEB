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

        public ActionResult Index()
        {
            //dbcontext.Database.ExecuteSqlCommand("TRUNCATE TABLE [PostalCode]");
            dbcontext.PostalCode.Delete();

            ModelService.InsertPostalCodes();
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