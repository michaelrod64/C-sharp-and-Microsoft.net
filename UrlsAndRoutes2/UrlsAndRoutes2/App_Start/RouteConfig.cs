using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using UrlsAndRoutes2.Infrastructure;

namespace UrlsAndRoutes2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.Add(new LegacyRoute(
                "~/articles/Windows_3.1_Overview.html",
                "~/old/.NET_1.0_Class_Library"));

            routes.MapRoute("MyRoute", "{controller}/{action}s", null,
                new[] {"UrlsAndRoutes2.Controllers"});
            routes.MapRoute("MyOtherRoute", "App/{action}", 
                new { controller = "Home" }, new[] {"UrlsAndRoutes2.Controllers"});
   
        }
    }
}