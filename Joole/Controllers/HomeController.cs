using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Joole.Data;
using Joole.Service;

namespace Joole.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(tblUser user)
        {
            UserService serviceObj = new UserService();
            serviceObj.AddUser(user);
            return View("Login");
        }


        [HttpPost]
        public ActionResult Login(tblUser user)
        {
            UserService serviceObj = new UserService();
            IEnumerable<tblUser> users = serviceObj.GetUsers();
            int index = -1;
            foreach (tblUser u in users)
            {
               if (u.UserEmail == user.UserName | u.UserName == user.UserName)
                {
                    index = u.UserId;

                }
            }
            if(index == -1) { return View("Login"); }
            tblUser userinfo = serviceObj.GetUserProfile(index);
            if (userinfo.UserPassword == user.UserPassword) { return RedirectToAction("Search", "Search"); }

            return View("Login"); 
        }


    }
}