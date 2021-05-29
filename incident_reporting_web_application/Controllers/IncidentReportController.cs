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
            #region-kp-cases
            string[] kpCases =
            {
                "Article No. 154 Unlawful use of means of publication and unlawful utterances.",
                "Article No. 155 Alarms and scandals.",
                "Article No. 175 Using false certificates.",
                "Article No. 178 Using fictitious names and concealing true names.",
                "Article No. 179 Illegal use of uniforms and insignias.",
                "Article No. 252 Physical injuries inflicted in a tumultuous affray.",
                "Article No. 253 Giving assistance to consummated suicide.",
                "Article No. 260 Responsibility of participants in a duel if only physical injuries are inflicted or no physical injuries have been inflicted.",
                "Article No. 265 Less serious physical injuries.",
                "Article No. 266 Slight physical injuries and maltreatment.",
                "Article No. 269 Unlawful arrest.",
                "Article No. 271 Inducing a minor to abandon his/ her home.",
                "Article No. 275 Abandonment of a person in danger and abandonment of one’s own victim.",
                "Article No. 276 Abandoning a minor(A child under seven[7] years old).",
                "Article No. 277 Abandonment of a minor by persons entrusted with his / her custody; indifference of parents.",
                "Article No. 280 Qualified trespass to dwelling(Without the use of violence and intimidation).",
                "Article No. 281 Other forms of trespass.",
                "Article No. 283 Light threats.",
                "Article No. 285 Other light threats.",
                "Article No. 286 Grave coercion.",
                "Article No. 287 Light coercion.",
                "Article No. 288 Other similar coercions(Compulsory purchase of merchandise and payment of wages by means of tokens).",
                "Article No. 289 Formation, maintenance, and prohibition of combination of capital or labor through violence or threats.",
                "Article No. 290 Discovering secrets through seizure and correspondence.",
                "Article No. 291 Revealing secrets with abuse of authority.",
                "Article No. 309 Theft(If the value of the property stolen does not exceed P50.00).",
                "Article No. 310 Qualified Theft(If the amount does not exceed P500).",
                "Article No. 312 Occupation of real property or usurpation of real rights in property.",
                "Article No. 313 Altering boundaries or landmarks.",
                "Article No. 315 Swindling or estafa(If the amount does not exceed P200.00).",
                "Article No. 316 Other forms of swindling.",
                "Article No. 317 Swindling a minor.",
                "Article No. 318 Other deceits.",
                "Article No. 319 Removal, sale, or pledge of mortgaged property.",
                "Article No. 328 Special cases of malicious mischief(If the value of the damaged property does not exceed P1, 000.00).",
                "Article No. 329 Other mischiefs(If the value of the damaged property does not exceed P1,000.00).",
                "Article No. 338 Simple seduction.",
                "Article No. 339 Acts of lasciviousness with the consent of the offended party.",
                "Article No. 356 Threating to publish and offer to prevent such publication for compensation.",
                "Article No. 357 Prohibiting publication of acts referred to in the course of official proceedings.",
                "Article No. 363 Incriminating innocent persons.",
                "Article No. 364 Intriguing against honor.",
                "BP 22 Issuing checks without sufficient funds.",
                "PD 1612 Fencing of stolen properties if the property involved is not more than P50.00."
            };
            #endregion
            ViewBag.KPCases = new List<string>(kpCases);

            return View();
        }

        [HttpGet]
        public ActionResult DisplayOngoingIncidentReports() // Ongoing
        {
            //Dummy data
            List<IncidentReportList> report = new List<IncidentReportList>();

            report.Add(new IncidentReportList(
                "2020-05", 
                "Atienza v Dimailig", 
                "Lorem ipsum", 
                "Lorem ipsum", 
                DateTime.Parse("08/15/2020"), 
                "john_dimailig", 
                DateTime.Parse("08/17/2020"), 
                "CONCILIATION"));

            report.Add(new IncidentReportList(
                "2019-06", 
                "Lopez v Velasquez", 
                "Lorem ipsum", "" +
                "Lorem ipsum", 
                DateTime.Parse("02/02/2019"), 
                "john_dimailig", 
                DateTime.Parse("02/05/2019"), 
                "N/A"));

            report.Add(new IncidentReportList(
                "2019-07", 
                "Didal v Dela Cruz", 
                "Lorem ipsum", 
                "Lorem ipsum", 
                DateTime.Parse("02/27/2019"), 
                "john_dimailig", 
                DateTime.Parse("02/28/2019"), 
                "MEDIATION"));

            return View(report);
        }

        //in x-nav or horizontal
        public ActionResult SettledIncidentReports() 
        {
            List<SettledReport> reports = new List<SettledReport>();

            reports.Add(new SettledReport(
                "2021-01",
                "Nardin Nelson vs. Romel Zamora",
                "Article 21",
                "MEDIATION",
                DateTime.Parse("01/05/2021"),
                DateTime.Parse("01/07/2021"),
                lorem1,
                "COMPLIANCE",
                lorem2));

            reports.Add(new SettledReport(
                "2021-02",
                "Bayani Diaz vs. Jejomar Pangilinan",
                "Article 35",
                "ARBITRATION",
                DateTime.Parse("01/06/2021"),
                DateTime.Parse("01/07/2021"),
                lorem2,
                "NON-COMPLIANCE",
                lorem3));

            reports.Add(new SettledReport(
                "2021-03",
                "Melchor Cook vs. Gani Morgan",
                "Article 45",
                "CONCILIATION",
                DateTime.Parse("01/08/2021"),
                DateTime.Parse("01/09/2021"),
                lorem3,
                "COMPLIANCE",
                lorem2));

            reports.Add(new SettledReport(
                "2021-04",
                "Narding Edwards vs. Ramil Mendoza",
                "Article 1",
                "CONCILIATION",
                DateTime.Parse("01/10/2021"),
                DateTime.Parse("01/11/2021"),
                lorem1,
                "COMPLIANCE",
                lorem1));

            return View(reports);
        }

        public ActionResult DisplayReportSummary(int? caseno)
        {
            return View(new IncidentReportSummary("2020-08", "Mark Atienza vs Lesley Dimailig",
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