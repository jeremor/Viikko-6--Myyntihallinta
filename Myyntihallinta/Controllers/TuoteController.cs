using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Myyntihallinta.Models;

namespace Myyntihallinta.Controllers
{
    public class TuoteController : Controller
    {
        private MyyntiDBEntities db = new MyyntiDBEntities();

        // GET: Tuote
        public ActionResult Index()
        {
            return View(db.Tuotteet.ToList());
        }

        // GET: Tuote/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tuote tuote = db.Tuotteet.Find(id);
            if (tuote == null)
            {
                return HttpNotFound();
            }
            return View(tuote);
        }

        // GET: Tuote/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tuote/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tuote_id,nimi,tyyppi,tuoteryhmä,hinta")] Tuote tuote)
        {
            if (ModelState.IsValid)
            {
                db.Tuotteet.Add(tuote);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tuote);
        }

        // GET: Tuote/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tuote tuote = db.Tuotteet.Find(id);
            if (tuote == null)
            {
                return HttpNotFound();
            }
            return View(tuote);
        }

        // POST: Tuote/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tuote_id,nimi,tyyppi,tuoteryhmä,hinta")] Tuote tuote)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tuote).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tuote);
        }

        // GET: Tuote/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tuote tuote = db.Tuotteet.Find(id);
            if (tuote == null)
            {
                return HttpNotFound();
            }
            return View(tuote);
        }

        // POST: Tuote/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tuote tuote = db.Tuotteet.Find(id);
            db.Tuotteet.Remove(tuote);
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
