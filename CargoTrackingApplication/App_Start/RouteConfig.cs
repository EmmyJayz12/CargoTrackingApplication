using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CargoTrackingApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           /* routes.MapRoute(
            name: "ClientUpdate",
            url: "admin/clientupdate/{id}",
            defaults: new { controller = "Admin", action = "clientupdate"}
           );*/

            routes.MapRoute(
            name: "Edit",
            url: "admin/edit/{id}",
            defaults: new { controller = "Admin", action = "Edit" }
           );

            routes.MapRoute(
            name: "Delete",
            url: "admin/delete/{id}",
            defaults: new { controller = "Admin", action = "Delete" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
