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
using System.IO;

namespace SchoolManagementSystem.Controllers
{
    [Authorize]
    public class SchoolDetailsController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: SchoolDetails
        public ActionResult Index()
        {
            int schoolDetailsCount = db.SchoolDetails.Count();
            string redirectAction = "";

            if (schoolDetailsCount > 0)
            {
                redirectAction = "Edit/" + db.SchoolDetails.First().Id;
            }
            else
            {
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
            ViewBag.PostalCodeId = new SelectList(db.PostalCode.OrderBy(p => p.PostalName), "Code", "PostalName");
            ViewBag.WardId = new SelectList(db.Ward.OrderBy(w => w.Name), "Id", "Name");
            ViewBag.CountyId = db.County.OrderBy(c => c.CountyName).ToList();
            return View();
        }

        // POST: SchoolDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,PhoneNumber,EmailAddress,MobileNumber,PostalAddress,PostalCodeId,WardId,SchoolLogoUrl,CreateBy,CreateDate,ModifyBy,ModifyDate")] SchoolDetails schoolDetails, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Data/SchoolLogo/"), fileName);
                    file.SaveAs(path);
                    schoolDetails.SchoolLogoUrl = Url.Content("~/Data/SchoolLogo/" + fileName);
                    
                }
                int postId = db.PostalCode.Where(p => p.Code == schoolDetails.PostalCodeId).Select(i => i.Id).FirstOrDefault();
                schoolDetails.PostalCodeId = postId;

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

            var ward = db.Ward.Where(i => i.Id == schoolDetails.WardId).Include(c => c.Constituency);
            int selectedWard = ward.Select(i => i.Id).First();

            int selectedConstituency = ward.Select(i => i.ConstituencyId).First();
            var Constituency = db.Constituency.Find(selectedConstituency);

            int selectedCounty = Constituency.CountyId;
            int selectedPC = db.PostalCode.Where(i => i.Id == schoolDetails.PostalCodeId).Select(c => c.Code).First();

            ViewBag.PostalCodeId = new SelectList(db.PostalCode.OrderBy(p => p.PostalName), "Code", "PostalName", selectedPC);
            ViewBag.WardId = new SelectList(db.Ward.OrderBy(w => w.Name), "Id", "Name", selectedWard);
            ViewBag.ConstituencyId = new SelectList(db.Constituency.OrderBy(c => c.Name), "Id", "Name", selectedConstituency);
            ViewBag.CountyId = new SelectList(db.County.OrderBy(c => c.CountyName), "Id", "CountyName", selectedCounty); 
            return View(schoolDetails);
        }

        // POST: SchoolDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,PhoneNumber,EmailAddress,MobileNumber,PostalAddress,PostalCodeId,WardId,SchoolLogoUrl,CreateBy,CreateDate,ModifyBy,ModifyDate")] SchoolDetails schoolDetails, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Data/SchoolLogo/"), fileName);
                    file.SaveAs(path);
                    schoolDetails.SchoolLogoUrl = Url.Content("~/Data/SchoolLogo/" + fileName);
                    
                }

                int postId = db.PostalCode.Where(p => p.Code == schoolDetails.PostalCodeId).Select(i => i.Id).FirstOrDefault();
                schoolDetails.PostalCodeId = postId;

                db.Entry(schoolDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            var ward = db.Ward.Where(i => i.Id == schoolDetails.WardId).Include(c => c.Constituency);
            int selectedWard = ward.Select(i => i.Id).First();

            int selectedConstituency = ward.Select(i => i.ConstituencyId).First();
            var Constituency = db.Constituency.Find(selectedConstituency);

            int selectedCounty = Constituency.CountyId;
            int selectedPC = db.PostalCode.Where(i => i.Id == schoolDetails.PostalCodeId).Select(c => c.Code).First();

            ViewBag.PostalCodeId = new SelectList(db.PostalCode.OrderBy(p => p.PostalName), "Code", "PostalName", selectedPC);
            ViewBag.WardId = new SelectList(db.Ward.OrderBy(w => w.Name), "Id", "Name", selectedWard);
            ViewBag.ConstituencyId = new SelectList(db.Constituency.OrderBy(c => c.Name), "Id", "Name", selectedConstituency);
            ViewBag.CountyId = new SelectList(db.County.OrderBy(c => c.CountyName), "Id", "CountyName", selectedCounty);
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
