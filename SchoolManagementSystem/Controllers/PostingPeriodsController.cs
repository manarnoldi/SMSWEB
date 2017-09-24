using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SchoolManagementSystem.Models.Initialisation;
using SchoolManagementSystemModel.School;
using SchoolManagementSystem.Models.ViewModels;
using System.Web.Script.Serialization;

namespace SchoolManagementSystem.Controllers
{
    public class PostingPeriodsController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: PostingPeriods
        public ActionResult Index()
        {
            PostingPeriodsViewModel model = new PostingPeriodsViewModel()
            {
                PostingPeriods = db.PostingPeriod.Include(p => p.Calendar).Include(p => p.Posting)
                .OrderByDescending(c=>c.Calendar.Year)
                .ThenBy(c=>c.Calendar.PeriodName)
                .ThenBy(c=>c.Posting.Name)
                .ToList(),
                PostingPeriod = new PostingPeriod(),
                Year = 0,
                PeriodName = string.Empty
            };
            ViewBag.Year = new SelectList(db.Calendar.Select(y => new { y.Year }).Distinct().OrderByDescending(y => y.Year),"Year","Year");
            ViewBag.CalendarId = new SelectList(db.Calendar, "PeriodName", "PeriodName");
            ViewBag.PostingId = new SelectList(db.Posting, "Id", "Name");
            return View(model);
        }

        // GET: PostingPeriods/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostingPeriod postingPeriod = db.PostingPeriod.Find(id);
            if (postingPeriod == null)
            {
                return HttpNotFound();
            }
            return View(postingPeriod);
        }

        // GET: PostingPeriods/Create
        public ActionResult Create()
        {
            ViewBag.Year = new SelectList(db.Calendar.Select(y => new { y.Year }).Distinct().OrderByDescending(y => y.Year), "Year", "Year");
            ViewBag.CalendarId = new SelectList(db.Calendar, "PeriodName", "PeriodName");
            ViewBag.PostingId = new SelectList(db.Posting, "Id", "Name");
            return View();
        }

        // POST: PostingPeriods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PostingPeriodsViewModel postingPeriodVM)
        {
            if (ModelState.IsValid)
            {
                Calendar calendar = db.Calendar.Where(p => p.PeriodName == postingPeriodVM.PeriodName).Where(y => y.Year == postingPeriodVM.Year).FirstOrDefault();
                
                postingPeriodVM.PostingPeriod.CalendarId = calendar.Id;
                db.PostingPeriod.Add(postingPeriodVM.PostingPeriod);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Year = new SelectList(db.Calendar.Select(y => new { y.Year }).Distinct().OrderByDescending(y => y.Year), "Year", "Year");
            ViewBag.CalendarId = new SelectList(db.Calendar, "PeriodName", "PeriodName", postingPeriodVM.PostingPeriod.CalendarId);
            ViewBag.PostingId = new SelectList(db.Posting, "Id", "Name", postingPeriodVM.PostingPeriod.PostingId);
            return View(postingPeriodVM.PostingPeriod);
        }

        // GET: PostingPeriods/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            PostingPeriodsViewModel model = new PostingPeriodsViewModel()
            {
                PostingPeriods = db.PostingPeriod.Include(p => p.Calendar).Include(p => p.Posting)
                .OrderByDescending(c => c.Calendar.Year)
                .ThenBy(c => c.Calendar.PeriodName)
                .ThenBy(c => c.Posting.Name)
                .ToList(),
                PostingPeriod = db.PostingPeriod.Find(id),
                Year = 0,
                PeriodName = string.Empty
            };
            
            int selectedYear = db.PostingPeriod.Include(p => p.Calendar).First(i => i.Id == id).Calendar.Year;
            string selectedPeriodName = db.PostingPeriod.Include(p => p.Calendar).First(i => i.Id == id).Calendar.PeriodName; 
           
            ViewBag.Year = new SelectList(db.Calendar.Select(y => new { y.Year }).Distinct().OrderByDescending(y => y.Year), "Year", "Year", selectedYear);
            ViewBag.CalendarId = new SelectList(db.Calendar, "PeriodName", "PeriodName", selectedPeriodName);
            ViewBag.PostingId = new SelectList(db.Posting, "Id", "Name", db.PostingPeriod.Find(id).PostingId);
            return View(model);
        }

        // POST: PostingPeriods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PostingPeriodsViewModel postingPeriodVM)
        {
            if (ModelState.IsValid)
            {
                postingPeriodVM.PostingPeriod.StartDate = db.PostingPeriod.Where(i => i.Id == postingPeriodVM.PostingPeriod.Id).Select(i => i.StartDate).FirstOrDefault();
                postingPeriodVM.PostingPeriod.EndDate = db.PostingPeriod.Where(i => i.Id == postingPeriodVM.PostingPeriod.Id).Select(i => i.EndDate).FirstOrDefault();
                postingPeriodVM.PostingPeriod.CalendarId = db.PostingPeriod.Where(i => i.Id == postingPeriodVM.PostingPeriod.Id).Select(i => i.CalendarId).FirstOrDefault();
                postingPeriodVM.PostingPeriod.PostingId = db.PostingPeriod.Where(i => i.Id == postingPeriodVM.PostingPeriod.Id).Select(i => i.PostingId).FirstOrDefault();
                db.Entry(postingPeriodVM.PostingPeriod).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Year = new SelectList(db.Calendar.Select(y => new { y.Year }).Distinct().OrderByDescending(y => y.Year), "Year", "Year");
            ViewBag.CalendarId = new SelectList(db.Calendar, "PeriodName", "PeriodName", postingPeriodVM.PostingPeriod.CalendarId);
            ViewBag.PostingId = new SelectList(db.Posting, "Id", "Name", postingPeriodVM.PostingPeriod.PostingId);
            return View(postingPeriodVM.PostingPeriod);

            //if (ModelState.IsValid)
            //{
            //    db.Entry(postingPeriod).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //ViewBag.Year = new SelectList(db.Calendar.Select(y => new { y.Year }).Distinct().OrderByDescending(y => y.Year), "Year", "Year");
            //ViewBag.CalendarId = new SelectList(db.Calendar, "PeriodName", "PeriodName", postingPeriod.CalendarId);
            //ViewBag.PostingId = new SelectList(db.Posting, "Id", "Name", postingPeriod.PostingId);
            //return View(postingPeriod);
        }

        // GET: PostingPeriods/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostingPeriod postingPeriod = db.PostingPeriod.Include(c=>c.Calendar).Include(p=>p.Posting).SingleOrDefault(i=>i.Id == id);
            if (postingPeriod == null)
            {
                return HttpNotFound();
            }
            return View(postingPeriod);
        }

        // POST: PostingPeriods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PostingPeriod postingPeriod = db.PostingPeriod.Find(id);
            db.PostingPeriod.Remove(postingPeriod);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            } 
            base.Dispose(disposing);
        }
        public ActionResult getPeriodName(string itemId)
        {
            int yearInt = Convert.ToInt32(itemId);
            List<Calendar> calendar = new List<Calendar>();
            calendar = db.Calendar.Where(y => y.Year == yearInt).OrderBy(p=>p.PeriodName).ToList();
            
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            string result = javaScriptSerializer.Serialize(calendar);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        

    }
}
