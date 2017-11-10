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
    public class WardsController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: Wards
        public ActionResult Index()
        {
            return RedirectToAction("Create");
        }

        // GET: Wards/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ward ward = db.Ward.Find(id);
            if (ward == null)
            {
                return HttpNotFound();
            }
            return View(ward);
        }

        // GET: Wards/Create
        public ActionResult Create()
        {
            WardsViewModel model = new WardsViewModel() {
                Ward = new Ward(),
                Wards = db.Ward.OrderBy(w=>w.Name).ToList(),
                Counties = db.County.OrderBy(n=>n.CountyName).ToList(),
                Constituencies = db.Constituency.OrderBy(c=>c.Name).ToList()
            };
            return View(model);
        }

        // POST: Wards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,ConstituencyId,CreateBy,CreateDate,ModifyBy,ModifyDate")] Ward ward)
        {
            if (ModelState.IsValid)
            {
                db.Ward.Add(ward);
                db.SaveChanges();
                Utils.ShowUserMessage("confirmation", "Your record has been saved successfully.");
                return RedirectToAction("Index");
            }

            ViewBag.ConstituencyId = new SelectList(db.Constituency, "Id", "Name", ward.ConstituencyId);
            return View(ward);
        }

        // GET: Wards/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ward ward = db.Ward.Find(id);
            if (ward == null)
            {
                return HttpNotFound();
            }
            ViewBag.ConstituencyId = new SelectList(db.Constituency, "Id", "Name", ward.ConstituencyId);
            return View(ward);
        }

        // POST: Wards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,ConstituencyId,CreateBy,CreateDate,ModifyBy,ModifyDate")] Ward ward)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ward).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ConstituencyId = new SelectList(db.Constituency, "Id", "Name", ward.ConstituencyId);
            return View(ward);
        }

        // GET: Wards/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ward ward = db.Ward.Find(id);
            if (ward == null)
            {
                return HttpNotFound();
            }
            return View(ward);
        }

        // POST: Wards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ward ward = db.Ward.Find(id);
            db.Ward.Remove(ward);
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
