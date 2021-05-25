using incident_reporting_web_application.Models.AuditTrail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace incident_reporting_web_application.Controllers
{
    public class AuditTrailController : Controller
    {
        // GET: AuditTrail
        public ActionResult Index()
        {
            List<AuditTrail> trails = new List<AuditTrail>();

            trails.Add(new AuditTrail(
                DateTime.Parse("05/20/2021 13:45"),
                "User login.",
                "john_v_dimailig",
                "Account"));

            trails.Add(new AuditTrail(
                DateTime.Parse("05/20/2021 16:30"),
                "User login.",
                "john_v_dimailig",
                "Account"));

            trails.Add(new AuditTrail(
                DateTime.Parse("01/5/2021 14:10"),
                "User \"lukas_d_martinez\" registered.",
                "martin_v_atienza",
                "Account"));

            trails.Add(new AuditTrail(
                DateTime.Parse("5/6/2021 14:10"),
                "User \"chris_mol_m_dela_cruz\" registered.",
                "john_v_dimailig",
                "Account"));

            trails.Add(new AuditTrail(
                DateTime.Parse("5/4/2021 08:50"),
                "Case #2021-05-AD1 Atienza v Dimailig recorded.",
                "martin_v_atienza",
                "Incident Report"));

            trails.Add(new AuditTrail(
                DateTime.Parse("5/4/2021 10:10"),
                "Hearing notice for Case #2021-05-AD1 Atienza v Dimailig recorded. Respondent are ATIENZA, Martin.",
                "martin_v_atienza",
                "Notice"));

            trails.Add(new AuditTrail(
                DateTime.Parse("5/4/2021 10:15"),
                "Summon notice for Case #2021-05-AD1 Atienza v Dimailig recorded. Witness are DIMAILIG, Mar.",
                "martin_v_atienza",
                "Notice"));

            trails.Add(new AuditTrail(
                DateTime.Parse("5/5/2021 12:30"),
                "Notified record of summon notice for Case #2021-05-AD1 Atienza v Dimailig.",
                "martin_v_atienza",
                "Notice"));

            trails.Add(new AuditTrail(
                DateTime.Parse("5/8/2021 09:33"),
                "Hearing status changed to CONCILIATION for case #2021-05-Z30.",
                "martin_v_atienza",
                "Hearing"));

            trails.Add(new AuditTrail(
                DateTime.Parse("5/10/2021 13:50"),
                "Hearing status changed to ARBITRATION for case #2021-05-A10.",
                "john_v_dimailig",
                "Hearing"));

            trails.Add(new AuditTrail(
                DateTime.Parse("5/9/2021 13:15"),
                "Created amicable settlement for case #2021-05-Z30.",
                "john_v_dimailig",
                "Hearing"));

            trails.Add(new AuditTrail(
                DateTime.Parse("5/12/2021 14:01"),
                "Created arbitration award for case #2021-05-A10.",
                "john_v_dimailig",
                "Hearing"));

            trails.Add(new AuditTrail(
                DateTime.Parse("5/15/2021 15:29"),
                "Court action filed from case #2021-05-3X1.",
                "martin_v_atienza",
                "Hearing"));

            return View(trails);
        }
    }
}