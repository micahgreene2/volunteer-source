using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Volunteer_Iowa_Site.Models;

namespace Volunteer_Iowa_Site.Controllers
{
    [Authorize]
    public class LogController : Controller
    {
        
        private LogEntitiesContainer db = new LogEntitiesContainer();
     // private Log db = new Log();
        //
        // GET: /Log/

        public ActionResult Index()
        {
            
            ViewData["userName"] = User.Identity.Name;
           // ViewData["events"] = dbc.Events.ToArray();
            
            return View(db.Logs.ToList());
        }

        //
        // GET: /Log/Details/5

        public ActionResult Details(int id = 0)
        {
            Log log = db.Logs.Find(id);
            if (log == null)
            {
                return HttpNotFound();
            }
            return View(log);
        }

        //
        // GET: /Log/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Log/Create

        [HttpPost]
        public ActionResult Create(Log log)
        {
            if (ModelState.IsValid)
            {
                db.Logs.Add(log);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(log);
        }

        //
        // GET: /Log/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Log log = db.Logs.Find(id);
            if (log == null)
            {
                return HttpNotFound();
            }
            return View(log);
        }

        //
        // POST: /Log/Edit/5

        [HttpPost]
        public ActionResult Edit(Log log)
        {
            if (ModelState.IsValid)
            {
                db.Entry(log).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(log);
        }

        //
        // GET: /Log/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Log log = db.Logs.Find(id);
            if (log == null)
            {
                return HttpNotFound();
            }
            return View(log);
        }

        //
        // POST: /Log/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Log log = db.Logs.Find(id);
            db.Logs.Remove(log);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        public ActionResult SearchIndex( string searchString)
        {
           // EventDataContext dbc = new EventDataContext();
               //     LogEntitiesContainer dbc = new LogEntitiesContainer();
            /*
            var log = from Name in dbc.Events
                      select Name;
            if (!String.IsNullOrEmpty(searchString))
            {
                log = Logs.Where( s => s.Name.Contains(searchString));
            }
            return View(log);*/
            return View();
        }
    }

}