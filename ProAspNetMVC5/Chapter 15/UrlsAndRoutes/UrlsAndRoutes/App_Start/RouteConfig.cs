using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using UrlsAndRoutes.Infrastructure;

namespace UrlsAndRoutes {
    public class RouteConfig {

        public static void RegisterRoutes(RouteCollection routes) {

            //routes.MapMvcAttributeRoutes();

            //routes.MapRoute("Default", "{controller}/{action}/{id}",
            //    new {
            //        controller = "Home", action = "Index",
            //        id = UrlParameter.Optional
            //    },
            //    new[] { "UrlsAndRoutes.Controllers" });

            //            Route myRoute = new Route("{controller}/{action}", new
            //MvcRouteHandler());
            //            routes.Add("MyRoute", myRoute);
            routes.MapRoute("Static1", "X{controller}/{action}", new { controller = "Admin", action = "index" });

            routes.MapRoute("MyRoute", "{controller}/{action}");

            routes.MapRoute("Default1", "{controller}/{action}", new { action = "Index" });

            routes.MapRoute("Default2", "{controller}/{action}", new { action = "Index", controller = "Admin" });

            //static mapping
            routes.MapRoute("Static", "public/{controller}/{action}", new { controller = "Admin", action = "index" });
            



        }
    }
}
