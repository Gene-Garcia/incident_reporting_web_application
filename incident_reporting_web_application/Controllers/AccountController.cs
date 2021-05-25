using incident_reporting_web_application.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace incident_reporting_web_application.Controllers
{
    public class AccountController : Controller
    {
        
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult MyAccount()
        {
            AccountInfo acc = new AccountInfo(
                "Martin",
                "Villa",
                "Atienza",
                "martin_v_atienza",
                "Lupon",
                "Barangay Secretary");

            return View(acc);
        }
    }
}