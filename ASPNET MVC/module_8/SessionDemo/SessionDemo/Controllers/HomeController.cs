using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //reading a cookie demo
            HttpCookie cookie = Request.Cookies["item"];
            if (cookie != null)
            {
                ViewBag.Item = cookie.Value;
            }
            else
            {
                ViewBag.Item = "not set";
            }

            //reading from session
            var myList = Session["list"] as List<string>;
            if (myList == null)
            {
                myList = new List<string>();
                Session["list"] = myList;
            }

            return View(myList);
        }

        public ActionResult AddItem()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddItem(string item)
        {
            //writing to cookie
            HttpCookie myCookie = new HttpCookie("item");
            myCookie.Value = item;
            Response.Cookies.Add(myCookie);

            //writing to session
            var myList = Session["list"] as List<string>;
            if (myList == null)
            {
                myList = new List<string>();
                Session["list"] = myList;
            }
            myList.Add(item);


            return RedirectToAction("Index");
        }

        
    }
}