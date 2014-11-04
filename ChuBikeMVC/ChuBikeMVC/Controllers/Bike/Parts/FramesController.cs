using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ChuBikeMVC.Models.Context.Bike.Parts;
using ChuBikeMVC.Models.Parts;

namespace ChuBikeMVC.Controllers.Bike.Parts
{
    public class FramesController : Controller
    {
        private FramesDBContext db = new FramesDBContext();

        // GET: Frames
        public ActionResult Index()
        {
            var frames = db.Frames.Include(f => f.Part);
            return View(frames.ToList());
        }

        // GET: Frames/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Frame frame = db.Frames.Find(id);
            if (frame == null)
            {
                return HttpNotFound();
            }
            return View(frame);
        }

        // GET: Frames/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.Parts, "Id", "Name");
            return View();
        }

        // POST: Frames/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Lenght")] Frame frame)
        {
            if (ModelState.IsValid)
            {
                db.Frames.Add(frame);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(db.Parts, "Id", "Name", frame.Id);
            return View(frame);
        }

        // GET: Frames/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Frame frame = db.Frames.Find(id);
            if (frame == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.Parts, "Id", "Name", frame.Id);
            return View(frame);
        }

        // POST: Frames/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Lenght")] Frame frame)
        {
            if (ModelState.IsValid)
            {
                db.Entry(frame).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.Parts, "Id", "Name", frame.Id);
            return View(frame);
        }

        // GET: Frames/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Frame frame = db.Frames.Find(id);
            if (frame == null)
            {
                return HttpNotFound();
            }
            return View(frame);
        }

        // POST: Frames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Frame frame = db.Frames.Find(id);
            db.Frames.Remove(frame);
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
