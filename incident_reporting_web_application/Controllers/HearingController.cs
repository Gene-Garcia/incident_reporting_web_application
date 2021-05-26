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
                "2021-28",
                "Jose Viceral vs. August Martin",
                new List<string>() { "VICERAL, Jose, Mari" },
                new List<string>() { "MARTIN, August, Neri", "LUO, Yuan, Ong" },
                new List<string>() { "LUCAS, Luke, Argon" },
                DateTime.Parse("05/25/2021"),
                false));

            hearings.Add(new ForHearing(
                "2021-29",
                "Grey Santiago vs. Bodhi Tapia",
                new List<string>() { "SANTIAGO, Grey, Asher" },
                new List<string>() { "TAPIA, Bodhi, Lopez", "SY, Eloise, Garcia" },
                new List<string>() ,
                DateTime.Parse("05/25/2021"),
                true));

            hearings.Add(new ForHearing(
                "2021-31",
                "Finn Dimailig vs. Jane Martes",
                new List<string>() { "DIMAILIG, Finn, Grace" },
                new List<string>() { "MARTES, Jane, Daisy"},
                new List<string>() { "DUJUA, Florence, Villa" },
                DateTime.Parse("05/25/2021"),
                true));

            hearings.Add(new ForHearing(
                "2021-033",
                "Amara Paor vs. Martin Javier",
                new List<string>() { "PAOR, Amara, Ava", "CONOL, Beck, Atienza" },
                new List<string>() { "JAVIER, Martin, Maverick", "HUDSON, Wanda, Ong", "CHOY, Martin, Ong" },
                new List<string>() { "REPRE, Yanna, Del Pilar", "MANALA, Eph, Talag" },
                DateTime.Parse("05/25/2021"),
                false));

            return View(hearings);
        }

        public ActionResult RecordHearing(string caseno, string hearingtype)
        {
            if (hearingtype == "") hearingtype = "MEDIATION";

            Hearing h = new Hearing(
                "2021-29",
                "Owen Velasquez vs. Oliver Cortez",
                hearingtype.ToUpper(),
                new List<string>(){ "VELASQUEZ, Owen, Joe", "VELASQUEZ, Oliver, Atienza" },
                new List<string>(){ "CORTEZ, Luca, Lou" },
                new List<string>(){ "MARIA, Ryker, Roxas" },
                DateTime.Parse("05/30/2021"),
                DateTime.Parse("5/25/2021"),
                DateTime.Parse("5/26/2021"));

            return View(h);
        }

        public ActionResult CreateArbitrationAgreement()
        {
            Hearing h = new Hearing(
                "2021-29",
                "Owen Velasquez vs. Oliver Cortez",
                "MEDIATION",
                new List<string>() { "VELASQUEZ, Owen, Joe", "VELASQUEZ, Oliver, Atienza" },
                new List<string>() { "CORTEZ, Luca, Lou" },
                new List<string>() { "MARIA, Ryker, Roxas" },
                DateTime.Parse("05/30/2021"),
                DateTime.Parse("5/25/2021"),
                DateTime.Parse("5/26/2021"));

            return View(h);
        }

        public ActionResult FileCourtAction()
        {
            CourtAction courtAction = new CourtAction(
                "2021-29",
                "Owen Velasquez vs. Oliver Cortez",
                new List<string>() { "VELASQUEZ, Owen, Joe", "VELASQUEZ, Oliver, Atienza" },
                new List<string>() { "CORTEZ, Luca, Lou" },
                new List<string>() { "MARIA, Ryker, Roxas" },
                DateTime.Parse("05/30/2021"),
                "MEDIATION");
            return View(courtAction);
        }
    }
}