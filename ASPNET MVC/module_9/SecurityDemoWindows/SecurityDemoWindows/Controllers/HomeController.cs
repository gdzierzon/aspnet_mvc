using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityDemoWindows.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string someText = "<bold>XSS test</bold>";

            ViewBag.one = someText;

            return View();
        }
        
    }
}