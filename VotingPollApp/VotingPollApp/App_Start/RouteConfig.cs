using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VotingPollApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Dashboard",
               url: "Dashboard/{action}/{id}",
               defaults: new { controller = "Polls", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "Edit",
               url: "Edit-Poll/{action}/{id}",
               defaults: new { controller = "Polls", action = "Edit", id = UrlParameter.Optional }
           );
            routes.MapRoute(
              name: "Make-Poll",
              url: "Make-Poll/{action}/{id}",
              defaults: new { controller = "Polls", action = "Make", id = UrlParameter.Optional }
          );
            routes.MapRoute(
             name: "View-Poll",
             url: "View-Poll/{action}/{id}",
             defaults: new { controller = "Polls", action = "Results", id = UrlParameter.Optional }
         );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Polls", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
