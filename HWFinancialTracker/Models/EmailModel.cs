using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HWFinancialTracker.Models
{
    //This is for generating Email notifications with a specific message. Such as "you spent $100 today on clothing")
    public class EmailModel
    {
        //Who the sender is (admin? the head of household?)
        [Required, Display(Name = "Name")]
        public string FromName { get; set; }

        //Email address of the sender
        [Required, Display(Name = "Email"), EmailAddress]
        public string FromEmail { get; set; }

        //Subject line of the email message
        [Required]
        public string Subject { get; set; }

        //content of the email message
        [Required]
        public string Body { get; set; }

    }
}