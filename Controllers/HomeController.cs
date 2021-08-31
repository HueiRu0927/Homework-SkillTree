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
            List<CategoryInputVM> categoryListVM = new List<CategoryInputVM>();
            var random = new Random();
            for (int i = 0; i < 100; i++)
            {
                CategoryInputVM category = new CategoryInputVM
                {
                    id = i + 1,
                    Categories = (MoneyEnum)(random.Next(i) % 2),
                    Date = DateTime.Now.AddDays(-i),
                    Money = random.Next(i + 1000)
                };
                categoryListVM.Add(category);
                ViewBag.Category = categoryListVM;
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