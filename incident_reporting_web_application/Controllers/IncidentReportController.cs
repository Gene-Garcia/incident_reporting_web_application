using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace incident_reporting_web_application.Controllers
{
    public class IncidentReportController : Controller
    {
        // GET: IncidentReport
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateReport()
        {
            return View();
        }
    }
}