using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ChuBikeMVC.Models;
using ChuBikeMVC.Models.Bike;
using ChuBikeMVC.Models.Bike.Parts;
using ChuBikeMVC.Models.Context.Bike;

namespace ChuBikeMVC.Controllers.Bike
{
    public class PartsController : Controller
    {
        private PartsDBContext db = new PartsDBContext();

        // GET: Parts
        public ActionResult Index()
        {
            var parts = db.Parts.Include(p => p.Manufacturer).Include(p => p.PartType);
            return View(parts.ToList());
        }

        // GET: Parts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Part part = db.Parts.Find(id);
            if (part == null)
            {
                return HttpNotFound();
            }
            return View(part);
        }

        // GET: Parts/Create
        public ActionResult Create()
        {
            ViewBag.ManufacturerId = new SelectList(db.Manufacturers, "ManufacturerId", "Name");
            ViewBag.PartTypeId = new SelectList(db.PartTypes, "PartTypeId", "Name");
            return View();
        }

        // POST: Parts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection collection)
        {
            Stem obj = new Stem();
            if (collection["PartTypeId"] == "2")
                 obj = new Stem();

            obj.Name = collection["Name"];
            obj.Weight = double.Parse(collection["Weight"]);
            obj.AdditionalInformation = collection["AdditionalInformation"];
            obj.ManufacturerId = int.Parse(collection["ManufacturerId"]);
            obj.PartTypeId = int.Parse(collection["PartTypeId"]);

            db.Stems.Add(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
            return View(obj);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "PartId,Name,Weight,ManufacturerId,PartTypeId")] Part part)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Parts.Add(part);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.ManufacturerId = new SelectList(db.Manufacturers, "Id", "Name", part.ManufacturerId);
        //    ViewBag.PartTypeId = new SelectList(db.PartTypes, "Id", "Name", part.PartTypeId);
        //    return View(part);
        //}


        public ActionResult StemToPv(int partTypeId)
        {
            //IEnumerable<PartType> partTypes = new List<PartType>(db.PartTypes.Select(p => p));
            //var selectedPartTypeId = (from c in partTypes where c.Name == partTypeName select c.PartTypeId).FirstOrDefault();

            //IEnumerable<Stem> allStems = new List<Stem>(db.Stems.Select(s => s));
            //var stemInPartTypes = allStems.Where(s => s.PartTypeId == selectedPartTypeId).ToList();

            //return PartialView("PartialViews/StemPv", allStems);
            return PartialView("PartialViews/StemPv");
        }
        // GET: Parts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Part part = db.Parts.Find(id);
            if (part == null)
            {
                return HttpNotFound();
            }
            ViewBag.ManufacturerId = new SelectList(db.Manufacturers, "ManufacturerId", "Name", part.ManufacturerId);
            ViewBag.PartTypeId = new SelectList(db.PartTypes, "PartTypeId", "Name", part.PartTypeId);
            return View(part);
        }

        // POST: Parts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PartId,Name,Weight,AdditionalInformation,ManufacturerId,PartTypeId")] Part part)
        {
            if (ModelState.IsValid)
            {
                db.Entry(part).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ManufacturerId = new SelectList(db.Manufacturers, "ManufacturerId", "Name", part.ManufacturerId);
            ViewBag.PartTypeId = new SelectList(db.PartTypes, "PartTypeId", "Name", part.PartTypeId);
            return View(part);
        }

        // GET: Parts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Part part = db.Parts.Find(id);
            if (part == null)
            {
                return HttpNotFound();
            }
            return View(part);
        }

        // POST: Parts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Part part = db.Parts.Find(id);
            db.Parts.Remove(part);
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
