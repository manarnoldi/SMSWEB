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

namespace SchoolManagementSystem.Controllers
{
    public class SchoolDetailsController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: SchoolDetails
        public ActionResult Index()
        {
            var schoolDetails = db.SchoolDetails.Include(s => s.CoutyWard).Include(s => s.PostalCode);
            return View(schoolDetails.ToList());
        }

        // GET: SchoolDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolDetails schoolDetails = db.SchoolDetails.Find(id);
            if (schoolDetails == null)
            {
                return HttpNotFound();
            }
            return View(schoolDetails);
        }

        // GET: SchoolDetails/Create
        public ActionResult Create()
        {
            ViewBag.CoutyWardId = new SelectList(db.CountyWards, "Id", "County");
            ViewBag.PostalCodeId = new SelectList(db.PostalCode, "Id", "PostalName");
            return View();
        }

        // POST: SchoolDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,PhoneNumber,EmailAddress,MobileNumber,PostalAddress,PostalCodeId,CoutyWardId,Logo,CreateBy,CreateDate,ModifyBy,ModifyDate")] SchoolDetails schoolDetails)
        {
            if (ModelState.IsValid)
            {
                db.SchoolDetails.Add(schoolDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CoutyWardId = new SelectList(db.CountyWards, "Id", "County", schoolDetails.CoutyWardId);
            ViewBag.PostalCodeId = new SelectList(db.PostalCode, "Id", "PostalName", schoolDetails.PostalCodeId);
            return View(schoolDetails);
        }

        // GET: SchoolDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolDetails schoolDetails = db.SchoolDetails.Find(id);
            if (schoolDetails == null)
            {
                return HttpNotFound();
            }
            ViewBag.CoutyWardId = new SelectList(db.CountyWards, "Id", "County", schoolDetails.CoutyWardId);
            ViewBag.PostalCodeId = new SelectList(db.PostalCode, "Id", "PostalName", schoolDetails.PostalCodeId);
            return View(schoolDetails);
        }

        // POST: SchoolDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,PhoneNumber,EmailAddress,MobileNumber,PostalAddress,PostalCodeId,CoutyWardId,Logo,CreateBy,CreateDate,ModifyBy,ModifyDate")] SchoolDetails schoolDetails)
        {
            if (ModelState.IsValid)
            {
                
                db.Entry(schoolDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CoutyWardId = new SelectList(db.CountyWards, "Id", "County", schoolDetails.CoutyWardId);
            ViewBag.PostalCodeId = new SelectList(db.PostalCode, "Id", "PostalName", schoolDetails.PostalCodeId);
            return View(schoolDetails);
        }

        // GET: SchoolDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolDetails schoolDetails = db.SchoolDetails.Find(id);
            if (schoolDetails == null)
            {
                return HttpNotFound();
            }
            return View(schoolDetails);
        }

        // POST: SchoolDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SchoolDetails schoolDetails = db.SchoolDetails.Find(id);
            db.SchoolDetails.Remove(schoolDetails);
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
    }
}
