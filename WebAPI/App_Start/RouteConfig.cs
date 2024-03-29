﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAPI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "PODETAIL",
            //    url: "PODETAIL/{action}/{id}/{itcode}",
            //    defaults: new { controller = "PODETAIL", action = "Index", id = UrlParameter.Optional,itcode = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "ITEM", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
