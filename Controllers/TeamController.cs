using TeamPerfomanceTracker.Models;
using TeamPerfomanceTracker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TeamPerfomanceTracker.Services;


namespace TeamPerfomanceTracker.Controllers
{
    public class TeamController : Controller
    {
        int userID = 999;
        int teamID = 999;

        private ITeamServices _service = null;
        public TeamController(ITeamServices service)
        {
            _service = service;
        }
        // GET: Team
        public ActionResult CreateTeam()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTeam(CreateTeamViewModel model)
        {
            _service.SaveTeamToDb(model);
            return RedirectToAction("SMHomePage", "Home");
        }
        public ActionResult GetTeam(int model)
        {
            teamID = model;
            return RedirectToAction("AddMember", "Team");
        }
        public ActionResult GetUser(int model)
        {
            userID = model;
            return RedirectToAction("AddMember1", "Team");
        }
        public ActionResult AddMember()
        {
            TPTEntities1 Db = new TPTEntities1();
            return View(Db.Users.ToList());
        }
        public ActionResult AddMember1()
        {
            _service.AddUserToTeam(userID, teamID);
            return RedirectToAction("SMHomePage", "Home");
        }
    }
}