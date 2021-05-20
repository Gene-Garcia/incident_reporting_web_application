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
        private string lorem1 = "Vivamus porttitor, est blandit fermentum fermentum, ex lorem imperdiet erat, sit amet efficitur tortor velit at elit. Fusce consectetur velit nibh, eget tincidunt augue tristique ac. Nullam aliquam fringilla eros ac consequat. Phasellus dictum cursus malesuada. Duis ac maximus felis, at molestie risus. Aenean interdum ante sit amet gravida dictum. Etiam sodales faucibus arcu, non tincidunt odio tempus quis. Suspendisse potenti. Quisque porttitor, libero eget luctus pellentesque, massa eros faucibus velit, at mollis est enim et risus. In ullamcorper laoreet ante nec finibus. Donec quis ligula vehicula, aliquet justo eu, tristique neque. Nam tristique urna id facilisis consectetur. Aliquam sodales tortor non maximus accumsan. In porta dapibus purus, accumsan cursus ante egestas nec.";
        private string lorem2 = "Nullam laoreet, felis sed gravida tempor, metus diam feugiat orci, ut porta enim leo eu enim. Nunc sed sapien fringilla odio hendrerit viverra non non libero. Proin vitae justo a risus finibus scelerisque gravida venenatis dui. Pellentesque in porta eros. Aliquam vel neque vitae neque efficitur gravida. Nunc id porta ante, nec lacinia nisl. Aliquam posuere lectus a nibh rhoncus, non bibendum nunc laoreet. Nullam consequat est nec nisl molestie, vel bibendum enim faucibus. Nam vestibulum urna id justo condimentum, at rhoncus felis suscipit. Maecenas ante mauris, luctus et velit et, rhoncus hendrerit arcu. In hac habitasse platea dictumst.";
        private string lorem3 = "Fusce eget nulla feugiat, iaculis nisl sed, aliquet magna. Vivamus quis imperdiet libero. Suspendisse potenti. Suspendisse eu augue ligula. Sed libero risus, laoreet at imperdiet eget, sollicitudin eu elit. Vivamus semper mi ut nisi sagittis, in convallis mi bibendum. Sed non consequat arcu, vitae pulvinar dui. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Praesent dapibus nunc et nisi gravida interdum. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nam pellentesque ex odio, eget porta dolor blandit sed. Vestibulum fermentum quam ante, non luctus massa mattis nec.";
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


        public ActionResult DisplayReportSummary(int? caseno)
        {
            return View(new IncidentReportSummary("2020-08-3C0", "Atienza v Dimailig",
                new List<string>() { "Mark Atienza", "Arch Gomez" },
                new List<string>() { "Lesley Dimailig", "Ray Cruz", "Martin Black" },
                lorem1,
                DateTime.Parse("08/19/2020"), "CONCILIATION",
                lorem3,
                DateTime.Parse("08/19/2020"),
                DateTime.Parse("08/15/2020"),
                DateTime.Parse("08/17/2020"),
                "john_dimailig"
                ));
        }
    }
}