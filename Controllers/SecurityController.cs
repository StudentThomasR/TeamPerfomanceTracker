using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamPerfomanceTracker.Services;
using TeamPerfomanceTracker.ViewModels;
using System.Web.Security;
using TeamPerfomanceTracker.Models;

namespace TeamPerfomanceTracker.Controllers
{
    public class SecurityController : Controller
    {
        private ISercurityService _service = null;
        public SecurityController(ISercurityService service)
        {
            _service = service;
        }
        // GET: Security
        public ActionResult Logon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logon(LogonViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_service.IsValidUser(model))
                {
                    string AccountType = _service.GetAccountType(model);
                    User currentUser = _service.GetsUserInfo(model);
                    Session["UserID"] = currentUser.UserID;
                    Session["FirstName"] = currentUser.FirstName;
                    Session["LastName"] = currentUser.LastName;
                    Session["TeamID"] = currentUser.TeamID;
                    Session["TeamName"] = _service.GetUserTeam(currentUser.TeamID);
                    if (AccountType == "SystemManager")
                    {
                        return RedirectToAction("SMHomePage", "Home");
                    }
                    else if (AccountType == "TeamLeader")
                    {
                        return RedirectToAction("TLHomePage", "Home");
                    }
                    else if (AccountType == "TeamMember")
                    {
                        return RedirectToAction("TMHomePage", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Username or Password");
                }
            }
            return View(model);
        }

        public ActionResult CreateMember()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateMember(CreateMemberViewModel model)
        {
            _service.SaveUserToDB(model);
            return RedirectToAction("SMHomePage", "Home");
        }
    }
}