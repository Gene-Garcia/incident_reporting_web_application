using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace incident_reporting_web_application.Models.AuditTrail
{
    public class AuditTrail
    {
        public AuditTrail(DateTime dateRecorded, string description, string username, string module)
        {
            DateRecorded = dateRecorded;
            Description = description;
            Username = username;
            Module = module;
        }

        public DateTime DateRecorded { get; set; }
        public string Description { get; set; }
        public string Username { get; set; }
        public string Module { get; set; }

    }
}