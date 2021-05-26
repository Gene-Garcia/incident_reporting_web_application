using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace incident_reporting_web_application.Models
{
    public class LoginModel
    {
        [DisplayName("Username")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}