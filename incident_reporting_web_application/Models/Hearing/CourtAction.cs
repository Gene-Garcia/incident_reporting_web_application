using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace incident_reporting_web_application.Models.Hearing
{
    public class CourtAction
    {
        public CourtAction(string caseNumber, string caseTitle, List<string> complainant, List<string> respondents, List<string> witness, DateTime hearingDate, string lastHearingType)
        {
            CaseNumber = caseNumber;
            CaseTitle = caseTitle;
            Complainant = complainant;
            Respondents = respondents;
            Witness = witness;
            HearingDate = hearingDate;
            LastHearingType = lastHearingType;
        }

        public string CaseNumber { get; set; }
        public string CaseTitle { get; set; }
        public List<string> Complainant { get; set; }
        public List<string> Respondents { get; set; }
        public List<string> Witness { get; set; }
        public DateTime HearingDate { get; set; }
        public string LastHearingType { get; set; }


    }
}