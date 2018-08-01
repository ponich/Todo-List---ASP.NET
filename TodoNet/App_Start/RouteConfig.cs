﻿using System.Web.Mvc;
using System.Web.Routing;

namespace TodoNet
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new {controller = "Todo", action = "Index", id = UrlParameter.Optional}
            );
        }
    }
}