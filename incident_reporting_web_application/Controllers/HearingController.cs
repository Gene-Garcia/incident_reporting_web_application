using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using incident_reporting_web_application.Models.Hearing;
using System.Web.Mvc;

namespace incident_reporting_web_application.Controllers
{
    public class HearingController : Controller
    {
        // GET: Hearing
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CasesForHearing(string hearingType)
        {
            List<ForHearing> hearings = new List<ForHearing>();

            ViewBag.HearingType = hearingType;

            hearings.Add(new ForHearing(
                "2021-05-1AX",
                "Viceral v Martin",
                new List<string>() { "VICERAL, Jose, Mari" },
                new List<string>() { "MARTIN, Neut, Neri", "LUO, Yuan, Ong" },
                new List<string>() { "LUCAS, Luke, Argon" },
                DateTime.Parse("05/25/2021")));

            hearings.Add(new ForHearing(
                "2021-05-1AX",
                "Viceral v Martin",
                new List<string>() { "VICERAL, Jose, Mari" },
                new List<string>() { "MARTIN, Neut, Neri", "LUO, Yuan, Ong" },
                new List<string>() { "LUCAS, Luke, Argon" },
                DateTime.Parse("05/25/2021")));

            hearings.Add(new ForHearing(
                "2021-05-1AX",
                "Viceral v Martin",
                new List<string>() { "VICERAL, Jose, Mari" },
                new List<string>() { "MARTIN, Neut, Neri", "LUO, Yuan, Ong" },
                new List<string>() { "LUCAS, Luke, Argon" },
                DateTime.Parse("05/25/2021")));

            hearings.Add(new ForHearing(
                "2021-05-1AX",
                "Viceral v Martin",
                new List<string>() { "VICERAL, Jose, Mari" },
                new List<string>() { "MARTIN, Neut, Neri", "LUO, Yuan, Ong" },
                new List<string>() { "LUCAS, Luke, Argon" },
                DateTime.Parse("05/25/2021")));

            return View(hearings);
        }
    }
}