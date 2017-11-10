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
using SchoolManagementSystem.Assets;

namespace SchoolManagementSystem.Controllers
{
    public class CountiesController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: Counties
        public ActionResult Index()
        {
            return RedirectToAction("Create");
        }

        // GET: Counties/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            County county = db.County.Find(id);
            if (county == null)
            {
                return HttpNotFound();
            }
            return View(county);
        }

        // GET: Counties/Create
        public ActionResult Create()
        {
            CountyViewModel model = new CountyViewModel()
            {
                County = new County(),
                Counties = db.County.OrderBy(c => c.CountyName)
            };
            return View(model);
        }

        // POST: Counties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CountyName,CreateBy,CreateDate,ModifyBy,ModifyDate")] County county)
        {
            if (ModelState.IsValid)
            {
                db.County.Add(county);
                db.SaveChanges();
                Utils.ShowUserMessage("confirmation","Your record has been saved successfully");
                return RedirectToAction("Index");
            }

            return View(county);
        }

        // GET: Counties/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            County county = db.County.Find(id);
            CountyViewModel model = new CountyViewModel()
            {
                County = county,
                Counties = db.County.OrderBy(c => c.CountyName)
            };
            
            if (county == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: Counties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CountyName,CreateBy,CreateDate,ModifyBy,ModifyDate")] County county)
        {
            if (ModelState.IsValid)
            {
                db.Entry(county).State = EntityState.Modified;
                db.SaveChanges();
                Utils.ShowUserMessage("confirmation", "Your record has been saved successfully");
                return RedirectToAction("Index");
            }
            return View(county);
        }

        // GET: Counties/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            County county = db.County.Find(id);
            CountyViewModel model = new CountyViewModel()
            {
                County = county,
                Counties = db.County.OrderBy(c => c.CountyName)
            };
            if (county == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: Counties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            County county = db.County.Find(id);
            db.County.Remove(county);
            db.SaveChanges();
            Utils.ShowUserMessage("confirmation", "Your record has been saved successfully");
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
    }
}
