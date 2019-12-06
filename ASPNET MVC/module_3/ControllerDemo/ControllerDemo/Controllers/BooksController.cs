using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerDemo.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        //http://localhost:4221/Books
        //http://localhost:4221/Books/Index
        public ActionResult Index(bool isCustom = false)
        {
            if (isCustom)
            {
                return View("CustomIndex");
            }

            return View();
        }

        //http://localhost:4221/Books/Details/52
        public ActionResult Details(int id)
        {
            //ViewData["id"] = id;
            ViewBag.id = id;
            return View();
        }

        public ActionResult PriceList()
        {
            return File("~/Contents/PriceList.pdf", "application/pdf", "Prices.pdf");
        }

        [NonAction]
        public string GetMessage(int id)
        {
            string message = "";
            switch (id)
            {
                case 1:
                    message = "Book out of stock";
                    break;
            }

            return message;
        }
    }
}