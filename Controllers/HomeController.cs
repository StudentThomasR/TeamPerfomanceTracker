using TeamPerfomanceTracker.Models;
using TeamPerfomanceTracker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace TeamPerfomanceTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult SMHomePage()
        {
            TPTEntities1 Db = new TPTEntities1();
            return View(Db.Teams.ToList());
        }

        public ActionResult TLHomePage()
        {
            return View();
        }

        public ActionResult TMHomePage()
        {
            return View();
        }
        public ActionResult CreateMember()
        {
            return RedirectToAction("CreateMember", "Security");
        }
        public ActionResult CreateTeam()
        {
            return RedirectToAction("CreateTeam", "Team");
        }
        public ActionResult AddMember()
        {
            return RedirectToAction("AddMember", "Team");
        }
    }
}