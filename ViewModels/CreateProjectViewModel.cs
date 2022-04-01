using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeamPerfomanceTracker.Models;

namespace TeamPerfomanceTracker.ViewModels
{
    public class CreateProjectViewModel
    {
        public string ProjectName { get; set; }
        public string ClientName { get; set; }
        public string Budget { get; set; }
        public string TeamName { get; set; }
        public Team Team { get; set; }
        public int TeamID { get; set; }
    }
}