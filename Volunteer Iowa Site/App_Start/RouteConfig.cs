﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Volunteer_Iowa_Site
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Logs",
                url: "{controller}/{action}/{userID}",
                defaults: new { controller = "Log", action = "Index", userID = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Search",
                url: "search/{*query}",
                defaults: new { controller = "Log", action = "Search" }
            );
        }
    }
}