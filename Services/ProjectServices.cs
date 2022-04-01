using TeamPerfomanceTracker.Models;
using TeamPerfomanceTracker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Security;

namespace TeamPerfomanceTracker.Services
{
    public class ProjectServices : IProjectServices
    {
        private TPTEntities1 _context = null;
        public ProjectServices()
        {
            _context = new TPTEntities1();
        }
        public void SaveProjectToDB(CreateProjectViewModel model)
        {
            Project newProject = new Project();
            newProject.ProjectName = model.ProjectName;
            newProject.ClientName = model.ProjectName;
            newProject.Budget = model.Budget;
            model.TeamID = Convert.ToInt32(model.TeamID);
            Team TeamID = _context.Teams.SingleOrDefault(c => c.TeamName.Equals(model.TeamName));
            TeamID.TeamID = Convert.ToInt32(TeamID.TeamID);
            newProject.TeamID = TeamID.TeamID;
            _context.Projects.Add(newProject);
            _context.SaveChanges();
        }
        public int ChangeID(CreateProjectViewModel model)
        {
            return (Convert.ToInt32(model.TeamID));
        }
    }
    public interface IProjectServices
    {
        void SaveProjectToDB(CreateProjectViewModel model);
        int ChangeID(CreateProjectViewModel model);
    }
}