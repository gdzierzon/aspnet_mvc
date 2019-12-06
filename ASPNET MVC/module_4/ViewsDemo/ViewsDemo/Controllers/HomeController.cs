using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Item = "Backpack";
            ViewBag.Cost = 199.95m;
            ViewBag.PaymentMethod = "MasterCard";
            ViewBag.Card = "5466000000000000";
            ViewBag.Expiration = "07/20";

            ViewBag.Names = new string[] {"Greg","Mary","Cindy","Wendy","Patty"};


            return View();
        }

        [HttpPost]
        public ActionResult Index(int? id)
        {
            return View();
        }

        public ActionResult Demo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Demo(string firstName)
        {
            return View();
        }

    }
}