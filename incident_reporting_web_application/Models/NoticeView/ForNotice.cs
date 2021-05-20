using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace incident_reporting_web_application.Models.NoticeView
{
    public class ForNotice
    {
        public ForNotice(string caseNo, string caseTitle, DateTime dateReported, string processedBy, DateTime? hearingDate, List<string> notices)
        {
            CaseNo = caseNo;
            CaseTitle = caseTitle;
            DateReported = dateReported;
            ProcessedBy = processedBy;
            HearingDate = hearingDate;
            Notices = notices;
        }

        public string CaseNo { get; set; }
        public string CaseTitle { get; set; }
        public DateTime DateReported { get; set; }
        public string ProcessedBy { get; set; }
        public DateTime? HearingDate { get; set; }
        public List<string> Notices { get; set; }

    }
}