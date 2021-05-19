using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace incident_reporting_web_application.Models.KPForms
{
    public class ComplaintFormModel
    {
        [Required]
        [DisplayName("Description of Violation")]
        public string ViolationDesc { get; set; }

        [Required]
        [DisplayName("Relief/s Asked")]
        public string ReliefGrant { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [DisplayName("Date of Incident")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfIncident { get; set; }

    }
}