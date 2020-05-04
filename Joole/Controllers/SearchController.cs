using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Joole.Service;
using Joole.Models;
using Joole.Data;


namespace Joole.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Search()
        {
            var selectList = new UserService().GetCategories();
            ViewBag.CategoryName = selectList;
            //ViewBag.CategoryName = new SelectList(selectList,"CategoryId","CategoryName");
            return View();
        }

        public ActionResult SubmitSearch(int categoryId, int subCategoryId)
        {
            UserService serviceObj = new UserService();
            IEnumerable<tblProduct> p = serviceObj.GetResult(subCategoryId);
            var productmodel = new ProductModel
            {
                products = p
            };
            return View("Result", productmodel);
        }

        public ActionResult GetSubCategory(int categoryValue)
        {
            UserService serviceObj = new UserService();
            IEnumerable<tblSubCategory> subCategories = serviceObj.GetSubCategories();
            IEnumerable<tblSubCategory> result = subCategories.Where(x => x.CategoryId == categoryValue).ToList();
            return Json(result.Select(x => new { SubCategoryID= x.SubCategoryID, SubCategoryName = x.SubCategoryName }), JsonRequestBehavior.AllowGet);
        }


    }
}