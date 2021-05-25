using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace incident_reporting_web_application.Models.Account
{
    public class RegisteredAccount
    {
        public RegisteredAccount(string username, string fullName, DateTime registeredOn, string registeredBy, string userType, string personnelPosition, bool disabled)
        {
            Username = username;
            FullName = fullName;
            RegisteredOn = registeredOn;
            RegisteredBy = registeredBy;
            UserType = userType;
            PersonnelPosition = personnelPosition;
            Disabled = disabled;
        }

        public string Username { get; set; }
        public string FullName { get; set; }
        public DateTime RegisteredOn { get; set; }
        public string RegisteredBy { get; set; }
        public string UserType { get; set; }
        public string PersonnelPosition { get; set; }
        public bool Disabled { get; set; }
    }
}