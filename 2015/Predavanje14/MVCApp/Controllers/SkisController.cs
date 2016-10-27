using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class SkisController : Controller
    {
        private SkiEntities db = new SkiEntities();

        // GET: Skis
        public ActionResult Index()
        {
            var ski = db.Ski.Include(s => s.Drzava);
            return View(ski.ToList());
        }

        // GET: Skis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ski ski = db.Ski.Find(id);
            if (ski == null)
            {
                return HttpNotFound();
            }
            return View(ski);
        }

        // GET: Skis/Create
        public ActionResult Create()
        {
            ViewBag.drzavaId = new SelectList(db.Drzava, "id", "naziv");
            return View();
        }

        // POST: Skis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,naziv,drzavaId")] Ski ski)
        {
            if (ModelState.IsValid)
            {
                db.Ski.Add(ski);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.drzavaId = new SelectList(db.Drzava, "id", "naziv", ski.drzavaId);
            return View(ski);
        }

        // GET: Skis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ski ski = db.Ski.Find(id);
            if (ski == null)
            {
                return HttpNotFound();
            }
            ViewBag.drzavaId = new SelectList(db.Drzava, "id", "naziv", ski.drzavaId);
            return View(ski);
        }

        // POST: Skis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,naziv,drzavaId")] Ski ski)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ski).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.drzavaId = new SelectList(db.Drzava, "id", "naziv", ski.drzavaId);
            return View(ski);
        }

        // GET: Skis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ski ski = db.Ski.Find(id);
            if (ski == null)
            {
                return HttpNotFound();
            }
            return View(ski);
        }

        // POST: Skis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ski ski = db.Ski.Find(id);
            db.Ski.Remove(ski);
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
