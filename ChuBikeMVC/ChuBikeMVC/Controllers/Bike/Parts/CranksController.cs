using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ChuBikeMVC.Models.Context.Bike;
using ChuBikeMVC.Models.Parts;

namespace ChuBikeMVC.Controllers.Bike.Parts
{
    public class CranksController : Controller
    {
        private PartsDBContext db = new PartsDBContext();

        // GET: Cranks
        public ActionResult Index()
        {
            var cranks = db.Cranks.Include(c => c.Part);
            return View(cranks.ToList());
        }

        // GET: Cranks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crank crank = db.Cranks.Find(id);
            if (crank == null)
            {
                return HttpNotFound();
            }
            return View(crank);
        }

        // GET: Cranks/Create
        public ActionResult Create()
        {
            ViewBag.PartId = new SelectList(db.Parts, "PartId", "Name");
            return View();
        }

        // POST: Cranks/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CrankId,Width,Diameter,PartId")] Crank crank)
        {
            if (ModelState.IsValid)
            {
                db.Cranks.Add(crank);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PartId = new SelectList(db.Parts, "PartId", "Name", crank.PartId);
            return View(crank);
        }

        // GET: Cranks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crank crank = db.Cranks.Find(id);
            if (crank == null)
            {
                return HttpNotFound();
            }
            ViewBag.PartId = new SelectList(db.Parts, "PartId", "Name", crank.PartId);
            return View(crank);
        }

        // POST: Cranks/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CrankId,Width,Diameter,PartId")] Crank crank)
        {
            if (ModelState.IsValid)
            {
                db.Entry(crank).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PartId = new SelectList(db.Parts, "PartId", "Name", crank.PartId);
            return View(crank);
        }

        // GET: Cranks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crank crank = db.Cranks.Find(id);
            if (crank == null)
            {
                return HttpNotFound();
            }
            return View(crank);
        }

        // POST: Cranks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Crank crank = db.Cranks.Find(id);
            db.Cranks.Remove(crank);
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
