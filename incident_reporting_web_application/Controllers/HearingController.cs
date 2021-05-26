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
                DateTime.Parse("05/25/2021"),
                false));

            hearings.Add(new ForHearing(
                "2021-05-1AX",
                "Viceral v Martin",
                new List<string>() { "VICERAL, Jose, Mari" },
                new List<string>() { "MARTIN, Neut, Neri", "LUO, Yuan, Ong" },
                new List<string>() { "LUCAS, Luke, Argon" },
                DateTime.Parse("05/25/2021"),
                true));

            hearings.Add(new ForHearing(
                "2021-05-1AX",
                "Viceral v Martin",
                new List<string>() { "VICERAL, Jose, Mari" },
                new List<string>() { "MARTIN, Neut, Neri", "LUO, Yuan, Ong" },
                new List<string>() { "LUCAS, Luke, Argon" },
                DateTime.Parse("05/25/2021"),
                true));

            hearings.Add(new ForHearing(
                "2021-05-1AX",
                "Viceral v Martin",
                new List<string>() { "VICERAL, Jose, Mari" },
                new List<string>() { "MARTIN, Neut, Neri", "LUO, Yuan, Ong" },
                new List<string>() { "LUCAS, Luke, Argon" },
                DateTime.Parse("05/25/2021"),
                false));

            return View(hearings);
        }

        public ActionResult RecordHearing(string caseno, string hearingtype)
        {
            if (hearingtype == "") hearingtype = "MEDIATION";

            Hearing h = new Hearing(
                "2021-05-B12",
                "Velasquez v Cortez",
                hearingtype.ToUpper(),
                new List<string>(){ "VELASQUEZ, Martin, Joe", "VELASQUEZ, Cha, Atienza" },
                new List<string>(){ "CORTEZ, Luca, Lou" },
                new List<string>(){ "MARIA, Jeremy, Roxas" },
                DateTime.Parse("05/30/2021"),
                DateTime.Parse("5/25/2021"),
                DateTime.Parse("5/26/2021"));

            return View(h);
        }

        public ActionResult CreateArbitrationAgreement()
        {
            Hearing h = new Hearing(
                "2021-10",
                "Velasquez v Cortez",
                "MEDIATION",
                new List<string>() { "VELASQUEZ, Martin, Joe", "VELASQUEZ, Cha, Atienza" },
                new List<string>() { "CORTEZ, Luca, Lou" },
                new List<string>() { "MARIA, Jeremy, Roxas" },
                DateTime.Parse("05/30/2021"),
                DateTime.Parse("5/25/2021"),
                DateTime.Parse("5/26/2021"));

            return View(h);
        }

        public ActionResult FileCourtAction()
        {
            CourtAction courtAction = new CourtAction(
                "2021-05-B12",
                "Velasquez v Cortez",
                new List<string>() { "VELASQUEZ, Martin, Joe", "VELASQUEZ, Cha, Atienza" },
                new List<string>() { "CORTEZ, Luca, Lou" },
                new List<string>() { "MARIA, Jeremy, Roxas" },
                DateTime.Parse("05/30/2021"),
                "MEDIATION");
            return View(courtAction);
        }
    }
}