using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Details(int productId)
        {
            return View();
        }
    }
}