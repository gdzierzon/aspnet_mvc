﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionDemo.Controllers
{
    public class HomeController : Controller
    {
        private List<string> myList;

        public HomeController()
        {
            //myList = Session["list"] as List<string>;
            //if (myList == null)
            //{
            //    myList = new List<string>();
            //    Session["list"] = myList;
            //}
        }

        public ActionResult Index()
        {

            HttpCookie cookie = Request.Cookies["item"];
            if (cookie != null)
            {
                ViewBag.Item = cookie.Value;
            }
            else
            {
                ViewBag.Item = "not set";
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
            HttpCookie myCookie = new HttpCookie("item");
            myCookie.Value = item;
            Response.Cookies.Add(myCookie);

            //myList.Add(item);
            return RedirectToAction("Index");
        }

        
    }
}