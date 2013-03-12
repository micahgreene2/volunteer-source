using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Volunteer_Iowa_Site.Models;

namespace Volunteer_Iowa_Site.Controllers
{
    public class LogController : Controller
    {
        //
        // GET: /Log/
        //change by anthony version 2

        public ActionResult Index(  )
        {
            var db = new LogDataContext();
            var log = db.Logs.ToArray();
            //save to database
            //var db = new LogDataContext();
            //db.Logs.Add(//class);
            //db.SaveChanges();
            return View(log);
        }
        public ActionResult Create()
        {

            return View();
        }


    }
    /* my own text */
}
