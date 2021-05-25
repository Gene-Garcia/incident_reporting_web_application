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

        public ActionResult RegisterNewAccount()
        {
            return View();
        }

        public ActionResult ManageAccounts()
        {
            List<RegisteredAccount> accounts = new List<RegisteredAccount>();

            //accounts.Add(new RegisteredAccount(
            //    "martin_v_atienza",
            //    "ATEIN, Atienza, Villa",
            //    DateTime.Parse("12/5/2020"),
            //    "default",
            //    "Lupon",
            //    "Barangay Secretary",
            //    false));

            accounts.Add(new RegisteredAccount(
                "john_v_dimailig",
                "DIMAILIG, John, Villa",
                DateTime.Parse("12/28/2020"),
                "martin_v_atienza",
                "Lupon",
                "Punong Barangay",
                false));

            accounts.Add(new RegisteredAccount(
                "lukas_d_martinez",
                "MARTINEZ, Lukas, Domingo",
                DateTime.Parse("01/5/2021"),
                "martin_v_atienza",
                "Sanguniang Barangay",
                "Sanguniang Barangay Member",
                false));

            accounts.Add(new RegisteredAccount(
                "chris_mol_m_dela_cruz",
                "DELA CRUZ, Chris Mol, Marasigan",
                DateTime.Parse("01/6/2021"),
                "john_v_dimailig",
                "Sanguniang Barangay",
                "Sanguniang Barangay Member",
                true));

            accounts.Add(new RegisteredAccount(
                "lukas_d_martinez",
                "ATIENZA, Lar Minong, Ochoa",
                DateTime.Parse("01/7/2021"),
                "john_v_dimailig",
                "Sanguniang Barangay",
                "Sanguniang Barangay Member",
                false));


            return View(accounts);
        }
    }
}