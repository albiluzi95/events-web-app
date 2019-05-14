using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Events_app.Controllers
{
    public class VotersController : Controller
    {
        // GET: Voters
        public ActionResult Index()
        {
            return View();
        }
    }
}