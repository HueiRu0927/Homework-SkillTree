using Homework_SkillTree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework_SkillTree.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<CategoryInputViewModel> categoryListViewModel = new List<CategoryInputViewModel>();
            var random = new Random();
            for (int i = 0; i < 100; i++)
            {
                CategoryInputViewModel category = new CategoryInputViewModel
                {
                    id = i + 1,
                    Categories = (MoneyEnum)(random.Next(i) % 2),
                    Date = DateTime.Now.AddDays(-i),
                    Money = random.Next(i + 1000)
                };
                categoryListViewModel.Add(category);
                ViewBag.Category = categoryListViewModel;
            }
            return View();
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