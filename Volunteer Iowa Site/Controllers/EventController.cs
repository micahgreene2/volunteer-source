﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Volunteer_Iowa_Site.Models;

namespace Volunteer_Iowa_Site.Controllers
{
    public class EventController : Controller
    {
        private LogEntitiesContainer db = new LogEntitiesContainer();

        //
        // GET: /Event/

        public ActionResult Index()
        {
            var eventss = db.Events.Include(e => e.Address);
            return View(eventss.ToList());
        }

        //
        // GET: /Event/Details/5

        public ActionResult Details(int id = 0)
        {
            Event events = db.Events.Find(id);
            if (events == null)
            {
                return HttpNotFound();
            }
            return View(events);
        }

        //
        // GET: /Event/Create

        public ActionResult Create()
        {
            ViewBag.addressID = new SelectList(db.Addresses, "Id", "lineOne");
            return View();
        }

        //
        // POST: /Event/Create

        [HttpPost]
        public ActionResult Create(Event events)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(events);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.addressID = new SelectList(db.Addresses, "Id", "lineOne", events.addressID);
            return View(events);
        }

        //
        // GET: /Event/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Event events = db.Events.Find(id);
            if (events == null)
            {
                return HttpNotFound();
            }
            ViewBag.addressID = new SelectList(db.Addresses, "Id", "lineOne", events.addressID);
            return View(events);
        }

        //
        // POST: /Event/Edit/5

        [HttpPost]
        public ActionResult Edit(Event events)
        {
            if (ModelState.IsValid)
            {
                db.Entry(events).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.addressID = new SelectList(db.Addresses, "Id", "lineOne", events.addressID);
            return View(events);
        }

        //
        // GET: /Event/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Event events = db.Events.Find(id);
            if (events == null)
            {
                return HttpNotFound();
            }
            return View(events);
        }

        //
        // POST: /Event/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Event events = db.Events.Find(id);
            db.Events.Remove(events);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}