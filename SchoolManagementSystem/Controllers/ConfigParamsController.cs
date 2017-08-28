using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SchoolManagementSystem.Models.Initialisation;
using SchoolManagementSystemModel.Academics;
using SchoolManagementSystem.Models.ViewModels;

namespace SchoolManagementSystem.Controllers
{
    public class ConfigParamsController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: ConfigParams
        public ActionResult Index(int? id)
        {
            if (id is null)
            {
                id = 0;
            }
            ConfigParamsIndexEditViewModel model = new ConfigParamsIndexEditViewModel()
            {
                ConfigParameters = db.ConfigParams.ToList(),
                ConfigParameter = new ConfigParams()
            };
            return View(model);
        }

        // GET: ConfigParams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConfigParams configParams = db.ConfigParams.Find(id);
            if (configParams == null)
            {
                return HttpNotFound();
            }
            return View(configParams);
        }

        // GET: ConfigParams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConfigParams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ParamType,ParamCategory,ParamName,Value,CreateBy,CreateDate,ModifyBy,ModifyDate")] ConfigParams configParams)
        {
            if (ModelState.IsValid)
            {
                db.ConfigParams.Add(configParams);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(configParams);
        }

        // GET: ConfigParams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConfigParamsIndexEditViewModel model = new ConfigParamsIndexEditViewModel()
            {
                ConfigParameters = db.ConfigParams.ToList(),
                ConfigParameter = db.ConfigParams.Find(id)
            };
            return View(model);
        }

        // POST: ConfigParams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ConfigParamsIndexEditViewModel configParams)
        {
            if (ModelState.IsValid)
            {
                db.Entry(configParams.ConfigParameter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(configParams);
        }

        // GET: ConfigParams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConfigParams configParams = db.ConfigParams.Find(id);
            if (configParams == null)
            {
                return HttpNotFound();
            }
            return View(configParams);
        }

        // POST: ConfigParams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConfigParams configParams = db.ConfigParams.Find(id);
            db.ConfigParams.Remove(configParams);
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
