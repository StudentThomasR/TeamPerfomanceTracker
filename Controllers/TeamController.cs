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
        public ActionResult GetTeamAdd(int model)
        {
            Session["SelectedTeam"] = model;
            return RedirectToAction("AddMember", "Team");
        }
        public ActionResult GetTeamView(int model)
        {
            Session["SelectedTeam"] = model;
            return RedirectToAction("ViewTeamData", "Team");
        }
        public ActionResult GetUser(int model)
        {
            Session["SelectedUser"] = model;
            return RedirectToAction("AddMember1", "Team");
        }
        public ActionResult AddMember()
        {
            TPTEntities1 Db = new TPTEntities1();
            return View(Db.Users.ToList());
        }
        public ActionResult AddMember1()
        {
            _service.AddUserToTeam(Session["SelectedUser"].GetHashCode(), Session["SelectedTeam"].GetHashCode());
            return RedirectToAction("SMHomePage", "Home");
        }
        public ActionResult ViewTeamData()
        {
            TPTEntities1 Db = new TPTEntities1();
            int teamID = Session["SelectedTeam"].GetHashCode();
            Team currentTeam =_service.GetTeamDetails(teamID);
            ViewBag.CurrentTeam = currentTeam;
            return View(Db.Users.ToList());
        }
        public ActionResult CompareTeams()
        {
            return View();
        }
    }
}