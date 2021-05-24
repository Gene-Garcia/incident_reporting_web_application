using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace incident_reporting_web_application.Models.Hearing
{
    public class ForHearing
    {
        public ForHearing(string caseNumber, string title, List<string> complainants, List<string> respondents, List<string> witnesses, DateTime hearingDate, bool needRequirement)
        {
            CaseNumber = caseNumber;
            CaseTitle = title;
            Complainants = complainants;
            Respondents = respondents;
            Witnesses = witnesses;
            HearingDate = hearingDate;
            NeedRequirement = needRequirement;
        }

        public string CaseNumber { get; set; }
        public string CaseTitle { get; set; }
        public List<string> Complainants { get; set; }
        public List<string> Respondents { get; set; }
        public List<string> Witnesses { get; set; }
        public DateTime HearingDate { get; set; }
        public bool NeedRequirement { get; set; }

    }
}