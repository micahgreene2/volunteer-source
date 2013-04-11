using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Volunteer_Iowa_Site.Models;

namespace Volunteer_Iowa_Site.API
{
    public class EventsController : ApiController
    {
        //private EventDataContext db = new EventDataContext();
        private LogEntitiesContainer db = new LogEntitiesContainer();
        public EventsController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET api/Events
        public IEnumerable<Event> GetEvents()
        {
            return db.Events.AsEnumerable();
        }

        // GET api/Events/5
        public Event GetEvent(int id)
        {
            Event ev = db.Events.Find(id);
            if (ev == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return ev;
        }

        // PUT api/Events/5
        public HttpResponseMessage PutEvent(int id, Event ev)
        {
            if (ModelState.IsValid && id == ev.eventID)
            {
                db.Entry(ev).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // POST api/Events
        public HttpResponseMessage PostEvent(Event ev)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(ev);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, ev);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = ev.eventID }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Events/5
        public HttpResponseMessage DeleteEvent(int id)
        {
            Event ev = db.Events.Find(id);
            if (ev == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Events.Remove(ev);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, ev);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}