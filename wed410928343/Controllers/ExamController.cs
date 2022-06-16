using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace wed410928343.Controllers
{
    public class ExamController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Exam
        public ActionResult About(float? A)
        {
            var result = "";
            if (A==1) {
                result = "星期一";
            }
            if (A == 2)
            {
                result = "星期二";
            }
            if (A == 3)
            {
                result = "星期三";
            }
            if (A == 4)
            {
                result = "星期四";
            }
            if (A == 5)
            {
                result = "星期五";
            }
            if (A == 6)
            {
                result = "星期六";
            }
            if (A == 7)
            {
                result = "星期日";
            }
            ViewBag.Result = result;
            return View();
        }
    }
}