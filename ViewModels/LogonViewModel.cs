using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamPerfomanceTracker.ViewModels
{
    public class LogonViewModel
    {
        [Required]
        public string ID { get; set; }

        [Required]
        public string Password { get; set; }
    }
}