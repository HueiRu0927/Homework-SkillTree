using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homework_SkillTree.Models;
using Homework_SkillTree.Service;
using Homework_SkillTree.ViewModel;

namespace Homework_SkillTree.Controllers
{
    public class HomeController : Controller
    {

        private readonly CategoryListService categoryList;

        public HomeController()
        {
            this.categoryList = new CategoryListService();
        }

        public ActionResult Index()
        {
            var inputViewModel = new CategoryInputViewModel();
            return View(inputViewModel);
        }

        [HttpPost]
        public ActionResult Index(CategoryInputViewModel inputViewModel)
        {

            if (ModelState.IsValid)
            {
                categoryList.Add(inputViewModel);
                categoryList.Save();
                return RedirectToAction("Index");
            }
            return View(inputViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        } 
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
    }
}