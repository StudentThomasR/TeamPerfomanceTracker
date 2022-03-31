using TeamPerfomanceTracker.Models;
using TeamPerfomanceTracker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TeamPerfomanceTracker.Services
{
    public class SecurityServices : ISercurityService
    {
        private TPTEntities1 _context = null;
        public SecurityServices()
        {
            _context = new TPTEntities1();
        }

        public bool IsValidUser(LogonViewModel model)
        {
            User user = null;
            user = _context.Users.SingleOrDefault(c => c.UserID.Equals(model.ID) && c.Password.Equals(model.Password));
            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string GetAccountType(LogonViewModel model)
        {
            User user = null;
            user = _context.Users.SingleOrDefault(c => c.UserID.Equals(model.ID) && c.Password.Equals(model.Password));
            return (user.AccType);
        }

        public void SaveUserToDB(CreateMemberViewModel model)
        {
            User userDetails = new User();
            userDetails.UserID = model.UserID;
            userDetails.FirstName = model.FirstName;
            userDetails.LastName = model.LastName;
            userDetails.Password = model.Password;
            userDetails.AccType = model.AccType;

            _context.Users.Add(userDetails);
            _context.SaveChanges();
        }
    }

    public interface ISercurityService
    {
        bool IsValidUser(LogonViewModel model);
        string GetAccountType(LogonViewModel model);
        void SaveUserToDB(CreateMemberViewModel model);
    }
}
