using incident_reporting_web_application.Models.NoticeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace incident_reporting_web_application.Controllers
{
    public class NoticeController : Controller
    {
        // GET: Notice
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CasesForNotices() //cases that have just been created but without any notices of hearing and summon
        {
            List<ForNotice> data = new List<ForNotice>();

            data.Add(new ForNotice("2021-08", "Olive Viceral vs. Eli Mariano", DateTime.Parse("01/15/2021"), "marlcruz", DateTime.Parse("05/5/2021"), new List<string>() { "Summon" }));
            data.Add(new ForNotice("2021-09", "Della Ocampo vs. Scarlet Rivas", DateTime.Parse("01/17/2021"), "johndimailig", DateTime.Parse("05/6/2021"), new List<string>()));
            data.Add(new ForNotice("2021-10", "Ephraim Gomez vs. Elijah Hilario", DateTime.Parse("02/07/2021"), "marlcruz", DateTime.Parse("05/7/2021"), new List<string>() { "Hearing" }));
            data.Add(new ForNotice("2021-11", "Harold Reyes vs. Emma Pineda", DateTime.Parse("03/20/2021"), "marlcruz", null, new List<string>() { "Hearing" }));

            return View(data);
        }

        [HttpGet]
        public ActionResult ScheduleSelection(int? caseno)
        {
            List<(DateTime, string)> schedules = new List<(DateTime, string)>();

            schedules.Add( (DateTime.Parse("05/15/2021"), "Jasper Mariano vs. Julian Del Pilar") );
            schedules.Add((DateTime.Parse("05/16/2021"), "Kai Lopez vs. Lucas Gurion"));
            schedules.Add((DateTime.Parse("05/18/2021"), "Harry Santiago vs. Hazel Recio"));
            schedules.Add((DateTime.Parse("05/20/2021"), "Max Padilla vs. Luke Baretto"));

            return View(new ScheduleSelection(
                "2021-21", "Mark Atienza vs. Lesley Dimailig", 
                new List<string>() { "Mark Atienza", "Arch Gomez" },
                new List<string>() { "Lesley Dimailig", "Ray Cruz", "Martin Black" },
                schedules));
        }

        [HttpGet]
        public ActionResult ManageCaseNotice(int? caseno)
        {
            return View();
        }

        [HttpGet]
        public ActionResult DisplayNotices() //group by case, card design. each card for each case with numerous notices. per card, group by hearing type to display its notices. If all notice status is notifed, display in the HEARING PROCESS MODULE
        {

            List<IncidentReport> reports = new List<IncidentReport>();

            reports.Add(new IncidentReport(
                "2021-16",
                "Jude Hilario vs. Alex Viceral",
                "MEDIATION",
                DateTime.Parse("04/15/2021"),
                new List<ReportNotice>() { 
                    new ReportNotice("Hearing Notice", new List<string>() { "HILARIO, Jude, Martin", "HILARIO, Judemar, Martin" }, "TO NOTIFY"),
                    new ReportNotice("Summon Notice", new List<string>() { "VICERAL, Alex, Jun" }, "TO NOTIFY"),
                    new ReportNotice("Subpoena Notice", new List<string>() { "GOMEZ, Ezra, Mil" }, "TO NOTIFY")
                }));

            reports.Add(new IncidentReport(
                "2021-18",
                "Nico Perez vs. Annie Padilla",
                "MEDIATION",
                DateTime.Parse("04/16/2021"),
                new List<ReportNotice>() {
                    new ReportNotice("Hearing Notice", new List<string>() { "PEREZ, Nico, Martin" }, "NOTIFIED", DateTime.Parse("04/14/2021")),
                    new ReportNotice("Summon Notice", new List<string>() { "PADILLA, Annie, Jean", "DIMAILIG, Journey, Castro" }, "TO NOTIFY")
                }));

            reports.Add(new IncidentReport(
                "2021-19",
                "Max Cortez vs. Joi Atienza",
                "ARBITRATION",
                DateTime.Parse("04/17/2021"),
                new List<ReportNotice>() {
                    new ReportNotice("Hearing Notice", new List<string>() { "CORTEZ, Max, Pilar" }, "TO NOTIFY"),
                    new ReportNotice("Summon Notice", new List<string>() { "ATIENZA, Joi, Marin", "BING, Arch, Monti" }, "TO NOTIFY"),
                    new ReportNotice("Subpoena Notice", new List<string>() { "GALVEZ, Leo, Coring", "MARIA, Vhong, Viceral" }, "NOTIFIED", DateTime.Parse("04/16/2021"))
                }));

            reports.Add(new IncidentReport(
                "2021-22",
                "Jude Hilario vs. Alex Viceral",
                "CONCILIATION",
                DateTime.Parse("04/20/2021"),
                new List<ReportNotice>() {
                    new ReportNotice("Hearing Notice", new List<string>() { "HILARIO, Jude, Martin", }, "TO NOTIFY"),
                    new ReportNotice("Summon Notice", new List<string>() { "VICERAL, Alex, Jun", }, "NOTIFIED", DateTime.Parse("04/18/2021")),
                    new ReportNotice("Subpoena Notice", new List<string>() { "LOPEZ, Colt, Mil", }, "TO NOTIFY")
                }));

            return View(reports);
        }

        [HttpGet]
        public ActionResult NoticeDetails(int? noticeId)
        {
            return View();
        }
    }
}