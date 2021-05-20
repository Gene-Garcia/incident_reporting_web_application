using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace incident_reporting_web_application.Models.NoticeView
{
    public class ScheduleSelection
    {
        public ScheduleSelection(string caseNo, string caseTitle, List<string> complainantsFullName, List<string> respondentsFullName, List<(DateTime, string)> scheduleTaken)
        {
            CaseNo = caseNo;
            CaseTitle = caseTitle;
            ComplainantsFullName = complainantsFullName;
            RespondentsFullName = respondentsFullName;
            ScheduleTaken = scheduleTaken;  
        }

        public string CaseNo { get; set; }
        public string CaseTitle { get; set; }
        public List<string> ComplainantsFullName { get; set; }
        public List<string> RespondentsFullName { get; set; }
        public List<(DateTime, string)> ScheduleTaken { get; set; }
    }
}