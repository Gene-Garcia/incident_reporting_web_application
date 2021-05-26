using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace incident_reporting_web_application.Models.IncidentReportView
{
    public class SettledReport
    {
        public SettledReport(string caseNumber, string caseTitle, string kPCase, string hearingType, DateTime dateOfAgreement, DateTime dateOfExecution, string agreement, string complianceStatus, string remarks)
        {
            CaseNumber = caseNumber;
            CaseTitle = caseTitle;
            KPCase = kPCase;
            HearingType = hearingType;
            DateOfAgreement = dateOfAgreement;
            DateOfExecution = dateOfExecution;
            Agreement = agreement;
            ComplianceStatus = complianceStatus;
            Remarks = remarks;
        }

        //public SettledReport(string caseNumber, string caseTitle, string kPCase, string hearingType, DateTime dateOfAgreement, string agreement)
        //{
        //    CaseNumber = caseNumber;
        //    CaseTitle = caseTitle;
        //    KPCase = kPCase;
        //    HearingType = hearingType;
        //    DateOfAgreement = dateOfAgreement;
        //    Agreement = agreement;
        //}

        public string CaseNumber { get; set; }
        public string CaseTitle { get; set; }
        public string KPCase { get; set; }
        public string HearingType { get; set; }
        public DateTime DateOfAgreement { get; set; }
        public DateTime DateOfExecution { get; set; }
        public string Agreement { get; set; }
        public string ComplianceStatus { get; set; }
        public string Remarks { get; set; }
    }
}