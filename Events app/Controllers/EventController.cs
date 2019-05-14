using Events_app.Models;
using Events_app.Models.Repository;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Events_app.Controllers
{
    public class EventController : Controller
    {
        public MongoDatabase mongoDatabase;
        private EventCollection _events = new EventCollection();

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("event")]
        public List<Event> GetEvents()
        {
            return _events.GetEvents();
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("event/{id:int}")]
        public Event GetEvent(int id)
        {
            return _events.GetEvent(id);
        }
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("event")]
        public bool AddEvent(Event @event)
        {
            var response = _events.addEvent(@event);
            return response;
        }
    }
}