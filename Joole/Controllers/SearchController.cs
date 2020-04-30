using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Joole.Data;
using Joole.Service;



namespace Joole.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        [HttpGet]
        public ActionResult Search()
        {

            UserService serviceObj = new UserService();
            
            ViewBag.categories = serviceObj.GetCategories();
           
            return View();
        }

        public ActionResult SubCategory(int c)
        {
            return View("Login");
        }
    }
}