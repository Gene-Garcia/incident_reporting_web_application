using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace incident_reporting_web_application.Models.IncidentReportView
{
    public class IncidentReportSummary
    {
        public IncidentReportSummary(string caseNo, string caseTitle, List<string> complainantsFullName, List<string> respondentsFullName, string incidentDesc, DateTime hearingDate, string hearingStatus, string finalAgreement, DateTime dateSettled, DateTime dateOfIncident, DateTime dateReported, string processedBy)
        {
            CaseNo = caseNo;
            CaseTitle = caseTitle;
            ComplainantsFullName = complainantsFullName;
            RespondentsFullName = respondentsFullName;
            IncidentDesc = incidentDesc;
            HearingDate = hearingDate;
            HearingStatus = hearingStatus;
            FinalAgreement = finalAgreement;
            DateSettled = dateSettled;
            DateOfIncident = dateOfIncident;
            DateReported = dateReported;
            ProcessedBy = processedBy;
        }

        public string CaseNo { get; set; }
        public string CaseTitle { get; set; }
        public List<string> ComplainantsFullName { get; set; }
        public List<string> RespondentsFullName { get; set; }
        public string IncidentDesc { get; set; }
        public DateTime HearingDate { get; set; }
        public string HearingStatus { get; set; }
        public string FinalAgreement { get; set; }
        public DateTime DateSettled { get; set; }

        public DateTime DateOfIncident { get; set; }
        public DateTime DateReported { get; set; }
        public string ProcessedBy { get; set; }

    }
}