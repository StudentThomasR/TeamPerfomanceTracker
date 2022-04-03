using TeamPerfomanceTracker.Models;
using TeamPerfomanceTracker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TeamPerfomanceTracker.Services
{
    public class TeamServices : ITeamServices
    {
        private TPTEntities1 _context = null;
        public TeamServices()
        {
            _context = new TPTEntities1();
        }
        public void SaveTeamToDb(CreateTeamViewModel model)
        {
            Team team = new Team();
            team.TeamName = model.TeamName;

            _context.Teams.Add(team);
            _context.SaveChanges();
        }
        public void AddUserToTeam(int user, int team)
        {
            User currentUser = _context.Users.Find(user);
            Team currentTeam = _context.Teams.Find(team);
            currentUser.TeamID = team;
            currentTeam.Id = user;

            _context.SaveChanges();

        }
        public Team GetTeamDetails(int team)
        {
            Team currentTeam = _context.Teams.Find(team);
            return (currentTeam);
        }
    }

    public interface ITeamServices
    {
        void SaveTeamToDb(CreateTeamViewModel model);
        void AddUserToTeam(int user, int team);
        Team GetTeamDetails(int team);
    }
}