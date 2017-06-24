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
using System.Web.Script.Serialization;

namespace SchoolManagementSystem.Controllers
{
    public class SchoolDetailsController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: SchoolDetails
        public ActionResult Index()
        {
            int schoolDetailsCount = db.SchoolDetails.Count();
            string redirectAction = "";

            if (schoolDetailsCount > 0) {
                redirectAction = "Edit/"+db.SchoolDetails.First().Id;
            }
            else {
                redirectAction = "Create";
            }
            return RedirectToAction(redirectAction);
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
            ViewBag.PostalCodeId = new SelectList(db.PostalCode.OrderBy(p => p.PostalName), "Id", "PostalName");
            ViewBag.WardId = new SelectList(db.Ward.OrderBy(w => w.Name), "Id", "Name");
            ViewBag.CountyId = db.County.OrderBy(c => c.CountyName).ToList();
            return View();
        }

        // POST: SchoolDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,PhoneNumber,EmailAddress,MobileNumber,PostalAddress,PostalCodeId,WardId,Logo,CreateBy,CreateDate,ModifyBy,ModifyDate")] SchoolDetails schoolDetails)
        {
            if (ModelState.IsValid)
            {
                db.SchoolDetails.Add(schoolDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PostalCodeId = new SelectList(db.PostalCode, "Id", "PostalName", schoolDetails.PostalCodeId);
            ViewBag.WardId = new SelectList(db.Ward, "Id", "Name", schoolDetails.WardId);
            ViewBag.CountyId = db.County.OrderBy(c => c.CountyName).ToList();
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
            ViewBag.PostalCodeId = new SelectList(db.PostalCode, "Id", "PostalName", schoolDetails.PostalCodeId);
            ViewBag.WardId = new SelectList(db.Ward, "Id", "Name", schoolDetails.WardId);
            return View(schoolDetails);
        }

        // POST: SchoolDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,PhoneNumber,EmailAddress,MobileNumber,PostalAddress,PostalCodeId,WardId,Logo,CreateBy,CreateDate,ModifyBy,ModifyDate")] SchoolDetails schoolDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(schoolDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PostalCodeId = new SelectList(db.PostalCode, "Id", "PostalName", schoolDetails.PostalCodeId);
            ViewBag.WardId = new SelectList(db.Ward, "Id", "Name", schoolDetails.WardId);
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

        public ActionResult getConstituencies(string itemId)
        {
            List<Constituency> constituency = new List<Constituency>();
            int countyId = Convert.ToInt32(itemId);
            constituency = db.Constituency.Where(c => c.County.Id == countyId).OrderBy(c => c.Name).ToList();
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            string result = javaScriptSerializer.Serialize(constituency);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult getWards(string itemId)
        {
            List<Ward> ward = new List<Ward>();
            int constituencyId = Convert.ToInt32(itemId);
            ward = db.Ward.Where(c => c.Constituency.Id == constituencyId).OrderBy(w => w.Name).ToList();
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            string result = javaScriptSerializer.Serialize(ward);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
