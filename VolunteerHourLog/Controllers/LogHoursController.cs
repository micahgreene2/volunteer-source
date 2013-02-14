using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VolunteerHourLog.Models;
using VolunteerHourLog.ViewModels;

namespace VolunteerHourLog.Controllers
{ 
    public class LogHoursController : Controller
    {
        private VolunteerEventContext db = new VolunteerEventContext();

        //
        // GET: /Default1/

        public ViewResult Index()
        {
            Database.SetInitializer<VolunteerEventContext>(new EventTopicsDBInitializer());
            return View(db.VolunteerEvents.ToList());
        }

        //
        // GET: /Default1/Details/5

        public ViewResult Details(int id)
        {
            VolunteerEvent volunteerevent = db.VolunteerEvents.Find(id);
            return View(volunteerevent);
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            ViewBag.VolunteerTopicId = new SelectList(db.VolunteerTopics, "VolunteerTopicID", "VolunteerTopicName");
            return View();
        } 

        //
        // POST: /Default1/Create

        [HttpPost]
        public ActionResult Create(VolunteerViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var thing = ViewBag.VolunteerTopicId;
                db.VolunteerEvents.Add(viewModel.VolunteerEvent);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(viewModel);
        }
        
        //
        // GET: /Default1/Edit/5
 
        public ActionResult Edit(int id)
        {
            VolunteerEvent volunteerevent = db.VolunteerEvents.Find(id);
            return View(volunteerevent);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        public ActionResult Edit(VolunteerEvent volunteerevent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(volunteerevent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(volunteerevent);
        }

        //
        // GET: /Default1/Delete/5
 
        public ActionResult Delete(int id)
        {
            VolunteerEvent volunteerevent = db.VolunteerEvents.Find(id);
            return View(volunteerevent);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            VolunteerEvent volunteerevent = db.VolunteerEvents.Find(id);
            db.VolunteerEvents.Remove(volunteerevent);
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