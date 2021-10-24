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

        private readonly CategoryList categoryList;

        public HomeController()
        {
            this.categoryList = new CategoryList();
        }

        public ActionResult Index()
        {
            var inputViewModel = new CategoryInputViewModel();
            var categorylistViewModel = categoryList.GetCategoryViewModel();
            categorylistViewModel.ListViewModel = inputViewModel;
            return View(categorylistViewModel);
        }

        [HttpPost, ActionName("Index")]
        public ActionResult Index(CategoryViewModel inputViewModel)
        {

            if (ModelState.IsValid)
            {
                categoryList.Add(inputViewModel.ListViewModel);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index", inputViewModel);
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
        /// <summary>
        /// 製作假資料list
        /// </summary>
        /// <returns></returns>
        //public ActionResult Index()
        //{
        //    List<CategoryInputViewModel> categoryListViewModel = new List<CategoryInputViewModel>();
        //    var random = new Random();
        //    for (int i = 0; i < 100; i++)
        //    {
        //        CategoryInputViewModel category = new CategoryInputViewModel
        //        {
        //            Categories = (MoneyEnum)(random.Next(i) % 2),
        //            Date = DateTime.Now.AddDays(-i),
        //            Money = random.Next(i + 1000)
        //        };
        //        categoryListViewModel.Add(category);
        //        ViewBag.Category = categoryListViewModel;
        //    }
        //    return View();
        //}
    }
}