using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace incident_reporting_web_application.Models.Hearing
{
    public class Hearing
    {
        public Hearing(string caseNumber, string caseTitle, string hearingType, List<string> complainants, List<string> respondents, List<string> witness, DateTime hearingDate, DateTime dateOfIncident, DateTime dateReported)
        {
            CaseNumber = caseNumber;
            CaseTitle = caseTitle;
            HearingType = hearingType;
            Complainants = complainants;
            Respondents = respondents;
            Witness = witness;
            HearingDate = hearingDate;
            DateOfIncident = dateOfIncident;
            DateReported = dateReported;
        }

        public string CaseNumber { get; set; }
        public string CaseTitle { get; set; }
        public string HearingType { get; set; }
        public List<string> Complainants { get; set; }
        public List<string> Respondents { get; set; }
        public List<string> Witness { get; set; }
        public DateTime HearingDate { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateReported { get; set; }
    }
}