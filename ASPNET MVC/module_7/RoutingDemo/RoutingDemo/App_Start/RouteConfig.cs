using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            // www.site.com/BlogPost/2019-05-12
            routes.MapRoute(
                            "Blog",
                            "BlogPost/{username}/{date}",
                            new { Controller = "Archive", Action = "Entry" });

            routes.MapRoute(
                            "Products",
                            "Products/{productId}",
                            new {Controller = "Products", Action = "Details"},
                            new {productId = @"^\d+$"});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

            );


        }
    }
}
