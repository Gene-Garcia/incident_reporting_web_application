using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace incident_reporting_web_application.Models.Account
{
    public class AccountInfo
    {
        public AccountInfo(string firstName, string middleName, string lastName, string username, string userType, string personnelPosition)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Username = username;
            UserType = userType;
            PersonnelPosition = personnelPosition;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string UserType { get; set; }
        public string PersonnelPosition { get; set; }

        [Required]
        [Display(Name = "Old Password")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [Required]
        [Display( Name = "New Password")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [Compare("NewPassword")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}