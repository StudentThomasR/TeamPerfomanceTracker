using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamPerfomanceTracker.Models;
using TeamPerfomanceTracker.Services;
using TeamPerfomanceTracker.ViewModels;

namespace TeamPerfomanceTracker.Controllers
{
    public class ProjectController : Controller
    {
        private IProjectServices _service = null;
        public ProjectController(IProjectServices service)
        {
            _service = service;
        }
        // GET: Project
        public ActionResult CreateProject()
        {
            var Db = new TPTEntities1();
            var teams = Db.Teams.ToList();
            List<SelectListItem> teamNames = new List<SelectListItem>();
            foreach (Team item in teams)
            {
                teamNames.Add(new SelectListItem
                {
                    Text = item.TeamName,
                    Value = item.TeamName
                }); 
            }
            ViewBag.Teams = teamNames;
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(CreateProjectViewModel model)
        {
            _service.ChangeID(model);
            _service.SaveProjectToDB(model);
            return RedirectToAction("SMHomePage", "Home");
        }
    }
}