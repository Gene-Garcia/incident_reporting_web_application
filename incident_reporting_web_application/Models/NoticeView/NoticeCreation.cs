using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace incident_reporting_web_application.Models.NoticeView
{
    public class NoticeCreation
    {
        public string CaseNo { get; set; }
        public string CaseTitle { get; set; }
        public List<string> ComplainantsFullName { get; set; }
        public List<string> RespondentsFullName { get; set; }
        public DateTime HearingDate { get; set; }
        public DateTime DateReported { get; set; }
        public string ProcessedBy { get; set; }
    }
}