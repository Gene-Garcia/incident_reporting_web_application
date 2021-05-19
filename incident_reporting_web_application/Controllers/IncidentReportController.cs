using incident_reporting_web_application.Models.IncidentReportView;
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

        [HttpGet]
        public ActionResult CreateReport()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DisplayIncidentReports()
        {
            //Dummy data
            List<IncidentReportList> report = new List<IncidentReportList>();

            report.Add(
                new IncidentReportList("2020-08-3C0", "Atienza v Dimailig", "Lorem ipsum", "Lorem ipsum", DateTime.Parse("08/15/2020"), "john_dimailig", DateTime.Parse("08/17/2020"), "CONCILIATION"));

            report.Add(
                new IncidentReportList("2019-02-1A1", "Lopez v Velasquez", "Lorem ipsum", "Lorem ipsum", DateTime.Parse("02/02/2019"), "john_dimailig", DateTime.Parse("02/05/2019"), "N/A"));
            report.Add(
                new IncidentReportList("2019-02-1D9", "Didal v Dela Cruz", "Lorem ipsum", "Lorem ipsum", DateTime.Parse("02/27/2019"), "john_dimailig", DateTime.Parse("02/28/2019"), "MEDIATION"));

            return View(report);
        }
    }
}