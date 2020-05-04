using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Joole.Data;
using Joole.Service;
using Joole.Models;



namespace Joole.Controllers
{
    public class SearchControllercopy : Controller
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

        public ActionResult Result()
        {

            UserService serviceObj = new UserService();
            IEnumerable<tblProduct> p = serviceObj.GetProducts();
            var productmodel = new ProductModel
            {
                products = p
            };
            return View(productmodel);
        }
    }
}