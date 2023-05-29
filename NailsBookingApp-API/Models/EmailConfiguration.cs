﻿using System.ComponentModel.DataAnnotations;

namespace NailsBookingApp_API.Models
{
    public class EmailConfiguration
    {
        [Required]
        public string From { get; set; }
        [Required]
        public string SmtpServer { get; set; }
        public int Port { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
