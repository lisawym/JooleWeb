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
        public ActionResult Search()
        {

            UserService serviceObj = new UserService();
            IEnumerable<tblCategory> Categories= serviceObj.GetCategories();

            return View();
        }
    }
}