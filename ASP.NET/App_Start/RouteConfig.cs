using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP.NET
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Start",
                url: "Home/Root",
                    defaults: new { controller = "Home", action = "Root" }
            );
            routes.MapRoute(
              name: "Test3",
              url: "{something}/{*catchall}",
              defaults: new { controller = "Home", action = "GetFolder" }
              );            
            routes.MapRoute(
               name: "AnotherStart",
               url: "",
                   defaults: new { controller = "Home", action = "Root" }
           );
        }
    }
}
