using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace incident_reporting_web_application.Models.IncidentReportView
{
    public class IncidentReportList
    {
        //<td>Case #</td>
        //            <td> Title</td>
        //            <td>Incident Description</td> @*use... as the button for modal*@
        //            <td>Relief Description</td>
        //            <td>Date of Incident</td>
        //            <td>Processed By</td>
        //            <td>Date Processed</td>
        //            <td>Hearing Status</td>
        //            <td>Actions</td>

        public string CaseNo{ get; set; }
        public string CaseTitle { get; set; }
        public string IncidentDesc { get; set; }
        public string ReliefDesc { get; set; }
        public DateTime DateOfIncident { get; set; }
        public string ProcessedBy { get; set; }
        public DateTime DateProcessed { get; set; }
        public string HearingStatus { get; set; }

        public IncidentReportList(string caseNo, string caseTitle, string incidentDesc, string reliefDesc, DateTime dateOfIncident, string processedBy, DateTime dateProcessed, string hearingStatus)
        {
            CaseNo = caseNo;
            CaseTitle = caseTitle;
            IncidentDesc = incidentDesc;
            ReliefDesc = reliefDesc;
            DateOfIncident = dateOfIncident;
            ProcessedBy = processedBy;
            DateProcessed = dateProcessed;
            HearingStatus = hearingStatus;
        }
    }
}