using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NTLA1721050613.Models;

namespace NTLA1721050613.Controllers
{
    public class LucturesController : Controller
    {
        private NTLA1721050613DBContext db = new NTLA1721050613DBContext();
        StringProcess auto = new StringProcess();

        // GET: Luctures
        public ActionResult Index()
        {
            return View(db.Luctures.ToList());
        }

        // GET: Luctures/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lucture lucture = db.Luctures.Find(id);
            if (lucture == null)
            {
                return HttpNotFound();
            }
            return View(lucture);
        }

        // GET: Luctures/Create
        public ActionResult Create()
        {
            if (db.Persons.OrderByDescending(m => m.perSonID).Count() == 0)
            {
                var newID = "LCT001";
                ViewBag.newid = newID;
            }
            else
            {
                var PsID = db.Persons.OrderByDescending(m => m.perSonID).FirstOrDefault().perSonID;
                var newID = auto.GenKey("LCT", PsID);
                ViewBag.newid = newID;
            }
            return View();
        }

        // POST: Luctures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonID,PersonName,Faculty,Department")] Lucture lucture)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(lucture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lucture);
        }

        // GET: Luctures/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lucture lucture = db.Luctures.Find(id);
            if (lucture == null)
            {
                return HttpNotFound();
            }
            return View(lucture);
        }

        // POST: Luctures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonID,PersonName,Faculty,Department")] Lucture lucture)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lucture).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lucture);
        }

        // GET: Luctures/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lucture lucture = db.Luctures.Find(id);
            if (lucture == null)
            {
                return HttpNotFound();
            }
            return View(lucture);
        }

        // POST: Luctures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Lucture lucture = db.Luctures.Find(id);
            db.People.Remove(lucture);
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
