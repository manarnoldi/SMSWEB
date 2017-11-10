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
    public class ConstituenciesController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: Constituencies
        public ActionResult Index()
        {
            return RedirectToAction("Create");
        }

        // GET: Constituencies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constituency constituency = db.Constituency.Find(id);
            if (constituency == null)
            {
                return HttpNotFound();
            }
            return View(constituency);
        }

        // GET: Constituencies/Create
        public ActionResult Create()
        {
            ConstituencyViewModel model = new ConstituencyViewModel()
            {
                Constituency = new Constituency(),
                Constituencies = db.Constituency.OrderBy(n => n.Name).ToList(),
                Counties = db.County.OrderBy(n => n.CountyName).ToList()
            };

            return View(model);
        }

        // POST: Constituencies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Constituency constituency)
        {
            if (ModelState.IsValid)
            {
                db.Constituency.Add(constituency);
                db.SaveChanges(); 
                Utils.ShowUserMessage("Confirmation","Record has been saved successfully.");
                return RedirectToAction("Index");
            }

            ViewBag.CountyId = new SelectList(db.County, "Id", "CountyName", constituency.CountyId);
            return View(constituency);
        }

        // GET: Constituencies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constituency constituency = db.Constituency.Find(id);
            ConstituencyViewModel model = new ConstituencyViewModel()
            {
                Constituency = constituency,
                Constituencies = db.Constituency.OrderBy(n => n.Name).ToList(),
                Counties = db.County.OrderBy(n => n.CountyName).ToList()
            };
            if (constituency == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: Constituencies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Constituency constituency)
        {
            if (ModelState.IsValid)
            {
                db.Entry(constituency).State = EntityState.Modified;
                db.SaveChanges();
                Utils.ShowUserMessage("Confirmation","Your record has been edited successfully.");
                return RedirectToAction("Index");
            }

            Constituency constituencyToLoad = db.Constituency.Find(constituency.Id);
            ConstituencyViewModel model = new ConstituencyViewModel()
            {
                Constituency = constituencyToLoad,
                Constituencies = db.Constituency.OrderBy(n => n.Name).ToList(),
                Counties = db.County.OrderBy(n => n.CountyName).ToList()
            };
            if (constituency == null)
            {
                return HttpNotFound();
            }
            Utils.ShowUserMessage("warning","An error occured while saving your record. Report this to the system administrator.");
            return View(model);
        }

        // GET: Constituencies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constituency constituency = db.Constituency.Find(id);
            if (constituency == null)
            {
                return HttpNotFound();
            }
            return View(constituency);
        }

        // POST: Constituencies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Constituency constituency = db.Constituency.Find(id);
            db.Constituency.Remove(constituency);
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
