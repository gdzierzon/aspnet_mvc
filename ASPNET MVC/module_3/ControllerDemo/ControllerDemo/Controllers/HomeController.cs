using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int? number1, int? number2, string choice)
        {
            //default numbers to 0 if null
            number1 = number1 ?? 0;
            number2 = number2 ?? 0;

            ViewBag.Number1 = number1;
            ViewBag.Number2 = number2;

            if (choice == "Add")
            {
                ViewBag.Answer = number1 + number2;
                ViewBag.Operation = "+";
            }
            else
            {
                ViewBag.Answer = number1 - number2;
                ViewBag.Operation = "-";
            }

            return View("Result");
        }

        public ActionResult Location()
        {
            return RedirectToAction("Index","Books");
        }


    }
}