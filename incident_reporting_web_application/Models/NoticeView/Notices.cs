using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace incident_reporting_web_application.Models.NoticeView
{
    public class IncidentReport
    {
        public IncidentReport(string caseNo, string caseTitle, string hearingType, DateTime hearingDate, List<ReportNotice> notices)
        {
            CaseNo = caseNo;
            CaseTitle = caseTitle;
            HearingType = hearingType;
            HearingDate = hearingDate;
            Notices = notices;
        }

        public string CaseNo { get; set; }
        public string CaseTitle { get; set; }
        public string HearingType { get; set; }
        public DateTime HearingDate { get; set; }

        public List<ReportNotice> Notices { get; set; }

    }

    public class ReportNotice
    {
        public ReportNotice(string noticeType, List<string> residentNames, string noticeStatus)
        {
            NoticeType = noticeType;
            ResidentNames = residentNames;
            NoticeStatus = noticeStatus;
        }
        public ReportNotice(string noticeType, List<string> residentNames, string noticeStatus, DateTime dateNotified)
        {
            NoticeType = noticeType;
            ResidentNames = residentNames;
            NoticeStatus = noticeStatus;
            DateNotified = dateNotified;
        }

        public string NoticeType { get; set; }
        public List<string> ResidentNames { get; set; }
        public string NoticeStatus { get; set; }
        public DateTime DateNotified { get; set; }
    }
}