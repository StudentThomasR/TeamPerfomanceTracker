using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeamPerfomanceTracker.Models;

namespace TeamPerfomanceTracker.ViewModels
{
    public class CreateTeamViewModel
    {
        public string TeamName { get; set; }
        public User TeamLeader { get; set; }
        public List<User> TeamMembers { get; set; }
    }
}