﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    public class ArchiveController : Controller
    {
        // GET: Archive
        public ActionResult Entry()
        {
            return View();
        }
    }
}