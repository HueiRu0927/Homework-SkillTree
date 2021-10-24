using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework_SkillTree.Controllers
{
    public class ValidateController : Controller
    {
        // GET: Validate
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckDate([Bind(Prefix = "ListViewModel.Date")] DateTime Date)
        {
            var result = Date.CompareTo(DateTime.Now.Date);
            return Json(result < 0, JsonRequestBehavior.AllowGet);
        }

    }
}