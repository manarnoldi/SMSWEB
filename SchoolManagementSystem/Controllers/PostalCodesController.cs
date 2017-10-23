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

namespace SchoolManagementSystem.Controllers
{
    public class PostalCodesController : Controller
    {
        private SchoolContext db = new SchoolContext();

        public object PostalCodeViewModel { get; private set; }

        // GET: PostalCodes
        public ActionResult Index()
        {
            return RedirectToAction("Create");
            //return View(db.PostalCode.ToList());
        }

        // GET: PostalCodes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostalCode postalCode = db.PostalCode.Find(id);
            if (postalCode == null)
            {
                return HttpNotFound();
            }
            return View(postalCode);
        }

        // GET: PostalCodes/Create
        public ActionResult Create()
        {
            PostalCodesViewModel model = new PostalCodesViewModel()
            {
                PostalCode = new PostalCode(),
                PostalCodes = db.PostalCode.OrderBy(p => p.Code).ToList()
            };
            return View(model);
        }

        // POST: PostalCodes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Code,PostalName,CreateBy,CreateDate,ModifyBy,ModifyDate")] PostalCode postalCode)
        {
            if (ModelState.IsValid)
            {
                db.PostalCode.Add(postalCode);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(postalCode);
        }

        // GET: PostalCodes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            PostalCode postalCode = db.PostalCode.Find(id);
            if (postalCode == null)
            {
                return HttpNotFound();
            }

            PostalCodesViewModel model = new PostalCodesViewModel()
            {
                PostalCode = postalCode,
                PostalCodes = db.PostalCode.OrderBy(p => p.Code).ToList()
            };

            return View(model);
        }

        // POST: PostalCodes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Code,PostalName,CreateBy,CreateDate,ModifyBy,ModifyDate")] PostalCode postalCode)
        {
            if (ModelState.IsValid)
            {
                db.Entry(postalCode).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(postalCode);
        }

        // GET: PostalCodes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostalCode postalCode = db.PostalCode.Find(id);
            if (postalCode == null)
            {
                return HttpNotFound();
            }
            PostalCodesViewModel model = new PostalCodesViewModel()
            {
                PostalCode = postalCode,
                PostalCodes = db.PostalCode.OrderBy(p => p.Code)
            };

            return View(model);
        }

        // POST: PostalCodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PostalCode postalCode = db.PostalCode.Find(id);
            db.PostalCode.Remove(postalCode);
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
